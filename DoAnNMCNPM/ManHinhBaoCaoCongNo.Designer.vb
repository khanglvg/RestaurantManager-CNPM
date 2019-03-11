<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhBaoCaoCongNo
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
    Me.txtMaChiTietCongNo = New System.Windows.Forms.TextBox()
    Me.txtThang = New System.Windows.Forms.TextBox()
    Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
    Me.txtNoDau = New System.Windows.Forms.TextBox()
    Me.txtNoCuoi = New System.Windows.Forms.TextBox()
    Me.txtNoPhatSinh = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(29, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(175, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã chi tiết công nợ"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(29, 65)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(69, 25)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Tháng"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(29, 110)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(147, 25)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Mã khách hàng"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(29, 159)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(75, 25)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Nợ đầu"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(29, 206)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(78, 25)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Nợ cuối"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(29, 260)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(121, 25)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Nợ phát sinh"
    '
    'txtMaChiTietCongNo
    '
    Me.txtMaChiTietCongNo.Location = New System.Drawing.Point(236, 22)
    Me.txtMaChiTietCongNo.Name = "txtMaChiTietCongNo"
    Me.txtMaChiTietCongNo.Size = New System.Drawing.Size(486, 30)
    Me.txtMaChiTietCongNo.TabIndex = 1
    '
    'txtThang
    '
    Me.txtThang.Location = New System.Drawing.Point(236, 65)
    Me.txtThang.Name = "txtThang"
    Me.txtThang.Size = New System.Drawing.Size(486, 30)
    Me.txtThang.TabIndex = 1
    '
    'txtMaKhachHang
    '
    Me.txtMaKhachHang.Location = New System.Drawing.Point(236, 110)
    Me.txtMaKhachHang.Name = "txtMaKhachHang"
    Me.txtMaKhachHang.Size = New System.Drawing.Size(486, 30)
    Me.txtMaKhachHang.TabIndex = 1
    '
    'txtNoDau
    '
    Me.txtNoDau.Location = New System.Drawing.Point(236, 159)
    Me.txtNoDau.Name = "txtNoDau"
    Me.txtNoDau.Size = New System.Drawing.Size(486, 30)
    Me.txtNoDau.TabIndex = 1
    '
    'txtNoCuoi
    '
    Me.txtNoCuoi.Location = New System.Drawing.Point(236, 201)
    Me.txtNoCuoi.Name = "txtNoCuoi"
    Me.txtNoCuoi.Size = New System.Drawing.Size(486, 30)
    Me.txtNoCuoi.TabIndex = 1
    '
    'txtNoPhatSinh
    '
    Me.txtNoPhatSinh.Location = New System.Drawing.Point(236, 255)
    Me.txtNoPhatSinh.Name = "txtNoPhatSinh"
    Me.txtNoPhatSinh.Size = New System.Drawing.Size(486, 30)
    Me.txtNoPhatSinh.TabIndex = 1
    '
    'btnCapNhat
    '
    Me.btnCapNhat.Location = New System.Drawing.Point(533, 316)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(188, 62)
    Me.btnCapNhat.TabIndex = 2
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = True
    '
    'ManHinhBaoCaoCongNo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(803, 403)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtNoPhatSinh)
    Me.Controls.Add(Me.txtNoCuoi)
    Me.Controls.Add(Me.txtNoDau)
    Me.Controls.Add(Me.txtMaKhachHang)
    Me.Controls.Add(Me.txtThang)
    Me.Controls.Add(Me.txtMaChiTietCongNo)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhBaoCaoCongNo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "ManHinhBaoCaoCongNo"
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
  Public WithEvents txtMaChiTietCongNo As TextBox
  Public WithEvents txtThang As TextBox
  Public WithEvents txtMaKhachHang As TextBox
  Public WithEvents txtNoDau As TextBox
  Public WithEvents txtNoCuoi As TextBox
  Public WithEvents txtNoPhatSinh As TextBox
End Class
