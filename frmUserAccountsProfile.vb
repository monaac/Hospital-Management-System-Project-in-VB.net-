Public Class frmUserAccountsProfile

   
    Private Sub frmUserAccountsProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvUsers.Rows.Clear()
        findthis("SELECT `ACCOUNT_NAME`, `ACCOUNT_USERNAME`, `ACCOUNT_TYPE` FROM `useraccounts`")
        LoadData(dgvUsers, "LoadUsers")
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtname.Text = String.Empty Or txtUsername.Text = String.Empty Or txtpass.Text = String.Empty Or txtIDNO.Text = String.Empty Or cbtype.Text = String.Empty Then
                MsgBox("")



            Else
                If txtpass.Text = txtconfirm.Text Then
                    saveInsert("INSERT INTO `useraccounts` (`ACCOUNT_NAME`, `ACCOUNT_USERNAME`, `ACCOUNT_PASSWORD`, `ACCOUNT_TYPE`, `IDNO`)" & _
                                          " VALUES ('" & txtname.Text & "','" & txtUsername.Text & "', '" & txtpass.Text & "', '" & cbtype.Text & "'," & txtIDNO.Text & ")")
                    txtIDNO.Clear()
                    txtname.Clear()
                    txtpass.Clear()
                    txtconfirm.Clear()
                    txtUsername.Clear()
                    cbtype.Text = ""

                    frmUserAccountsProfile_Load(sender, e)
                Else
                    MsgBox("Password does not match.")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

   
End Class