Imports DTO
Imports DAL
Public Class PhieuThuTienBLL
  Dim phieuthutien As PhieuThuTienDAL = New PhieuThuTienDAL()
  Public Function CapNhatPhieuThuTien(ByVal maphieuthu As String, ByVal sotienthu As Double, ByVal ngaythutien As DateTime, ByVal makhachhang As String) As Boolean
    If phieuthutien.KiemTraMaPhieuThu(maphieuthu) = True Then
      Return False
    End If
    Return phieuthutien.CapNhatPhieuThuTien(maphieuthu, sotienthu, ngaythutien, makhachhang)
  End Function
End Class
