Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_koneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String

        username = T_username.Text
        password = T_password.Text

        login(username, password)
    End Sub

    Sub login(username As String, password As String)
        Try
            Tabel = Conn_Mysql.ExecuteQuery_Mysql("
                        SELECT username, password 
                        FROM tb_user 
                        WHERE username = '" & username & "' AND password = MD5('" & password & "') 
                        LIMIT 1")
            If Tabel.Rows.Count > 0 Then
                Dashboard.Show()
                Me.Hide()
            Else
                MsgBox("Username atau password anda salah, silahkan ulangi lagi")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class