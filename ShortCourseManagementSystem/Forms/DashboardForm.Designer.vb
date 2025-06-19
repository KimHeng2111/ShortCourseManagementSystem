<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbCompleteStudent = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbTotalStudnet = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lbCompleteClass = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbTotalClass = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbActionTeacher = New System.Windows.Forms.Label()
        Me.lbTotalTeacher = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel4 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbActionCourse = New System.Windows.Forms.Label()
        Me.lbTotalCourse = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.StudentChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CourseChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.Guna2CustomGradientPanel4.SuspendLayout()
        CType(Me.StudentChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.Controls.Add(Me.StudentChart)
        Me.Guna2Panel1.Controls.Add(Me.CourseChart)
        Me.Guna2Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(15, 15)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1674, 913)
        Me.Guna2Panel1.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Guna2CustomGradientPanel4)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 30)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1674, 201)
        Me.FlowLayoutPanel2.TabIndex = 5
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 10
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label24)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label25)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label13)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lbCompleteStudent)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label12)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lbTotalStudnet)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(3, 18)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 75, 3)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Quality = 20
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(350, 164)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(18, 824)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 161)
        Me.Panel1.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(280, 108)
        Me.Label24.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 29)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "នាក់"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label25.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(280, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 29)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "នាក់"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(10, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 29)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "សិស្សបានបញ្ចប់ ៖"
        '
        'lbCompleteStudent
        '
        Me.lbCompleteStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbCompleteStudent.BackColor = System.Drawing.Color.Transparent
        Me.lbCompleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbCompleteStudent.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompleteStudent.ForeColor = System.Drawing.Color.White
        Me.lbCompleteStudent.Location = New System.Drawing.Point(159, 104)
        Me.lbCompleteStudent.Name = "lbCompleteStudent"
        Me.lbCompleteStudent.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lbCompleteStudent.Size = New System.Drawing.Size(125, 36)
        Me.lbCompleteStudent.TabIndex = 5
        Me.lbCompleteStudent.Text = "10"
        Me.lbCompleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(10, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 29)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "សិស្សសរុប ៖"
        '
        'lbTotalStudnet
        '
        Me.lbTotalStudnet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbTotalStudnet.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalStudnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTotalStudnet.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalStudnet.ForeColor = System.Drawing.Color.White
        Me.lbTotalStudnet.Location = New System.Drawing.Point(159, 56)
        Me.lbTotalStudnet.Name = "lbTotalStudnet"
        Me.lbTotalStudnet.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lbTotalStudnet.Size = New System.Drawing.Size(125, 36)
        Me.lbTotalStudnet.TabIndex = 3
        Me.lbTotalStudnet.Text = "10"
        Me.lbTotalStudnet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(350, 43)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "សិស្ស"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel2.BorderRadius = 10
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label7)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label26)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label27)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lbCompleteClass)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label16)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label15)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lbTotalClass)
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(431, 18)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 85, 3)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel2
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(350, 164)
        Me.Guna2CustomGradientPanel2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(350, 43)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "វគ្គសិក្សា"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(271, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(66, 29)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "វគ្គសិក្សា"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(271, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 29)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "វគ្គសិក្សា"
        '
        'lbCompleteClass
        '
        Me.lbCompleteClass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbCompleteClass.BackColor = System.Drawing.Color.Transparent
        Me.lbCompleteClass.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompleteClass.ForeColor = System.Drawing.Color.White
        Me.lbCompleteClass.Location = New System.Drawing.Point(177, 108)
        Me.lbCompleteClass.Name = "lbCompleteClass"
        Me.lbCompleteClass.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbCompleteClass.Size = New System.Drawing.Size(96, 36)
        Me.lbCompleteClass.TabIndex = 6
        Me.lbCompleteClass.Text = "10"
        Me.lbCompleteClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(3, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 29)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "វគ្គសិក្សាបានបញ្ចប់ ៖"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(3, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 29)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "វគ្គសិក្សាសរុប ៖"
        '
        'lbTotalClass
        '
        Me.lbTotalClass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbTotalClass.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalClass.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalClass.ForeColor = System.Drawing.Color.White
        Me.lbTotalClass.Location = New System.Drawing.Point(171, 60)
        Me.lbTotalClass.Name = "lbTotalClass"
        Me.lbTotalClass.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbTotalClass.Size = New System.Drawing.Size(102, 36)
        Me.lbTotalClass.TabIndex = 3
        Me.lbTotalClass.Text = "10"
        Me.lbTotalClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel3.BorderRadius = 10
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label9)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label8)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label20)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbActionTeacher)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbTotalTeacher)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label19)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.Label18)
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(869, 18)
        Me.Guna2CustomGradientPanel3.Margin = New System.Windows.Forms.Padding(3, 3, 85, 3)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel3
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(350, 164)
        Me.Guna2CustomGradientPanel3.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label9.Size = New System.Drawing.Size(350, 43)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "គ្រូបង្រៀន"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(300, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "នាក់"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(300, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 29)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "នាក់"
        '
        'lbActionTeacher
        '
        Me.lbActionTeacher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbActionTeacher.BackColor = System.Drawing.Color.Transparent
        Me.lbActionTeacher.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbActionTeacher.ForeColor = System.Drawing.Color.White
        Me.lbActionTeacher.Location = New System.Drawing.Point(159, 108)
        Me.lbActionTeacher.Name = "lbActionTeacher"
        Me.lbActionTeacher.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbActionTeacher.Size = New System.Drawing.Size(128, 36)
        Me.lbActionTeacher.TabIndex = 10
        Me.lbActionTeacher.Text = "10"
        Me.lbActionTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalTeacher
        '
        Me.lbTotalTeacher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbTotalTeacher.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalTeacher.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalTeacher.ForeColor = System.Drawing.Color.White
        Me.lbTotalTeacher.Location = New System.Drawing.Point(153, 60)
        Me.lbTotalTeacher.Name = "lbTotalTeacher"
        Me.lbTotalTeacher.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbTotalTeacher.Size = New System.Drawing.Size(134, 36)
        Me.lbTotalTeacher.TabIndex = 9
        Me.lbTotalTeacher.Text = "10"
        Me.lbTotalTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(3, 108)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(129, 29)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "គ្រូបង្រៀនសកម្ម ៖"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(123, 29)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "គ្រូបង្រៀនសរុប ៖"
        '
        'Guna2CustomGradientPanel4
        '
        Me.Guna2CustomGradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel4.BorderRadius = 10
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label11)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label10)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label23)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.lbActionCourse)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.lbTotalCourse)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label22)
        Me.Guna2CustomGradientPanel4.Controls.Add(Me.Label21)
        Me.Guna2CustomGradientPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel4.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2CustomGradientPanel4.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Guna2CustomGradientPanel4.Location = New System.Drawing.Point(1307, 18)
        Me.Guna2CustomGradientPanel4.Name = "Guna2CustomGradientPanel4"
        Me.Guna2CustomGradientPanel4.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel4
        Me.Guna2CustomGradientPanel4.Size = New System.Drawing.Size(350, 164)
        Me.Guna2CustomGradientPanel4.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label11.Size = New System.Drawing.Size(350, 43)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "មុខវិជ្ជា"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(280, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 36)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "មុខវិជ្ជា"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(280, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 36)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "មុខវិជ្ជា"
        '
        'lbActionCourse
        '
        Me.lbActionCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbActionCourse.BackColor = System.Drawing.Color.Transparent
        Me.lbActionCourse.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbActionCourse.ForeColor = System.Drawing.Color.White
        Me.lbActionCourse.Location = New System.Drawing.Point(155, 108)
        Me.lbActionCourse.Name = "lbActionCourse"
        Me.lbActionCourse.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbActionCourse.Size = New System.Drawing.Size(119, 36)
        Me.lbActionCourse.TabIndex = 10
        Me.lbActionCourse.Text = "10"
        Me.lbActionCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalCourse
        '
        Me.lbTotalCourse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbTotalCourse.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalCourse.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalCourse.ForeColor = System.Drawing.Color.White
        Me.lbTotalCourse.Location = New System.Drawing.Point(155, 60)
        Me.lbTotalCourse.Name = "lbTotalCourse"
        Me.lbTotalCourse.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbTotalCourse.Size = New System.Drawing.Size(119, 36)
        Me.lbTotalCourse.TabIndex = 9
        Me.lbTotalCourse.Text = "10"
        Me.lbTotalCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(33, 108)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 36)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "មុខវិជ្ជាសកម្ម ៖"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Khmer OS Koulen", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(33, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 36)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "មុខវិជ្ជាសរុប ៖"
        '
        'StudentChart
        '
        Me.StudentChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        Me.StudentChart.BorderlineColor = System.Drawing.Color.Black
        Me.StudentChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.StudentChart.BorderlineWidth = 0
        ChartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea1.AxisX.LabelAutoFitStyle = CType((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.Interval = 0R
        ChartArea1.AxisX.MajorTickMark.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.MajorTickMark.LineWidth = 0
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.LineColor = System.Drawing.SystemColors.ActiveCaptionText
        ChartArea1.CursorX.LineWidth = 0
        ChartArea1.CursorX.SelectionColor = System.Drawing.Color.DimGray
        ChartArea1.CursorY.LineColor = System.Drawing.Color.MistyRose
        ChartArea1.CursorY.LineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.StudentChart.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Legend1.BorderWidth = 0
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Legend1.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Legend1.InterlacedRows = True
        Legend1.IsTextAutoFit = False
        Legend1.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
        Legend1.Name = "Legend1"
        Legend1.ShadowColor = System.Drawing.Color.Transparent
        Legend1.TitleBackColor = System.Drawing.Color.White
        Legend1.TitleFont = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.TitleForeColor = System.Drawing.Color.BlanchedAlmond
        Me.StudentChart.Legends.Add(Legend1)
        Me.StudentChart.Location = New System.Drawing.Point(0, 212)
        Me.StudentChart.Name = "StudentChart"
        Me.StudentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.BackImageTransparentColor = System.Drawing.Color.White
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series1.CustomProperties = "MaxPixelPointWidth=75, EmptyPointValue=Zero, DrawSideBySide=True, MinPixelPointWi" &
    "dth=20"
        Series1.EmptyPointStyle.Color = System.Drawing.Color.LightGray
        Series1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsVisibleInLegend = False
        Series1.Label = "#VAL{0""នាក់""}"
        Series1.LabelAngle = 2
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series1.LabelBorderWidth = 0
        Series1.Legend = "Legend1"
        Series1.MarkerBorderWidth = 0
        Series1.MarkerColor = System.Drawing.Color.Black
        Series1.Name = "Subject"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel
        Series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent
        Series1.XValueMember = "20"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YValueMembers = "10"
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.StudentChart.Series.Add(Series1)
        Me.StudentChart.Size = New System.Drawing.Size(1067, 687)
        Me.StudentChart.TabIndex = 6
        Me.StudentChart.Text = "ស្ថិតិសិស្ស"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.Font = New System.Drawing.Font("Khmer OS Moul", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "ចំនួនសិស្សក្នុងមុខវិជ្ជានិមួយៗ"
        Me.StudentChart.Titles.Add(Title1)
        '
        'CourseChart
        '
        Me.CourseChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CourseChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
        Me.CourseChart.BorderlineColor = System.Drawing.Color.Black
        Me.CourseChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.CourseChart.BorderlineWidth = 0
        ChartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines
        ChartArea2.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea2.AxisX.LabelAutoFitStyle = CType((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea2.AxisX.LineWidth = 0
        ChartArea2.AxisX.MajorGrid.LineWidth = 0
        ChartArea2.AxisX.MajorTickMark.Interval = 0R
        ChartArea2.AxisX.MajorTickMark.LineWidth = 0
        ChartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.MajorTickMark.LineWidth = 0
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.CursorX.IsUserEnabled = True
        ChartArea2.CursorX.LineColor = System.Drawing.SystemColors.ActiveCaptionText
        ChartArea2.CursorX.LineWidth = 0
        ChartArea2.CursorX.SelectionColor = System.Drawing.Color.DimGray
        ChartArea2.CursorY.LineColor = System.Drawing.Color.MistyRose
        ChartArea2.CursorY.LineWidth = 0
        ChartArea2.Name = "ChartArea1"
        Me.CourseChart.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Legend2.BorderWidth = 0
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend2.Font = New System.Drawing.Font("Khmer OS Siemreap", 10.0!)
        Legend2.InterlacedRows = True
        Legend2.IsTextAutoFit = False
        Legend2.ItemColumnSpacing = 20
        Legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder
        Legend2.MaximumAutoSize = 100.0!
        Legend2.Name = "Legend1"
        Legend2.ShadowColor = System.Drawing.Color.Transparent
        Legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide
        Legend2.TitleAlignment = System.Drawing.StringAlignment.Near
        Legend2.TitleBackColor = System.Drawing.Color.White
        Legend2.TitleFont = New System.Drawing.Font("Khmer OS Siemreap", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.TitleForeColor = System.Drawing.Color.BlanchedAlmond
        Me.CourseChart.Legends.Add(Legend2)
        Me.CourseChart.Location = New System.Drawing.Point(1085, 212)
        Me.CourseChart.Name = "CourseChart"
        Me.CourseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series2.BackImageTransparentColor = System.Drawing.Color.White
        Series2.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Series2.BorderWidth = 0
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.EmptyPointStyle.AxisLabel = """"""
        Series2.EmptyPointStyle.Color = System.Drawing.Color.LightGray
        Series2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.Label = "#VAL{0""វគ្គ""}"
        Series2.LabelBackColor = System.Drawing.Color.Transparent
        Series2.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Series2.LabelBorderWidth = 0
        Series2.Legend = "Legend1"
        Series2.LegendText = "#VALX #VAL{00""វគ្គ""}"
        Series2.MarkerBorderWidth = 0
        Series2.MarkerColor = System.Drawing.Color.Black
        Series2.Name = "Subject"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel
        Series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Transparent
        Series2.XValueMember = "20"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series2.YValueMembers = "10"
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.CourseChart.Series.Add(Series2)
        Me.CourseChart.Size = New System.Drawing.Size(589, 687)
        Me.CourseChart.TabIndex = 7
        Me.CourseChart.Text = "ស្ថិតិសិស្ស"
        Title2.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title2.Font = New System.Drawing.Font("Khmer OS Moul", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "ទិន្ន័យវគ្គសិក្សា"
        Me.CourseChart.Titles.Add(Title2)
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1704, 943)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "DashboardForm"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "DashboardForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        Me.Guna2CustomGradientPanel4.ResumeLayout(False)
        Me.Guna2CustomGradientPanel4.PerformLayout()
        CType(Me.StudentChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents StudentChart As DataVisualization.Charting.Chart
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbCompleteStudent As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbTotalStudnet As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lbCompleteClass As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbTotalClass As Label
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbActionTeacher As Label
    Friend WithEvents lbTotalTeacher As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Guna2CustomGradientPanel4 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbActionCourse As Label
    Friend WithEvents lbTotalCourse As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CourseChart As DataVisualization.Charting.Chart
End Class
