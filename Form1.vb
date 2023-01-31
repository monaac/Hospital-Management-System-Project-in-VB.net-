Public Class Form1

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        frmEmployee.Show()
    End Sub

    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        frmStudent.Show()
    End Sub

    Private Sub MedicineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicineToolStripMenuItem.Click
        frmInventory.Show()
    End Sub

    Private Sub EquipmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipmentToolStripMenuItem.Click
        frmInventoryEquipment.Show()
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        frmUserAccountsProfile.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AppointmentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentToolStripMenuItem1.Click
        APPCATEGORY = "Physical Appointment"
        frmPhysicalAppointment.Show()
    End Sub

    Private Sub AppointmentToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentToolStripMenuItem2.Click

        frmAppointments.Show()

    End Sub

   
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLogin.Click

        If tsLogin.Text = "Login" Then
            LoginForm1.Show()
        Else
            tsLogin.Text = "Login"

            tsList.Enabled = False
            tsConsultation.Enabled = False
            tsPhysical.Enabled = False
            tsDental.Enabled = False
            tsSetting.Enabled = False
            tsReports.Enabled = False

        End If


    End Sub

    Private Sub MedicationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicationToolStripMenuItem1.Click

        APPCATEGORY = "Physical Medication"
        frmPhysicalMed.Show()

    End Sub

    
    Private Sub AppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentToolStripMenuItem.Click
        APPCATEGORY = "Dental Appointment"
        frmDentalAppointment.Text = "Dental Appointment"
        frmDentalAppointment.Show()
    End Sub

    Private Sub AppointmentToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentToolStripMenuItem3.Click
        frmAppointments.Show()
    End Sub

    Private Sub MedicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicationToolStripMenuItem.Click
        frmPhysicalMed.Text = "Dental Medication"
        APPCATEGORY = "Dental Medication"
        frmPhysicalMed.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem1.Click
        reporttbs("SELECT * FROM `tblrecords`", "CrystalReport1")
    End Sub

    Private Sub HistoryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem2.Click
        reporttbs("SELECT * FROM `tbldentalxray`", "c3")
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        reporttbs("SELECT * FROM `tblrecords`", "CrystalReport1")
    End Sub

    Private Sub tsReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsReports.Click

    End Sub

    Private Sub MedicalCertificateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicalCertificateToolStripMenuItem.Click
        reporttbs("SELECT * FROM `tblrecords` where IDNO =20007346", "c2")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = DateAndTime.Today & " | " & TimeOfDay

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub

    Private Sub HistoryToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem3.Click
        reporttbs("SELECT * FROM `tblrecords`", "c4")
    End Sub
End Class
