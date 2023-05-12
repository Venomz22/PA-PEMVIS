Public Class menuutamaasliuser


    Private Sub menuutamaasliuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Menuutama_user_.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class