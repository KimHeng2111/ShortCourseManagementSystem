<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Me.txtSearchStudent = New CustomControls.RJControls.RJTextBox()
        Me.btnSerach = New CustomControls.RJControls.RJButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearchStudent
        '
        Me.txtSearchStudent.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearchStudent.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.txtSearchStudent.BorderFocusColor = System.Drawing.Color.HotPink
        Me.txtSearchStudent.BorderRadius = 20
        Me.txtSearchStudent.BorderSize = 2
        Me.txtSearchStudent.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearchStudent.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchStudent.Location = New System.Drawing.Point(0, 0)
        Me.txtSearchStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchStudent.Multiline = False
        Me.txtSearchStudent.Name = "txtSearchStudent"
        Me.txtSearchStudent.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtSearchStudent.PasswordChar = False
        Me.txtSearchStudent.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtSearchStudent.PlaceholderText = "ស្វែងរកសិស្ស តាម លេខសម្គាល់ ឬ ឈ្មោះ"
        Me.txtSearchStudent.Size = New System.Drawing.Size(493, 44)
        Me.txtSearchStudent.TabIndex = 0
        Me.txtSearchStudent.Texts = ""
        Me.txtSearchStudent.UnderlinedStyle = False
        '
        'btnSerach
        '
        Me.btnSerach.BackColor = System.Drawing.Color.Transparent
        Me.btnSerach.BackgroundColor = System.Drawing.Color.Transparent
        Me.btnSerach.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnSerach.BorderRadius = 20
        Me.btnSerach.BorderSize = 0
        Me.btnSerach.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSerach.FlatAppearance.BorderSize = 0
        Me.btnSerach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSerach.ForeColor = System.Drawing.Color.White
        Me.btnSerach.Image = Global.StudentManagementSystem.My.Resources.Resources.search
        Me.btnSerach.Location = New System.Drawing.Point(491, 0)
        Me.btnSerach.Name = "btnSerach"
        Me.btnSerach.Size = New System.Drawing.Size(47, 47)
        Me.btnSerach.TabIndex = 1
        Me.btnSerach.TextColor = System.Drawing.Color.White
        Me.btnSerach.UseVisualStyleBackColor = False
        Me.btnSerach.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSearchStudent)
        Me.Panel1.Controls.Add(Me.btnSerach)
        Me.Panel1.Location = New System.Drawing.Point(1091, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 47)
        Me.Panel1.TabIndex = 2
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1650, 840)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Student"
        Me.Text = "Student"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSearchStudent As CustomControls.RJControls.RJTextBox
    Friend WithEvents btnSerach As CustomControls.RJControls.RJButton
    Friend WithEvents Panel1 As Panel
End Class
