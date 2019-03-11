Imports DAL
Imports DTO
Public Class ThamSoBLL
  Dim thamso As ThamSoDAL = New ThamSoDAL
  Public Function LayDuLieu() As ThamSo
    Return thamso.LayDuLieu()
  End Function
  Public Function CapNhatDuLieu(ByVal soluongnhapitnhat As Integer, ByVal soluongtontoidatruocnhap As Integer, ByVal soluongtonsautoithieu As Integer, ByVal sotiennotoida As Double, ByVal sudungquydinhsotiennotoida As Boolean) As Boolean
    Return thamso.CapNhatDuLieu(soluongnhapitnhat, soluongtontoidatruocnhap, soluongtonsautoithieu, sotiennotoida, sudungquydinhsotiennotoida)
  End Function
End Class
