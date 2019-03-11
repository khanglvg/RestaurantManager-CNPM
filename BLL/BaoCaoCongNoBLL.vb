Imports DTO
Imports DAL
Public Class BaoCaoCongNoBLL
  Dim baocaocongno As BaoCaoCongNoDAL = New BaoCaoCongNoDAL()
  Public Function LayDuLieuTheoMaKhachHang(ByVal makhachhang As String) As BaoCaoCongNo
    Return baocaocongno.LayDuLieuTheoMaKhachHang(makhachhang)
  End Function
  Public Function CapNhatDuLieu(ByVal machitietcongno As String, ByVal thang As Integer, ByVal makhachhang As String, ByVal nodau As Double, ByVal nocuoi As Double, ByVal nophatsinh As Double) As Boolean
    If baocaocongno.KiemTraMaChiTietCongNo(machitietcongno) = True Then
      Return False
    End If
    Return baocaocongno.CapNhatDuLieu(machitietcongno, thang, makhachhang, nodau, nocuoi, nophatsinh)
  End Function
  Public Function LayToanBoDuLieu() As List(Of BaoCaoCongNo)
    Return baocaocongno.LayToanBoDuLieu()
  End Function
  Public Function LayTheoThang(ByVal thang As Integer) As List(Of BaoCaoCongNo)
    Return baocaocongno.LayTheoThang(thang)
  End Function
End Class
