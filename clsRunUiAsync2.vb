Public Class clsRunUiAsync2

   'Public Shared Function Run(mainControl As Control, Aktion As [Delegate], Optional showWaitControl As Boolean = True) As Task
   '   ' Zweck:    für das gegebene mainControl die gegebene Aktion asynchron durchführen
   '   Try
   '      ' Prüfen, ob die Parameter ok sind
   '      If mainControl Is Nothing OrElse Aktion Is Nothing Then Return Nothing

   '      ' ggf ein Wait-Control erzeugen, und das Main-Control ausblenden
   '      Dim waitControl As Label = waitControlEinrichten(mainControl, showWaitControl)

   '      ' Die Aktion starten
   '      mainControl.BeginInvoke(Aktion)

   '      ' Main-Control wieder anzeigen
   '      mainControl.BeginInvoke(Sub() fertig(mainControl, waitControl))

   '   Catch ex As Exception
   '      Stop
   '   End Try
   '   Return Nothing
   'End Function
   Public Shared Async Sub Run(mainControl As Control, Aktion As Action, Optional waittext As String = Nothing)
      ' Zweck:    für das gegebene mainControl die gegebene Aktion asynchron durchführen
      Try
         ' Prüfen, ob die Parameter ok sind
         If mainControl Is Nothing OrElse Aktion Is Nothing Then Exit Sub

         ' ggf ein Wait-Control erzeugen, und das Main-Control ausblenden
         Dim waitControl As Label = waitControlEinrichten(mainControl, waittext)

         ' Die Aktion starten
         'Await Task.Run(Sub() mainControl.BeginInvoke(Aktion))
         Await Task.Run(Aktion).ConfigureAwait(False)

         ' Main-Control wieder anzeigen
         mainControl.BeginInvoke(Sub() fertig(mainControl, waitControl))

      Catch ex As Exception
         Stop
      End Try
   End Sub

   Private Shared Function waitControlEinrichten(mainControl As Control, waittext As String) As Label
      ' Zweck:    Wenn ein waitControl angezeigt werden soll, wird es hier erzeugt
      Try
         If waittext IsNot Nothing Then
            mainControl.Visible = False

            Dim waitControl As New Label
            With waitControl
               .Top = mainControl.Top
               .Left = mainControl.Left
               .Width = mainControl.Width
               .Height = mainControl.Height
               .Text = waittext
               .TextAlign = ContentAlignment.MiddleCenter
               Dim Font As New Font("Arial", CSng(.Width / 20))
               .Font = Font
            End With
            mainControl.Parent.Controls.Add(waitControl)
            Application.DoEvents()
            Return waitControl
         End If
      Catch ex As Exception
         Stop
      End Try
      Return Nothing
   End Function
   Private Shared Sub fertig(mainControl As Control, waitControl As Control)
      ' Zweck:    Wenn ein waitControl vorhanden war, wird es wieder entfernt
      Try
         If waitControl IsNot Nothing Then
            mainControl.Visible = True
            mainControl.Parent.Controls.Remove(waitControl)
            waitControl.Dispose()
            Application.DoEvents()
         End If
      Catch ex As Exception
         Stop
      End Try
   End Sub


End Class
