Public Class frmPhysicalMed


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmMedicine.Show()
    End Sub

    Private Sub frmPhysicalMed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblDate.Text = Format(Now, "yyyy-MM-dd")
    End Sub

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click

        If rbstudent.Checked = True Then
            frmStudent.Show()
        ElseIf rbEmployee.Checked = True Then
            frmEmployee.Show()
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        meddate = lblDate.Text
        medtime = lbltime.Text

        saveInsert("INSERT INTO `tblmedication` (`IDNO`, `PATIENTNAME`, `MEDREASON`, `MEDDATE`, `MEDTIME`)" & _
                 " VALUES (" & txtIdno.Text & ",'" & txtName.Text & "','" & txtReason.Text & "','" & meddate & "','" & medtime & "')")


        For Each row As DataGridViewRow In dgvGivenMed.Rows

            givenmedicine = row.Cells(0).Value
            gmedquantity = row.Cells(2).Value

            saveInsert("INSERT INTO `tblmedicationmedicine` (`IDNO`, `MED_ID`, `MEDNAME`, `MEDQUANTITY`, `MEDDATE`, `MEDTIME`)" & _
        " VALUES (" & txtIdno.Text & "," & givenmedicine & ",'" & row.Cells(1).Value & "', " & gmedquantity & ",'" & meddate & "','" & medtime & "')")


            findthis("SELECT `MEDQUANTITY` FROM `tblmedicine` WHERE `MED_ID` =" & givenmedicine & "")
            CheckResult("SubtractMedicine")

        Next


        Me.Close()


    End Sub

    Private Sub rbEmployee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmployee.CheckedChanged

    End Sub
End Class