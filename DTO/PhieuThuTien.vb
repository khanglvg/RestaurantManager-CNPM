Public Class PhieuThuTien
  Private _MaPhieuThu As String
  Private _SoTienThu As Double
  Private _NgayThuTien As DateTime
  Private _MaKhachHang As String

  Public Property MaPhieuThu() As String
    Get
      Return _MaPhieuThu
    End Get
    Set(value As String)
      _MaPhieuThu = value
    End Set
  End Property
  Public Property SoTienThu() As Double
    Get
      Return _SoTienThu
    End Get
    Set(value As Double)
      _SoTienThu = value
    End Set
  End Property
  Public Property NgayThuTien() As DateTime
    Get
      Return _NgayThuTien
    End Get
    Set(value As DateTime)
      _NgayThuTien = value
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

  Public Sub New()
    _MaPhieuThu = ""
    _SoTienThu = 0
    _NgayThuTien = ""
    _MaKhachHang = ""
  End Sub
  Public Sub New(ByVal maphieuthu As String, ByVal sotienthu As Double, ByVal ngaythutien As DateTime, ByVal makhachhang As String)
    _MaPhieuThu = maphieuthu
    _SoTienThu = sotienthu
    _NgayThuTien = ngaythutien
    _MaKhachHang = makhachhang
  End Sub
End Class
