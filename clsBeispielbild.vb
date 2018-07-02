Public Class clsBeispielbild

   Private _Name As String
   Public Property Name() As String
      Get
         Return _Name
      End Get
      Set(ByVal value As String)
         _Name = value
      End Set
   End Property

   Private _Bild As Bitmap
   Public Property Bild() As Bitmap
      Get
         Return _Bild
      End Get
      Set(ByVal value As Bitmap)
         _Bild = value
         ReDim _Eingabematrix(_Bild.Size.Width * _Bild.Size.Height - 1)
         ReDim _Lösungsmatrix(9)
      End Set
   End Property

   Private _Wert As Integer
   Public Property Wert() As Integer
      Get
         Return _Wert
      End Get
      Set(ByVal value As Integer)
         _Wert = value
      End Set
   End Property

   Private _Eingabematrix As Double()
   Public Property Eingabematrix() As Double()
      Get
         Return _Eingabematrix
      End Get
      Set(ByVal value As Double())
         _Eingabematrix = value
      End Set
   End Property

   Private _Lösungsmatrix As Double()
   Public Property Lösungsmatrix() As Double()
      Get
         Return _Lösungsmatrix
      End Get
      Set(ByVal value As Double())
         _Lösungsmatrix = value
      End Set
   End Property

End Class
