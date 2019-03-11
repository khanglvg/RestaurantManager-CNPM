<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhBaoCaoTon
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
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.txtMaChiTietTon = New System.Windows.Forms.TextBox()
    Me.txtThang = New System.Windows.Forms.TextBox()
    Me.txtMaSach = New System.Windows.Forms.TextBox()
    Me.txtTonDau = New System.Windows.Forms.TextBox()
    Me.txtTonPhatSinh = New System.Windows.Forms.TextBox()
    Me.txtTonCuoi = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(36, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(132, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã chi tiết tồn"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(36, 73)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(69, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Tháng"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(36, 123)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(87, 25)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Mã sách"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(36, 170)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(85, 25)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Tồn đầu"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(36, 213)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(131, 25)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Tồn phát sinh"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(36, 256)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(88, 25)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Tồn cuối"
    '
    'btnCapNhat
    '
    Me.btnCapNhat.Location = New System.Drawing.Point(578, 320)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(104, 37)
    Me.btnCapNhat.TabIndex = 12
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = True
    '
    'txtMaChiTietTon
    '
    Me.txtMaChiTietTon.Location = New System.Drawing.Point(214, 28)
    Me.txtMaChiTietTon.Name = "txtMaChiTietTon"
    Me.txtMaChiTietTon.Size = New System.Drawing.Size(468, 30)
    Me.txtMaChiTietTon.TabIndex = 1
    '
    'txtThang
    '
    Me.txtThang.Location = New System.Drawing.Point(214, 73)
    Me.txtThang.Name = "txtThang"
    Me.txtThang.Size = New System.Drawing.Size(468, 30)
    Me.txtThang.TabIndex = 3
    '
    'txtMaSach
    '
    Me.txtMaSach.Location = New System.Drawing.Point(214, 120)
    Me.txtMaSach.Name = "txtMaSach"
    Me.txtMaSach.Size = New System.Drawing.Size(468, 30)
    Me.txtMaSach.TabIndex = 5
    '
    'txtTonDau
    '
    Me.txtTonDau.Location = New System.Drawing.Point(214, 167)
    Me.txtTonDau.Name = "txtTonDau"
    Me.txtTonDau.Size = New System.Drawing.Size(468, 30)
    Me.txtTonDau.TabIndex = 7
    '
    'txtTonPhatSinh
    '
    Me.txtTonPhatSinh.Location = New System.Drawing.Point(214, 210)
    Me.txtTonPhatSinh.Name = "txtTonPhatSinh"
    Me.txtTonPhatSinh.Size = New System.Drawing.Size(468, 30)
    Me.txtTonPhatSinh.TabIndex = 9
    '
    'txtTonCuoi
    '
    Me.txtTonCuoi.Location = New System.Drawing.Point(214, 253)
    Me.txtTonCuoi.Name = "txtTonCuoi"
    Me.txtTonCuoi.Size = New System.Drawing.Size(468, 30)
    Me.txtTonCuoi.TabIndex = 11
    '
    'ManHinhBaoCaoTon
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(738, 369)
    Me.Controls.Add(Me.txtTonCuoi)
    Me.Controls.Add(Me.txtTonPhatSinh)
    Me.Controls.Add(Me.txtTonDau)
    Me.Controls.Add(Me.txtMaSach)
    Me.Controls.Add(Me.txtThang)
    Me.Controls.Add(Me.txtMaChiTietTon)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhBaoCaoTon"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "ManHinhBaoCaoTon"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents btnCapNhat As Button
  Friend WithEvents txtMaChiTietTon As TextBox
  Public WithEvents txtThang As TextBox
  Public WithEvents txtMaSach As TextBox
  Public WithEvents txtTonDau As TextBox
  Public WithEvents txtTonPhatSinh As TextBox
  Public WithEvents txtTonCuoi As TextBox
End Class
