<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNhanVien))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxmatk = New System.Windows.Forms.TextBox()
        Me.tbxname = New System.Windows.Forms.TextBox()
        Me.tbxdiachi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxsdt = New System.Windows.Forms.TextBox()
        Me.tbxemail = New System.Windows.Forms.TextBox()
        Me.tbxmatkhau = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btntrongdulieu = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ Và Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Địa Chỉ"
        '
        'tbxmatk
        '
        Me.tbxmatk.Location = New System.Drawing.Point(102, 6)
        Me.tbxmatk.Name = "tbxmatk"
        Me.tbxmatk.Size = New System.Drawing.Size(162, 20)
        Me.tbxmatk.TabIndex = 6
        '
        'tbxname
        '
        Me.tbxname.Location = New System.Drawing.Point(102, 28)
        Me.tbxname.Name = "tbxname"
        Me.tbxname.Size = New System.Drawing.Size(162, 20)
        Me.tbxname.TabIndex = 7
        '
        'tbxdiachi
        '
        Me.tbxdiachi.Location = New System.Drawing.Point(102, 51)
        Me.tbxdiachi.Name = "tbxdiachi"
        Me.tbxdiachi.Size = New System.Drawing.Size(162, 20)
        Me.tbxdiachi.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Số Điện Thoại"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(320, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(320, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Mật Khẩu"
        '
        'tbxsdt
        '
        Me.tbxsdt.Location = New System.Drawing.Point(410, 6)
        Me.tbxsdt.Name = "tbxsdt"
        Me.tbxsdt.Size = New System.Drawing.Size(162, 20)
        Me.tbxsdt.TabIndex = 8
        '
        'tbxemail
        '
        Me.tbxemail.Location = New System.Drawing.Point(410, 28)
        Me.tbxemail.Name = "tbxemail"
        Me.tbxemail.Size = New System.Drawing.Size(162, 20)
        Me.tbxemail.TabIndex = 8
        '
        'tbxmatkhau
        '
        Me.tbxmatkhau.Location = New System.Drawing.Point(410, 49)
        Me.tbxmatkhau.Name = "tbxmatkhau"
        Me.tbxmatkhau.Size = New System.Drawing.Size(162, 20)
        Me.tbxmatkhau.TabIndex = 8
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(15, 77)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(778, 150)
        Me.DGV1.TabIndex = 9
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(15, 242)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 10
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(112, 242)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 11
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(207, 242)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 12
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btntrongdulieu
        '
        Me.btntrongdulieu.Location = New System.Drawing.Point(15, 271)
        Me.btntrongdulieu.Name = "btntrongdulieu"
        Me.btntrongdulieu.Size = New System.Drawing.Size(75, 23)
        Me.btntrongdulieu.TabIndex = 13
        Me.btntrongdulieu.Text = "Nhập Lại"
        Me.btntrongdulieu.UseVisualStyleBackColor = True
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 310)
        Me.Controls.Add(Me.btntrongdulieu)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.tbxmatkhau)
        Me.Controls.Add(Me.tbxemail)
        Me.Controls.Add(Me.tbxsdt)
        Me.Controls.Add(Me.tbxdiachi)
        Me.Controls.Add(Me.tbxname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbxmatk)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNhanVien"
        Me.Text = "Quản Lý Nhân Viên"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxmatk As System.Windows.Forms.TextBox
    Friend WithEvents tbxname As System.Windows.Forms.TextBox
    Friend WithEvents tbxdiachi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbxsdt As System.Windows.Forms.TextBox
    Friend WithEvents tbxemail As System.Windows.Forms.TextBox
    Friend WithEvents tbxmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btntrongdulieu As System.Windows.Forms.Button
End Class
