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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btmCreate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtBasePrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(765, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Management"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Location = New System.Drawing.Point(12, 412)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1680, 519)
        Me.Panel5.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1674, 446)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btmCreate)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Location = New System.Drawing.Point(12, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1680, 302)
        Me.Panel1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1143, 258)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 41)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(865, 258)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 41)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(607, 258)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(170, 41)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btmCreate
        '
        Me.btmCreate.Location = New System.Drawing.Point(368, 258)
        Me.btmCreate.Name = "btmCreate"
        Me.btmCreate.Size = New System.Drawing.Size(170, 41)
        Me.btmCreate.TabIndex = 10
        Me.btmCreate.Text = "CreateNewCourse"
        Me.btmCreate.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.txtCourseName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(249, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 35, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(463, 37)
        Me.Panel2.TabIndex = 6
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(143, 0)
        Me.txtCourseName.Margin = New System.Windows.Forms.Padding(3, 3, 25, 3)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(320, 37)
        Me.txtCourseName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Course Name :"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtDuration)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(249, 112)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(30, 3, 35, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(463, 37)
        Me.Panel3.TabIndex = 8
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(143, 0)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(3, 3, 25, 3)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(247, 37)
        Me.txtDuration.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DurationHours :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(hours)"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtDes)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(843, 46)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 30, 35, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(589, 132)
        Me.Panel4.TabIndex = 7
        '
        'txtDes
        '
        Me.txtDes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDes.Location = New System.Drawing.Point(159, 0)
        Me.txtDes.Multiline = True
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(427, 127)
        Me.txtDes.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course Description :"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtBasePrice)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Location = New System.Drawing.Point(249, 182)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(30, 30, 35, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(463, 37)
        Me.Panel6.TabIndex = 9
        '
        'txtBasePrice
        '
        Me.txtBasePrice.Location = New System.Drawing.Point(143, 0)
        Me.txtBasePrice.Margin = New System.Windows.Forms.Padding(3, 3, 25, 3)
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.Size = New System.Drawing.Size(247, 37)
        Me.txtBasePrice.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "BasePrice :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "($)"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CoursesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1704, 943)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS Siemreap", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CoursesForm"
        Me.Text = "Courses"
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btmCreate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtDes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtBasePrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
