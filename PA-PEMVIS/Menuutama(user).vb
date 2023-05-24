Imports MySql.Data.MySqlClient

Public Class Menuutama_user_

    Sub TampilJenis()
        da = New MySqlDataAdapter("SELECT * FROM tbbuku WHERE judul_buku LIKE '%" & TextBox1.Text & "%' AND jumlah > 0", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbbuku")
        For i As Integer = 0 To ds.Tables("tbbuku").Rows.Count - 1
            belibuku.dgv1.Rows.Add(ds.Tables("tbbuku").Rows(i)(10), ds.Tables("tbbuku").Rows(i)(1), ds.Tables("tbbuku").Rows(i)(2), ds.Tables("tbbuku").Rows(i)(3), ds.Tables("tbbuku").Rows(i)(4), ds.Tables("tbbuku").Rows(i)(5),
ds.Tables("tbbuku").Rows(i)(6), ds.Tables("tbbuku").Rows(i)(7), ds.Tables("tbbuku").Rows(i)(8), ds.Tables("tbbuku").Rows(i)(9))
        Next
        belibuku.dgv1.Refresh()
    End Sub
    Private Sub Menuutama_user__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If beli_lagi = 0 Then
            btnBack.Visible = False
            btnBatal.Visible = False
        Else
            btnBack.Visible = True
            btnBatal.Visible = True
        End If

        Me.Refresh()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        belibuku.jenis = "Horor"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        belibuku.jenis = "Misteri"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        belibuku.jenis = "Petualangan"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        belibuku.jenis = "Musik"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        belibuku.jenis = "Sejarah"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        belibuku.jenis = "Drama"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        belibuku.jenis = "Fiksi"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        belibuku.jenis = "Fiksi Ilmiah"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        belibuku.jenis = "Romansa"
        belibuku.Show()
        Me.Dispose()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        belibuku.jenis = "Ensiklopedia"
        belibuku.Show()
        Me.Dispose()
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

    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        TransaksiUser.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Homepage.Show()
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Metode.Show()
        Me.Close()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim answer = MsgBox("Yakin ingin membalkan pesanan ? ", vbQuestion + vbYesNo + vbDefaultButton2, "PERHATIAN")
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
            Me.btnHome.Enabled = True
            Me.btnProfile.Enabled = True
            Me.btnTransaksi.Enabled = True
            Me.btnbook.Enabled = True
            btnBack.Visible = False
            btnBatal.Visible = False
            arrbeliJML.Clear()
            arrbeliID.Clear()
            beli_lagi = 0
            judul_sebelum = ""
            totall = 0
            jumlah_pesanan = 0
        Else
            Me.Refresh()
        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        belibuku.nomor = 1
        belibuku.Show()
        Me.Close()

    End Sub
End Class