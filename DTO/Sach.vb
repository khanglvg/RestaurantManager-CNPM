Public Class Sach
  Private _MaSach As String
  Private _TenSach As String
  Private _TheLoai As String
  Private _TacGia As String
  Private _SoLuongTon As Integer
  Private _DonGia As Double

  Public Property MaSach() As String
    Get
      Return _MaSach
    End Get
    Set(value As String)
      _MaSach = value
    End Set
  End Property
  Public Property TenSach() As String
    Get
      Return _TenSach
    End Get
    Set(value As String)
      _TenSach = value
    End Set
  End Property
  Public Property TheLoai() As String
    Get
      Return _TheLoai
    End Get
    Set(value As String)
      _TheLoai = value
    End Set
  End Property
  Public Property TacGia() As String
    Get
      Return _TacGia
    End Get
    Set(value As String)
      _TacGia = value
    End Set
  End Property
  Public Property SoLuongTon() As Integer
    Get
      Return _SoLuongTon
    End Get
    Set(value As Integer)
      _SoLuongTon = value
    End Set
  End Property
  Public Property DonGia() As Double
    Get
      Return _DonGia
    End Get
    Set(value As Double)
      _DonGia = value
    End Set
  End Property

  Public Sub New()
    _MaSach = ""
    _TenSach = ""
    _TheLoai = ""
    _TacGia = ""
    _SoLuongTon = 0
    _DonGia = 0
  End Sub
  Public Sub New(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal soluongton As Integer, ByVal dongia As Double)
    _MaSach = masach
    _TenSach = tensach
    _TheLoai = theloai
    _TacGia = tacgia
    _SoLuongTon = soluongton
    _DonGia = dongia
  End Sub
End Class
