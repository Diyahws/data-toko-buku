Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM admin WHERE username = '" & txboxUsername.Text & "' AND password = '" & txboxPassword.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            MainForm.Show()
            FormDataBuku.cmboxAdmin.Text = dr!username
            Me.Hide()
        Else
            MessageBox.Show("Username dan Password Salah", "Informasi", MessageBoxButtons.OK)
            txboxPassword.Text = ""
        End If
    End Sub
End Class
