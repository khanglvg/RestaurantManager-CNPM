Imports DTO
Imports System.Data.OleDb
Public Class KhachHangDAL
    Public Function LayToanBoKhachHang() As List(Of KhachHang)
        Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
        DataAccess.Openconnection()
        Dim command As OleDbCommand = New OleDbCommand()
        command.CommandType = CommandType.Text
        command.CommandText = "select * from KhachHang"
        command.Connection = DataAccess.connection
        Dim reader As OleDbDataReader = command.ExecuteReader()
        While reader.Read()
            Dim khachhang As KhachHang = New KhachHang()
            khachhang.MaKhachHang = reader.GetString(0)
            khachhang.HoTenKhachHang = reader.GetString(1)
            khachhang.DiaChi = reader.GetString(2)
            khachhang.DienThoai = reader.GetString(3)
            khachhang.Email = reader.GetString(4)
            khachhang.SoTienNo = reader.GetInt32(5)
            DSKH.Add(khachhang)
        End While
        reader.Close()
        Return DSKH
    End Function

    Public Function LayKhachHangTheoMa(ByVal makhachhang As String) As KhachHang
    Dim khachhang As KhachHang = New KhachHang()
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from KhachHang where MaKhachHang=@makhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim reader As OleDbDataReader = command.ExecuteReader()
    If reader.Read() Then
      khachhang.MaKhachHang = reader.GetString(0)
      khachhang.HoTenKhachHang = reader.GetString(1)
      khachhang.DiaChi = reader.GetString(2)
      khachhang.DienThoai = reader.GetString(3)
      khachhang.Email = reader.GetString(4)
      khachhang.SoTienNo = reader.GetInt32(5)
    End If
    reader.Close()
    Return khachhang
  End Function
  Public Function LayKhachHangTheoTen(ByVal tenkhachhang As String) As List(Of KhachHang)
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from KhachHang where HoTenKhachHang like @tenkhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@tenkhachhang", OleDbType.BSTR).Value = "%" + tenkhachhang + "%"
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim kh As KhachHang = New KhachHang()
      kh.MaKhachHang = reader.GetString(0)
      kh.HoTenKhachHang = reader.GetString(1)
      kh.DiaChi = reader.GetString(2)
      kh.DienThoai = reader.GetString(3)
      kh.Email = reader.GetString(4)
      kh.SoTienNo = reader.GetInt32(5)
      DSKH.Add(kh)
    End While
    reader.Close()
    Return DSKH
  End Function
  Public Function LayKhachHangTheoDiaChi(ByVal diachi As String) As List(Of KhachHang)
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from KhachHang where DiaChi like @diachi"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@diachi", OleDbType.BSTR).Value = "%" + diachi + "%"
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim kh As KhachHang = New KhachHang()
      kh.MaKhachHang = reader.GetString(0)
      kh.HoTenKhachHang = reader.GetString(1)
      kh.DiaChi = reader.GetString(2)
      kh.DienThoai = reader.GetString(3)
      kh.Email = reader.GetString(4)
      kh.SoTienNo = reader.GetInt32(5)
      DSKH.Add(kh)
    End While
    reader.Close()
    Return DSKH
  End Function
  Public Function LayKhachHangTheoSoDienThoai(ByVal dienthoai As String) As List(Of KhachHang)
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from KhachHang where DienThoai like @dienthoai"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@dienthoai", OleDbType.BSTR).Value = "%" + dienthoai + "%"
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim kh As KhachHang = New KhachHang()
      kh.MaKhachHang = reader.GetString(0)
      kh.HoTenKhachHang = reader.GetString(1)
      kh.DiaChi = reader.GetString(2)
      kh.DienThoai = reader.GetString(3)
      kh.Email = reader.GetString(4)
      kh.SoTienNo = reader.GetInt32(5)
      DSKH.Add(kh)
    End While
    reader.Close()
    Return DSKH
  End Function
  Public Function LayKhachHangTheoEmail(ByVal email As String) As List(Of KhachHang)
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from KhachHang where Email like @email"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@email", OleDbType.BSTR).Value = "%" + email + "%"
    Dim reader As OleDbDataReader = command.ExecuteReader()
    While reader.Read()
      Dim kh As KhachHang = New KhachHang()
      kh.MaKhachHang = reader.GetString(0)
      kh.HoTenKhachHang = reader.GetString(1)
      kh.DiaChi = reader.GetString(2)
      kh.DienThoai = reader.GetString(3)
      kh.Email = reader.GetString(4)
      kh.SoTienNo = reader.GetInt32(5)
      DSKH.Add(kh)
    End While
    reader.Close()
    Return DSKH
  End Function
  Public Function ThemKhachHang(ByVal makhachhang As String, ByVal hotenkhachhang As String, ByVal diachi As String, ByVal dienthoai As String, ByVal email As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "insert into KhachHang values(@makhachhang,@hotenkhachhang,@diachi,@dienthoai,@email,@sotienno)"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    command.Parameters.Add("@hotenkhachhang", OleDbType.BSTR).Value = hotenkhachhang
    command.Parameters.Add("@diachi", OleDbType.BSTR).Value = diachi
    command.Parameters.Add("@dienthoai", OleDbType.BSTR).Value = dienthoai
    command.Parameters.Add("@email", OleDbType.BSTR).Value = email
    command.Parameters.Add("@sotienno", OleDbType.Integer).Value = 0
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function KiemTraMaKhachHang(ByVal makhachhang As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from KhachHang where MaKhachHang=@makhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim reader As OleDbDataReader = command.ExecuteReader()
    Dim kq As Boolean = reader.Read()
    reader.Close()
    Return kq
  End Function
  Public Function SuaKhachHang(ByVal makhachhang As String, ByVal hotenkhachhang As String, ByVal diachi As String, ByVal dienthoai As String, ByVal email As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "update KhachHang set HoTenKhachHang=@hotenkhachhang,DiaChi=@diachi,DienThoai=@dienthoai,Email=@email where MaKhachHang=@makhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@hotenkhachhang", OleDbType.BSTR).Value = hotenkhachhang
    command.Parameters.Add("@diachi", OleDbType.BSTR).Value = diachi
    command.Parameters.Add("@dienthoai", OleDbType.BSTR).Value = dienthoai
    command.Parameters.Add("@email", OleDbType.BSTR).Value = email
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function XoaKhachHang(ByVal makhachhang As String) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "delete from KhachHang where MaKhachHang=@makhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
  Public Function LaySoTienNoTheoMaKhachHang(ByVal makhachhang As String) As Double
    Dim sotienno As Double = 0
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "select * from KhachHang where MaKhachHang=@makhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim reader As OleDbDataReader = command.ExecuteReader()
    If reader.Read() Then
      sotienno = reader.GetInt32(5)
    End If
    reader.Close()
    Return sotienno
  End Function
  Public Function CapNhatTienNoMoiTheoMaKhachHang(ByVal makhachhang As String, ByVal sotiennomoi As Double) As Boolean
    DataAccess.Openconnection()
    Dim command As OleDbCommand = New OleDbCommand()
    command.CommandType = CommandType.Text
    command.CommandText = "update KhachHang set SoTienNo=@sotienno where MaKhachHang=@makhachhang"
    command.Connection = DataAccess.connection
    command.Parameters.Add("@sotienno", OleDbType.Double).Value = sotiennomoi
    command.Parameters.Add("@makhachhang", OleDbType.BSTR).Value = makhachhang
    Dim kq As Integer = command.ExecuteNonQuery()
    Return kq > 0
  End Function
End Class
