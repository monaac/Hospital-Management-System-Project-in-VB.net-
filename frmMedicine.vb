Public Class frmMedicine


    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        dgvMedicine.Rows.Clear()
        findthis("SELECT `MED_ID`, `MEDNAME` FROM `tblmedicine` WHERE `CATEGORY`='" & cbCategory.Text & "' and `MEDTYPE`='" & cbType.Text & "'")
        LoadData(dgvMedicine, "SelectMed")

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In dgvMedicine.Rows
            If row.Cells(0).Value = True Then
                frmPhysicalMed.dgvGivenMed.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value)
            End If
        Next
        Me.Close()
    End Sub
End Class