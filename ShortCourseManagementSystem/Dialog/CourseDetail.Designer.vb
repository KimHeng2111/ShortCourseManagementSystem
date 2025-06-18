<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseDetail
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.txtTeacher = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CachedInvoice1 = New StudentManagementSystem.CachedInvoice()
        Me.CachedInvoice2 = New StudentManagementSystem.CachedInvoice()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(6, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 809)
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
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 336)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(949, 473)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(949, 38)
        Me.Panel2.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Moul Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(438, 7)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 24)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "បញ្ជីសិស្ស"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panel3.Controls.Add(Me.dtpEndDate)
        Me.panel3.Controls.Add(Me.cbStatus)
        Me.panel3.Controls.Add(Me.btnUpdate)
        Me.panel3.Controls.Add(Me.btnCancel)
        Me.panel3.Controls.Add(Me.txtStatus)
        Me.panel3.Controls.Add(Me.Label7)
        Me.panel3.Controls.Add(Me.btnSave)
        Me.panel3.Controls.Add(Me.txtEndDate)
        Me.panel3.Controls.Add(Me.txtStartDate)
        Me.panel3.Controls.Add(Me.Label17)
        Me.panel3.Controls.Add(Me.txtTotal)
        Me.panel3.Controls.Add(Me.txtRoom)
        Me.panel3.Controls.Add(Me.txtSchedule)
        Me.panel3.Controls.Add(Me.txtTeacher)
        Me.panel3.Controls.Add(Me.txtCourse)
        Me.panel3.Controls.Add(Me.txtID)
        Me.panel3.Controls.Add(Me.Label8)
        Me.panel3.Controls.Add(Me.Label9)
        Me.panel3.Controls.Add(Me.Label6)
        Me.panel3.Controls.Add(Me.Label5)
        Me.panel3.Controls.Add(Me.Label4)
        Me.panel3.Controls.Add(Me.Label3)
        Me.panel3.Controls.Add(Me.Label2)
        Me.panel3.Controls.Add(Me.Label1)
        Me.panel3.Controls.Add(Me.Label11)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(949, 298)
        Me.panel3.TabIndex = 0
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "   dd/MM/yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(441, 183)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowUpDown = True
        Me.dtpEndDate.Size = New System.Drawing.Size(173, 31)
        Me.dtpEndDate.TabIndex = 34
        Me.dtpEndDate.Value = New Date(2025, 6, 10, 22, 44, 3, 0)
        Me.dtpEndDate.Visible = False
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(770, 182)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 32)
        Me.cbStatus.TabIndex = 33
        Me.cbStatus.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(389, 241)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(170, 41)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "ធ្វើបច្ចុប្បន្នភាព"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(511, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(170, 41)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "បោះបង់"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(771, 180)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(113, 35)
        Me.txtStatus.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(651, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 27)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ស្ថានភាពថ្នាក់ ៖"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(265, 241)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 41)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "រក្សាទុក"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'txtEndDate
        '
        Me.txtEndDate.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndDate.Location = New System.Drawing.Point(442, 180)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(172, 35)
        Me.txtEndDate.TabIndex = 27
        '
        'txtStartDate
        '
        Me.txtStartDate.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartDate.Location = New System.Drawing.Point(114, 180)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.ReadOnly = True
        Me.txtStartDate.Size = New System.Drawing.Size(172, 35)
        Me.txtStartDate.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(766, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 27)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "នាក់"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(637, 123)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(113, 35)
        Me.txtTotal.TabIndex = 15
        '
        'txtRoom
        '
        Me.txtRoom.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(350, 123)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.ReadOnly = True
        Me.txtRoom.Size = New System.Drawing.Size(113, 35)
        Me.txtRoom.TabIndex = 14
        '
        'txtSchedule
        '
        Me.txtSchedule.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedule.Location = New System.Drawing.Point(96, 123)
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.ReadOnly = True
        Me.txtSchedule.Size = New System.Drawing.Size(172, 35)
        Me.txtSchedule.TabIndex = 13
        '
        'txtTeacher
        '
        Me.txtTeacher.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacher.Location = New System.Drawing.Point(656, 65)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.ReadOnly = True
        Me.txtTeacher.Size = New System.Drawing.Size(245, 35)
        Me.txtTeacher.TabIndex = 12
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(299, 65)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(245, 35)
        Me.txtCourse.TabIndex = 11
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(96, 65)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(113, 35)
        Me.txtID.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(311, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 27)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "ថ្ងៃបញ្ចប់វគ្គសិក្សា ៖"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 27)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ថ្ងៃចូលរៀន ៖"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(513, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 27)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ចំនូនសិស្សសរុប ៖"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "បន្ទប់ ៖"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "វេនសិក្សា ៖"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(570, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "គ្រូបង្រៀន ៖"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "វគ្គសិក្សា ៖"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ClassID :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS Moul Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(390, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 24)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ព័ត៌មានថ្នាក់រៀនលម្ពិត"
        '
        'ClassDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(961, 827)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "ClassDetail"
        Me.Padding = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.Text = "ClassDetial"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents txtSchedule As TextBox
    Friend WithEvents txtTeacher As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents CachedInvoice1 As CachedInvoice
    Friend WithEvents CachedInvoice2 As CachedInvoice
End Class
