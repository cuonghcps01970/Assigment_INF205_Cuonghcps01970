Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmkhachhang
    Dim cons As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
    Dim DataTable1 As New DataTable


    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consql As SqlConnection = New SqlConnection(cons)
        Dim QuerySlect As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", consql)
        consql.Open()
        QuerySlect.Fill(DataTable1)
        DGV1.DataSource = DataTable1.DefaultView
        consql.Close()

        btnedit.Enabled = False
        btndelete.Enabled = False

        txtid.Focus()



    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim consql As SqlConnection = New SqlConnection(cons)
        Dim QueryString As String = "Insert into KhachHang values (@id,@name,@address,@phone,@email)"
        Dim ExQuery As New SqlCommand(QueryString, consql)
        consql.Open()




        ExQuery.Parameters.AddWithValue("@id", txtid.Text)
        ExQuery.Parameters.AddWithValue("@name", txtname.Text)
        ExQuery.Parameters.AddWithValue("@address", txtaddress.Text)
        ExQuery.Parameters.AddWithValue("@phone", txtphone.Text)
        ExQuery.Parameters.AddWithValue("@email", txtemail.Text)
        ExQuery.ExecuteNonQuery()


        Dim QuerySelect As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", consql)
        DataTable1.Clear()
        QuerySelect.Fill(DataTable1)
        DGV1.DataSource = DataTable1.DefaultView
        consql.Close()



    End Sub

    Private Sub txtedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim consql As SqlConnection = New SqlConnection(cons)
        Dim QueryString As String = "Update  KhachHang Set TenKH=@name,DiaChi=@address,SoDienThoai=@phone,Email=@email where MaKH=@id"
        Dim ExQuery As New SqlCommand(QueryString, consql)
        consql.Open()




        ExQuery.Parameters.AddWithValue("@id", txtid.Text)
        ExQuery.Parameters.AddWithValue("@name", txtname.Text)
        ExQuery.Parameters.AddWithValue("@address", txtaddress.Text)
        ExQuery.Parameters.AddWithValue("@phone", txtphone.Text)
        ExQuery.Parameters.AddWithValue("@email", txtemail.Text)
        ExQuery.ExecuteNonQuery()
        MsgBox("Đã sửa thành công", MsgBoxStyle.Information, "Thông Báo")

        Dim QuerySelect As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", consql)
        DataTable1.Clear()
        QuerySelect.Fill(DataTable1)
        DGV1.DataSource = DataTable1.DefaultView
        consql.Close()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click



        Dim consql As SqlConnection = New SqlConnection(cons)
        Dim QueryString As String = "Delete from KhachHang where MaKH=@id"
        Dim ExQuery As New SqlCommand(QueryString, consql)
        consql.Open()




        ExQuery.Parameters.AddWithValue("@id", txtid.Text)
        
        ExQuery.ExecuteNonQuery()
        MsgBox("Xóa Thành Công", MsgBoxStyle.Information, "Thông Báo")

        Dim QuerySelect As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", consql)
        DataTable1.Clear()
        QuerySelect.Fill(DataTable1)
        DGV1.DataSource = DataTable1.DefaultView
        consql.Close()
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        Dim index As Integer = DGV1.CurrentCell.RowIndex
        txtid.Text = DGV1.Item(0, index).Value
        txtname.Text = DGV1.Item(1, index).Value
        txtaddress.Text = DGV1.Item(2, index).Value
        txtphone.Text = DGV1.Item(3, index).Value
        txtemail.Text = DGV1.Item(4, index).Value
        If frmdangnhap.tbxtaikhoan.Text = "admin" Then
            btnedit.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
        Else
            btnedit.Enabled = False
            btndelete.Enabled = False
            btnadd.Enabled = False

        End If
    End Sub
End Class