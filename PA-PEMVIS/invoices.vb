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
        cmd = New MySqlCommand("select * from nota where id = '" & idnota & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()

        nota.Text = rd("kode")
        judul.Text = rd("judul")
        pemesan.Text = login.nama
        jumlah.Text = rd("jumlah")
        harga.Text = rd("harga")
        metode.Text = rd("payment")
        rd.Close()
        Me.Refresh()



    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Menuutama_user_.Show()
        Me.Close()
    End Sub

    Private Sub judul_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class