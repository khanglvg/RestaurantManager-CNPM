Imports System.Data.OleDb
Imports DTO
Public Class ThamSoDAL
  Public Function LayDuLieu() As ThamSo
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from ThamSo"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim thamso As ThamSo = New ThamSo()
    While reader.Read

      thamso.SoLuongNhapItNhat = reader.GetInt32(1)
      thamso.SoLuongTonToiDaTruocNhap = reader.GetInt32(2)
      thamso.SoLuongTonSauToiThieu = reader.GetInt32(3)
      thamso.SoTienNoToiDa = reader.GetInt32(4)
      thamso.SuDungQuyDinhSoTienNoToiDa = reader.GetBoolean(5)
    End While
    reader.Close()
    Return thamso
  End Function
  Public Function CapNhatDuLieu(ByVal soluongnhapitnhat As Integer, ByVal soluongtontoidatruocnhap As Integer, ByVal soluongtonsautoithieu As Integer, ByVal sotiennotoida As Double, ByVal sudungquydinhsotiennotoida As Boolean) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "update ThamSo set SoLuongNhapItNhat=@soluongnhapitnhat,SoLuongTonToiDaTruocNhap=@soluongtontoidatruocnhap,SoLuongTonSauToiThieu=@soluongtonsautoithieu,SoTienNoToiDa=@sotiennotoida,SuDungQuyDinhSoTienNoToiDa=@sudungquydinhsotiennotoida"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@soluongnhapitnhat", OleDbType.Integer).Value = soluongnhapitnhat
    command.Parameters.Add("@soluongtontoidatruocnhap", OleDbType.Integer).Value = soluongtontoidatruocnhap
    command.Parameters.Add("@soluongtonsautoithieu", OleDbType.Integer).Value = soluongtonsautoithieu
    command.Parameters.Add("@sotiennotoida", OleDbType.Double).Value = sotiennotoida
    command.Parameters.Add("@sudungquydinhsotiennotoida", OleDbType.Boolean).Value = sudungquydinhsotiennotoida
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq
  End Function
End Class
