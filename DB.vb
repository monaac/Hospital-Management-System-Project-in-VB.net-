Imports MySql.Data.MySqlClient

Module DB

    Dim MysqlConn As New MySqlConnection
    Public con As MySqlConnection = myconn()

    Dim cmd As New MySqlCommand
    Dim result As Integer

    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dReader As MySqlDataReader

    Public myWhat As String

    Public idno As Integer
    Public dname As String
    Public usertype As String

    Public APPCATEGORY As String

    Public patienceid As Integer

    Public subtractmedicine As Integer

    Public givenmedicine As Integer
    Public gmedquantity As Integer

    Public meddate As String
    Public medtime As String

    Public filename As String

    Public Function myconn() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password='';database=kcccims")
    End Function

    Public Sub findthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally

            da.Dispose()
            con.Close()

        End Try

    End Sub

    Public Sub LoadData(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()

            Select Case param

                Case "SelectMed"
                    Do While dReader.Read = True
                        obj.Rows.Add(False, dReader(0), dReader(1), "")
                    Loop


                Case "LoadEquipment"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(3), dReader(4), dReader(5))
                    Loop

                Case "LoadMedicine"

                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(6), dReader(7), dReader(3))
                    Loop

                Case "LoadEmployee"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2))
                    Loop
                Case "LoadStudent"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2))
                    Loop

                Case "LoadDoctor"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1))
                    Loop
                Case "LoadMedicine"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop
                Case "LoadEquipment"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3))
                    Loop

                Case "LoadUsers"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2))
                    Loop

                Case "LoadAppointments"
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2))
                    Loop



            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Public Function saveInsert(ByVal sql As String) As Boolean

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try

    End Function

    Public Function UpdateSave(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    Return False
                Else
                    Return True

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try

    End Function

    Public Sub CheckResult(ByVal CaseResult As String)
        Dim table As New DataTable
        Try

            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then
                Select Case CaseResult

                    Case "SubtractMedicine"
                        subtractmedicine = table.Rows(0).Item(0) - gmedquantity


                        UpdateSave("Update `tblmedicine` set `MEDQUANTITY` = " & subtractmedicine & " where `MED_ID` =" & givenmedicine & "")


                    Case "Login"
                        If table.Rows(0).Item(0) = "Physical Doctor" Then

                            usertype = table.Rows(0).Item(0)

                            With Form1
                                .tsPhysical.Enabled = True
                                .tsLogin.Text = "Logout"
                            End With


                            'idno = table.Rows(0).Item(1)
                            'dname = table.Rows(0).Item(2)
                            LoginForm1.Close()

                        ElseIf table.Rows(0).Item(0) = "Dental Doctor" Then

                            usertype = table.Rows(0).Item(0)

                            With Form1
                                .tsDental.Enabled = True
                                .tsLogin.Text = "Logout"
                            End With


                            'idno = table.Rows(0).Item(1)
                            'dname = table.Rows(0).Item(2)
                            LoginForm1.Close()


                        ElseIf table.Rows(0).Item(0) = "Nurse" Then

                            usertype = table.Rows(0).Item(0)

                            With Form1
                                .tsList.Enabled = True
                                .tsConsultation.Enabled = True
                                .tsLogin.Text = "Logout"
                                .tsReports.Enabled = True
                            End With
                            LoginForm1.Close()

                        ElseIf table.Rows(0).Item(0) = "Administrator" Then

                            With Form1
                                .tsList.Enabled = True
                                .tsConsultation.Enabled = True
                                .tsPhysical.Enabled = True
                                .tsDental.Enabled = True
                                .tsSetting.Enabled = True
                                .tsReports.Enabled = True
                                .tsLogin.Text = "Logout"
                            End With
                            LoginForm1.Close()

                        End If





                End Select
            Else
                Select Case CaseResult

                    Case "Login"
                        MsgBox("Contact Administrator.")




                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub fillcombo(ByVal combo As Object, ByVal member As String, ByVal idparam As String)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            With combo
                .DataSource = publictable
                .displaymember = member
                .valuemember = idparam
                .SelectedIndex = -1
            End With

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub LoadSingleData(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()

            Select Case param

                Case "LoadTeeth"
                    Do While dReader.Read = True
                        With frmCheckUpTeeth
                            '.txtXrayRecom.Text = dReader("RECOMMENDATION")
                            .PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pictures\" & dReader("FILELOCATION"))
                            ''PictureBox1.Image = Image.FromFile(FILELOCATION)

                        End With
                    Loop

                Case "Appointments"
                    Do While dReader.Read = True
                        With frmCheckUp

                            patienceid = dReader("R_ID")

                            .txtIdno.Text = dReader("IDNO")
                            .txtName.Text = dReader("PATIENTNAME")
                            .txtAllergies.Text = dReader("ALLERIGIES")
                            .txtSurgeries.Text = dReader("SURGERIES")
                            .txtSymptoms.Text = dReader("SYMPTOMS")

                            If dReader("EXERCISE") = "Yes" Then
                                .cbExercise.Checked = True
                            End If

                            If dReader("SMOKE") = "Yes" Then
                                .cbSmoke.Checked = True
                            End If

                            If dReader("ALCOHOL") = "Yes" Then
                                .cbAlcohol.Checked = True
                            End If

                            .txtReason.Text = dReader("REASONS")

                            .Show()
                        End With
                    Loop


                Case "AppointmentsDental"
                    Do While dReader.Read = True
                        With frmCheckUpTeeth

                            patienceid = dReader("R_ID")

                            .txtIdno.Text = dReader("IDNO")
                            .txtName.Text = dReader("PATIENTNAME")
                            .txtAllergies.Text = dReader("ALLERIGIES")
                            .txtSurgeries.Text = dReader("SURGERIES")
                            .txtSymptoms.Text = dReader("SYMPTOMS")

                            If dReader("EXERCISE") = "Yes" Then
                                .cbExercise.Checked = True
                            End If

                            If dReader("SMOKE") = "Yes" Then
                                .cbSmoke.Checked = True
                            End If

                            If dReader("ALCOHOL") = "Yes" Then
                                .cbAlcohol.Checked = True
                            End If

                            .txtReason.Text = dReader("REASONS")

                            .Show()
                        End With
                    Loop


            End Select

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub

    Public Sub reporttbs(ByVal RpTsql As String, ByVal rptname As String)
        dt = New DataTable
        Try
            myconn.Open()
            cmd.Connection = myconn()
            cmd.CommandText = RpTsql
            da.SelectCommand = cmd
            da.Fill(dt)

            Dim reportpath As String = Application.StartupPath & "\reports\" & rptname & ".rpt"
            If Not IO.File.Exists(reportpath) Then
                MsgBox("Unable to locate file")
            End If
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            reportdoc.Load(reportpath)
            reportdoc.SetDataSource(dt)

            With Form2
                .CrystalReportViewer1.ReportSource = reportdoc
                .Show()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            myconn.Close()

        End Try


    End Sub


End Module
