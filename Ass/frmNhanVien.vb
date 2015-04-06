Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmNhanVien

    Private Sub frmNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chuoiketnoi1 As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi1)
        Dim caulenhtruyvan As SqlDataAdapter = New SqlDataAdapter(" select * from NhanVien ", ketnoi)
        Dim csdl As New DataTable
        Try
            ketnoi.Open()
            caulenhtruyvan.Fill(csdl)

        Catch ex As Exception

        End Try
        DGV1.DataSource = csdl.DefaultView
        ketnoi.Close()

        btnsua.Enabled = False
        btnxoa.Enabled = False



    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        Dim index As Integer = DGV1.CurrentCell.RowIndex
        tbxmatk.Text = DGV1.Item(0, index).Value
        tbxname.Text = DGV1.Item(1, index).Value
        tbxdiachi.Text = DGV1.Item(2, index).Value
        tbxsdt.Text = DGV1.Item(3, index).Value
        tbxemail.Text = DGV1.Item(4, index).Value
        tbxmatkhau.Text = DGV1.Item(5, index).Value

        If frmdangnhap.tbxtaikhoan.Text = "admin" Then
            btnsua.Enabled = True
            btnxoa.Enabled = True
            btnthem.Enabled = False
        Else
            btnsua.Enabled = False
            btnxoa.Enabled = False
            btnthem.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnthem.Click





        DGV1.DataSource = "" 'làm rổng datagridview'
        Dim chuoiketnoi2 As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
        Dim ketnoi3 As SqlConnection = New SqlConnection(chuoiketnoi2)
        Dim caulenhtruyvan1 As SqlDataAdapter = New SqlDataAdapter(" Insert into NhanVien values" +
                                                                   "( '" & tbxmatk.Text & "','" & tbxname.Text & "'," +
                                                                   "'" & tbxdiachi.Text & "','" & tbxsdt.Text & "'," +
                                                                   "'" & tbxemail.Text & "','" & tbxmatkhau.Text & "')", ketnoi3)

        Dim csdl3 As New DataTable


        ketnoi3.Open()
        caulenhtruyvan1.Fill(csdl3) ' đưa dữ liệu câu lệnh Insert vào CSDL3'

        Try
            Dim caulenhtruyvan2 As SqlDataAdapter = New SqlDataAdapter(" select" +
                                                                       "* from NhanVien ", ketnoi3)

            caulenhtruyvan2.Fill(csdl3)
        Catch ex As Exception

        End Try
        DGV1.DataSource = csdl3.DefaultView
        ketnoi3.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim chuoiketnoi4 As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
        Dim ketnoi4 As SqlConnection = New SqlConnection(chuoiketnoi4)
        Dim csdl4 As New DataTable
        ketnoi4.Open()
        Dim caulenh5 As String = "delete  from  NhanVien where manv=@manv"

        Dim thucthicaulenh1 As New SqlCommand(caulenh5, ketnoi4)
        Try
            thucthicaulenh1.Parameters.AddWithValue("@manv", tbxmatk.Text)

            thucthicaulenh1.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("lổi")
        End Try
        Dim caulenhtruyvan2 As SqlDataAdapter = New SqlDataAdapter(" select" +
                                                                      "* from NhanVien ", ketnoi4)

        caulenhtruyvan2.Fill(csdl4)
        DGV1.DataSource = csdl4.DefaultView

        ketnoi4.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsua.Click 'nut sửa
        Dim chuoiketnoi2 As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
        Dim ketnoi3 As SqlConnection = New SqlConnection(chuoiketnoi2)
        Dim csdl3 As New DataTable


        ketnoi3.Open()

        Dim caulenh4 As String = "update  NhanVien set MaNV=@manv, TenNV=@hoten," +
            "DiaChiNV=@diachi, SDTNV=@sodt, EmailNV=@email,matkhau=@matkhau where MaNV=@manv "


        Dim thucthicaulenh As New SqlCommand(caulenh4, ketnoi3)
        Try
            thucthicaulenh.Parameters.AddWithValue("@manv", tbxmatk.Text)
            thucthicaulenh.Parameters.AddWithValue("@hoten", tbxname.Text)
            thucthicaulenh.Parameters.AddWithValue("@diachi", tbxdiachi.Text)
            thucthicaulenh.Parameters.AddWithValue("@sodt", tbxsdt.Text)
            thucthicaulenh.Parameters.AddWithValue("@email", tbxemail.Text)
            thucthicaulenh.Parameters.AddWithValue("@matkhau", tbxmatkhau.Text)

            thucthicaulenh.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show("Có thể xãy ra lổi hãy thử lại lần nữa")
        End Try


        Dim caulenhtruyvan2 As SqlDataAdapter = New SqlDataAdapter(" select" +
                                                                      "* from NhanVien ", ketnoi3)

        caulenhtruyvan2.Fill(csdl3)
        DGV1.DataSource = csdl3.DefaultView

        ketnoi3.Close()
        '
        ' Lổi khi click vào một số dữ liệu thì không hiện lên các ô Textbox


        '
    End Sub

    Private Sub btntrongdulieu_Click(sender As Object, e As EventArgs) Handles btntrongdulieu.Click
        tbxname.Text = ""
        tbxmatk.Text = ""
        tbxdiachi.Text = ""
        tbxsdt.Text = ""
        tbxemail.Text = ""
        tbxmatkhau.Text = ""
        tbxmatk.Focus()
        btnsua.Enabled = False
        btnxoa.Enabled = False
        btnthem.Enabled = True



    End Sub
End Class