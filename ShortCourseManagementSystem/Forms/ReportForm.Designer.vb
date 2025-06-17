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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbReport = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2Panel2)
        Me.Panel2.Controls.Add(Me.Panel1)
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
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(286, 5)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1383, 903)
        Me.Guna2Panel2.TabIndex = 2
        '
        'crsReport
        '
        Me.crsReport.ActiveViewIndex = -1
        Me.crsReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crsReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.crsReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crsReport.Location = New System.Drawing.Point(0, 0)
        Me.crsReport.Name = "crsReport"
        Me.crsReport.ShowCloseButton = False
        Me.crsReport.ShowGotoPageButton = False
        Me.crsReport.ShowGroupTreeButton = False
        Me.crsReport.ShowLogo = False
        Me.crsReport.ShowPageNavigateButtons = False
        Me.crsReport.ShowParameterPanelButton = False
        Me.crsReport.ShowRefreshButton = False
        Me.crsReport.ShowTextSearchButton = False
        Me.crsReport.Size = New System.Drawing.Size(1383, 903)
        Me.crsReport.TabIndex = 0
        Me.crsReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.cbReport)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 903)
        Me.Panel1.TabIndex = 1
        '
        'cbReport
        '
        Me.cbReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbReport.BackColor = System.Drawing.Color.Transparent
        Me.cbReport.BorderColor = System.Drawing.Color.DimGray
        Me.cbReport.BorderRadius = 8
        Me.cbReport.BorderThickness = 2
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
        Me.cbReport.Location = New System.Drawing.Point(12, 75)
        Me.cbReport.Name = "cbReport"
        Me.cbReport.ShadowDecoration.Parent = Me.cbReport
        Me.cbReport.Size = New System.Drawing.Size(266, 41)
        Me.cbReport.StartIndex = 5
        Me.cbReport.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(88, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "របាយការណ៍ "
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents crsReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As Label
    Friend WithEvents cbReport As Guna.UI2.WinForms.Guna2ComboBox
End Class
