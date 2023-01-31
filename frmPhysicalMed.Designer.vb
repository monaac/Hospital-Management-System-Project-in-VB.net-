<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhysicalMed
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
        Me.dgvGivenMed = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbEmployee = New System.Windows.Forms.RadioButton
        Me.rbstudent = New System.Windows.Forms.RadioButton
        Me.btnbrowse = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtIdno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtReason = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblDate = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvGivenMed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGivenMed
        '
        Me.dgvGivenMed.AllowUserToAddRows = False
        Me.dgvGivenMed.AllowUserToDeleteRows = False
        Me.dgvGivenMed.AllowUserToOrderColumns = True
        Me.dgvGivenMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGivenMed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvGivenMed.Location = New System.Drawing.Point(15, 55)
        Me.dgvGivenMed.Name = "dgvGivenMed"
        Me.dgvGivenMed.RowHeadersVisible = False
        Me.dgvGivenMed.Size = New System.Drawing.Size(310, 246)
        Me.dgvGivenMed.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "M_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "QTY"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(688, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 136)
        Me.GroupBox1.TabIndex = 56
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtReason)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 154)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(405, 237)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reason for Medication"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.dgvGivenMed)
        Me.GroupBox2.Location = New System.Drawing.Point(427, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 314)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medicine Given"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 24)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Select"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.ForeColor = System.Drawing.Color.Blue
        Me.lblDate.Location = New System.Drawing.Point(439, 362)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 13)
        Me.lblDate.TabIndex = 66
        Me.lblDate.Text = "DATE"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.ForeColor = System.Drawing.Color.Blue
        Me.lbltime.Location = New System.Drawing.Point(439, 342)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(33, 13)
        Me.lbltime.TabIndex = 65
        Me.lbltime.Text = "TIME"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'frmPhysicalMed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.KCCCIMS.My.Resources.Resources.Untitled_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 406)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPhysicalMed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physical Medication"
        CType(Me.dgvGivenMed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvGivenMed As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents rbstudent As System.Windows.Forms.RadioButton
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIdno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
