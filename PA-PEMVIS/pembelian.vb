Imports MySql.Data.MySqlClient

Public Class pembelian
    Public buku As String
    Public judul_buku As String
    Public harga As Integer
    Public answer As String
    Dim jumlahbuku As Integer
    Dim terjual As Integer

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
        terjual = rd("jumlah_terjual")
        judul_buku = rd("judul_buku")
        rd.Close()

        btnbook.Enabled = False
        btnHome.Enabled = False
        btnProfile.Enabled = False
        btnTransaksi.Enabled = False






    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total.Text = Val(jumlah.Text) * harga
        jumlahbuku = jumlahbuku - Val(jumlah.Text)
        terjual = terjual + Val(jumlah.Text)
        jumlah_pesanan = jumlah_pesanan + Val(jumlah.Text)

        answer = MsgBox("ingin beli lagi ? ", vbQuestion + vbYesNo + vbDefaultButton2, "PERHATIAN")
        If beli_lagi = 0 Then
            idnota = login.idlogin + "N-" + random()
            Dim cmd_inseert = New MySqlCommand("INSERT INTO nota (id,judul,jumlah,harga,iduser,payment) values ('" & idnota & "','" & judul_buku & "','" & jumlah.Text & "','" & total.Text & "','" & login.idlogin & "','')", con)
            cmd_inseert.ExecuteNonQuery()
            Dim cmbb = New MySqlCommand("UPDATE tbbuku SET jumlah = " & jumlahbuku & ", jumlah_terjual = " & terjual & " where idbuku = '" & buku & "'", con)
            cmbb.ExecuteNonQuery()
        Else
            Dim judul = judul_sebelum + ", " + judul_buku
            Dim totalll = totall + Val(total.Text)
            cmd = New MySqlCommand("UPDATE nota SET harga = '" & totalll & "', judul = '" & judul & "', jumlah = '" & jumlah_pesanan & "' where id = '" & idnota & "'", con)
            cmd.ExecuteNonQuery()
            Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah = " & jumlahbuku & ", jumlah_terjual = " & terjual & " where idbuku = '" & buku & "'", con)
            cmbbb.ExecuteNonQuery()
        End If
        If answer = MsgBoxResult.Yes Then
            If beli_lagi = 0 Then
                judul_sebelum = judul_buku
            Else
                judul_sebelum = judul_sebelum + ", " + judul_buku
            End If
            beli_lagi = 1
            totall = Val(total.Text) + totall
            total.Text = ""
            jumlah.Text = ""
            Menuutama_user_.Show()
            Me.Close()
            Exit Sub

        Else
            Form2.Show()
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Menuutama_user_.Show()
        Me.Close()

    End Sub
End Class