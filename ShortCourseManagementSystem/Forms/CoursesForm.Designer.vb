<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CoursesForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSearch = New CustomControls.RJControls.RJTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDes = New CustomControls.RJControls.RJTextBox()
        Me.btmCreate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCourseName = New CustomControls.RJControls.RJTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDuration = New CustomControls.RJControls.RJTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBasePrice = New CustomControls.RJControls.RJTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Location = New System.Drawing.Point(12, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1680, 919)
        Me.Panel5.TabIndex = 2
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 359)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1680, 560)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnClear)
        Me.Panel7.Controls.Add(Me.txtSearch)
        Me.Panel7.Controls.Add(Me.btnAdd)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 287)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1680, 72)
        Me.Panel7.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(376, 16)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 41)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "សម្អាត"
        Me.btnClear.UseVisualStyleBackColor = False
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
        Me.txtSearch.Location = New System.Drawing.Point(9, 18)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtSearch.PasswordChar = False
        Me.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtSearch.PlaceholderText = "ស្វែងរក ឈ្មោះ ឬ ID"
        Me.txtSearch.Size = New System.Drawing.Size(340, 39)
        Me.txtSearch.TabIndex = 17
        Me.txtSearch.Texts = ""
        Me.txtSearch.UnderlinedStyle = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(574, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 41)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "បង្កើតវគ្គសិក្សាថ្មី"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btmCreate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1680, 287)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(779, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 29)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "បង្កើតវគ្គសិក្សាថ្មី"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(901, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(170, 41)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "បោះបង់"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtDes)
        Me.Panel4.Location = New System.Drawing.Point(168, 106)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 30, 35, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(654, 110)
        Me.Panel4.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(95, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 29)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "៖"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ការពិពណ៌នា"
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDes.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtDes.BorderRadius = 0
        Me.txtDes.BorderSize = 2
        Me.txtDes.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDes.Location = New System.Drawing.Point(128, 0)
        Me.txtDes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDes.Multiline = True
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtDes.PasswordChar = False
        Me.txtDes.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtDes.PlaceholderText = ""
        Me.txtDes.Size = New System.Drawing.Size(522, 106)
        Me.txtDes.TabIndex = 15
        Me.txtDes.Texts = ""
        Me.txtDes.UnderlinedStyle = False
        '
        'btmCreate
        '
        Me.btmCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.btmCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btmCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btmCreate.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmCreate.ForeColor = System.Drawing.Color.White
        Me.btmCreate.Location = New System.Drawing.Point(609, 235)
        Me.btmCreate.Name = "btmCreate"
        Me.btmCreate.Size = New System.Drawing.Size(170, 41)
        Me.btmCreate.TabIndex = 10
        Me.btmCreate.Text = "រក្សាទុក"
        Me.btmCreate.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCourseName)
        Me.Panel2.Location = New System.Drawing.Point(168, 45)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 35, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 54)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "៖"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ឈ្មោះវគ្គសិក្សា"
        '
        'txtCourseName
        '
        Me.txtCourseName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCourseName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourseName.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtCourseName.BorderRadius = 0
        Me.txtCourseName.BorderSize = 2
        Me.txtCourseName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCourseName.Location = New System.Drawing.Point(131, 8)
        Me.txtCourseName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCourseName.Multiline = False
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtCourseName.PasswordChar = False
        Me.txtCourseName.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtCourseName.PlaceholderText = ""
        Me.txtCourseName.Size = New System.Drawing.Size(519, 39)
        Me.txtCourseName.TabIndex = 16
        Me.txtCourseName.Texts = ""
        Me.txtCourseName.UnderlinedStyle = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtDuration)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(1120, 45)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(30, 3, 35, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 54)
        Me.Panel3.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 29)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "៖"
        '
        'txtDuration
        '
        Me.txtDuration.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuration.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDuration.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtDuration.BorderRadius = 0
        Me.txtDuration.BorderSize = 2
        Me.txtDuration.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDuration.Location = New System.Drawing.Point(100, 8)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDuration.Multiline = False
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtDuration.PasswordChar = False
        Me.txtDuration.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtDuration.PlaceholderText = ""
        Me.txtDuration.Size = New System.Drawing.Size(220, 39)
        Me.txtDuration.TabIndex = 17
        Me.txtDuration.Texts = ""
        Me.txtDuration.UnderlinedStyle = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "រយៈពេល"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(ម៉ោង)"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.txtBasePrice)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(1120, 134)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(30, 30, 35, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(393, 54)
        Me.Panel6.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 29)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "៖"
        '
        'txtBasePrice
        '
        Me.txtBasePrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtBasePrice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBasePrice.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtBasePrice.BorderRadius = 0
        Me.txtBasePrice.BorderSize = 2
        Me.txtBasePrice.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBasePrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBasePrice.Location = New System.Drawing.Point(100, 10)
        Me.txtBasePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBasePrice.Multiline = False
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtBasePrice.PasswordChar = False
        Me.txtBasePrice.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtBasePrice.PlaceholderText = ""
        Me.txtBasePrice.Size = New System.Drawing.Size(220, 39)
        Me.txtBasePrice.TabIndex = 18
        Me.txtBasePrice.Texts = ""
        Me.txtBasePrice.UnderlinedStyle = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "តម្លៃ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "($)"
        '
        'CoursesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1704, 943)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CoursesForm"
        Me.Text = "Courses"
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btmCreate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtDes As CustomControls.RJControls.RJTextBox
    Friend WithEvents txtCourseName As CustomControls.RJControls.RJTextBox
    Friend WithEvents txtDuration As CustomControls.RJControls.RJTextBox
    Friend WithEvents txtBasePrice As CustomControls.RJControls.RJTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As CustomControls.RJControls.RJTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClear As Button
End Class
