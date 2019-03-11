<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManHinhLapBaoCaoCongNo
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
    Me.cboThangCanLamBaoCao = New System.Windows.Forms.ComboBox()
    Me.txtTenKhachHang = New System.Windows.Forms.TextBox()
    Me.lvDaTa = New System.Windows.Forms.ListView()
    Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
    Me.btnHienThiTatCa = New System.Windows.Forms.Button()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btnHienThiTatCa)
    Me.Panel1.Controls.Add(Me.txtTenKhachHang)
    Me.Panel1.Controls.Add(Me.cboThangCanLamBaoCao)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(981, 192)
    Me.Panel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.lvDaTa)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 192)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(981, 313)
    Me.Panel2.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(117, 27)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(217, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Tháng cần làm báo cáo"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(117, 90)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(154, 25)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Tên khách hàng"
    '
    'cboThangCanLamBaoCao
    '
    Me.cboThangCanLamBaoCao.FormattingEnabled = True
    Me.cboThangCanLamBaoCao.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
    Me.cboThangCanLamBaoCao.Location = New System.Drawing.Point(353, 27)
    Me.cboThangCanLamBaoCao.Name = "cboThangCanLamBaoCao"
    Me.cboThangCanLamBaoCao.Size = New System.Drawing.Size(474, 33)
    Me.cboThangCanLamBaoCao.TabIndex = 1
    '
    'txtTenKhachHang
    '
    Me.txtTenKhachHang.Location = New System.Drawing.Point(353, 90)
    Me.txtTenKhachHang.Name = "txtTenKhachHang"
    Me.txtTenKhachHang.Size = New System.Drawing.Size(474, 30)
    Me.txtTenKhachHang.TabIndex = 2
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
    Me.lvDaTa.Size = New System.Drawing.Size(981, 313)
    Me.lvDaTa.TabIndex = 0
    Me.lvDaTa.UseCompatibleStateImageBehavior = False
    Me.lvDaTa.View = System.Windows.Forms.View.Details
    '
    'ColumnHeader1
    '
    Me.ColumnHeader1.Text = "Mã chi tiết công nợ"
    Me.ColumnHeader1.Width = 100
    '
    'ColumnHeader2
    '
    Me.ColumnHeader2.Text = "Tháng"
    Me.ColumnHeader2.Width = 100
    '
    'ColumnHeader3
    '
    Me.ColumnHeader3.Text = "Mã khách hàng"
    Me.ColumnHeader3.Width = 200
    '
    'ColumnHeader4
    '
    Me.ColumnHeader4.Text = "Nợ Đầu"
    Me.ColumnHeader4.Width = 200
    '
    'ColumnHeader5
    '
    Me.ColumnHeader5.Text = "Nợ Cuối"
    Me.ColumnHeader5.Width = 200
    '
    'ColumnHeader6
    '
    Me.ColumnHeader6.Text = "Nợ Phát Sinh"
    Me.ColumnHeader6.Width = 200
    '
    'btnHienThiTatCa
    '
    Me.btnHienThiTatCa.Location = New System.Drawing.Point(610, 128)
    Me.btnHienThiTatCa.Name = "btnHienThiTatCa"
    Me.btnHienThiTatCa.Size = New System.Drawing.Size(217, 43)
    Me.btnHienThiTatCa.TabIndex = 3
    Me.btnHienThiTatCa.Text = "Hiển thị tất cả"
    Me.btnHienThiTatCa.UseVisualStyleBackColor = True
    '
    'ManHinhLapBaoCaoCongNo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(981, 505)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.MaximizeBox = False
    Me.Name = "ManHinhLapBaoCaoCongNo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "ManHinhLapBaoCaoCongNo"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Panel1 As Panel
  Friend WithEvents txtTenKhachHang As TextBox
  Friend WithEvents cboThangCanLamBaoCao As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Panel2 As Panel
  Friend WithEvents lvDaTa As ListView
  Friend WithEvents ColumnHeader1 As ColumnHeader
  Friend WithEvents ColumnHeader2 As ColumnHeader
  Friend WithEvents ColumnHeader3 As ColumnHeader
  Friend WithEvents ColumnHeader4 As ColumnHeader
  Friend WithEvents ColumnHeader5 As ColumnHeader
  Friend WithEvents ColumnHeader6 As ColumnHeader
  Friend WithEvents btnHienThiTatCa As Button
End Class
