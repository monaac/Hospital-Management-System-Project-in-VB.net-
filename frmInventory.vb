Public Class frmInventory


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            saveInsert("INSERT INTO `tblmedicine` (`MEDNAME`, `MEDDESCRIPTION`, `MEDQUANTITY`, `CATEGORY`, `MEDTYPE`, `MEDVALUE`, `MEDUNIT`)" & _
                          " VALUES ('" & txtName.Text & "','" & txtDescription.Text & "', " & txtQuantity.Text & ", '" & cbCategory.Text & "','" & cbType.Text & "'," & txtValue.Text & ",'" & txtUnit.Text & "')")

            cbCategory.Text = ""
            cbType.Text = ""
            txtName.Clear()
            txtDescription.Clear()
            txtQuantity.Clear()
            txtValue.Clear()
            txtUnit.Clear()

            frmInventory_Load(sender, e)
        End If
        If btnSave.Text = "Update" Then
            saveInsert("UPDATE `tblmedicine` set `MEDQUANTITY`= '" & txtQuantity.Text & "' Where MED_ID='" & dgvMedicine.CurrentRow.Cells(0).Value & "' ")
            txtDescription.Clear()
            txtQuantity.Clear()
            txtValue.Clear()
            txtUnit.Clear()


            frmInventory_Load(sender, e)
        End If
    End Sub

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvMedicine.Rows.Clear()
        findthis("SELECT * FROM `tblmedicine`")
        LoadData(dgvMedicine, "LoadMedicine")
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With dgvMedicine
            txtName.Text = dgvMedicine.CurrentRow.Cells(1).Value
            txtDescription.Text = dgvMedicine.CurrentRow.Cells(2).Value
            txtValue.Text = dgvMedicine.CurrentRow.Cells(3).Value
            txtUnit.Text = dgvMedicine.CurrentRow.Cells(4).Value
            txtQuantity.Text = dgvMedicine.CurrentRow.Cells(5).Value
        End With
        btnSave.Text = "UPDATE"
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        reporttbs("SELECT * FROM `tblmedicine`", "c5")

    End Sub
End Class