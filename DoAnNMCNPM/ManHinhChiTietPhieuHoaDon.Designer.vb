<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhChiTietPhieuHoaDon
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
    Me.txtMaChiTietPhieuHoaDon = New System.Windows.Forms.TextBox()
    Me.txtMaPhieuHoaDon = New System.Windows.Forms.TextBox()
    Me.txtMaSach = New System.Windows.Forms.TextBox()
    Me.txtSoLuongBan = New System.Windows.Forms.TextBox()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(35, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(229, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã chi tiết phiếu hóa đơn"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(35, 71)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(169, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Mã phiếu hóa đơn"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(35, 120)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(87, 25)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Mã sách"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(35, 175)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(128, 25)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Số lượng bán"
    '
    'txtMaChiTietPhieuHoaDon
    '
    Me.txtMaChiTietPhieuHoaDon.Location = New System.Drawing.Point(292, 22)
    Me.txtMaChiTietPhieuHoaDon.Name = "txtMaChiTietPhieuHoaDon"
    Me.txtMaChiTietPhieuHoaDon.Size = New System.Drawing.Size(404, 30)
    Me.txtMaChiTietPhieuHoaDon.TabIndex = 1
    '
    'txtMaPhieuHoaDon
    '
    Me.txtMaPhieuHoaDon.Location = New System.Drawing.Point(292, 71)
    Me.txtMaPhieuHoaDon.Name = "txtMaPhieuHoaDon"
    Me.txtMaPhieuHoaDon.Size = New System.Drawing.Size(404, 30)
    Me.txtMaPhieuHoaDon.TabIndex = 3
    '
    'txtMaSach
    '
    Me.txtMaSach.Location = New System.Drawing.Point(292, 120)
    Me.txtMaSach.Name = "txtMaSach"
    Me.txtMaSach.Size = New System.Drawing.Size(404, 30)
    Me.txtMaSach.TabIndex = 5
    '
    'txtSoLuongBan
    '
    Me.txtSoLuongBan.Location = New System.Drawing.Point(292, 172)
    Me.txtSoLuongBan.Name = "txtSoLuongBan"
    Me.txtSoLuongBan.Size = New System.Drawing.Size(404, 30)
    Me.txtSoLuongBan.TabIndex = 7
    '
    'btnCapNhat
    '
    Me.btnCapNhat.Location = New System.Drawing.Point(549, 230)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(147, 45)
    Me.btnCapNhat.TabIndex = 8
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = True
    '
    'ManHinhChiTietPhieuHoaDon
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(765, 306)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.txtSoLuongBan)
    Me.Controls.Add(Me.txtMaSach)
    Me.Controls.Add(Me.txtMaPhieuHoaDon)
    Me.Controls.Add(Me.txtMaChiTietPhieuHoaDon)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhChiTietPhieuHoaDon"
    Me.Text = "ManHinhChiTietPhieuHoaDon"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label4 As Label
  Public WithEvents txtMaChiTietPhieuHoaDon As TextBox
  Public WithEvents txtMaPhieuHoaDon As TextBox
  Public WithEvents txtMaSach As TextBox
  Public WithEvents txtSoLuongBan As TextBox
  Friend WithEvents btnCapNhat As Button
End Class
