<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEngName = New CustomControls.RJControls.RJTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKhName = New CustomControls.RJControls.RJTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenPic = New System.Windows.Forms.OpenFileDialog()
        Me.txtPhone = New CustomControls.RJControls.RJTextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dtpDob = New CustomControls.RJControls.RJDatePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cbAddress = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnChooseImage = New FontAwesome.Sharp.IconButton()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbSearchAddress = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New CustomControls.RJControls.RJTextBox()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
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
        Me.txtEngName.TabIndex = 1
        Me.txtEngName.Texts = ""
        Me.txtEngName.UnderlinedStyle = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
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
        Me.Label2.Size = New System.Drawing.Size(48, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ឈ្មោះ"
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
        Me.txtKhName.TabIndex = 0
        Me.txtKhName.Texts = ""
        Me.txtKhName.UnderlinedStyle = True
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Khmer OS Moul", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(741, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 29)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "ព័ត៌មានសិស្ស"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
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
        'OpenPic
        '
        Me.OpenPic.FileName = "OpenFileDialog1"
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
        Me.txtPhone.TabIndex = 5
        Me.txtPhone.Texts = ""
        Me.txtPhone.UnderlinedStyle = True
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel13.Controls.Add(Me.DataGridView1)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(15, 371)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1674, 557)
        Me.Panel13.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1674, 557)
        Me.DataGridView1.TabIndex = 60
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btnChooseImage)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.picStudent)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1674, 292)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(867, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 41)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "បោះបង់"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(637, 232)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(151, 44)
        Me.btnEdit.TabIndex = 84
        Me.btnEdit.Text = "រក្សាទុក"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.dtpDob)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Location = New System.Drawing.Point(58, 116)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(480, 41)
        Me.Panel8.TabIndex = 64
        '
        'dtpDob
        '
        Me.dtpDob.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.dtpDob.BorderSize = 0
        Me.dtpDob.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDob.Location = New System.Drawing.Point(154, 3)
        Me.dtpDob.MinimumSize = New System.Drawing.Size(4, 35)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(323, 35)
        Me.dtpDob.SkinColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpDob.TabIndex = 3
        Me.dtpDob.TextColor = System.Drawing.Color.Black
        Me.dtpDob.Value = New Date(2005, 12, 30, 0, 0, 0, 0)
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
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.cbAddress)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Location = New System.Drawing.Point(589, 116)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(480, 41)
        Me.Panel7.TabIndex = 63
        '
        'cbAddress
        '
        Me.cbAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAddress.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!)
        Me.cbAddress.FormattingEnabled = True
        Me.cbAddress.Location = New System.Drawing.Point(157, 2)
        Me.cbAddress.Name = "cbAddress"
        Me.cbAddress.Size = New System.Drawing.Size(323, 35)
        Me.cbAddress.TabIndex = 86
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 27)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "អាស័យដ្ឋាន"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtPhone)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(1118, 115)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(278, 42)
        Me.Panel4.TabIndex = 62
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
        'btnChooseImage
        '
        Me.btnChooseImage.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImage.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnChooseImage.IconColor = System.Drawing.Color.Black
        Me.btnChooseImage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnChooseImage.Location = New System.Drawing.Point(1521, 182)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(117, 32)
        Me.btnChooseImage.TabIndex = 59
        Me.btnChooseImage.Text = "ជ្រើសរើសរូបភាព"
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'picStudent
        '
        Me.picStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Location = New System.Drawing.Point(1521, 3)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(117, 168)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 50
        Me.picStudent.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbSearchAddress)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1674, 64)
        Me.Panel1.TabIndex = 7
        '
        'cbSearchAddress
        '
        Me.cbSearchAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbSearchAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchAddress.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!)
        Me.cbSearchAddress.FormattingEnabled = True
        Me.cbSearchAddress.Location = New System.Drawing.Point(372, 12)
        Me.cbSearchAddress.Name = "cbSearchAddress"
        Me.cbSearchAddress.Size = New System.Drawing.Size(150, 35)
        Me.cbSearchAddress.TabIndex = 87
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(546, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 41)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "សម្អាត"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.BorderRadius = 10
        Me.txtSearch.BorderSize = 2
        Me.txtSearch.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(14, 9)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtSearch.PasswordChar = False
        Me.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtSearch.PlaceholderText = "ស្វែងរកតាមរយៈ ឈ្មោះ ឬ ID "
        Me.txtSearch.Size = New System.Drawing.Size(340, 39)
        Me.txtSearch.TabIndex = 35
        Me.txtSearch.Texts = ""
        Me.txtSearch.UnderlinedStyle = False
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1704, 943)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "StudentForm"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "StudentForm"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEngName As CustomControls.RJControls.RJTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKhName As CustomControls.RJControls.RJTextBox
    Friend WithEvents btnChooseImage As FontAwesome.Sharp.IconButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents picStudent As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenPic As OpenFileDialog
    Friend WithEvents txtPhone As CustomControls.RJControls.RJTextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDob As CustomControls.RJControls.RJDatePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As CustomControls.RJControls.RJTextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbAddress As ComboBox
    Friend WithEvents cbSearchAddress As ComboBox
End Class
