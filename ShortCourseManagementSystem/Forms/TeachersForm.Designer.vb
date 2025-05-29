<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeachersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtEmail = New CustomControls.RJControls.RJTextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnChooseStudent = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDob = New CustomControls.RJControls.RJDatePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPOB = New CustomControls.RJControls.RJTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhone = New CustomControls.RJControls.RJTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEngName = New CustomControls.RJControls.RJTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKhName = New CustomControls.RJControls.RJTextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Panel15)
        Me.Panel2.Controls.Add(Me.btnChooseStudent)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnRegister)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.picStudent)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1710, 434)
        Me.Panel2.TabIndex = 3
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel15.Controls.Add(Me.Label29)
        Me.Panel15.Controls.Add(Me.txtEmail)
        Me.Panel15.Controls.Add(Me.Label32)
        Me.Panel15.Location = New System.Drawing.Point(58, 172)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(480, 42)
        Me.Panel15.TabIndex = 72
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(96, 6)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 27)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = ":"
        '
        'txtEmail
        '
        Me.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmail.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtEmail.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.txtEmail.BorderRadius = 3
        Me.txtEmail.BorderSize = 2
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtEmail.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(157, 0)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtEmail.PasswordChar = False
        Me.txtEmail.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtEmail.PlaceholderText = "example@gmail.com"
        Me.txtEmail.Size = New System.Drawing.Size(323, 42)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.Texts = ""
        Me.txtEmail.UnderlinedStyle = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label32.Location = New System.Drawing.Point(8, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 27)
        Me.Label32.TabIndex = 51
        Me.Label32.Text = "Email"
        '
        'btnChooseStudent
        '
        Me.btnChooseStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChooseStudent.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseStudent.Location = New System.Drawing.Point(815, 360)
        Me.btnChooseStudent.Name = "btnChooseStudent"
        Me.btnChooseStudent.Size = New System.Drawing.Size(151, 44)
        Me.btnChooseStudent.TabIndex = 71
        Me.btnChooseStudent.Text = "Choose Student"
        Me.btnChooseStudent.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1006, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 44)
        Me.btnClear.TabIndex = 68
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegister.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(618, 360)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(151, 44)
        Me.btnRegister.TabIndex = 68
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.dtpDob)
        Me.Panel8.Location = New System.Drawing.Point(58, 116)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(480, 41)
        Me.Panel8.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(105, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 27)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 27)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        '
        'dtpDob
        '
        Me.dtpDob.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.dtpDob.BorderSize = 0
        Me.dtpDob.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDob.Location = New System.Drawing.Point(157, 3)
        Me.dtpDob.MinimumSize = New System.Drawing.Size(4, 35)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(323, 35)
        Me.dtpDob.SkinColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpDob.TabIndex = 14
        Me.dtpDob.TextColor = System.Drawing.Color.Black
        Me.dtpDob.Value = New Date(2005, 12, 30, 0, 0, 0, 0)
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.txtPOB)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Location = New System.Drawing.Point(589, 116)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(480, 41)
        Me.Panel7.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(111, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 27)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = ":"
        '
        'txtPOB
        '
        Me.txtPOB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtPOB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPOB.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPOB.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtPOB.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.txtPOB.BorderRadius = 3
        Me.txtPOB.BorderSize = 2
        Me.txtPOB.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPOB.Location = New System.Drawing.Point(157, -1)
        Me.txtPOB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPOB.Multiline = False
        Me.txtPOB.Name = "txtPOB"
        Me.txtPOB.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPOB.PasswordChar = False
        Me.txtPOB.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtPOB.PlaceholderText = "PlaceOfBirth"
        Me.txtPOB.Size = New System.Drawing.Size(323, 42)
        Me.txtPOB.TabIndex = 55
        Me.txtPOB.Texts = ""
        Me.txtPOB.UnderlinedStyle = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 27)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "ទីកន្លែងកំណើត"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtPhone)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(1118, 115)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 42)
        Me.Panel4.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        '
        'txtPhone
        '
        Me.txtPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPhone.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtPhone.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.txtPhone.BorderRadius = 3
        Me.txtPhone.BorderSize = 2
        Me.txtPhone.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtPhone.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(113, 0)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Multiline = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPhone.PasswordChar = False
        Me.txtPhone.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtPhone.PlaceholderText = "PhoneNumber"
        Me.txtPhone.Size = New System.Drawing.Size(165, 42)
        Me.txtPhone.TabIndex = 2
        Me.txtPhone.Texts = ""
        Me.txtPhone.UnderlinedStyle = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(8, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 27)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "លេខទូរស័ព្ទ"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.txtEngName)
        Me.Panel6.Location = New System.Drawing.Point(589, 64)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(480, 41)
        Me.Panel6.TabIndex = 61
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 27)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "ឈ្មោះឡាតាំង"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(96, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 27)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = ":"
        '
        'txtEngName
        '
        Me.txtEngName.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtEngName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEngName.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtEngName.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.txtEngName.BorderRadius = 3
        Me.txtEngName.BorderSize = 2
        Me.txtEngName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtEngName.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEngName.Location = New System.Drawing.Point(157, 0)
        Me.txtEngName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEngName.Multiline = False
        Me.txtEngName.Name = "txtEngName"
        Me.txtEngName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtEngName.PasswordChar = False
        Me.txtEngName.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtEngName.PlaceholderText = "EnglishName"
        Me.txtEngName.Size = New System.Drawing.Size(323, 42)
        Me.txtEngName.TabIndex = 2
        Me.txtEngName.Texts = ""
        Me.txtEngName.UnderlinedStyle = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtKhName)
        Me.Panel5.Location = New System.Drawing.Point(58, 64)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(480, 41)
        Me.Panel5.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ឈ្មោះខ្មែរ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'txtKhName
        '
        Me.txtKhName.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtKhName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtKhName.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtKhName.BorderFocusColor = System.Drawing.Color.CornflowerBlue
        Me.txtKhName.BorderRadius = 3
        Me.txtKhName.BorderSize = 2
        Me.txtKhName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtKhName.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtKhName.Location = New System.Drawing.Point(157, 0)
        Me.txtKhName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKhName.Multiline = False
        Me.txtKhName.Name = "txtKhName"
        Me.txtKhName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtKhName.PasswordChar = False
        Me.txtKhName.PlaceholderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtKhName.PlaceholderText = "Khmer Name"
        Me.txtKhName.Size = New System.Drawing.Size(323, 42)
        Me.txtKhName.TabIndex = 2
        Me.txtKhName.Texts = ""
        Me.txtKhName.UnderlinedStyle = True
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(1511, 290)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(136, 32)
        Me.IconButton1.TabIndex = 59
        Me.IconButton1.Text = "Choose Image"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tlok", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(818, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(152, 29)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "TeacherForm"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.cbGender)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(1118, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(278, 40)
        Me.Panel3.TabIndex = 57
        '
        'cbGender
        '
        Me.cbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"ប្រុស", "ស្រី"})
        Me.cbGender.Location = New System.Drawing.Point(113, 2)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(162, 35)
        Me.cbGender.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(11, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ភេទ"
        '
        'picStudent
        '
        Me.picStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Location = New System.Drawing.Point(1506, 64)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(146, 209)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 50
        Me.picStudent.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(137, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = ":"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel13.Controls.Add(Me.DataGridView2)
        Me.Panel13.Controls.Add(Me.Label26)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(5, 444)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1710, 528)
        Me.Panel13.TabIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView2.Location = New System.Drawing.Point(53, 75)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.RowHeadersWidth = 35
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.RowTemplate.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1604, 432)
        Me.DataGridView2.TabIndex = 61
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Khmer OS Moul Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label26.Location = New System.Drawing.Point(767, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 29)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "បញ្ជីគ្រួ"
        '
        'TeachersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1720, 982)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeachersForm"
        Me.Padding = New System.Windows.Forms.Padding(5, 2, 5, 10)
        Me.Text = "Student"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKhName As CustomControls.RJControls.RJTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDob As CustomControls.RJControls.RJDatePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents picStudent As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPOB As CustomControls.RJControls.RJTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEngName As CustomControls.RJControls.RJTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As CustomControls.RJControls.RJTextBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnChooseStudent As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents txtEmail As CustomControls.RJControls.RJTextBox
    Friend WithEvents Label32 As Label
End Class
