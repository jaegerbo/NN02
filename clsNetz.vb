Imports AForge.Neuro

Public Class clsNetz
   Inherits Network

   Public Sub New(AnzahlEingangsneuronen As Integer, AnzahlLayer As Integer)
      MyBase.New(AnzahlEingangsneuronen, AnzahlLayer)
      Try
         For Each Layer As clsSchicht In Layers
            If Layer Is Nothing Then
               Layer = New clsSchicht(AnzahlEingangsneuronen, AnzahlEingangsneuronen)
            End If

         Next
      Catch ex As Exception
         logFehler(ex)
      End Try
   End Sub


End Class
