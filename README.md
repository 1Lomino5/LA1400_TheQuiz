# LA1400_TheQuiz
Ein Quizspiel erstellt mit C#

#### Was ist das Ziel dieses Portfolios ?
###### Die LeserInnen können am Ende dieses Beitrages eine PictureBox in Winforms erstellen, diese mit Bildern befüllen und im Verlauf des Codes das angezeigte Bild ändern.
<br>

## Wie man eine PictureBox erstellt und befüllt
In diesem Video können Sie sehen wie man eine PictureBox erstellt und befüllt.
[![Mein Foto](http://img.youtube.com/vi/i0y-RBSp8R0/0.jpg)](https://youtu.be/_4MSXQ1RMtw)


## Ändern des Bildes mithilfe des Codes
Möchte man das Bild, welches man eingefügt hat, ändern, zum Beispiel bei einem Quiz, damit für jede Frage ein neues Bild kommt, so kann man dies ganz einfach mithilfe des Codes machen.

Um das Bild zu ändern, gibt man als erstes das Objekt an, also in unserem Fall die ``pictureBox1``. <br>
Wenn man nicht weiss, wie ein Objekt heisst, kann man doppelt drauf klicken, daraufhin öffnet sich der Code mit der Funktion des Objektes. Im Namen dieser Funktion sieht man, wie das Objekt heisst, als Alternative kann man dies auch im Eigenschaften Fenster nachschauen.
<br>
<br>
Als nächstes setzt man hinter den Namen der PictureBox ``.Image``, also das es so aussieht ``pictureBox1.Image``. Somit weiss das Programm, dass sich der folgende Befehl auf das Bild im Objekt bezieht.
<br>
<br>
Damit man das Bild ändern kann, muss man nun das Bild im Speicherort öffnen. Den Speicherort ruft man wie folgt auf ``pictureBox1.Image = Properties.Resources``. Das Gleich zeigt, dass das Bild im Objekt ``pictureBox1`` zu dem Bild aus ``Properties.Resources`` umgewandelt werden soll. So wie der Befehl jetzt ist, fehlt aber noch der wichtigste Teil, nähmlich das Bild. Bis jetzt hat man nämlich lediglich den Speicherort geöffnet.
<br>
<br>
Der letzte Schritt ist, dass man nun noch den Namen des gewünschten Bildes angibt, also zum Beispiel ``.HDMI``. Wichtig ist, dass man den Punkt vor dem Namen nicht vergisst.
Wenn man nicht weiss, wie ein Bild heisst, kann man nochmals das Fenster öffnen, in dem man die Bilder hinzugefügt hat. Dort sieht man alle Bilder mit Namen und jeweiliger Vorschau.
<br>
<br>
Der fertige Befehl, um das Bild zu ändern, würde also so aussehen (Dateiname ist variabel): ``pictureBox1.Image = Properties.Resources.HDMI;``
<br>
Was man nicht vergessen darf, ist am Ende des Befehls ein ``;`` einzufügen, um diesen zu schliessen.

 
### Einbettung in einen Code
Im Porjekt LA1400 haben wir diesen Befehl verwendet, um bei jeder Frage ein neues Bild anzeigen zu lassen. Dafür haben wir für jede Frage ein Case erstellt, bei dem wir dann den Befehl verwendeten. (Im Bild rot markiert):
![](LA1400_TheQuiz/Pictures/Beispiel.jpg)


## Verifikation
Mit der Anleitung sollten die LeserInnen wissen, wie man in Winforms eine PictureBox ersellt, diese befüllt und mithilfe des Codes das Bild darin ändert.

## Reflexion
Im Projekt habe ich viele neue Erfahrungen gesammelt, eine der grössten Erfahrungen bezieht sich auf das Arbeiten in der Gruppe. Ich hatte bereits zuvor Projekte, bei denen ich in Gruppen gerbeitet habe, jedoch kannte ich die Leute dort zuvor schon. Bei diesem Projekt war das ganz anders, am ersten Tag mussten wir natürlich am Projekt arbeiten, nebenbei lernten wir uns dabei kennen. Es war sehr interessent ein Projekt auf diese Weise zu beginnen, am Anfang gab es ein wenig Stille, da man nicht genau wusste, wie man die anderen ansprechen sollte. Das wurde mit der Zeit immer besser, wir öffneten uns und so konnten wir auch besser miteinander arbeiten. <br>
Ein weiterer neuer Faktor, der in diesem Projekt vorkam, war, dass wir uns nicht mehr auf Konsolenanwendungen beschränkten, sondern anfingen, auch Objekte zu bentutzen. Als wir mit dem Programmieren begannen, versuchten wir, sofort immer auch das Design anzupassen, jedoch merkten wir nach einiger Zeit, dass es sich mehr lohnt, zuerst den Code zu schreiben und dann das Design zu machen, denn wenn man noch nicht fertig ist mit dem Code, kann sich das Design immer wieder ändern. Daher wäre mein Verbesserungvorschlag, dass man während dem Porgammieren nicht zu viel Zeit in das Design steckt, sondern sich am Schluss, wenn der Code fertig ist, die Zeit nimmt und dann das Design macht. So verbraucht man weniger Zeit und kann effizienter arbeiten.
