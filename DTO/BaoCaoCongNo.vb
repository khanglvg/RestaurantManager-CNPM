Public Class BaoCaoCongNo
  Private _MaChiTietCongNo As String
  Private _Thang As Integer
  Private _MaKhachHang As String
  Private _NoDau As Double
  Private _NoCuoi As Double
  Private _NoPhatSinh As Double

  Public Property MaChiTietCongNo() As String
    Get
      Return _MaChiTietCongNo
    End Get
    Set(value As String)
      _MaChiTietCongNo = value
    End Set
  End Property
  Public Property Thang() As Integer
    Get
      Return _Thang
    End Get
    Set(value As Integer)
      _Thang = value
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
  Public Property NoDau() As Double
    Get
      Return _NoDau
    End Get
    Set(value As Double)
      _NoDau = value
    End Set
  End Property
  Public Property NoCuoi() As Double
    Get
      Return _NoCuoi
    End Get
    Set(value As Double)
      _NoCuoi = value
    End Set
  End Property
  Public Property NoPhatSinh() As Double
    Get
      Return _NoPhatSinh
    End Get
    Set(value As Double)
      _NoPhatSinh = value
    End Set
  End Property

  Public Sub New()
    _MaChiTietCongNo = ""
    _Thang = 0
    _MaKhachHang = ""
    _NoDau = 0
    _NoCuoi = 0
    _NoPhatSinh = 0
  End Sub

  Public Sub New(ByVal machitietcongno As String, ByVal thang As Integer, ByVal makhachhang As String, ByVal nodau As Double, ByVal nocuoi As Double, ByVal nophatsinh As Double)
    _MaChiTietCongNo = machitietcongno
    _Thang = thang
    _MaKhachHang = makhachhang
    _NoDau = nodau
    _NoCuoi = nocuoi
    _NoPhatSinh = nophatsinh
  End Sub
End Class
