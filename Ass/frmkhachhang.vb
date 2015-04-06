Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmkhachhang
    Dim cons As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
    Dim DataTable1 As DataTable


    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consql As SqlConnection = New SqlConnection(cons)
        Dim QuerySlect As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", consql)
        consql.Open()
        QuerySlect.Fill(DataTable1)
        DGV1.DataSource = DataTable1.DefaultView
        consql.Close()



    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim consql As SqlConnection = New SqlConnection(cons)
        Dim QueryString As String = "Insert into KhachHang values (@id,@name,@address,@phone,@email)"
        Dim ExQuery As New SqlCommand(QueryString, consql)
        consql.Open()
        Try

        

        ExQuery.Parameters.AddWithValue("@id", txtid.Text)
        ExQuery.Parameters.AddWithValue("@name", txtname.Text)
        ExQuery.Parameters.AddWithValue("@address", txtaddress.Text)
        ExQuery.Parameters.AddWithValue("@phone", txtphone.Text)
        ExQuery.Parameters.AddWithValue("@email", txtemail.Text)
            ExQuery.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Lổi")
        End Try

        Dim QuerySelect As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", consql)
        DataTable1.Clear()
        QuerySelect.Fill(DataTable1)
        DGV1.DataSource = DataTable1.DefaultView
        consql.Close()



    End Sub
End Class