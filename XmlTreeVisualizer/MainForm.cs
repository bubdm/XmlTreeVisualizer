using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MindFusion.Diagramming;
using MindFusion.Diagramming.Layout;
using MindFusion.Diagramming.WinForms;
using Brush = MindFusion.Drawing.Brush;

namespace XmlTreeViewer
{
    public partial class MainForm : Form
    {
        /// These objects are for tree visualization
        private readonly Random random = new Random();
        private readonly RectangleF nodeBounds = new RectangleF(0, 0, 40, 20);
        private readonly Brush rootBrush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(124, 139, 193));
        private readonly Brush nodeBrush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(139, 180, 229));
        private readonly Brush leafBrush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(185, 200, 255));
        private readonly Brush attrBrush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(200, 230, 255));

        /// <summary>
        /// Initializes all window controls and creates a random tree on diagram
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ShapeNode root = MainDiagram.Factory.CreateShapeNode(nodeBounds);
            RandomTree(root, 4, 4);
            Arrange(MainDiagramView);
        }

                /// <summary>
        /// Recursively iterate through all nodes starting from root
        /// and draw them on diagram associated with diagramRoot
        /// </summary>
        /// <param name="xmlRoot">The root to start from (usually the root of XML document)</param>
        /// <param name="diagramRoot"></param>
        private void ProcessNode(XmlNode xmlRoot, DiagramNode diagramRoot)
        {
            Diagram diagram = diagramRoot.Parent;

            foreach (XmlNode xmlChild in xmlRoot.ChildNodes)
            {
                if (xmlChild.NodeType != XmlNodeType.Text)
                {
                    ShapeNode diagramChild = XmlToShapeNode(xmlChild, diagram);
                    diagram.Factory.CreateDiagramLink(diagramRoot, diagramChild);
                    ProcessNode(xmlChild, diagramChild);
                }
                else if (!string.IsNullOrWhiteSpace(xmlChild.InnerText))
                {
                    ShapeNode diagramTextChild = diagram.Factory.CreateShapeNode(nodeBounds);
                    diagramTextChild.Brush = attrBrush;
                    diagramTextChild.Text = Regex.Replace(xmlChild.InnerText, @"\s+", " ");
                    diagram.Factory.CreateDiagramLink(diagramRoot, diagramTextChild);
                }
            }
        }

        /// <summary>
        /// Converts XmlNode into its visual representation as a ShapeNode (does not draw child nodes, only )
        /// </summary>
        /// <param name="xmlNode">XmlNode to be visualized</param>
        /// <param name="diagram">Diagram to place ShapeNode on</param>
        /// <returns>ShapeNode with information about XmlNode</returns>
        private ShapeNode XmlToShapeNode(XmlNode xmlNode, Diagram diagram)
        {
            ShapeNode resultNode = diagram.Factory.CreateShapeNode(nodeBounds);
            
            if (xmlNode.Attributes != null)
                foreach (XmlAttribute attr in xmlNode.Attributes)
                {
                    ShapeNode attrNode = diagram.Factory.CreateShapeNode(nodeBounds);
                    attrNode.Text = $"{attr.Name}={attr.Value}";
                    attrNode.Brush = leafBrush;
                    diagram.Factory.CreateDiagramLink(resultNode, attrNode);
                }
            
            resultNode.EnableStyledText = true;
            resultNode.Text = $"<b>{xmlNode.Name}</b>";
            resultNode.Brush = nodeBrush;

            return resultNode;
        }

        /// <summary>
        /// Creates a tree with random elements
        /// </summary>
        /// <param name="root">Root of tree to start from</param>
        /// <param name="depth">Depth of generated tree</param>
        /// <param name="maxChildren">Max amount of children from any parent element
        /// (parent will have from 1 to maxChildren children)</param>
        void RandomTree(DiagramNode root, int depth, int maxChildren)
        {
            if (depth <= 0) return;

            Diagram dgm = root.Parent;
            int childrenAmount = random.Next(1, maxChildren);

            for (int i = 0; i < childrenAmount; ++i)
            {
                ShapeNode child = dgm.Factory.CreateShapeNode(nodeBounds);
                dgm.Factory.CreateDiagramLink(root, child);
                
                RandomTree(child, depth - 1, maxChildren);
            }
        }

        /// <summary>
        /// Arranges a tree on diagram to look pretty
        /// </summary>
        /// <param name="diagramView">DiagramView to arrange</param>
        private void Arrange(DiagramView diagramView)
        {
            var layout = new TreeLayout {KeepRootPosition = true, Direction = TreeLayoutDirections.TopToBottom};
            layout.Arrange(diagramView.Diagram);
            
            diagramView.Diagram.ResizeToFitItems(5);
            diagramView.ZoomToFit();
        }

        /// <summary>
        /// Opens dialog to save a downloaded file
        /// </summary>
        private async void DownloadXmlBtn_Click(object sender, EventArgs e)
        {
            if (!Uri.TryCreate(UriTextbox.Text, UriKind.Absolute, out Uri uriToRawFile))
                return;
            
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                var file = new FileInfo(saveFileDialog.FileName);
                await DownloadFileAsync(file, uriToRawFile);
                
                if (string.IsNullOrEmpty(chooseFileDialog.FileName))
                {
                    ChosenFileLink.Text = file.Name;
                    chooseFileDialog.FileName = file.FullName;
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, @"Unable to download", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Unable to save a file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads an XML document asynchronously and then
        /// synchronously renders the document in tree view
        /// </summary>
        private async void DrawTreeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chooseFileDialog.FileName))
                return;

            try
            {
                var file = new FileInfo(chooseFileDialog.FileName);
                if (file.Length > 100000)
                {
                    var dialogResult = MessageBox.Show(
                        @"You are trying to process a large file, it may take a very long time. Are you sure?",
                        @"File is very large", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.No)
                        return;
                }

                var xmlRoot = await Task.Run(() =>
                {
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(chooseFileDialog.FileName);
                    return xmlDoc.DocumentElement;
                });

                MainDiagram.ClearAll();
                var diagramRoot = MainDiagram.Factory.CreateShapeNode(nodeBounds);
                diagramRoot.EnableStyledText = true;
                diagramRoot.Text = $"<b>{xmlRoot.Name}</b>";
                diagramRoot.Brush = rootBrush;
                
                ProcessNode(xmlRoot, diagramRoot);
                Arrange(MainDiagramView);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message,
                    @"Cannot open chosen file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (XmlException ex)
            {
                MessageBox.Show($@"Error in '{chooseFileDialog.FileName}': {ex.Message}",
                    @"XML file is not valid",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens dialog window to choose a file
        /// </summary>
        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            chooseFileDialog.ShowDialog();

            if (string.IsNullOrEmpty(chooseFileDialog.FileName))
                return;

            var file = new FileInfo(chooseFileDialog.FileName);

            if (file.Exists)
            {
                ChosenFileLink.Text = file.Name;
            }
        }

        /// <summary>
        /// Opens chosen file in notepad
        /// </summary>
        private void ChosenFileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(chooseFileDialog.FileName))
                return;
            
            var file = new FileInfo(chooseFileDialog.FileName);

            if (file.Exists)
            {
                try
                {
                    Process.Start("notepad.exe", file.FullName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Unable to open file in notepad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Downloads a file and shows a progress on ProgressBar
        /// </summary>
        /// <param name="file">File to save to</param>
        /// <param name="uri">URI to download from</param>
        private Task DownloadFileAsync(FileInfo file, Uri uri)
        {
            using (var wc = new WebClient())
            {
                DownloadBar.Value = 0;
                DownloadBar.Visible = DownloadBar.Enabled = true;
                DownloadingLabel.Visible = DownloadingLabel.Enabled = true;

                wc.DownloadProgressChanged += (s, eventArgs) => { DownloadBar.Value = eventArgs.ProgressPercentage; };
                wc.DownloadFileCompleted += async (s, eventArgs) =>
                {
                    await Task.Delay(1000);
                    DownloadBar.Visible = DownloadBar.Enabled = false;
                    DownloadingLabel.Visible = DownloadingLabel.Enabled = false;
                };

                return wc.DownloadFileTaskAsync(uri, file.FullName);
            }
        }

        /// <summary>
        /// Adds a handler to zoom diagram using mouse scroll
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainDiagramView.MouseWheel += (s, mouseEvent) =>
            {
                ZoomControl.ZoomFactor += mouseEvent.Delta / 5.0f;
            };
        }
        
        /// <summary>
        /// Fits diagram scale to window size
        /// </summary>
        private void MainForm_Resize(object sender, EventArgs e)
        {
            MainDiagramView.ZoomToFit();
        }
    }
}
