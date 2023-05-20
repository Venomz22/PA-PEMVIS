Public Class menuutamaasliadmin


    Private Sub Button32_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Close()
    End Sub

    Private Sub btnprofile_Click_1(sender As Object, e As EventArgs) Handles btnprofile.Click
        ProfileAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnUser_Click_1(sender As Object, e As EventArgs) Handles btnUser.Click
        ReadUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Transaksi.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub menuutamaasliadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ReadBuku.Show()
        Me.Close()

    End Sub
End Class