Imports MySql.Data.MySqlClient

Public Class pembelian
    Public buku As String
    Public idnota As String
    Public idnota1 As Integer

    Public harga_lama As Integer
    Public judul_buku As String
    Public judul_sebelum As String
    Public jumlah_pesanan As Integer
    Public harga As Integer
    Public answer As String
    Public beli_lagi As Integer

    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(judul_buku)
        judul.Enabled = False
        total.Enabled = False
        jumlah.Text = ""
        total.Text = ""

        cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & buku & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        judul.Text = rd("judul_buku")
        harga = rd("harga_buku")


        judul_buku = rd("judul_buku")
        rd.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total.Text = Val(jumlah.Text) * harga
        jumlah_pesanan = jumlah_pesanan + Val(jumlah.Text)

        'MsgBox(total.Text)
        'MsgBox(jumlah.Text)
        'MsgBox(harga)

        answer = MsgBox("ingin beli lagi ? ", vbQuestion + vbYesNo + vbDefaultButton2, "PERHATIAN")
        If beli_lagi = 0 Then
            idnota = "not111"
            idnota = idnota
            Dim cmd_inseert = New MySqlCommand("INSERT INTO nota (id,judul,jumlah,harga,iduser,payment) values ('" & idnota & "','" & judul_buku & "','" & jumlah.Text & "','" & total.Text & "','" & login.idlogin & "','')", con)
            cmd_inseert.ExecuteNonQuery()

        Else
            pembelian_Load(sender, e)
            Dim judul = judul_sebelum + "," + judul_buku
            harga_lama = harga_lama + harga
            cmd = New MySqlCommand("UPDATE nota SET harga = '" & harga_lama & "', judul = '" & judul & "', jumlah = '" & jumlah_pesanan & "' where id = '" & idnota & "'", con)
            cmd.ExecuteNonQuery()
        End If

        If answer = MsgBoxResult.Yes Then
            beli_lagi = 1
            judul_sebelum = judul_sebelum + ", " + judul_buku
            Menuutama_user_.Show()
            Me.Hide()
            Exit Sub

        Else
            Form2.Show()
        End If

    End Sub
End Class