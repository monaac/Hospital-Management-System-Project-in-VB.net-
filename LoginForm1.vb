Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        findthis("SELECT `ACCOUNT_TYPE`, `ACCOUNT_NAME`, `IDNO` FROM `useraccounts` WHERE `ACCOUNT_USERNAME` ='" & UsernameTextBox.Text & "' and `ACCOUNT_PASSWORD` ='" & PasswordTextBox.Text & "'")
        CheckResult("Login")



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
