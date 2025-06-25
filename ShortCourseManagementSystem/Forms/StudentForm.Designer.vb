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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.OpenPic = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.btnChooseImage = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtKhName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtEngName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.cbAddress = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.dtpDob = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbSearchAddress = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenPic
        '
        Me.OpenPic.FileName = "OpenFileDialog1"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(15, 452)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(225, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1674, 476)
        Me.DataGridView1.TabIndex = 60
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel16)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1674, 347)
        Me.Panel2.TabIndex = 5
        Me.Panel2.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Khmer Muol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1674, 49)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "ព័ត៌មានសិស្សចុះឈ្មោះ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.picStudent)
        Me.Panel6.Controls.Add(Me.btnChooseImage)
        Me.Panel6.Location = New System.Drawing.Point(1451, 61)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(130, 207)
        Me.Panel6.TabIndex = 92
        '
        'picStudent
        '
        Me.picStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Image = CType(resources.GetObject("picStudent.Image"), System.Drawing.Image)
        Me.picStudent.Location = New System.Drawing.Point(0, 0)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(130, 162)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 50
        Me.picStudent.TabStop = False
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnChooseImage.FlatAppearance.BorderSize = 0
        Me.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseImage.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseImage.ForeColor = System.Drawing.Color.White
        Me.btnChooseImage.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnChooseImage.IconColor = System.Drawing.Color.Transparent
        Me.btnChooseImage.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnChooseImage.Location = New System.Drawing.Point(0, 174)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(130, 32)
        Me.btnChooseImage.TabIndex = 10
        Me.btnChooseImage.Text = "ជ្រើសរើសរូបភាព"
        Me.btnChooseImage.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.txtKhName)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(106, 64)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel5.Size = New System.Drawing.Size(371, 84)
        Me.Panel5.TabIndex = 86
        '
        'txtKhName
        '
        Me.txtKhName.BorderColor = System.Drawing.Color.DimGray
        Me.txtKhName.BorderRadius = 8
        Me.txtKhName.BorderThickness = 2
        Me.txtKhName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKhName.DefaultText = ""
        Me.txtKhName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKhName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKhName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKhName.DisabledState.Parent = Me.txtKhName
        Me.txtKhName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKhName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtKhName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtKhName.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtKhName.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtKhName.FocusedState.Parent = Me.txtKhName
        Me.txtKhName.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhName.ForeColor = System.Drawing.Color.Black
        Me.txtKhName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKhName.HoverState.Parent = Me.txtKhName
        Me.txtKhName.Location = New System.Drawing.Point(0, 37)
        Me.txtKhName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtKhName.Name = "txtKhName"
        Me.txtKhName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKhName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtKhName.PlaceholderText = "បញ្ចូលឈ្មោះសិស្សទាំងត្រកូល"
        Me.txtKhName.SelectedText = ""
        Me.txtKhName.ShadowDecoration.Parent = Me.txtKhName
        Me.txtKhName.Size = New System.Drawing.Size(371, 44)
        Me.txtKhName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "គោត្តនាម នាម ៖"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.txtEngName)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(606, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel3.Size = New System.Drawing.Size(371, 84)
        Me.Panel3.TabIndex = 87
        '
        'txtEngName
        '
        Me.txtEngName.Animated = True
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
        Me.txtEngName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtEngName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtEngName.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtEngName.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtEngName.FocusedState.Parent = Me.txtEngName
        Me.txtEngName.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngName.ForeColor = System.Drawing.Color.Black
        Me.txtEngName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEngName.HoverState.Parent = Me.txtEngName
        Me.txtEngName.Location = New System.Drawing.Point(0, 37)
        Me.txtEngName.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtEngName.Name = "txtEngName"
        Me.txtEngName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEngName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtEngName.PlaceholderText = "បញ្ចូលឈ្មោះជាភាសាអង់​គ្គេស"
        Me.txtEngName.SelectedText = ""
        Me.txtEngName.ShadowDecoration.Parent = Me.txtEngName
        Me.txtEngName.Size = New System.Drawing.Size(371, 44)
        Me.txtEngName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ឈ្មោះឡាតាំង ៖"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.cbGender)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(1091, 64)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel4.Size = New System.Drawing.Size(253, 84)
        Me.Panel4.TabIndex = 88
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.Color.Transparent
        Me.cbGender.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbGender.BorderRadius = 8
        Me.cbGender.BorderThickness = 2
        Me.cbGender.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbGender.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbGender.FocusedState.Parent = Me.cbGender
        Me.cbGender.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.ForeColor = System.Drawing.Color.Black
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbGender.HoverState.FillColor = System.Drawing.Color.White
        Me.cbGender.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbGender.HoverState.Parent = Me.cbGender
        Me.cbGender.ItemHeight = 35
        Me.cbGender.Items.AddRange(New Object() {"ប្រុស", "ស្រី", "ជ្រើសរើសភេទ"})
        Me.cbGender.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbGender.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbGender.ItemsAppearance.Parent = Me.cbGender
        Me.cbGender.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbGender.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbGender.Location = New System.Drawing.Point(0, 40)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.ShadowDecoration.Parent = Me.cbGender
        Me.cbGender.Size = New System.Drawing.Size(253, 41)
        Me.cbGender.StartIndex = 2
        Me.cbGender.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ភេទ៖"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.cbAddress)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Location = New System.Drawing.Point(606, 154)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel9.Size = New System.Drawing.Size(371, 84)
        Me.Panel9.TabIndex = 90
        '
        'cbAddress
        '
        Me.cbAddress.BackColor = System.Drawing.Color.Transparent
        Me.cbAddress.BorderColor = System.Drawing.Color.DimGray
        Me.cbAddress.BorderRadius = 8
        Me.cbAddress.BorderThickness = 2
        Me.cbAddress.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAddress.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbAddress.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAddress.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbAddress.FocusedState.Parent = Me.cbAddress
        Me.cbAddress.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAddress.ForeColor = System.Drawing.Color.Black
        Me.cbAddress.FormattingEnabled = True
        Me.cbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbAddress.HoverState.FillColor = System.Drawing.Color.White
        Me.cbAddress.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbAddress.HoverState.Parent = Me.cbAddress
        Me.cbAddress.ItemHeight = 35
        Me.cbAddress.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbAddress.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAddress.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbAddress.ItemsAppearance.Parent = Me.cbAddress
        Me.cbAddress.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbAddress.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbAddress.Location = New System.Drawing.Point(0, 40)
        Me.cbAddress.Name = "cbAddress"
        Me.cbAddress.ShadowDecoration.Parent = Me.cbAddress
        Me.cbAddress.Size = New System.Drawing.Size(371, 41)
        Me.cbAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "អាសយដ្ឋាន ៖"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Transparent
        Me.Panel16.Controls.Add(Me.dtpDob)
        Me.Panel16.Controls.Add(Me.Label14)
        Me.Panel16.Location = New System.Drawing.Point(106, 154)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel16.Size = New System.Drawing.Size(371, 84)
        Me.Panel16.TabIndex = 89
        '
        'dtpDob
        '
        Me.dtpDob.BorderColor = System.Drawing.Color.DimGray
        Me.dtpDob.BorderRadius = 8
        Me.dtpDob.BorderThickness = 2
        Me.dtpDob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dtpDob.DefaultText = ""
        Me.dtpDob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dtpDob.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dtpDob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dtpDob.DisabledState.Parent = Me.dtpDob
        Me.dtpDob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dtpDob.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpDob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.dtpDob.FocusedState.FillColor = System.Drawing.Color.White
        Me.dtpDob.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.dtpDob.FocusedState.Parent = Me.dtpDob
        Me.dtpDob.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDob.ForeColor = System.Drawing.Color.Black
        Me.dtpDob.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDob.HoverState.Parent = Me.dtpDob
        Me.dtpDob.Location = New System.Drawing.Point(0, 37)
        Me.dtpDob.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dtpDob.PlaceholderForeColor = System.Drawing.Color.Black
        Me.dtpDob.PlaceholderText = "dd/mm/yyyy"
        Me.dtpDob.SelectedText = ""
        Me.dtpDob.ShadowDecoration.Parent = Me.dtpDob
        Me.dtpDob.Size = New System.Drawing.Size(371, 44)
        Me.dtpDob.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(3, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 29)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "ថ្ងៃខែឆ្នាំកំណើត ៖"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtPhone)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Location = New System.Drawing.Point(1091, 154)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel8.Size = New System.Drawing.Size(253, 84)
        Me.Panel8.TabIndex = 91
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
        Me.txtPhone.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtPhone.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtPhone.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.FocusedState.Parent = Me.txtPhone
        Me.txtPhone.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.HoverState.Parent = Me.txtPhone
        Me.txtPhone.Location = New System.Drawing.Point(0, 40)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPhone.PlaceholderText = "បញ្ចូលលេខទូរស័ព្ទ"
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.ShadowDecoration.Parent = Me.txtPhone
        Me.txtPhone.Size = New System.Drawing.Size(253, 41)
        Me.txtPhone.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "លេខទូរស័ព្ទ ៖"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(867, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 41)
        Me.btnClear.TabIndex = 85
        Me.btnClear.Text = "បោះបង់"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(621, 287)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(151, 44)
        Me.btnEdit.TabIndex = 84
        Me.btnEdit.Text = "រក្សាទុក"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.cbSearchAddress)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 372)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1674, 70)
        Me.Panel1.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.DimGray
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.BorderThickness = 2
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtSearch.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtSearch.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.Location = New System.Drawing.Point(4, 13)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtSearch.PlaceholderText = "ស្វែងរកតាមរយៈ ឈ្មោះ ឬ ID "
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(349, 44)
        Me.txtSearch.TabIndex = 88
        '
        'cbSearchAddress
        '
        Me.cbSearchAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbSearchAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchAddress.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!)
        Me.cbSearchAddress.FormattingEnabled = True
        Me.cbSearchAddress.Location = New System.Drawing.Point(372, 18)
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
        Me.Button1.Location = New System.Drawing.Point(546, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 41)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "សម្អាត"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(15, 442)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(1674, 10)
        Me.Guna2Panel3.TabIndex = 110
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(15, 362)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1674, 10)
        Me.Guna2Panel2.TabIndex = 109
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me.Panel2
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 10
        Me.Guna2Elipse2.TargetControl = Me.Panel1
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 10
        Me.Guna2Elipse3.TargetControl = Me.DataGridView1
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1704, 943)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "StudentForm"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "StudentForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenPic As OpenFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cbSearchAddress As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtKhName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtEngName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents cbAddress As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents dtpDob As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents picStudent As PictureBox
    Friend WithEvents btnChooseImage As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
End Class
