Imports System.Drawing.Printing
Imports System.Runtime.ConstrainedExecution
Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class Metode
    Inherits Form
    Dim panjang As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1

    End Sub

    Public Sub New()

        MyBase.New()
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim f As Font = New Font("Calibri", 12, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black) 'br = adalah warna font
        Dim p As Pen = New Pen(Color.Black) 'p = adalah warna garis kotak
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f101 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f102 As New Font("Times New Roman", 10, FontStyle.Italic)
        Dim f11 As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f12 As New Font("Times New Roman", 14, FontStyle.Bold)
        Dim f13 As New Font("Times New Roman", 14, FontStyle.Italic)

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat

        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width


        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center
        'e.Graphics.DrawString(Path.Combine("D:\Dunia Perkuliahan\Semester 4\Pratikum\Pemrograman Visual\PA-PEMVIS\Gambar", Path.GetFileName("IMG_20160213_143534")), f, br, 60, 60)
        'e.Graphics.DrawString("Belajar Visual Studio", f, br, 60, 90)
        Dim newimage As Image = Image.FromFile("D:\Dunia Perkuliahan\Semester 4\Pratikum\Pemrograman Visual\PA-PEMVIS\PA-PEMVIS\Resources\book-shop2.png")
        e.Graphics.DrawString("MANTAP BOOKSTORE", f11, br, centermargin, 50, tengah)
        e.Graphics.DrawImage(newimage, centermargin, 10, 35, 33)
        e.Graphics.DrawString("ID Pembelian : " & idnota, f10, br, leftmargin - 90, 90)
        e.Graphics.DrawString("Tanggal           : " & Format(Now, "dd-MM-yyyy"), f10, br, leftmargin - 90, 110)
        e.Graphics.DrawString("Jenis Payment     : " & cmbMetode.Text, f10, br, leftmargin - 90, 130)
        Dim garis As String = "----------------------------------------------------------------------------------------"
        e.Graphics.DrawString(garis, f10, br, 0, 150)
        Dim tingi As Integer
        If beli_lagi = 0 Then
            cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & pembelian.buku & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim judul As String = rd("judul_buku")
            Dim jumlah As Integer = Val(pembelian.jumlah.Text)
            Dim harga As Integer = rd("harga_buku")
            rd.Close()
            e.Graphics.DrawString(jumlah, f10, br, leftmargin - 90, 170)
            e.Graphics.DrawString(judul, f10, br, leftmargin - 50, 170)
            e.Graphics.DrawString(harga, f10, br, rightmargin, 170, kanan)
            e.Graphics.DrawString(garis, f10, br, 0, 190)
            cmd = New MySqlCommand("select * from nota where id = '" & idnota & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            e.Graphics.DrawString(rd("jumlah"), f11, br, leftmargin - 90, 210)
            e.Graphics.DrawString(rd("harga"), f11, br, rightmargin, 210, kanan)
            rd.Close()
            e.Graphics.DrawString("~Terima Kasih Belanja~", f10, br, centermargin, 250, tengah)
            e.Graphics.DrawString("~Di Toko Kami~", f10, br, centermargin, 270, tengah)
        Else
            For i As Integer = 0 To arrbeliID.Count - 1
                cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & arrbeliID(i) & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim judul As String = rd("judul_buku")
                Dim jumlah As Integer = Val(arrbeliJML(i))
                Dim harga As Integer = rd("harga_buku")
                rd.Close()
                e.Graphics.DrawString(jumlah, f10, br, leftmargin - 90, 170 + tingi)
                e.Graphics.DrawString(judul, f10, br, leftmargin - 50, 170 + tingi)
                e.Graphics.DrawString(harga, f10, br, rightmargin, 170 + tingi, kanan)
                tingi += 20
            Next
            tingi = 170 + tingi
            e.Graphics.DrawString(garis, f10, br, 0, tingi)
            cmd = New MySqlCommand("select * from nota where id = '" & idnota & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            e.Graphics.DrawString(rd("jumlah"), f11, br, leftmargin - 90, tingi + 20)
            e.Graphics.DrawString(rd("harga"), f11, br, rightmargin, tingi + 20, kanan)
            rd.Close()
            e.Graphics.DrawString("~Terima Kasih Belanja~", f10, br, centermargin, tingi + 60, tengah)
            e.Graphics.DrawString("~Di Toko Kami~", f10, br, centermargin, tingi + 80, tengah)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbMetode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMetode.SelectedIndexChanged

    End Sub

    Private Sub btnbeli_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        cmd = New MySqlCommand("UPDATE nota SET payment = '" & cmbMetode.Text & "', tgl = NOW() where id = '" & idnota & "'", con)
        cmd.ExecuteNonQuery()
        If beli_lagi = 0 Then
            cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & pembelian.buku & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim terjual As Integer = rd("jumlah_terjual") + Val(pembelian.jumlah.Text)
            rd.Close()
            Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah_terjual = " & terjual & " where idbuku = '" & pembelian.buku & "'", con)
            cmbbb.ExecuteNonQuery()
        Else
            For i As Integer = 0 To arrbeliID.Count - 1
                cmd = New MySqlCommand("select * from tbbuku where idbuku = '" & arrbeliID(i) & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim jumlahbuku As Integer = rd("jumlah") - Val(arrbeliJML(i))
                Dim terjual As Integer = rd("jumlah_terjual") + Val(arrbeliJML(i))
                rd.Close()
                Dim cmbbb = New MySqlCommand("UPDATE tbbuku SET jumlah_terjual = " & terjual & " where idbuku = '" & arrbeliID(i) & "'", con)
                cmbbb.ExecuteNonQuery()
            Next
        End If
        ubah_panjag()
        PrintPreviewDialog1.ShowDialog()
        arrbeliJML.Clear()
        arrbeliID.Clear()
        beli_lagi = 0
        judul_sebelum = ""
        totall = 0
        jumlah_pesanan = 0
        pembelian.Close()
        Me.Close()
        Menuutama_user_.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim page As New PageSettings
        page.PaperSize = New PaperSize("Custom", 250, panjang)
        PrintDocument1.DefaultPageSettings = page

    End Sub
    Sub ubah_panjag()
        If beli_lagi = 0 Then
            panjang = 300
        Else
            Dim rowcount As Integer
            panjang = 0
            rowcount = arrbeliID.Count
            panjang = rowcount * 20
            panjang = panjang + 300
        End If


    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.EndPrint

    End Sub
End Class