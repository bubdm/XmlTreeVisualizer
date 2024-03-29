# XmlTreeVisualizer
### Simple WinForms application for XML-tree visualization
____
## Использование
При запуске приложения строится случайное дерево не связанное с XML - чтобы показать, как примерно будет выглядеть дерево построенное по XML документу.
![Начальный экран](https://i.imgur.com/TqKov53.png)

Справа расположена панель для скачивания и выбора файлов:
1. Синяя надпись (LinkLabel) показывает выбранный в данный момент файл.
    Если в данный момент выбран какой то файл, то при нажатии на надпись, этот файл откроется в блокноте.
2. Кнопка `Choose file` открывает окно диалога для выбора XML файла по которому будет построено дерево.
3. В поле для текста вводится URI для скачивания файла.
4. Кнопка `Download file` скачивает файл по введенному URI.
5. Элемент управления для масштабирования диаграммы. 
6. Кнопка `Draw XML tree` выполняет визуализацию выбранного в данный момент файла.
____
Построеное дерево подстраивается под размеры экрана.
![Построенное дерево](https://i.imgur.com/y6ljhP7.png)
Дерево можно масштабировать и перемещаться по нему с помощью мыши.
![Приближенное дерево](https://i.imgur.com/PfFNwxs.png)
Блоки диаграммы отличаются по цвету в зависимости от типа узла - корень, узел, атрибут или простой текст.
![Подписанные узлы](https://i.imgur.com/yngwEGj.png)
____
Если попытаться отрисовать файл размером более 100000 байт, то программа выдаст предупреждение о том,
что обработка такого файла может занять много времени и визуально дерево будет слишком большим, чтобы удобно его воспринимать.

## Примеры ссылок для скачивания XML
https://raw.githubusercontent.com/kizeevov/elcomplusfiles/main/config.xml    
https://raw.githubusercontent.com/kizeevov/elcomplusfiles/main/tree.xml    
https://www.w3schools.com/xml/note.xml    
https://www.w3schools.com/xml/note_error.xml (с ошибкой)    
https://www.w3schools.com/xml/cd_catalog.xml    
https://www.w3schools.com/xml/simple.xml    

## Библиотеки
Используется набор библиотек MindFusion для построения диаграмм.
