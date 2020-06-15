<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPage
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPage))
        Me.txtSearchEmployee = New System.Windows.Forms.TextBox()
        Me.dgvRisedentList = New System.Windows.Forms.DataGridView()
        Me.btnDeleteResident = New System.Windows.Forms.Button()
        Me.btnEditResidentInfo = New System.Windows.Forms.Button()
        Me.btnAddResident = New System.Windows.Forms.Button()
        Me.btnBenefitsNumbers = New System.Windows.Forms.Button()
        Me.btnEmploymentStatus = New System.Windows.Forms.Button()
        Me.btnEmergencyContact = New System.Windows.Forms.Button()
        Me.btnPersonalInfo = New System.Windows.Forms.Button()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.pnlEmegencyContact = New System.Windows.Forms.Panel()
        Me.lblEContact_Number = New System.Windows.Forms.Label()
        Me.lblEContact_Relationship = New System.Windows.Forms.Label()
        Me.lblEContact_Address = New System.Windows.Forms.Label()
        Me.lblEContact_Name = New System.Windows.Forms.Label()
        Me.pnlBenefitsNumbers = New System.Windows.Forms.Panel()
        Me.lblTINNumber = New System.Windows.Forms.Label()
        Me.lblPagibigNumber = New System.Windows.Forms.Label()
        Me.lblSSSNumber = New System.Windows.Forms.Label()
        Me.lblPhilHealthNumber = New System.Windows.Forms.Label()
        Me.pnlEmploymentStatus = New System.Windows.Forms.Panel()
        Me.lblJobPosition = New System.Windows.Forms.Label()
        Me.lblContractEnd = New System.Windows.Forms.Label()
        Me.lblDateHired = New System.Windows.Forms.Label()
        Me.lblSalaryRate = New System.Windows.Forms.Label()
        Me.lblEMploymentStatus = New System.Windows.Forms.Label()
        Me.lblEmploymentType = New System.Windows.Forms.Label()
        Me.lblEmployeeIDNumber = New System.Windows.Forms.Label()
        Me.pnlPersonalInformation = New System.Windows.Forms.Panel()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblCivilStatus = New System.Windows.Forms.Label()
        Me.lblEmployeeAddress = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblEmployeeAge = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmployeeCount = New System.Windows.Forms.Label()
        Me.picEmployeeProfilePicture = New System.Windows.Forms.PictureBox()
        Me.btnPrintID = New System.Windows.Forms.Button()
        CType(Me.dgvRisedentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEmegencyContact.SuspendLayout()
        Me.pnlBenefitsNumbers.SuspendLayout()
        Me.pnlEmploymentStatus.SuspendLayout()
        Me.pnlPersonalInformation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picEmployeeProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchEmployee
        '
        Me.txtSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchEmployee.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmployee.Location = New System.Drawing.Point(111, 72)
        Me.txtSearchEmployee.Name = "txtSearchEmployee"
        Me.txtSearchEmployee.Size = New System.Drawing.Size(240, 19)
        Me.txtSearchEmployee.TabIndex = 0
        '
        'dgvRisedentList
        '
        Me.dgvRisedentList.AllowUserToAddRows = False
        Me.dgvRisedentList.AllowUserToDeleteRows = False
        Me.dgvRisedentList.AllowUserToResizeColumns = False
        Me.dgvRisedentList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvRisedentList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRisedentList.BackgroundColor = System.Drawing.Color.White
        Me.dgvRisedentList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRisedentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRisedentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRisedentList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRisedentList.GridColor = System.Drawing.Color.White
        Me.dgvRisedentList.Location = New System.Drawing.Point(39, 132)
        Me.dgvRisedentList.Name = "dgvRisedentList"
        Me.dgvRisedentList.RowHeadersVisible = False
        Me.dgvRisedentList.RowTemplate.Height = 30
        Me.dgvRisedentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRisedentList.Size = New System.Drawing.Size(322, 476)
        Me.dgvRisedentList.TabIndex = 7
        '
        'btnDeleteResident
        '
        Me.btnDeleteResident.Enabled = False
        Me.btnDeleteResident.FlatAppearance.BorderSize = 0
        Me.btnDeleteResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteResident.Image = CType(resources.GetObject("btnDeleteResident.Image"), System.Drawing.Image)
        Me.btnDeleteResident.Location = New System.Drawing.Point(196, 628)
        Me.btnDeleteResident.Name = "btnDeleteResident"
        Me.btnDeleteResident.Size = New System.Drawing.Size(73, 33)
        Me.btnDeleteResident.TabIndex = 9
        Me.btnDeleteResident.UseVisualStyleBackColor = True
        '
        'btnEditResidentInfo
        '
        Me.btnEditResidentInfo.Enabled = False
        Me.btnEditResidentInfo.FlatAppearance.BorderSize = 0
        Me.btnEditResidentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditResidentInfo.Image = CType(resources.GetObject("btnEditResidentInfo.Image"), System.Drawing.Image)
        Me.btnEditResidentInfo.Location = New System.Drawing.Point(133, 628)
        Me.btnEditResidentInfo.Name = "btnEditResidentInfo"
        Me.btnEditResidentInfo.Size = New System.Drawing.Size(57, 33)
        Me.btnEditResidentInfo.TabIndex = 10
        Me.btnEditResidentInfo.UseVisualStyleBackColor = True
        '
        'btnAddResident
        '
        Me.btnAddResident.FlatAppearance.BorderSize = 0
        Me.btnAddResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddResident.Image = CType(resources.GetObject("btnAddResident.Image"), System.Drawing.Image)
        Me.btnAddResident.Location = New System.Drawing.Point(37, 628)
        Me.btnAddResident.Name = "btnAddResident"
        Me.btnAddResident.Size = New System.Drawing.Size(91, 33)
        Me.btnAddResident.TabIndex = 11
        Me.btnAddResident.UseVisualStyleBackColor = True
        '
        'btnBenefitsNumbers
        '
        Me.btnBenefitsNumbers.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnBenefitsNumbers.FlatAppearance.BorderSize = 0
        Me.btnBenefitsNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBenefitsNumbers.Image = CType(resources.GetObject("btnBenefitsNumbers.Image"), System.Drawing.Image)
        Me.btnBenefitsNumbers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBenefitsNumbers.Location = New System.Drawing.Point(418, 492)
        Me.btnBenefitsNumbers.Name = "btnBenefitsNumbers"
        Me.btnBenefitsNumbers.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnBenefitsNumbers.Size = New System.Drawing.Size(220, 55)
        Me.btnBenefitsNumbers.TabIndex = 11
        Me.btnBenefitsNumbers.UseVisualStyleBackColor = False
        '
        'btnEmploymentStatus
        '
        Me.btnEmploymentStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnEmploymentStatus.FlatAppearance.BorderSize = 0
        Me.btnEmploymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmploymentStatus.Image = CType(resources.GetObject("btnEmploymentStatus.Image"), System.Drawing.Image)
        Me.btnEmploymentStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmploymentStatus.Location = New System.Drawing.Point(418, 432)
        Me.btnEmploymentStatus.Name = "btnEmploymentStatus"
        Me.btnEmploymentStatus.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnEmploymentStatus.Size = New System.Drawing.Size(220, 55)
        Me.btnEmploymentStatus.TabIndex = 13
        Me.btnEmploymentStatus.UseVisualStyleBackColor = False
        '
        'btnEmergencyContact
        '
        Me.btnEmergencyContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnEmergencyContact.FlatAppearance.BorderSize = 0
        Me.btnEmergencyContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmergencyContact.Image = CType(resources.GetObject("btnEmergencyContact.Image"), System.Drawing.Image)
        Me.btnEmergencyContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmergencyContact.Location = New System.Drawing.Point(418, 552)
        Me.btnEmergencyContact.Name = "btnEmergencyContact"
        Me.btnEmergencyContact.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnEmergencyContact.Size = New System.Drawing.Size(220, 55)
        Me.btnEmergencyContact.TabIndex = 12
        Me.btnEmergencyContact.UseVisualStyleBackColor = False
        '
        'btnPersonalInfo
        '
        Me.btnPersonalInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnPersonalInfo.FlatAppearance.BorderSize = 0
        Me.btnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonalInfo.Image = CType(resources.GetObject("btnPersonalInfo.Image"), System.Drawing.Image)
        Me.btnPersonalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonalInfo.Location = New System.Drawing.Point(418, 372)
        Me.btnPersonalInfo.Name = "btnPersonalInfo"
        Me.btnPersonalInfo.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnPersonalInfo.Size = New System.Drawing.Size(220, 55)
        Me.btnPersonalInfo.TabIndex = 10
        Me.btnPersonalInfo.UseVisualStyleBackColor = False
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeName.Location = New System.Drawing.Point(423, 207)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(211, 23)
        Me.lblEmployeeName.TabIndex = 9
        Me.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlEmegencyContact
        '
        Me.pnlEmegencyContact.BackgroundImage = CType(resources.GetObject("pnlEmegencyContact.BackgroundImage"), System.Drawing.Image)
        Me.pnlEmegencyContact.Controls.Add(Me.lblEContact_Number)
        Me.pnlEmegencyContact.Controls.Add(Me.lblEContact_Relationship)
        Me.pnlEmegencyContact.Controls.Add(Me.lblEContact_Address)
        Me.pnlEmegencyContact.Controls.Add(Me.lblEContact_Name)
        Me.pnlEmegencyContact.Location = New System.Drawing.Point(660, 89)
        Me.pnlEmegencyContact.Name = "pnlEmegencyContact"
        Me.pnlEmegencyContact.Size = New System.Drawing.Size(508, 276)
        Me.pnlEmegencyContact.TabIndex = 7
        Me.pnlEmegencyContact.Visible = False
        '
        'lblEContact_Number
        '
        Me.lblEContact_Number.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Number.Location = New System.Drawing.Point(263, 218)
        Me.lblEContact_Number.Name = "lblEContact_Number"
        Me.lblEContact_Number.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Number.Size = New System.Drawing.Size(212, 24)
        Me.lblEContact_Number.TabIndex = 11
        Me.lblEContact_Number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEContact_Relationship
        '
        Me.lblEContact_Relationship.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Relationship.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Relationship.Location = New System.Drawing.Point(30, 218)
        Me.lblEContact_Relationship.Name = "lblEContact_Relationship"
        Me.lblEContact_Relationship.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Relationship.Size = New System.Drawing.Size(212, 24)
        Me.lblEContact_Relationship.TabIndex = 10
        Me.lblEContact_Relationship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEContact_Address
        '
        Me.lblEContact_Address.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Address.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Address.Location = New System.Drawing.Point(30, 153)
        Me.lblEContact_Address.Name = "lblEContact_Address"
        Me.lblEContact_Address.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Address.Size = New System.Drawing.Size(443, 24)
        Me.lblEContact_Address.TabIndex = 9
        Me.lblEContact_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEContact_Name
        '
        Me.lblEContact_Name.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Name.Location = New System.Drawing.Point(32, 86)
        Me.lblEContact_Name.Name = "lblEContact_Name"
        Me.lblEContact_Name.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Name.Size = New System.Drawing.Size(255, 24)
        Me.lblEContact_Name.TabIndex = 1
        Me.lblEContact_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBenefitsNumbers
        '
        Me.pnlBenefitsNumbers.BackgroundImage = CType(resources.GetObject("pnlBenefitsNumbers.BackgroundImage"), System.Drawing.Image)
        Me.pnlBenefitsNumbers.Controls.Add(Me.lblTINNumber)
        Me.pnlBenefitsNumbers.Controls.Add(Me.lblPagibigNumber)
        Me.pnlBenefitsNumbers.Controls.Add(Me.lblSSSNumber)
        Me.pnlBenefitsNumbers.Controls.Add(Me.lblPhilHealthNumber)
        Me.pnlBenefitsNumbers.Location = New System.Drawing.Point(660, 89)
        Me.pnlBenefitsNumbers.Name = "pnlBenefitsNumbers"
        Me.pnlBenefitsNumbers.Size = New System.Drawing.Size(508, 215)
        Me.pnlBenefitsNumbers.TabIndex = 6
        Me.pnlBenefitsNumbers.Visible = False
        '
        'lblTINNumber
        '
        Me.lblTINNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblTINNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTINNumber.Location = New System.Drawing.Point(262, 153)
        Me.lblTINNumber.Name = "lblTINNumber"
        Me.lblTINNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblTINNumber.Size = New System.Drawing.Size(212, 24)
        Me.lblTINNumber.TabIndex = 12
        Me.lblTINNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPagibigNumber
        '
        Me.lblPagibigNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPagibigNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagibigNumber.Location = New System.Drawing.Point(263, 86)
        Me.lblPagibigNumber.Name = "lblPagibigNumber"
        Me.lblPagibigNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblPagibigNumber.Size = New System.Drawing.Size(212, 24)
        Me.lblPagibigNumber.TabIndex = 11
        Me.lblPagibigNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSSSNumber
        '
        Me.lblSSSNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSSSNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSSNumber.Location = New System.Drawing.Point(30, 153)
        Me.lblSSSNumber.Name = "lblSSSNumber"
        Me.lblSSSNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblSSSNumber.Size = New System.Drawing.Size(212, 24)
        Me.lblSSSNumber.TabIndex = 10
        Me.lblSSSNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPhilHealthNumber
        '
        Me.lblPhilHealthNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhilHealthNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilHealthNumber.Location = New System.Drawing.Point(30, 86)
        Me.lblPhilHealthNumber.Name = "lblPhilHealthNumber"
        Me.lblPhilHealthNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblPhilHealthNumber.Size = New System.Drawing.Size(212, 24)
        Me.lblPhilHealthNumber.TabIndex = 9
        Me.lblPhilHealthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlEmploymentStatus
        '
        Me.pnlEmploymentStatus.BackgroundImage = CType(resources.GetObject("pnlEmploymentStatus.BackgroundImage"), System.Drawing.Image)
        Me.pnlEmploymentStatus.Controls.Add(Me.lblJobPosition)
        Me.pnlEmploymentStatus.Controls.Add(Me.lblContractEnd)
        Me.pnlEmploymentStatus.Controls.Add(Me.lblDateHired)
        Me.pnlEmploymentStatus.Controls.Add(Me.lblSalaryRate)
        Me.pnlEmploymentStatus.Controls.Add(Me.lblEMploymentStatus)
        Me.pnlEmploymentStatus.Controls.Add(Me.lblEmploymentType)
        Me.pnlEmploymentStatus.Controls.Add(Me.lblEmployeeIDNumber)
        Me.pnlEmploymentStatus.Location = New System.Drawing.Point(660, 89)
        Me.pnlEmploymentStatus.Name = "pnlEmploymentStatus"
        Me.pnlEmploymentStatus.Size = New System.Drawing.Size(508, 563)
        Me.pnlEmploymentStatus.TabIndex = 3
        Me.pnlEmploymentStatus.Visible = False
        '
        'lblJobPosition
        '
        Me.lblJobPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblJobPosition.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobPosition.Location = New System.Drawing.Point(90, 510)
        Me.lblJobPosition.Name = "lblJobPosition"
        Me.lblJobPosition.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblJobPosition.Size = New System.Drawing.Size(228, 24)
        Me.lblJobPosition.TabIndex = 11
        Me.lblJobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContractEnd
        '
        Me.lblContractEnd.BackColor = System.Drawing.Color.Transparent
        Me.lblContractEnd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContractEnd.Location = New System.Drawing.Point(90, 438)
        Me.lblContractEnd.Name = "lblContractEnd"
        Me.lblContractEnd.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblContractEnd.Size = New System.Drawing.Size(228, 24)
        Me.lblContractEnd.TabIndex = 10
        Me.lblContractEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateHired
        '
        Me.lblDateHired.BackColor = System.Drawing.Color.Transparent
        Me.lblDateHired.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateHired.Location = New System.Drawing.Point(90, 386)
        Me.lblDateHired.Name = "lblDateHired"
        Me.lblDateHired.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblDateHired.Size = New System.Drawing.Size(228, 24)
        Me.lblDateHired.TabIndex = 9
        Me.lblDateHired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalaryRate
        '
        Me.lblSalaryRate.BackColor = System.Drawing.Color.Transparent
        Me.lblSalaryRate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryRate.Location = New System.Drawing.Point(32, 268)
        Me.lblSalaryRate.Name = "lblSalaryRate"
        Me.lblSalaryRate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblSalaryRate.Size = New System.Drawing.Size(212, 24)
        Me.lblSalaryRate.TabIndex = 8
        Me.lblSalaryRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEMploymentStatus
        '
        Me.lblEMploymentStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblEMploymentStatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEMploymentStatus.Location = New System.Drawing.Point(263, 206)
        Me.lblEMploymentStatus.Name = "lblEMploymentStatus"
        Me.lblEMploymentStatus.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEMploymentStatus.Size = New System.Drawing.Size(212, 24)
        Me.lblEMploymentStatus.TabIndex = 7
        Me.lblEMploymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmploymentType
        '
        Me.lblEmploymentType.BackColor = System.Drawing.Color.Transparent
        Me.lblEmploymentType.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmploymentType.Location = New System.Drawing.Point(30, 206)
        Me.lblEmploymentType.Name = "lblEmploymentType"
        Me.lblEmploymentType.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmploymentType.Size = New System.Drawing.Size(212, 24)
        Me.lblEmploymentType.TabIndex = 6
        Me.lblEmploymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeIDNumber
        '
        Me.lblEmployeeIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeIDNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeIDNumber.Location = New System.Drawing.Point(30, 86)
        Me.lblEmployeeIDNumber.Name = "lblEmployeeIDNumber"
        Me.lblEmployeeIDNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmployeeIDNumber.Size = New System.Drawing.Size(212, 24)
        Me.lblEmployeeIDNumber.TabIndex = 5
        Me.lblEmployeeIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlPersonalInformation
        '
        Me.pnlPersonalInformation.BackgroundImage = CType(resources.GetObject("pnlPersonalInformation.BackgroundImage"), System.Drawing.Image)
        Me.pnlPersonalInformation.Controls.Add(Me.lblContactNumber)
        Me.pnlPersonalInformation.Controls.Add(Me.lblCivilStatus)
        Me.pnlPersonalInformation.Controls.Add(Me.lblEmployeeAddress)
        Me.pnlPersonalInformation.Controls.Add(Me.lblGender)
        Me.pnlPersonalInformation.Controls.Add(Me.lblEmployeeAge)
        Me.pnlPersonalInformation.Controls.Add(Me.lblBirthDate)
        Me.pnlPersonalInformation.Controls.Add(Me.lblMiddleName)
        Me.pnlPersonalInformation.Controls.Add(Me.lblFirstName)
        Me.pnlPersonalInformation.Controls.Add(Me.lblLastName)
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(660, 89)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(508, 563)
        Me.pnlPersonalInformation.TabIndex = 2
        '
        'lblContactNumber
        '
        Me.lblContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblContactNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(262, 503)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblContactNumber.Size = New System.Drawing.Size(212, 24)
        Me.lblContactNumber.TabIndex = 10
        Me.lblContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblCivilStatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCivilStatus.Location = New System.Drawing.Point(34, 503)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblCivilStatus.Size = New System.Drawing.Size(212, 24)
        Me.lblCivilStatus.TabIndex = 9
        Me.lblCivilStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeAddress
        '
        Me.lblEmployeeAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAddress.Location = New System.Drawing.Point(34, 437)
        Me.lblEmployeeAddress.Name = "lblEmployeeAddress"
        Me.lblEmployeeAddress.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmployeeAddress.Size = New System.Drawing.Size(440, 24)
        Me.lblEmployeeAddress.TabIndex = 8
        Me.lblEmployeeAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(373, 272)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblGender.Size = New System.Drawing.Size(100, 24)
        Me.lblGender.TabIndex = 7
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeAge
        '
        Me.lblEmployeeAge.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeAge.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAge.Location = New System.Drawing.Point(91, 324)
        Me.lblEmployeeAge.Name = "lblEmployeeAge"
        Me.lblEmployeeAge.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmployeeAge.Size = New System.Drawing.Size(154, 24)
        Me.lblEmployeeAge.TabIndex = 6
        Me.lblEmployeeAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBirthDate
        '
        Me.lblBirthDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(91, 272)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblBirthDate.Size = New System.Drawing.Size(154, 24)
        Me.lblBirthDate.TabIndex = 5
        Me.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMiddleName
        '
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(30, 153)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblMiddleName.Size = New System.Drawing.Size(212, 24)
        Me.lblMiddleName.TabIndex = 4
        Me.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(262, 86)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblFirstName.Size = New System.Drawing.Size(212, 24)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(30, 86)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblLastName.Size = New System.Drawing.Size(212, 24)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1149, -1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 30)
        Me.Panel1.TabIndex = 14
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1097, -1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(50, 31)
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "IDENTIFICATION CARD LAYOUT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployeeCount
        '
        Me.lblEmployeeCount.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeCount.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeCount.Location = New System.Drawing.Point(111, 103)
        Me.lblEmployeeCount.Name = "lblEmployeeCount"
        Me.lblEmployeeCount.Size = New System.Drawing.Size(253, 17)
        Me.lblEmployeeCount.TabIndex = 15
        Me.lblEmployeeCount.Text = "Total count:"
        Me.lblEmployeeCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picEmployeeProfilePicture
        '
        Me.picEmployeeProfilePicture.BackColor = System.Drawing.Color.Transparent
        Me.picEmployeeProfilePicture.Location = New System.Drawing.Point(478, 88)
        Me.picEmployeeProfilePicture.Name = "picEmployeeProfilePicture"
        Me.picEmployeeProfilePicture.Size = New System.Drawing.Size(100, 100)
        Me.picEmployeeProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmployeeProfilePicture.TabIndex = 16
        Me.picEmployeeProfilePicture.TabStop = False
        '
        'btnPrintID
        '
        Me.btnPrintID.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintID.Enabled = False
        Me.btnPrintID.FlatAppearance.BorderSize = 0
        Me.btnPrintID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintID.ForeColor = System.Drawing.Color.White
        Me.btnPrintID.Image = CType(resources.GetObject("btnPrintID.Image"), System.Drawing.Image)
        Me.btnPrintID.Location = New System.Drawing.Point(276, 628)
        Me.btnPrintID.Name = "btnPrintID"
        Me.btnPrintID.Size = New System.Drawing.Size(73, 33)
        Me.btnPrintID.TabIndex = 17
        Me.btnPrintID.UseVisualStyleBackColor = False
        '
        'frmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1198, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrintID)
        Me.Controls.Add(Me.picEmployeeProfilePicture)
        Me.Controls.Add(Me.pnlEmegencyContact)
        Me.Controls.Add(Me.pnlBenefitsNumbers)
        Me.Controls.Add(Me.pnlEmploymentStatus)
        Me.Controls.Add(Me.pnlPersonalInformation)
        Me.Controls.Add(Me.lblEmployeeCount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.btnBenefitsNumbers)
        Me.Controls.Add(Me.btnEmploymentStatus)
        Me.Controls.Add(Me.btnAddResident)
        Me.Controls.Add(Me.btnEmergencyContact)
        Me.Controls.Add(Me.btnPersonalInfo)
        Me.Controls.Add(Me.btnEditResidentInfo)
        Me.Controls.Add(Me.btnDeleteResident)
        Me.Controls.Add(Me.dgvRisedentList)
        Me.Controls.Add(Me.txtSearchEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvRisedentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEmegencyContact.ResumeLayout(False)
        Me.pnlBenefitsNumbers.ResumeLayout(False)
        Me.pnlEmploymentStatus.ResumeLayout(False)
        Me.pnlPersonalInformation.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picEmployeeProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchEmployee As System.Windows.Forms.TextBox
    Friend WithEvents dgvRisedentList As System.Windows.Forms.DataGridView
    Friend WithEvents btnDeleteResident As System.Windows.Forms.Button
    Friend WithEvents btnEditResidentInfo As System.Windows.Forms.Button
    Friend WithEvents btnAddResident As System.Windows.Forms.Button
    Friend WithEvents pnlPersonalInformation As System.Windows.Forms.Panel
    Friend WithEvents pnlEmploymentStatus As System.Windows.Forms.Panel
    Friend WithEvents pnlBenefitsNumbers As System.Windows.Forms.Panel
    Friend WithEvents pnlEmegencyContact As System.Windows.Forms.Panel
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents btnBenefitsNumbers As System.Windows.Forms.Button
    Friend WithEvents btnEmploymentStatus As System.Windows.Forms.Button
    Friend WithEvents btnEmergencyContact As System.Windows.Forms.Button
    Friend WithEvents btnPersonalInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents lblEmployeeCount As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Name As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeAge As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeAddress As System.Windows.Forms.Label
    Friend WithEvents lblCivilStatus As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeIDNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmploymentType As System.Windows.Forms.Label
    Friend WithEvents lblEMploymentStatus As System.Windows.Forms.Label
    Friend WithEvents lblSalaryRate As System.Windows.Forms.Label
    Friend WithEvents lblDateHired As System.Windows.Forms.Label
    Friend WithEvents lblContractEnd As System.Windows.Forms.Label
    Friend WithEvents lblJobPosition As System.Windows.Forms.Label
    Friend WithEvents lblPhilHealthNumber As System.Windows.Forms.Label
    Friend WithEvents lblTINNumber As System.Windows.Forms.Label
    Friend WithEvents lblPagibigNumber As System.Windows.Forms.Label
    Friend WithEvents lblSSSNumber As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Address As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Number As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Relationship As System.Windows.Forms.Label
    Friend WithEvents picEmployeeProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrintID As System.Windows.Forms.Button

End Class
