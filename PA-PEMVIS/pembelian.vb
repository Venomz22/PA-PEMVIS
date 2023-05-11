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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total.Text = Val(jumlah.Text) * harga
        MsgBox(total.Text)
        MsgBox(jumlah.Text)
        MsgBox(harga)
        MsgBox("apakah ingin membeli ?", "confirm", vbYesNo)
    End Sub
End Class

