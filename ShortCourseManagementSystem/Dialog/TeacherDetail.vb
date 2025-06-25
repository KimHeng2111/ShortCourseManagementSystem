Public Class TeacherDetail
    Dim teacher As Teacher = New Teacher()
    Public Sub New(teacher As Teacher)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.teacher = teacher
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub FillData()
        txtID.Text = teacher.TeacherID
        txtkhName.Text = teacher.KhName
        txtEngName.Text = teacher.EngName
        txtGender.Text = teacher.Gender
        txtAddress.Text = teacher.Address
        txtDob.Text = teacher.DoB
        txtPhone.Text = teacher.Phone
        txtEmail.Text = teacher.Email
        picTeacher.ImageLocation = teacher.Picture
    End Sub
    Sub Display()
        Dim query As String = "SELECT tblCourse.ID, tblSubject.Subject, tblSchedule.Schedule, tblRoom.Room, tblCourse.CurrentEnrollment, tblCourseStatus.Status
                                FROM tblRoom INNER JOIN (tblSubject INNER JOIN (tblSchedule INNER JOIN ((tblCourseStatus 
                                INNER JOIN tblCourse ON tblCourseStatus.ID = tblCourse.StatusID) INNER JOIN tblRegister ON tblCourse.ID = tblRegister.CourseID)
                                ON tblSchedule.ID = tblCourse.ScheduleID) ON tblSubject.ID = tblCourse.SubjectID) ON tblRoom.ID = tblCourse.RoomID
                                WHERE (((tblCourse.TeacherID)=@teacherID));"
        Dim cmd As New OleDb.OleDbCommand(query, teacher.GetConnection())
        cmd.Parameters.AddWithValue("@teacherID", teacher.TeacherID)
        DataGridView1.DataSource = teacher.ExecuteQuery(cmd)
        Regonize()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        FillData()
        Display()
    End Sub
    Sub Regonize()
        ' Customize DataGridView columns
        DataGridView1.ColumnHeadersHeight = 40
        DataGridView1.Columns(0).Width = 75
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(1).HeaderText = "វគ្គសិក្សា"
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(2).HeaderText = "វេនសិក្សា"
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(3).HeaderText = "បន្ទប់"
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(4).HeaderText = "សិស្សសរុប"
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(5).HeaderText = "ស្ថានភាព"
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 1 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
            End If
        Next i
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        DataGridView1.ClearSelection()
    End Sub
End Class