Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        cmd = New MySqlCommand("UPDATE nota SET payment = '" & cmbMetode.Text & "' where id = '" & idnota & "'", con)
        cmd.ExecuteNonQuery()
        invoices.Show()
        beli_lagi = 0
        judul_sebelum = ""
        idnota = ""
        totall = 0
        jumlah_pesanan = 0
        pembelian.Close()

        Menuutama_user_.Show()
        Me.Close()
    End Sub
End Class