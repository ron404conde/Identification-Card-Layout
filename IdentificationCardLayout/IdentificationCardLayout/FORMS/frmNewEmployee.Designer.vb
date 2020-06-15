<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewEmployee))
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlEmergencyContact = New System.Windows.Forms.Panel()
        Me.txtEContact_Address = New System.Windows.Forms.TextBox()
        Me.txtEContactNumber = New System.Windows.Forms.TextBox()
        Me.txtEContact_Relationship = New System.Windows.Forms.TextBox()
        Me.txtEContact_Name = New System.Windows.Forms.TextBox()
        Me.pnlBenefitsNumbers = New System.Windows.Forms.Panel()
        Me.txtTINNumber = New System.Windows.Forms.TextBox()
        Me.txtSSSNumber = New System.Windows.Forms.TextBox()
        Me.txtPagibigNumber = New System.Windows.Forms.TextBox()
        Me.txtPhilHealthNumber = New System.Windows.Forms.TextBox()
        Me.pnlEmploymentStatus = New System.Windows.Forms.Panel()
        Me.dtpDateHired = New System.Windows.Forms.DateTimePicker()
        Me.dtpContractEnd = New System.Windows.Forms.DateTimePicker()
        Me.cboJobPosition = New System.Windows.Forms.ComboBox()
        Me.cboEmploymentStatus = New System.Windows.Forms.ComboBox()
        Me.txtSalaryRate = New System.Windows.Forms.TextBox()
        Me.cboEmplymentType = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeIDNumber = New System.Windows.Forms.TextBox()
        Me.pnlPersonalInformation = New System.Windows.Forms.Panel()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.picEmployeeProfilePicture = New System.Windows.Forms.PictureBox()
        Me.txtEmployeeAddress = New System.Windows.Forms.TextBox()
        Me.txtEmployeeContactNumber = New System.Windows.Forms.TextBox()
        Me.rbGenderFemale = New System.Windows.Forms.RadioButton()
        Me.rbGenderMale = New System.Windows.Forms.RadioButton()
        Me.cboCivilStatus = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.pnlReviewInformation = New System.Windows.Forms.Panel()
        Me.btnEdit_EmegencyContact = New System.Windows.Forms.Button()
        Me.btnEdit_BenefitsNumbers = New System.Windows.Forms.Button()
        Me.btnEdit_EmploymentStatus = New System.Windows.Forms.Button()
        Me.btnEdit_PersonalInfo = New System.Windows.Forms.Button()
        Me.lblEContact_Address = New System.Windows.Forms.Label()
        Me.lblEContact_Number = New System.Windows.Forms.Label()
        Me.lblEContact_Relationship = New System.Windows.Forms.Label()
        Me.lblEContact_Name = New System.Windows.Forms.Label()
        Me.lblTINNumber = New System.Windows.Forms.Label()
        Me.lblSSSNumber = New System.Windows.Forms.Label()
        Me.lblPagibigNumber = New System.Windows.Forms.Label()
        Me.lblPhilHealthNumber = New System.Windows.Forms.Label()
        Me.lblJobPosition = New System.Windows.Forms.Label()
        Me.lblContractEnd = New System.Windows.Forms.Label()
        Me.lblDateHired = New System.Windows.Forms.Label()
        Me.lblSalaryRate = New System.Windows.Forms.Label()
        Me.lblEMploymentStatus = New System.Windows.Forms.Label()
        Me.lblEmploymentType = New System.Windows.Forms.Label()
        Me.lblEmployeeIDNumber = New System.Windows.Forms.Label()
        Me.lblEmployeeAddress = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblCivilStatus = New System.Windows.Forms.Label()
        Me.lblEmployeeAge = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.pnlMoveForm = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.pnlEmergencyContact.SuspendLayout()
        Me.pnlBenefitsNumbers.SuspendLayout()
        Me.pnlEmploymentStatus.SuspendLayout()
        Me.pnlPersonalInformation.SuspendLayout()
        CType(Me.picEmployeeProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReviewInformation.SuspendLayout()
        Me.pnlMoveForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.pnlEmergencyContact)
        Me.pnlMain.Controls.Add(Me.pnlBenefitsNumbers)
        Me.pnlMain.Controls.Add(Me.pnlEmploymentStatus)
        Me.pnlMain.Controls.Add(Me.pnlPersonalInformation)
        Me.pnlMain.Controls.Add(Me.pnlReviewInformation)
        Me.pnlMain.Location = New System.Drawing.Point(23, 56)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(772, 537)
        Me.pnlMain.TabIndex = 0
        '
        'pnlEmergencyContact
        '
        Me.pnlEmergencyContact.BackgroundImage = CType(resources.GetObject("pnlEmergencyContact.BackgroundImage"), System.Drawing.Image)
        Me.pnlEmergencyContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlEmergencyContact.Controls.Add(Me.txtEContact_Address)
        Me.pnlEmergencyContact.Controls.Add(Me.txtEContactNumber)
        Me.pnlEmergencyContact.Controls.Add(Me.txtEContact_Relationship)
        Me.pnlEmergencyContact.Controls.Add(Me.txtEContact_Name)
        Me.pnlEmergencyContact.Location = New System.Drawing.Point(0, 0)
        Me.pnlEmergencyContact.Name = "pnlEmergencyContact"
        Me.pnlEmergencyContact.Size = New System.Drawing.Size(754, 533)
        Me.pnlEmergencyContact.TabIndex = 19
        Me.pnlEmergencyContact.Visible = False
        '
        'txtEContact_Address
        '
        Me.txtEContact_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEContact_Address.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEContact_Address.Location = New System.Drawing.Point(33, 243)
        Me.txtEContact_Address.Name = "txtEContact_Address"
        Me.txtEContact_Address.Size = New System.Drawing.Size(705, 19)
        Me.txtEContact_Address.TabIndex = 11
        '
        'txtEContactNumber
        '
        Me.txtEContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEContactNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEContactNumber.Location = New System.Drawing.Point(529, 182)
        Me.txtEContactNumber.Name = "txtEContactNumber"
        Me.txtEContactNumber.Size = New System.Drawing.Size(209, 19)
        Me.txtEContactNumber.TabIndex = 10
        '
        'txtEContact_Relationship
        '
        Me.txtEContact_Relationship.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEContact_Relationship.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEContact_Relationship.Location = New System.Drawing.Point(280, 182)
        Me.txtEContact_Relationship.Name = "txtEContact_Relationship"
        Me.txtEContact_Relationship.Size = New System.Drawing.Size(209, 19)
        Me.txtEContact_Relationship.TabIndex = 9
        '
        'txtEContact_Name
        '
        Me.txtEContact_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEContact_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEContact_Name.Location = New System.Drawing.Point(33, 182)
        Me.txtEContact_Name.Name = "txtEContact_Name"
        Me.txtEContact_Name.Size = New System.Drawing.Size(209, 19)
        Me.txtEContact_Name.TabIndex = 8
        '
        'pnlBenefitsNumbers
        '
        Me.pnlBenefitsNumbers.BackgroundImage = CType(resources.GetObject("pnlBenefitsNumbers.BackgroundImage"), System.Drawing.Image)
        Me.pnlBenefitsNumbers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlBenefitsNumbers.Controls.Add(Me.txtTINNumber)
        Me.pnlBenefitsNumbers.Controls.Add(Me.txtSSSNumber)
        Me.pnlBenefitsNumbers.Controls.Add(Me.txtPagibigNumber)
        Me.pnlBenefitsNumbers.Controls.Add(Me.txtPhilHealthNumber)
        Me.pnlBenefitsNumbers.Location = New System.Drawing.Point(0, 0)
        Me.pnlBenefitsNumbers.Name = "pnlBenefitsNumbers"
        Me.pnlBenefitsNumbers.Size = New System.Drawing.Size(754, 533)
        Me.pnlBenefitsNumbers.TabIndex = 18
        Me.pnlBenefitsNumbers.Visible = False
        '
        'txtTINNumber
        '
        Me.txtTINNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTINNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTINNumber.Location = New System.Drawing.Point(33, 243)
        Me.txtTINNumber.Name = "txtTINNumber"
        Me.txtTINNumber.Size = New System.Drawing.Size(209, 19)
        Me.txtTINNumber.TabIndex = 10
        '
        'txtSSSNumber
        '
        Me.txtSSSNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSSSNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSSNumber.Location = New System.Drawing.Point(528, 182)
        Me.txtSSSNumber.Name = "txtSSSNumber"
        Me.txtSSSNumber.Size = New System.Drawing.Size(209, 19)
        Me.txtSSSNumber.TabIndex = 9
        '
        'txtPagibigNumber
        '
        Me.txtPagibigNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPagibigNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagibigNumber.Location = New System.Drawing.Point(280, 182)
        Me.txtPagibigNumber.Name = "txtPagibigNumber"
        Me.txtPagibigNumber.Size = New System.Drawing.Size(209, 19)
        Me.txtPagibigNumber.TabIndex = 8
        '
        'txtPhilHealthNumber
        '
        Me.txtPhilHealthNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhilHealthNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhilHealthNumber.Location = New System.Drawing.Point(33, 182)
        Me.txtPhilHealthNumber.Name = "txtPhilHealthNumber"
        Me.txtPhilHealthNumber.Size = New System.Drawing.Size(209, 19)
        Me.txtPhilHealthNumber.TabIndex = 7
        '
        'pnlEmploymentStatus
        '
        Me.pnlEmploymentStatus.BackgroundImage = CType(resources.GetObject("pnlEmploymentStatus.BackgroundImage"), System.Drawing.Image)
        Me.pnlEmploymentStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlEmploymentStatus.Controls.Add(Me.dtpDateHired)
        Me.pnlEmploymentStatus.Controls.Add(Me.dtpContractEnd)
        Me.pnlEmploymentStatus.Controls.Add(Me.cboJobPosition)
        Me.pnlEmploymentStatus.Controls.Add(Me.cboEmploymentStatus)
        Me.pnlEmploymentStatus.Controls.Add(Me.txtSalaryRate)
        Me.pnlEmploymentStatus.Controls.Add(Me.cboEmplymentType)
        Me.pnlEmploymentStatus.Controls.Add(Me.txtEmployeeIDNumber)
        Me.pnlEmploymentStatus.Location = New System.Drawing.Point(0, 0)
        Me.pnlEmploymentStatus.Name = "pnlEmploymentStatus"
        Me.pnlEmploymentStatus.Size = New System.Drawing.Size(754, 533)
        Me.pnlEmploymentStatus.TabIndex = 17
        Me.pnlEmploymentStatus.Visible = False
        '
        'dtpDateHired
        '
        Me.dtpDateHired.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateHired.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateHired.Location = New System.Drawing.Point(23, 312)
        Me.dtpDateHired.Name = "dtpDateHired"
        Me.dtpDateHired.Size = New System.Drawing.Size(228, 23)
        Me.dtpDateHired.TabIndex = 14
        '
        'dtpContractEnd
        '
        Me.dtpContractEnd.CustomFormat = "MMMM dd, yyyy"
        Me.dtpContractEnd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpContractEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpContractEnd.Location = New System.Drawing.Point(270, 312)
        Me.dtpContractEnd.Name = "dtpContractEnd"
        Me.dtpContractEnd.Size = New System.Drawing.Size(228, 23)
        Me.dtpContractEnd.TabIndex = 13
        '
        'cboJobPosition
        '
        Me.cboJobPosition.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJobPosition.FormattingEnabled = True
        Me.cboJobPosition.Location = New System.Drawing.Point(518, 311)
        Me.cboJobPosition.Name = "cboJobPosition"
        Me.cboJobPosition.Size = New System.Drawing.Size(230, 25)
        Me.cboJobPosition.TabIndex = 12
        '
        'cboEmploymentStatus
        '
        Me.cboEmploymentStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmploymentStatus.FormattingEnabled = True
        Me.cboEmploymentStatus.Location = New System.Drawing.Point(518, 179)
        Me.cboEmploymentStatus.Name = "cboEmploymentStatus"
        Me.cboEmploymentStatus.Size = New System.Drawing.Size(230, 25)
        Me.cboEmploymentStatus.TabIndex = 11
        '
        'txtSalaryRate
        '
        Me.txtSalaryRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSalaryRate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalaryRate.Location = New System.Drawing.Point(32, 243)
        Me.txtSalaryRate.Name = "txtSalaryRate"
        Me.txtSalaryRate.Size = New System.Drawing.Size(209, 19)
        Me.txtSalaryRate.TabIndex = 8
        '
        'cboEmplymentType
        '
        Me.cboEmplymentType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmplymentType.FormattingEnabled = True
        Me.cboEmplymentType.Location = New System.Drawing.Point(270, 179)
        Me.cboEmplymentType.Name = "cboEmplymentType"
        Me.cboEmplymentType.Size = New System.Drawing.Size(228, 25)
        Me.cboEmplymentType.TabIndex = 7
        '
        'txtEmployeeIDNumber
        '
        Me.txtEmployeeIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmployeeIDNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeIDNumber.Location = New System.Drawing.Point(32, 182)
        Me.txtEmployeeIDNumber.Name = "txtEmployeeIDNumber"
        Me.txtEmployeeIDNumber.Size = New System.Drawing.Size(209, 19)
        Me.txtEmployeeIDNumber.TabIndex = 6
        '
        'pnlPersonalInformation
        '
        Me.pnlPersonalInformation.BackColor = System.Drawing.Color.Transparent
        Me.pnlPersonalInformation.BackgroundImage = CType(resources.GetObject("pnlPersonalInformation.BackgroundImage"), System.Drawing.Image)
        Me.pnlPersonalInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlPersonalInformation.Controls.Add(Me.btnChooseImage)
        Me.pnlPersonalInformation.Controls.Add(Me.picEmployeeProfilePicture)
        Me.pnlPersonalInformation.Controls.Add(Me.txtEmployeeAddress)
        Me.pnlPersonalInformation.Controls.Add(Me.txtEmployeeContactNumber)
        Me.pnlPersonalInformation.Controls.Add(Me.rbGenderFemale)
        Me.pnlPersonalInformation.Controls.Add(Me.rbGenderMale)
        Me.pnlPersonalInformation.Controls.Add(Me.cboCivilStatus)
        Me.pnlPersonalInformation.Controls.Add(Me.txtAge)
        Me.pnlPersonalInformation.Controls.Add(Me.dtpBirthdate)
        Me.pnlPersonalInformation.Controls.Add(Me.txtMiddleName)
        Me.pnlPersonalInformation.Controls.Add(Me.txtFirstName)
        Me.pnlPersonalInformation.Controls.Add(Me.txtLastName)
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(0, 0)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(754, 533)
        Me.pnlPersonalInformation.TabIndex = 1
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseImage.FlatAppearance.BorderSize = 0
        Me.btnChooseImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChooseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseImage.Location = New System.Drawing.Point(567, 369)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(100, 20)
        Me.btnChooseImage.TabIndex = 11
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'picEmployeeProfilePicture
        '
        Me.picEmployeeProfilePicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.picEmployeeProfilePicture.Image = CType(resources.GetObject("picEmployeeProfilePicture.Image"), System.Drawing.Image)
        Me.picEmployeeProfilePicture.Location = New System.Drawing.Point(567, 249)
        Me.picEmployeeProfilePicture.Name = "picEmployeeProfilePicture"
        Me.picEmployeeProfilePicture.Size = New System.Drawing.Size(100, 100)
        Me.picEmployeeProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmployeeProfilePicture.TabIndex = 10
        Me.picEmployeeProfilePicture.TabStop = False
        '
        'txtEmployeeAddress
        '
        Me.txtEmployeeAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmployeeAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeAddress.Location = New System.Drawing.Point(32, 436)
        Me.txtEmployeeAddress.Name = "txtEmployeeAddress"
        Me.txtEmployeeAddress.Size = New System.Drawing.Size(706, 19)
        Me.txtEmployeeAddress.TabIndex = 9
        '
        'txtEmployeeContactNumber
        '
        Me.txtEmployeeContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmployeeContactNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeContactNumber.Location = New System.Drawing.Point(32, 375)
        Me.txtEmployeeContactNumber.Name = "txtEmployeeContactNumber"
        Me.txtEmployeeContactNumber.Size = New System.Drawing.Size(209, 19)
        Me.txtEmployeeContactNumber.TabIndex = 8
        '
        'rbGenderFemale
        '
        Me.rbGenderFemale.AutoSize = True
        Me.rbGenderFemale.Location = New System.Drawing.Point(364, 319)
        Me.rbGenderFemale.Name = "rbGenderFemale"
        Me.rbGenderFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbGenderFemale.TabIndex = 7
        Me.rbGenderFemale.TabStop = True
        Me.rbGenderFemale.Text = "Female"
        Me.rbGenderFemale.UseVisualStyleBackColor = True
        '
        'rbGenderMale
        '
        Me.rbGenderMale.AutoSize = True
        Me.rbGenderMale.Location = New System.Drawing.Point(280, 319)
        Me.rbGenderMale.Name = "rbGenderMale"
        Me.rbGenderMale.Size = New System.Drawing.Size(48, 17)
        Me.rbGenderMale.TabIndex = 6
        Me.rbGenderMale.TabStop = True
        Me.rbGenderMale.Text = "Male"
        Me.rbGenderMale.UseVisualStyleBackColor = True
        '
        'cboCivilStatus
        '
        Me.cboCivilStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCivilStatus.FormattingEnabled = True
        Me.cboCivilStatus.Location = New System.Drawing.Point(24, 311)
        Me.cboCivilStatus.Name = "cboCivilStatus"
        Me.cboCivilStatus.Size = New System.Drawing.Size(227, 25)
        Me.cboCivilStatus.TabIndex = 5
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(280, 243)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(209, 19)
        Me.txtAge.TabIndex = 4
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpBirthdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthdate.Location = New System.Drawing.Point(24, 242)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(227, 23)
        Me.dtpBirthdate.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMiddleName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(528, 182)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(210, 19)
        Me.txtMiddleName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(280, 182)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(209, 19)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(32, 182)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(209, 19)
        Me.txtLastName.TabIndex = 0
        '
        'pnlReviewInformation
        '
        Me.pnlReviewInformation.BackgroundImage = CType(resources.GetObject("pnlReviewInformation.BackgroundImage"), System.Drawing.Image)
        Me.pnlReviewInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlReviewInformation.Controls.Add(Me.btnEdit_EmegencyContact)
        Me.pnlReviewInformation.Controls.Add(Me.btnEdit_BenefitsNumbers)
        Me.pnlReviewInformation.Controls.Add(Me.btnEdit_EmploymentStatus)
        Me.pnlReviewInformation.Controls.Add(Me.btnEdit_PersonalInfo)
        Me.pnlReviewInformation.Controls.Add(Me.lblEContact_Address)
        Me.pnlReviewInformation.Controls.Add(Me.lblEContact_Number)
        Me.pnlReviewInformation.Controls.Add(Me.lblEContact_Relationship)
        Me.pnlReviewInformation.Controls.Add(Me.lblEContact_Name)
        Me.pnlReviewInformation.Controls.Add(Me.lblTINNumber)
        Me.pnlReviewInformation.Controls.Add(Me.lblSSSNumber)
        Me.pnlReviewInformation.Controls.Add(Me.lblPagibigNumber)
        Me.pnlReviewInformation.Controls.Add(Me.lblPhilHealthNumber)
        Me.pnlReviewInformation.Controls.Add(Me.lblJobPosition)
        Me.pnlReviewInformation.Controls.Add(Me.lblContractEnd)
        Me.pnlReviewInformation.Controls.Add(Me.lblDateHired)
        Me.pnlReviewInformation.Controls.Add(Me.lblSalaryRate)
        Me.pnlReviewInformation.Controls.Add(Me.lblEMploymentStatus)
        Me.pnlReviewInformation.Controls.Add(Me.lblEmploymentType)
        Me.pnlReviewInformation.Controls.Add(Me.lblEmployeeIDNumber)
        Me.pnlReviewInformation.Controls.Add(Me.lblEmployeeAddress)
        Me.pnlReviewInformation.Controls.Add(Me.lblGender)
        Me.pnlReviewInformation.Controls.Add(Me.lblContactNumber)
        Me.pnlReviewInformation.Controls.Add(Me.lblCivilStatus)
        Me.pnlReviewInformation.Controls.Add(Me.lblEmployeeAge)
        Me.pnlReviewInformation.Controls.Add(Me.lblMiddleName)
        Me.pnlReviewInformation.Controls.Add(Me.lblFirstName)
        Me.pnlReviewInformation.Controls.Add(Me.lblBirthDate)
        Me.pnlReviewInformation.Controls.Add(Me.lblLastName)
        Me.pnlReviewInformation.Location = New System.Drawing.Point(0, 0)
        Me.pnlReviewInformation.Name = "pnlReviewInformation"
        Me.pnlReviewInformation.Size = New System.Drawing.Size(754, 924)
        Me.pnlReviewInformation.TabIndex = 0
        Me.pnlReviewInformation.Visible = False
        '
        'btnEdit_EmegencyContact
        '
        Me.btnEdit_EmegencyContact.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit_EmegencyContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit_EmegencyContact.FlatAppearance.BorderSize = 0
        Me.btnEdit_EmegencyContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_EmegencyContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_EmegencyContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit_EmegencyContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit_EmegencyContact.ForeColor = System.Drawing.Color.White
        Me.btnEdit_EmegencyContact.Location = New System.Drawing.Point(173, 770)
        Me.btnEdit_EmegencyContact.Name = "btnEdit_EmegencyContact"
        Me.btnEdit_EmegencyContact.Size = New System.Drawing.Size(48, 18)
        Me.btnEdit_EmegencyContact.TabIndex = 27
        Me.btnEdit_EmegencyContact.UseVisualStyleBackColor = False
        '
        'btnEdit_BenefitsNumbers
        '
        Me.btnEdit_BenefitsNumbers.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit_BenefitsNumbers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit_BenefitsNumbers.FlatAppearance.BorderSize = 0
        Me.btnEdit_BenefitsNumbers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_BenefitsNumbers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_BenefitsNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit_BenefitsNumbers.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit_BenefitsNumbers.ForeColor = System.Drawing.Color.White
        Me.btnEdit_BenefitsNumbers.Location = New System.Drawing.Point(155, 621)
        Me.btnEdit_BenefitsNumbers.Name = "btnEdit_BenefitsNumbers"
        Me.btnEdit_BenefitsNumbers.Size = New System.Drawing.Size(48, 18)
        Me.btnEdit_BenefitsNumbers.TabIndex = 26
        Me.btnEdit_BenefitsNumbers.UseVisualStyleBackColor = False
        '
        'btnEdit_EmploymentStatus
        '
        Me.btnEdit_EmploymentStatus.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit_EmploymentStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit_EmploymentStatus.FlatAppearance.BorderSize = 0
        Me.btnEdit_EmploymentStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_EmploymentStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_EmploymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit_EmploymentStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit_EmploymentStatus.ForeColor = System.Drawing.Color.White
        Me.btnEdit_EmploymentStatus.Location = New System.Drawing.Point(165, 416)
        Me.btnEdit_EmploymentStatus.Name = "btnEdit_EmploymentStatus"
        Me.btnEdit_EmploymentStatus.Size = New System.Drawing.Size(48, 18)
        Me.btnEdit_EmploymentStatus.TabIndex = 25
        Me.btnEdit_EmploymentStatus.UseVisualStyleBackColor = False
        '
        'btnEdit_PersonalInfo
        '
        Me.btnEdit_PersonalInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit_PersonalInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit_PersonalInfo.FlatAppearance.BorderSize = 0
        Me.btnEdit_PersonalInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_PersonalInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEdit_PersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit_PersonalInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit_PersonalInfo.ForeColor = System.Drawing.Color.White
        Me.btnEdit_PersonalInfo.Location = New System.Drawing.Point(175, 155)
        Me.btnEdit_PersonalInfo.Name = "btnEdit_PersonalInfo"
        Me.btnEdit_PersonalInfo.Size = New System.Drawing.Size(48, 18)
        Me.btnEdit_PersonalInfo.TabIndex = 24
        Me.btnEdit_PersonalInfo.UseVisualStyleBackColor = False
        '
        'lblEContact_Address
        '
        Me.lblEContact_Address.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Address.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Address.Location = New System.Drawing.Point(25, 877)
        Me.lblEContact_Address.Name = "lblEContact_Address"
        Me.lblEContact_Address.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Address.Size = New System.Drawing.Size(720, 24)
        Me.lblEContact_Address.TabIndex = 23
        Me.lblEContact_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEContact_Number
        '
        Me.lblEContact_Number.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Number.Location = New System.Drawing.Point(520, 821)
        Me.lblEContact_Number.Name = "lblEContact_Number"
        Me.lblEContact_Number.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Number.Size = New System.Drawing.Size(225, 24)
        Me.lblEContact_Number.TabIndex = 22
        Me.lblEContact_Number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEContact_Relationship
        '
        Me.lblEContact_Relationship.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Relationship.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Relationship.Location = New System.Drawing.Point(273, 821)
        Me.lblEContact_Relationship.Name = "lblEContact_Relationship"
        Me.lblEContact_Relationship.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Relationship.Size = New System.Drawing.Size(224, 24)
        Me.lblEContact_Relationship.TabIndex = 21
        Me.lblEContact_Relationship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEContact_Name
        '
        Me.lblEContact_Name.BackColor = System.Drawing.Color.Transparent
        Me.lblEContact_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEContact_Name.Location = New System.Drawing.Point(25, 821)
        Me.lblEContact_Name.Name = "lblEContact_Name"
        Me.lblEContact_Name.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEContact_Name.Size = New System.Drawing.Size(224, 24)
        Me.lblEContact_Name.TabIndex = 20
        Me.lblEContact_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTINNumber
        '
        Me.lblTINNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblTINNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTINNumber.Location = New System.Drawing.Point(25, 728)
        Me.lblTINNumber.Name = "lblTINNumber"
        Me.lblTINNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblTINNumber.Size = New System.Drawing.Size(224, 24)
        Me.lblTINNumber.TabIndex = 19
        Me.lblTINNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSSSNumber
        '
        Me.lblSSSNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSSSNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSSNumber.Location = New System.Drawing.Point(520, 672)
        Me.lblSSSNumber.Name = "lblSSSNumber"
        Me.lblSSSNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblSSSNumber.Size = New System.Drawing.Size(225, 24)
        Me.lblSSSNumber.TabIndex = 18
        Me.lblSSSNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPagibigNumber
        '
        Me.lblPagibigNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPagibigNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagibigNumber.Location = New System.Drawing.Point(273, 672)
        Me.lblPagibigNumber.Name = "lblPagibigNumber"
        Me.lblPagibigNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblPagibigNumber.Size = New System.Drawing.Size(224, 24)
        Me.lblPagibigNumber.TabIndex = 17
        Me.lblPagibigNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPhilHealthNumber
        '
        Me.lblPhilHealthNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhilHealthNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilHealthNumber.Location = New System.Drawing.Point(25, 672)
        Me.lblPhilHealthNumber.Name = "lblPhilHealthNumber"
        Me.lblPhilHealthNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblPhilHealthNumber.Size = New System.Drawing.Size(224, 24)
        Me.lblPhilHealthNumber.TabIndex = 16
        Me.lblPhilHealthNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJobPosition
        '
        Me.lblJobPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblJobPosition.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobPosition.Location = New System.Drawing.Point(520, 579)
        Me.lblJobPosition.Name = "lblJobPosition"
        Me.lblJobPosition.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblJobPosition.Size = New System.Drawing.Size(225, 24)
        Me.lblJobPosition.TabIndex = 15
        Me.lblJobPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContractEnd
        '
        Me.lblContractEnd.BackColor = System.Drawing.Color.Transparent
        Me.lblContractEnd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContractEnd.Location = New System.Drawing.Point(272, 579)
        Me.lblContractEnd.Name = "lblContractEnd"
        Me.lblContractEnd.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblContractEnd.Size = New System.Drawing.Size(224, 24)
        Me.lblContractEnd.TabIndex = 14
        Me.lblContractEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateHired
        '
        Me.lblDateHired.BackColor = System.Drawing.Color.Transparent
        Me.lblDateHired.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateHired.Location = New System.Drawing.Point(25, 579)
        Me.lblDateHired.Name = "lblDateHired"
        Me.lblDateHired.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblDateHired.Size = New System.Drawing.Size(224, 24)
        Me.lblDateHired.TabIndex = 13
        Me.lblDateHired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalaryRate
        '
        Me.lblSalaryRate.BackColor = System.Drawing.Color.Transparent
        Me.lblSalaryRate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryRate.Location = New System.Drawing.Point(25, 523)
        Me.lblSalaryRate.Name = "lblSalaryRate"
        Me.lblSalaryRate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblSalaryRate.Size = New System.Drawing.Size(224, 24)
        Me.lblSalaryRate.TabIndex = 12
        Me.lblSalaryRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEMploymentStatus
        '
        Me.lblEMploymentStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblEMploymentStatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEMploymentStatus.Location = New System.Drawing.Point(520, 467)
        Me.lblEMploymentStatus.Name = "lblEMploymentStatus"
        Me.lblEMploymentStatus.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEMploymentStatus.Size = New System.Drawing.Size(225, 24)
        Me.lblEMploymentStatus.TabIndex = 11
        Me.lblEMploymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmploymentType
        '
        Me.lblEmploymentType.BackColor = System.Drawing.Color.Transparent
        Me.lblEmploymentType.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmploymentType.Location = New System.Drawing.Point(273, 467)
        Me.lblEmploymentType.Name = "lblEmploymentType"
        Me.lblEmploymentType.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmploymentType.Size = New System.Drawing.Size(224, 24)
        Me.lblEmploymentType.TabIndex = 10
        Me.lblEmploymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeIDNumber
        '
        Me.lblEmployeeIDNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeIDNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeIDNumber.Location = New System.Drawing.Point(26, 467)
        Me.lblEmployeeIDNumber.Name = "lblEmployeeIDNumber"
        Me.lblEmployeeIDNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmployeeIDNumber.Size = New System.Drawing.Size(224, 24)
        Me.lblEmployeeIDNumber.TabIndex = 9
        Me.lblEmployeeIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeAddress
        '
        Me.lblEmployeeAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAddress.Location = New System.Drawing.Point(25, 374)
        Me.lblEmployeeAddress.Name = "lblEmployeeAddress"
        Me.lblEmployeeAddress.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmployeeAddress.Size = New System.Drawing.Size(721, 24)
        Me.lblEmployeeAddress.TabIndex = 8
        Me.lblEmployeeAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(272, 318)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblGender.Size = New System.Drawing.Size(224, 24)
        Me.lblGender.TabIndex = 7
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactNumber
        '
        Me.lblContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblContactNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(25, 318)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblContactNumber.Size = New System.Drawing.Size(224, 24)
        Me.lblContactNumber.TabIndex = 6
        Me.lblContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblCivilStatus.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCivilStatus.Location = New System.Drawing.Point(520, 262)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblCivilStatus.Size = New System.Drawing.Size(226, 24)
        Me.lblCivilStatus.TabIndex = 5
        Me.lblCivilStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeAge
        '
        Me.lblEmployeeAge.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeAge.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeAge.Location = New System.Drawing.Point(273, 262)
        Me.lblEmployeeAge.Name = "lblEmployeeAge"
        Me.lblEmployeeAge.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblEmployeeAge.Size = New System.Drawing.Size(224, 24)
        Me.lblEmployeeAge.TabIndex = 4
        Me.lblEmployeeAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMiddleName
        '
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(520, 206)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblMiddleName.Size = New System.Drawing.Size(226, 24)
        Me.lblMiddleName.TabIndex = 3
        Me.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(273, 206)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblFirstName.Size = New System.Drawing.Size(224, 24)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBirthDate
        '
        Me.lblBirthDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(25, 262)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblBirthDate.Size = New System.Drawing.Size(224, 24)
        Me.lblBirthDate.TabIndex = 1
        Me.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(25, 206)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Padding = New System.Windows.Forms.Padding(5, 0, 0, 5)
        Me.lblLastName.Size = New System.Drawing.Size(224, 24)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlMoveForm
        '
        Me.pnlMoveForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.pnlMoveForm.Controls.Add(Me.btnMinimize)
        Me.pnlMoveForm.Controls.Add(Me.lblFormName)
        Me.pnlMoveForm.Controls.Add(Me.btnExit)
        Me.pnlMoveForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMoveForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlMoveForm.Name = "pnlMoveForm"
        Me.pnlMoveForm.Size = New System.Drawing.Size(817, 30)
        Me.pnlMoveForm.TabIndex = 15
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(715, -1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(50, 31)
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.BackColor = System.Drawing.Color.Transparent
        Me.lblFormName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.ForeColor = System.Drawing.Color.White
        Me.lblFormName.Location = New System.Drawing.Point(15, 6)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(162, 19)
        Me.lblFormName.TabIndex = 10
        Me.lblFormName.Text = "ADD NEW EMPLOYEE"
        Me.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(768, -1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(50, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(677, 615)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(88, 28)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Gray
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(51, 615)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(88, 28)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(850, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Form size: 820, 684"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(850, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Panels Location: 1,1"
        '
        'frmNewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(817, 682)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pnlMoveForm)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNewEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMain.ResumeLayout(False)
        Me.pnlEmergencyContact.ResumeLayout(False)
        Me.pnlEmergencyContact.PerformLayout()
        Me.pnlBenefitsNumbers.ResumeLayout(False)
        Me.pnlBenefitsNumbers.PerformLayout()
        Me.pnlEmploymentStatus.ResumeLayout(False)
        Me.pnlEmploymentStatus.PerformLayout()
        Me.pnlPersonalInformation.ResumeLayout(False)
        Me.pnlPersonalInformation.PerformLayout()
        CType(Me.picEmployeeProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReviewInformation.ResumeLayout(False)
        Me.pnlMoveForm.ResumeLayout(False)
        Me.pnlMoveForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlReviewInformation As System.Windows.Forms.Panel
    Friend WithEvents pnlMoveForm As System.Windows.Forms.Panel
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents lblFormName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents pnlPersonalInformation As System.Windows.Forms.Panel
    Friend WithEvents pnlEmploymentStatus As System.Windows.Forms.Panel
    Friend WithEvents pnlBenefitsNumbers As System.Windows.Forms.Panel
    Friend WithEvents pnlEmergencyContact As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents cboCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents rbGenderMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbGenderFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtEmployeeContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeAddress As System.Windows.Forms.TextBox
    Friend WithEvents picEmployeeProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents cboEmplymentType As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmployeeIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSalaryRate As System.Windows.Forms.TextBox
    Friend WithEvents cboEmploymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboJobPosition As System.Windows.Forms.ComboBox
    Friend WithEvents txtSSSNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPagibigNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPhilHealthNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTINNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtEContact_Address As System.Windows.Forms.TextBox
    Friend WithEvents txtEContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtEContact_Relationship As System.Windows.Forms.TextBox
    Friend WithEvents txtEContact_Name As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateHired As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpContractEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeAge As System.Windows.Forms.Label
    Friend WithEvents lblCivilStatus As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeIDNumber As System.Windows.Forms.Label
    Friend WithEvents lblEmploymentType As System.Windows.Forms.Label
    Friend WithEvents lblEMploymentStatus As System.Windows.Forms.Label
    Friend WithEvents lblSalaryRate As System.Windows.Forms.Label
    Friend WithEvents lblDateHired As System.Windows.Forms.Label
    Friend WithEvents lblContractEnd As System.Windows.Forms.Label
    Friend WithEvents lblJobPosition As System.Windows.Forms.Label
    Friend WithEvents lblPhilHealthNumber As System.Windows.Forms.Label
    Friend WithEvents lblPagibigNumber As System.Windows.Forms.Label
    Friend WithEvents lblSSSNumber As System.Windows.Forms.Label
    Friend WithEvents lblTINNumber As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Address As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Number As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Relationship As System.Windows.Forms.Label
    Friend WithEvents lblEContact_Name As System.Windows.Forms.Label
    Friend WithEvents btnEdit_PersonalInfo As System.Windows.Forms.Button
    Friend WithEvents btnEdit_EmploymentStatus As System.Windows.Forms.Button
    Friend WithEvents btnEdit_BenefitsNumbers As System.Windows.Forms.Button
    Friend WithEvents btnEdit_EmegencyContact As System.Windows.Forms.Button
End Class
