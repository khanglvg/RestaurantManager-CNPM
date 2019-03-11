<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhPhieuThuTien
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtMaPhieuThu = New System.Windows.Forms.TextBox()
    Me.txtSoTienThu = New System.Windows.Forms.TextBox()
    Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.dtNgayThuTien = New System.Windows.Forms.DateTimePicker()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(26, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(125, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã phiếu thu"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(26, 73)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(105, 25)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Số tiền thu"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(26, 124)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(126, 25)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Ngày thu tiền"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(26, 183)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(152, 25)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Mã khách  hàng"
    '
    'txtMaPhieuThu
    '
    Me.txtMaPhieuThu.Location = New System.Drawing.Point(191, 22)
    Me.txtMaPhieuThu.Name = "txtMaPhieuThu"
    Me.txtMaPhieuThu.Size = New System.Drawing.Size(387, 30)
    Me.txtMaPhieuThu.TabIndex = 1
    '
    'txtSoTienThu
    '
    Me.txtSoTienThu.Location = New System.Drawing.Point(191, 70)
    Me.txtSoTienThu.Name = "txtSoTienThu"
    Me.txtSoTienThu.Size = New System.Drawing.Size(387, 30)
    Me.txtSoTienThu.TabIndex = 1
    '
    'txtMaKhachHang
    '
    Me.txtMaKhachHang.Location = New System.Drawing.Point(191, 178)
    Me.txtMaKhachHang.Name = "txtMaKhachHang"
    Me.txtMaKhachHang.Size = New System.Drawing.Size(387, 30)
    Me.txtMaKhachHang.TabIndex = 1
    '
    'btnCapNhat
    '
    Me.btnCapNhat.Location = New System.Drawing.Point(408, 245)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(170, 50)
    Me.btnCapNhat.TabIndex = 2
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = True
    '
    'dtNgayThuTien
    '
    Me.dtNgayThuTien.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtNgayThuTien.Location = New System.Drawing.Point(191, 124)
    Me.dtNgayThuTien.Name = "dtNgayThuTien"
    Me.dtNgayThuTien.Size = New System.Drawing.Size(387, 30)
    Me.dtNgayThuTien.TabIndex = 3
    '
    'ManHinhPhieuThuTien
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(613, 327)
    Me.Controls.Add(Me.dtNgayThuTien)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtMaKhachHang)
    Me.Controls.Add(Me.txtSoTienThu)
    Me.Controls.Add(Me.txtMaPhieuThu)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhPhieuThuTien"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "ManHinhPhieuThuTien"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents btnCapNhat As Button
  Public WithEvents txtMaPhieuThu As TextBox
  Public WithEvents txtSoTienThu As TextBox
  Public WithEvents txtMaKhachHang As TextBox
  Public WithEvents dtNgayThuTien As DateTimePicker
End Class
