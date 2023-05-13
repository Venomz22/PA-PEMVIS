Imports MySql.Data.MySqlClient

Public Class ProfileUser
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        menuutamaasliuser.Show()
        Me.Close()
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Menuutama_user_.Show()
        Me.Close()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        TransaksiUser.Show()
        Me.Close()
    End Sub

    Private Sub ProfileUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

        cmd = New MySqlCommand("select * from user where id = '" & login.idlogin & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtID.Text = login.idlogin
            txtnama.Text = rd("nama")
            txtnomorHp.Text = rd("nohp")
            txtAlamat.Text = rd("alamat")
            txtjk.Text = rd("kelamin")
            txttglLahir.Text = rd("tanggal lahir")
            txtUsername.Text = rd("username")
            rd.Close()
        End If
    End Sub
End Class