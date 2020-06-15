'RON
'Created by: RON CONDE

Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmMainPage

    Dim c As New AppConfiguration
    Dim cs = c.cnstring

    Dim Current_EmployeeID As String
    Dim Current_EmployeeName As String

#Region "Functions"
    Private Sub Get_EmployeeMasterList(ByVal SearchInput As String)
        Try
            Dim ds As DataSet
            ds = SqlHelper.ExecuteDataset(cs, CommandType.StoredProcedure, "spu_GetEmployeeMasterList",
                                          New SqlParameter("@SearchInput", SearchInput))
            With dgvRisedentList
                .DataSource = ds.Tables(0)

                .Columns("EmployeeID").Visible = False

                .Columns("FullName").HeaderText = "Name"
                .Columns("FullName").Width = 200
                .Columns("FullName").ReadOnly = True
                .Columns("FullName").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("FullName").SortMode = DataGridViewColumnSortMode.NotSortable

                .Columns("ContactNumber").HeaderText = "Contact Number"
                .Columns("ContactNumber").Width = 150
                .Columns("ContactNumber").ReadOnly = True
                .Columns("ContactNumber").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("ContactNumber").SortMode = DataGridViewColumnSortMode.NotSortable

                .Columns("EmployeeAddress").HeaderText = "Employee Address"
                .Columns("EmployeeAddress").Width = 400
                .Columns("EmployeeAddress").ReadOnly = True
                .Columns("EmployeeAddress").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns("EmployeeAddress").SortMode = DataGridViewColumnSortMode.NotSortable

                lblEmployeeCount.Text = "Total count: " & .RowCount
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Get_EmployeeInformations(ByVal EmployeeID As String)
        Try
            Dim dr As SqlDataReader

            dr = SqlHelper.ExecuteReader(cs, CommandType.StoredProcedure, "spu_GetEmployeeInformation",
                                         New SqlParameter("@fcEmployeeID", EmployeeID))
            If dr.HasRows Then
                While dr.Read
                    With dr
                        lblLastName.Text = StrConv(.Item("LastName"), VbStrConv.ProperCase)
                        lblFirstName.Text = StrConv(.Item("FirstName"), VbStrConv.ProperCase)
                        lblMiddleName.Text = StrConv(.Item("MiddleName"), VbStrConv.ProperCase)
                        lblEmployeeName.Text = StrConv(.Item("FullName"), VbStrConv.ProperCase)
                        lblBirthDate.Text = .Item("BirthDate")
                        lblEmployeeAge.Text = .Item("Age")
                        lblGender.Text = .Item("Gender")
                        lblEmployeeAddress.Text = .Item("EmployeeAddress")
                        lblCivilStatus.Text = .Item("CivilStatus")
                        lblContactNumber.Text = .Item("ContactNumber")

                        If Not String.IsNullOrEmpty(dr.Item("EmployeeProfilePic").ToString.Trim) Then
                            Dim bytes As Byte() = dr.Item("EmployeeProfilePic")
                            Dim mstream As New MemoryStream(bytes)
                            picEmployeeProfilePicture.Image = Image.FromStream(mstream)
                            picEmployeeProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
                        Else
                            picEmployeeProfilePicture.Image = Nothing
                        End If
                    
                        lblEmployeeIDNumber.Text = .Item("EmployeeID")
                        lblEmploymentType.Text = .Item("EmploymentType")
                        lblEMploymentStatus.Text = .Item("EmploymentStatus")
                        lblSalaryRate.Text = .Item("SalaryRate")
                        lblDateHired.Text = .Item("DateHired")
                        lblContractEnd.Text = .Item("ContractEnd")
                        lblJobPosition.Text = .Item("JobPosition")

                        lblPhilHealthNumber.Text = .Item("PhilHealth")
                        lblPagibigNumber.Text = .Item("PAGIBIG")
                        lblSSSNumber.Text = .Item("SSS")
                        lblTINNumber.Text = .Item("TIN")

                        lblEContact_Name.Text = .Item("ContactName")
                        lblEContact_Address.Text = .Item("ContactAddress")
                        lblEContact_Relationship.Text = .Item("Relationship")
                        lblEContact_Number.Text = .Item("ContactNumber")

                    End With
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Account_PicRound()
        Dim ci As New Drawing2D.GraphicsPath
        ci.AddEllipse(0, 0, 100, 100)
        picEmployeeProfilePicture.Region = New Region(ci)
        picEmployeeProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub DeleteEmployeeInformation(ByVal EmployeeID As String)
        Try
            SqlHelper.ExecuteNonQuery(cs, CommandType.StoredProcedure, "spu_DeleteEmployeeInformation",
                                      New SqlParameter("@fcEmployeeID", EmployeeID))

            MsgBox("Employee Information deleted successfully!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub BackToDefault()
        lblLastName.Text = Nothing
        lblFirstName.Text = Nothing
        lblMiddleName.Text = Nothing
        lblEmployeeName.Text = Nothing
        lblBirthDate.Text = Nothing
        lblEmployeeAge.Text = Nothing
        lblGender.Text = Nothing
        lblEmployeeAddress.Text = Nothing
        lblCivilStatus.Text = Nothing
        lblContactNumber.Text = Nothing
        picEmployeeProfilePicture.Image = Nothing

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
        lblEContact_Address.Text = Nothing
        lblEContact_Relationship.Text = Nothing
        lblEContact_Number.Text = Nothing
    End Sub

    'Private Sub PreEditEmployeeInformation()
    '    With frmNewEmployee
    '        .txtLastName.Text = lblLastName.Text
    '        .txtFirstName.Text = lblFirstName.Text
    '        .txtMiddleName.Text = lblMiddleName.Text
    '        .dtpBirthdate.Value = lblBirthDate.Text 'This might error on other machine
    '        .txtAge.Text = lblEmployeeAge.Text
    '        .cboCivilStatus.SelectedItem = 1

    '        If lblGender.Text = "Male" Then
    '            .rbGenderMale.Checked = True
    '        Else
    '            .rbGenderFemale.Checked = True
    '        End If

    '        .txtEmployeeContactNumber.Text = lblContactNumber.Text
    '        .txtEmployeeAddress.Text = lblEmployeeAddress.Text
    '        .picEmployeeProfilePicture.Image = picEmployeeProfilePicture.Image

    '        .txtEmployeeIDNumber.Text = lblEmployeeIDNumber.Text
    '        .cboEmplymentType.SelectedItem = lblEmploymentType.Text
    '    End With
    'End Sub

#End Region

    Private Sub btnPersonalInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonalInfo.Click
        pnlPersonalInformation.Visible = True
        pnlEmploymentStatus.Visible = False
        pnlBenefitsNumbers.Visible = False
        pnlEmegencyContact.Visible = False

    End Sub

    Private Sub btnEmploymentStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmploymentStatus.Click
        pnlEmploymentStatus.Visible = True
        pnlPersonalInformation.Visible = False
        pnlBenefitsNumbers.Visible = False
        pnlEmegencyContact.Visible = False
    End Sub

    Private Sub btnBenefitsNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBenefitsNumbers.Click
        pnlBenefitsNumbers.Visible = True
        pnlPersonalInformation.Visible = False
        pnlEmploymentStatus.Visible = False
        pnlEmegencyContact.Visible = False
    End Sub

    Private Sub btnEmergencyContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmergencyContact.Click
        pnlEmegencyContact.Visible = True
        pnlPersonalInformation.Visible = False
        pnlEmploymentStatus.Visible = False
        pnlBenefitsNumbers.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim AppExit As String = MsgBox("Are you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
        If AppExit = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAddResident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddResident.Click
        frmNewEmployee.ShowDialog()
    End Sub

    Private Sub frmMainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Get_EmployeeMasterList(txtSearchEmployee.Text)
        Call Account_PicRound()
    End Sub

    Private Sub txtSearchEmployee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchEmployee.TextChanged
        Call Get_EmployeeMasterList(txtSearchEmployee.Text)
    End Sub

    Private Sub dgvRisedentList_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRisedentList.CellClick
        If dgvRisedentList.Rows.Count <> 0 Then
            With dgvRisedentList
                Current_EmployeeID = .SelectedRows(0).Cells(0).Value.ToString
                Current_EmployeeName = .SelectedRows(0).Cells(1).Value.ToString

                Call Get_EmployeeInformations(Current_EmployeeID)
                btnEditResidentInfo.Enabled = True
                btnDeleteResident.Enabled = True

                btnPrintID.Enabled = True
            End With
        End If
    End Sub

    Private Sub btnDeleteResident_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteResident.Click
        Dim deleteEmployee As String = MsgBox("Are you sure you want to delete this employee record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")

        If deleteEmployee = vbYes Then
            Call DeleteEmployeeInformation(Current_EmployeeID)
            Call Get_EmployeeMasterList("")
            btnEditResidentInfo.Enabled = False
            btnDeleteResident.Enabled = False

            btnPrintID.Enabled = False
            Call BackToDefault()
        End If
    End Sub

    Private Sub btnEditResidentInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditResidentInfo.Click
        'Call PreEditEmployeeInformation()
        frmNewEmployee.EditMode_EmployeeInfo = True
        frmNewEmployee.Current_EmployeeID = Current_EmployeeID
        frmNewEmployee.ShowDialog()
    End Sub

    Private Sub btnPrintID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintID.Click
        frmEmployeeIDCard_PrintPreview.ShowDialog()
    End Sub
End Class
