Imports MySql.Data.MySqlClient

Public Class invoices
    Private Sub invoices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilJenis()

    End Sub

    Sub TampilJenis()

        'da = New MySqlDataAdapter("Select * From nota where id ='" & pembelian.idnota & "'", con)
        'ds = New DataSet
        ''ds.Clear()
        'da.Fill(ds, "nota")
        'For i As Integer = 0 To ds.Tables("nota").Rows.Count - 1
        'DataGridView1.Rows.Add(ds.Tables("nota").Rows(i)(0), login.nama, ds.Tables("nota").Rows(i)(1), ds.Tables("nota").Rows(i)(2), ds.Tables("nota").Rows(i)(3))
        ' Next
        ' DataGridView1.Refresh()
        cmd = New MySqlCommand("select * from nota where id = '" & pembelian.idnota & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()

        nota.Text = pembelian.idnota
        judul.Text = rd("judul")
        pemesan.Text = login.nama
        jumlah.Text = rd("jumlah")
        harga.Text = rd("harga")
        metode.Text = rd("payment")
        rd.Close()

        Me.Refresh()



    End Sub

    Private Sub id_Click(sender As Object, e As EventArgs) Handles id.Click

    End Sub
End Class