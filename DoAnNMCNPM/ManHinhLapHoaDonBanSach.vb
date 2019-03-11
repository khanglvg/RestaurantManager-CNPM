Imports DTO
Imports BLL
Public Class ManHinhLapHoaDonBanSach
  Dim sachbll As SachBLL = New SachBLL()
  Dim thamsobll As ThamSoBLL = New ThamSoBLL()
  Dim khachhangbll As KhachHangBLL = New KhachHangBLL()
  Dim baocaotonbll As BaoCaoTonBLL = New BaoCaoTonBLL()
  Dim phieuhoadonbll As PhieuHoaDonBLL = New PhieuHoaDonBLL()
  Dim chitietphieuhoadonbll As ChiTietPhieuHoaDonBLL = New ChiTietPhieuHoaDonBLL()
  Private Sub ManHinhLapHoaDonBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    HienThiQuyDinh()
    HienThiSachLenListView()
  End Sub

  Private Sub HienThiSachLenListView()
    Dim DSS As List(Of Sach) = New List(Of Sach)
    DSS = sachbll.LayToanBoSach()
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã sách", 150)
    lvDaTa.Columns.Add("Tên sách", 250)
    lvDaTa.Columns.Add("Thể loại", 150)
    lvDaTa.Columns.Add("Tác giả", 250)
    lvDaTa.Columns.Add("Số lượng tồn", 150)
    lvDaTa.Columns.Add("Đơn giá", 200)
    Dim itemsach As Sach = New Sach()
    For Each itemsach In DSS
      Dim lvi As ListViewItem = New ListViewItem(itemsach.MaSach)
      lvi.SubItems.Add(itemsach.TenSach)
      lvi.SubItems.Add(itemsach.TheLoai)
      lvi.SubItems.Add(itemsach.TacGia)
      lvi.SubItems.Add(itemsach.SoLuongTon)
      lvi.SubItems.Add(itemsach.DonGia)
      lvi.Tag = itemsach.MaSach
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub HienThiQuyDinh()
    Dim thamso As ThamSo = thamsobll.LayDuLieu()
    txtSoTienNoToiDa.Text = thamso.SoTienNoToiDa.ToString()
    txtSoLuongTonToiThieuSauKhiBan.Text = thamso.SoLuongTonSauToiThieu.ToString()
  End Sub

  Private Sub lvDaTa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDaTa.SelectedIndexChanged
    If lvDaTa.SelectedItems.Count = 0 Then
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag

    Dim kh As KhachHang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    txtMaKhachHang.Text = kh.MaKhachHang
    txtHoTenKhachHang.Text = kh.HoTenKhachHang
    txtDiaChi.Text = kh.DiaChi
    txtDienThoai.Text = kh.DienThoai
    txtEmail.Text = kh.Email
    txtSoTienNo.Text = kh.SoTienNo.ToString()

  End Sub

  Private Sub btnTimSachTheoMa_Click(sender As Object, e As EventArgs) Handles btnTimSachTheoMa.Click
    Dim masach As String = txtMaSach.Text
    Dim kq As Boolean = sachbll.KiemTraMaSach(masach)
    If kq = True Then
      HienThiSachTheoMaSach(masach)
    ElseIf kq = False Then
      MessageBox.Show("Mã không tồn tại")
    End If
  End Sub
  Private Sub HienThiSachTheoMaSach(masach As String)
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã sách", 150)
    lvDaTa.Columns.Add("Tên sách", 250)
    lvDaTa.Columns.Add("Thể loại", 150)
    lvDaTa.Columns.Add("Tác giả", 250)
    lvDaTa.Columns.Add("Số lượng tồn", 150)
    lvDaTa.Columns.Add("Đơn giá", 200)
    Dim sach As Sach = sachbll.LaySachTheoMaSach(masach)
    Dim lvi As ListViewItem = New ListViewItem(sach.MaSach)
    lvi.SubItems.Add(sach.TenSach)
    lvi.SubItems.Add(sach.TheLoai)
    lvi.SubItems.Add(sach.TacGia)
    lvi.SubItems.Add(sach.SoLuongTon)
    lvi.SubItems.Add(sach.DonGia)
    lvi.Tag = sach.MaSach
    lvDaTa.Items.Add(lvi)
  End Sub

  Private Sub btnHienThiSach_Click(sender As Object, e As EventArgs) Handles btnHienThiSach.Click
    HienThiSachLenListView()
  End Sub

  Private Sub btnHienThiKhach_Click(sender As Object, e As EventArgs) Handles btnHienThiKhach.Click
    HienThiToanBoKhachHang()
  End Sub

  Private Sub HienThiToanBoKhachHang()
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 200)
    lvDaTa.Columns.Add("Địa chỉ", 200)
    lvDaTa.Columns.Add("Điện thoại", 200)
    lvDaTa.Columns.Add("Email", 200)
    lvDaTa.Columns.Add("Số tiền nợ", 200)
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
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimKhachTheoMa_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoMa.Click
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim khachhang As KhachHang = New KhachHang()
    khachhang = khachhangbll.LayKhachHangTheoMa(makhachhang)
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 200)
    lvDaTa.Columns.Add("Địa chỉ", 200)
    lvDaTa.Columns.Add("Điện thoại", 200)
    lvDaTa.Columns.Add("Email", 200)
    lvDaTa.Columns.Add("Số tiền nợ", 200)
    Dim lvi As ListViewItem = New ListViewItem(khachhang.MaKhachHang)
    lvi.SubItems.Add(khachhang.HoTenKhachHang)
    lvi.SubItems.Add(khachhang.DiaChi)
    lvi.SubItems.Add(khachhang.DienThoai)
    lvi.SubItems.Add(khachhang.Email)
    lvi.SubItems.Add(khachhang.SoTienNo)
    lvi.Tag = khachhang.MaKhachHang
    lvDaTa.Items.Add(lvi)
  End Sub

  Private Sub btnTimKhachTheoTenKhach_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoTenKhach.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 200)
    lvDaTa.Columns.Add("Địa chỉ", 200)
    lvDaTa.Columns.Add("Điện thoại", 200)
    lvDaTa.Columns.Add("Email", 200)
    lvDaTa.Columns.Add("Số tiền nợ", 200)
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
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimKhachTheoDiaChi_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoDiaChi.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 200)
    lvDaTa.Columns.Add("Địa chỉ", 200)
    lvDaTa.Columns.Add("Điện thoại", 200)
    lvDaTa.Columns.Add("Email", 200)
    lvDaTa.Columns.Add("Số tiền nợ", 200)
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
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimKhachTheoSoDienThoai_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoSoDienThoai.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 200)
    lvDaTa.Columns.Add("Địa chỉ", 200)
    lvDaTa.Columns.Add("Điện thoại", 200)
    lvDaTa.Columns.Add("Email", 200)
    lvDaTa.Columns.Add("Số tiền nợ", 200)
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
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnTimKhachTheoEmail_Click(sender As Object, e As EventArgs) Handles btnTimKhachTheoEmail.Click
    lvDaTa.Items.Clear()
    lvDaTa.Columns.Clear()
    lvDaTa.Columns.Add("Mã khách hàng", 150)
    lvDaTa.Columns.Add("Họ tên khách hàng", 200)
    lvDaTa.Columns.Add("Địa chỉ", 200)
    lvDaTa.Columns.Add("Điện thoại", 200)
    lvDaTa.Columns.Add("Email", 200)
    lvDaTa.Columns.Add("Số tiền nợ", 200)
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
      lvDaTa.Items.Add(lvi)
    Next
  End Sub

  Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
    txtMaKhachHang.Text = ""
    txtHoTenKhachHang.Text = ""
    txtDiaChi.Text = ""
    txtDienThoai.Text = ""
    txtEmail.Text = ""
    txtSoTienNo.Text = ""
    txtMaSach.Text = ""
    txtSoLuongMua.Text = ""
    txtMaKhachHang.Focus()
  End Sub

  Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
    If txtMaKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập mã khách hàng")
      Return
    End If
    If txtHoTenKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập họ tên khách hàng")
      Return
    End If
    If txtDiaChi.Text = "" Then
      MessageBox.Show("Chưa nhập địa chỉ")
      Return
    End If
    If txtDienThoai.Text = "" Then
      MessageBox.Show("Chưa nhập điện thoại")
      Return
    End If
    If txtEmail.Text = "" Then
      MessageBox.Show("Chưa nhập email")
      Return
    End If
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim hotenkhachhang As String = txtHoTenKhachHang.Text
    Dim diachi As String = txtDiaChi.Text
    Dim dienthoai As String = txtDienThoai.Text
    Dim email As String = txtEmail.Text
    Dim kq As Boolean = khachhangbll.ThemKhachHang(makhachhang, hotenkhachhang, diachi, dienthoai, email)
    If kq = True Then
      MessageBox.Show("Thêm khách hàng mới thành công")
      HienThiToanBoKhachHang()
      btnLamMoi.PerformClick()
    ElseIf kq = False Then
      MessageBox.Show("Mã khách hàng này đã tồn tại rồi")
    End If
  End Sub

  Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
    If lvDaTa.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao sửa được")
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag
    Dim hotenkhachhang As String = txtHoTenKhachHang.Text
    Dim diachi As String = txtDiaChi.Text
    Dim dienthoai As String = txtDienThoai.Text
    Dim email As String = txtEmail.Text
    Dim kq As Boolean = khachhangbll.SuaKhachHang(makhachhang, hotenkhachhang, diachi, dienthoai, email)
    If kq = True Then
      MessageBox.Show("Sửa thông tin khách hàng thành công")
      HienThiToanBoKhachHang()
      btnLamMoi.PerformClick()
    End If
  End Sub

  Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
    If lvDaTa.SelectedItems.Count = 0 Then
      MessageBox.Show("Chưa chọn sao xóa")
      Return
    End If
    Dim lvi As ListViewItem = lvDaTa.SelectedItems(0)
    Dim makhachhang As String = lvi.Tag
    Dim ret As DialogResult = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    If ret = DialogResult.Yes Then
      Dim kq As Boolean = khachhangbll.XoaKhachHang(makhachhang)
      If kq = True Then
        MessageBox.Show("Xóa khách hàng thành công")
        HienThiToanBoKhachHang()
        btnLamMoi.PerformClick()
      End If
    End If
  End Sub

  Private Sub btnBan_Click(sender As Object, e As EventArgs) Handles btnBan.Click
    If txtMaKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập mã khách hàng")
      Return
    End If
    If txtHoTenKhachHang.Text = "" Then
      MessageBox.Show("Chưa nhập họ tên khách hàng")
      Return
    End If
    If txtDiaChi.Text = "" Then
      MessageBox.Show("Chưa nhập địa chỉ")
      Return
    End If
    If txtDienThoai.Text = "" Then
      MessageBox.Show("Chưa nhập điện thoại")
      Return
    End If
    If txtEmail.Text = "" Then
      MessageBox.Show("Chưa nhập email")
      Return
    End If
    If txtMaSach.Text = "" Then
      MessageBox.Show("Chưa nhập mã sách")
      Return
    End If
    If txtSoLuongMua.Text = "" Then
      MessageBox.Show("Chưa nhập số lượng mua")
      Return
    End If
    Dim makhachhang As String = txtMaKhachHang.Text
    Dim kq As Boolean = khachhangbll.KiemTraMaKhachHang(makhachhang)

    If kq = True Then     'Khách hàng cũ
      Dim tonnn As BaoCaoTon = New BaoCaoTon()
      Dim masachhh As String = txtMaSach.Text
      tonnn = baocaotonbll.LayTonDauTheoMaSach(masachhh)
      Dim soluongtonn As Integer = sachbll.LaySoLuongTonTheoMaSach(masachhh)
      Dim tondauuu As Integer = tonnn.TonDau
      Dim tonphatsinhh As Integer = tonnn.TonPhatSinh
      Dim toncuoiii As Integer = tonnn.TonCuoi
      If tondauuu = soluongtonn Then
        tonphatsinhh = 0
        toncuoiii = soluongtonn
        Dim baocaoton As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
        baocaoton.txtMaSach.Text = txtMaSach.Text
        baocaoton.txtThang.Text = DateTime.Now.Month
        baocaoton.txtTonDau.Text = tondauuu.ToString()
        baocaoton.txtTonPhatSinh.Text = tonphatsinhh.ToString()
        baocaoton.txtTonCuoi.Text = toncuoiii.ToString()
        If baocaoton.DialogResult = DialogResult.OK Then
          Dim machitietton As String = baocaoton.txtMaChiTietTon.Text
          Dim thang As Integer = Integer.Parse(baocaoton.txtThang.Text)
          Dim masah As String = baocaoton.txtMaSach.Text
          Dim tondauu As Integer = Integer.Parse(baocaoton.txtTonDau.Text)
          Dim tonphatsinhhh As Integer = Integer.Parse(baocaoton.txtTonPhatSinh.Text)
          Dim toncuoii As Integer = Integer.Parse(baocaoton.txtTonCuoi.Text)
          Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thang, masah, tondauu, tonphatsinhhh, toncuoii)
          If kimtra = True Then
            MessageBox.Show("Cập nhật báo cáo tồn thành công")
          ElseIf kimtra = False Then
            MessageBox.Show("Mã chi tiết tồn đã tồn tại rồi,vui lòng cập nhật lại")
            Return
          End If
        End If
      End If
      Dim soluongmuaa As Integer = Integer.Parse(txtSoLuongMua.Text)

      tonphatsinhh = tonphatsinhh - soluongmuaa
      toncuoiii = soluongtonn
      Dim baocaotonnn As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
      baocaotonnn.txtMaSach.Text = txtMaSach.Text
      baocaotonnn.txtThang.Text = DateTime.Now.Month
      baocaotonnn.txtTonDau.Text = tondauuu.ToString()
      baocaotonnn.txtTonPhatSinh.Text = tonphatsinhh.ToString()
      baocaotonnn.txtTonCuoi.Text = toncuoiii.ToString()
      If baocaotonnn.ShowDialog() = DialogResult.OK Then
        Dim machitietton As String = baocaotonnn.txtMaChiTietTon.Text
        Dim thang As Integer = baocaotonnn.txtThang.Text
        Dim masah As String = baocaotonnn.txtMaSach.Text
        Dim tondauu As Integer = Integer.Parse(baocaotonnn.txtTonDau.Text)
        Dim tonphatsinhhh As Integer = Integer.Parse(baocaotonnn.txtTonPhatSinh.Text)
        Dim toncuoii As Integer = Integer.Parse(baocaotonnn.txtTonCuoi.Text)
        Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thang, masah, tondauu, tonphatsinhhh, toncuoii)
        If kimtra = True Then
          MessageBox.Show("Cập nhật báo cáo tồn thành công")
        ElseIf kimtra = False Then
          MessageBox.Show("Mã chi tiết tồn đã tồn tại,vui lòng nhập lại")
          Return
        End If
      End If
      Dim phieuhoadonn As ManHinhPhieuHoaDon = New ManHinhPhieuHoaDon()
      phieuhoadonn.txtMaKhachHang.Text = txtMaKhachHang.Text
      phieuhoadonn.dtNgayLap.Value = DateTime.Now
      Dim strr As String = ""
      If phieuhoadonn.ShowDialog() = DialogResult.OK Then
        Dim maphieuhoadon As String = phieuhoadonn.txtMaPhieuHoaDon.Text
        strr = maphieuhoadon
        Dim makhachhangg As String = phieuhoadonn.txtMaKhachHang.Text
        Dim ngaylap As DateTime = phieuhoadonn.dtNgayLap.Value
        Dim ktphieuhoadon As Boolean = phieuhoadonbll.CapNhatPhieuHoaDon(maphieuhoadon, makhachhangg, ngaylap)
        If ktphieuhoadon = True Then
          MessageBox.Show("Cập nhật phiếu hóa đơn thành công")
        ElseIf ktphieuhoadon = False Then
          MessageBox.Show("Mã phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim chitietphieuhoadonn As ManHinhChiTietPhieuHoaDon = New ManHinhChiTietPhieuHoaDon()
      chitietphieuhoadonn.txtMaPhieuHoaDon.Text = strr
      chitietphieuhoadonn.txtMaSach.Text = txtMaSach.Text
      chitietphieuhoadonn.txtSoLuongBan.Text = txtSoLuongMua.Text
      If chitietphieuhoadonn.ShowDialog() = DialogResult.OK Then
        Dim machitietphieuhoadon As String = chitietphieuhoadonn.txtMaChiTietPhieuHoaDon.Text
        Dim maphieuhoadonn As String = chitietphieuhoadonn.txtMaPhieuHoaDon.Text
        Dim masahh As String = chitietphieuhoadonn.txtMaSach.Text
        Dim soluongban As Integer = Integer.Parse(chitietphieuhoadonn.txtSoLuongBan.Text)
        Dim kiemtrachitietphieuhoadon As Boolean = chitietphieuhoadonbll.CapNhapChiTietPhieuHoaDon(machitietphieuhoadon, maphieuhoadonn, masahh, soluongban)
        If kiemtrachitietphieuhoadon = True Then
          MessageBox.Show("Cập nhật chi tiết phiếu hóa đơn thành công")
        ElseIf kiemtrachitietphieuhoadon = False Then
          MessageBox.Show("Mã chi tiết phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim soluongtontoithieusaukhibann As Integer = Integer.Parse(txtSoLuongTonToiThieuSauKhiBan.Text)
      Dim soluongtonmoii As Integer = soluongtonn - soluongmuaa
      If soluongtonmoii < soluongtontoithieusaukhibann Then
        MessageBox.Show("Không bán do không thỏa quy định số lượng tồn của sách sau khi bán")
        Return
      End If
      Dim sotiennoo As Double = khachhangbll.LaySoTienNoTheoMaKhachHang(makhachhang)
      Dim sotiennotoidaa As Double = Double.Parse(txtSoTienNoToiDa.Text)
      If sotiennoo > sotiennotoidaa Then
        MessageBox.Show("Không bán cho khách hàng này nữa vì khách hàng này đã nợ quá nhiều")
        Return
      End If
      Dim dongiaa As Double = sachbll.LayDonGiaTheoMaSach(masachhh)
      Dim sotiennomoii As Double = soluongmuaa * dongiaa
      txtTongTien.Text = sotiennomoii.ToString()
      Dim rett As DialogResult = MessageBox.Show("Bạn sẽn thanh toán trực tiếp ?", "Hỏi thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      If rett = DialogResult.Yes Then 'thanh toán trực tiếp
        Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masachhh, soluongtonmoii)
        If kqq = True Then
          MessageBox.Show("Bán sách thành công")
          HienThiSachLenListView()
          btnLamMoi.PerformClick()
        End If
      ElseIf rett = DialogResult.No Then 'ghi nợ
        Dim kqqq As Boolean = khachhangbll.CapNhatTienNoMoiTheoMaKhachHang(makhachhang, sotiennomoii)
        If kqqq = True Then
          MessageBox.Show("Cập nhật nợ cho khách hàng thành công")
        End If
        Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masachhh, soluongtonmoii)
        If kqq = True Then
          MessageBox.Show("Bán sách thành công")
          HienThiSachLenListView()
          btnLamMoi.PerformClick()
        End If
      End If
    ElseIf kq = False Then     'Khách hàng mới
      Dim b = 6
      Dim makhachhangggg As String = txtMaKhachHang.Text
      Dim hotenkhachhang As String = txtHoTenKhachHang.Text
      Dim diachi As String = txtDiaChi.Text
      Dim dienthoai As String = txtDienThoai.Text
      Dim email As String = txtEmail.Text
      Dim bl As Boolean = khachhangbll.ThemKhachHang(makhachhangggg, hotenkhachhang, diachi, dienthoai, email)
      If bl = True Then
        MessageBox.Show("Thêm khách hàng mới thành công")
        HienThiToanBoKhachHang()
      ElseIf bl = False Then
        MessageBox.Show("Mã khách hàng này đã tồn tại rồi")
      End If
      Dim ton As BaoCaoTon = New BaoCaoTon()
      Dim masach As String = txtMaSach.Text
      ton = baocaotonbll.LayTonDauTheoMaSach(masach)
      Dim soluongton As Integer = sachbll.LaySoLuongTonTheoMaSach(masach)
      Dim tondau As Integer = ton.TonDau
      Dim tonphatsinh As Integer = ton.TonPhatSinh
      Dim toncuoi As Integer = ton.TonCuoi
      If tondau = soluongton Then
        tonphatsinh = 0
        toncuoi = soluongton
        Dim baocaoton As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
        baocaoton.txtMaSach.Text = txtMaSach.Text
        baocaoton.txtThang.Text = DateTime.Now.Month
        baocaoton.txtTonDau.Text = tondau.ToString()
        baocaoton.txtTonPhatSinh.Text = tonphatsinh.ToString()
        baocaoton.txtTonCuoi.Text = toncuoi.ToString()
        If baocaoton.DialogResult = DialogResult.OK Then
          Dim machitietton As String = baocaoton.txtMaChiTietTon.Text
          Dim thang As Integer = Integer.Parse(baocaoton.txtThang.Text)
          Dim masah As String = baocaoton.txtMaSach.Text
          Dim tondauu As Integer = Integer.Parse(baocaoton.txtTonDau.Text)
          Dim tonphatsinhh As Integer = Integer.Parse(baocaoton.txtTonPhatSinh.Text)
          Dim toncuoii As Integer = Integer.Parse(baocaoton.txtTonCuoi.Text)
          Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thang, masah, tondauu, tonphatsinhh, toncuoii)
          If kimtra = True Then
            MessageBox.Show("Cập nhật báo cáo tồn thành công")
          ElseIf kimtra = False Then
            MessageBox.Show("Mã chi tiết tồn đã tồn tại rồi,vui lòng cập nhật lại")
            Return
          End If
        End If
      End If
      Dim soluongmua As Integer = Integer.Parse(txtSoLuongMua.Text)
      tonphatsinh = tonphatsinh - soluongmua
      toncuoi = soluongton
      Dim baocaotonn As ManHinhBaoCaoTon = New ManHinhBaoCaoTon()
      baocaotonn.txtMaSach.Text = txtMaSach.Text
      baocaotonn.txtThang.Text = DateTime.Now.Month
      baocaotonn.txtTonDau.Text = tondau.ToString()
      baocaotonn.txtTonPhatSinh.Text = tonphatsinh.ToString()
      baocaotonn.txtTonCuoi.Text = toncuoi.ToString()
      If baocaotonn.ShowDialog() = DialogResult.OK Then
        Dim machitietton As String = baocaotonn.txtMaChiTietTon.Text
        Dim thang As Integer = baocaotonn.txtThang.Text
        Dim masah As String = baocaotonn.txtMaSach.Text
        Dim tondauu As Integer = Integer.Parse(baocaotonn.txtTonDau.Text)
        Dim tonphatsinhh As Integer = Integer.Parse(baocaotonn.txtTonPhatSinh.Text)
        Dim toncuoii As Integer = Integer.Parse(baocaotonn.txtTonCuoi.Text)
        Dim kimtra As Boolean = baocaotonbll.CapNhapBaoCaoTon(machitietton, thang, masah, tondauu, tonphatsinhh, toncuoii)
        If kimtra = True Then
          MessageBox.Show("Cập nhật báo cáo tồn thành công")
        ElseIf kimtra = False Then
          MessageBox.Show("Mã chi tiết tồn đã tồn tại,vui lòng nhập lại")
          Return
        End If
      End If
      Dim phieuhoadon As ManHinhPhieuHoaDon = New ManHinhPhieuHoaDon()
      phieuhoadon.txtMaKhachHang.Text = txtMaKhachHang.Text
      phieuhoadon.dtNgayLap.Value = DateTime.Now
      Dim str As String = ""
      If phieuhoadon.ShowDialog() = DialogResult.OK Then
        Dim maphieuhoadon As String = phieuhoadon.txtMaPhieuHoaDon.Text
        str = maphieuhoadon
        Dim makhachhangg As String = phieuhoadon.txtMaKhachHang.Text
        Dim ngaylap As DateTime = phieuhoadon.dtNgayLap.Value
        Dim ktphieuhoadon As Boolean = phieuhoadonbll.CapNhatPhieuHoaDon(maphieuhoadon, makhachhangg, ngaylap)
        If ktphieuhoadon = True Then
          MessageBox.Show("Cập nhật phiếu hóa đơn thành công")
        ElseIf ktphieuhoadon = False Then
          MessageBox.Show("Mã phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim chitietphieuhoadon As ManHinhChiTietPhieuHoaDon = New ManHinhChiTietPhieuHoaDon()
      chitietphieuhoadon.txtMaPhieuHoaDon.Text = str
      chitietphieuhoadon.txtMaSach.Text = txtMaSach.Text
      chitietphieuhoadon.txtSoLuongBan.Text = txtSoLuongMua.Text
      If chitietphieuhoadon.ShowDialog() = DialogResult.OK Then
        Dim machitietphieuhoadon As String = chitietphieuhoadon.txtMaChiTietPhieuHoaDon.Text
        Dim maphieuhoadonn As String = chitietphieuhoadon.txtMaPhieuHoaDon.Text
        Dim masahh As String = chitietphieuhoadon.txtMaSach.Text
        Dim soluongban As Integer = Integer.Parse(chitietphieuhoadon.txtSoLuongBan.Text)
        Dim kiemtrachitietphieuhoadon As Boolean = chitietphieuhoadonbll.CapNhapChiTietPhieuHoaDon(machitietphieuhoadon, maphieuhoadonn, masahh, soluongban)
        If kiemtrachitietphieuhoadon = True Then
          MessageBox.Show("Cập nhật chi tiết phiếu hóa đơn thành công")
        ElseIf kiemtrachitietphieuhoadon = False Then
          MessageBox.Show("Mã chi tiết phiếu hóa đơn này đã tồn tại rồi,vui lòng nhập lại")
          Return
        End If
      End If
      Dim soluongtontoithieusaukhiban As Integer = Integer.Parse(txtSoLuongTonToiThieuSauKhiBan.Text)
      Dim soluongtonmoi As Integer = soluongton - soluongmua
      If soluongtonmoi < soluongtontoithieusaukhiban Then
        MessageBox.Show("Không bán do không thỏa quy định số lượng tồn của sách sau khi bán")
        Return
      End If
      Dim sotienno As Double = khachhangbll.LaySoTienNoTheoMaKhachHang(txtMaKhachHang.Text)
      Dim sotiennotoida As Double = Double.Parse(txtSoTienNoToiDa.Text)
      If sotienno > sotiennotoida Then
        MessageBox.Show("Không bán cho khách hàng này nữa vì khách hàng này đã nợ quá nhiều")
        Return
      End If
      Dim dongia As Double = sachbll.LayDonGiaTheoMaSach(masach)
      Dim sotiennomoi As Double = soluongmua * dongia ''''''''''''
      txtTongTien.Text = sotiennomoi.ToString()
      Dim ret As DialogResult = MessageBox.Show("Bạn sẽn thanh toán trực tiếp ?", "Hỏi thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      If ret = DialogResult.Yes Then 'thanh toán trực tiếp
        Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoi)
        If kqq = True Then
          MessageBox.Show("Bán sách thành công")
          HienThiSachLenListView()
          btnLamMoi.PerformClick()
        End If
      ElseIf ret = DialogResult.No Then 'ghi nợ
        Dim kqqq As Boolean = khachhangbll.CapNhatTienNoMoiTheoMaKhachHang(txtMaKhachHang.Text, sotiennomoi)
        If kqqq = True Then
          MessageBox.Show("Cập nhật nợ cho khách hàng thành công")
        End If
        Dim kqq As Boolean = sachbll.CapNhatSoLuongTonMoiTheoMaSach(masach, soluongtonmoi)
        If kqq = True Then
          MessageBox.Show("Bán sách thành công")
          HienThiSachLenListView()
          btnLamMoi.PerformClick()
        End If
      End If
    End If
  End Sub
End Class