Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports MySql.Data.MySqlClient

Public Class ReadBuku
    Dim jenis As String

    Sub TampilJenis()
        da = New MySqlDataAdapter("Select * From tbbuku", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbbuku")
        For i As Integer = 0 To ds.Tables("tbbuku").Rows.Count - 1
            dgv1.Rows.Add(ds.Tables("tbbuku").Rows(i)(0), ds.Tables("tbbuku").Rows(i)(1), ds.Tables("tbbuku").Rows(i)(2), ds.Tables("tbbuku").Rows(i)(3), ds.Tables("tbbuku").Rows(i)(4), ds.Tables("tbbuku").Rows(i)(5),
ds.Tables("tbbuku").Rows(i)(6), ds.Tables("tbbuku").Rows(i)(7), ds.Tables("tbbuku").Rows(i)(8))
        Next
        dgv1.Refresh()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        TampilJenis()
        dgv1.ReadOnly = True


    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Dim i As Integer
        i = Me.dgv1.CurrentRow.Index
        With dgv1.Rows.Item(i)
            txtID.Text = .Cells(0).Value
            txtjudul.Text = .Cells(1).Value
            txtthun.Text = .Cells(2).Value
            txtPengarang.Text = .Cells(3).Value
            txtPenerbit.Text = .Cells(4).Value
            cmbjenis.Text = .Cells(5).Value
            txtjumlah.Text = .Cells(6).Value
            txtHarga.Text = .Cells(7).Value
            txtterjual.Text = .Cells(8).Value

        End With
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AddBuku.Show()
        Me.Hide()

    End Sub

    Sub clear()
        txtID.Clear()
        cmbjenis.SelectedIndex = -1
        txtjudul.Clear()
        txtPengarang.Clear()
        txtPenerbit.Clear()
        txtjumlah.Clear()
        txtHarga.Clear()
        txtterjual.Clear()
        txtthun.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        cmd = New MySqlCommand("Select * From tbbuku where idbuku='" & txtID.Text & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            Dim simpan As String = "DELETE From tbbuku Where idbuku ='" & txtID.Text & "'; "
            rd.Close()
            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()

            MsgBox("Hapus data sukses....|", MsgBoxStyle.Information, "Perhatian")
            clear()
            dgv1.Rows.Clear()
            TampilJenis()

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cmd = New MySqlCommand("Select * From tbbuku where idbuku='" & txtID.Text & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Dim simpan As String = "UPDATE tbbuku SET judul_buku ='" & txtjudul.Text & "', tahun_terbit = " & txtthun.Text & ", pengarang ='" & txtPengarang.Text & "', penerbit ='" & txtPenerbit.Text & "', jenis_buku ='" & cmbjenis.Text & "', jumlah =" & txtjumlah.Text & ", harga_buku =" & txtHarga.Text & ", jumlah_terjual = " & txtterjual.Text & "
WHERE idbuku = '" & txtID.Text & "';"
            rd.Close()
            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()

            MsgBox("Edit data sukses....|", MsgBoxStyle.Information, "Perhatian")
            clear()
            dgv1.Rows.Clear()
            TampilJenis()


        End If
    End Sub
End Class