Imports DTO
Imports DAL
Public Class KhachHangBLL
  Dim khachhang As KhachHangDAL = New KhachHangDAL()
  Public Function LayToanBoKhachHang() As List(Of KhachHang)
    Return khachhang.LayToanBoKhachHang()
  End Function
  Public Function LayKhachHangTheoMa(ByVal makhachhang As String) As KhachHang
    Return khachhang.LayKhachHangTheoMa(makhachhang)
  End Function
  Public Function LayKhachHangTheoTen(ByVal tenkhachhang As String) As List(Of KhachHang)
    Return khachhang.LayKhachHangTheoTen(tenkhachhang)
  End Function
  Public Function LayKhachHangTheoDiaChi(ByVal diachi As String) As List(Of KhachHang)
    Return khachhang.LayKhachHangTheoDiaChi(diachi)
  End Function
  Public Function LayKhachHangTheoSoDienThoai(ByVal dienthoai As String) As List(Of KhachHang)
    Return khachhang.LayKhachHangTheoSoDienThoai(dienthoai)
  End Function
  Public Function LayKhachHangTheoEmail(ByVal email As String) As List(Of KhachHang)
    Return khachhang.LayKhachHangTheoEmail(email)
  End Function
  Public Function ThemKhachHang(ByVal makhachhang As String, ByVal hotenkhachhang As String, ByVal diachi As String, ByVal dienthoai As String, ByVal email As String) As Boolean
    If khachhang.KiemTraMaKhachHang(makhachhang) = True Then
      Return False
    End If
    Return khachhang.ThemKhachHang(makhachhang, hotenkhachhang, diachi, dienthoai, email)
  End Function
  Public Function SuaKhachHang(ByVal makhachhang As String, ByVal hotenkhachhang As String, ByVal diachi As String, ByVal dienthoai As String, ByVal email As String) As Boolean
    Return khachhang.SuaKhachHang(makhachhang, hotenkhachhang, diachi, dienthoai, email)
  End Function
  Public Function XoaKhachHang(ByVal makhachhang As String) As Boolean
    Return khachhang.XoaKhachHang(makhachhang)
  End Function
  Public Function KiemTraMaKhachHang(ByVal makhachhang As String) As Boolean
    Return khachhang.KiemTraMaKhachHang(makhachhang)
  End Function
  Public Function LaySoTienNoTheoMaKhachHang(ByVal makhachhang As String) As Double
    Return khachhang.LaySoTienNoTheoMaKhachHang(makhachhang)
  End Function
  Public Function CapNhatTienNoMoiTheoMaKhachHang(ByVal makhachhang As String, ByVal sotiennomoi As Double) As Boolean
    Return khachhang.CapNhatTienNoMoiTheoMaKhachHang(makhachhang, sotiennomoi)
  End Function
End Class
