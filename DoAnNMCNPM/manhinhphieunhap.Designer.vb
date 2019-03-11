<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manhinhphieunhap
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
    Me.txtMaPhieuNHap = New System.Windows.Forms.TextBox()
    Me.dtNgayNhap = New System.Windows.Forms.DateTimePicker()
    Me.btnCapNhat = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(24, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(142, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mã phiếu nhập"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(24, 79)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(107, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Ngày nhập"
    '
    'txtMaPhieuNHap
    '
    Me.txtMaPhieuNHap.Location = New System.Drawing.Point(172, 19)
    Me.txtMaPhieuNHap.Name = "txtMaPhieuNHap"
    Me.txtMaPhieuNHap.Size = New System.Drawing.Size(326, 30)
    Me.txtMaPhieuNHap.TabIndex = 1
    '
    'dtNgayNhap
    '
    Me.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtNgayNhap.Location = New System.Drawing.Point(172, 79)
    Me.dtNgayNhap.Name = "dtNgayNhap"
    Me.dtNgayNhap.Size = New System.Drawing.Size(326, 30)
    Me.dtNgayNhap.TabIndex = 3
    '
    'btnCapNhat
    '
    Me.btnCapNhat.Location = New System.Drawing.Point(394, 125)
    Me.btnCapNhat.Name = "btnCapNhat"
    Me.btnCapNhat.Size = New System.Drawing.Size(104, 36)
    Me.btnCapNhat.TabIndex = 4
    Me.btnCapNhat.Text = "Cập nhật"
    Me.btnCapNhat.UseVisualStyleBackColor = True
    '
    'manhinhphieunhap
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(538, 173)
    Me.Controls.Add(Me.btnCapNhat)
    Me.Controls.Add(Me.dtNgayNhap)
    Me.Controls.Add(Me.txtMaPhieuNHap)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.MaximizeBox = False
    Me.Name = "manhinhphieunhap"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "PhieuNhap"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents btnCapNhat As Button
  Public WithEvents txtMaPhieuNHap As TextBox
  Public WithEvents dtNgayNhap As DateTimePicker
End Class
