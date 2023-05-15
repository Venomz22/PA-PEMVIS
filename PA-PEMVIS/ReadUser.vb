Imports MySql.Data.MySqlClient
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class ReadUser
    Dim index As Integer
    Private Sub ReadUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

        cmd = New MySqlCommand("select * from user where role = 'User'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            rd.Close()
            Data(index)
            btnprev.Enabled = False
        Else
            rd.Close()
            btnprev.Enabled = False
            btnNext.Enabled = False
        End If
    End Sub


    Public Sub Data(ByVal posisi As Integer)
        da = New MySqlDataAdapter("Select * From user where role = 'User'", con)
        ds = New DataSet
        da.Fill(ds, "user")
        txtID.Text = ds.Tables("user").Rows(posisi)(8).ToString
        txtnama.Text = ds.Tables("user").Rows(posisi)(1).ToString
        txtnomorHp.Text = ds.Tables("user").Rows(posisi)(2).ToString
        txtAlamat.Text = ds.Tables("user").Rows(posisi)(3).ToString
        txtjk.Text = ds.Tables("user").Rows(posisi)(5).ToString
        txttglLahir.Text = ds.Tables("user").Rows(posisi)(6).ToString
        txtUsername.Text = ds.Tables("user").Rows(posisi)(0).ToString
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        Index -= 1
        Data(Index)
        If Index = 0 Then
            btnprev.Enabled = False
        End If
        btnNext.Enabled = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Index += 1
        If Index = ds.Tables("user").Rows.Count - 1 Then
            Data(Index)
            btnNext.Enabled = False
            btnprev.Enabled = True
        ElseIf ds.Tables("user").Rows.Count = 1 Then
            Data(0)
            btnNext.Enabled = False
            btnprev.Enabled = False
        Else
            Data(Index)
            btnprev.Enabled = True
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        menuutamaasliadmin.Show()
        Me.Close()

    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        ProfileAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ReadBuku.Show()
        Me.Close()

    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Transaksi.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Close()
    End Sub
End Class