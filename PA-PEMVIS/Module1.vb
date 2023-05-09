Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Module Module1

    Public con As MySqlConnection
        Public cmd As MySqlCommand
        Public rd As MySqlDataReader
        Public da As MySqlDataAdapter
        Public ds As DataSet
        Public str As String
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
End Module
