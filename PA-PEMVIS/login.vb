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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If lpass.Text = "" And lname.Text = "" Then
            MsgBox("Username dan Password wajib di isi")
        Else
            Call koneksi()
            Dim un As String = lname.Text
            Dim pw As String = lpass.Text

            cmd = New MySqlCommand("select * from user where username = '" & un & "' and password = '" & pw & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                nama = rd("nama")
                role = rd("role")
                idlogin = rd("id")
                rd.Close()


                If role = "Admin" Then
                    menuutamaasliadmin.Show()
                    lname.Text = ""
                    lpass.Text = ""
                    Me.Visible = False
                Else

                    menuutamaasliuser.Show()
                    lname.Text = ""
                    lpass.Text = ""
                    Me.Visible = False
                End If

            Else
                MsgBox("username atau password anda salah")
                lname.Text = ""
                lpass.Text = ""
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        register.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
