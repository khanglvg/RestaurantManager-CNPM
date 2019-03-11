Imports BLL
Imports DTO
Public Class manhinhphieunhap
  Dim phieunhap As PhieuNhapBLL = New PhieuNhapBLL()
  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    DialogResult = DialogResult.OK
  End Sub
End Class