Public Class frmCheckUpTeeth

    Dim OpenFileDialog1 As New OpenFileDialog



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
                   " `BLOOD`='" & txtblood.Text & "', `HEART` ='" & txtHearth.Text & "', `APPEARANCE` ='" & txtAppearance.Text & "'," & _
                   " `ABDOMINAL` ='" & txtAbdominal.Text & "' where `R_ID` =" & patienceid & "")
        MsgBox("Data Has been Save!")

        Me.Close()
        'SEL, `APPCATEGORY`, , `HEART`, `APPEARANCE`, `ABDOMINAL`, `HAIR`, `BLOODCOUNT`, `LIPID`, `CHEMISTRY`, `CHOLESTEROL`, `DIABETES`, `CHOLESSCREEN`, `TESTICULAR`, `PAPSMEAR`, `OSTEOPOROSIS`, `BREAST`, `PELVIC`, `MAMOGRAM`, `HEIGHT`, `WEIGTH`, `PULSE` FROM `tblrecords` WHERE 1

    End Sub

    Private Sub frmCheckUpTeeth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click


        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            filename = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        saveInsert("INSERT INTO `tbldentalxray` (`IDNO`, `XRAYNO`, `RECOMMENDATION`, `FILELOCATION`)" & _
                      " VALUES (" & txtIdno.Text & "," & txtXrayID.Text & ", '" & txtXrayRecom.Text & "', '" & filename & "')")

        MsgBox("The Data has been recorded!")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        findthis("SELECT * FROM `tbldentalxray` WHERE `XRAYNO`=" & txtXrayID.Text & " and `IDNO` =" & txtIdno.Text & "")
        LoadSingleData("LoadTeeth")

    End Sub
End Class