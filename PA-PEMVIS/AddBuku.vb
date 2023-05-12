Imports MySql.Data.MySqlClient
Imports System.Windows

Public Class AddBuku
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        txtID.Text = "BK-" + random()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        cmd = New MySqlCommand("Select * From tbbuku where idbuku='" & txtID.Text & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            rd.Close()
            Dim simpan As String = $"insert into tbbuku(idbuku,judul_buku,tahun_terbit, pengarang,penerbit,jenis_buku, jumlah,harga_buku, jumlah_terjual)values ('" & txtID.Text & "', '" & txtjudul.Text & "', '" & txtthun.Text & "', '" & txtPengarang.Text & "', '" & txtPenerbit.Text & "', '" & cmbjenis.Text & "', '" & txtjumlah.Text & "', '" & txtHarga.Text & "', '" & txtterjual.Text & "')"
            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()
            MsgBox("Simpan data sukses....|", MsgBoxStyle.Information, "Perhatian")
        End If
        ReadBuku.dgv1.Rows.Clear()
        ReadBuku.TampilJenis()
        ReadBuku.Show()
        Me.Close()

    End Sub

    Sub clear()
        cmbjenis.Text = ""
        txtjudul.Clear()
        txtPengarang.Clear()
        txtPenerbit.Clear()
        txtjumlah.Clear()
        txtHarga.Clear()
        txtterjual.Clear()
        txtthun.Clear()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()

    End Sub
End Class