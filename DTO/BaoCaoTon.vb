Public Class BaoCaoTon
  Private _MaChiTietTon As String
  Private _Thang As Integer
  Private _MaSach As String
  Private _TonDau As Integer
  Private _TonPhatSinh As Integer
  Private _TonCuoi As Integer

  Public Property MaChiTietTon() As String
    Get
      Return _MaChiTietTon
    End Get
    Set(value As String)
      _MaChiTietTon = value
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
  Public Property MaSach() As String
    Get
      Return _MaSach
    End Get
    Set(value As String)
      _MaSach = value
    End Set
  End Property
  Public Property TonDau() As Integer
    Get
      Return _TonDau
    End Get
    Set(value As Integer)
      _TonDau = value
    End Set
  End Property
  Public Property TonPhatSinh() As Integer
    Get
      Return _TonPhatSinh
    End Get
    Set(value As Integer)
      _TonPhatSinh = value
    End Set
  End Property
  Public Property TonCuoi() As Integer
    Get
      Return _TonCuoi
    End Get
    Set(value As Integer)
      _TonCuoi = value
    End Set
  End Property

  Public Sub New()
    _MaChiTietTon = ""
    _Thang = 0
    _MaSach = ""
    _TonDau = 0
    _TonPhatSinh = 0
    _TonCuoi = 0
  End Sub
  Public Sub New(ByVal machitietton As String, ByVal thang As Integer, ByVal masach As String, ByVal tondau As Integer, ByVal tonphatsinh As Integer, ByVal toncuoi As Integer)
    _MaChiTietTon = machitietton
    _Thang = thang
    _MaSach = masach
    _TonDau = tondau
    _TonPhatSinh = tonphatsinh
    _TonCuoi = toncuoi
  End Sub
End Class
