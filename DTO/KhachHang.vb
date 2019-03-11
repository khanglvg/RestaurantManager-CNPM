Public Class KhachHang
  Private _MaKhachHang As String
  Private _HoTenKhachHang As String
  Private _DiaChi As String
  Private _DienThoai As String
  Private _Email As String
  Private _SoTienNo As Double

  Public Property MaKhachHang() As String
    Get
      Return _MaKhachHang
    End Get
    Set(value As String)
      _MaKhachHang = value
    End Set
  End Property
  Public Property HoTenKhachHang() As String
    Get
      Return _HoTenKhachHang
    End Get
    Set(value As String)
      _HoTenKhachHang = value
    End Set
  End Property
  Public Property DiaChi() As String
    Get
      Return _DiaChi
    End Get
    Set(value As String)
      _DiaChi = value
    End Set
  End Property
  Public Property DienThoai() As String
    Get
      Return _DienThoai
    End Get
    Set(value As String)
      _DienThoai = value
    End Set
  End Property
  Public Property Email() As String
    Get
      Return _Email
    End Get
    Set(value As String)
      _Email = value
    End Set
  End Property
  Public Property SoTienNo() As Double
    Get
      Return _SoTienNo
    End Get
    Set(value As Double)
      _SoTienNo = value
    End Set
  End Property

  Public Sub New()
    _MaKhachHang = ""
    _HoTenKhachHang = ""
    _DiaChi = ""
    _DienThoai = ""
    _Email = ""
    _SoTienNo = 0
  End Sub
  Public Sub New(ByVal makhachhang As String, ByVal hotenkhachhang As String, ByVal diachi As String, ByVal dienthoai As String, ByVal email As String, ByVal sotienno As Double)
    _MaKhachHang = makhachhang
    _HoTenKhachHang = hotenkhachhang
    _DiaChi = diachi
    _DienThoai = dienthoai
    _Email = email
    _SoTienNo = sotienno
  End Sub
End Class
