<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinNhânViênToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblResultStatus = New System.Windows.Forms.Label()
        Me.lblResultLogin = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.ThôngTinNhânViênToolStripMenuItem, Me.QuảnLýSảnPhẩmToolStripMenuItem, Me.QuảnLýKháchHàngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ Thống"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Image = CType(resources.GetObject("ĐăngXuấtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng Xuất"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Image = CType(resources.GetObject("ThoátToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'ThôngTinNhânViênToolStripMenuItem
        '
        Me.ThôngTinNhânViênToolStripMenuItem.Name = "ThôngTinNhânViênToolStripMenuItem"
        Me.ThôngTinNhânViênToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.ThôngTinNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên"
        '
        'QuảnLýSảnPhẩmToolStripMenuItem
        '
        Me.QuảnLýSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSảnPhẩmToolStripMenuItem})
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Name = "QuảnLýSảnPhẩmToolStripMenuItem"
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.QuảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm"
        '
        'ThêmSảnPhẩmToolStripMenuItem
        '
        Me.ThêmSảnPhẩmToolStripMenuItem.Image = CType(resources.GetObject("ThêmSảnPhẩmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ThêmSảnPhẩmToolStripMenuItem.Name = "ThêmSảnPhẩmToolStripMenuItem"
        Me.ThêmSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ThêmSảnPhẩmToolStripMenuItem.Text = "Thêm Sản Phẩm"
        '
        'QuảnLýKháchHàngToolStripMenuItem
        '
        Me.QuảnLýKháchHàngToolStripMenuItem.Name = "QuảnLýKháchHàngToolStripMenuItem"
        Me.QuảnLýKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.QuảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng"
        '
        'lblResultStatus
        '
        Me.lblResultStatus.AutoSize = True
        Me.lblResultStatus.Location = New System.Drawing.Point(12, 239)
        Me.lblResultStatus.Name = "lblResultStatus"
        Me.lblResultStatus.Size = New System.Drawing.Size(148, 13)
        Me.lblResultStatus.TabIndex = 1
        Me.lblResultStatus.Text = "Bạn đăng nhập với tài khoản:"
        '
        'lblResultLogin
        '
        Me.lblResultLogin.AutoSize = True
        Me.lblResultLogin.Location = New System.Drawing.Point(166, 239)
        Me.lblResultLogin.Name = "lblResultLogin"
        Me.lblResultLogin.Size = New System.Drawing.Size(35, 13)
        Me.lblResultLogin.TabIndex = 2
        Me.lblResultLogin.Text = "label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 261)
        Me.Controls.Add(Me.lblResultLogin)
        Me.Controls.Add(Me.lblResultStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Quản Lý"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinNhânViênToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThêmSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblResultStatus As System.Windows.Forms.Label
    Friend WithEvents lblResultLogin As System.Windows.Forms.Label
End Class
