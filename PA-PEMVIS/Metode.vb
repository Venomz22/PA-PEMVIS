Imports System.Runtime.ConstrainedExecution
Imports MySql.Data.MySqlClient

Public Class Metode
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbMetode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMetode.SelectedIndexChanged

    End Sub

    Private Sub btnbeli_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        cmd = New MySqlCommand("UPDATE nota SET payment = '" & cmbMetode.Text & "', tgl = NOW() where id = '" & idnota & "'", con)
        cmd.ExecuteNonQuery()
        If beli_lagi = 0 Then
            cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & pembelian.buku & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim terjual As Integer = rd("jumlah_terjual") + Val(pembelian.jumlah.Text)
            rd.Close()
            Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah_terjual = " & terjual & " where idbuku = '" & pembelian.buku & "'", con)
            cmbbb.ExecuteNonQuery()
        Else
            For i As Integer = 0 To arrbeliID.Count - 1
                cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & arrbeliID(i) & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim jumlahbuku As Integer = rd("jumlah") - Val(arrbeliJML(i))
                Dim terjual As Integer = rd("jumlah_terjual") + Val(arrbeliJML(i))
                rd.Close()
                Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah_terjual = " & terjual & " where idbuku = '" & arrbeliID(i) & "'", con)
                cmbbb.ExecuteNonQuery()
            Next
        End If
        invoices.Show()
        arrbeliJML.Clear()
        arrbeliID.Clear()
        beli_lagi = 0
        judul_sebelum = ""
        totall = 0
        jumlah_pesanan = 0
        pembelian.Close()
        Me.Close()
    End Sub
End Class