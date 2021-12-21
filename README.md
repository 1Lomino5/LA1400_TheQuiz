# LA1400_TheQuiz
Ein Quizspiel erstellt mit C#

#### Was ist das Ziel dieses Portfolios ?
###### Die LeserInnen können am Ende dieses Beitrages eine PictureBox in Winforms erstellen, diese mit Bilder befüllen und im Verlauf des Codes das angezeigte Bild ändern.
<br>

## Wie man eine PictureBox erstellt und befüllt
In diesem Video können Sie sehen wie man eine PictureBox erstellt und befüllt.
[![Mein Foto](http://img.youtube.com/vi/i0y-RBSp8R0/0.jpg)](https://youtu.be/_4MSXQ1RMtw)


## Ändern des Bildes mit hilfe des Codes
Möchte man das Bild, welches man eingefügt hat ändern, zum Beispiel bei einem Quiz das für jede Frage ein neues Bild kommt, so kann man dies ganz einfach mithilfe des Codes machen.

Um das Bild zu ändern gibt man als erstes das Objekt an, also in unserem Fall die ``pictureBox1``. <br>
Wenn man nicht weiss wie ein Objekt heisst kann man doppelt drauf klicken, daraufhin öffnet sich der Code mit der Funktion des Objekt. Im Name dieser Funktion sieht man wie das Objekt heisst, als alternative kann man dies auch im Eigenschaften Fenster nachschauen.
<br>
<br>
Als nächstes setzt man hinter den Namen der PictureBox ``.Image`` also das es so aussieht ``pictureBox1.Image``. Somit weiss das Programm das sich der folgende Befehl auf das Bild im Objekt sich bezieht.
<br>
<br>
Damit man das Bild ändern kann muss man nun das Bild im Speicherort öffnen. Den Speicherort ruft man wie folgt auf ``pictureBox1.Image = Properties.Resources`` das gleich zeigt dass das Bild im Obejekt ``pictureBox1`` zu dem mit ``Properties.Resources`` Bild umgewandelt werden soll. So wie der Befehl jetzt ist fehlt aber noch der wichtigste Teil, nähmlich das Bild. Bis jetzt hat man nähmlich lediglich den Speicherort geöffnet.
<br>
<br>
Der letzte Schritt ist das man nun noch den Namen des gewünschet Bilds angibt als zum Beispiel ``.HDMI`` wichtig ist das man den Punkt vor dem Namen nicht vergisst.
Wenn man nicht weiss wie ein Bild heisst kann man nochmal das Fenster öffnen indem man die Bilder hinzugefügt hat, dort sieht man alle Bilder mit Namen und jeweiliger Vorschau.
<br>
<br>
Der fertige Befehl um das Bild zu ändern würde also so aussehen (Dateiname ist variabel): ``pictureBox1.Image = Properties.Resources.HDMI;``
<br>
Was man nicht vergessen darf ist am Ende des Befehls ein ``;`` einzufügen um diesen zu schliessen.

 
### Einbettung in einen Code
Im Porjekt LA1400 haben wir diesen Befehl verwendet um bei jeder Frage ein neues Bild anzeigen zu lassen. Dafür haben wir für jede Frage ein Case erstellt, bei dem wir dann den Befehl verwendeten. (Im Bild rot markiert):
![](LA1400_TheQuiz/Pictures/Beispiel.jpg)


## Verifikation
Mit der Anleitung sollten die Leser wissen, wie man in Winforms eine PictureBox ersellt, diese befült und mit hilfe des Codes das Bild darin ändert.

## Reflexion
Im Projekt habe ich viele neue Erfahrungen gesammelt, eine der grössten Erfahrung bezieht sich auf das Arbeit in der Gruppe. Ich habe bereits zuvor Projekte gehabt, welche ich in Gruppen erarbeitet habe, jedoch kannte ich dort die Leute mit denen ich arbeitet bereits im Vorraus. Bei diesem Projekt war das ganz anders, als wir am ersten Tag begangen lernte ich gleichzeitig meine Arbeitskollegen kennen. Es war sehr interessent ein Projekt auf diese weise zu begingen, am Anfang gab es ein wenig stille da man nicht genau wusste wie man die andere Personen aus der Gruppe ansprechen sollte, doch mit der Zeit wurde es immer besser, die Arbeit wurde lokerer dafür aber auch fokusierter und gezielter. Ein weiterer grosser neuer Faktor diese Projekt war das wir uns nicht mehr auf Konsolenanwendungen beschränkten
