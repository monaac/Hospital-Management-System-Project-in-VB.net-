Public Class frmInventoryEquipment


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Me.Close()
    'End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

  

    'End Sub

    'Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   
    'End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            saveInsert("INSERT INTO `tblequipments` (`EQCATEGORY`, `EQTYPE`, `EQNAME`, `DESCRIPTION`, `EQQUANTITY`)" & _
                          " VALUES ('" & cbCategory.Text & "','" & cbType.Text & "','" & txtName.Text & "', '" & txtDescription.Text & "','" & txtQuantity.Text & "')")

            cbCategory.Text = ""
            cbType.Text = ""
            txtName.Clear()
            txtDescription.Clear()
            txtQuantity.Clear()


            frmInventoryEquipment_Load(sender, e)

            
        End If
        If btnSave.Text = "UPDATE" Then
            UpdateSave("UPDATE `tblequipments` set `EQQUANTITY`='" & txtQuantity.Text & "' WHERE `EQ_ID` = " & dgvEquipment.CurrentRow.Cells(0).Value & "")
            cbCategory.Text = ""
            cbType.Text = ""
            txtName.Clear()
            txtDescription.Clear()
            txtQuantity.Clear()
            btnSave.Text = "Save"

            frmInventoryEquipment_Load(sender, e)

        End If

    End Sub

    Private Sub frmInventoryEquipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvEquipment.Rows.Clear()
        findthis("SELECT * FROM `tblequipments`")
        LoadData(dgvEquipment, "LoadEquipment")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        txtName.Text = dgvEquipment.CurrentRow.Cells(1).Value
        txtDescription.Text = dgvEquipment.CurrentRow.Cells(2).Value
        txtQuantity.Text = dgvEquipment.CurrentRow.Cells(3).Value
        btnSave.Text = "UPDATE"
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class