Imports MySql.Data.MySqlClient

Public Class Transaksi
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Sub TampilJenis()
        da = New MySqlDataAdapter("Select * From nota", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "nota")
        For i As Integer = 0 To ds.Tables("nota").Rows.Count - 1
            dgv1.Rows.Add(ds.Tables("nota").Rows(i)(0), ds.Tables("nota").Rows(i)(4), ds.Tables("nota").Rows(i)(1), ds.Tables("nota").Rows(i)(2), ds.Tables("nota").Rows(i)(3), ds.Tables("nota").Rows(i)(5))
        Next
        dgv1.Refresh()
    End Sub
    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        TampilJenis()
        dgv1.ReadOnly = True
    End Sub

    Private Sub dgv1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Dim i As Integer
        i = Me.dgv1.CurrentRow.Index
        With dgv1.Rows.Item(i)
            txtID.Text = .Cells(0).Value
            txtIDUser.Text = .Cells(1).Value
            txtjudul.Text = .Cells(2).Value
            txtJumlah.Text = .Cells(3).Value
            txtHarga.Text = .Cells(4).Value
            txtPayment.Text = .Cells(5).Value

        End With
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.Show()
        Me.Close()
    End Sub
End Class