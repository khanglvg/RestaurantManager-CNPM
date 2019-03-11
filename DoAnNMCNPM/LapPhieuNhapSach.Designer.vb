<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LapPhieuNhapSach
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.txtSoLuongTonToiDaTruocNhap = New System.Windows.Forms.TextBox()
    Me.txtSoLuongNhapItNhat = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.txtDonGia = New System.Windows.Forms.TextBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.btnTimSachTheoTacGia = New System.Windows.Forms.Button()
    Me.btnTimSachTheoTheLoai = New System.Windows.Forms.Button()
    Me.btnTimSachTheoTen = New System.Windows.Forms.Button()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.btnLamMoi = New System.Windows.Forms.Button()
    Me.btnXoa = New System.Windows.Forms.Button()
    Me.btnSua = New System.Windows.Forms.Button()
    Me.btnToanBo = New System.Windows.Forms.Button()
    Me.btnThem = New System.Windows.Forms.Button()
    Me.btnTimSach = New System.Windows.Forms.Button()
    Me.txtSoLuongNhap = New System.Windows.Forms.TextBox()
    Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
    Me.txtTacGia = New System.Windows.Forms.TextBox()
    Me.txtTheLoai = New System.Windows.Forms.TextBox()
    Me.txtTenSach = New System.Windows.Forms.TextBox()
    Me.txtMaSach = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel4 = New System.Windows.Forms.Panel()
    Me.lvData = New System.Windows.Forms.ListView()
    Me.Panel1.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Panel3)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(996, 502)
    Me.Panel1.TabIndex = 0
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.GroupBox2)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel3.Location = New System.Drawing.Point(656, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(340, 502)
    Me.Panel3.TabIndex = 1
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.txtSoLuongTonToiDaTruocNhap)
    Me.GroupBox2.Controls.Add(Me.txtSoLuongNhapItNhat)
    Me.GroupBox2.Controls.Add(Me.Label7)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(340, 502)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Qui định"
    '
    'txtSoLuongTonToiDaTruocNhap
    '
    Me.txtSoLuongTonToiDaTruocNhap.Location = New System.Drawing.Point(25, 180)
    Me.txtSoLuongTonToiDaTruocNhap.Name = "txtSoLuongTonToiDaTruocNhap"
    Me.txtSoLuongTonToiDaTruocNhap.ReadOnly = True
    Me.txtSoLuongTonToiDaTruocNhap.Size = New System.Drawing.Size(291, 30)
    Me.txtSoLuongTonToiDaTruocNhap.TabIndex = 3
    '
    'txtSoLuongNhapItNhat
    '
    Me.txtSoLuongNhapItNhat.Location = New System.Drawing.Point(25, 78)
    Me.txtSoLuongNhapItNhat.Name = "txtSoLuongNhapItNhat"
    Me.txtSoLuongNhapItNhat.ReadOnly = True
    Me.txtSoLuongNhapItNhat.Size = New System.Drawing.Size(291, 30)
    Me.txtSoLuongNhapItNhat.TabIndex = 1
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(20, 142)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(301, 25)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "Số lượng tồn tối đa trước khi nhập"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(20, 39)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(196, 25)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Số lượng nhập ít nhất"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.GroupBox1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(656, 502)
    Me.Panel2.TabIndex = 0
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtDonGia)
    Me.GroupBox1.Controls.Add(Me.Label10)
    Me.GroupBox1.Controls.Add(Me.btnTimSachTheoTacGia)
    Me.GroupBox1.Controls.Add(Me.btnTimSachTheoTheLoai)
    Me.GroupBox1.Controls.Add(Me.btnTimSachTheoTen)
    Me.GroupBox1.Controls.Add(Me.Label8)
    Me.GroupBox1.Controls.Add(Me.btnLamMoi)
    Me.GroupBox1.Controls.Add(Me.btnXoa)
    Me.GroupBox1.Controls.Add(Me.btnSua)
    Me.GroupBox1.Controls.Add(Me.btnToanBo)
    Me.GroupBox1.Controls.Add(Me.btnThem)
    Me.GroupBox1.Controls.Add(Me.btnTimSach)
    Me.GroupBox1.Controls.Add(Me.txtSoLuongNhap)
    Me.GroupBox1.Controls.Add(Me.txtSoLuongTon)
    Me.GroupBox1.Controls.Add(Me.txtTacGia)
    Me.GroupBox1.Controls.Add(Me.txtTheLoai)
    Me.GroupBox1.Controls.Add(Me.txtTenSach)
    Me.GroupBox1.Controls.Add(Me.txtMaSach)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(656, 502)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Thông tin chi tiết"
    '
    'txtDonGia
    '
    Me.txtDonGia.Location = New System.Drawing.Point(162, 311)
    Me.txtDonGia.Name = "txtDonGia"
    Me.txtDonGia.Size = New System.Drawing.Size(231, 30)
    Me.txtDonGia.TabIndex = 15
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(19, 311)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(79, 25)
    Me.Label10.TabIndex = 14
    Me.Label10.Text = "Đơn giá"
    '
    'btnTimSachTheoTacGia
    '
    Me.btnTimSachTheoTacGia.Location = New System.Drawing.Point(419, 211)
    Me.btnTimSachTheoTacGia.Name = "btnTimSachTheoTacGia"
    Me.btnTimSachTheoTacGia.Size = New System.Drawing.Size(210, 30)
    Me.btnTimSachTheoTacGia.TabIndex = 11
    Me.btnTimSachTheoTacGia.Text = "Tìm sách theo tác giả"
    Me.btnTimSachTheoTacGia.UseVisualStyleBackColor = True
    '
    'btnTimSachTheoTheLoai
    '
    Me.btnTimSachTheoTheLoai.Location = New System.Drawing.Point(419, 152)
    Me.btnTimSachTheoTheLoai.Name = "btnTimSachTheoTheLoai"
    Me.btnTimSachTheoTheLoai.Size = New System.Drawing.Size(210, 30)
    Me.btnTimSachTheoTheLoai.TabIndex = 8
    Me.btnTimSachTheoTheLoai.Text = "Tìm sách theo thể loại"
    Me.btnTimSachTheoTheLoai.UseVisualStyleBackColor = True
    '
    'btnTimSachTheoTen
    '
    Me.btnTimSachTheoTen.Location = New System.Drawing.Point(419, 95)
    Me.btnTimSachTheoTen.Name = "btnTimSachTheoTen"
    Me.btnTimSachTheoTen.Size = New System.Drawing.Size(210, 30)
    Me.btnTimSachTheoTen.TabIndex = 5
    Me.btnTimSachTheoTen.Text = "Tìm sách theo tên"
    Me.btnTimSachTheoTen.UseVisualStyleBackColor = True
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(19, 364)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(139, 25)
    Me.Label8.TabIndex = 16
    Me.Label8.Text = "Số lượng nhập"
    '
    'btnLamMoi
    '
    Me.btnLamMoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnLamMoi.Location = New System.Drawing.Point(457, 412)
    Me.btnLamMoi.Name = "btnLamMoi"
    Me.btnLamMoi.Size = New System.Drawing.Size(150, 71)
    Me.btnLamMoi.TabIndex = 22
    Me.btnLamMoi.Text = "Làm mới thông tin chi tiết"
    Me.btnLamMoi.UseVisualStyleBackColor = True
    '
    'btnXoa
    '
    Me.btnXoa.Location = New System.Drawing.Point(363, 412)
    Me.btnXoa.Name = "btnXoa"
    Me.btnXoa.Size = New System.Drawing.Size(88, 71)
    Me.btnXoa.TabIndex = 21
    Me.btnXoa.Text = "Xóa sách"
    Me.btnXoa.UseVisualStyleBackColor = True
    '
    'btnSua
    '
    Me.btnSua.Location = New System.Drawing.Point(269, 412)
    Me.btnSua.Name = "btnSua"
    Me.btnSua.Size = New System.Drawing.Size(88, 71)
    Me.btnSua.TabIndex = 20
    Me.btnSua.Text = "Sửa sách"
    Me.btnSua.UseVisualStyleBackColor = True
    '
    'btnToanBo
    '
    Me.btnToanBo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnToanBo.Location = New System.Drawing.Point(25, 412)
    Me.btnToanBo.Name = "btnToanBo"
    Me.btnToanBo.Size = New System.Drawing.Size(144, 71)
    Me.btnToanBo.TabIndex = 18
    Me.btnToanBo.Text = "Hiển thị toàn bộ sách"
    Me.btnToanBo.UseVisualStyleBackColor = True
    '
    'btnThem
    '
    Me.btnThem.Location = New System.Drawing.Point(175, 412)
    Me.btnThem.Name = "btnThem"
    Me.btnThem.Size = New System.Drawing.Size(88, 71)
    Me.btnThem.TabIndex = 19
    Me.btnThem.Text = "Thêm sách"
    Me.btnThem.UseVisualStyleBackColor = True
    '
    'btnTimSach
    '
    Me.btnTimSach.Location = New System.Drawing.Point(419, 36)
    Me.btnTimSach.Name = "btnTimSach"
    Me.btnTimSach.Size = New System.Drawing.Size(210, 30)
    Me.btnTimSach.TabIndex = 2
    Me.btnTimSach.Text = "Tìm sách theo mã"
    Me.btnTimSach.UseVisualStyleBackColor = True
    '
    'txtSoLuongNhap
    '
    Me.txtSoLuongNhap.Location = New System.Drawing.Point(164, 359)
    Me.txtSoLuongNhap.Name = "txtSoLuongNhap"
    Me.txtSoLuongNhap.Size = New System.Drawing.Size(229, 30)
    Me.txtSoLuongNhap.TabIndex = 17
    '
    'txtSoLuongTon
    '
    Me.txtSoLuongTon.Location = New System.Drawing.Point(164, 267)
    Me.txtSoLuongTon.Name = "txtSoLuongTon"
    Me.txtSoLuongTon.ReadOnly = True
    Me.txtSoLuongTon.Size = New System.Drawing.Size(229, 30)
    Me.txtSoLuongTon.TabIndex = 13
    '
    'txtTacGia
    '
    Me.txtTacGia.Location = New System.Drawing.Point(164, 194)
    Me.txtTacGia.Multiline = True
    Me.txtTacGia.Name = "txtTacGia"
    Me.txtTacGia.Size = New System.Drawing.Size(229, 67)
    Me.txtTacGia.TabIndex = 10
    '
    'txtTheLoai
    '
    Me.txtTheLoai.Location = New System.Drawing.Point(164, 152)
    Me.txtTheLoai.Name = "txtTheLoai"
    Me.txtTheLoai.Size = New System.Drawing.Size(229, 30)
    Me.txtTheLoai.TabIndex = 7
    '
    'txtTenSach
    '
    Me.txtTenSach.Location = New System.Drawing.Point(164, 78)
    Me.txtTenSach.Multiline = True
    Me.txtTenSach.Name = "txtTenSach"
    Me.txtTenSach.Size = New System.Drawing.Size(229, 68)
    Me.txtTenSach.TabIndex = 4
    '
    'txtMaSach
    '
    Me.txtMaSach.Location = New System.Drawing.Point(164, 36)
    Me.txtMaSach.Name = "txtMaSach"
    Me.txtMaSach.Size = New System.Drawing.Size(229, 30)
    Me.txtMaSach.TabIndex = 1
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(19, 267)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(122, 25)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "Số lượng tồn"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(19, 194)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(77, 25)
    Me.Label4.TabIndex = 9
    Me.Label4.Text = "Tác giả"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(19, 152)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(82, 25)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Thể loại"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(19, 78)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(94, 25)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Tên sách"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(19, 36)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(87, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã sách"
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.lvData)
    Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel4.Location = New System.Drawing.Point(0, 502)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(996, 96)
    Me.Panel4.TabIndex = 1
    '
    'lvData
    '
    Me.lvData.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvData.FullRowSelect = True
    Me.lvData.GridLines = True
    Me.lvData.HideSelection = False
    Me.lvData.Location = New System.Drawing.Point(0, 0)
    Me.lvData.Name = "lvData"
    Me.lvData.Size = New System.Drawing.Size(996, 96)
    Me.lvData.TabIndex = 0
    Me.lvData.UseCompatibleStateImageBehavior = False
    Me.lvData.View = System.Windows.Forms.View.Details
    '
    'LapPhieuNhapSach
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(996, 598)
    Me.Controls.Add(Me.Panel4)
    Me.Controls.Add(Me.Panel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "LapPhieuNhapSach"
    Me.Text = "LapPhieuNhapSach"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.Panel1.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.Panel4.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
  Friend WithEvents Panel3 As Panel
  Friend WithEvents GroupBox2 As GroupBox
  Friend WithEvents txtSoLuongTonToiDaTruocNhap As TextBox
  Friend WithEvents txtSoLuongNhapItNhat As TextBox
  Friend WithEvents Label7 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents Panel2 As Panel
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents Label8 As Label
  Friend WithEvents btnLamMoi As Button
  Friend WithEvents btnXoa As Button
  Friend WithEvents btnSua As Button
  Friend WithEvents btnToanBo As Button
  Friend WithEvents btnThem As Button
  Friend WithEvents btnTimSach As Button
  Friend WithEvents txtSoLuongTon As TextBox
  Friend WithEvents txtTacGia As TextBox
  Friend WithEvents txtTheLoai As TextBox
  Friend WithEvents txtTenSach As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Panel4 As Panel
  Friend WithEvents lvData As ListView
  Friend WithEvents btnTimSachTheoTacGia As Button
  Friend WithEvents btnTimSachTheoTheLoai As Button
  Friend WithEvents btnTimSachTheoTen As Button
  Friend WithEvents txtDonGia As TextBox
  Friend WithEvents Label10 As Label
  Public WithEvents txtMaSach As TextBox
  Public WithEvents txtSoLuongNhap As TextBox
End Class
