Imports MySql.Data.MySqlClient

<<<<<<< HEAD
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
=======
Public Class ProfileAdmin
    Private Sub ProfileAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        menuutamaasliadmin.Show()
        Me.Close()

    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ReadUser.Show()
        Me.Close()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ReadBuku.Show()
        Me.Close()
    End Sub
>>>>>>> faf2d3c79090e1c1f2daa6ec3d64ac2329527800
End Class