<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageClassForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.dtpStartDate = New CustomControls.RJControls.RJDatePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNewClass = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbTeacher = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbRoom = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbSearchTeacher = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearch = New CustomControls.RJControls.RJTextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnRoom)
        Me.Panel2.Controls.Add(Me.btnTime)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnNewClass)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1674, 282)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(445, 218)
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
        Me.btnRoom.Location = New System.Drawing.Point(855, 218)
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
        Me.btnTime.Location = New System.Drawing.Point(629, 218)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(169, 44)
        Me.btnTime.TabIndex = 81
        Me.btnTime.Text = "គ្រប់គ្រងវេនសិក្សា"
        Me.btnTime.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.dtpStartDate)
        Me.Panel10.Controls.Add(Me.Label15)
        Me.Panel10.Controls.Add(Me.Label16)
        Me.Panel10.ForeColor = System.Drawing.Color.Black
        Me.Panel10.Location = New System.Drawing.Point(232, 138)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(364, 41)
        Me.Panel10.TabIndex = 79
        '
        'dtpStartDate
        '
        Me.dtpStartDate.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.dtpStartDate.BorderSize = 0
        Me.dtpStartDate.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(164, 2)
        Me.dtpStartDate.MinimumSize = New System.Drawing.Size(4, 35)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(197, 35)
        Me.dtpStartDate.SkinColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpStartDate.TabIndex = 16
        Me.dtpStartDate.TextColor = System.Drawing.Color.Black
        Me.dtpStartDate.Value = New Date(2025, 6, 3, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(141, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 29)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 29)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "កាលបរិច្ឋេទចូលរៀន"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(1085, 218)
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
        Me.btnNewClass.Location = New System.Drawing.Point(445, 218)
        Me.btnNewClass.Name = "btnNewClass"
        Me.btnNewClass.Size = New System.Drawing.Size(151, 44)
        Me.btnNewClass.TabIndex = 76
        Me.btnNewClass.Text = "រក្សាទុក"
        Me.btnNewClass.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.cbTime)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.ForeColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(681, 135)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(364, 41)
        Me.Panel8.TabIndex = 8
        '
        'cbTime
        '
        Me.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTime.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Location = New System.Drawing.Point(91, 2)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(270, 37)
        Me.cbTime.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(74, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 29)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 29)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "វេនសិក្សា"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cbTeacher)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(1108, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(364, 41)
        Me.Panel6.TabIndex = 6
        '
        'cbTeacher
        '
        Me.cbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTeacher.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbTeacher.FormattingEnabled = True
        Me.cbTeacher.Location = New System.Drawing.Point(167, 2)
        Me.cbTeacher.Name = "cbTeacher"
        Me.cbTeacher.Size = New System.Drawing.Size(197, 37)
        Me.cbTeacher.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(129, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 29)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 29)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "គ្រូបង្រៀន"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cbRoom)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(1108, 135)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(364, 41)
        Me.Panel5.TabIndex = 5
        '
        'cbRoom
        '
        Me.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRoom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbRoom.FormattingEnabled = True
        Me.cbRoom.Location = New System.Drawing.Point(164, 3)
        Me.cbRoom.Name = "cbRoom"
        Me.cbRoom.Size = New System.Drawing.Size(197, 37)
        Me.cbRoom.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(129, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 29)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 29)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "បន្ទប់សិក្សា"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbCourse)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(681, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(364, 41)
        Me.Panel4.TabIndex = 4
        '
        'cbCourse
        '
        Me.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Location = New System.Drawing.Point(89, 1)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(272, 37)
        Me.cbCourse.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "មុខវិជ្ជា"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtClassID)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(232, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(364, 41)
        Me.Panel3.TabIndex = 3
        '
        'txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(164, 3)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.Size = New System.Drawing.Size(197, 37)
        Me.txtClassID.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "លេខកូដថ្នាក់រៀន"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Moul Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(781, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ព័ត៌មានថ្នាក់រៀន"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.DataGridView1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(15, 369)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1674, 559)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
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
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1674, 559)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.cbSearchTeacher)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 297)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel1.Size = New System.Drawing.Size(1674, 72)
        Me.Panel1.TabIndex = 1
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.ItemHeight = 24
        Me.cbStatus.Location = New System.Drawing.Point(601, 20)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(154, 32)
        Me.cbStatus.TabIndex = 31
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
        'ManageClassForm
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
        Me.Name = "ManageClassForm"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "ManageClassForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNewClass As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpStartDate As CustomControls.RJControls.RJDatePicker
    Friend WithEvents cbTime As ComboBox
    Friend WithEvents cbRoom As ComboBox
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents cbTeacher As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSearch As CustomControls.RJControls.RJTextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbSearchTeacher As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRoom As Button
    Friend WithEvents btnTime As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtClassID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnEdit As Button
End Class
