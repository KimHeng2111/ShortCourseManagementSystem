﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.panelTitlebar = New System.Windows.Forms.Panel()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.panelChildForm = New System.Windows.Forms.Panel()
        Me.panelMenu.SuspendLayout()
        Me.panelMenuUpper.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(157, Byte), Integer))
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
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(200, 1080)
        Me.panelMenu.TabIndex = 0
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnReport.Tag = "Report"
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.Transparent
        Me.btnCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourse.FlatAppearance.BorderSize = 0
        Me.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnCourse.Tag = "Course"
        Me.btnCourse.Text = "Course"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'btnClass
        '
        Me.btnClass.BackColor = System.Drawing.Color.Transparent
        Me.btnClass.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClass.FlatAppearance.BorderSize = 0
        Me.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnClass.Tag = "Manage Class"
        Me.btnClass.Text = "Manage Class"
        Me.btnClass.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
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
        Me.btnStudent.Location = New System.Drawing.Point(0, 331)
        Me.btnStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStudent.Size = New System.Drawing.Size(200, 57)
        Me.btnStudent.TabIndex = 8
        Me.btnStudent.Tag = "Student"
        Me.btnStudent.Text = "Student"
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
        Me.btnExit.Location = New System.Drawing.Point(0, 1020)
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
        Me.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacher.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnTeacher.Tag = "Teachers"
        Me.btnTeacher.Text = "Teachers"
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
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
        Me.btnRegister.Location = New System.Drawing.Point(0, 217)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnRegister.Size = New System.Drawing.Size(200, 57)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Tag = "Student"
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
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
        Me.btnDashboard.Size = New System.Drawing.Size(200, 57)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Tag = "Dashboard"
        Me.btnDashboard.Text = "Dashboard"
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
        Me.lbFormTitle.AutoSize = True
        Me.lbFormTitle.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbFormTitle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbFormTitle.Location = New System.Drawing.Point(56, 14)
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
        Me.IconCurrentForm.IconSize = 40
        Me.IconCurrentForm.Location = New System.Drawing.Point(5, 2)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.IconCurrentForm.Size = New System.Drawing.Size(40, 40)
        Me.IconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'panelTitlebar
        '
        Me.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.panelTitlebar.Controls.Add(Me.lbFormTitle)
        Me.panelTitlebar.Controls.Add(Me.btnMin)
        Me.panelTitlebar.Controls.Add(Me.btnClose)
        Me.panelTitlebar.Controls.Add(Me.IconCurrentForm)
        Me.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitlebar.Location = New System.Drawing.Point(200, 0)
        Me.panelTitlebar.Name = "panelTitlebar"
        Me.panelTitlebar.Size = New System.Drawing.Size(1720, 42)
        Me.panelTitlebar.TabIndex = 1
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.White
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnMin.IconColor = System.Drawing.Color.Black
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 30
        Me.btnMin.Location = New System.Drawing.Point(1660, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(30, 25)
        Me.btnMin.TabIndex = 10
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 30
        Me.btnClose.Location = New System.Drawing.Point(1690, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 25)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelChildForm
        '
        Me.panelChildForm.BackColor = System.Drawing.SystemColors.MenuBar
        Me.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelChildForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelChildForm.Location = New System.Drawing.Point(200, 42)
        Me.panelChildForm.Name = "panelChildForm"
        Me.panelChildForm.Size = New System.Drawing.Size(1720, 1038)
        Me.panelChildForm.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.panelChildForm)
        Me.Controls.Add(Me.panelTitlebar)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenuUpper.ResumeLayout(False)
        Me.panelMenuUpper.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitlebar.ResumeLayout(False)
        Me.panelTitlebar.PerformLayout()
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
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnStudent As FontAwesome.Sharp.IconButton
End Class
