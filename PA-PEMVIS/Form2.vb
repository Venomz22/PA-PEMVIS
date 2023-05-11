Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        cmd = New MySqlCommand("UPDATE nota SET payment = '" & cmbMetode.Text & "' where id = '" & pembelian.idnota & "'", con)
        cmd.ExecuteNonQuery()
        invoices.Show()
        pembelian.beli_lagi = 0
        pembelian.judul_sebelum = ""
        pembelian.harga_lama = 0
        pembelian.harga = 0
        pembelian.idnota = ""
        pembelian.Close()

        Menuutama_user_.Show()
        Me.Close()
    End Sub
End Class