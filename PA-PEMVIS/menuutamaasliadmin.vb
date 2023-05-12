Public Class menuutamaasliadmin



    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        ProfileAdmin.Show()
        Me.Hide()

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ReadBuku.Show()
        Me.Hide()

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ReadUser.Show()
        Me.Hide()

    End Sub

    Private Sub menuutamaasliadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class