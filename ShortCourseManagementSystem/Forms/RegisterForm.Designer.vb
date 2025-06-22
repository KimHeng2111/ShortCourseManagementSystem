<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenPic = New System.Windows.Forms.OpenFileDialog()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelRegister = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtDis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.cbTime = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtKhName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtEngName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.cbAddress = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.dtpDob = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnChooseStudent = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbRoom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.cbSearchTeacher = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New CustomControls.RJControls.RJTextBox()
        Me.PanelListShow = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PanelRegister.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.PanelListShow.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenPic
        '
        Me.OpenPic.FileName = "StudentImage"
        Me.OpenPic.RestoreDirectory = True
        Me.OpenPic.Title = "Choose Image"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelRegister)
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelSearch)
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelListShow)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 15)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1705, 952)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'PanelRegister
        '
        Me.PanelRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.PanelRegister.Controls.Add(Me.Panel1)
        Me.PanelRegister.Controls.Add(Me.Panel12)
        Me.PanelRegister.Controls.Add(Me.Panel10)
        Me.PanelRegister.Controls.Add(Me.Panel6)
        Me.PanelRegister.Controls.Add(Me.Panel14)
        Me.PanelRegister.Controls.Add(Me.Panel11)
        Me.PanelRegister.Controls.Add(Me.Panel5)
        Me.PanelRegister.Controls.Add(Me.Label4)
        Me.PanelRegister.Controls.Add(Me.Panel2)
        Me.PanelRegister.Controls.Add(Me.Panel3)
        Me.PanelRegister.Controls.Add(Me.Panel13)
        Me.PanelRegister.Controls.Add(Me.Panel9)
        Me.PanelRegister.Controls.Add(Me.Panel16)
        Me.PanelRegister.Controls.Add(Me.Panel8)
        Me.PanelRegister.Controls.Add(Me.btnChooseStudent)
        Me.PanelRegister.Controls.Add(Me.btnClear)
        Me.PanelRegister.Controls.Add(Me.btnRegister)
        Me.PanelRegister.Controls.Add(Me.Panel4)
        Me.PanelRegister.Location = New System.Drawing.Point(3, 3)
        Me.PanelRegister.Name = "PanelRegister"
        Me.PanelRegister.Size = New System.Drawing.Size(1678, 426)
        Me.PanelRegister.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtPay)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Location = New System.Drawing.Point(1081, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 42)
        Me.Panel1.TabIndex = 9
        '
        'txtPay
        '
        Me.txtPay.BorderColor = System.Drawing.Color.DimGray
        Me.txtPay.BorderRadius = 8
        Me.txtPay.BorderThickness = 2
        Me.txtPay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPay.DefaultText = ""
        Me.txtPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPay.DisabledState.Parent = Me.txtPay
        Me.txtPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtPay.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtPay.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtPay.FocusedState.Parent = Me.txtPay
        Me.txtPay.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.ForeColor = System.Drawing.Color.Black
        Me.txtPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPay.HoverState.Parent = Me.txtPay
        Me.txtPay.Location = New System.Drawing.Point(119, 2)
        Me.txtPay.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPay.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPay.PlaceholderText = ""
        Me.txtPay.SelectedText = ""
        Me.txtPay.ShadowDecoration.Parent = Me.txtPay
        Me.txtPay.Size = New System.Drawing.Size(129, 39)
        Me.txtPay.TabIndex = 109
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label33.Location = New System.Drawing.Point(255, 6)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(20, 27)
        Me.Label33.TabIndex = 70
        Me.Label33.Text = "$"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(96, 6)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 27)
        Me.Label34.TabIndex = 3
        Me.Label34.Text = ":"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label35.Location = New System.Drawing.Point(3, 6)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(101, 29)
        Me.Label35.TabIndex = 51
        Me.Label35.Text = "ប្រាក់បានបង់"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.Controls.Add(Me.txtAmount)
        Me.Panel12.Controls.Add(Me.Label21)
        Me.Panel12.Controls.Add(Me.Label24)
        Me.Panel12.Controls.Add(Me.Label25)
        Me.Panel12.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(751, 315)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(227, 42)
        Me.Panel12.TabIndex = 107
        '
        'txtAmount
        '
        Me.txtAmount.BorderColor = System.Drawing.Color.DimGray
        Me.txtAmount.BorderRadius = 8
        Me.txtAmount.BorderThickness = 2
        Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmount.DefaultText = ""
        Me.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.DisabledState.Parent = Me.txtAmount
        Me.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtAmount.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtAmount.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.FocusedState.Parent = Me.txtAmount
        Me.txtAmount.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmount.HoverState.Parent = Me.txtAmount
        Me.txtAmount.Location = New System.Drawing.Point(99, 2)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAmount.PlaceholderText = ""
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.ShadowDecoration.Parent = Me.txtAmount
        Me.txtAmount.Size = New System.Drawing.Size(99, 39)
        Me.txtAmount.TabIndex = 109
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(202, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 27)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "$"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(76, 6)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(16, 27)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(3, 6)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 29)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "តម្លៃសរុប"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.txtDis)
        Me.Panel10.Controls.Add(Me.Label22)
        Me.Panel10.Controls.Add(Me.Label17)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Location = New System.Drawing.Point(446, 315)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(229, 42)
        Me.Panel10.TabIndex = 8
        '
        'txtDis
        '
        Me.txtDis.BorderColor = System.Drawing.Color.DimGray
        Me.txtDis.BorderRadius = 8
        Me.txtDis.BorderThickness = 2
        Me.txtDis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDis.DefaultText = ""
        Me.txtDis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDis.DisabledState.Parent = Me.txtDis
        Me.txtDis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtDis.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtDis.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtDis.FocusedState.Parent = Me.txtDis
        Me.txtDis.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDis.ForeColor = System.Drawing.Color.Black
        Me.txtDis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDis.HoverState.Parent = Me.txtDis
        Me.txtDis.Location = New System.Drawing.Point(100, 2)
        Me.txtDis.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtDis.Name = "txtDis"
        Me.txtDis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDis.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtDis.PlaceholderText = ""
        Me.txtDis.SelectedText = ""
        Me.txtDis.ShadowDecoration.Parent = Me.txtDis
        Me.txtDis.Size = New System.Drawing.Size(99, 39)
        Me.txtDis.TabIndex = 108
        '
        'Label22
        '
        Me.Label22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(201, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 27)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(84, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 27)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(8, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 29)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "បញ្ចុះតម្លៃ"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Transparent
        Me.Panel14.Controls.Add(Me.cbTime)
        Me.Panel14.Controls.Add(Me.Label28)
        Me.Panel14.Location = New System.Drawing.Point(621, 229)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(371, 74)
        Me.Panel14.TabIndex = 7
        '
        'cbTime
        '
        Me.cbTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbTime.BackColor = System.Drawing.Color.Transparent
        Me.cbTime.BorderColor = System.Drawing.Color.DimGray
        Me.cbTime.BorderRadius = 8
        Me.cbTime.BorderThickness = 2
        Me.cbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTime.Enabled = False
        Me.cbTime.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbTime.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTime.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbTime.FocusedState.Parent = Me.cbTime
        Me.cbTime.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTime.ForeColor = System.Drawing.Color.Black
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbTime.HoverState.FillColor = System.Drawing.Color.White
        Me.cbTime.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbTime.HoverState.Parent = Me.cbTime
        Me.cbTime.ItemHeight = 35
        Me.cbTime.Items.AddRange(New Object() {"ជ្រើសរើសវេនសិក្សា"})
        Me.cbTime.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbTime.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTime.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbTime.ItemsAppearance.Parent = Me.cbTime
        Me.cbTime.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbTime.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbTime.Location = New System.Drawing.Point(0, 30)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.ShadowDecoration.Parent = Me.cbTime
        Me.cbTime.Size = New System.Drawing.Size(266, 41)
        Me.cbTime.StartIndex = 0
        Me.cbTime.TabIndex = 7
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(3, 2)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(93, 29)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "វេនសិក្សា ៖"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.txtPrice)
        Me.Panel11.Controls.Add(Me.Label23)
        Me.Panel11.Controls.Add(Me.Label20)
        Me.Panel11.Location = New System.Drawing.Point(121, 315)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(253, 42)
        Me.Panel11.TabIndex = 103
        '
        'txtPrice
        '
        Me.txtPrice.BorderColor = System.Drawing.Color.DimGray
        Me.txtPrice.BorderRadius = 8
        Me.txtPrice.BorderThickness = 2
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.Parent = Me.txtPrice
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtPrice.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtPrice.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.FocusedState.Parent = Me.txtPrice
        Me.txtPrice.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.HoverState.Parent = Me.txtPrice
        Me.txtPrice.Location = New System.Drawing.Point(124, 3)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.ShadowDecoration.Parent = Me.txtPrice
        Me.txtPrice.Size = New System.Drawing.Size(99, 39)
        Me.txtPrice.TabIndex = 109
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(229, -5)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 47)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "$"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(8, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 29)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "តម្លៃវគ្គសិក្សា ៖"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.txtKhName)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(121, 60)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel5.Size = New System.Drawing.Size(371, 84)
        Me.Panel5.TabIndex = 0
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
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Khmer Muol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1678, 49)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "ព័ត៌មានសិស្សចុះឈ្មោះ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.txtEngName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(621, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel2.Size = New System.Drawing.Size(371, 84)
        Me.Panel2.TabIndex = 1
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.cbGender)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(1106, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel3.Size = New System.Drawing.Size(253, 84)
        Me.Panel3.TabIndex = 2
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
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.picStudent)
        Me.Panel13.Controls.Add(Me.IconButton1)
        Me.Panel13.Location = New System.Drawing.Point(1495, 60)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(150, 244)
        Me.Panel13.TabIndex = 10
        '
        'picStudent
        '
        Me.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudent.Location = New System.Drawing.Point(0, 0)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(150, 193)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStudent.TabIndex = 50
        Me.picStudent.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Transparent
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(0, 211)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(150, 32)
        Me.IconButton1.TabIndex = 10
        Me.IconButton1.Text = "ជ្រើសរើសរូបភាព"
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.cbAddress)
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Location = New System.Drawing.Point(621, 143)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel9.Size = New System.Drawing.Size(371, 84)
        Me.Panel9.TabIndex = 4
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
        Me.Panel16.Location = New System.Drawing.Point(121, 143)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel16.Size = New System.Drawing.Size(371, 84)
        Me.Panel16.TabIndex = 3
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
        Me.Panel8.Location = New System.Drawing.Point(1106, 143)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel8.Size = New System.Drawing.Size(253, 84)
        Me.Panel8.TabIndex = 5
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
        'btnChooseStudent
        '
        Me.btnChooseStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnChooseStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnChooseStudent.FlatAppearance.BorderSize = 0
        Me.btnChooseStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseStudent.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseStudent.ForeColor = System.Drawing.Color.White
        Me.btnChooseStudent.Location = New System.Drawing.Point(767, 373)
        Me.btnChooseStudent.Name = "btnChooseStudent"
        Me.btnChooseStudent.Size = New System.Drawing.Size(151, 44)
        Me.btnChooseStudent.TabIndex = 12
        Me.btnChooseStudent.Text = "ជ្រើសរើសសិស្ស"
        Me.btnChooseStudent.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(958, 373)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 44)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "សម្អាត"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(570, 373)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(151, 44)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "ចុះឈ្មោះ"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbRoom)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Location = New System.Drawing.Point(1106, 229)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel4.Size = New System.Drawing.Size(252, 73)
        Me.Panel4.TabIndex = 111
        '
        'lbRoom
        '
        Me.lbRoom.BorderColor = System.Drawing.Color.DimGray
        Me.lbRoom.BorderRadius = 8
        Me.lbRoom.BorderThickness = 2
        Me.lbRoom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbRoom.DefaultText = ""
        Me.lbRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lbRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lbRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbRoom.DisabledState.Parent = Me.lbRoom
        Me.lbRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbRoom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lbRoom.FocusedState.FillColor = System.Drawing.Color.White
        Me.lbRoom.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.lbRoom.FocusedState.Parent = Me.lbRoom
        Me.lbRoom.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRoom.ForeColor = System.Drawing.Color.Black
        Me.lbRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbRoom.HoverState.Parent = Me.lbRoom
        Me.lbRoom.Location = New System.Drawing.Point(0, 31)
        Me.lbRoom.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.lbRoom.Name = "lbRoom"
        Me.lbRoom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lbRoom.PlaceholderForeColor = System.Drawing.Color.Black
        Me.lbRoom.PlaceholderText = ""
        Me.lbRoom.ReadOnly = True
        Me.lbRoom.SelectedText = ""
        Me.lbRoom.ShadowDecoration.Parent = Me.lbRoom
        Me.lbRoom.Size = New System.Drawing.Size(252, 39)
        Me.lbRoom.TabIndex = 110
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label31.Location = New System.Drawing.Point(3, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 29)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "បន្ទប់ ៖"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelSearch.Controls.Add(Me.cbSearchTeacher)
        Me.PanelSearch.Controls.Add(Me.Button1)
        Me.PanelSearch.Controls.Add(Me.txtSearch)
        Me.PanelSearch.Location = New System.Drawing.Point(3, 439)
        Me.PanelSearch.Margin = New System.Windows.Forms.Padding(3, 7, 3, 10)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Padding = New System.Windows.Forms.Padding(15)
        Me.PanelSearch.Size = New System.Drawing.Size(1678, 60)
        Me.PanelSearch.TabIndex = 20
        '
        'cbSearchTeacher
        '
        Me.cbSearchTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cbSearchTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchTeacher.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchTeacher.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cbSearchTeacher.FormattingEnabled = True
        Me.cbSearchTeacher.ItemHeight = 24
        Me.cbSearchTeacher.Location = New System.Drawing.Point(364, 16)
        Me.cbSearchTeacher.Name = "cbSearchTeacher"
        Me.cbSearchTeacher.Size = New System.Drawing.Size(197, 32)
        Me.cbSearchTeacher.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(587, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 41)
        Me.Button1.TabIndex = 3
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
        Me.txtSearch.Location = New System.Drawing.Point(5, 9)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtSearch.PasswordChar = False
        Me.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtSearch.PlaceholderText = "ស្វែងរក ឈ្មោះមុខវីជ្ជា ឬ ClassID"
        Me.txtSearch.Size = New System.Drawing.Size(340, 39)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Texts = ""
        Me.txtSearch.UnderlinedStyle = False
        '
        'PanelListShow
        '
        Me.PanelListShow.BorderRadius = 15
        Me.PanelListShow.Controls.Add(Me.DataGridView1)
        Me.PanelListShow.Controls.Add(Me.Label36)
        Me.PanelListShow.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelListShow.Location = New System.Drawing.Point(3, 512)
        Me.PanelListShow.Name = "PanelListShow"
        Me.PanelListShow.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelListShow.ShadowDecoration.Parent = Me.PanelListShow
        Me.PanelListShow.Size = New System.Drawing.Size(1678, 391)
        Me.PanelListShow.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(5, 59)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
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
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1668, 327)
        Me.DataGridView1.TabIndex = 4
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label36.Font = New System.Drawing.Font("Khmer OS Koulen", 16.0!)
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(5, 5)
        Me.Label36.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.Label36.Name = "Label36"
        Me.Label36.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label36.Size = New System.Drawing.Size(1668, 54)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "បញ្ជីវគ្គសិក្សា"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me.PanelRegister
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 15
        Me.Guna2Elipse2.TargetControl = Me.PanelSearch
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "វគ្គសិក្សា៖"
        '
        'cbCourse
        '
        Me.cbCourse.BackColor = System.Drawing.Color.Transparent
        Me.cbCourse.BorderColor = System.Drawing.Color.DimGray
        Me.cbCourse.BorderRadius = 8
        Me.cbCourse.BorderThickness = 2
        Me.cbCourse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbCourse.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbCourse.FocusedState.Parent = Me.cbCourse
        Me.cbCourse.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.ForeColor = System.Drawing.Color.Black
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbCourse.HoverState.FillColor = System.Drawing.Color.White
        Me.cbCourse.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbCourse.HoverState.Parent = Me.cbCourse
        Me.cbCourse.ItemHeight = 35
        Me.cbCourse.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbCourse.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbCourse.ItemsAppearance.Parent = Me.cbCourse
        Me.cbCourse.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbCourse.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbCourse.Location = New System.Drawing.Point(0, 30)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.ShadowDecoration.Parent = Me.cbCourse
        Me.cbCourse.Size = New System.Drawing.Size(371, 41)
        Me.cbCourse.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.cbCourse)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(121, 229)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel6.Size = New System.Drawing.Size(371, 74)
        Me.Panel6.TabIndex = 6
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1720, 982)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegisterForm"
        Me.Padding = New System.Windows.Forms.Padding(15, 15, 0, 15)
        Me.Text = "Student"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PanelRegister.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelListShow.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenPic As OpenFileDialog
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents cbSearchTeacher As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As CustomControls.RJControls.RJTextBox
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents btnChooseStudent As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents PanelListShow As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label36 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents cbTime As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtKhName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtEngName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents picStudent As PictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel9 As Panel
    Friend WithEvents cbAddress As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDob As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtPay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbRoom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
End Class
