Public Class ChiTietPhieuNhap
  Private _MaChiTietPhieuNhap As String
  Private _MaPhieuNhap As String
  Private _MaSach As String
  Private _SoLuongNhap As Integer

  Public Property MaChiTietPhieuNhap() As String
    Get
      Return _MaChiTietPhieuNhap
    End Get
    Set(value As String)
      _MaChiTietPhieuNhap = value
    End Set
  End Property
  Public Property MaPhieuNhap() As String
    Get
      Return _MaPhieuNhap
    End Get
    Set(value As String)
      _MaPhieuNhap = value
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
  Public Property SoLuongNhap() As Integer
    Get
      Return _SoLuongNhap
    End Get
    Set(value As Integer)
      _SoLuongNhap = value
    End Set
  End Property
  Public Sub New()
    _MaChiTietPhieuNhap = ""
    _MaPhieuNhap = ""
    _MaSach = ""
    _SoLuongNhap = 0
  End Sub
  Public Sub New(ByVal machitietphieunhap As String, ByVal maphieunhap As String, ByVal masach As String, ByVal soluongnhap As Integer)
    _MaChiTietPhieuNhap = machitietphieunhap
    _MaPhieuNhap = maphieunhap
    _MaSach = masach
    _SoLuongNhap = soluongnhap
  End Sub
End Class
