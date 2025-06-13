<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassWord = New CustomControls.RJControls.RJTextBox()
        Me.txtUserName = New CustomControls.RJControls.RJTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnShowHide = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Siemreap", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(153, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 33)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "សូមស្វាគមន៍"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(742, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 43)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "ចាកចេញ"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(528, 322)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(155, 43)
        Me.btnLogin.TabIndex = 13
        Me.btnLogin.Text = "ចូល"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassWord
        '
        Me.txtPassWord.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtPassWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassWord.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.txtPassWord.BorderFocusColor = System.Drawing.Color.Blue
        Me.txtPassWord.BorderRadius = 3
        Me.txtPassWord.BorderSize = 2
        Me.txtPassWord.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassWord.ForeColor = System.Drawing.Color.Black
        Me.txtPassWord.Location = New System.Drawing.Point(653, 214)
        Me.txtPassWord.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassWord.Multiline = False
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtPassWord.PasswordChar = True
        Me.txtPassWord.PlaceholderColor = System.Drawing.Color.Gainsboro
        Me.txtPassWord.PlaceholderText = "ពាក្យសម្ងាត់"
        Me.txtPassWord.Size = New System.Drawing.Size(270, 42)
        Me.txtPassWord.TabIndex = 12
        Me.txtPassWord.Texts = ""
        Me.txtPassWord.UnderlinedStyle = True
        '
        'txtUserName
        '
        Me.txtUserName.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserName.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.txtUserName.BorderFocusColor = System.Drawing.Color.Blue
        Me.txtUserName.BorderRadius = 3
        Me.txtUserName.BorderSize = 2
        Me.txtUserName.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.Location = New System.Drawing.Point(653, 150)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Multiline = False
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtUserName.PasswordChar = False
        Me.txtUserName.PlaceholderColor = System.Drawing.Color.LightGray
        Me.txtUserName.PlaceholderText = "ឈ្មោះអ្នកប្រើប្រាស់"
        Me.txtUserName.Size = New System.Drawing.Size(270, 42)
        Me.txtUserName.TabIndex = 11
        Me.txtUserName.Texts = ""
        Me.txtUserName.UnderlinedStyle = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(522, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 34)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(522, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "UserName :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(153, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 477)
        Me.Panel1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Siemreap", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(378, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Regional Polytechnic Institute Techo Sen Battambang"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Siemreap", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(415, 33)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "វិទ្យាស្ថានពហុបច្ចេកទេសភូមិភាគតេជោសែនបាត់ដំបង"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowHide
        '
        Me.btnShowHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowHide.FlatAppearance.BorderSize = 0
        Me.btnShowHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowHide.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnShowHide.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnShowHide.IconColor = System.Drawing.Color.Black
        Me.btnShowHide.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnShowHide.IconSize = 30
        Me.btnShowHide.Location = New System.Drawing.Point(887, 218)
        Me.btnShowHide.Name = "btnShowHide"
        Me.btnShowHide.Size = New System.Drawing.Size(35, 34)
        Me.btnShowHide.TabIndex = 16
        Me.btnShowHide.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(984, 25)
        Me.Panel2.TabIndex = 17
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
        Me.btnClose.IconSize = 20
        Me.btnClose.Location = New System.Drawing.Point(959, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(25, 25)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(5, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 5, 0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(234, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ShorCourse Management Systme"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StudentManagementSystem.My.Resources.Resources.loginfrom1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 502)
        Me.Controls.Add(Me.btnShowHide)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassWord)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1000, 700)
        Me.MinimumSize = New System.Drawing.Size(100, 500)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassWord As CustomControls.RJControls.RJTextBox
    Friend WithEvents txtUserName As CustomControls.RJControls.RJTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnShowHide As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
End Class
