Imports MySql.Data.MySqlClient
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class belibuku

    Public jenis As String

    Private Sub belibuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(jenis)
    End Sub

    Sub TampilJenis()

        da = New MySqlDataAdapter("Select * From tbbuku where jenis_buku ='" & jenis & "'", con)
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
End Class