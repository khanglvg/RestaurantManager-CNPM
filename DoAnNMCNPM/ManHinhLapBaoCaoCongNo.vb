Imports DTO
Imports BLL
Public Class ManHinhLapBaoCaoCongNo
  Dim baocaocongnobll As BaoCaoCongNoBLL = New BaoCaoCongNoBLL()
  Dim khachhangbll As KhachHangBLL = New KhachHangBLL()
  Private Sub ManHinhLapBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiTatCaLenListView()
  End Sub

  Private Sub HienThiTatCaLenListView()
    Dim DSBC As List(Of BaoCaoCongNo) = baocaocongnobll.LayToanBoDuLieu()
    Dim itembaocao As BaoCaoCongNo = New BaoCaoCongNo()
    For Each itembaocao In DSBC
      Dim lvi As ListViewItem = New ListViewItem(itembaocao.MaChiTietCongNo)
      lvi.SubItems.Add(itembaocao.Thang)
      lvi.SubItems.Add(itembaocao.MaKhachHang)
      lvi.SubItems.Add(itembaocao.NoDau)
      lvi.SubItems.Add(itembaocao.NoCuoi)
      lvi.SubItems.Add(itembaocao.NoPhatSinh)
      lvi.Tag = itembaocao.MaKhachHang
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub lvDaTa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDaTa.SelectedIndexChanged
    If lvDaTa.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag
    Dim kh As KhachHang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    txtTenKhachHang.Text = kh.HoTenKhachHang
  End Sub

  Private Sub cboThangCanLamBaoCao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboThangCanLamBaoCao.SelectedIndexChanged
    lvDaTa.Items.Clear()
    If cboThangCanLamBaoCao.SelectedIndex = -1 Then
      Return
    End If
    Dim thang As Integer = Integer.Parse(cboThangCanLamBaoCao.Text)
    Dim DSBC As List(Of BaoCaoCongNo) = baocaocongnobll.LayTheoThang(thang)
    Dim itembc As BaoCaoCongNo = New BaoCaoCongNo()
    For Each itembc In DSBC
      Dim lvi As ListViewItem = New ListViewItem(itembc.MaChiTietCongNo)
      lvi.SubItems.Add(itembc.Thang)
      lvi.SubItems.Add(itembc.MaKhachHang)
      lvi.SubItems.Add(itembc.NoDau)
      lvi.SubItems.Add(itembc.NoCuoi)
      lvi.SubItems.Add(itembc.NoPhatSinh)
      lvi.Tag = itembc.MaKhachHang
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnHienThiTatCa_Click(sender As Object, e As EventArgs) Handles btnHienThiTatCa.Click
    lvDaTa.Items.Clear()
    HienThiTatCaLenListView()
  End Sub
End Class