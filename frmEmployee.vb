Public Class frmEmployee

 
    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        findthis("SELECT `EMPID`, `INST_FULLNAME`, `INST_SEX` FROM `instructor`")
        LoadData(dgvInstructor, "LoadEmployee")
    End Sub

    Private Sub dgvInstructor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInstructor.CellClick

      
        If APPCATEGORY = "Dental Appointment" Then
            With frmDentalAppointment
                .txtIdno.Text = dgvInstructor.CurrentRow.Cells(0).Value
                .txtName.Text = dgvInstructor.CurrentRow.Cells(1).Value
            End With


        ElseIf APPCATEGORY = "Dental Medication" Then

            With frmPhysicalMed
                .txtIdno.Text = dgvInstructor.CurrentRow.Cells(0).Value
                .txtName.Text = dgvInstructor.CurrentRow.Cells(1).Value
            End With

        ElseIf APPCATEGORY = "Physical Appointment" Then

            With frmPhysicalAppointment
                .txtIdno.Text = dgvInstructor.CurrentRow.Cells(0).Value
                .txtName.Text = dgvInstructor.CurrentRow.Cells(1).Value
            End With

        ElseIf APPCATEGORY = "Physical Medication" Then

            With frmPhysicalMed
                .txtIdno.Text = dgvInstructor.CurrentRow.Cells(0).Value
                .txtName.Text = dgvInstructor.CurrentRow.Cells(1).Value
            End With

        End If




        Me.Close()

    End Sub
End Class