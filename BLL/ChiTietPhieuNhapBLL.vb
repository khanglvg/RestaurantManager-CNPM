Imports DTO
Imports DAL
Public Class ChiTietPhieuNhapBLL
  Dim chitietphieunhap As ChiTietPhieuNhapDAL = New ChiTietPhieuNhapDAL()
  Public Function CapNhatChiTietPhieuNhap(ByVal machitietphieunhap As String, ByVal maphieunhap As String, ByVal masach As String, ByVal soluongnhap As Integer) As Boolean
    Dim a = 5
    If chitietphieunhap.KiemTraMaChiTietPhieuNhap(machitietphieunhap) = True Then
      Return False
    End If
    Dim b = 6
    Return chitietphieunhap.CapNhatChiTietPhieuNhap(machitietphieunhap, maphieunhap, masach, soluongnhap)
  End Function
End Class
