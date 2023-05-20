Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class belibuku

    Public jenis As String
    Public id As Integer
    Public nomor As Integer

    Private Sub belibuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()

        If nomor = 0 Then
            TampilJenis()
            If beli_lagi = 0 Then
                btnBack.Visible = False
                btnBatal.Visible = False
            Else
                btnBack.Visible = True
                btnBatal.Visible = True
            End If
            btnbeli.Enabled = False
        Else
            Menuutama_user_.TampilJenis()
            If beli_lagi = 0 Then
                btnBack.Visible = False
                btnBatal.Visible = False
            Else
                btnBack.Visible = True
                btnBatal.Visible = True
            End If
            btnbeli.Enabled = False
        End If
        dgv1.ReadOnly = True


    End Sub

    Sub TampilJenis()
        da = New MySqlDataAdapter("Select * From tbbuku where jenis_buku ='" & jenis & "' AND jumlah > 0 ", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbbuku")
        For i As Integer = 0 To ds.Tables("tbbuku").Rows.Count - 1
            dgv1.Rows.Add(ds.Tables("tbbuku").Rows(i)(10), ds.Tables("tbbuku").Rows(i)(1), ds.Tables("tbbuku").Rows(i)(2), ds.Tables("tbbuku").Rows(i)(3), ds.Tables("tbbuku").Rows(i)(4), ds.Tables("tbbuku").Rows(i)(5),
ds.Tables("tbbuku").Rows(i)(6), ds.Tables("tbbuku").Rows(i)(7), ds.Tables("tbbuku").Rows(i)(9))
        Next
        dgv1.Refresh()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick
        Dim i As Integer
        i = Me.dgv1.CurrentRow.Index
        If i <> dgv1.RowCount - 1 Then
            With dgv1.Rows.Item(i)
                txtID.Text = .Cells(0).Value
                txtjudul.Text = .Cells(1).Value
                txtthun.Text = .Cells(2).Value
                txtPengarang.Text = .Cells(3).Value
                txtPenerbit.Text = .Cells(4).Value
                txtjenis.Text = .Cells(5).Value
                txtjumlah.Text = .Cells(6).Value
                txtHarga.Text = .Cells(7).Value
                Dim sFolder As String = "D:\Dunia Perkuliahan\Semester 4\Pratikum\Pemrograman Visual\PA-PEMVIS\Gambar"
                Dim files = .Cells(8).Value
                PictureBox1.ImageLocation = Path.Combine(sFolder, Path.GetFileName(files))
                btnbeli.Enabled = True
            End With
            cmd = New MySqlCommand("Select * From tbbuku where judul_buku = '" & txtjudul.Text & "' and pengarang = '" & txtPengarang.Text & "' and penerbit = '" & txtPenerbit.Text & "' and kode = '" & txtID.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                id = rd("idbuku")
                rd.Close()
            End If
            rd.Close()
        End If
    End Sub

    Sub clear()
        txtID.Clear()
        txtjenis.Clear()
        txtjudul.Clear()
        txtPengarang.Clear()
        txtPenerbit.Clear()
        txtjumlah.Clear()
        txtHarga.Clear()
        txtthun.Clear()
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbjenis_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtterjual_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtthun_TextChanged(sender As Object, e As EventArgs) Handles txtthun.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtjudul_TextChanged(sender As Object, e As EventArgs) Handles txtjudul.TextChanged

    End Sub

    Private Sub txtPengarang_TextChanged(sender As Object, e As EventArgs) Handles txtPengarang.TextChanged

    End Sub

    Private Sub Nama_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPenerbit_TextChanged(sender As Object, e As EventArgs) Handles txtPenerbit.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

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
        ProfileUser.Show()

        Me.Close()
    End Sub

    Private Sub btnbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        Menuutama_user_.Show()
        Me.Close()


    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        TransaksiUser.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        login.Show()
        Me.Close()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Metode.Show()
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim answer = MsgBox("Yakin ingin membatalkan pesanan ? ", vbQuestion + vbYesNo + vbDefaultButton2, "PERHATIAN")
        If answer = MsgBoxResult.Yes Then
            For i As Integer = 0 To arrbeliID.Count - 1
                cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & arrbeliID(i) & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim jumlahbuku As Integer = rd("jumlah") + Val(arrbeliJML(i))
                rd.Close()
                Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah = " & jumlahbuku & " where idbuku = '" & arrbeliID(i) & "'", con)
                cmbbb.ExecuteNonQuery()
            Next
            Menuutama_user_.btnHome.Enabled = True
            Menuutama_user_.btnProfile.Enabled = True
            Menuutama_user_.btnTransaksi.Enabled = True
            Menuutama_user_.btnbook.Enabled = True
            Menuutama_user_.btnBack.Visible = False
            Menuutama_user_.btnBatal.Visible = False
            Menuutama_user_.Show()
            btnBack.Visible = False
            btnBatal.Visible = False
            arrbeliJML.Clear()
            arrbeliID.Clear()
            beli_lagi = 0
            judul_sebelum = ""
            totall = 0
            jumlah_pesanan = 0
            Menuutama_user_.Show()
            Me.Close()
        Else
            Me.Refresh()
        End If

    End Sub

    Private Sub btnbeli_Click(sender As Object, e As EventArgs) Handles btnbeli.Click
        'Dim i As Integer
        'i = Me.dgv1.CurrentRow.Index

        'With dgv1.Rows.Item(i)
        '    txtID.Text = .Cells(0).Value
        '    txtjudul.Text = .Cells(1).Value
        '    txtthun.Text = .Cells(2).Value
        '    txtPengarang.Text = .Cells(3).Value
        '    txtPenerbit.Text = .Cells(4).Value
        '    txtjenis.Text = .Cells(5).Value
        '    txtjumlah.Text = .Cells(6).Value
        '    txtHarga.Text = .Cells(7).Value
        'End With
        pembelian.buku = id
        pembelian.Show()

        Me.Close()
    End Sub
End Class