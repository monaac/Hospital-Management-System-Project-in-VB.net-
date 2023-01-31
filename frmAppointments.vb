Public Class frmAppointments

   

    Private Sub frmAppointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If usertype = "Physical Doctor" Then

            findthis("SELECT  `IDNO` ,  `PATIENTNAME` ,  `REASONS` FROM  `tblrecords` WHERE `PATIENTSTATUS` ='Appointment' and `APPCATEGORY` ='Physical Appointment'")
            LoadData(dgvAppointments, "LoadAppointments")

        ElseIf usertype = "Dental Doctor" Then

            findthis("SELECT  `IDNO` ,  `PATIENTNAME` ,  `REASONS` FROM  `tblrecords` WHERE `PATIENTSTATUS` ='Appointment' and `APPCATEGORY` ='Dental Appointment'")
            LoadData(dgvAppointments, "LoadAppointments")

        End If

       

    End Sub

    Private Sub btnCheckup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckup.Click

        If usertype = "Physical Doctor" Then

            findthis("SELECT * FROM `tblrecords` WHERE `IDNO` =" & dgvAppointments.CurrentRow.Cells(0).Value & "")
            LoadSingleData("Appointments")

        ElseIf usertype = "Dental Doctor" Then

            findthis("SELECT * FROM `tblrecords` WHERE `IDNO` =" & dgvAppointments.CurrentRow.Cells(0).Value & "")
            LoadSingleData("AppointmentsDental")

        End If

       

        Me.Close()
    End Sub
End Class