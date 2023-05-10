Imports MySql.Data.MySqlClient

Public Class pembelian
    Public buku As String
    Public harga_lama As Integer
    Public harga As Integer

    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        judul.Enabled = False
        total.Enabled = False
        cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & buku & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()

        judul.Text = rd("judul_buku")
        harga = rd("harga_buku")
        rd.Close()

    End Sub

    Private Sub jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged

    End Sub

    Private Sub jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlah.KeyPress

        total.Text = Val(jumlah.Text) * harga
        MsgBox(total.Text)
        MsgBox(jumlah.Text)
        MsgBox(harga)
    End Sub
End Class

