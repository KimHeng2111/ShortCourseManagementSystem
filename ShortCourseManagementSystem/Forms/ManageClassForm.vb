Imports System.Data.OleDb

Public Class ManageClassForm
    Dim manageClass As ManageClass = New ManageClass()
    Dim startup As Boolean = True
    'GetData From Class ManageClass
    Private Sub display()
        DataGridView2.DataSource = manageClass.GetClassData()
        If DataGridView2.Columns.Count = 7 Then
            DataGridView2.Columns(0).Width = 100
            DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(1).Width = 250
            DataGridView2.Columns(1).HeaderText = "វគ្គសិក្សា"
            DataGridView2.Columns(2).Width = 200
            DataGridView2.Columns(2).HeaderText = "គ្រូបង្រៀន"
            DataGridView2.Columns(3).Width = 150
            DataGridView2.Columns(3).HeaderText = "បន្ទប់"
            DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(4).Width = 200
            DataGridView2.Columns(4).HeaderText = "វេនសិក្សា"
            DataGridView2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(5).Width = 150
            DataGridView2.Columns(5).HeaderText = "សិស្សសរុប"
            DataGridView2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(6).Width = 200
            DataGridView2.Columns(6).HeaderText = "ស្ថានភាព"
            DataGridView2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                If i Mod 2 = 1 Then
                    DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
                Else
                    DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
                End If
            Next i
        End If
        DataGridView2.ClearSelection()
    End Sub
    Sub GetCbTime()
        Dim timeList = manageClass.GetTimeList()
        timeList.Add("ជ្រើសរើសវេនសិក្សា", -1)
        cbTime.DataSource = New BindingSource(timeList, Nothing)
        cbTime.DisplayMember = "Key"
        cbTime.ValueMember = "Value"
        cbTime.SelectedIndex = cbTime.Items.Count - 1
    End Sub
    Sub GetCbRoom()
        Dim RoomList = manageClass.GetRoomList()
        RoomList.Add("ជ្រើសរើសបន្ទប់រៀន", -1)
        cbRoom.DataSource = New BindingSource(RoomList, Nothing)
        cbRoom.DisplayMember = "Key"
        cbRoom.ValueMember = "Value"
        cbRoom.SelectedIndex = cbRoom.Items.Count - 1
    End Sub
    Sub GetCbTeacher()
        Dim teacherList = manageClass.GetTeacherList()
        teacherList.Add("ជ្រើសរើសគ្រូបង្រៀន", "-1")
        cbTeacher.DataSource = New BindingSource(teacherList, Nothing)
        cbTeacher.DisplayMember = "Key"
        cbTeacher.ValueMember = "Value"
        cbTeacher.SelectedIndex = cbTeacher.Items.Count - 1
    End Sub
    Sub GetcbCourse()
        Dim courseList = manageClass.GetCourseList()
        courseList.Add("ជ្រើសរើសវគ្គសិក្សា", -1)
        cbCourse.DataSource = New BindingSource(courseList, Nothing)
        cbCourse.DisplayMember = "Key"
        cbCourse.ValueMember = "Value"
    End Sub
    Sub GetcbSearch()
        Dim teacherList = manageClass.GetTeacherList()
        teacherList.Add("គ្រប់គ្រូទាំងអស់", "%")
        cbSearchTeacher.DataSource = New BindingSource(teacherList, Nothing)
        cbSearchTeacher.DisplayMember = "Key"
        cbSearchTeacher.ValueMember = "Value"
        cbSearchTeacher.SelectedIndex = cbSearchTeacher.Items.Count - 1
    End Sub
    Private Sub btnNewClass_Click(sender As Object, e As EventArgs) Handles btnNewClass.Click
        If CheckField() Then
            manageClass.classID = txtClassID.Text.Trim()
            manageClass.scheduleID = Convert.ToInt32(cbTime.SelectedValue.ToString())
            manageClass.roomID = Convert.ToInt32(cbRoom.SelectedValue.ToString())
            manageClass.teacher.TeacherID = cbTeacher.SelectedValue.ToString()
            manageClass.course.courseID = cbCourse.SelectedValue.ToString()
            manageClass.startDate = dtpStartDate.Value
        End If
        manageClass.AddClass()
        display()
    End Sub

    'Check User Input
    Private Function CheckField() As Boolean
        Dim ClassName As String = txtClassID.Text.Trim()
        Dim TimeID As Integer = Convert.ToInt32(cbTime.SelectedValue)
        Dim RoomID As Integer = Convert.ToInt32(cbRoom.SelectedValue)
        Dim TeacherID As Integer = cbTeacher.SelectedValue
        Dim CourseID As Integer = cbCourse.SelectedValue
        manageClass.startDate = dtpStartDate.Value
        If String.IsNullOrEmpty(ClassName) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If TimeID <= 0 Or RoomID <= 0 Or TeacherID <= 0 Or CourseID <= 0 Then
            MessageBox.Show("Please select valid options for time, room, teacher, and course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If CheckField() Then
            Dim id As String = txtClassID.Text.Trim()
            Dim courseID As String = cbCourse.SelectedValue.ToString()
            Dim teacherID As String = cbTeacher.SelectedValue.ToString()
            Dim startDate As String = dtpStartDate.Value
            Dim roomID As Integer = Convert.ToInt32(cbRoom.SelectedValue)
            Dim secheduleID As Integer = Convert.ToInt32(cbTime.SelectedValue)
            manageClass.UpdateClass(id, courseID, teacherID, startDate, roomID, secheduleID)
        End If
        display()
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint
        display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbSearchTeacher.SelectedIndex = cbSearchTeacher.Items.Count - 1
        txtSearch.Texts = ""
    End Sub

    'Insert DATA To DataGridView
    Private Sub InsertData(data As DataTable)
        DataGridView2.DataSource = data
        If DataGridView2.Columns.Count = 7 Then
            DataGridView2.Columns(0).Width = 100
            DataGridView2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(1).Width = 250
            DataGridView2.Columns(1).HeaderText = "វគ្គសិក្សា"
            DataGridView2.Columns(2).Width = 200
            DataGridView2.Columns(2).HeaderText = "គ្រូបង្រៀន"
            DataGridView2.Columns(3).Width = 150
            DataGridView2.Columns(3).HeaderText = "បន្ទប់"
            DataGridView2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(4).Width = 200
            DataGridView2.Columns(4).HeaderText = "វេនសិក្សា"
            DataGridView2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(5).Width = 150
            DataGridView2.Columns(5).HeaderText = "សិស្សសរុប"
            DataGridView2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView2.Columns(6).Width = 200
            DataGridView2.Columns(6).HeaderText = "ស្ថានភាព"
            DataGridView2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                If i Mod 2 = 1 Then
                    DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
                Else
                    DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
                End If
            Next i
        End If
        DataGridView2.ClearSelection()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        GetCbTime()
        GetCbRoom()
        GetCbTeacher()
        GetcbCourse()
        GetcbSearch()
    End Sub

    Private Sub txtSearch__TextChanged(sender As Object, e As EventArgs) Handles txtSearch._TextChanged
        If startup Then

        Else
            Dim textSearch = If(txtSearch.Texts.Trim() = "", "%", txtSearch.Texts.Trim()) + "%"
            Dim teacherSearch = cbSearchTeacher.SelectedValue
            Dim query As String = " SELECT tblClass.ClassID, tblCourses.CourseName AS Course, tblTeacher.KhName AS Teacher, tblRoom.Room AS Room, tblSchedule.Schedule, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudents, tblClassStatus.Status
                            FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblTeacher.ID = tblClass.TeacherID
                            GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.Room, tblSchedule.Schedule, tblClassStatus.Status, tblTeacher.ID 
                            HAVING ((((tblClass.ClassID) Like @Classid) OR ((tblCourses.CourseName) Like @Classid)) AND ((tblTeacher.ID) Like @Teacher));"
            Dim cmd As New OleDbCommand(query, manageClass.GetConnection())
            cmd.Parameters.AddWithValue("@Classid", textSearch)
            cmd.Parameters.AddWithValue("@Teacher", teacherSearch)
            InsertData(manageClass.ExecuteQuery(cmd))
        End If
    End Sub

    Private Sub cbSearchTeacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchTeacher.SelectedIndexChanged
        If Not IsNumeric(cbSearchTeacher.SelectedValue) And cbSearchTeacher.SelectedValue.ToString() <> "%" Then
            Return
        Else
            Dim textSearch = If(txtSearch.Texts.Trim() = "", "%", txtSearch.Texts.Trim()) + "%"
            Dim teacherSearch = cbSearchTeacher.SelectedValue
            Dim query As String = " SELECT tblClass.ClassID, tblCourses.CourseName AS Course, tblTeacher.KhName AS Teacher, tblRoom.Room AS Room, tblSchedule.Schedule, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudents, tblClassStatus.Status
                            FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblTeacher.ID = tblClass.TeacherID
                            GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.Room, tblSchedule.Schedule, tblClassStatus.Status, tblTeacher.ID 
                            HAVING ((((tblClass.ClassID) Like @Classid) OR ((tblCourses.CourseName) Like @Classid)) AND ((tblTeacher.ID) Like @Teacher));"
            Dim cmd As New OleDbCommand(query, manageClass.GetConnection())
            cmd.Parameters.AddWithValue("@Classid", textSearch)
            cmd.Parameters.AddWithValue("@Teacher", teacherSearch)
            InsertData(manageClass.ExecuteQuery(cmd))
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ManageClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startup = False
    End Sub
End Class