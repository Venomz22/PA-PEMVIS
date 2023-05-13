﻿Imports MySql.Data.MySqlClient
Imports System.Windows

Public Class AddBuku
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        txtID.Text = "BK-" + random()
        txtterjual.Text = 0

    End Sub

    Private Function cek_data_kosong() As Boolean
        If txtjudul.Text = "" Then
            MessageBox.Show("Judul buku harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtjudul.Focus()
            Return False
        ElseIf txtthun.Text = "" Then
            MessageBox.Show("Tahun terbit harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtthun.Focus()
            Return False
        ElseIf cmbjenis.Text = "" Then
            MessageBox.Show("Jenis buku harus dipilih", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbjenis.Focus()
            Return False
        ElseIf txtPengarang.Text = "" Then
            MessageBox.Show("Nama pengarang harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPengarang.Focus()
            Return False
        ElseIf txtPenerbit.Text = "" Then
            MessageBox.Show("Nama penerbit harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPenerbit.Focus()
            Return False
        ElseIf txtjumlah.Text = "" Then
            MessageBox.Show("Jumlah buku harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtjumlah.Focus()
            Return False
        ElseIf txtHarga.Text = "" Then
            MessageBox.Show("Harga buku harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus()
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cek_data_kosong() = True Then
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
        End If
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        menuutamaasliadmin.Show()
        Me.Close()

    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        ProfileAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ReadUser.Show()
        Me.Close()

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ReadBuku.Show()
        Me.Close()

    End Sub

    Private Sub txtthun_TextChanged(sender As Object, e As EventArgs) Handles txtthun.TextChanged

    End Sub

    Private Sub txtthun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtthun.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MessageBox.Show("Wajib mengisi dengan angka", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[1-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MessageBox.Show("Wajib mengisi dengan angka dan harus lebih dari 0", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[1-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MessageBox.Show("Wajib mengisi dengan angka dan harus lebih dari 0", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Transaksi.Show()
        Me.Close()
    End Sub
End Class