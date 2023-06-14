Imports System.Windows.Documents
Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Const nTambah As Integer = 100
    Private Function enkrip(ByVal cInput As String) As String
        Dim nHitung As Integer
        Dim cString As String
        Dim cOutput As String = ""
        cInput = Trim(cInput) 'menghapus white space
        For nHitung = 1 To cInput.Length
            cString = cInput.Substring(nHitung - 1, 1)

            Try
                cOutput += Chr((Asc(cString) + nTambah) - nHitung)
            Catch ex As Exception

            End Try
        Next
        cOutput = StrReverse(cOutput)
        Return cOutput
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()



    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles txtUsername.MouseEnter
        If txtUsername.Text = "Masukkan Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black


        End If
    End Sub

    Private Sub txtUsername_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Masukkan Username"
            txtUsername.ForeColor = Color.Silver


        End If
    End Sub

    Private Sub txtPassword_MouseEnter(sender As Object, e As EventArgs) Handles txtPassword.MouseEnter
        If txtPassword.Text = "Masukkan Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.Black


        End If
    End Sub

    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Masukkan Password"
            txtPassword.ForeColor = Color.Silver
            txtPassword.PasswordChar = ""


        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Role As String = txtDec.Text

        myCon()
        Cmd = New MySqlCommand("Select * from tbl_user  where username ='" & txtUsername.Text & "'and pw='" & txtPassword.Text & "' and role ='" & Role & "'", cn)
        Rdr = Cmd.ExecuteReader
        Rdr.Read()


        If Rdr.HasRows Then
            NamaKasir = txtUsername.Text
            Username = txtUsername.Text
            Me.Hide()
            If txtDec.Text = "Kasir" Then
                MenuForm.Show()

            Else
                MenuFormAdmin.Show()

            End If


        Else
            MsgBox("Username atau Password Salah")



        End If

        Rdr.Close()


    End Sub
End Class