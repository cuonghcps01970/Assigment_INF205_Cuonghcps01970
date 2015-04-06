Public Class frmMain

    Private Sub ThôngTinNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinNhânViênToolStripMenuItem.Click
        frmNhanVien.Show()

    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click

    End Sub

    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmSảnPhẩmToolStripMenuItem.Click
        frmSanPham.Show()

    End Sub

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        frmkhachhang.Show()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmdangnhap.tbxtaikhoan.Text = "admin" Then
            lblResultLogin.Text = "Quản Lý"
        Else
            lblResultLogin.Text = "Nhân Viên"
        End If

    End Sub

    Private Sub QuảnLýHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        frmdangnhap.Show()

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Hide()

    End Sub
End Class