Public Class frmDoctor


    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If APPCATEGORY = "Physical Appointment" Then
            findthis("SELECT `IDNO`, `ACCOUNT_NAME` FROM `useraccounts` WHERE `ACCOUNT_TYPE` ='Physical Doctor'")
            LoadData(dgvDoctor, "LoadDoctor")
        ElseIf APPCATEGORY = "Dental Appointment" Then
            findthis("SELECT `IDNO`, `ACCOUNT_NAME` FROM `useraccounts` WHERE `ACCOUNT_TYPE` ='Dental Doctor'")
            LoadData(dgvDoctor, "LoadDoctor")
        End If

       
    End Sub

    Private Sub dgvInstructor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDoctor.CellClick

        If APPCATEGORY = "Physical Appointment" Then
            With frmPhysicalAppointment
                .txtDoctorId.Text = dgvDoctor.CurrentRow.Cells(0).Value
                .txtDoctorName.Text = dgvDoctor.CurrentRow.Cells(1).Value
            End With
        ElseIf APPCATEGORY = "Dental Appointment" Then
            With frmDentalAppointment
                .txtDoctorId.Text = dgvDoctor.CurrentRow.Cells(0).Value
                .txtDoctorName.Text = dgvDoctor.CurrentRow.Cells(1).Value
            End With
        End If

        Me.Close()
    End Sub
End Class