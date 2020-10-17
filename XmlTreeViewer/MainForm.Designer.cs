namespace XmlTreeViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ChooseFilePanel = new System.Windows.Forms.Panel();
            this.ChosenFileLink = new System.Windows.Forms.LinkLabel();
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.ParseTreeBtn = new System.Windows.Forms.Button();
            this.DownloadFilePanel = new System.Windows.Forms.Panel();
            this.UriTextbox = new System.Windows.Forms.TextBox();
            this.DownloadBar = new System.Windows.Forms.ProgressBar();
            this.DownloadXmlBtn = new System.Windows.Forms.Button();
            this.DownloadingLabel = new System.Windows.Forms.Label();
            this.VisualizePanel = new System.Windows.Forms.Panel();
            this.MainDiagramView = new MindFusion.Diagramming.WinForms.DiagramView();
            this.MainDiagram = new MindFusion.Diagramming.Diagram();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ZoomControl = new MindFusion.Common.WinForms.ZoomControl();
            this.MainLayout.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.ControlsLayout.SuspendLayout();
            this.ChooseFilePanel.SuspendLayout();
            this.DownloadFilePanel.SuspendLayout();
            this.VisualizePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Controls.Add(this.ControlPanel, 1, 0);
            this.MainLayout.Controls.Add(this.VisualizePanel, 0, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(827, 511);
            this.MainLayout.TabIndex = 0;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.ControlsLayout);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPanel.Location = new System.Drawing.Point(655, 3);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(169, 505);
            this.ControlPanel.TabIndex = 3;
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.ColumnCount = 1;
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ControlsLayout.Controls.Add(this.ChooseFilePanel, 0, 0);
            this.ControlsLayout.Controls.Add(this.ParseTreeBtn, 0, 2);
            this.ControlsLayout.Controls.Add(this.DownloadFilePanel, 0, 1);
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(0, 0);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 3;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ControlsLayout.Size = new System.Drawing.Size(167, 503);
            this.ControlsLayout.TabIndex = 5;
            // 
            // ChooseFilePanel
            // 
            this.ChooseFilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChooseFilePanel.Controls.Add(this.ChosenFileLink);
            this.ChooseFilePanel.Controls.Add(this.ChooseFileBtn);
            this.ChooseFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseFilePanel.Location = new System.Drawing.Point(3, 3);
            this.ChooseFilePanel.Name = "ChooseFilePanel";
            this.ChooseFilePanel.Size = new System.Drawing.Size(161, 58);
            this.ChooseFilePanel.TabIndex = 6;
            // 
            // ChosenFileLink
            // 
            this.ChosenFileLink.AutoSize = true;
            this.ChosenFileLink.Font = new System.Drawing.Font("Candara", 9F);
            this.ChosenFileLink.Location = new System.Drawing.Point(6, 3);
            this.ChosenFileLink.Name = "ChosenFileLink";
            this.ChosenFileLink.Size = new System.Drawing.Size(107, 14);
            this.ChosenFileLink.TabIndex = 5;
            this.ChosenFileLink.TabStop = true;
            this.ChosenFileLink.Text = "<file is not chosen>";
            this.ChosenFileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChosenFileLink_LinkClicked);
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.Font = new System.Drawing.Font("Candara", 9F);
            this.ChooseFileBtn.Location = new System.Drawing.Point(4, 22);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(153, 28);
            this.ChooseFileBtn.TabIndex = 4;
            this.ChooseFileBtn.Text = "Choose file";
            this.ChooseFileBtn.UseVisualStyleBackColor = true;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // ParseTreeBtn
            // 
            this.ParseTreeBtn.Font = new System.Drawing.Font("Candara", 9F);
            this.ParseTreeBtn.Location = new System.Drawing.Point(3, 470);
            this.ParseTreeBtn.Name = "ParseTreeBtn";
            this.ParseTreeBtn.Size = new System.Drawing.Size(161, 30);
            this.ParseTreeBtn.TabIndex = 5;
            this.ParseTreeBtn.Text = "Draw XML tree";
            this.ParseTreeBtn.UseVisualStyleBackColor = true;
            this.ParseTreeBtn.Click += new System.EventHandler(this.RenderTreeBtn_Click);
            // 
            // DownloadFilePanel
            // 
            this.DownloadFilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DownloadFilePanel.Controls.Add(this.ZoomControl);
            this.DownloadFilePanel.Controls.Add(this.UriTextbox);
            this.DownloadFilePanel.Controls.Add(this.DownloadBar);
            this.DownloadFilePanel.Controls.Add(this.DownloadXmlBtn);
            this.DownloadFilePanel.Controls.Add(this.DownloadingLabel);
            this.DownloadFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownloadFilePanel.Location = new System.Drawing.Point(3, 67);
            this.DownloadFilePanel.Name = "DownloadFilePanel";
            this.DownloadFilePanel.Size = new System.Drawing.Size(161, 397);
            this.DownloadFilePanel.TabIndex = 7;
            // 
            // UriTextbox
            // 
            this.UriTextbox.Font = new System.Drawing.Font("Candara", 9F);
            this.UriTextbox.Location = new System.Drawing.Point(4, 6);
            this.UriTextbox.Name = "UriTextbox";
            this.UriTextbox.Size = new System.Drawing.Size(152, 22);
            this.UriTextbox.TabIndex = 6;
            this.UriTextbox.Text = "https://raw.githubusercontent.com/kizeevov/elcomplusfiles/main/config.xml";
            // 
            // DownloadBar
            // 
            this.DownloadBar.Enabled = false;
            this.DownloadBar.Location = new System.Drawing.Point(5, 83);
            this.DownloadBar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 10);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.Size = new System.Drawing.Size(152, 23);
            this.DownloadBar.TabIndex = 2;
            this.DownloadBar.Visible = false;
            // 
            // DownloadXmlBtn
            // 
            this.DownloadXmlBtn.FlatAppearance.BorderSize = 0;
            this.DownloadXmlBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadXmlBtn.ForeColor = System.Drawing.Color.Black;
            this.DownloadXmlBtn.Location = new System.Drawing.Point(3, 29);
            this.DownloadXmlBtn.Name = "DownloadXmlBtn";
            this.DownloadXmlBtn.Size = new System.Drawing.Size(153, 27);
            this.DownloadXmlBtn.TabIndex = 1;
            this.DownloadXmlBtn.Text = "Download file";
            this.DownloadXmlBtn.UseVisualStyleBackColor = true;
            this.DownloadXmlBtn.Click += new System.EventHandler(this.DownloadXmlBtn_Click);
            // 
            // DownloadingLabel
            // 
            this.DownloadingLabel.AutoSize = true;
            this.DownloadingLabel.Enabled = false;
            this.DownloadingLabel.Font = new System.Drawing.Font("Candara", 9F);
            this.DownloadingLabel.Location = new System.Drawing.Point(4, 65);
            this.DownloadingLabel.Margin = new System.Windows.Forms.Padding(3, 55, 3, 0);
            this.DownloadingLabel.Name = "DownloadingLabel";
            this.DownloadingLabel.Size = new System.Drawing.Size(86, 14);
            this.DownloadingLabel.TabIndex = 3;
            this.DownloadingLabel.Text = "Downloading...";
            this.DownloadingLabel.Visible = false;
            // 
            // VisualizePanel
            // 
            this.VisualizePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisualizePanel.Controls.Add(this.MainDiagramView);
            this.VisualizePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisualizePanel.Location = new System.Drawing.Point(3, 3);
            this.VisualizePanel.Name = "VisualizePanel";
            this.VisualizePanel.Size = new System.Drawing.Size(646, 505);
            this.VisualizePanel.TabIndex = 4;
            // 
            // MainDiagramView
            // 
            this.MainDiagramView.Diagram = this.MainDiagram;
            this.MainDiagramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDiagramView.LicenseKey = null;
            this.MainDiagramView.Location = new System.Drawing.Point(0, 0);
            this.MainDiagramView.Name = "MainDiagramView";
            this.MainDiagramView.Size = new System.Drawing.Size(644, 503);
            this.MainDiagramView.TabIndex = 3;
            this.MainDiagramView.Text = "diagramView1";
            // 
            // MainDiagram
            // 
            this.MainDiagram.TouchThreshold = 0F;
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.chooseFileDialog.Title = "Choose XML document to visualize";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Choose where to save a file";
            // 
            // ZoomControl
            // 
            this.ZoomControl.BackColor = System.Drawing.Color.Transparent;
            this.ZoomControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ZoomControl.Location = new System.Drawing.Point(0, 245);
            this.ZoomControl.Name = "ZoomControl";
            this.ZoomControl.Padding = new System.Windows.Forms.Padding(5);
            this.ZoomControl.Size = new System.Drawing.Size(159, 150);
            this.ZoomControl.TabIndex = 7;
            this.ZoomControl.Target = this.MainDiagramView;
            this.ZoomControl.TickPosition = MindFusion.Common.WinForms.TickPosition.Left;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 511);
            this.Controls.Add(this.MainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "XML Tree Visualizer";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainLayout.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlsLayout.ResumeLayout(false);
            this.ChooseFilePanel.ResumeLayout(false);
            this.ChooseFilePanel.PerformLayout();
            this.DownloadFilePanel.ResumeLayout(false);
            this.DownloadFilePanel.PerformLayout();
            this.VisualizePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button DownloadXmlBtn;
        private System.Windows.Forms.ProgressBar DownloadBar;
        private System.Windows.Forms.Label DownloadingLabel;
        private System.Windows.Forms.Panel VisualizePanel;
        private MindFusion.Diagramming.WinForms.DiagramView MainDiagramView;
        private MindFusion.Diagramming.Diagram MainDiagram;
        private System.Windows.Forms.TableLayoutPanel ControlsLayout;
        private System.Windows.Forms.Button ParseTreeBtn;
        private System.Windows.Forms.Panel ChooseFilePanel;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.LinkLabel ChosenFileLink;
        private System.Windows.Forms.TextBox UriTextbox;
        private System.Windows.Forms.Panel DownloadFilePanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MindFusion.Common.WinForms.ZoomControl ZoomControl;
    }
}

