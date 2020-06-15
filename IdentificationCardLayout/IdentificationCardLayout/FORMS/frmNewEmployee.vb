'RON
'Created by: RON CONDE

Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmNewEmployee
    Dim gc As New GlobalClasses
    Dim c As New AppConfiguration
    Dim cs = c.cnstring

    'Declarations
    Dim PersonalInfo As Boolean = True
    Dim EmploymentStatus As Boolean = False
    Dim BenefitsNumbers As Boolean = False
    Dim EmergencyContact As Boolean = False
    Dim ReviewInformation As Boolean = False

    Dim haveEmptyText As Boolean
    Public EditMode_EmployeeInfo As Boolean = False
    Public Current_EmployeeID As String

#Region "Functions"
    Public Sub UploadPhoto()
        Dim ofdBrowsePhoto As New OpenFileDialog

        Try
            With ofdBrowsePhoto
                .Filter = ("Picture Files (*)|*.bmp;*.gif;*.jpg;*.png")
            End With
            ofdBrowsePhoto.FileName = ""
            If ofdBrowsePhoto.ShowDialog = Windows.Forms.DialogResult.OK Then
                picEmployeeProfilePicture.Image = Image.FromFile(ofdBrowsePhoto.FileName)
            End If
        Catch ex As Exception
            MsgBox("Cannot the open File", MsgBoxStyle.Exclamation, "Upload Photo")
        End Try
    End Sub

    Private Sub Check_isEmptyText(ByVal Input As String)
        Select Case Input
            Case "Personal Info"
                haveEmptyText = True
                If txtLastName.TextLength <= 0 Then
                    MsgBox("Employee Last Name is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtLastName.Focus()
                ElseIf txtFirstName.TextLength <= 0 Then
                    MsgBox("Employee First Name is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtFirstName.Focus()
                ElseIf txtAge.TextLength <= 0 Then
                    MsgBox("Employee Age is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtAge.Focus()
                ElseIf cboCivilStatus.SelectedItem Is Nothing Then
                    MsgBox("Employee Civil Status is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    cboCivilStatus.Focus()
                ElseIf rbGenderMale.Checked = False And rbGenderFemale.Checked = False Then
                    MsgBox("Employee Gender is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                ElseIf txtEmployeeContactNumber.TextLength <= 0 Then
                    MsgBox("Employee Contact Number is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtEmployeeContactNumber.Focus()
                ElseIf txtEmployeeAddress.TextLength <= 0 Then
                    MsgBox("Employee Address is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtEmployeeAddress.Focus()
                Else
                    haveEmptyText = False
                End If

            Case "Employment Status"
                haveEmptyText = True
                If txtEmployeeIDNumber.TextLength <= 0 Then
                    MsgBox("Employee ID Number is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtEmployeeIDNumber.Focus()
                ElseIf cboEmplymentType.SelectedItem Is Nothing Then
                    MsgBox("Employee Employment Type is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    cboEmplymentType.Focus()
                ElseIf cboEmploymentStatus.SelectedItem Is Nothing Then
                    MsgBox("Employee Employment Status is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    cboEmploymentStatus.Focus()
                ElseIf txtSalaryRate.TextLength <= 0 Then
                    MsgBox("Employee Job Rate is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtSalaryRate.Focus()
                ElseIf cboJobPosition.SelectedItem Is Nothing Then
                    MsgBox("Employee Job Position is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    cboJobPosition.Focus()
                Else
                    haveEmptyText = False
                End If

            Case "Benefits Numbers"
                haveEmptyText = True
                If txtPhilHealthNumber.TextLength <= 0 Then
                    MsgBox("Employee PhilHealth Number is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtPhilHealthNumber.Focus()
                ElseIf txtPagibigNumber.TextLength <= 0 Then
                    MsgBox("Employee PAGIBIG Number is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtPagibigNumber.Focus()
                ElseIf txtSSSNumber.TextLength <= 0 Then
                    MsgBox("Employee SSS Number is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtSSSNumber.Focus()
                ElseIf txtTINNumber.TextLength <= 0 Then
                    MsgBox("Employee TIN Number is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtTINNumber.Focus()
                Else
                    haveEmptyText = False
                End If

            Case "Emergency Contact"
                haveEmptyText = True
                If txtEContact_Name.TextLength <= 0 Then
                    MsgBox("Employee Emergency Contact Name is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtEContact_Name.Focus()
                ElseIf txtEContact_Relationship.TextLength <= 0 Then
                    MsgBox("Employee Emergency Contact Relationship is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtEContact_Relationship.Focus()
                ElseIf txtEContactNumber.TextLength <= 0 Then
                    MsgBox("Employee Emergency Contact Number is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtEContactNumber.Focus()
                ElseIf txtEContact_Address.TextLength <= 0 Then
                    MsgBox("Employee Emergency Contact Address is required!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    txtEContact_Address.Focus()
                Else
                    haveEmptyText = False
                End If
        End Select
    End Sub

    Private Sub Edit_EmployeeInfo(ByVal edit As String)
        pnlReviewInformation.Visible = False
        btnNext.Text = "Next"

        Select Case edit
            Case "Personal Info"
                pnlPersonalInformation.Visible = True
                PersonalInfo = True
            Case "Employment Status"
                pnlEmploymentStatus.Visible = True
                EmploymentStatus = True
                btnBack.Visible = True
            Case "Benefits Numbers"
                pnlBenefitsNumbers.Visible = True
                BenefitsNumbers = True
                btnBack.Visible = True
            Case "Emergency Contact"
                pnlEmergencyContact.Visible = True
                EmergencyContact = True
                btnBack.Visible = True
        End Select
    End Sub

    Private Sub ForwardForReview_Info(ByVal Input As String)
        Select Case Input
            Case "Personal Info"
                lblLastName.Text = txtLastName.Text
                lblFirstName.Text = txtFirstName.Text
                lblMiddleName.Text = txtMiddleName.Text
                lblBirthDate.Text = Format(dtpBirthdate.Value, "MMMM dd, yyyy")
                lblEmployeeAge.Text = txtAge.Text
                lblCivilStatus.Text = cboCivilStatus.SelectedValue.ToString
                'Gender
                If rbGenderMale.Checked = True Then
                    lblGender.Text = "Male"
                Else
                    lblGender.Text = "Female"
                End If
                lblContactNumber.Text = txtEmployeeContactNumber.Text
                lblEmployeeAddress.Text = txtEmployeeAddress.Text
            Case "Employment Status"
                lblEmployeeIDNumber.Text = txtEmployeeIDNumber.Text
                lblEmploymentType.Text = cboEmplymentType.SelectedValue.ToString
                lblEMploymentStatus.Text = cboEmploymentStatus.SelectedValue.ToString
                lblSalaryRate.Text = txtSalaryRate.Text
                lblDateHired.Text = Format(dtpDateHired.Value, "MMMM dd, yyyy")
                lblContractEnd.Text = Format(dtpContractEnd.Value, "MMMM dd, yyyy")
                lblJobPosition.Text = cboJobPosition.SelectedValue.ToString
            Case "Benefits Numbers"
                lblPhilHealthNumber.Text = txtPhilHealthNumber.Text
                lblPagibigNumber.Text = txtPagibigNumber.Text
                lblSSSNumber.Text = txtSSSNumber.Text
                lblTINNumber.Text = txtTINNumber.Text
            Case "Emergency Contact"
                lblEContact_Name.Text = txtEContact_Name.Text
                lblEContact_Relationship.Text = txtEContact_Relationship.Text
                lblEContact_Number.Text = txtEContactNumber.Text
                lblEContact_Address.Text = txtEContact_Address.Text
        End Select
    End Sub

    'Public Sub Fill_CivilStatus()
    '    Try
    '        Dim ds As DataSet
    '        ds = SqlHelper.ExecuteDataset(cs, CommandType.StoredProcedure, "spu_Employee_CivilStatusList")

    '        With cboCivilStatus
    '            .ValueMember = "CivilStatusID"
    '            .DisplayMember = "CivilStatusDescription"
    '            .DataSource = ds.Tables(0)
    '            .SelectedItem = Nothing
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    '    End Try
    'End Sub

    'Public Sub Fill_EmploymentType()
    '    Try
    '        Dim ds As DataSet
    '        ds = SqlHelper.ExecuteDataset(cs, CommandType.StoredProcedure, "spu_Employee_TypesOfEmploymentList")

    '        With cboEmplymentType
    '            .ValueMember = "EmploymentTypeID"
    '            .DisplayMember = "EmploymentTypeDescription"
    '            .DataSource = ds.Tables(0)
    '            .SelectedItem = Nothing
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    '    End Try
    'End Sub

    'Public Sub Fill_EmploymentStatus()
    '    Try
    '        Dim ds As DataSet
    '        ds = SqlHelper.ExecuteDataset(cs, CommandType.StoredProcedure, "spu_Employee_TypesOfEmploymentStatusList")

    '        With cboEmploymentStatus
    '            .ValueMember = "EmploymentStatusID"
    '            .DisplayMember = "EmploymentStatusDescription"
    '            .DataSource = ds.Tables(0)
    '            .SelectedItem = Nothing
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    '    End Try
    'End Sub

    'Public Sub Create_JobPosition()
    '    Try
    '        Dim ds As DataSet
    '        ds = SqlHelper.ExecuteDataset(cs, CommandType.StoredProcedure, "spu_Employee_TypesOfJobPosition")

    '        With cboJobPosition
    '            .ValueMember = "EmployeeJobPositionID"
    '            .DisplayMember = "EmployeeJobPositionDescription"
    '            .DataSource = ds.Tables(0)
    '            .SelectedItem = Nothing
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    '    End Try
    'End Sub

    Private Sub Save_NewEmployeeInformation()
        Try
            Dim EmployeeGender As Integer
            If rbGenderMale.Checked = True Then
                EmployeeGender = 0
            ElseIf rbGenderFemale.Checked = True Then
                EmployeeGender = 1
            End If

            'Account Image
            Dim mstream As New System.IO.MemoryStream
            picEmployeeProfilePicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer
            mstream.Close()

            SqlHelper.ExecuteNonQuery(cs, CommandType.StoredProcedure, "spu_EmployeeMasterlist_AddUpdate",
                                      New SqlParameter("@fcEmployeeID", txtEmployeeIDNumber.Text),
                                      New SqlParameter("@fcLastName", txtLastName.Text),
                                      New SqlParameter("@fcFirstName", txtFirstName.Text),
                                      New SqlParameter("@fcMiddleName", txtMiddleName.Text),
                                      New SqlParameter("@fcBirthDate", Format(dtpBirthdate.Value, "MMMM dd, yyyy")),
                                      New SqlParameter("@fcAge", txtAge.Text),
                                      New SqlParameter("@fcCivilStatus", cboCivilStatus.SelectedValue),
                                      New SqlParameter("@fcContactNumber", txtEmployeeContactNumber.Text),
                                      New SqlParameter("@fcGender", EmployeeGender),
                                      New SqlParameter("@fcEmployeeAddress", txtEmployeeAddress.Text),
                                      New SqlParameter("@fcEmployeeProfilePicture", arrImage),
                                      New SqlParameter("@fcEmploymentType", cboEmplymentType.SelectedValue),
                                      New SqlParameter("@fcEmploymentStatus", cboEmploymentStatus.SelectedValue),
                                      New SqlParameter("@fcSalaryRate", txtSalaryRate.Text),
                                      New SqlParameter("@fcDateHired", Format(dtpDateHired.Value, "MMMM dd, yyyy")),
                                      New SqlParameter("@fcContractEnd", Format(dtpContractEnd.Value, "MMMM dd, yyyy")),
                                      New SqlParameter("@fcJobPosition", cboJobPosition.SelectedValue),
                                      New SqlParameter("@fcPhilHealth", txtPhilHealthNumber.Text),
                                      New SqlParameter("@fcPAGIBIG", txtPagibigNumber.Text),
                                      New SqlParameter("@fcSSS", txtSSSNumber.Text),
                                      New SqlParameter("@fcTIN", txtTINNumber.Text),
                                      New SqlParameter("@fcEmergency_ContactName", txtEContact_Name.Text),
                                      New SqlParameter("@fcEmergency_Relationship", txtEContact_Relationship.Text),
                                      New SqlParameter("@fcEmergency_ContactNumber", txtEContactNumber.Text),
                                      New SqlParameter("@fcEmergency_ContactAddress", txtEContact_Address.Text))

            MsgBox("Save success", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    'Private Sub Fill_ComboBox(ByVal WhatComboBox As ComboBox,
    '                          ByVal StoredProcedureInput As String,
    '                          ByVal ValueMemberInput As String,
    '                          ByVal DisplayMemberInput As String)
    '    Try
    '        Dim ds As DataSet
    '        ds = SqlHelper.ExecuteDataset(cs, CommandType.StoredProcedure, StoredProcedureInput)

    '        With WhatComboBox
    '            .ValueMember = ValueMemberInput
    '            .DisplayMember = DisplayMemberInput
    '            .DataSource = ds.Tables(0)
    '            .SelectedItem = Nothing
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
    '    End Try
    'End Sub

    Private Sub FillEmployeeInfor_EditMode(ByVal EmployeeID As String)
        Try
            Dim dr As SqlDataReader
            dr = SqlHelper.ExecuteReader(cs, CommandType.StoredProcedure, "spu_GetEmployeeInformation",
                                         New SqlParameter("@fcEmployeeID", EmployeeID))
            If dr.HasRows Then
                While dr.Read
                    With dr
                        txtLastName.Text = StrConv(.Item("LastName"), VbStrConv.ProperCase)
                        txtFirstName.Text = StrConv(.Item("FirstName"), VbStrConv.ProperCase)
                        txtMiddleName.Text = StrConv(.Item("MiddleName"), VbStrConv.ProperCase)
                        dtpBirthdate.Value = .Item("BirthDate")
                        txtAge.Text = .Item("Age")

                        Dim EmpGender As String = .Item("Gender")
                        If EmpGender = "Male" Then
                            rbGenderMale.Checked = True
                        Else
                            rbGenderFemale.Checked = True
                        End If

                        Dim cvlsts As String = .Item("CivilStatus")
                        If cvlsts = "Single" Then
                            cboCivilStatus.SelectedValue = "001"
                        ElseIf cvlsts = "Married" Then
                            cboCivilStatus.SelectedValue = "002"
                        ElseIf cvlsts = "Devorsed" Then
                            cboCivilStatus.SelectedValue = "003"
                        End If

                        txtEmployeeContactNumber.Text = .Item("ContactNumber")
                        txtEmployeeAddress.Text = .Item("EmployeeAddress")

                        If Not String.IsNullOrEmpty(dr.Item("EmployeeProfilePic").ToString.Trim) Then
                            Dim bytes As Byte() = dr.Item("EmployeeProfilePic")
                            Dim mstream As New MemoryStream(bytes)
                            picEmployeeProfilePicture.Image = Image.FromStream(mstream)
                            picEmployeeProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
                        Else
                            picEmployeeProfilePicture.Image = Nothing
                        End If

                        txtEmployeeIDNumber.Text = .Item("EmployeeID")
                        Dim emptype As String = .Item("EmploymentType")
                        If emptype = "Regular" Then
                            cboEmplymentType.SelectedValue = "001"
                        ElseIf emptype = "Contract" Then
                            cboEmplymentType.SelectedValue = "002"
                        ElseIf emptype = "Provisional" Then
                            cboEmplymentType.SelectedValue = "003"
                        End If

                        Dim empsts As String = .Item("EmploymentStatus")
                        If empsts = "Active" Then
                            cboEmploymentStatus.SelectedValue = "001"
                        ElseIf empsts = "Resigned" Then
                            cboEmploymentStatus.SelectedValue = "002"
                        ElseIf empsts = "Suspended" Then
                            cboEmploymentStatus.SelectedValue = "003"
                        ElseIf empsts = "On Vacation" Then
                            cboEmploymentStatus.SelectedValue = "004"
                        End If

                        txtSalaryRate.Text = .Item("SalaryRate")
                        dtpDateHired.Value = .Item("DateHired")
                        dtpContractEnd.Value = .Item("ContractEnd")

                        Dim jbpos As String = .Item("JobPosition")
                        If jbpos = "IT Manager" Then
                            cboJobPosition.SelectedValue = "001"
                        ElseIf jbpos = "CEO" Then
                            cboJobPosition.SelectedValue = "002"
                        ElseIf jbpos = "Admin" Then
                            cboJobPosition.SelectedValue = "003"
                        End If

                        txtPhilHealthNumber.Text = .Item("PhilHealth")
                        txtPagibigNumber.Text = .Item("PAGIBIG")
                        txtSSSNumber.Text = .Item("SSS")
                        txtTINNumber.Text = .Item("TIN")

                        txtEContact_Name.Text = .Item("ContactName")
                        txtEContact_Address.Text = .Item("ContactAddress")
                        txtEContact_Relationship.Text = .Item("Relationship")
                        txtEContactNumber.Text = .Item("ContactNumber")
                    End With
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub BackToDefault()
        txtLastName.Text = Nothing
        txtFirstName.Text = Nothing
        txtMiddleName.Text = Nothing
        dtpBirthdate.Value = Today.Date
        txtAge.Text = Nothing
        cboCivilStatus.SelectedItem = Nothing
        rbGenderMale.Checked = False
        rbGenderFemale.Checked = False
        picEmployeeProfilePicture.Image = Nothing
        txtEmployeeContactNumber.Text = Nothing
        txtEmployeeAddress.Text = Nothing

        txtEmployeeIDNumber.Text = Nothing
        cboEmploymentStatus.SelectedItem = Nothing
        cboEmplymentType.SelectedItem = Nothing
        txtSalaryRate.Text = Nothing
        dtpDateHired.Value = Today.Date
        dtpContractEnd.Value = Today.Date
        cboJobPosition.Text = Nothing

        txtPhilHealthNumber.Text = Nothing
        txtPagibigNumber.Text = Nothing
        txtSSSNumber.Text = Nothing
        txtTINNumber.Text = Nothing

        txtEContact_Name.Text = Nothing
        txtEContact_Relationship.Text = Nothing
        txtEContactNumber.Text = Nothing
        txtEContact_Address.Text = Nothing

        pnlReviewInformation.Visible = False
        pnlPersonalInformation.Visible = True
        btnNext.Text = "Next"

        'Review information labels
        lblLastName.Text = Nothing
        lblFirstName.Text = Nothing
        lblMiddleName.Text = Nothing
        lblBirthDate.Text = Nothing
        lblEmployeeAge.Text = Nothing
        lblCivilStatus.Text = Nothing
        lblGender.Text = Nothing
        lblContactNumber.Text = Nothing
        lblEmployeeAddress.Text = Nothing

        lblEmployeeIDNumber.Text = Nothing
        lblEmploymentType.Text = Nothing
        lblEMploymentStatus.Text = Nothing
        lblSalaryRate.Text = Nothing
        lblDateHired.Text = Nothing
        lblContractEnd.Text = Nothing
        lblJobPosition.Text = Nothing

        lblPhilHealthNumber.Text = Nothing
        lblPagibigNumber.Text = Nothing
        lblSSSNumber.Text = Nothing
        lblTINNumber.Text = Nothing

        lblEContact_Name.Text = Nothing
        lblEContact_Relationship.Text = Nothing
        lblEContact_Number.Text = Nothing
        lblEContact_Address.Text = Nothing

    End Sub

#End Region

#Region "Panel (Moved Form)"
    Private Sub PnlMoveForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMoveForm.MouseMove, lblFormName.MouseMove
        If gc.MoveForm Then
            Me.Location = Me.Location + (e.Location - gc.MoveForm_MousePosition)
        End If
    End Sub

    Private Sub PnlMoveForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMoveForm.MouseUp, lblFormName.MouseUp
        If e.Button = MouseButtons.Left Then
            gc.MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PnlMoveForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlMoveForm.MouseDown, lblFormName.MouseDown
        If e.Button = MouseButtons.Left Then
            gc.MoveForm = True
            Me.Cursor = Cursors.Arrow
            gc.MoveForm_MousePosition = e.Location
        End If
    End Sub
#End Region

    Private Sub frmNewEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pnlMain.AutoScroll = True
        'Call Fill_CivilStatus()
        'Call Fill_EmploymentType()
        'Call Fill_EmploymentStatus()
        'Call Create_JobPosition()

        Call gc.Fill_ComboBox(cboCivilStatus, "spu_Employee_CivilStatusList", "CivilStatusID", "CivilStatusDescription")
        Call gc.Fill_ComboBox(cboEmplymentType, "spu_Employee_TypesOfEmploymentList", "EmploymentTypeID", "EmploymentTypeDescription")
        Call gc.Fill_ComboBox(cboEmploymentStatus, "spu_Employee_TypesOfEmploymentStatusList", "EmploymentStatusID", "EmploymentStatusDescription")
        Call gc.Fill_ComboBox(cboJobPosition, "spu_Employee_TypesOfJobPosition", "EmployeeJobPositionID", "EmployeeJobPositionDescription")

        If EditMode_EmployeeInfo = True Then
            Call FillEmployeeInfor_EditMode(Current_EmployeeID)
            EditMode_EmployeeInfo = False
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If btnNext.Text = "Save" Then
            Call Save_NewEmployeeInformation()
        Else
            If PersonalInfo = True Then
                Call Check_isEmptyText("Personal Info") 'Personal Info INPUT
                Select Case haveEmptyText
                    Case False
                        pnlPersonalInformation.Visible = False
                        pnlEmploymentStatus.Visible = True
                        EmploymentStatus = True
                        PersonalInfo = False
                        btnBack.Visible = True
                        Call ForwardForReview_Info("Personal Info")
                End Select

                'for test only
                'pnlPersonalInformation.Visible = False
                'pnlEmploymentStatus.Visible = True
                'EmploymentStatus = True
                'PersonalInfo = False
                'btnBack.Visible = True
                'Call ForwardForReview_Info("Personal Info")

            ElseIf EmploymentStatus = True Then
                Call Check_isEmptyText("Employment Status") 'Employment Status INPUT
                Select Case haveEmptyText
                    Case False
                        pnlEmploymentStatus.Visible = False
                        pnlBenefitsNumbers.Visible = True
                        BenefitsNumbers = True
                        EmploymentStatus = False
                        Call ForwardForReview_Info("Employment Status")
                End Select

                'for test only
                'pnlEmploymentStatus.Visible = False
                'pnlBenefitsNumbers.Visible = True
                'BenefitsNumbers = True
                'EmploymentStatus = False
                'Call ForwardForReview_Info("Employment Status")

            ElseIf BenefitsNumbers = True Then
                Call Check_isEmptyText("Benefits Numbers")
                Select Case haveEmptyText
                    Case False
                        pnlBenefitsNumbers.Visible = False
                        pnlEmergencyContact.Visible = True
                        EmergencyContact = True
                        BenefitsNumbers = False
                        Call ForwardForReview_Info("Benefits Numbers")
                End Select

                'for test only
                'pnlBenefitsNumbers.Visible = False
                'pnlEmergencyContact.Visible = True
                'EmergencyContact = True
                'BenefitsNumbers = False
                'Call ForwardForReview_Info("Benefits Numbers")

            ElseIf EmergencyContact = True Then
                Call Check_isEmptyText("Emergency Contact")
                Select Case haveEmptyText
                    Case False
                        pnlEmergencyContact.Visible = False
                        pnlReviewInformation.Visible = True
                        ReviewInformation = True
                        EmergencyContact = False
                        btnNext.Text = "Save"
                        btnBack.Visible = False
                        Call ForwardForReview_Info("Emergency Contact")
                End Select

                'for test only
                'pnlEmergencyContact.Visible = False
                'pnlReviewInformation.Visible = True
                'ReviewInformation = True
                'EmergencyContact = False
                'btnNext.Text = "Save"
                'btnBack.Visible = False
                'Call ForwardForReview_Info("Emergency Contact")

            End If
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If EmergencyContact = True Then
            pnlEmergencyContact.Visible = False
            pnlBenefitsNumbers.Visible = True
            BenefitsNumbers = True
            EmergencyContact = False
        ElseIf BenefitsNumbers = True Then
            pnlBenefitsNumbers.Visible = False
            pnlEmploymentStatus.Visible = True
            EmploymentStatus = True
            BenefitsNumbers = False
        ElseIf EmploymentStatus = True Then
            pnlEmploymentStatus.Visible = False
            pnlPersonalInformation.Visible = True
            PersonalInfo = True
            EmploymentStatus = False
            'Button
            btnBack.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Call BackToDefault()
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnChooseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseImage.Click
        Call UploadPhoto()
    End Sub

    Private Sub btnEdit_PersonalInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit_PersonalInfo.Click
        Call Edit_EmployeeInfo("Personal Info")
    End Sub

    Private Sub btnEdit_EmploymentStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit_EmploymentStatus.Click
        Call Edit_EmployeeInfo("Employment Status")
    End Sub

    Private Sub btnEdit_BenefitsNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit_BenefitsNumbers.Click
        Call Edit_EmployeeInfo("Benefits Numbers")
    End Sub

    Private Sub btnEdit_EmegencyContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit_EmegencyContact.Click
        Call Edit_EmployeeInfo("Emergency Contact")
    End Sub

End Class