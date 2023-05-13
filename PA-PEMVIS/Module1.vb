Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports System.Reflection
Imports Microsoft.VisualBasic.ApplicationServices

Module Module1

    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Public nomorBuku As Integer
    Public nomorUser As Integer
    Public nomorAdmin As Integer
    Public nomorNota As Integer
    Public beli_lagi As Integer
    Public judul_sebelum As String
    Public totall As Integer
    Public idnota As String
    Public jumlah_pesanan As Integer


    Sub koneksi()
        Try
            str = "server=localhost;userid=root;password=;database=pa_pemvis;Convert Zero Datetime=True;"
            con = New MySqlConnection(str)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    'Sub nomor_urut()
    '    cmd = New MySqlCommand("Select * From user where id = '" & login.idlogin & "'", con)
    '    rd = cmd.ExecuteReader
    '    rd.Read()
    '    If rd.HasRows Then
    '        rd.Close()
    '        da = New MySqlDataAdapter("Select * From user where id = '" & login.idlogin & "'", con)
    '        ds = New DataSet
    '        da.Fill(ds, "user")
    '        Dim index1 As Integer = ds.Tables("user").Rows.Count - 1
    '        Dim iduser As String = ds.Tables("user").Rows(index1)(8).ToString
    '        nomorUser = Val(iduser.Substring(1))
    '    Else
    '        rd.Close()
    '        nomorUser = 0
    '    End If





    '    cmd = New MySqlCommand("Select * From tbbuku", con)
    '    rd = cmd.ExecuteReader
    '    rd.Read()
    '    If rd.HasRows Then
    '        rd.Close()
    '        da = New MySqlDataAdapter("Select * From tbbuku", con)
    '        ds = New DataSet
    '        da.Fill(ds, "buku")
    '        Dim index2 As Integer = ds.Tables("buku").Rows.Count - 1
    '        Dim idbuku As String = ds.Tables("buku").Rows(index2)(0).ToString
    '        nomorBuku = Val(idbuku.Substring(2))
    '    Else
    '        rd.Close()
    '        nomorBuku = 0
    '    End If




    '    cmd = New MySqlCommand("Select * FROM nota JOIN user ON user.id = nota.iduser WHERE nota.iduser = '" & login.idlogin & "';", con)

    '    rd = cmd.ExecuteReader
    '    rd.Read()
    '    If rd.HasRows Then
    '        rd.Close()
    '        da = New MySqlDataAdapter(" Select * FROM nota JOIN user ON user.id = nota.iduser WHERE nota.iduser = '" & login.idlogin & "';", con)
    '        ds = New DataSet
    '        da.Fill(ds, "nota")
    '        Dim index3 As Integer = ds.Tables("nota").Rows.Count - 1

    '        Dim idnota As String = ds.Tables("nota").Rows(index3)(0).ToString
    '        nomorNota = Val(idnota.Substring(3))

    '    Else
    '        rd.Close()
    '        nomorNota = 0
    '    End If
    'End Sub

    Function random() As String
        Dim hasil As String = " "
        Dim nilai As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim jumlah = 0
        Dim rand As New Random
        Dim strpos As String = ""
        While jumlah < 3
            strpos = rand.Next(0, nilai.Length)
            hasil = hasil & nilai(strpos)
            jumlah += 1
        End While
        Return hasil
    End Function
End Module
