Public Class menuutamaasliuser


    Private Sub menuutamaasliuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        welcome1.Text = "HALO " & login.nama.ToUpper

    End Sub



    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ProfileUser.Show()
        Me.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        Menuutama_user_.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        TransaksiUser.Show()
        Me.Close()
    End Sub

    Private Sub BunifuImageButton2_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Close()
    End Sub
End Class