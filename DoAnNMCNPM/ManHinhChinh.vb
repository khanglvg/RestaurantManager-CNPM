Public Class ManHinhChinh
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim frm As LapPhieuNhapSach = New LapPhieuNhapSach()
    frm.Show()
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    Dim frm1 As ManHinhLapHoaDonBanSach = New ManHinhLapHoaDonBanSach()
    frm1.Show()
  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    Dim frm2 As ManHinhLapPhieuThuTien = New ManHinhLapPhieuThuTien()
    frm2.Show()
  End Sub

  Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    Dim frm3 As ManHinhLapBaoCaoTon = New ManHinhLapBaoCaoTon()
    frm3.Show()
  End Sub

  Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    Dim frm4 As ManHinhLapBaoCaoCongNo = New ManHinhLapBaoCaoCongNo()
    frm4.Show()
  End Sub

  Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    Dim frm5 As ManHinhThayDoiQuyDinh = New ManHinhThayDoiQuyDinh()
    frm5.Show()
  End Sub
End Class