Public Class menuutamaasliuser


    Private Sub menuutamaasliuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        welcome.Text = "HALO " & login.nama.ToUpper

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        Menuutama_user_.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ProfileUser.Show()
        Me.Close()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        TransaksiUser.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Close()
    End Sub
End Class