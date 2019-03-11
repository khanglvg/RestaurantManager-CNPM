<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhLapBaoCaoTon
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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboThangCanLapBaoCao = New System.Windows.Forms.ComboBox()
    Me.txtTenSach = New System.Windows.Forms.TextBox()
    Me.btnHienThiTatCa = New System.Windows.Forms.Button()
    Me.lvDaTa = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.lvDaTa)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.Location = New System.Drawing.Point(0, 194)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(943, 249)
    Me.Panel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.btnHienThiTatCa)
    Me.Panel2.Controls.Add(Me.txtTenSach)
    Me.Panel2.Controls.Add(Me.cboThangCanLapBaoCao)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(943, 194)
    Me.Panel2.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(81, 29)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(212, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tháng cần lập báo cáo"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(81, 86)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(94, 25)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Tên sách"
    '
    'cboThangCanLapBaoCao
    '
    Me.cboThangCanLapBaoCao.FormattingEnabled = True
    Me.cboThangCanLapBaoCao.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cboThangCanLapBaoCao.Location = New System.Drawing.Point(330, 29)
    Me.cboThangCanLapBaoCao.Name = "cboThangCanLapBaoCao"
    Me.cboThangCanLapBaoCao.Size = New System.Drawing.Size(414, 33)
    Me.cboThangCanLapBaoCao.TabIndex = 1
    '
    'txtTenSach
    '
    Me.txtTenSach.Location = New System.Drawing.Point(330, 86)
    Me.txtTenSach.Name = "txtTenSach"
    Me.txtTenSach.Size = New System.Drawing.Size(414, 30)
    Me.txtTenSach.TabIndex = 2
    '
    'btnHienThiTatCa
    '
    Me.btnHienThiTatCa.Location = New System.Drawing.Point(569, 131)
    Me.btnHienThiTatCa.Name = "btnHienThiTatCa"
    Me.btnHienThiTatCa.Size = New System.Drawing.Size(175, 45)
    Me.btnHienThiTatCa.TabIndex = 3
    Me.btnHienThiTatCa.Text = "Hiển thị tất cả"
    Me.btnHienThiTatCa.UseVisualStyleBackColor = True
    '
    'lvDaTa
    '
    Me.lvDaTa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
    Me.lvDaTa.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lvDaTa.FullRowSelect = True
    Me.lvDaTa.GridLines = True
    Me.lvDaTa.HideSelection = False
    Me.lvDaTa.Location = New System.Drawing.Point(0, 0)
    Me.lvDaTa.Name = "lvDaTa"
    Me.lvDaTa.Size = New System.Drawing.Size(943, 249)
    Me.lvDaTa.TabIndex = 0
    Me.lvDaTa.UseCompatibleStateImageBehavior = False
    Me.lvDaTa.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Mã chi tiết tồn"
    Me.ColumnHeader1.Width = 150
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Tháng"
    Me.ColumnHeader2.Width = 100
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Mã sách"
    Me.ColumnHeader3.Width = 100
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Tồn đầu"
    Me.ColumnHeader4.Width = 200
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "Tồn phát sinh"
    Me.ColumnHeader5.Width = 200
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "Tồn cuối"
    Me.ColumnHeader6.Width = 200
    '
    'ManHinhLapBaoCaoTon
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(943, 443)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhLapBaoCaoTon"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "ManHinhLapBaoCaoTon"
    Me.Panel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
  Friend WithEvents lvDaTa As ListView
  Friend WithEvents ColumnHeader1 As ColumnHeader
  Friend WithEvents ColumnHeader2 As ColumnHeader
  Friend WithEvents ColumnHeader3 As ColumnHeader
  Friend WithEvents ColumnHeader4 As ColumnHeader
  Friend WithEvents ColumnHeader5 As ColumnHeader
  Friend WithEvents ColumnHeader6 As ColumnHeader
  Friend WithEvents Panel2 As Panel
  Friend WithEvents btnHienThiTatCa As Button
  Friend WithEvents txtTenSach As TextBox
  Friend WithEvents cboThangCanLapBaoCao As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
