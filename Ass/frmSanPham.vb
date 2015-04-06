Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmSanPham
    Dim chuoiketnoi As String = "workstation id=Cuonghcps01970.mssql.somee.com;packet size=4096;user id=cuonghcps01970;pwd=Minutes123;data source=Cuonghcps01970.mssql.somee.com;persist security info=False;initial catalog=Cuonghcps01970"
    Dim csdl As New DataTable


    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim caulenhtruyvan1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)

        ketnoi.Open()
        caulenhtruyvan1.Fill(csdl)
        DGV2.DataSource = csdl.DefaultView
        ketnoi.Close()

        btnsua.Enabled = False
        btnxoa.Enabled = False


    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim caulenhtruyvan2 As String = "insert into SanPham values (@masp,@tensp,@dgsp,@slsp,@chuthich,@loaisp)"
        Dim thucthicaulenh1 As New SqlCommand(caulenhtruyvan2, ketnoi)
        ketnoi.Open()



        thucthicaulenh1.Parameters.AddWithValue("@masp", txtMasp.Text)
        thucthicaulenh1.Parameters.AddWithValue("@tensp", txtTenSP.Text)

        thucthicaulenh1.Parameters.AddWithValue("@dgsp", txtdongia.Text)
        thucthicaulenh1.Parameters.AddWithValue("@slsp", txtsoluong.Text)

        thucthicaulenh1.Parameters.AddWithValue("@chuthich", txtchuthich.Text)
        thucthicaulenh1.Parameters.AddWithValue("@loaisp", cbx1.SelectedItem)


        thucthicaulenh1.ExecuteNonQuery()

        MessageBox.Show("Đã thêm sản phẩm thành công")




        Dim caulenhtruyvan3 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        csdl.Clear()

        caulenhtruyvan3.Fill(csdl)
        DGV2.DataSource = csdl.DefaultView
        ketnoi.Close()



    End Sub

    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick
        Dim index As Integer = DGV2.CurrentCell.RowIndex
        txtMasp.Text = DGV2.Item(0, index).Value
        txtTenSP.Text = DGV2.Item(1, index).Value
        txtdongia.Text = DGV2.Item(2, index).Value
        txtsoluong.Text = DGV2.Item(3, index).Value
        txtchuthich.Text = DGV2.Item(4, index).Value
        cbx1.SelectedItem = DGV2.Item(5, index).Value

        If frmdangnhap.tbxtaikhoan.Text = "admin" Then
            btnsua.Enabled = True
            btnxoa.Enabled = True
            btnThem.Enabled = False
        Else
            btnsua.Enabled = False
            btnxoa.Enabled = False
            btnThem.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim caulenhtryvan4 As String = "Update SanPham Set MaSP=@masp, TenSP=@tensp, DonGiaSP=@dongia,SoLuongSP=@soluong,ChuThichSP=@chuthich, LoaiSanPham_MaLoaiSP=@loaisp Where MaSP=@masp"

        Dim thucthicaulenh2 As New SqlCommand(caulenhtryvan4, ketnoi)

        ketnoi.Open()
        thucthicaulenh2.Parameters.AddWithValue("@masp", txtMasp.Text)
        thucthicaulenh2.Parameters.AddWithValue("@tensp", txtTenSP.Text)

        thucthicaulenh2.Parameters.AddWithValue("@dongia", txtdongia.Text)
        thucthicaulenh2.Parameters.AddWithValue("@soluong", txtsoluong.Text)

        thucthicaulenh2.Parameters.AddWithValue("@chuthich", txtchuthich.Text)
        thucthicaulenh2.Parameters.AddWithValue("@loaisp", cbx1.SelectedItem)


        thucthicaulenh2.ExecuteNonQuery()



        Dim caulenhSELECT As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        csdl.Clear()

        caulenhSELECT.Fill(csdl)
        DGV2.DataSource = csdl.DefaultView
        ketnoi.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim caulenhtruyvan As String = " delete from SanPham Where MaSP=@masp"
        Dim thucthicaulenh As New SqlCommand(caulenhtruyvan, ketnoi)

        ketnoi.Open()
        thucthicaulenh.Parameters.AddWithValue("@masp", txtMasp.Text)
        thucthicaulenh.ExecuteNonQuery()

        Dim caulenhselect As SqlDataAdapter = New SqlDataAdapter("Select * from SanPham", ketnoi)
        csdl.Clear()
        caulenhselect.Fill(csdl)
        DGV2.DataSource = csdl.DefaultView
        ketnoi.Close()




    End Sub

    Private Sub btnnhaplai_Click(sender As Object, e As EventArgs) Handles btnnhaplai.Click
        txtMasp.Text = ""
        txtTenSP.Text = ""
        txtdongia.Text = ""
        txtsoluong.Text = ""
        txtchuthich.Text = ""
        btnThem.Enabled = True
        btnsua.Enabled = False
        btnxoa.Enabled = False

    End Sub
End Class