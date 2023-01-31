Public Class frmPhysicalAppointment

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click

        If rbstudent.Checked = True Then
            frmStudent.Show()
        ElseIf rbEmployee.Checked = True Then
            frmEmployee.Show()
        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnBrowsedoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsedoctor.Click

        frmDoctor.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim exercise, smoke, alcohol As String

        If cbExercise.Checked = True Then
            exercise = "Yes"
        Else
            exercise = "No"
        End If

        If cbSmoke.Checked = True Then
            smoke = "Yes"
        Else
            smoke = "No"
        End If

        If cbAlcohol.Checked = True Then
            alcohol = "Yes"
        Else
            alcohol = "No"
        End If

        saveInsert("INSERT INTO `tblrecords` (`IDNO`, `PATIENTNAME`, `ALLERIGIES`, `SURGERIES`, `SYMPTOMS`, `EXERCISE`, `SMOKE`, `ALCOHOL`, `REASONS`, `DOCTORID`, `DOCTORNAME`, `PATIENTSTATUS`, `APPCATEGORY`)" & _
                      " VALUES (" & txtIdno.Text & ",'" & txtName.Text & "', '" & txtAllergies.Text & "', '" & txtSurgeries.Text & "','" & txtSymptoms.Text & "','" & exercise & "','" & smoke & "','" & alcohol & "','" & txtReason.Text & "'," & txtDoctorId.Text & ",'" & txtDoctorName.Text & "','Appointment','" & APPCATEGORY & "')")

        Me.Close()
    End Sub

  
End Class