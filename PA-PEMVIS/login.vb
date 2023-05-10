Imports MySql.Data.MySqlClient
Imports System.Windows
Imports System.Data.Odbc
Imports System.Data.SqlClient


Public Class login
    Dim role As String

    Private Sub loginuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call koneksi()

        Dim un As String = lname.Text
        Dim pw As String = lpass.Text

        cmd = New MySqlCommand("select * from akun where username = '" & un & "' and password = '" & pw & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            role = rd("rule")

            If role = "admin" Then

                menuutamaasliadmin.Show()
                Me.Visible = False
            Else

                menuutamaasliuser.Show()
                Me.Visible = False
            End If

        Else
            MsgBox("username atau password anda salah")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
