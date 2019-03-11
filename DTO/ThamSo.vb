Public Class ThamSo
  Private _SoLuongNhapItNhat As Integer
  Private _SoLuongTonToiDaTruocNhap As Integer
  Private _SoLuongTonSauToiThieu As Integer 'số lượng tồn sau khi bán tối thiểu
  Private _SoTienNoToiDa As Double
  Private _SuDungQuyDinhSoTienNoToiDa As Boolean

  Public Property SoLuongNhapItNhat() As Integer
    Get
      Return _SoLuongNhapItNhat
    End Get
    Set(value As Integer)
      _SoLuongNhapItNhat = value
    End Set
  End Property
  Public Property SoLuongTonToiDaTruocNhap() As Integer
    Get
      Return _SoLuongTonToiDaTruocNhap
    End Get
    Set(value As Integer)
      _SoLuongTonToiDaTruocNhap = value
    End Set
  End Property
  Public Property SoLuongTonSauToiThieu As Integer
    Get
      Return _SoLuongTonSauToiThieu
    End Get
    Set(value As Integer)
      _SoLuongTonSauToiThieu = value
    End Set
  End Property
  Public Property SoTienNoToiDa() As Double
    Get
      Return _SoTienNoToiDa
    End Get
    Set(value As Double)
      _SoTienNoToiDa = value
    End Set
  End Property
  Public Property SuDungQuyDinhSoTienNoToiDa() As Boolean
    Get
      Return _SuDungQuyDinhSoTienNoToiDa
    End Get
    Set(value As Boolean)
      _SuDungQuyDinhSoTienNoToiDa = value
    End Set
  End Property

  Public Sub New()
    _SoLuongNhapItNhat = 0
    _SoLuongTonToiDaTruocNhap = 0
    _SoLuongTonSauToiThieu = 0
    _SoTienNoToiDa = 0
    _SuDungQuyDinhSoTienNoToiDa = False
  End Sub

  Public Sub New(ByVal soluongnhapitnhat As Integer, ByVal soluongtontoidatruocnhap As Integer, ByVal soluongtonsautoithieu As Integer, ByVal sotiennotoida As Double, ByVal sudungquydinhsotiennotoida As Boolean)
    _SoLuongNhapItNhat = soluongnhapitnhat
    _SoLuongTonToiDaTruocNhap = soluongtontoidatruocnhap
    _SoLuongTonSauToiThieu = soluongtonsautoithieu
    _SoTienNoToiDa = sotiennotoida
    _SuDungQuyDinhSoTienNoToiDa = sudungquydinhsotiennotoida
  End Sub
End Class
