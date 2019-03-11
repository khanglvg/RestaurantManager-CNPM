Imports DTO
Imports DAL
Public Class SachBLL
  Dim sach As SachDAL = New SachDAL()
  Public Function LayToanBoSach() As List(Of Sach)
    Return sach.LayToanBoSach()
  End Function
  Public Function LaySachTheoMaSach(ByVal masach As String) As Sach
    Return sach.LaySachTheoMaSach(masach)
  End Function
  Public Function KiemTraMaSach(ByVal masach As String) As Boolean
    Return sach.KiemTraMaSach(masach)
  End Function
  Public Function LaySachTheoTen(ByVal tensach As String) As List(Of Sach)
    Return sach.LaySachTheoTen(tensach)
  End Function
  Public Function LaySachTheoTheLoai(ByVal theloai As String) As List(Of Sach)
    Return sach.LaySachTheoTheLoai(theloai)
  End Function
  Public Function LaySachTheoTacGia(ByVal tacgia As String) As List(Of Sach)
    Return sach.LaySachTheoTacGia(tacgia)
  End Function
  Public Function LaySoLuongTonTheoMaSach(ByVal masach As String) As Integer
    Return sach.LaySoLuongTonTheoMaSach(masach)
  End Function
  Public Function CapNhatSoLuongTonMoiTheoMaSach(ByVal masach As String, ByVal soluongtonmoi As Integer) As Boolean
    Return sach.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoi)
  End Function
  Public Function ThemSach(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal soluongton As Integer, ByVal dongia As Integer)
    Return sach.ThemSach(masach, tensach, theloai, tacgia, soluongton, dongia)
  End Function
  Public Function SuaSach(ByVal masach As String, ByVal tensach As String, ByVal theloai As String, ByVal tacgia As String, ByVal dongia As Integer) As Boolean
    Return sach.SuaSach(masach, tensach, theloai, tacgia, dongia)
  End Function
  Public Function XoaSach(ByVal masach As String) As Boolean
    Return sach.XoaSach(masach)
  End Function
  Public Function LayDonGiaTheoMaSach(ByVal masach As String) As Double
    Return sach.LayDonGiaTheoMaSach(masach)
  End Function
End Class
