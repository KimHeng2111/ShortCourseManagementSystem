<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.crsReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.cbReport = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2Panel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(15, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(1674, 913)
        Me.Panel2.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.crsReport)
        Me.Guna2Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1664, 903)
        Me.Guna2Panel2.TabIndex = 2
        '
        'crsReport
        '
        Me.crsReport.ActiveViewIndex = -1
        Me.crsReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crsReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crsReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crsReport.Location = New System.Drawing.Point(0, 58)
        Me.crsReport.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.crsReport.Name = "crsReport"
        Me.crsReport.ShowCloseButton = False
        Me.crsReport.ShowGotoPageButton = False
        Me.crsReport.ShowGroupTreeButton = False
        Me.crsReport.ShowLogo = False
        Me.crsReport.ShowPageNavigateButtons = False
        Me.crsReport.ShowParameterPanelButton = False
        Me.crsReport.ShowRefreshButton = False
        Me.crsReport.ShowTextSearchButton = False
        Me.crsReport.Size = New System.Drawing.Size(1664, 845)
        Me.crsReport.TabIndex = 0
        Me.crsReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2Panel1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1664, 58)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.btnPrint)
        Me.Guna2Panel1.Controls.Add(Me.cbReport)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1682, 55)
        Me.Guna2Panel1.TabIndex = 9
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(1521, 3)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(137, 45)
        Me.Guna2Button2.TabIndex = 11
        Me.Guna2Button2.Text = "Export"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderRadius = 5
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(1338, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.PressedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(137, 45)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        '
        'cbReport
        '
        Me.cbReport.BackColor = System.Drawing.Color.Transparent
        Me.cbReport.BorderColor = System.Drawing.Color.DimGray
        Me.cbReport.BorderRadius = 8
        Me.cbReport.BorderThickness = 2
        Me.cbReport.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbReport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbReport.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbReport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbReport.FocusedState.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReport.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.cbReport.FocusedState.Parent = Me.cbReport
        Me.cbReport.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReport.ForeColor = System.Drawing.Color.Black
        Me.cbReport.FormattingEnabled = True
        Me.cbReport.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.cbReport.HoverState.FillColor = System.Drawing.Color.White
        Me.cbReport.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbReport.HoverState.Parent = Me.cbReport
        Me.cbReport.ItemHeight = 35
        Me.cbReport.Items.AddRange(New Object() {"របាយការណ៍សិស្ស", "របាយការណ៍គ្រូបង្រៀន", "របាយការណ៍វគ្គសិក្សា", "របាយការណ៍មុខវិជ្ជា", "របាយការណ៍បង់ប្រាក់", "សូមជ្រើសរើសរបាយការណ៍"})
        Me.cbReport.ItemsAppearance.BackColor = System.Drawing.Color.White
        Me.cbReport.ItemsAppearance.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReport.ItemsAppearance.ForeColor = System.Drawing.Color.Black
        Me.cbReport.ItemsAppearance.Parent = Me.cbReport
        Me.cbReport.ItemsAppearance.SelectedBackColor = System.Drawing.Color.White
        Me.cbReport.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black
        Me.cbReport.Location = New System.Drawing.Point(128, 5)
        Me.cbReport.Name = "cbReport"
        Me.cbReport.ShadowDecoration.Parent = Me.cbReport
        Me.cbReport.Size = New System.Drawing.Size(405, 41)
        Me.cbReport.StartIndex = 5
        Me.cbReport.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 45)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "របាយការណ៍  ៖"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1704, 943)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ReportForm"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "ReportForm"
        Me.Panel2.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents crsReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As Label
    Friend WithEvents cbReport As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
End Class
