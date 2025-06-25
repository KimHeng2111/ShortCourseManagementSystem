Public Class SubjectDetail
    Dim subject As New Subject()
    Public Sub New(course As Subject)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.subject = course
        FillCourseDetails()
        Display()
    End Sub
    Sub Display()
        Dim query As String = "SELECT tblCourse.ID, tblTeacher.KhName AS Teacher, tblRoom.Room AS Room, tblSchedule.Schedule, tblCourse.CurrentEnrollment, tblCourseStatus.Status
FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourseStatus INNER JOIN tblCourse ON tblCourseStatus.ID = tblCourse.StatusID) ON tblRoom.ID = tblCourse.RoomID) ON tblSchedule.ID = tblCourse.ScheduleID) ON tblTeacher.ID = tblCourse.TeacherID
WHERE tblCourse.SubjectID = @ID;"
        Dim cmd As New OleDb.OleDbCommand(query, subject.GetConnection())
        cmd.Parameters.AddWithValue("@ID", subject.ID)
        DataGridView1.DataSource = subject.ExecuteQuery(cmd)
        DataGridView1.ColumnHeadersHeight = 40
        'DataGridView1.AllowUserToResizeColumns = True
        'Customize DataGridView columns
        DataGridView1.Columns(0).Width = 75
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(0).HeaderText = "ClassID"
        DataGridView1.Columns(1).HeaderText = "គ្រូបង្រៀន"
        DataGridView1.Columns(2).HeaderText = "បន្ទប់"
        DataGridView1.Columns(3).HeaderText = "វេនសិក្សា"
        DataGridView1.Columns(4).HeaderText = "សិស្សសរុប"
        DataGridView1.Columns(5).HeaderText = "ស្ថានភាព"
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 1 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
            End If
            For j As Integer = 3 To DataGridView1.Columns.Count - 1
                DataGridView1.Rows(i).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next j
        Next i
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        DataGridView1.ClearSelection()
    End Sub
    Sub FillCourseDetails()
        txtSubject.Text = subject.Subject
        txtDes.Text = subject.Description.ToString()
        txtDuration.Text = subject.CreditHours.ToString()
        txtBasePrice.Text = subject.basePrice.ToString("F2")
    End Sub

    'Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '    Me.Close()
    'End Sub

    'Private Sub btmCreate_Click(sender As Object, e As EventArgs) Handles btmCreate.Click
    '    'Cheack Filed
    '    If Not CheckField() Then
    '        Return
    '    Else
    'subject.Subject = txtCourseName.Texts.Trim()
    'subject.basePrice = Convert.ToDecimal(txtBasePrice.Texts.Trim())
    'subject.CreditHours = Convert.ToInt32(txtDuration.Texts.Trim())
    'subject.Description = txtDes.Texts.Trim()
    'subject.UpdateSubject()
    'Display()
    '    End If
    'End Sub
    'Function CheckField() As Boolean
    '    Dim courseName As String = txtCourseName.Texts.Trim()
    '    Dim description As String = txtDes.Texts.Trim()
    '    Dim duration As String = txtDuration.Texts.Trim()
    '    Dim basePrice As String = txtBasePrice.Texts.Trim()
    '    If String.IsNullOrEmpty(courseName) Then
    '        MessageBox.Show("ឈ្មោះវគ្គសិក្សាមិនត្រឹមត្រូវ", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End If
    '    If String.IsNullOrEmpty(description) Then
    '        MessageBox.Show("ការពិពណ៌រនាមិនត្រឹមត្រូវ", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End If
    '    If String.IsNullOrEmpty(duration) OrElse Not IsNumeric(duration) Then
    '        MessageBox.Show("សូមបញ្ជូលរយៈពលេសិក្សា", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End If
    '    If String.IsNullOrEmpty(basePrice) OrElse Not IsNumeric(basePrice) Then
    '        MessageBox.Show("សូមបញ្ជូលតម្លៃវគ្គសិក្សា", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End If
    '    Return True
    'End Function
End Class