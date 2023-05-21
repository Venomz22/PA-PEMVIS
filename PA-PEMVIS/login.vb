Imports MySql.Data.MySqlClient
Imports System.Windows
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class login
    Public role As String
    Public nama As String
    Public idlogin As String

    Private Sub loginuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        register.Show()
        Me.Hide()

    End Sub

    Private Sub c_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If lpasss.text = "" And lnamed.text = "" Then
            MsgBox("Username dan Password wajib di isi")
        Else
            Call koneksi()
            Dim un As String = lnamed.text
            Dim pw As String = lpasss.Text

            cmd = New MySqlCommand("select * from user where username = '" & un & "' and password = '" & pw & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                nama = rd("username")
                role = rd("role")
                idlogin = rd("id")
                rd.Close()


                If role = "Admin" Then
                    menuutamaasliadmin.Show()
                    lnamed.text = ""
                    lpasss.text = ""
                    Me.Visible = False
                Else

                    menuutamaasliuser.Show()
                    lnamed.text = ""
                    lpasss.text = ""
                    Me.Visible = False
                End If

            Else
                MsgBox("username atau password anda salah")
                lnamed.text = ""
                lpasss.text = ""
            End If
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Homepage.Show()
        Me.Hide()
    End Sub
End Class
