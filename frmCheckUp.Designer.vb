<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckUp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtIdno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtheart = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtblood = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txthair = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtabdominal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtappearance = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtcholesterol = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtchemistry = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtlipid = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcount = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtmamogram = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtpelvic = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtbreast = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtOsteoporosis = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtpapsmear = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txttetiscular = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtcholesterolscreen = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtdiabetes = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txtpulse = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtweigth = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtheight = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(1060, 509)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 24)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(989, 509)
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
        Me.GroupBox2.Location = New System.Drawing.Point(9, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 226)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medical History"
        '
        'txtReason
        '
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(17, 19)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(375, 153)
        Me.txtReason.TabIndex = 22
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtReason)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 351)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(405, 182)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reason for Appointment / Checkup"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtIdno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 104)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient's Information"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(73, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(316, 26)
        Me.txtName.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "NAME :"
        '
        'txtIdno
        '
        Me.txtIdno.Enabled = False
        Me.txtIdno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdno.Location = New System.Drawing.Point(73, 30)
        Me.txtIdno.Name = "txtIdno"
        Me.txtIdno.Size = New System.Drawing.Size(316, 26)
        Me.txtIdno.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDNO :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtheart)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtblood)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(421, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(352, 119)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vital Sign Checks"
        '
        'txtheart
        '
        Me.txtheart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtheart.Location = New System.Drawing.Point(22, 87)
        Me.txtheart.Name = "txtheart"
        Me.txtheart.Size = New System.Drawing.Size(316, 26)
        Me.txtheart.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Checking Heart/Respiratory Rate :"
        '
        'txtblood
        '
        Me.txtblood.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtblood.Location = New System.Drawing.Point(22, 42)
        Me.txtblood.Name = "txtblood"
        Me.txtblood.Size = New System.Drawing.Size(316, 26)
        Me.txtblood.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Blood Pressure Reading :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txthair)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txtabdominal)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtappearance)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Location = New System.Drawing.Point(421, 133)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(352, 171)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Visual Exam :"
        '
        'txthair
        '
        Me.txthair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthair.Location = New System.Drawing.Point(22, 136)
        Me.txthair.Name = "txthair"
        Me.txthair.Size = New System.Drawing.Size(316, 26)
        Me.txthair.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Hair / Nail / Limbs :"
        '
        'txtabdominal
        '
        Me.txtabdominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtabdominal.Location = New System.Drawing.Point(22, 90)
        Me.txtabdominal.Name = "txtabdominal"
        Me.txtabdominal.Size = New System.Drawing.Size(316, 26)
        Me.txtabdominal.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Head / Neck / Abdominal Area :"
        '
        'txtappearance
        '
        Me.txtappearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtappearance.Location = New System.Drawing.Point(22, 43)
        Me.txtappearance.Name = "txtappearance"
        Me.txtappearance.Size = New System.Drawing.Size(316, 26)
        Me.txtappearance.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Patient's Appearance :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtcholesterol)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.txtchemistry)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.txtlipid)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.txtcount)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Location = New System.Drawing.Point(421, 310)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(352, 223)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Laboratory :"
        '
        'txtcholesterol
        '
        Me.txtcholesterol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcholesterol.Location = New System.Drawing.Point(22, 183)
        Me.txtcholesterol.Name = "txtcholesterol"
        Me.txtcholesterol.Size = New System.Drawing.Size(316, 26)
        Me.txtcholesterol.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Cholesterol Test :"
        '
        'txtchemistry
        '
        Me.txtchemistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchemistry.Location = New System.Drawing.Point(22, 133)
        Me.txtchemistry.Name = "txtchemistry"
        Me.txtchemistry.Size = New System.Drawing.Size(316, 26)
        Me.txtchemistry.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Chemistry Panel :"
        '
        'txtlipid
        '
        Me.txtlipid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlipid.Location = New System.Drawing.Point(22, 87)
        Me.txtlipid.Name = "txtlipid"
        Me.txtlipid.Size = New System.Drawing.Size(316, 26)
        Me.txtlipid.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Lipid Panel :"
        '
        'txtcount
        '
        Me.txtcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcount.Location = New System.Drawing.Point(22, 40)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.Size = New System.Drawing.Size(316, 26)
        Me.txtcount.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Blood Count :"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.txtmamogram)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.txtpelvic)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.txtbreast)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.txtOsteoporosis)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.txtpapsmear)
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Controls.Add(Me.txttetiscular)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.txtcholesterolscreen)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.txtdiabetes)
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Location = New System.Drawing.Point(779, 10)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(352, 413)
        Me.GroupBox8.TabIndex = 23
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Screening Test"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(31, 405)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 13)
        Me.Label21.TabIndex = 34
        '
        'txtmamogram
        '
        Me.txtmamogram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamogram.Location = New System.Drawing.Point(26, 375)
        Me.txtmamogram.Name = "txtmamogram"
        Me.txtmamogram.Size = New System.Drawing.Size(316, 26)
        Me.txtmamogram.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(30, 358)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Mammogram :"
        '
        'txtpelvic
        '
        Me.txtpelvic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpelvic.Location = New System.Drawing.Point(26, 330)
        Me.txtpelvic.Name = "txtpelvic"
        Me.txtpelvic.Size = New System.Drawing.Size(316, 26)
        Me.txtpelvic.TabIndex = 31
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(29, 310)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "Pelvic Exam :"
        '
        'txtbreast
        '
        Me.txtbreast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbreast.Location = New System.Drawing.Point(26, 277)
        Me.txtbreast.Name = "txtbreast"
        Me.txtbreast.Size = New System.Drawing.Size(316, 26)
        Me.txtbreast.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 260)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Breast Exam :"
        '
        'txtOsteoporosis
        '
        Me.txtOsteoporosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOsteoporosis.Location = New System.Drawing.Point(25, 230)
        Me.txtOsteoporosis.Name = "txtOsteoporosis"
        Me.txtOsteoporosis.Size = New System.Drawing.Size(316, 26)
        Me.txtOsteoporosis.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(29, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Osteoporosis :"
        '
        'txtpapsmear
        '
        Me.txtpapsmear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpapsmear.Location = New System.Drawing.Point(25, 185)
        Me.txtpapsmear.Name = "txtpapsmear"
        Me.txtpapsmear.Size = New System.Drawing.Size(316, 26)
        Me.txtpapsmear.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 165)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Pap Smear :"
        '
        'txttetiscular
        '
        Me.txttetiscular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttetiscular.Location = New System.Drawing.Point(23, 134)
        Me.txttetiscular.Name = "txttetiscular"
        Me.txttetiscular.Size = New System.Drawing.Size(316, 26)
        Me.txttetiscular.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Testicular Exam :"
        '
        'txtcholesterolscreen
        '
        Me.txtcholesterolscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcholesterolscreen.Location = New System.Drawing.Point(22, 87)
        Me.txtcholesterolscreen.Name = "txtcholesterolscreen"
        Me.txtcholesterolscreen.Size = New System.Drawing.Size(316, 26)
        Me.txtcholesterolscreen.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Cholesterol :"
        '
        'txtdiabetes
        '
        Me.txtdiabetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiabetes.Location = New System.Drawing.Point(22, 42)
        Me.txtdiabetes.Name = "txtdiabetes"
        Me.txtdiabetes.Size = New System.Drawing.Size(316, 26)
        Me.txtdiabetes.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Diabetes :"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtpulse)
        Me.GroupBox9.Controls.Add(Me.Label26)
        Me.GroupBox9.Controls.Add(Me.txtweigth)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.Controls.Add(Me.txtheight)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Location = New System.Drawing.Point(782, 427)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(349, 72)
        Me.GroupBox9.TabIndex = 22
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Others"
        '
        'txtpulse
        '
        Me.txtpulse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpulse.Location = New System.Drawing.Point(280, 21)
        Me.txtpulse.Name = "txtpulse"
        Me.txtpulse.Size = New System.Drawing.Size(56, 26)
        Me.txtpulse.TabIndex = 23
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(231, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 13)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Pulse :"
        '
        'txtweigth
        '
        Me.txtweigth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtweigth.Location = New System.Drawing.Point(171, 23)
        Me.txtweigth.Name = "txtweigth"
        Me.txtweigth.Size = New System.Drawing.Size(54, 26)
        Me.txtweigth.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(118, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 13)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Weigth :"
        '
        'txtheight
        '
        Me.txtheight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtheight.Location = New System.Drawing.Point(65, 23)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(47, 26)
        Me.txtheight.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Heigth :"
        '
        'frmCheckUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KCCCIMS.My.Resources.Resources.Untitled_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1139, 547)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmCheckUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physical Appointment"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
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
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIdno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbAlcohol As System.Windows.Forms.CheckBox
    Friend WithEvents cbSmoke As System.Windows.Forms.CheckBox
    Friend WithEvents cbExercise As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtheart As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtblood As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcholesterol As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtchemistry As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtlipid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txthair As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtabdominal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtappearance As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbreast As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtOsteoporosis As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtpapsmear As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txttetiscular As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcholesterolscreen As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtdiabetes As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtmamogram As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtpelvic As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtweigth As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtheight As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtpulse As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
End Class
