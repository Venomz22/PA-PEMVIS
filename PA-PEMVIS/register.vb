Imports MySql.Data.MySqlClient

Public Class register
    Dim kelamin As String
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub rpass2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Function cek_data_kosong() As Boolean
        If rnama.Text = "" Then
            MessageBox.Show("Nama harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rnama.Focus()
            Return False
        ElseIf rusernamea.Text = "" Then
            MessageBox.Show("Username harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rusernamea.Focus()
            Return False
        ElseIf rpass.Text = "" Then
            MessageBox.Show("Password harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rpass.Focus()
            Return False
        ElseIf rnomorHP.Text = "" Then
            MessageBox.Show("NomorHP harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rnomorHP.Focus()
            Return False
        ElseIf rAlamat.Text = "" Then
            MessageBox.Show("Alamat harus diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rAlamat.Focus()
            Return False
        ElseIf RbLaki.Checked = False And rbCewek.Checked = False Then
            MessageBox.Show("Jenis kelamin harus dipilih", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        If cek_data_kosong() = True Then
            cmd = New MySqlCommand("select * from user where username = '" & rusernamea.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Username telah tersedia")
                rusernamea.Text = " "
                rusernamea.Focus()
                rd.Close()
            Else
                rd.Close()
                If rbCewek.Checked Then
                    kelamin = rbCewek.Text
                ElseIf RbLaki.Checked Then
                    kelamin = RbLaki.Text
                End If
                Dim role As String = "User"
                Dim kode As String = "U-" + random()
                Dim cmdd = New MySqlCommand("INSERT INTO user (username,nama,nohp,alamat,password,kelamin, tanggal_lahir, role, id, kode) values ('" & rusernamea.Text & "','" & rnama.Text & "','" & rnomorHP.Text & "','" & rAlamat.Text & "','" & rpass.Text & "','" & kelamin & "', '" & Format(tanggal.Value, "yyyy-MM-dd") & "', '" & role & "', ' ', '" & kode & "')", con)
                cmdd.ExecuteNonQuery()
                MsgBox("Anda berhasil registrasi")
                login.Show()
                Me.Close()


            End If
        End If
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If cek_data_kosong() = True Then
            cmd = New MySqlCommand("select * from user where username = '" & rusernamea.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Username telah tersedia")
                rusernamea.Text = " "
                rusernamea.Focus()
                rd.Close()
            Else
                rd.Close()
                If rbCewek.Checked Then
                    kelamin = rbCewek.Text
                ElseIf RbLaki.Checked Then
                    kelamin = RbLaki.Text
                End If
                Dim role As String = "User"
                Dim kode As String = "U-" + random()
                Dim cmdd = New MySqlCommand("INSERT INTO user (username,nama,nohp,alamat,password,kelamin, tanggal_lahir, role, id, kode) values ('" & rusernamea.Text & "','" & rnama.Text & "','" & rnama.Text & "','" & rnama.Text & "','" & rnama.Text & "','" & kelamin & "', '" & Format(tanggal.Value, "yyyy-MM-dd") & "', '" & role & "', ' ', '" & kode & "')", con)
                cmdd.ExecuteNonQuery()
                MsgBox("Anda berhasil registrasi")
                login.Show()
                Me.Close()


            End If
        End If
    End Sub



    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub rnomorHP_OnValueChanged(sender As Object, e As EventArgs) Handles rnomorHP.OnValueChanged

    End Sub

    Private Sub rnomorHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rnomorHP.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like “[0-9]” OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
            MessageBox.Show("Wajib mengisi dengan angka", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class