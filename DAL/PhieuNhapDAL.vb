Imports DTO
Imports System.Data.OleDb
Public Class PhieuNhapDAL

  Public Function CapNhatThongTinVaoPhieuNhap(ByVal maphieunhap As String, ByVal ngaynhap As DateTime) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into PhieuNhap values(@maphieunhap,@ngaynhap)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieunhap", OleDbType.BSTR).Value = maphieunhap
    command.Parameters.Add("@ngaynhap", OleDbType.Date).Value = ngaynhap
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function KiemTraMaPhieuNhap(ByVal maphieunhap As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from PhieuNhap where MaPhieuNhap=@maphieunhap"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@maphieunhap", OleDbType.BSTR).Value = maphieunhap
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read
    reader.Close()
    Return kq
  End Function
End Class
