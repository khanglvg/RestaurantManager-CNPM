Imports System.Data.OleDb
Public Class DataAccess
  Public Shared connection As OleDbConnection
  Shared Sub Openconnection()
    connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDL.accdb")
    If connection.State = ConnectionState.Closed Then
      connection.Open()
    End If
  End Sub
  Shared Sub Closeconnection()
    connection.Close()
  End Sub
End Class
