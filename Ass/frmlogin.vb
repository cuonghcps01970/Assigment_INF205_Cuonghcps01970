Imports System.Data.SqlClient

Public Class frmdangnhap

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
      


        ' Tạo chuổi kết nối'

        Dim chuoiketnoi As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
        'tạo kết nối thông quan chuổi kết nối'
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        ' Thực hiện truy vấn'
        Dim sqladapter As SqlDataAdapter = New SqlDataAdapter(" select * from NhanVien where MaNV ='" & tbxtaikhoan.Text & "'and matkhau='" & tbxmatkhau.Text & "'", ketnoi)
        Dim csdl As New DataTable
        Try
            ketnoi.Open()
            sqladapter.Fill(csdl)
            If csdl.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu")
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        tbxtaikhoan.Text = ""
        tbxmatkhau.Text = ""
        tbxtaikhoan.Focus()

    End Sub

    Private Sub frmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
