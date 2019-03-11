Imports DTO
Imports System.Data.OleDb
Public Class PhieuHoaDonDAL
  Public Function CapNhatPhieuHoaDon(ByVal maphieuhoadon As String, ByVal makhachhang As String, ByVal ngaylaphoadon As DateTime) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into PhieuHoaDon values(@maphieuhoadon,@makhachhang,@ngaylaphoadon)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieuhoadon", OleDbType.BSTR).Value = maphieuhoadon
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    command.Parameters.Add("@ngaylaphoadon", OleDbType.Date).Value = ngaylaphoadon
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function KiemtraMaPhieuHoaDon(ByVal maphieuhoadon As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from PhieuHoaDon where MaPhieuHoaDon=@maphieuhoadon"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieuhoadon", OleDbType.BSTR).Value = maphieuhoadon
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
End Class
