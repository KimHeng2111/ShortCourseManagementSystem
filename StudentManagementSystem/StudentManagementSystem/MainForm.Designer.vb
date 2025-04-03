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
        Me.btnPayment = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnTeacher = New FontAwesome.Sharp.IconButton()
        Me.btnCourse = New FontAwesome.Sharp.IconButton()
        Me.btnStudent = New FontAwesome.Sharp.IconButton()
        Me.btnRegister = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.panelMenuUpper = New System.Windows.Forms.Panel()
        Me.btnMenu = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbSchoolName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelTitlebar = New System.Windows.Forms.Panel()
        Me.panelFormOpen = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelMenu.SuspendLayout()
        Me.panelMenuUpper.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitlebar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnPayment)
        Me.panelMenu.Controls.Add(Me.btnExit)
        Me.panelMenu.Controls.Add(Me.btnTeacher)
        Me.panelMenu.Controls.Add(Me.btnCourse)
        Me.panelMenu.Controls.Add(Me.btnStudent)
        Me.panelMenu.Controls.Add(Me.btnRegister)
        Me.panelMenu.Controls.Add(Me.btnDashboard)
        Me.panelMenu.Controls.Add(Me.panelMenuUpper)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(250, 761)
        Me.panelMenu.TabIndex = 0
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPayment.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.btnPayment.IconColor = System.Drawing.Color.Gainsboro
        Me.btnPayment.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPayment.IconSize = 32
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.Location = New System.Drawing.Point(0, 460)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(30, 0, 20, 0)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPayment.Size = New System.Drawing.Size(250, 60)
        Me.btnPayment.TabIndex = 5
        Me.btnPayment.Tag = "        Payment"
        Me.btnPayment.Text = "        Payment"
        Me.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
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
        Me.btnExit.Location = New System.Drawing.Point(0, 701)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnExit.Size = New System.Drawing.Size(250, 60)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Tag = "        Exit"
        Me.btnExit.Text = "        Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnTeacher
        '
        Me.btnTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTeacher.FlatAppearance.BorderSize = 0
        Me.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacher.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacher.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTeacher.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher
        Me.btnTeacher.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTeacher.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTeacher.IconSize = 32
        Me.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacher.Location = New System.Drawing.Point(0, 400)
        Me.btnTeacher.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnTeacher.Size = New System.Drawing.Size(250, 60)
        Me.btnTeacher.TabIndex = 6
        Me.btnTeacher.Tag = "        Teachers"
        Me.btnTeacher.Text = "        Teachers"
        Me.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourse.FlatAppearance.BorderSize = 0
        Me.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCourse.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        Me.btnCourse.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCourse.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCourse.IconSize = 32
        Me.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourse.Location = New System.Drawing.Point(0, 340)
        Me.btnCourse.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCourse.Size = New System.Drawing.Size(250, 60)
        Me.btnCourse.TabIndex = 4
        Me.btnCourse.Tag = "        Courses"
        Me.btnCourse.Text = "        Courses"
        Me.btnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate
        Me.btnStudent.IconColor = System.Drawing.Color.Gainsboro
        Me.btnStudent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudent.IconSize = 32
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.Location = New System.Drawing.Point(0, 280)
        Me.btnStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStudent.Size = New System.Drawing.Size(250, 60)
        Me.btnStudent.TabIndex = 3
        Me.btnStudent.Tag = "        Student"
        Me.btnStudent.Text = "        Student"
        Me.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegister.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRegister.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnRegister.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRegister.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRegister.IconSize = 32
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(0, 220)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegister.Size = New System.Drawing.Size(250, 60)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Tag = "        Register"
        Me.btnRegister.Text = "        Register"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnDashboard.Size = New System.Drawing.Size(250, 60)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Tag = "        Dashboard"
        Me.btnDashboard.Text = "        Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'panelMenuUpper
        '
        Me.panelMenuUpper.Controls.Add(Me.btnMenu)
        Me.panelMenuUpper.Controls.Add(Me.Panel1)
        Me.panelMenuUpper.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMenuUpper.Location = New System.Drawing.Point(0, 0)
        Me.panelMenuUpper.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.panelMenuUpper.Name = "panelMenuUpper"
        Me.panelMenuUpper.Size = New System.Drawing.Size(250, 160)
        Me.panelMenuUpper.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.btnMenu.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMenu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMenu.IconSize = 32
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMenu.Location = New System.Drawing.Point(187, 1)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(3, 25, 3, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(63, 54)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbSchoolName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 160)
        Me.Panel1.TabIndex = 0
        '
        'lbSchoolName
        '
        Me.lbSchoolName.AutoSize = True
        Me.lbSchoolName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSchoolName.ForeColor = System.Drawing.Color.White
        Me.lbSchoolName.Location = New System.Drawing.Point(45, 116)
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
        Me.PictureBox1.Size = New System.Drawing.Size(156, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelTitlebar
        '
        Me.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelTitlebar.Controls.Add(Me.panelFormOpen)
        Me.panelTitlebar.Controls.Add(Me.lbFormTitle)
        Me.panelTitlebar.Controls.Add(Me.IconCurrentForm)
        Me.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitlebar.Location = New System.Drawing.Point(250, 0)
        Me.panelTitlebar.Name = "panelTitlebar"
        Me.panelTitlebar.Size = New System.Drawing.Size(840, 91)
        Me.panelTitlebar.TabIndex = 1
        '
        'panelFormOpen
        '
        Me.panelFormOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.panelFormOpen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFormOpen.Location = New System.Drawing.Point(0, 61)
        Me.panelFormOpen.Name = "panelFormOpen"
        Me.panelFormOpen.Size = New System.Drawing.Size(840, 30)
        Me.panelFormOpen.TabIndex = 2
        '
        'lbFormTitle
        '
        Me.lbFormTitle.AutoSize = True
        Me.lbFormTitle.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbFormTitle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbFormTitle.Location = New System.Drawing.Point(70, 29)
        Me.lbFormTitle.Name = "lbFormTitle"
        Me.lbFormTitle.Size = New System.Drawing.Size(38, 15)
        Me.lbFormTitle.TabIndex = 1
        Me.lbFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.Transparent
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 45
        Me.IconCurrentForm.Location = New System.Drawing.Point(19, 16)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(45, 45)
        Me.IconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'panelChildForm
        '
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildForm.Location = New System.Drawing.Point(250, 91)
        Me.panelChildForm.MinimumSize = New System.Drawing.Size(222, 648)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Padding = New System.Windows.Forms.Padding(30)
        Me.panelChildForm.Size = New System.Drawing.Size(840, 670)
        Me.panelChildForm.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(250, 745)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 16)
        Me.Panel2.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 761)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.panelTitlebar)
        Me.Controls.Add(Me.panelMenu)
        Me.MinimumSize = New System.Drawing.Size(1106, 800)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenuUpper.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitlebar.ResumeLayout(False)
        Me.panelTitlebar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelMenuUpper As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelTitlebar As Panel
    Friend WithEvents panelChildForm As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTeacher As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCourse As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudent As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegister As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents lbSchoolName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbFormTitle As Label
    Friend WithEvents btnPayment As FontAwesome.Sharp.IconButton
    Friend WithEvents panelFormOpen As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
End Class
