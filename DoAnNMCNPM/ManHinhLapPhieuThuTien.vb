Imports DTO
Imports BLL
Public Class ManHinhLapPhieuThuTien
  Dim khachhangbll As KhachHangBLL = New KhachHangBLL()
  Dim baocaocongnobll As BaoCaoCongNoBLL = New BaoCaoCongNoBLL()
  Dim phieuthutienbll As PhieuThuTienBLL = New PhieuThuTienBLL()
  Private Sub ManHinhLapPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiKhachHangLenListView()
  End Sub

  Private Sub HienThiKhachHangLenListView()
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    DSKH = khachhangbll.LayToanBoKhachHang()
    Dim itemkhachhang As KhachHang = New KhachHang()
    For Each itemkhachhang In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkhachhang.MaKhachHang)
      lvi.SubItems.Add(itemkhachhang.HoTenKhachHang)
      lvi.SubItems.Add(itemkhachhang.DiaChi)
      lvi.SubItems.Add(itemkhachhang.DienThoai)
      lvi.SubItems.Add(itemkhachhang.Email)
      lvi.SubItems.Add(itemkhachhang.SoTienNo)
      lvi.Tag = itemkhachhang.MaKhachHang
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged
    If lvData.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvData.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag

    Dim kh As KhachHang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    txtMaKhachHang.Text = kh.MaKhachHang
    txtHoTenKhachHang.Text = kh.HoTenKhachHang
    txtDiaChi.Text = kh.DiaChi
    txtDienThoai.Text = kh.DienThoai
    txtEmail.Text = kh.Email
    txtSoTienNo.Text = kh.SoTienNo.ToString()

  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    lvData.Items.Clear()
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim khachhang As KhachHang = New KhachHang()
    khachhang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    Dim lvi As ListViewItem = New ListViewItem(khachhang.MaKhachHang)
    lvi.SubItems.Add(khachhang.HoTenKhachHang)
    lvi.SubItems.Add(khachhang.DiaChi)
    lvi.SubItems.Add(khachhang.DienThoai)
    lvi.SubItems.Add(khachhang.Email)
    lvi.SubItems.Add(khachhang.SoTienNo)
    lvi.Tag = khachhang.MaKhachHang
    lvData.Items.Add(lvi)
    LamMoi()
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    lvData.Items.Clear()
    Dim tenkhachhang As String = txtHoTenKhachHang.Text
    Dim DSKH As List(Of KhachHang) = khachhangbll.LayKhachHangTheoTen(tenkhachhang)
    Dim itemkh As KhachHang = New KhachHang()
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      lvi.Tag = itemkh.MaKhachHang
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    lvData.Items.Clear()
    Dim diachi As String = txtDiaChi.Text
    Dim DSKH As List(Of KhachHang) = khachhangbll.LayKhachHangTheoDiaChi(diachi)
    Dim itemkh As KhachHang = New KhachHang()
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      lvi.Tag = itemkh.MaKhachHang
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    lvData.Items.Clear()
    Dim dienthoai As String = txtDienThoai.Text
    Dim DSKH As List(Of KhachHang) = khachhangbll.LayKhachHangTheoSoDienThoai(dienthoai)
    Dim itemkh As KhachHang = New KhachHang()
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      lvi.Tag = itemkh.MaKhachHang
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    lvData.Items.Clear()
    Dim email As String = txtEmail.Text
    Dim DSKH As List(Of KhachHang) = New List(Of KhachHang)
    Dim itemkh As KhachHang = New KhachHang()
    DSKH = khachhangbll.LayKhachHangTheoEmail(email)
    For Each itemkh In DSKH
      Dim lvi As ListViewItem = New ListViewItem(itemkh.MaKhachHang)
      lvi.SubItems.Add(itemkh.HoTenKhachHang)
      lvi.SubItems.Add(itemkh.DiaChi)
      lvi.SubItems.Add(itemkh.DienThoai)
      lvi.SubItems.Add(itemkh.Email)
      lvi.SubItems.Add(itemkh.SoTienNo)
      lvi.Tag = itemkh.MaKhachHang
      lvData.Items.Add(lvi)
      LamMoi()
    Next
  End Sub

  Private Sub btnHienThiToanBoKhachHang_Click(sender As Object, e As EventArgs) Handles btnHienThiToanBoKhachHang.Click
    lvData.Items.Clear()
    HienThiKhachHangLenListView()
    LamMoi()
  End Sub
  Sub LamMoi()
    txtMaKhachHang.Text = ""
    txtHoTenKhachHang.Text = ""
    txtDiaChi.Text = ""
    txtDienThoai.Text = ""
    txtEmail.Text = ""
    txtSoTienNo.Text = ""
    txtSoTienThu.Text = ""
    txtMaKhachHang.Focus()
  End Sub

  Private Sub btnThuTien_Click(sender As Object, e As EventArgs) Handles btnThuTien.Click
    Dim sotienthu As Double = Double.Parse(txtSoTienThu.Text)
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim sotienno As Double = khachhangbll.LaySoTienNoTheoMaKhachHang(makhachhang)
    If sotienthu > sotienno Then
      MessageBox.Show("Số tiền thu lớn hơn số tiền khách hàng nợ rồi!!!")
      Return
    End If
    Dim baocao As BaoCaoCongNo = New BaoCaoCongNo()
    baocao = baocaocongnobll.LayDuLieuTheoMaKhachHang(makhachhang)
    Dim nodau As Double = 0
    Dim nocuoi As Double = 0
    Dim nophatsinh As Double = 0
    If baocao.NoDau = sotienno Then
      nodau = baocao.NoDau
      nocuoi = sotienno
      nophatsinh = 0
      Dim baocaocongnoo As ManHinhBaoCaoCongNo = New ManHinhBaoCaoCongNo()
      baocaocongnoo.txtThang.Text = dtNgayThuTien.Value.Month
      baocaocongnoo.txtMaKhachHang.Text = makhachhang
      baocaocongnoo.txtNoDau.Text = nodau.ToString()
      baocaocongnoo.txtNoCuoi.Text = nocuoi.ToString()
      baocaocongnoo.txtNoPhatSinh.Text = nophatsinh.ToString()
      If baocaocongnoo.ShowDialog() = DialogResult.OK Then
        Dim machitietcongno As String = baocaocongnoo.txtMaChiTietCongNo.Text
        Dim thang As Integer = Integer.Parse(baocaocongnoo.txtThang.Text)
        Dim makhachhangg As String = baocaocongnoo.txtMaKhachHang.Text
        Dim nodauu As Double = Double.Parse(baocaocongnoo.txtNoDau.Text)
        Dim nocuoii As Double = Double.Parse(baocaocongnoo.txtNoCuoi.Text)
        Dim nophatsinhh As Double = Double.Parse(baocaocongnoo.txtNoPhatSinh.Text)
        Dim kt As Boolean = baocaocongnobll.CapNhatDuLieu(machitietcongno, thang, makhachhangg, nodauu, nocuoii, nophatsinhh)
        If kt = True Then
          MessageBox.Show("Cập nhật báo cáo công nợ thành công")
        ElseIf kt = False Then
          MessageBox.Show("Mã chi tiết công nợ này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
    End If
    nodau = baocao.NoDau
    nocuoi = baocao.NoCuoi - sotienthu
    nophatsinh = baocao.NoPhatSinh - sotienthu
    Dim baocaocongno As ManHinhBaoCaoCongNo = New ManHinhBaoCaoCongNo()
    baocaocongno.txtThang.Text = dtNgayThuTien.Value.Month
    baocaocongno.txtMaKhachHang.Text = makhachhang
    baocaocongno.txtNoDau.Text = nodau.ToString()
    baocaocongno.txtNoCuoi.Text = nocuoi.ToString()
    baocaocongno.txtNoPhatSinh.Text = nophatsinh.ToString()
    If baocaocongno.ShowDialog() = DialogResult.OK Then
      Dim machitietcongno As String = baocaocongno.txtMaChiTietCongNo.Text
      Dim thang As Integer = Integer.Parse(baocaocongno.txtThang.Text)
      Dim makhachhangg As String = baocaocongno.txtMaKhachHang.Text
      Dim nodauu As Double = Double.Parse(baocaocongno.txtNoDau.Text)
      Dim nocuoii As Double = Double.Parse(baocaocongno.txtNoCuoi.Text)
      Dim nophatsinhh As Double = Double.Parse(baocaocongno.txtNoPhatSinh.Text)
      Dim kt As Boolean = baocaocongnobll.CapNhatDuLieu(machitietcongno, thang, makhachhangg, nodauu, nocuoii, nophatsinhh)
      If kt = True Then
        MessageBox.Show("Cập nhật báo cáo công nợ thành công")
      ElseIf kt = False Then
        MessageBox.Show("Mã chi tiết công nợ này đã tồn tại rồi,vui lòng nhập lại")
        Return
      End If
    End If
    Dim phieuthutien As ManHinhPhieuThuTien = New ManHinhPhieuThuTien()
    phieuthutien.txtSoTienThu.Text = txtSoTienThu.Text
    phieuthutien.dtNgayThuTien.Value = dtNgayThuTien.Value
    phieuthutien.txtMaKhachHang.Text = txtMaKhachHang.Text
    If phieuthutien.ShowDialog() = DialogResult.OK Then
      Dim machitietphieuthu As String = phieuthutien.txtMaPhieuThu.Text
      Dim sotienthuuu As Double = Double.Parse(phieuthutien.txtSoTienThu.Text)
      Dim ngaythutienn As DateTime = phieuthutien.dtNgayThuTien.Value
      Dim makhach As String = phieuthutien.txtMaKhachHang.Text
      Dim kiemtra As Boolean = phieuthutienbll.CapNhatPhieuThuTien(machitietphieuthu, sotienthuuu, ngaythutienn, makhach)
      If kiemtra = True Then
        MessageBox.Show("Cập nhật phiếu thu tiền thành công")
      ElseIf kiemtra = False Then
        MessageBox.Show("Mã chi tiết phiếu thu này đã tồn tại rồi,vui lòng nhập lại")
        Return
      End If
    End If
    Dim sotiennomoi As Double = sotienno - sotienthu
    Dim kq As Boolean = khachhangbll.CapNhatTienNoMoiTheoMaKhachHang(makhachhang, sotiennomoi)
    If kq = True Then
      MessageBox.Show("Thu tiền thành công")
      lvData.Items.Clear()
      HienThiKhachHangLenListView()
      LamMoi()
    End If
  End Sub
End Class