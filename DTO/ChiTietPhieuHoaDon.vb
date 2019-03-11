Public Class ChiTietPhieuHoaDon
  Private _MaChiTietPhieuHoaDon As String
  Private _MaPhieuHoaDon As String
  Private _MaSach As String
  Private _SoLuongBan As Integer

  Public Property MaChiTietPhieuHoaDon() As String
    Get
      Return _MaChiTietPhieuHoaDon
    End Get
    Set(value As String)
      _MaChiTietPhieuHoaDon = value
    End Set
  End Property
  Public Property MaPhieuHoaDon() As String
    Get
      Return _MaPhieuHoaDon
    End Get
    Set(value As String)
      _MaPhieuHoaDon = value
    End Set
  End Property
  Public Property MaSach() As String
    Get
      Return _MaSach
    End Get
    Set(value As String)
      _MaSach = value
    End Set
  End Property
  Public Property SoLuongBan() As Integer
    Get
      Return _SoLuongBan
    End Get
    Set(value As Integer)
      _SoLuongBan = value
    End Set
  End Property

  Public Sub New()
    _MaChiTietPhieuHoaDon = ""
    _MaPhieuHoaDon = ""
    _MaSach = ""
    _SoLuongBan = 0
  End Sub
  Public Sub New(ByVal machitietphieuhoadon As String, ByVal maphieuhoadon As String, ByVal masach As String, ByVal soluongban As Integer)
    _MaChiTietPhieuHoaDon = machitietphieuhoadon
    _MaPhieuHoaDon = maphieuhoadon
    _MaSach = masach
    _SoLuongBan = soluongban
  End Sub
End Class
