Imports System.IO
Imports MySql.Data.MySqlClient

Public Class pembelian
    Public buku As String
    Public judul_buku As String
    Public harga As Integer
    Public answer As String
    Dim jumlahbuku As Integer
    Dim gambar As String

    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        judul.Enabled = False
        total.Enabled = False
        jumlah.Text = ""
        total.Text = ""
        cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & buku & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        judul.Text = rd("judul_buku")
        harga = rd("harga_buku")
        jumlahbuku = rd("jumlah")
        judul_buku = rd("judul_buku")
        gambar = rd("gambar")
        rd.Close()

        btnbook.Enabled = False
        btnHome.Enabled = False
        btnProfile.Enabled = False
        btnTransaksi.Enabled = False
        Dim sFolder As String = "D:\Dunia Perkuliahan\Semester 4\Pratikum\Pemrograman Visual\PA-PEMVIS\Gambar"
        PictureBox1.ImageLocation = Path.Combine(sFolder, Path.GetFileName(gambar))
    End Sub


    Private Sub jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlah.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MessageBox.Show("Wajib mengisi dengan angka", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click

    End Sub

    Private Sub btnbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Val(jumlah.Text) > jumlahbuku Then
            MsgBox("Stok buku tidak cukup")
            jumlah.Text = ""
        Else
            total.Text = Val(jumlah.Text) * harga
            jumlah_pesanan = jumlah_pesanan + Val(jumlah.Text)
            jumlahbuku = jumlahbuku - Val(jumlah.Text)
            answer = MsgBox("ingin beli lagi ? ", vbQuestion + vbYesNo + vbDefaultButton2, "PERHATIAN")
            If beli_lagi = 0 Then
                Dim kode As String = login.idlogin & "N-" & random()
                Dim cmd_inseert = New MySqlCommand("INSERT INTO nota (id,judul,jumlah,harga,iduser,payment,kode,tgl) values (' ', '" & judul_buku & "','" & jumlah.Text & "','" & total.Text & "','" & login.idlogin & "','', '" & kode & "','')", con)
                cmd_inseert.ExecuteNonQuery()
                Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah = " & jumlahbuku & " where idbuku = '" & buku & "'", con)
                cmbbb.ExecuteNonQuery()
                cmd = New MySqlCommand("Select * From nota where iduser = '" & login.idlogin & "' and kode = '" & kode & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    idnota = rd("id")
                    rd.Close()
                End If
                rd.Close()
            Else
                Dim judul = judul_sebelum + ", " + judul_buku
                Dim totalll = totall + Val(total.Text)
                cmd = New MySqlCommand("UPDATE nota SET harga = '" & totalll & "', judul = '" & judul & "', jumlah = '" & jumlah_pesanan & "' where id = '" & idnota & "'", con)
                cmd.ExecuteNonQuery()
                Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah = " & jumlahbuku & " where idbuku = '" & buku & "'", con)
                cmbbb.ExecuteNonQuery()
            End If

            If answer = MsgBoxResult.Yes Then
                If beli_lagi = 0 Then
                    judul_sebelum = judul_buku
                Else
                    judul_sebelum = judul_sebelum + ", " + judul_buku
                End If
                beli_lagi = 1
                arrbeliID.Add(buku)
                arrbeliJML.Add(jumlah.Text)
                totall = Val(total.Text) + totall
                total.Text = ""
                jumlah.Text = ""
                Menuutama_user_.btnHome.Enabled = False
                Menuutama_user_.btnProfile.Enabled = False
                Menuutama_user_.btnTransaksi.Enabled = False
                Menuutama_user_.btnbook.Enabled = False
                Menuutama_user_.Show()
                Me.Close()
                Exit Sub

            Else
                arrbeliID.Add(buku)
                arrbeliJML.Add(jumlah.Text)
                Metode.Show()
                Me.Visible = False


            End If
        End If

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Menuutama_user_.Show()
        Me.Close()
    End Sub
End Class