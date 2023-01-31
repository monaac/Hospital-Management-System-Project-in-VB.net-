Public Class frmCheckUp

   
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

        UpdateSave("Update `tblrecords` set `ALLERIGIES` = '" & txtAllergies.Text & "', `SURGERIES` ='" & txtSurgeries.Text & "'," & _
                   " `SYMPTOMS` ='" & txtSymptoms.Text & "', `EXERCISE` ='" & exercise & "', `SMOKE` ='" & smoke & "'," & _
                   " `ALCOHOL` ='" & alcohol & "', `REASONS` ='" & txtReason.Text & "', `PATIENTSTATUS` ='Checked'," & _
                   " `BLOOD` ='" & txtblood.Text & "', `HEART` ='" & txtheart.Text & "', `APPEARANCE` ='" & txtappearance.Text & "'," & _
                   " `ABDOMINAL` ='" & txtabdominal.Text & "', `HAIR` ='" & txthair.Text & "', `BLOODCOUNT` ='" & txtcount.Text & "'," & _
                   " `LIPID` ='" & txtlipid.Text & "', `CHEMISTRY` ='" & txtchemistry.Text & "', `CHOLESTEROL` ='" & txtcholesterol.Text & "'," & _
                   " `DIABETES` ='" & txtdiabetes.Text & "', `CHOLESSCREEN` ='" & txtcholesterolscreen.Text & "'," & _
                   " `TESTICULAR` ='" & txttetiscular.Text & "', `PAPSMEAR` ='" & txtpapsmear.Text & "', `OSTEOPOROSIS` ='" & txtOsteoporosis.Text & "'," & _
                   " `BREAST` ='" & txtbreast.Text & "', `PELVIC` ='" & txtpelvic.Text & "', `MAMOGRAM` ='" & txtmamogram.Text & "'," & _
                   " `HEIGHT` ='" & txtheight.Text & "', `WEIGTH` ='" & txtweigth.Text & "', `PULSE` ='" & txtpulse.Text & "' where `R_ID` =" & patienceid & "")
        MsgBox("Data has been save!")
        Me.Close()


    End Sub

    Private Sub frmCheckUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class