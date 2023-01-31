Public Class frmStudent

    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        findthis("SELECT `IDNO`, concat(`LNAME`, ', ', `FNAME`, ' ', `MNAME`) as Name, `SEX` FROM `tblstudent`")
        LoadData(dgvstudent, "LoadStudent")
    End Sub

    Private Sub dgvstudent_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvstudent.CellClick



        If APPCATEGORY = "Dental Appointment" Then
            With frmDentalAppointment
                .txtIdno.Text = dgvstudent.CurrentRow.Cells(0).Value
                .txtName.Text = dgvstudent.CurrentRow.Cells(1).Value
            End With


        ElseIf APPCATEGORY = "Dental Medication" Then

            With frmPhysicalMed
                .txtIdno.Text = dgvstudent.CurrentRow.Cells(0).Value
                .txtName.Text = dgvstudent.CurrentRow.Cells(1).Value
            End With

        ElseIf APPCATEGORY = "Physical Appointment" Then

            With frmPhysicalAppointment
                .txtIdno.Text = dgvstudent.CurrentRow.Cells(0).Value
                .txtName.Text = dgvstudent.CurrentRow.Cells(1).Value
            End With

        ElseIf APPCATEGORY = "Physical Medication" Then

            With frmPhysicalMed
                .txtIdno.Text = dgvstudent.CurrentRow.Cells(0).Value
                .txtName.Text = dgvstudent.CurrentRow.Cells(1).Value
            End With

        End If


      

        Me.Close()


    End Sub

End Class