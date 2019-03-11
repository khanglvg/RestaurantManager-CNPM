Imports DTO
Imports DAL
Public Class BaoCaoTonBLL
  Dim baocaoton As BaoCaoTonDAL = New BaoCaoTonDAL()
  Public Function CapNhapBaoCaoTon(ByVal mabaocaoton As String, ByVal thang As Integer, ByVal masach As String, ByVal tondau As Integer, ByVal tonphatsinh As Integer, ByVal toncuoi As Integer) As Boolean
    If baocaoton.KiemTraMaChiTietTon(mabaocaoton) = True Then
      Return False
    End If
    Return baocaoton.CapNhapBaoCaoTon(mabaocaoton, thang, masach, tondau, tonphatsinh, toncuoi)
  End Function
  Public Function LayTonDauTheoMaSach(ByVal masach As String) As BaoCaoTon
    Return baocaoton.LayTonDauTheoMaSach(masach)
  End Function
  Public Function LayToanBoBaoCaoTon() As List(Of BaoCaoTon)
    Return baocaoton.LayToanBoBaoCaoTon()
  End Function
  Public Function LayTheoThang(ByVal thang As Integer) As List(Of BaoCaoTon)
    Return baocaoton.LayTheoThang(thang)
  End Function
End Class
