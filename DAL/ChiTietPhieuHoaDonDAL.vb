Imports DTO
Imports System.Data.OleDb
Public Class ChiTietPhieuHoaDonDAL
  Public Function KiemTraMaChiTietPhieuHoaDon(ByVal machitietphieuhoadon As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from ChiTietPhieuHoaDon where MaChiTietPhieuHoaDon=@machitietphieuhoadon"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietphieuhoadon", OleDbType.BSTR).Value = machitietphieuhoadon
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function CapNhapChiTietPhieuHoaDon(ByVal machitietphieuhoadon As String, ByVal maphieuhoadon As String, ByVal masach As String, ByVal soluongban As Integer) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into ChiTietPhieuHoaDon values(@machitietphieuhoadon,@maphieuhoadon,@masach,@soluongban)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietphieuhoadon", OleDbType.BSTR).Value = machitietphieuhoadon
    command.Parameters.Add("@maphieuhoadon", OleDbType.BSTR).Value = maphieuhoadon
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    command.Parameters.Add("@soluongban", OleDbType.Integer).Value = soluongban
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
End Class
