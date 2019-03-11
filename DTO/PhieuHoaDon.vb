Public Class PhieuHoaDon
  Private _MaPhieuHoaDon As String
  Private _MaKhachHang As String
  Private _NgayLapHoaDon As DateTime

  Public Property MaPhieuHoaDon() As String
    Get
      Return _MaPhieuHoaDon
    End Get
    Set(value As String)
      _MaPhieuHoaDon = value
    End Set
  End Property
  Public Property MaKhachHang() As String
    Get
      Return _MaKhachHang
    End Get
    Set(value As String)
      _MaKhachHang = value
    End Set
  End Property
  Public Property NgayLapHoaDon() As DateTime
    Get
      Return _NgayLapHoaDon
    End Get
    Set(value As DateTime)
      _NgayLapHoaDon = value
    End Set
  End Property
  Public Sub New()
    _MaPhieuHoaDon = ""
    _MaKhachHang = ""
    _NgayLapHoaDon = ""
  End Sub
  Public Sub New(ByVal maphieuhoadon As String, ByVal makhachhang As String, ByVal ngaylaphoadon As DateTime)
    _MaPhieuHoaDon = maphieuhoadon
    _MaKhachHang = makhachhang
    _NgayLapHoaDon = ngaylaphoadon
  End Sub
End Class
