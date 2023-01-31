<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.tsHome = New System.Windows.Forms.ToolStripMenuItem
        Me.tsLogin = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsList = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsConsultation = New System.Windows.Forms.ToolStripMenuItem
        Me.DentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MedicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MedicalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AppointmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MedicationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsPhysical = New System.Windows.Forms.ToolStripMenuItem
        Me.AppointmentToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsDental = New System.Windows.Forms.ToolStripMenuItem
        Me.AppointmentToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsSetting = New System.Windows.Forms.ToolStripMenuItem
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsReports = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MedicalCertificateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsHome, Me.tsList, Me.tsConsultation, Me.tsPhysical, Me.tsDental, Me.tsReports, Me.tsSetting})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsHome
        '
        Me.tsHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLogin, Me.ExitToolStripMenuItem})
        Me.tsHome.Image = Global.KCCCIMS.My.Resources.Resources.Home
        Me.tsHome.Name = "tsHome"
        Me.tsHome.Size = New System.Drawing.Size(68, 20)
        Me.tsHome.Text = "Home"
        '
        'tsLogin
        '
        Me.tsLogin.Name = "tsLogin"
        Me.tsLogin.Size = New System.Drawing.Size(152, 22)
        Me.tsLogin.Text = "Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'tsList
        '
        Me.tsList.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.MedicineToolStripMenuItem, Me.EquipmentToolStripMenuItem})
        Me.tsList.Enabled = False
        Me.tsList.Image = Global.KCCCIMS.My.Resources.Resources.Default_Document
        Me.tsList.Name = "tsList"
        Me.tsList.Size = New System.Drawing.Size(53, 20)
        Me.tsList.Text = "List"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'MedicineToolStripMenuItem
        '
        Me.MedicineToolStripMenuItem.Name = "MedicineToolStripMenuItem"
        Me.MedicineToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MedicineToolStripMenuItem.Text = "Medicine"
        '
        'EquipmentToolStripMenuItem
        '
        Me.EquipmentToolStripMenuItem.Name = "EquipmentToolStripMenuItem"
        Me.EquipmentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EquipmentToolStripMenuItem.Text = "Equipment"
        '
        'tsConsultation
        '
        Me.tsConsultation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DentalToolStripMenuItem, Me.MedicalToolStripMenuItem})
        Me.tsConsultation.Enabled = False
        Me.tsConsultation.Image = Global.KCCCIMS.My.Resources.Resources.Sharing_Overlay
        Me.tsConsultation.Name = "tsConsultation"
        Me.tsConsultation.Size = New System.Drawing.Size(103, 20)
        Me.tsConsultation.Text = "Consultation"
        '
        'DentalToolStripMenuItem
        '
        Me.DentalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentToolStripMenuItem, Me.MedicationToolStripMenuItem})
        Me.DentalToolStripMenuItem.Name = "DentalToolStripMenuItem"
        Me.DentalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DentalToolStripMenuItem.Text = "Dental"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AppointmentToolStripMenuItem.Text = "Appointment"
        '
        'MedicationToolStripMenuItem
        '
        Me.MedicationToolStripMenuItem.Name = "MedicationToolStripMenuItem"
        Me.MedicationToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.MedicationToolStripMenuItem.Text = "Medication"
        '
        'MedicalToolStripMenuItem
        '
        Me.MedicalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentToolStripMenuItem1, Me.MedicationToolStripMenuItem1})
        Me.MedicalToolStripMenuItem.Name = "MedicalToolStripMenuItem"
        Me.MedicalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MedicalToolStripMenuItem.Text = "Physical"
        '
        'AppointmentToolStripMenuItem1
        '
        Me.AppointmentToolStripMenuItem1.Name = "AppointmentToolStripMenuItem1"
        Me.AppointmentToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.AppointmentToolStripMenuItem1.Text = "Appointment"
        '
        'MedicationToolStripMenuItem1
        '
        Me.MedicationToolStripMenuItem1.Name = "MedicationToolStripMenuItem1"
        Me.MedicationToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.MedicationToolStripMenuItem1.Text = "Medication"
        '
        'tsPhysical
        '
        Me.tsPhysical.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentToolStripMenuItem2, Me.HistoryToolStripMenuItem})
        Me.tsPhysical.Enabled = False
        Me.tsPhysical.Image = Global.KCCCIMS.My.Resources.Resources._2
        Me.tsPhysical.Name = "tsPhysical"
        Me.tsPhysical.Size = New System.Drawing.Size(78, 20)
        Me.tsPhysical.Text = "Physical"
        '
        'AppointmentToolStripMenuItem2
        '
        Me.AppointmentToolStripMenuItem2.Name = "AppointmentToolStripMenuItem2"
        Me.AppointmentToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.AppointmentToolStripMenuItem2.Text = "Appointment"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'tsDental
        '
        Me.tsDental.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentToolStripMenuItem3, Me.HistoryToolStripMenuItem2, Me.HistoryToolStripMenuItem3})
        Me.tsDental.Enabled = False
        Me.tsDental.Image = Global.KCCCIMS.My.Resources.Resources.ds
        Me.tsDental.Name = "tsDental"
        Me.tsDental.Size = New System.Drawing.Size(69, 20)
        Me.tsDental.Text = "Dental"
        '
        'AppointmentToolStripMenuItem3
        '
        Me.AppointmentToolStripMenuItem3.Name = "AppointmentToolStripMenuItem3"
        Me.AppointmentToolStripMenuItem3.Size = New System.Drawing.Size(145, 22)
        Me.AppointmentToolStripMenuItem3.Text = "Appointment"
        '
        'HistoryToolStripMenuItem2
        '
        Me.HistoryToolStripMenuItem2.Name = "HistoryToolStripMenuItem2"
        Me.HistoryToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.HistoryToolStripMenuItem2.Text = "X-Ray"
        '
        'HistoryToolStripMenuItem3
        '
        Me.HistoryToolStripMenuItem3.Name = "HistoryToolStripMenuItem3"
        Me.HistoryToolStripMenuItem3.Size = New System.Drawing.Size(145, 22)
        Me.HistoryToolStripMenuItem3.Text = "History"
        '
        'tsSetting
        '
        Me.tsSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem})
        Me.tsSetting.Enabled = False
        Me.tsSetting.Image = Global.KCCCIMS.My.Resources.Resources.Run
        Me.tsSetting.Name = "tsSetting"
        Me.tsSetting.Size = New System.Drawing.Size(77, 20)
        Me.tsSetting.Text = "Settings"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'tsReports
        '
        Me.tsReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem1, Me.MedicalCertificateToolStripMenuItem})
        Me.tsReports.Enabled = False
        Me.tsReports.Image = Global.KCCCIMS.My.Resources.Resources.Printer
        Me.tsReports.Name = "tsReports"
        Me.tsReports.Size = New System.Drawing.Size(75, 20)
        Me.tsReports.Text = "Reports"
        '
        'HistoryToolStripMenuItem1
        '
        Me.HistoryToolStripMenuItem1.Name = "HistoryToolStripMenuItem1"
        Me.HistoryToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.HistoryToolStripMenuItem1.Text = "History"
        '
        'MedicalCertificateToolStripMenuItem
        '
        Me.MedicalCertificateToolStripMenuItem.Name = "MedicalCertificateToolStripMenuItem"
        Me.MedicalCertificateToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MedicalCertificateToolStripMenuItem.Text = "Medical Certificate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "KCCCIMS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KCCCIMS.My.Resources.Resources.Untitled_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(880, 501)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "KABANKALAN CATHOLIC COLLEGE CLINIC INFORMATION SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsConsultation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSetting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPhysical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDental As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalCertificateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HistoryToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem

End Class
