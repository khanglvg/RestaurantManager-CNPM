Imports DTO
Imports System.Data.OleDb
Public Class BaoCaoTonDAL
  Public Function CapNhapBaoCaoTon(ByVal mabaocaoton As String, ByVal thang As Integer, ByVal masach As String, ByVal tondau As Integer, ByVal tonphatsinh As Integer, ByVal toncuoi As Integer) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into BaoCaoTon values(@mabaocaoton,@thang,@masach,@tondau,@tonphatsinh,@toncuoi)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@mabaocaoton", OleDbType.BSTR).Value = mabaocaoton
    command.Parameters.Add("@thang", OleDbType.Integer).Value = thang
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    command.Parameters.Add("@tondau", OleDbType.Integer).Value = tondau
    command.Parameters.Add("@tonphatsinh", OleDbType.Integer).Value = tonphatsinh
    command.Parameters.Add("@toncuoi", OleDbType.Integer).Value = toncuoi
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function LayTonDauTheoMaSach(ByVal masach As String) As BaoCaoTon
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoTon where MaSach=@masach"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@masach", OleDbType.BSTR).Value = masach
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim baocaoton As BaoCaoTon = New BaoCaoTon()
    If reader.Read() Then
      baocaoton.MaChiTietTon = reader.GetString(0)
      baocaoton.Thang = reader.GetInt32(1)
      baocaoton.MaSach = reader.GetString(2)
      baocaoton.TonDau = reader.GetInt32(3)
      baocaoton.TonPhatSinh = reader.GetInt32(4)
      baocaoton.TonCuoi = reader.GetInt32(5)
    End If
    reader.Close()
    Return baocaoton
  End Function
  Public Function KiemTraMaChiTietTon(ByVal machitietton As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoTon where MaChiTietTon=@machitietton"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@machitietton", OleDbType.BSTR).Value = machitietton
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function LayToanBoBaoCaoTon() As List(Of BaoCaoTon)
    Dim DSBCT As List(Of BaoCaoTon) = New List(Of BaoCaoTon)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoTon"
    command.Connection = DataAccess.connection
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim baocaoton As BaoCaoTon = New BaoCaoTon()
      baocaoton.MaChiTietTon = reader.GetString(0)
      baocaoton.Thang = reader.GetInt32(1)
      baocaoton.MaSach = reader.GetString(2)
      baocaoton.TonDau = reader.GetInt32(3)
      baocaoton.TonPhatSinh = reader.GetInt32(4)
      baocaoton.TonCuoi = reader.GetInt32(5)
      DSBCT.Add(baocaoton)
    End While
    reader.Close()
    Return DSBCT
  End Function
  Public Function LayTheoThang(ByVal thang As Integer) As List(Of BaoCaoTon)
    Dim DSBCT As List(Of BaoCaoTon) = New List(Of BaoCaoTon)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from BaoCaoTon where Thang=@thang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@thang", OleDbType.Integer).Value = thang
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim baocao As BaoCaoTon = New BaoCaoTon()
      baocao.MaChiTietTon = reader.GetString(0)
      baocao.Thang = reader.GetInt32(1)
      baocao.MaSach = reader.GetString(2)
      baocao.TonDau = reader.GetInt32(3)
      baocao.TonPhatSinh = reader.GetInt32(4)
      baocao.TonCuoi = reader.GetInt32(5)
      DSBCT.Add(baocao)
    End While
    reader.Close()
    Return DSBCT
  End Function
End Class
