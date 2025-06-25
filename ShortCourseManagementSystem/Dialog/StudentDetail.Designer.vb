<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGender = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtkhName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDob = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEngName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 749)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 326)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(933, 423)
        Me.DataGridView1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 288)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(933, 38)
        Me.Panel4.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Moul Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(933, 38)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "បញ្ជីវគ្គសិក្សា"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.txtGender)
        Me.Panel3.Controls.Add(Me.txtkhName)
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.Controls.Add(Me.txtPhone)
        Me.Panel3.Controls.Add(Me.txtDob)
        Me.Panel3.Controls.Add(Me.txtEngName)
        Me.Panel3.Controls.Add(Me.picStudent)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(933, 254)
        Me.Panel3.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.BorderColor = System.Drawing.Color.DimGray
        Me.txtAddress.BorderRadius = 8
        Me.txtAddress.BorderThickness = 2
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.Parent = Me.txtAddress
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtAddress.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtAddress.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.FocusedState.Parent = Me.txtAddress
        Me.txtAddress.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.HoverState.Parent = Me.txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(145, 158)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.ShadowDecoration.Parent = Me.txtAddress
        Me.txtAddress.Size = New System.Drawing.Size(212, 44)
        Me.txtAddress.TabIndex = 60
        '
        'txtGender
        '
        Me.txtGender.BorderColor = System.Drawing.Color.DimGray
        Me.txtGender.BorderRadius = 8
        Me.txtGender.BorderThickness = 2
        Me.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGender.DefaultText = ""
        Me.txtGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGender.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGender.DisabledState.Parent = Me.txtGender
        Me.txtGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtGender.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtGender.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtGender.FocusedState.Parent = Me.txtGender
        Me.txtGender.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.Color.Black
        Me.txtGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGender.HoverState.Parent = Me.txtGender
        Me.txtGender.Location = New System.Drawing.Point(145, 110)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGender.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtGender.PlaceholderText = ""
        Me.txtGender.ReadOnly = True
        Me.txtGender.SelectedText = ""
        Me.txtGender.ShadowDecoration.Parent = Me.txtGender
        Me.txtGender.Size = New System.Drawing.Size(212, 44)
        Me.txtGender.TabIndex = 59
        '
        'txtkhName
        '
        Me.txtkhName.BorderColor = System.Drawing.Color.DimGray
        Me.txtkhName.BorderRadius = 8
        Me.txtkhName.BorderThickness = 2
        Me.txtkhName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkhName.DefaultText = ""
        Me.txtkhName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtkhName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtkhName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkhName.DisabledState.Parent = Me.txtkhName
        Me.txtkhName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkhName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtkhName.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtkhName.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtkhName.FocusedState.Parent = Me.txtkhName
        Me.txtkhName.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhName.ForeColor = System.Drawing.Color.Black
        Me.txtkhName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkhName.HoverState.Parent = Me.txtkhName
        Me.txtkhName.Location = New System.Drawing.Point(145, 59)
        Me.txtkhName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtkhName.Name = "txtkhName"
        Me.txtkhName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtkhName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtkhName.PlaceholderText = ""
        Me.txtkhName.ReadOnly = True
        Me.txtkhName.SelectedText = ""
        Me.txtkhName.ShadowDecoration.Parent = Me.txtkhName
        Me.txtkhName.Size = New System.Drawing.Size(212, 44)
        Me.txtkhName.TabIndex = 53
        '
        'txtID
        '
        Me.txtID.BorderColor = System.Drawing.Color.DimGray
        Me.txtID.BorderRadius = 8
        Me.txtID.BorderThickness = 2
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DefaultText = ""
        Me.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.DisabledState.Parent = Me.txtID
        Me.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtID.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtID.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtID.FocusedState.Parent = Me.txtID
        Me.txtID.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.HoverState.Parent = Me.txtID
        Me.txtID.Location = New System.Drawing.Point(145, 12)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtID.PlaceholderText = ""
        Me.txtID.ReadOnly = True
        Me.txtID.SelectedText = ""
        Me.txtID.ShadowDecoration.Parent = Me.txtID
        Me.txtID.Size = New System.Drawing.Size(212, 44)
        Me.txtID.TabIndex = 52
        '
        'txtPhone
        '
        Me.txtPhone.BorderColor = System.Drawing.Color.DimGray
        Me.txtPhone.BorderRadius = 8
        Me.txtPhone.BorderThickness = 2
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.DefaultText = ""
        Me.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.DisabledState.Parent = Me.txtPhone
        Me.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtPhone.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtPhone.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.FocusedState.Parent = Me.txtPhone
        Me.txtPhone.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.HoverState.Parent = Me.txtPhone
        Me.txtPhone.Location = New System.Drawing.Point(501, 156)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPhone.PlaceholderText = ""
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.ShadowDecoration.Parent = Me.txtPhone
        Me.txtPhone.Size = New System.Drawing.Size(254, 44)
        Me.txtPhone.TabIndex = 56
        '
        'txtDob
        '
        Me.txtDob.BorderColor = System.Drawing.Color.DimGray
        Me.txtDob.BorderRadius = 8
        Me.txtDob.BorderThickness = 2
        Me.txtDob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDob.DefaultText = ""
        Me.txtDob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDob.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDob.DisabledState.Parent = Me.txtDob
        Me.txtDob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtDob.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtDob.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtDob.FocusedState.Parent = Me.txtDob
        Me.txtDob.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDob.ForeColor = System.Drawing.Color.Black
        Me.txtDob.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDob.HoverState.Parent = Me.txtDob
        Me.txtDob.Location = New System.Drawing.Point(501, 108)
        Me.txtDob.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDob.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtDob.PlaceholderText = ""
        Me.txtDob.ReadOnly = True
        Me.txtDob.SelectedText = ""
        Me.txtDob.ShadowDecoration.Parent = Me.txtDob
        Me.txtDob.Size = New System.Drawing.Size(254, 44)
        Me.txtDob.TabIndex = 55
        '
        'txtEngName
        '
        Me.txtEngName.BorderColor = System.Drawing.Color.DimGray
        Me.txtEngName.BorderRadius = 8
        Me.txtEngName.BorderThickness = 2
        Me.txtEngName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEngName.DefaultText = ""
        Me.txtEngName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEngName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEngName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEngName.DisabledState.Parent = Me.txtEngName
        Me.txtEngName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEngName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtEngName.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtEngName.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtEngName.FocusedState.Parent = Me.txtEngName
        Me.txtEngName.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngName.ForeColor = System.Drawing.Color.Black
        Me.txtEngName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEngName.HoverState.Parent = Me.txtEngName
        Me.txtEngName.Location = New System.Drawing.Point(501, 59)
        Me.txtEngName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtEngName.Name = "txtEngName"
        Me.txtEngName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEngName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtEngName.PlaceholderText = ""
        Me.txtEngName.ReadOnly = True
        Me.txtEngName.SelectedText = ""
        Me.txtEngName.ShadowDecoration.Parent = Me.txtEngName
        Me.txtEngName.Size = New System.Drawing.Size(254, 44)
        Me.txtEngName.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(393, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 29)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "លេខទូរស័ព្ទ ៖"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 29)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "ថ្ងៃខែឆ្មាំកំណើត ៖"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 29)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "អាស័យដ្ឋាន ៖"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 29)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ភេទ ៖"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(383, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 29)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "ឈ្មោះឡាតាំង ៖"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 29)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "គោត្តនាម នាម ៖"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "លេខកូដសិស្ស ៖"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(933, 34)
        Me.Panel2.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Khmer OS Moul Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(933, 34)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ព័ត៌មានសិស្សលម្ពិត"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picStudent
        '
        Me.picStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Location = New System.Drawing.Point(810, 2)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(117, 159)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 51
        Me.picStudent.TabStop = False
        '
        'StudentDetail
        '
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(943, 759)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(959, 798)
        Me.MinimumSize = New System.Drawing.Size(959, 798)
        Me.Name = "StudentDetail"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents picStudent As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEngName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtkhName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGender As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDob As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
