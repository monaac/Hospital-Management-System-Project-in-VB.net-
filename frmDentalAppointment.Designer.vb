<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDentalAppointment
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAllergies = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSurgeries = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSymptoms = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbAlcohol = New System.Windows.Forms.CheckBox
        Me.cbSmoke = New System.Windows.Forms.CheckBox
        Me.cbExercise = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtReason = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDoctorId = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDoctorName = New System.Windows.Forms.TextBox
        Me.btnBrowsedoctor = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbEmployee = New System.Windows.Forms.RadioButton
        Me.rbstudent = New System.Windows.Forms.RadioButton
        Me.btnbrowse = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtIdno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(753, 365)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 24)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(682, 365)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 24)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Any Allergies :"
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergies.Location = New System.Drawing.Point(27, 41)
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(365, 26)
        Me.txtAllergies.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Past Surgeries :"
        '
        'txtSurgeries
        '
        Me.txtSurgeries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurgeries.Location = New System.Drawing.Point(27, 88)
        Me.txtSurgeries.Name = "txtSurgeries"
        Me.txtSurgeries.Size = New System.Drawing.Size(365, 26)
        Me.txtSurgeries.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Symptoms :"
        '
        'txtSymptoms
        '
        Me.txtSymptoms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSymptoms.Location = New System.Drawing.Point(27, 136)
        Me.txtSymptoms.Name = "txtSymptoms"
        Me.txtSymptoms.Size = New System.Drawing.Size(365, 26)
        Me.txtSymptoms.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbAlcohol)
        Me.GroupBox3.Controls.Add(Me.cbSmoke)
        Me.GroupBox3.Controls.Add(Me.cbExercise)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 169)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 44)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lifestyle"
        '
        'cbAlcohol
        '
        Me.cbAlcohol.AutoSize = True
        Me.cbAlcohol.Location = New System.Drawing.Point(266, 19)
        Me.cbAlcohol.Name = "cbAlcohol"
        Me.cbAlcohol.Size = New System.Drawing.Size(61, 17)
        Me.cbAlcohol.TabIndex = 2
        Me.cbAlcohol.Text = "Alcohol"
        Me.cbAlcohol.UseVisualStyleBackColor = True
        '
        'cbSmoke
        '
        Me.cbSmoke.AutoSize = True
        Me.cbSmoke.Location = New System.Drawing.Point(137, 19)
        Me.cbSmoke.Name = "cbSmoke"
        Me.cbSmoke.Size = New System.Drawing.Size(59, 17)
        Me.cbSmoke.TabIndex = 1
        Me.cbSmoke.Text = "Smoke"
        Me.cbSmoke.UseVisualStyleBackColor = True
        '
        'cbExercise
        '
        Me.cbExercise.AutoSize = True
        Me.cbExercise.Location = New System.Drawing.Point(29, 19)
        Me.cbExercise.Name = "cbExercise"
        Me.cbExercise.Size = New System.Drawing.Size(66, 17)
        Me.cbExercise.TabIndex = 0
        Me.cbExercise.Text = "Exercise"
        Me.cbExercise.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtSymptoms)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtSurgeries)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtAllergies)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 226)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medical History"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(17, 21)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(375, 205)
        Me.txtReason.TabIndex = 22
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtReason)
        Me.GroupBox4.Location = New System.Drawing.Point(421, 119)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(405, 237)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reason for Appointment / Checkup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "IDNO :"
        '
        'txtDoctorId
        '
        Me.txtDoctorId.Enabled = False
        Me.txtDoctorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorId.Location = New System.Drawing.Point(76, 27)
        Me.txtDoctorId.Name = "txtDoctorId"
        Me.txtDoctorId.Size = New System.Drawing.Size(231, 26)
        Me.txtDoctorId.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "NAME :"
        '
        'txtDoctorName
        '
        Me.txtDoctorName.Enabled = False
        Me.txtDoctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorName.Location = New System.Drawing.Point(76, 59)
        Me.txtDoctorName.Name = "txtDoctorName"
        Me.txtDoctorName.Size = New System.Drawing.Size(316, 26)
        Me.txtDoctorName.TabIndex = 21
        '
        'btnBrowsedoctor
        '
        Me.btnBrowsedoctor.Location = New System.Drawing.Point(329, 27)
        Me.btnBrowsedoctor.Name = "btnBrowsedoctor"
        Me.btnBrowsedoctor.Size = New System.Drawing.Size(63, 24)
        Me.btnBrowsedoctor.TabIndex = 15
        Me.btnBrowsedoctor.Text = "Browse"
        Me.btnBrowsedoctor.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnBrowsedoctor)
        Me.GroupBox5.Controls.Add(Me.txtDoctorName)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtDoctorId)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(421, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(405, 104)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Doctor Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbEmployee)
        Me.GroupBox1.Controls.Add(Me.rbstudent)
        Me.GroupBox1.Controls.Add(Me.btnbrowse)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtIdno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 136)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient's Information"
        '
        'rbEmployee
        '
        Me.rbEmployee.AutoSize = True
        Me.rbEmployee.Location = New System.Drawing.Point(153, 29)
        Me.rbEmployee.Name = "rbEmployee"
        Me.rbEmployee.Size = New System.Drawing.Size(71, 17)
        Me.rbEmployee.TabIndex = 22
        Me.rbEmployee.TabStop = True
        Me.rbEmployee.Text = "Employee"
        Me.rbEmployee.UseVisualStyleBackColor = True
        '
        'rbstudent
        '
        Me.rbstudent.AutoSize = True
        Me.rbstudent.Location = New System.Drawing.Point(76, 29)
        Me.rbstudent.Name = "rbstudent"
        Me.rbstudent.Size = New System.Drawing.Size(62, 17)
        Me.rbstudent.TabIndex = 3
        Me.rbstudent.TabStop = True
        Me.rbstudent.Text = "Student"
        Me.rbstudent.UseVisualStyleBackColor = True
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(328, 64)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(63, 24)
        Me.btnbrowse.TabIndex = 15
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(76, 97)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(316, 26)
        Me.txtName.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "NAME :"
        '
        'txtIdno
        '
        Me.txtIdno.Enabled = False
        Me.txtIdno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdno.Location = New System.Drawing.Point(76, 65)
        Me.txtIdno.Name = "txtIdno"
        Me.txtIdno.Size = New System.Drawing.Size(231, 26)
        Me.txtIdno.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDNO :"
        '
        'frmDentalAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KCCCIMS.My.Resources.Resources.Untitled_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 402)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmDentalAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dental Appointment"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsedoctor As System.Windows.Forms.Button
    Friend WithEvents txtDoctorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDoctorId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSymptoms As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSurgeries As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAllergies As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents rbstudent As System.Windows.Forms.RadioButton
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIdno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbAlcohol As System.Windows.Forms.CheckBox
    Friend WithEvents cbSmoke As System.Windows.Forms.CheckBox
    Friend WithEvents cbExercise As System.Windows.Forms.CheckBox
End Class
