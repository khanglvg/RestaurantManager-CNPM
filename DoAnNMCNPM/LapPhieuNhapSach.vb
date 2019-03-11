Imports BLL
Imports DTO
Public Class LapPhieuNhapSach
  Dim thamsobll As ThamSoBLL = New ThamSoBLL()
  Dim sachbll As SachBLL = New SachBLL()
  Dim phieunhapbll As PhieuNhapBLL = New PhieuNhapBLL()
  Dim chitietphieunhapbll As ChiTietPhieuNhapBLL = New ChiTietPhieuNhapBLL()
  Dim baocaotonbll As BaoCaoTonBLL = New BaoCaoTonBLL()
  Private Sub LapPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiQuyDinh()
    HienThiToanBoSachLenListView()

  End Sub

  Private Sub HienThiToanBoSachLenListView()
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LayToanBoSach()
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 250)
    lvData.Columns.Add("Thể loại", 150)
    lvData.Columns.Add("Tác giả", 250)
    lvData.Columns.Add("Số lượng tồn", 150)
    lvData.Columns.Add("Đơn giá", 200)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub HienThiQuyDinh()
    Dim thamso As ThamSo = New ThamSo()
    thamso = thamsobll.LayDuLieu()
    txtSoLuongNhapItNhat.Text = thamso.SoLuongNhapItNhat
    txtSoLuongTonToiDaTruocNhap.Text = thamso.SoLuongTonToiDaTruocNhap
  End Sub

  Private Sub lvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvData.SelectedIndexChanged
    If lvData.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvData.SelectedItems(0)
    Dim masach As String = lvi.Tag.ToString()
    HienThiThongTinChiTietCho1QuyenSach(masach)
  End Sub

  Private Sub HienThiThongTinChiTietCho1QuyenSach(masach As String)
    Dim sach As Sach = New Sach()
    sach = sachbll.LaySachTheoMaSach(masach)
    txtMaSach.Text = sach.MaSach
    txtTenSach.Text = sach.TenSach
    txtTheLoai.Text = sach.TheLoai
    txtTacGia.Text = sach.TacGia
    txtSoLuongTon.Text = sach.SoLuongTon
    txtDonGia.Text = sach.DonGia
  End Sub

  Private Sub btnTimSach_Click(sender As Object, e As EventArgs) Handles btnTimSach.Click
    Dim masach As String = txtMaSach.Text
    Dim kq As Boolean = sachbll.KiemTraMaSach(masach)
    If kq = True Then
      HienThiSachTheoMaSach(masach)
      btnLamMoi.PerformClick()
    ElseIf kq = False Then
      MessageBox.Show("Mã không tồn tại")
      btnLamMoi.PerformClick()
    End If
  End Sub

  Private Sub HienThiSachTheoMaSach(masach As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 250)
    lvData.Columns.Add("Thể loại", 150)
    lvData.Columns.Add("Tác giả", 250)
    lvData.Columns.Add("Số lượng tồn", 150)
    lvData.Columns.Add("Đơn giá", 200)
    Dim sach As Sach = sachbll.LaySachTheoMaSach(masach)
    Dim lvi As ListViewItem = New ListViewItem(sach.MaSach)
    lvi.SubItems.Add(sach.TenSach)
    lvi.SubItems.Add(sach.TheLoai)
    lvi.SubItems.Add(sach.TacGia)
    lvi.SubItems.Add(sach.SoLuongTon)
    lvi.SubItems.Add(sach.DonGia)
    lvi.Tag = sach.MaSach
    lvData.Items.Add(lvi)
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTen.Click
    Dim tensach As String = txtTenSach.Text
    HienThiSachTheoTenSach(tensach)
    btnLamMoi.PerformClick()
  End Sub

  Private Sub HienThiSachTheoTenSach(tensach As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 250)
    lvData.Columns.Add("Thể loại", 150)
    lvData.Columns.Add("Tác giả", 250)
    lvData.Columns.Add("Số lượng tồn", 150)
    lvData.Columns.Add("Đơn giá", 200)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTen(tensach)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimSachTheoTheLoai_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTheLoai.Click
    Dim theloai As String = txtTheLoai.Text
    HienThiSachTheoTheLoai(theloai)
    btnLamMoi.PerformClick()
  End Sub

  Private Sub HienThiSachTheoTheLoai(theloai As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 250)
    lvData.Columns.Add("Thể loại", 150)
    lvData.Columns.Add("Tác giả", 250)
    lvData.Columns.Add("Số lượng tồn", 150)
    lvData.Columns.Add("Đơn giá", 200)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTheLoai(theloai)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimSachTheoTacGia_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoTacGia.Click
    Dim tacgia As String = txtTacGia.Text
    HienThiSachTheoTacGia(tacgia)
    btnLamMoi.PerformClick()
  End Sub

  Private Sub HienThiSachTheoTacGia(tacgia As String)
    lvData.Items.Clear()
    lvData.Columns.Clear()
    lvData.Columns.Add("Mã sách", 150)
    lvData.Columns.Add("Tên sách", 250)
    lvData.Columns.Add("Thể loại", 150)
    lvData.Columns.Add("Tác giả", 250)
    lvData.Columns.Add("Số lượng tồn", 150)
    lvData.Columns.Add("Đơn giá", 200)
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LaySachTheoTacGia(tacgia)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvData.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnToanBo_Click(sender As Object, e As EventArgs) Handles btnToanBo.Click
    HienThiToanBoSachLenListView()
  End Sub

  Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
    txtMaSach.Text = ""
    txtTenSach.Text = ""
    txtTheLoai.Text = ""
    txtTacGia.Text = ""
    txtSoLuongNhap.Text = ""
    txtSoLuongTon.Text = ""
    txtDonGia.Text = ""
    txtMaSach.Focus()
  End Sub

  Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
    Dim quydinhsoluongnhapitnhat As Integer = Integer.Parse(txtSoLuongNhapItNhat.Text)
    Dim quydinhsoluongtontoidatruocnhap As Integer = Integer.Parse(txtSoLuongTonToiDaTruocNhap.Text)
    If txtMaSach.Text = "" Then
      MessageBox.Show("Chưa nhập mã sách")
      Return
    End If
    If txtTenSach.Text = "" Then
      MessageBox.Show("Chưa nhập tên sách")
      Return
    End If
    If txtTheLoai.Text = "" Then
      MessageBox.Show("Chưa nhập thể loại sách")
      Return
    End If
    If txtTacGia.Text = "" Then
      MessageBox.Show("Chưa nhập tác giả")
      Return
    End If
    If txtDonGia.Text = "" Then
      MessageBox.Show("Chưa nhập đơn giá")
      Return
    End If
    Dim kq As Boolean = sachbll.KiemTraMaSach(txtMaSach.Text)
    If kq = True Then       ' mã sách có tồn tại trong kho sách
      Dim soluongtoncu As Integer = sachbll.LaySoLuongTonTheoMaSach(txtMaSach.Text)
      If soluongtoncu >= quydinhsoluongtontoidatruocnhap Then
        MessageBox.Show("Sách này tồn kho nhiều rồi , không nhập thêm được nữa !!!")
        Return
      End If
      Dim soluongnhap As Integer = Integer.Parse(txtSoLuongNhap.Text)
      If soluongnhap < quydinhsoluongnhapitnhat Then
        MessageBox.Show("Nhập quá ít , không cho nhập")
        Return
      End If
      Dim phieunhap As manhinhphieunhap = New manhinhphieunhap()
      Dim str As String = ""
      Dim thang As Integer = 0
      If phieunhap.ShowDialog() = DialogResult.OK Then
        Dim maphieunhap As String = phieunhap.txtMaPhieuNHap.Text
        str = maphieunhap
        Dim ngaynhap As DateTime = phieunhap.dtNgayNhap.Value
        thang = ngaynhap.Month
        Dim kt As Boolean = phieunhapbll.CapNhatThongTinVaoPhieuNhap(maphieunhap, ngaynhap)
        If kt = True Then
          MessageBox.Show("Cập nhật phiếu nhập thành công")
        ElseIf kt = False Then
          MessageBox.Show("Mã phiếu nhập đã tồn tại rồi")
          Return
        End If
      End If
      Dim chitietphieunhap As ManHinhChiTietPhieuNhap = New ManHinhChiTietPhieuNhap()
      chitietphieunhap.txtMaPhieuNhap.Text = str
      chitietphieunhap.txtMaSach.Text = txtMaSach.Text
      chitietphieunhap.txtSoLuongNhap.Text = txtSoLuongNhap.Text
      If chitietphieunhap.ShowDialog() = DialogResult.OK Then
        Dim machitietphieunhap As String = chitietphieunhap.txtMaChiTietPhieuNhap.Text
        Dim maphieunhapp As String = chitietphieunhap.txtMaPhieuNhap.Text
        Dim masachh As String = chitietphieunhap.txtMaSach.Text
        Dim soluongnhapp As Integer = Integer.Parse(chitietphieunhap.txtSoLuongNhap.Text)
        Dim ktt As Boolean = chitietphieunhapbll.CapNhatChiTietPhieuNhap(machitietphieunhap, maphieunhapp, masachh, soluongnhapp)
        If ktt = True Then
          MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công")
        ElseIf ktt = False Then
          MessageBox.Show("Mã chi tiết phiếu nhập đã tồn tại , vui lòng nhập lại")
          Dim a = 5
          Return
        End If
      End If
      Dim ton As BaoCaoTon = baocaotonbll.LayTonDauTheoMaSach(txtMaSach.Text)
      If ton.TonDau = soluongtoncu Then
        Dim baocaoton As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
        baocaoton.txtMaSach.Text = txtMaSach.Text
        baocaoton.txtThang.Text = thang.ToString()
        baocaoton.txtTonDau.Text = ton.TonDau.ToString()
        baocaoton.txtTonPhatSinh.Text = "0"
        baocaoton.txtTonCuoi.Text = soluongtoncu.ToString
        If baocaoton.ShowDialog() = DialogResult.OK Then
          Dim machitietton As String = baocaoton.txtMaChiTietTon.Text
          Dim thangg As Integer = Integer.Parse(baocaoton.txtThang.Text)
          Dim masah As String = baocaoton.txtMaSach.Text
          Dim tondauu As Integer = Integer.Parse(baocaoton.txtTonDau.Text)
          Dim tonphatsinh As Integer = Integer.Parse(baocaoton.txtTonPhatSinh.Text)
          Dim toncuoi As Integer = Integer.Parse(baocaoton.txtTonCuoi.Text)
          Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thangg, masah, tondauu, tonphatsinh, toncuoi)
          If kimtra Then
            MessageBox.Show("Cập nhật báo cáo tồn thành công")
          ElseIf kimtra = False Then
            MessageBox.Show("Mã chi tiết tồn đã tồn tại , vui lòng nhập lại")
            Return
          End If
        End If
      ElseIf ton.TonDau <> soluongtoncu Then
        Dim baocaoton As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
        baocaoton.txtMaSach.Text = txtMaSach.Text
        baocaoton.txtThang.Text = thang.ToString()
        baocaoton.txtTonDau.Text = ton.TonDau.ToString()
        Dim tonphatsinhmoi As Integer = ton.TonPhatSinh + soluongnhap
        baocaoton.txtTonPhatSinh.Text = tonphatsinhmoi.ToString()
        Dim toncuoimoi As Integer = ton.TonCuoi + soluongnhap
        baocaoton.txtTonCuoi.Text = tonphatsinhmoi.ToString()
        If baocaoton.ShowDialog() = DialogResult.OK Then
          Dim machitietton As String = baocaoton.txtMaChiTietTon.Text
          Dim thangg As Integer = Integer.Parse(baocaoton.txtThang.Text)
          Dim masah As String = baocaoton.txtMaSach.Text
          Dim tondauu As Integer = Integer.Parse(baocaoton.txtTonDau.Text)
          Dim tonphatsinh As Integer = Integer.Parse(baocaoton.txtTonPhatSinh.Text)
          Dim toncuoi As Integer = Integer.Parse(baocaoton.txtTonCuoi.Text)
          Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thangg, masah, tondauu, tonphatsinh, toncuoi)
          If kimtra Then
            MessageBox.Show("Cập nhật báo cáo tồn thành công")
          ElseIf kimtra = False Then
            MessageBox.Show("Mã chi tiết tồn đã tồn tại, vui lòng nhập lại")
            Return
          End If
        End If
      End If
      Dim soluongtonmoi As Integer = soluongtoncu + soluongnhap
      Dim kiemtra As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(txtMaSach.Text, soluongtonmoi)
      If kiemtra = True Then
        MessageBox.Show("Thêm thành công")
        HienThiToanBoSachLenListView()
        btnLamMoi.PerformClick()
      End If
    ElseIf kq = False Then     'mã sách không tồn tại trong kho sách
      Dim soluongnhap As Integer = Integer.Parse(txtSoLuongNhap.Text)
      If soluongnhap < quydinhsoluongnhapitnhat Then
        MessageBox.Show("Nhập quá ít , không cho nhập")
        Return
      End If
      Dim masach As String = txtMaSach.Text
      Dim tensach As String = txtTenSach.Text
      Dim theloai As String = txtTheLoai.Text
      Dim tacgia As String = txtTacGia.Text
      Dim soluongton As String = txtSoLuongNhap.Text
      Dim dongia As Integer = Integer.Parse(txtDonGia.Text)
      Dim kiemtra As Boolean = sachbll.ThemSach(masach, tensach, theloai, tacgia, soluongton, dongia)
      If kiemtra = True Then
        MessageBox.Show("Thêm thành công")
        HienThiToanBoSachLenListView()
      End If
      Dim phieunhap As manhinhphieunhap = New manhinhphieunhap()
      Dim str As String = ""
      Dim thang As Integer = 0
      If phieunhap.ShowDialog() = DialogResult.OK Then
        Dim maphieunhap As String = phieunhap.txtMaPhieuNHap.Text
        str = maphieunhap
        Dim ngaynhap As DateTime = phieunhap.dtNgayNhap.Value
        thang = ngaynhap.Month
        Dim kt As Boolean = phieunhapbll.CapNhatThongTinVaoPhieuNhap(maphieunhap, ngaynhap)
        If kt = True Then
          MessageBox.Show("Cập nhật phiếu nhập thành công")
        ElseIf kt = False Then
          MessageBox.Show("Mã phiếu nhập đã tồn tại rồi")
          Return
        End If
      End If
      Dim chitietphieunhap As ManHinhChiTietPhieuNhap = New ManHinhChiTietPhieuNhap()
      chitietphieunhap.txtMaPhieuNhap.Text = str
      chitietphieunhap.txtMaSach.Text = txtMaSach.Text
      chitietphieunhap.txtSoLuongNhap.Text = txtSoLuongNhap.Text
      If chitietphieunhap.ShowDialog() = DialogResult.OK Then
        Dim machitietphieunhap As String = chitietphieunhap.txtMaChiTietPhieuNhap.Text
        Dim maphieunhapp As String = chitietphieunhap.txtMaPhieuNhap.Text
        Dim masachh As String = chitietphieunhap.txtMaSach.Text
        Dim soluongnhapp As Integer = Integer.Parse(chitietphieunhap.txtSoLuongNhap.Text)
        Dim ktt As Boolean = chitietphieunhapbll.CapNhatChiTietPhieuNhap(machitietphieunhap, maphieunhapp, masachh, soluongnhapp)
        If ktt = True Then
          MessageBox.Show("Cập nhật chi tiết phiếu nhập thành công")
        ElseIf ktt = False Then
          MessageBox.Show("Mã chi tiết phiếu nhập đã tồn tại , vui lòng nhập lại")
          Dim a = 5
          Return
        End If
      End If
      Dim manhinhbaocaoton As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
      manhinhbaocaoton.txtMaSach.Text = txtMaSach.Text
      manhinhbaocaoton.txtThang.Text = thang.ToString()
      manhinhbaocaoton.txtTonDau.Text = txtSoLuongNhap.Text
      manhinhbaocaoton.txtTonPhatSinh.Text = txtSoLuongNhap.Text
      manhinhbaocaoton.txtTonCuoi.Text = txtSoLuongNhap.Text
      If manhinhbaocaoton.ShowDialog() = DialogResult.OK Then
        Dim machitietton As String = manhinhbaocaoton.txtMaChiTietTon.Text
        Dim thangg As Integer = Integer.Parse(manhinhbaocaoton.txtThang.Text)
        Dim masah As String = manhinhbaocaoton.txtMaSach.Text
        Dim tondau As Integer = Integer.Parse(manhinhbaocaoton.txtTonDau.Text)
        Dim tonphatsinh As Integer = Integer.Parse(manhinhbaocaoton.txtTonPhatSinh.Text)
        Dim toncuoi As Integer = Integer.Parse(manhinhbaocaoton.txtTonCuoi.Text)
        Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thangg, masah, tondau, tonphatsinh, toncuoi)
        If kimtra = True Then
          MessageBox.Show("Cập nhật bảng báo cáo tồn thành công")
          btnLamMoi.PerformClick()
        ElseIf kimtra = False Then
          MessageBox.Show("Mã chi tiết tồn đã tồn tại rồi , vui lòng nhập lại")
          btnLamMoi.PerformClick()
          Return
        End If
      End If
    End If
  End Sub

  Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
    If lvData.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao sửa được thím")
      Return
    End If
    Dim lvi As ListViewItem = lvData.SelectedItems(0)
    Dim masach As String = lvi.Tag.ToString()
    Dim tensach As String = txtTenSach.Text
    Dim theloai As String = txtTheLoai.Text
    Dim tacgia As String = txtTacGia.Text
    Dim dongia As Integer = Integer.Parse(txtDonGia.Text)
    Dim kq As Boolean = sachbll.SuaSach(masach, tensach, theloai, tacgia, dongia)
    If kq Then
      MessageBox.Show("Sửa sách thành công")
      HienThiToanBoSachLenListView()
      btnLamMoi.PerformClick()
    End If
  End Sub

  Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
    If lvData.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao xóa được thím")
      Return
    End If
    Dim ret As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa không ?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    If ret = DialogResult.Yes Then
      Dim lvi As ListViewItem = lvData.SelectedItems(0)
      Dim masach As String = lvi.Tag.ToString()
      Dim kq As Boolean = sachbll.XoaSach(masach)
      If kq Then
        MessageBox.Show("Xóa sách thành công")
        HienThiToanBoSachLenListView()
        btnLamMoi.PerformClick()
        Return
      End If
    End If
  End Sub
End Class