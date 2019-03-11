Imports DAL
Imports DTO
Public Class PhieuHoaDonBLL
  Dim phieuhoadon As PhieuHoaDonDAL = New PhieuHoaDonDAL()
  Public Function CapNhatPhieuHoaDon(ByVal maphieuhoadon As String, ByVal makhachhang As String, ByVal ngaylaphoadon As DateTime) As Boolean
    If phieuhoadon.KiemtraMaPhieuHoaDon(maphieuhoadon) = True Then
      Return False
    End If
    Return phieuhoadon.CapNhatPhieuHoaDon(maphieuhoadon, makhachhang, ngaylaphoadon)
  End Function
End Class
