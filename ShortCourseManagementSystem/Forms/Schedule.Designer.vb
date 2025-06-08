<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Schedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Schedule))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'cbDay
        '
        Me.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbDay, "cbDay")
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {resources.GetString("cbDay.Items"), resources.GetString("cbDay.Items1"), resources.GetString("cbDay.Items2")})
        Me.cbDay.Name = "cbDay"
        '
        'cbTime
        '
        resources.ApplyResources(Me.cbTime, "cbTime")
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Name = "cbTime"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.cbTime)
        Me.Panel1.Controls.Add(Me.cbDay)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        resources.ApplyResources(Me.DataGridView2, "DataGridView2")
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowTemplate.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Schedule
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Schedule"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbDay As ComboBox
    Friend WithEvents cbTime As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
End Class
