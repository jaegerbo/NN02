Imports AForge.Neuro

Public Class frmStart

   Private _Netz As ActivationNetwork
   Private _Beispielbilder As Generic.List(Of clsBeispielbild)


   Private Sub btnBeispielbilderLaden_Click(sender As Object, e As EventArgs) Handles btnBeispielbilderLaden.Click
      ' Zweck:    Beispielbilder laden
      Try
         Cursor = Cursors.WaitCursor

         _Beispielbilder = New Generic.List(Of clsBeispielbild)

         Using OpenDialog As New FolderBrowserDialog
            OpenDialog.SelectedPath = "D:\Beispieldaten\numbers-master\0001_CH4M"
            OpenDialog.ShowDialog()
            Dim Directory As String = OpenDialog.SelectedPath
            Dim Di As New IO.DirectoryInfo(Directory)

            ' Schleife über alle Directories
            For Each D As IO.DirectoryInfo In Di.GetDirectories
               loadFilesOfDirectory(D)
            Next
         End Using

         gridBeispielbilder.DataSource = _Beispielbilder
         gridBeispielbilder.DisplayLayout.Bands(0).Override.DefaultRowHeight = 30
      Catch ex As Exception
         logFehler(ex)
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub
   Private Sub loadFilesOfDirectory(Directory As IO.DirectoryInfo)
      Try
         ' Schleife über alle Dateien
         For Each File As IO.FileInfo In Directory.GetFiles
            Dim Bild As New clsBeispielbild
            Bild.Name = File.Name
            Bild.Bild = Image.FromFile(File.FullName)
            If IsNumeric(Directory.Name) Then
               Bild.Wert = CInt(Directory.Name)
               Bild.Lösungsmatrix = ZifferToLösungsarray(Bild.Wert)
            End If
            Bild.Eingabematrix = EingabematrixErstellen(Bild.Bild)
            _Beispielbilder.Add(Bild)
         Next
      Catch ex As Exception
         logFehler(ex)
      End Try
   End Sub

   Private Sub btnNetzErstellen_Click(sender As Object, e As EventArgs) Handles btnNetzErstellen.Click
      Try
         Cursor = Cursors.WaitCursor

         Dim Ergebnismatrix(9) As Double
         Dim Layers() As Integer = {10000, 100, 100, 10}

         Dim AktivierungsFunktion As New BipolarSigmoidFunction()
         _Netz = New ActivationNetwork(AktivierungsFunktion, 10000, Layers)

         Dim Lehrer As New Learning.BackPropagationLearning(_Netz)
         Lehrer.LearningRate = 0.1
         Lehrer.Momentum = 0.0

         ' Trainingsphase starten

         ' Schleife über alle Bilder
         For Each Bild As clsBeispielbild In _Beispielbilder

            For Iterationsnummer As Integer = 0 To 100

               ' Netz berechnen
               Ergebnismatrix = _Netz.Compute(Bild.Eingabematrix)

               ' Fehler ermitteln, indem alle Elemente der Ergebnismatrix mit allen Elementen der Lösungsmatrix verglichen werden.
               Dim VorhersageFehler As Double = 0
               For i As Integer = 0 To 9
                  If Ergebnismatrix(i) <> Bild.Lösungsmatrix(i) Then
                     VorhersageFehler = 1
                     Exit For
                  End If
               Next


            Next
         Next

         Stop
      Catch ex As Exception
         logFehler(ex)
      Finally
         Cursor = Cursors.Default
      End Try
   End Sub
   Private Function ZifferToLösungsarray(Ziffer As Integer) As Double()
      Dim gewünschtesLösungsarray(9) As Double
      Try
         gewünschtesLösungsarray(Ziffer) = 1
      Catch ex As Exception
         logFehler(ex)
      End Try
      Return gewünschtesLösungsarray
   End Function
   Private Function EingabematrixErstellen(Bild As Bitmap) As Double()
      ' Zweck:    Für das gegebene bild eine Eingabematrix für das neuronale Netz erstellen
      Dim Eingabematrix(Bild.Size.Width * Bild.Size.Height - 1) As Double
      Try
         Dim i As Integer = 0
         For y As Integer = 0 To Bild.Size.Height - 1

            For x As Integer = 0 To Bild.Size.Width - 1
               Dim Farbe As Color = Bild.GetPixel(x, y)
               Select Case Farbe.ToArgb
                  Case Color.Black.ToArgb
                     Eingabematrix(i) = 1.0
                  Case Else
                     Eingabematrix(i) = 0.0
               End Select
               i += 1
            Next

         Next

      Catch ex As Exception
         logFehler(ex)
      End Try
      Return Eingabematrix
   End Function

End Class