Imports DTO
Imports BLL
Public Class ManHinhThayDoiQuyDinh
  Dim thamsobll As ThamSoBLL = New ThamSoBLL()
  Private Sub ManHinhThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim ts As ThamSo = New ThamSo()
    ts = thamsobll.LayDuLieu()
    txtSoLuongNhatItNhat.Text = ts.SoLuongNhapItNhat.ToString()
    txtLuongTonToiDaTruocKhiNhap.Text = ts.SoLuongTonToiDaTruocNhap.ToString()
    txtTienNoToiDa.Text = ts.SoTienNoToiDa.ToString()
    txtLuongTonToiThieuSauKhiBan.Text = ts.SoLuongTonSauToiThieu.ToString()
    ckbSuDungTienNoToiDa.Checked = ts.SuDungQuyDinhSoTienNoToiDa
  End Sub

  Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
    Dim ret As DialogResult = MessageBox.Show("Bạn có chắc muốn thay đổi quy định không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    If ret = DialogResult.Yes Then
      Dim soluongnhapitnhat As Integer = Integer.Parse(txtSoLuongNhatItNhat.Text)
      Dim soluongtontoidatruocnhap As Integer = Integer.Parse(txtLuongTonToiDaTruocKhiNhap.Text)
      Dim soluongtonsautoithieu As Integer = Integer.Parse(txtLuongTonToiThieuSauKhiBan.Text)
      Dim sotiennotoida As Double = Double.Parse(txtTienNoToiDa.Text)
      Dim sudungquydinhsotiennotoida As Boolean = ckbSuDungTienNoToiDa.Checked
      Dim kq As Boolean = thamsobll.CapNhatDuLieu(soluongnhapitnhat, soluongtontoidatruocnhap, soluongtonsautoithieu, sotiennotoida, sudungquydinhsotiennotoida)
      If kq = True Then
        MessageBox.Show("Cập nhật quy định thành công")
      End If
    End If
  End Sub
End Class