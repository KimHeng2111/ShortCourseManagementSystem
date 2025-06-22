<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.cbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dtpEndDate = New CustomControls.RJControls.RJDatePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbRoom = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbSchedule = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbTeacher = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbSubject = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtCourseID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.dtpStartDate = New CustomControls.RJControls.RJDatePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNewClass = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbSearchStatus = New System.Windows.Forms.ComboBox()
        Me.cbSearchTeacher = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearch = New CustomControls.RJControls.RJTextBox()
        Me.DataSet1 = New StudentManagementSystem.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnRoom)
        Me.Panel2.Controls.Add(Me.btnTime)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnNewClass)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1674, 366)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Khmer Muol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1674, 49)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "ព័ត៌មានវគ្គសិក្សា"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.cbStatus)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Location = New System.Drawing.Point(1397, 176)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel11.Size = New System.Drawing.Size(185, 80)
        Me.Panel11.TabIndex = 90
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.Transparent
        Me.cbStatus.BorderColor = System.Drawing.Color.DimGray
        Me.cbStatus.BorderRadius = 8
        Me.cbStatus.BorderThickness = 2
        Me.cbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbStatus.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbStatus.FocusedState.Parent = Me.cbStatus
        Me.cbStatus.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.ForeColor = System.Drawing.Color.Black
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbStatus.HoverState.FillColor = System.Drawing.Color.White
        Me.cbStatus.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbStatus.HoverState.Parent = Me.cbStatus
        Me.cbStatus.ItemHeight = 35
        Me.cbStatus.Items.AddRange(New Object() {"ឆាប់ៗនេះ", "កំពុងសិក្សា", "បានបញ្ចប់", "ត្រូវបានបោះបង់ចោល"})
        Me.cbStatus.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbStatus.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbStatus.ItemsAppearance.Parent = Me.cbStatus
        Me.cbStatus.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbStatus.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbStatus.Location = New System.Drawing.Point(0, 36)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.ShadowDecoration.Parent = Me.cbStatus
        Me.cbStatus.Size = New System.Drawing.Size(185, 41)
        Me.cbStatus.StartIndex = 0
        Me.cbStatus.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ស្ថានភាពវគ្គសិក្សា"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dtpEndDate)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(942, 176)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel5.Size = New System.Drawing.Size(364, 80)
        Me.Panel5.TabIndex = 89
        '
        'dtpEndDate
        '
        Me.dtpEndDate.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.dtpEndDate.BorderSize = 0
        Me.dtpEndDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEndDate.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(0, 42)
        Me.dtpEndDate.MinimumSize = New System.Drawing.Size(4, 35)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(364, 35)
        Me.dtpEndDate.SkinColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpEndDate.TabIndex = 6
        Me.dtpEndDate.TextColor = System.Drawing.Color.Black
        Me.dtpEndDate.Value = New Date(2025, 6, 22, 20, 52, 55, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 29)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "កាលបរិច្ឋេទបញ្ចប់ការសិក្សា៖"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.cbRoom)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(92, 176)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel8.Size = New System.Drawing.Size(371, 80)
        Me.Panel8.TabIndex = 88
        '
        'cbRoom
        '
        Me.cbRoom.BackColor = System.Drawing.Color.Transparent
        Me.cbRoom.BorderColor = System.Drawing.Color.DimGray
        Me.cbRoom.BorderRadius = 8
        Me.cbRoom.BorderThickness = 2
        Me.cbRoom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbRoom.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoom.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbRoom.FocusedState.Parent = Me.cbRoom
        Me.cbRoom.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoom.ForeColor = System.Drawing.Color.Black
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbRoom.HoverState.FillColor = System.Drawing.Color.White
        Me.cbRoom.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbRoom.HoverState.Parent = Me.cbRoom
        Me.cbRoom.ItemHeight = 35
        Me.cbRoom.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbRoom.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoom.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbRoom.ItemsAppearance.Parent = Me.cbRoom
        Me.cbRoom.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbRoom.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbRoom.Location = New System.Drawing.Point(0, 36)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.ShadowDecoration.Parent = Me.cbRoom
        Me.cbRoom.Size = New System.Drawing.Size(371, 41)
        Me.cbRoom.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "បន្ទប់រៀន"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.cbSchedule)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(1233, 63)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel6.Size = New System.Drawing.Size(371, 80)
        Me.Panel6.TabIndex = 87
        '
        'cbSchedule
        '
        Me.cbSchedule.BackColor = System.Drawing.Color.Transparent
        Me.cbSchedule.BorderColor = System.Drawing.Color.DimGray
        Me.cbSchedule.BorderRadius = 8
        Me.cbSchedule.BorderThickness = 2
        Me.cbSchedule.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbSchedule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSchedule.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbSchedule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbSchedule.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSchedule.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbSchedule.FocusedState.Parent = Me.cbSchedule
        Me.cbSchedule.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSchedule.ForeColor = System.Drawing.Color.Black
        Me.cbSchedule.FormattingEnabled = True
        Me.cbSchedule.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbSchedule.HoverState.FillColor = System.Drawing.Color.White
        Me.cbSchedule.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbSchedule.HoverState.Parent = Me.cbSchedule
        Me.cbSchedule.ItemHeight = 35
        Me.cbSchedule.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbSchedule.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSchedule.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbSchedule.ItemsAppearance.Parent = Me.cbSchedule
        Me.cbSchedule.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbSchedule.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbSchedule.Location = New System.Drawing.Point(0, 36)
        Me.cbSchedule.Name = "cbSchedule"
        Me.cbSchedule.ShadowDecoration.Parent = Me.cbSchedule
        Me.cbSchedule.Size = New System.Drawing.Size(371, 41)
        Me.cbSchedule.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "វេនសិក្សា"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.cbTeacher)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(761, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel4.Size = New System.Drawing.Size(371, 80)
        Me.Panel4.TabIndex = 86
        '
        'cbTeacher
        '
        Me.cbTeacher.BackColor = System.Drawing.Color.Transparent
        Me.cbTeacher.BorderColor = System.Drawing.Color.DimGray
        Me.cbTeacher.BorderRadius = 8
        Me.cbTeacher.BorderThickness = 2
        Me.cbTeacher.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTeacher.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbTeacher.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTeacher.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbTeacher.FocusedState.Parent = Me.cbTeacher
        Me.cbTeacher.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTeacher.ForeColor = System.Drawing.Color.Black
        Me.cbTeacher.FormattingEnabled = True
        Me.cbTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbTeacher.HoverState.FillColor = System.Drawing.Color.White
        Me.cbTeacher.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbTeacher.HoverState.Parent = Me.cbTeacher
        Me.cbTeacher.ItemHeight = 35
        Me.cbTeacher.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbTeacher.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTeacher.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbTeacher.ItemsAppearance.Parent = Me.cbTeacher
        Me.cbTeacher.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbTeacher.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbTeacher.Location = New System.Drawing.Point(0, 36)
        Me.cbTeacher.Name = "cbTeacher"
        Me.cbTeacher.ShadowDecoration.Parent = Me.cbTeacher
        Me.cbTeacher.Size = New System.Drawing.Size(371, 41)
        Me.cbTeacher.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "គ្រូបង្រៀន"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.cbSubject)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(307, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel3.Size = New System.Drawing.Size(371, 80)
        Me.Panel3.TabIndex = 85
        '
        'cbSubject
        '
        Me.cbSubject.BackColor = System.Drawing.Color.Transparent
        Me.cbSubject.BorderColor = System.Drawing.Color.DimGray
        Me.cbSubject.BorderRadius = 8
        Me.cbSubject.BorderThickness = 2
        Me.cbSubject.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubject.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbSubject.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubject.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbSubject.FocusedState.Parent = Me.cbSubject
        Me.cbSubject.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubject.ForeColor = System.Drawing.Color.Black
        Me.cbSubject.FormattingEnabled = True
        Me.cbSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbSubject.HoverState.FillColor = System.Drawing.Color.White
        Me.cbSubject.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbSubject.HoverState.Parent = Me.cbSubject
        Me.cbSubject.ItemHeight = 35
        Me.cbSubject.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbSubject.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubject.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbSubject.ItemsAppearance.Parent = Me.cbSubject
        Me.cbSubject.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbSubject.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbSubject.Location = New System.Drawing.Point(0, 36)
        Me.cbSubject.Name = "cbSubject"
        Me.cbSubject.ShadowDecoration.Parent = Me.cbSubject
        Me.cbSubject.Size = New System.Drawing.Size(371, 41)
        Me.cbSubject.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "មុខវិជ្ជា៖"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.txtCourseID)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Location = New System.Drawing.Point(70, 63)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel7.Size = New System.Drawing.Size(148, 80)
        Me.Panel7.TabIndex = 84
        '
        'txtCourseID
        '
        Me.txtCourseID.BorderColor = System.Drawing.Color.DimGray
        Me.txtCourseID.BorderRadius = 8
        Me.txtCourseID.BorderThickness = 2
        Me.txtCourseID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourseID.DefaultText = ""
        Me.txtCourseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCourseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCourseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourseID.DisabledState.Parent = Me.txtCourseID
        Me.txtCourseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourseID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtCourseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtCourseID.FocusedState.FillColor = System.Drawing.Color.White
        Me.txtCourseID.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.txtCourseID.FocusedState.Parent = Me.txtCourseID
        Me.txtCourseID.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.ForeColor = System.Drawing.Color.Black
        Me.txtCourseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourseID.HoverState.Parent = Me.txtCourseID
        Me.txtCourseID.Location = New System.Drawing.Point(0, 36)
        Me.txtCourseID.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourseID.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtCourseID.PlaceholderText = ""
        Me.txtCourseID.SelectedText = ""
        Me.txtCourseID.ShadowDecoration.Parent = Me.txtCourseID
        Me.txtCourseID.Size = New System.Drawing.Size(148, 41)
        Me.txtCourseID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "លេខកូដវគ្គសិក្សា៖"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(441, 302)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(151, 44)
        Me.btnEdit.TabIndex = 83
        Me.btnEdit.Text = "រក្សាទុក"
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'btnRoom
        '
        Me.btnRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoom.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoom.ForeColor = System.Drawing.Color.White
        Me.btnRoom.Location = New System.Drawing.Point(852, 302)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(169, 44)
        Me.btnRoom.TabIndex = 82
        Me.btnRoom.Text = "គ្រប់គ្រងបន្ទប់រៀន"
        Me.btnRoom.UseVisualStyleBackColor = False
        '
        'btnTime
        '
        Me.btnTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTime.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.ForeColor = System.Drawing.Color.White
        Me.btnTime.Location = New System.Drawing.Point(626, 302)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(169, 44)
        Me.btnTime.TabIndex = 81
        Me.btnTime.Text = "គ្រប់គ្រងវេនសិក្សា"
        Me.btnTime.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.dtpStartDate)
        Me.Panel10.Controls.Add(Me.Label16)
        Me.Panel10.ForeColor = System.Drawing.Color.Black
        Me.Panel10.Location = New System.Drawing.Point(515, 176)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Panel10.Size = New System.Drawing.Size(364, 80)
        Me.Panel10.TabIndex = 79
        '
        'dtpStartDate
        '
        Me.dtpStartDate.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.dtpStartDate.BorderSize = 0
        Me.dtpStartDate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpStartDate.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(0, 42)
        Me.dtpStartDate.MinimumSize = New System.Drawing.Size(4, 35)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(364, 35)
        Me.dtpStartDate.SkinColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpStartDate.TabIndex = 5
        Me.dtpStartDate.TextColor = System.Drawing.Color.Black
        Me.dtpStartDate.Value = New Date(2025, 6, 22, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 29)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "កាលបរិច្ឋេទចូលរៀន៖"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1082, 302)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 44)
        Me.btnCancel.TabIndex = 75
        Me.btnCancel.Text = "បោះបង់"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnNewClass
        '
        Me.btnNewClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNewClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnNewClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewClass.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewClass.ForeColor = System.Drawing.Color.White
        Me.btnNewClass.Location = New System.Drawing.Point(442, 302)
        Me.btnNewClass.Name = "btnNewClass"
        Me.btnNewClass.Size = New System.Drawing.Size(151, 44)
        Me.btnNewClass.TabIndex = 76
        Me.btnNewClass.Text = "រក្សាទុក"
        Me.btnNewClass.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.DataGridView1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(15, 453)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1674, 475)
        Me.Panel9.TabIndex = 3
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
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1674, 475)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbSearchStatus)
        Me.Panel1.Controls.Add(Me.cbSearchTeacher)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 381)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel1.Size = New System.Drawing.Size(1674, 72)
        Me.Panel1.TabIndex = 1
        '
        'cbSearchStatus
        '
        Me.cbSearchStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cbSearchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchStatus.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchStatus.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cbSearchStatus.FormattingEnabled = True
        Me.cbSearchStatus.ItemHeight = 24
        Me.cbSearchStatus.Location = New System.Drawing.Point(601, 20)
        Me.cbSearchStatus.Name = "cbSearchStatus"
        Me.cbSearchStatus.Size = New System.Drawing.Size(154, 32)
        Me.cbSearchStatus.TabIndex = 31
        '
        'cbSearchTeacher
        '
        Me.cbSearchTeacher.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cbSearchTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchTeacher.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchTeacher.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cbSearchTeacher.FormattingEnabled = True
        Me.cbSearchTeacher.ItemHeight = 24
        Me.cbSearchTeacher.Location = New System.Drawing.Point(396, 20)
        Me.cbSearchTeacher.Name = "cbSearchTeacher"
        Me.cbSearchTeacher.Size = New System.Drawing.Size(197, 32)
        Me.cbSearchTeacher.TabIndex = 24
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(772, 16)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 41)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "សម្អាត"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(970, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 41)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "បង្កើតថ្នាក់រៀនថ្មី"
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.txtSearch.Location = New System.Drawing.Point(36, 17)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtSearch.PasswordChar = False
        Me.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtSearch.PlaceholderText = "ស្វែងរក ឈ្មោះមុខវីជ្ជា ឬ ClassID"
        Me.txtSearch.Size = New System.Drawing.Size(340, 39)
        Me.txtSearch.TabIndex = 30
        Me.txtSearch.Texts = ""
        Me.txtSearch.UnderlinedStyle = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'CourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1704, 943)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "CourseForm"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "ManageClassForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNewClass As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSearch As CustomControls.RJControls.RJTextBox
    Friend WithEvents cbSearchTeacher As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbSearchStatus As ComboBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnTime As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents cbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dtpEndDate As CustomControls.RJControls.RJDatePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cbRoom As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbSchedule As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbTeacher As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cbSubject As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtCourseID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents dtpStartDate As CustomControls.RJControls.RJDatePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet1BindingSource As BindingSource
End Class
