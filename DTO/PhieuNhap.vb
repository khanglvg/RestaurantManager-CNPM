Public Class PhieuNhap
  Private _MaPhieuNhap As String
  Private _NgayNhap As DateTime
  Public Property MaPhieuNhap() As String
    Get
      Return _MaPhieuNhap
    End Get
    Set(value As String)
      _MaPhieuNhap = value
    End Set
  End Property
  Public Property NgayNhap() As DateTime
    Get
      Return _NgayNhap
    End Get
    Set(value As DateTime)
      _NgayNhap = value
    End Set
  End Property
  Public Sub New()
    _MaPhieuNhap = ""
    _NgayNhap = ""
  End Sub
  Public Sub New(ByVal maphieunhap As String, ByVal ngaynhap As DateTime)
    _MaPhieuNhap = maphieunhap
    _NgayNhap = ngaynhap
  End Sub
End Class
