Imports MySql.Data.MySqlClient
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class belibuku

    Public jenis As String
    Public id As String

    Private Sub belibuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub TampilJenis()

        da = New MySqlDataAdapter("Select * From tbbuku where jenis_buku ='" & jenis & "' AND jumlah > 0 ", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbbuku")
        For i As Integer = 0 To ds.Tables("tbbuku").Rows.Count - 1
            dgv1.Rows.Add(ds.Tables("tbbuku").Rows(i)(0), ds.Tables("tbbuku").Rows(i)(1), ds.Tables("tbbuku").Rows(i)(2), ds.Tables("tbbuku").Rows(i)(3), ds.Tables("tbbuku").Rows(i)(4), ds.Tables("tbbuku").Rows(i)(5),
ds.Tables("tbbuku").Rows(i)(6), ds.Tables("tbbuku").Rows(i)(7))
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
        txtthun.Clear()
    End Sub

    Private Sub btnbeli_Click(sender As Object, e As EventArgs) Handles btnbeli.Click

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
            id = .Cells(0).Value
        End With
        pembelian.buku = id
        pembelian.Show()

        Me.Close()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjenis.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtterjual_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtthun_TextChanged(sender As Object, e As EventArgs) Handles txtthun.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtjudul_TextChanged(sender As Object, e As EventArgs) Handles txtjudul.TextChanged

    End Sub

    Private Sub txtPengarang_TextChanged(sender As Object, e As EventArgs) Handles txtPengarang.TextChanged

    End Sub

    Private Sub Nama_Click(sender As Object, e As EventArgs) Handles Nama.Click

    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtPenerbit_TextChanged(sender As Object, e As EventArgs) Handles txtPenerbit.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        menuutamaasliuser.Show()
        Me.Close()

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click

        Me.Close()
    End Sub

    Private Sub btnbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        Menuutama_user_.Show()
        Me.Close()


    End Sub
End Class