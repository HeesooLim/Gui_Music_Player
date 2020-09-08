1. 
List of buttons: 
- btnMusicTab
- btnHistoryTab
- btnPrevious
- btnPlay
- btnNext
- btnAdd
- btnSort
- btnDelete
- btnExit
- btnX

Label:
- lblYourMusic
- lblLogo
- lblPlayMusic
- lblLoading

PictureBox:
- pcPicture
- pcSplash

2.
ListBox:
- lstMusic

ComboBox:
- cboCategory

3.
Queue:
Queue<string> histories

List:
List<Music> musics

4. 
DataGridView:
gridViewMusics

-- Start up data
File name: musicList.txt
Modified file name: modified.txt

5. 
Communicating form:
Main form sends users' history data to 'Form2'

6.
Technical difficulty:
1. Tried to make auto refreshing history tab, but could not make.
2. Tried to assign different pictures for each music, but could not do that. It changes picture rather randomly

7. 
Generic method:
AddElementToArray<T>