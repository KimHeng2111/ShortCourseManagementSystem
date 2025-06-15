<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoom = New CustomControls.RJControls.RJTextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 277)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(495, 308)
        Me.Panel2.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Moul Light", 9.75!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(201, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "បញ្ជីបន្ទប់រៀន"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(254, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Khmer OS Siemreap", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView2.Location = New System.Drawing.Point(5, 81)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "48745"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 35
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS Siemreap", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.RowTemplate.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(485, 222)
        Me.DataGridView2.TabIndex = 63
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.txtRoom)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 224)
        Me.Panel1.TabIndex = 66
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClear.Location = New System.Drawing.Point(338, 148)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 31)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "សម្អាត"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelete.Location = New System.Drawing.Point(201, 148)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 31)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "លុប"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdd.Location = New System.Drawing.Point(60, 148)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 31)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "បន្ថែម"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(25, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ឈ្មោះបន្ទប់៖"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Moul", 11.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(172, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 27)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "គ្រប់គ្រងបន្ទប់រៀន"
        '
        'txtRoom
        '
        Me.txtRoom.BackColor = System.Drawing.SystemColors.Window
        Me.txtRoom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoom.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtRoom.BorderRadius = 0
        Me.txtRoom.BorderSize = 2
        Me.txtRoom.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRoom.Location = New System.Drawing.Point(124, 48)
        Me.txtRoom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoom.Multiline = False
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtRoom.PasswordChar = False
        Me.txtRoom.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtRoom.PlaceholderText = ""
        Me.txtRoom.Size = New System.Drawing.Size(345, 39)
        Me.txtRoom.TabIndex = 17
        Me.txtRoom.Texts = ""
        Me.txtRoom.UnderlinedStyle = False
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(495, 585)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(511, 624)
        Me.MinimumSize = New System.Drawing.Size(511, 624)
        Me.Name = "Room"
        Me.Text = "Room"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRoom As CustomControls.RJControls.RJTextBox
End Class
