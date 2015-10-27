<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAssesmentForm
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
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim UniversityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentAssesmentForm))
        Me.TabMainMenu = New System.Windows.Forms.TabControl()
        Me.TabGrading = New System.Windows.Forms.TabPage()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCreateReport = New System.Windows.Forms.Button()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.tbFeedback = New System.Windows.Forms.TextBox()
        Me.tbMark = New System.Windows.Forms.TextBox()
        Me.tbTPNumber = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbModule = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabUserProfile = New System.Windows.Forms.TabPage()
        Me.UniversityTextBox = New System.Windows.Forms.TextBox()
        Me.UserProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SGMSDataSet = New CSS_Assignment_SGMS.SGMSDataSet()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabChangePass = New System.Windows.Forms.TabPage()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tbConfirmPass = New System.Windows.Forms.TextBox()
        Me.tbNewPass = New System.Windows.Forms.TextBox()
        Me.tbOldPass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tbSubmit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.UserProfileTableAdapter = New CSS_Assignment_SGMS.SGMSDataSetTableAdapters.UserProfileTableAdapter()
        Me.TableAdapterManager = New CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager()
        Me.UserProfileBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserProfileBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        NameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        UniversityLabel = New System.Windows.Forms.Label()
        Me.TabMainMenu.SuspendLayout()
        Me.TabGrading.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabUserProfile.SuspendLayout()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SGMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabChangePass.SuspendLayout()
        CType(Me.UserProfileBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserProfileBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(105, 111)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(105, 143)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(105, 178)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 6
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'UniversityLabel
        '
        UniversityLabel.AutoSize = True
        UniversityLabel.Location = New System.Drawing.Point(105, 212)
        UniversityLabel.Name = "UniversityLabel"
        UniversityLabel.Size = New System.Drawing.Size(56, 13)
        UniversityLabel.TabIndex = 8
        UniversityLabel.Text = "University:"
        '
        'TabMainMenu
        '
        Me.TabMainMenu.Controls.Add(Me.TabGrading)
        Me.TabMainMenu.Controls.Add(Me.TabUserProfile)
        Me.TabMainMenu.Controls.Add(Me.TabChangePass)
        Me.TabMainMenu.Location = New System.Drawing.Point(12, 33)
        Me.TabMainMenu.Name = "TabMainMenu"
        Me.TabMainMenu.SelectedIndex = 0
        Me.TabMainMenu.Size = New System.Drawing.Size(487, 387)
        Me.TabMainMenu.TabIndex = 7
        '
        'TabGrading
        '
        Me.TabGrading.Controls.Add(Me.btnBack)
        Me.TabGrading.Controls.Add(Me.DataGridView1)
        Me.TabGrading.Controls.Add(Me.btnCreateReport)
        Me.TabGrading.Controls.Add(Me.btnSendEmail)
        Me.TabGrading.Controls.Add(Me.btnAdd)
        Me.TabGrading.Controls.Add(Me.btnDelete)
        Me.TabGrading.Controls.Add(Me.btnUpdate)
        Me.TabGrading.Controls.Add(Me.tbEmail)
        Me.TabGrading.Controls.Add(Me.tbFeedback)
        Me.TabGrading.Controls.Add(Me.tbMark)
        Me.TabGrading.Controls.Add(Me.tbTPNumber)
        Me.TabGrading.Controls.Add(Me.tbName)
        Me.TabGrading.Controls.Add(Me.Label6)
        Me.TabGrading.Controls.Add(Me.Label5)
        Me.TabGrading.Controls.Add(Me.Label4)
        Me.TabGrading.Controls.Add(Me.Label3)
        Me.TabGrading.Controls.Add(Me.Label2)
        Me.TabGrading.Controls.Add(Me.cbModule)
        Me.TabGrading.Controls.Add(Me.Label1)
        Me.TabGrading.Location = New System.Drawing.Point(4, 22)
        Me.TabGrading.Name = "TabGrading"
        Me.TabGrading.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGrading.Size = New System.Drawing.Size(479, 361)
        Me.TabGrading.TabIndex = 0
        Me.TabGrading.Text = "Grading"
        Me.TabGrading.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(6, 9)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "< -- back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(211, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 24
        '
        'btnCreateReport
        '
        Me.btnCreateReport.Location = New System.Drawing.Point(121, 325)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateReport.TabIndex = 23
        Me.btnCreateReport.Text = "Create Report"
        Me.btnCreateReport.UseVisualStyleBackColor = True
        '
        'btnSendEmail
        '
        Me.btnSendEmail.Location = New System.Drawing.Point(7, 325)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnSendEmail.TabIndex = 22
        Me.btnSendEmail.Text = "Send Email"
        Me.btnSendEmail.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(7, 296)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(189, 23)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add New Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(121, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(7, 267)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(63, 238)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(133, 20)
        Me.tbEmail.TabIndex = 17
        '
        'tbFeedback
        '
        Me.tbFeedback.Location = New System.Drawing.Point(63, 202)
        Me.tbFeedback.Name = "tbFeedback"
        Me.tbFeedback.Size = New System.Drawing.Size(133, 20)
        Me.tbFeedback.TabIndex = 18
        '
        'tbMark
        '
        Me.tbMark.Location = New System.Drawing.Point(63, 170)
        Me.tbMark.Name = "tbMark"
        Me.tbMark.Size = New System.Drawing.Size(133, 20)
        Me.tbMark.TabIndex = 16
        '
        'tbTPNumber
        '
        Me.tbTPNumber.Location = New System.Drawing.Point(63, 134)
        Me.tbTPNumber.Name = "tbTPNumber"
        Me.tbTPNumber.Size = New System.Drawing.Size(133, 20)
        Me.tbTPNumber.TabIndex = 15
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(63, 97)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(133, 20)
        Me.tbName.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Feedback"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "TP Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'cbModule
        '
        Me.cbModule.FormattingEnabled = True
        Me.cbModule.Location = New System.Drawing.Point(143, 50)
        Me.cbModule.Name = "cbModule"
        Me.cbModule.Size = New System.Drawing.Size(121, 21)
        Me.cbModule.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Module Name : "
        '
        'TabUserProfile
        '
        Me.TabUserProfile.Controls.Add(UniversityLabel)
        Me.TabUserProfile.Controls.Add(Me.UniversityTextBox)
        Me.TabUserProfile.Controls.Add(PhoneNumberLabel)
        Me.TabUserProfile.Controls.Add(Me.PhoneNumberTextBox)
        Me.TabUserProfile.Controls.Add(EmailLabel)
        Me.TabUserProfile.Controls.Add(Me.EmailTextBox)
        Me.TabUserProfile.Controls.Add(NameLabel)
        Me.TabUserProfile.Controls.Add(Me.NameTextBox)
        Me.TabUserProfile.Controls.Add(Me.btnModify)
        Me.TabUserProfile.Controls.Add(Me.Label7)
        Me.TabUserProfile.Location = New System.Drawing.Point(4, 22)
        Me.TabUserProfile.Name = "TabUserProfile"
        Me.TabUserProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUserProfile.Size = New System.Drawing.Size(479, 361)
        Me.TabUserProfile.TabIndex = 1
        Me.TabUserProfile.Text = "User Profile"
        Me.TabUserProfile.UseVisualStyleBackColor = True
        '
        'UniversityTextBox
        '
        Me.UniversityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource, "University", True))
        Me.UniversityTextBox.Location = New System.Drawing.Point(193, 209)
        Me.UniversityTextBox.Name = "UniversityTextBox"
        Me.UniversityTextBox.Size = New System.Drawing.Size(176, 20)
        Me.UniversityTextBox.TabIndex = 9
        '
        'UserProfileBindingSource
        '
        Me.UserProfileBindingSource.DataMember = "UserProfile"
        Me.UserProfileBindingSource.DataSource = Me.SGMSDataSet
        '
        'SGMSDataSet
        '
        Me.SGMSDataSet.DataSetName = "SGMSDataSet"
        Me.SGMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(193, 175)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(176, 20)
        Me.PhoneNumberTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(193, 143)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(176, 20)
        Me.EmailTextBox.TabIndex = 5
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserProfileBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(193, 108)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(176, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(225, 261)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(75, 23)
        Me.btnModify.TabIndex = 3
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(155, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "User Detail Information"
        '
        'TabChangePass
        '
        Me.TabChangePass.Controls.Add(Me.TextBox4)
        Me.TabChangePass.Controls.Add(Me.tbConfirmPass)
        Me.TabChangePass.Controls.Add(Me.tbNewPass)
        Me.TabChangePass.Controls.Add(Me.tbOldPass)
        Me.TabChangePass.Controls.Add(Me.Label11)
        Me.TabChangePass.Controls.Add(Me.Label10)
        Me.TabChangePass.Controls.Add(Me.Label9)
        Me.TabChangePass.Controls.Add(Me.btnCancel)
        Me.TabChangePass.Controls.Add(Me.tbSubmit)
        Me.TabChangePass.Location = New System.Drawing.Point(4, 22)
        Me.TabChangePass.Name = "TabChangePass"
        Me.TabChangePass.Padding = New System.Windows.Forms.Padding(3)
        Me.TabChangePass.Size = New System.Drawing.Size(479, 361)
        Me.TabChangePass.TabIndex = 2
        Me.TabChangePass.Text = "Change Password"
        Me.TabChangePass.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(94, 200)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(314, 89)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "Captcha Here"
        '
        'tbConfirmPass
        '
        Me.tbConfirmPass.Location = New System.Drawing.Point(200, 158)
        Me.tbConfirmPass.Name = "tbConfirmPass"
        Me.tbConfirmPass.Size = New System.Drawing.Size(208, 20)
        Me.tbConfirmPass.TabIndex = 4
        '
        'tbNewPass
        '
        Me.tbNewPass.Location = New System.Drawing.Point(200, 104)
        Me.tbNewPass.Name = "tbNewPass"
        Me.tbNewPass.Size = New System.Drawing.Size(208, 20)
        Me.tbNewPass.TabIndex = 4
        '
        'tbOldPass
        '
        Me.tbOldPass.Location = New System.Drawing.Point(200, 58)
        Me.tbOldPass.Name = "tbOldPass"
        Me.tbOldPass.Size = New System.Drawing.Size(208, 20)
        Me.tbOldPass.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(91, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Confirm Password :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Input New Password :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(88, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Input Old Password :"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(271, 310)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tbSubmit
        '
        Me.tbSubmit.Location = New System.Drawing.Point(141, 310)
        Me.tbSubmit.Name = "tbSubmit"
        Me.tbSubmit.Size = New System.Drawing.Size(75, 23)
        Me.tbSubmit.TabIndex = 0
        Me.tbSubmit.Text = "Submit"
        Me.tbSubmit.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(417, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'UserProfileTableAdapter
        '
        Me.UserProfileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserProfileTableAdapter = Me.UserProfileTableAdapter
        '
        'UserProfileBindingNavigator
        '
        Me.UserProfileBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserProfileBindingNavigator.BindingSource = Me.UserProfileBindingSource
        Me.UserProfileBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserProfileBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserProfileBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserProfileBindingNavigatorSaveItem})
        Me.UserProfileBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserProfileBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserProfileBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserProfileBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserProfileBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserProfileBindingNavigator.Name = "UserProfileBindingNavigator"
        Me.UserProfileBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserProfileBindingNavigator.Size = New System.Drawing.Size(519, 25)
        Me.UserProfileBindingNavigator.TabIndex = 9
        Me.UserProfileBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UserProfileBindingNavigatorSaveItem
        '
        Me.UserProfileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserProfileBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserProfileBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserProfileBindingNavigatorSaveItem.Name = "UserProfileBindingNavigatorSaveItem"
        Me.UserProfileBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserProfileBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentAssesmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 447)
        Me.Controls.Add(Me.UserProfileBindingNavigator)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.TabMainMenu)
        Me.Name = "StudentAssesmentForm"
        Me.Text = "Student Assesment Form"
        Me.TabMainMenu.ResumeLayout(False)
        Me.TabGrading.ResumeLayout(False)
        Me.TabGrading.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabUserProfile.ResumeLayout(False)
        Me.TabUserProfile.PerformLayout()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SGMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabChangePass.ResumeLayout(False)
        Me.TabChangePass.PerformLayout()
        CType(Me.UserProfileBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserProfileBindingNavigator.ResumeLayout(False)
        Me.UserProfileBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabMainMenu As System.Windows.Forms.TabControl
    Friend WithEvents TabGrading As System.Windows.Forms.TabPage
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCreateReport As System.Windows.Forms.Button
    Friend WithEvents btnSendEmail As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents tbFeedback As System.Windows.Forms.TextBox
    Friend WithEvents tbMark As System.Windows.Forms.TextBox
    Friend WithEvents tbTPNumber As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbModule As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabUserProfile As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabChangePass As System.Windows.Forms.TabPage
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents tbConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents tbNewPass As System.Windows.Forms.TextBox
    Friend WithEvents tbOldPass As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tbSubmit As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents SGMSDataSet As CSS_Assignment_SGMS.SGMSDataSet
    Friend WithEvents UserProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserProfileTableAdapter As CSS_Assignment_SGMS.SGMSDataSetTableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager As CSS_Assignment_SGMS.SGMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserProfileBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserProfileBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UniversityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
End Class
