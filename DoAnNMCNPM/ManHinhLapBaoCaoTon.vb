Imports DTO
Imports BLL
Public Class ManHinhLapBaoCaoTon
  Dim baocaotonbll As BaoCaoTonBLL = New BaoCaoTonBLL()
  Dim sachbll As SachBLL = New SachBLL()
  Private Sub ManHinhLapBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiTatCalenListView()
  End Sub

  Private Sub HienThiTatCalenListView()
    Dim DSBCT As List(Of BaoCaoTon) = baocaotonbll.LayToanBoBaoCaoTon()
    Dim itembaocao As BaoCaoTon = New BaoCaoTon()
    For Each itembao In DSBCT
      Dim lvi As ListViewItem = New ListViewItem(itembao.MaChiTietTon)
      lvi.SubItems.Add(itembao.Thang)
      lvi.SubItems.Add(itembao.MaSach)
      lvi.SubItems.Add(itembao.TonDau)
      lvi.SubItems.Add(itembao.TonPhatSinh)
      lvi.SubItems.Add(itembao.TonCuoi)
      lvi.Tag = itembao.MaSach
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub lvDaTa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDaTa.SelectedIndexChanged
    If lvDaTa.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim masach As String = lvi.Tag
    Dim itemsach As Sach = sachbll.LaySachTheoMaSach(masach)
    txtTenSach.Text = itemsach.TenSach
  End Sub

  Private Sub btnHienThiTatCa_Click(sender As Object, e As EventArgs) Handles btnHienThiTatCa.Click
    lvDaTa.Items.Clear()
    HienThiTatCalenListView()
  End Sub

  Private Sub cboThangCanLapBaoCao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboThangCanLapBaoCao.SelectedIndexChanged
    lvDaTa.Items.Clear()
    If cboThangCanLapBaoCao.SelectedItem = -1 Then
      Return
    End If
    Dim thang As Integer = Integer.Parse(cboThangCanLapBaoCao.Text)
    Dim DSBC As List(Of BaoCaoTon) = baocaotonbll.LayTheoThang(thang)
    Dim itembc As BaoCaoTon = New BaoCaoTon()
    For Each itembc In DSBC
      Dim lvi As ListViewItem = New ListViewItem(itembc.MaChiTietTon)
      lvi.SubItems.Add(itembc.Thang)
      lvi.SubItems.Add(itembc.MaSach)
      lvi.SubItems.Add(itembc.TonDau)
      lvi.SubItems.Add(itembc.TonPhatSinh)
      lvi.SubItems.Add(itembc.TonCuoi)
      lvDaTa.Items.Add(lvi)
    Next
  End Sub
End Class