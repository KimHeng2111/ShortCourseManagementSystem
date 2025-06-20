<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnReport = New FontAwesome.Sharp.IconButton()
        Me.btnCourse = New FontAwesome.Sharp.IconButton()
        Me.btnClass = New FontAwesome.Sharp.IconButton()
        Me.btnStudent = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnTeacher = New FontAwesome.Sharp.IconButton()
        Me.btnRegister = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.panelMenuUpper = New System.Windows.Forms.Panel()
        Me.lbSchoolName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbFormTitle = New System.Windows.Forms.Label()
        Me.panelTitlebar = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.panelMenu.SuspendLayout()
        Me.panelMenuUpper.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitlebar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnReport)
        Me.panelMenu.Controls.Add(Me.btnCourse)
        Me.panelMenu.Controls.Add(Me.btnClass)
        Me.panelMenu.Controls.Add(Me.btnStudent)
        Me.panelMenu.Controls.Add(Me.btnExit)
        Me.panelMenu.Controls.Add(Me.btnTeacher)
        Me.panelMenu.Controls.Add(Me.btnRegister)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.panelMenuUpper)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 33)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(200, 1028)
        Me.panelMenu.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Khmer Busra", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnReport.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReport.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.btnReport.IconColor = System.Drawing.Color.Gainsboro
        Me.btnReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReport.IconSize = 32
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(0, 502)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnReport.Size = New System.Drawing.Size(200, 57)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Tag = "បញ្ជីរបាយការណ៍"
        Me.btnReport.Text = "របាយការណ៍"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.Transparent
        Me.btnCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourse.FlatAppearance.BorderSize = 0
        Me.btnCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourse.Font = New System.Drawing.Font("Khmer Busra", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnCourse.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCourse.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnCourse.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCourse.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCourse.IconSize = 32
        Me.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourse.Location = New System.Drawing.Point(0, 445)
        Me.btnCourse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCourse.Size = New System.Drawing.Size(200, 57)
        Me.btnCourse.TabIndex = 7
        Me.btnCourse.Tag = "បញ្ជីព័ត៌មានមុខវិជ្ជា"
        Me.btnCourse.Text = "មុខវិជ្ជា"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'btnClass
        '
        Me.btnClass.BackColor = System.Drawing.Color.Transparent
        Me.btnClass.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClass.FlatAppearance.BorderSize = 0
        Me.btnClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClass.Font = New System.Drawing.Font("Khmer Busra", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnClass.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClass.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        Me.btnClass.IconColor = System.Drawing.Color.Gainsboro
        Me.btnClass.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClass.IconSize = 32
        Me.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClass.Location = New System.Drawing.Point(0, 388)
        Me.btnClass.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnClass.Size = New System.Drawing.Size(200, 57)
        Me.btnClass.TabIndex = 5
        Me.btnClass.Tag = "បញ្ជីព័ត៌មានវគ្គសិក្សា"
        Me.btnClass.Text = "វគ្គសិក្សា"
        Me.btnClass.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Khmer Busra", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnStudent.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate
        Me.btnStudent.IconColor = System.Drawing.Color.Gainsboro
        Me.btnStudent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudent.IconSize = 32
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.Location = New System.Drawing.Point(0, 331)
        Me.btnStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStudent.Size = New System.Drawing.Size(200, 57)
        Me.btnStudent.TabIndex = 8
        Me.btnStudent.Tag = "បញ្ជីព័ត៌មានសិស្ស"
        Me.btnStudent.Text = "សិស្ស"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorClosed
        Me.btnExit.IconColor = System.Drawing.Color.Gainsboro
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 32
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 968)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnExit.Size = New System.Drawing.Size(200, 60)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Tag = "        Exit"
        Me.btnExit.Text = "        Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnTeacher
        '
        Me.btnTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTeacher.FlatAppearance.BorderSize = 0
        Me.btnTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacher.Font = New System.Drawing.Font("Khmer Busra", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacher.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTeacher.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher
        Me.btnTeacher.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTeacher.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTeacher.IconSize = 32
        Me.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacher.Location = New System.Drawing.Point(0, 274)
        Me.btnTeacher.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnTeacher.Size = New System.Drawing.Size(200, 57)
        Me.btnTeacher.TabIndex = 6
        Me.btnTeacher.Tag = "បញ្ជីព័ត៌មានគ្រូបង្រៀន"
        Me.btnTeacher.Text = "គ្រូបង្រៀន"
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Khmer Busra", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegister.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnRegister.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegister.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegister.IconSize = 32
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(0, 217)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegister.Size = New System.Drawing.Size(200, 57)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Tag = "បញ្ជីចុះឈ្មោះសិស្ស"
        Me.btnRegister.Text = "ចុះឈ្មោះ"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Khmer Busra", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Chalkboard
        Me.btnDashboard.IconColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 160)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(200, 57)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Tag = "ប្រព័ន្ធគ្រប់គ្រងវគ្គសិក្សាវគ្គខ្លី"
        Me.btnDashboard.Text = "ទំព័រដើម"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'panelMenuUpper
        '
        Me.panelMenuUpper.Controls.Add(Me.lbSchoolName)
        Me.panelMenuUpper.Controls.Add(Me.PictureBox1)
        Me.panelMenuUpper.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMenuUpper.Location = New System.Drawing.Point(0, 0)
        Me.panelMenuUpper.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.panelMenuUpper.Name = "panelMenuUpper"
        Me.panelMenuUpper.Size = New System.Drawing.Size(200, 160)
        Me.panelMenuUpper.TabIndex = 0
        '
        'lbSchoolName
        '
        Me.lbSchoolName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbSchoolName.AutoSize = True
        Me.lbSchoolName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSchoolName.ForeColor = System.Drawing.Color.White
        Me.lbSchoolName.Location = New System.Drawing.Point(63, 130)
        Me.lbSchoolName.Name = "lbSchoolName"
        Me.lbSchoolName.Size = New System.Drawing.Size(66, 19)
        Me.lbSchoolName.TabIndex = 1
        Me.lbSchoolName.Text = "RPITSB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.PictureBox1.Size = New System.Drawing.Size(200, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbFormTitle
        '
        Me.lbFormTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbFormTitle.Font = New System.Drawing.Font("Khmer OS Moul", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormTitle.ForeColor = System.Drawing.Color.White
        Me.lbFormTitle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbFormTitle.Location = New System.Drawing.Point(0, 0)
        Me.lbFormTitle.Name = "lbFormTitle"
        Me.lbFormTitle.Padding = New System.Windows.Forms.Padding(70, 0, 0, 0)
        Me.lbFormTitle.Size = New System.Drawing.Size(1720, 72)
        Me.lbFormTitle.TabIndex = 1
        Me.lbFormTitle.Text = "ផ្ទាំងគ្រប់គ្រង"
        Me.lbFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelTitlebar
        '
        Me.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelTitlebar.Controls.Add(Me.Label29)
        Me.panelTitlebar.Controls.Add(Me.IconCurrentForm)
        Me.panelTitlebar.Controls.Add(Me.lbFormTitle)
        Me.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitlebar.Location = New System.Drawing.Point(200, 33)
        Me.panelTitlebar.Name = "panelTitlebar"
        Me.panelTitlebar.Size = New System.Drawing.Size(1720, 72)
        Me.panelTitlebar.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.Font = New System.Drawing.Font("Kh Bokor", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(1439, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Label29.Size = New System.Drawing.Size(278, 29)
        Me.Label29.TabIndex = 4
        Me.Label29.Tag = "គណនីប្រើប្រាស់ ៖ "
        Me.Label29.Text = "គណនីប្រើប្រាស់ ៖ Admin"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.Transparent
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 51
        Me.IconCurrentForm.Location = New System.Drawing.Point(6, 9)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.IconCurrentForm.Size = New System.Drawing.Size(58, 51)
        Me.IconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'panelChildForm
        '
        Me.panelChildForm.BackColor = System.Drawing.SystemColors.MenuBar
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelChildForm.Location = New System.Drawing.Point(200, 105)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(1720, 956)
        Me.panelChildForm.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMin)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(1920, 33)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(234, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ShorCourse Management Systme"
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.White
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMin.IconColor = System.Drawing.Color.Black
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 30
        Me.btnMin.Location = New System.Drawing.Point(1860, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 33)
        Me.btnMin.TabIndex = 12
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 30
        Me.btnClose.Location = New System.Drawing.Point(1890, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 33)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1061)
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.panelTitlebar)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenuUpper.ResumeLayout(False)
        Me.panelMenuUpper.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitlebar.ResumeLayout(False)
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelMenuUpper As Panel
    Friend WithEvents panelTitlebar As Panel
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTeacher As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegister As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents lbSchoolName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbFormTitle As Label
    Friend WithEvents btnClass As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCourse As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudent As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label29 As Label
End Class
