Imports DTO
Imports DAL
Public Class ChiTietPhieuHoaDonBLL
  Dim chitietphieuhoadon As ChiTietPhieuHoaDonDAL = New ChiTietPhieuHoaDonDAL()
  Public Function CapNhapChiTietPhieuHoaDon(ByVal machitietphieuhoadon As String, ByVal maphieuhoadon As String, ByVal masach As String, ByVal soluongban As Integer) As Boolean
    If chitietphieuhoadon.KiemTraMaChiTietPhieuHoaDon(machitietphieuhoadon) = True Then
      Return False
    End If
    Return chitietphieuhoadon.CapNhapChiTietPhieuHoaDon(machitietphieuhoadon, maphieuhoadon, masach, soluongban)
  End Function
End Class
