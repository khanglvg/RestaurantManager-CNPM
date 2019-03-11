Imports DAL
Imports DTO
Public Class PhieuNhapBLL
  Dim phieunhap As PhieuNhapDAL = New PhieuNhapDAL()
  Public Function CapNhatThongTinVaoPhieuNhap(ByVal maphieunhap As String, ByVal ngaynhap As DateTime) As Boolean
    If phieunhap.KiemTraMaPhieuNhap(maphieunhap) = True Then
      Return False
    End If
    Return phieunhap.CapNhatThongTinVaoPhieuNhap(maphieunhap, ngaynhap)
  End Function
End Class
