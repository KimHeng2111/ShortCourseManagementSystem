Imports System.Data.OleDb
Imports System.Windows

Public Class ManageClassForm
    Dim manageClass As ManageClass = New ManageClass()
    Dim startup As Boolean = True


    'Check Validation
    Function CheckValidation() As Boolean
        If Not CheckField() Then
            Return False
        End If
        Dim result As Boolean = True
        Dim query As String = "SELECT COUNT(*) FROM tblClass WHERE ScheduleID = @ScheduleID AND RoomID = @RoomID AND StatusID <= 2;" 'Check if the room and schedule are already in use
        Dim cmd As New OleDbCommand(query, manageClass.GetConnection())
        cmd.Parameters.AddWithValue("@ScheduleID", cbTime.SelectedValue)
        cmd.Parameters.AddWithValue("@RoomID", cbRoom.SelectedValue)
        Dim count As Integer = Convert.ToInt32(manageClass.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("បន្ទប់ និង វេនសិក្សា ត្រូវបានប្រើប្រាស់រួចហើយ។ សូមជ្រើសរើសវេនសិក្សា ឬ បន្ទប់ផ្សេងទៀត។", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        query = "SELECT COUNT(*) FROM tblClass WHERE ClassID = @ClassID;"
        cmd = New OleDbCommand(query, manageClass.GetConnection())
        cmd.Parameters.AddWithValue("@ClassID", txtClassID.Text.Trim())
        count = Convert.ToInt32(manageClass.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("ClassID នេះមានរួចហើយ.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        query = "SELECT COUNT(*) FROM tblClass WHERE CourseID = @CourseID AND StatusID <= 2 AND ScheduleID = @ScheduleID ;" 'Check if the course and teacher are already assigned
        cmd = New OleDbCommand(query, manageClass.GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", cbCourse.SelectedValue)
        cmd.Parameters.AddWithValue("@ScheduleID", cbTime.SelectedValue)
        'cmd.Parameters.AddWithValue("@TeacherID", cbTeacher.SelectedValue)
        count = Convert.ToInt32(manageClass.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("វគ្គសិក្សា ត្រូវបានប្រើប្រាស់រួចហើយនៅក្នុងវេនសិក្សានេះ ។ សូមជ្រើសរើស វគ្គសិក្សាថ្មី។", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        query = "SELECT COUNT(*) FROM tblClass WHERE TeacherID = @TeacherID AND StatusID <= 2 AND ScheduleID = @ScheduleID ;" 'Check if the course and teacher are already assigned
        cmd = New OleDbCommand(query, manageClass.GetConnection())
        cmd.Parameters.AddWithValue("@TeacherID", cbTeacher.SelectedValue)
        cmd.Parameters.AddWithValue("@ScheduleID", cbTime.SelectedValue)
        count = Convert.ToInt32(manageClass.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("គ្រូបង្រៀននេះ ត្រូវបានប្រើប្រាស់រួចហើយនៅក្នុងវេនសិក្សានេះ ។ សូមជ្រើសរើស គ្រូបង្រៀនថ្មី ។", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        Return result
    End Function
    'Check User Input
    Private Function CheckField() As Boolean
        Dim ClassName As String = txtClassID.Text.Trim()
        Dim TimeID As Integer = Convert.ToInt32(cbTime.SelectedValue)
        Dim RoomID As Integer = Convert.ToInt32(cbRoom.SelectedValue)
        Dim TeacherID As Integer = cbTeacher.SelectedValue
        Dim CourseID As Integer = cbCourse.SelectedValue
        manageClass.startDate = dtpStartDate.Value
        If String.IsNullOrEmpty(ClassName) Then
            MessageBox.Show("សូមបញ្ចូល", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If TimeID <= 0 Or RoomID <= 0 Or TeacherID <= 0 Or CourseID <= 0 Then
            MessageBox.Show("Please select valid options for time, room, teacher, and course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    'GetData From Class ManageClass
    Private Sub display()
        InsertData(manageClass.GetClassData())
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
    Sub GetcbStatus()
        Dim classStatusList = manageClass.GetClassStatusList()
        cbStatus.DataSource = New BindingSource(classStatusList, Nothing)
        cbStatus.DisplayMember = "Key"
        cbStatus.ValueMember = "Value"
        cbStatus.SelectedIndex = cbStatus.Items.Count - 1 ' Select the last item (which is "All")
    End Sub
    Private Sub btnNewClass_Click(sender As Object, e As EventArgs) Handles btnNewClass.Click
        If Not CheckValidation() Then
            Return
        End If
        manageClass.classID = txtClassID.Text.Trim()
        manageClass.scheduleID = Convert.ToInt32(cbTime.SelectedValue.ToString())
        manageClass.roomID = Convert.ToInt32(cbRoom.SelectedValue.ToString())
        manageClass.teacher.TeacherID = cbTeacher.SelectedValue.ToString()
        manageClass.course.courseID = cbCourse.SelectedValue.ToString()
        manageClass.startDate = dtpStartDate.Value
        manageClass.AddClass()
        display()
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
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
        GetcbSearch()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbSearchTeacher.SelectedIndex = cbSearchTeacher.Items.Count - 1
        txtSearch.Texts = ""
        display()
    End Sub

    'Insert DATA To DataGridView
    Private Sub InsertData(data As DataTable)
        DataGridView2.DataSource = data
        Regonize()
    End Sub
    'Regonize DataGridView2 
    Sub Regonize()
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
                    DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(150, 203, 175) ' Alternate row color
                Else
                    DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(235, 255, 255)
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
        GetcbStatus()
        startup = False
        Panel2.Visible = False
    End Sub

    Private Sub txtSearch__TextChanged(sender As Object, e As EventArgs) Handles txtSearch._TextChanged
        If startup Then
            Return
        Else
            Dim textSearch = If(txtSearch.Texts.Trim() = "", "%", txtSearch.Texts.Trim()) + "%"
            Dim StatusID As String = If(cbStatus.SelectedValue = 0, "%", cbStatus.SelectedValue.ToString())

            Dim teacherSearch = cbSearchTeacher.SelectedValue
            Dim query As String = " SELECT tblClass.ClassID, tblCourses.CourseName AS Course, tblTeacher.KhName AS Teacher, tblRoom.Room AS Room, tblSchedule.Schedule, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudents, tblClassStatus.Status
                                    FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblTeacher.ID = tblClass.TeacherID
                                    GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.Room, tblSchedule.Schedule, tblClassStatus.Status, tblTeacher.ID, tblClassStatus.ID
                                    HAVING (((tblClass.ClassID) Like [@Classid]) AND ((tblTeacher.ID) Like [@Teacher]) AND ((tblClassStatus.ID) Like [@StatusID])) OR (((tblCourses.CourseName) Like [@Classid]) AND ((tblTeacher.ID) Like [@Teacher]) AND ((tblClassStatus.ID) Like [@StatusID]));"
            Dim cmd As New OleDbCommand(query, manageClass.GetConnection())
            cmd.Parameters.AddWithValue("@Classid", textSearch)
            cmd.Parameters.AddWithValue("@Teacher", teacherSearch)
            cmd.Parameters.AddWithValue("@StatusID", StatusID)
            InsertData(manageClass.ExecuteQuery(cmd))
        End If
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If startup Then
            Return
        Else
            Dim textSearch = If(txtSearch.Texts.Trim() = "", "%", txtSearch.Texts.Trim()) + "%"
            Dim StatusID As String = If(cbStatus.SelectedValue = 0, "%", cbStatus.SelectedValue.ToString())

            Dim teacherSearch = cbSearchTeacher.SelectedValue
            Dim query As String = " SELECT tblClass.ClassID, tblCourses.CourseName AS Course, tblTeacher.KhName AS Teacher, tblRoom.Room AS Room, tblSchedule.Schedule, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudents, tblClassStatus.Status
                                    FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblTeacher.ID = tblClass.TeacherID
                                    GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.Room, tblSchedule.Schedule, tblClassStatus.Status, tblTeacher.ID, tblClassStatus.ID
                                    HAVING (((tblClass.ClassID) Like [@Classid]) AND ((tblTeacher.ID) Like [@Teacher]) AND ((tblClassStatus.ID) Like [@StatusID])) OR (((tblCourses.CourseName) Like [@Classid]) AND ((tblTeacher.ID) Like [@Teacher]) AND ((tblClassStatus.ID) Like [@StatusID]));"
            Dim cmd As New OleDbCommand(query, manageClass.GetConnection())
            cmd.Parameters.AddWithValue("@Classid", textSearch)
            cmd.Parameters.AddWithValue("@Teacher", teacherSearch)
            cmd.Parameters.AddWithValue("@StatusID", StatusID)
            InsertData(manageClass.ExecuteQuery(cmd))
        End If

    End Sub

    Private Sub cbSearchTeacher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchTeacher.SelectedIndexChanged
        If startup Then
            Return
        Else
            Dim textSearch = If(txtSearch.Texts.Trim() = "", "%", txtSearch.Texts.Trim()) + "%"
            Dim StatusID As String = If(cbStatus.SelectedValue = 0, "%", cbStatus.SelectedValue.ToString())

            Dim teacherSearch = cbSearchTeacher.SelectedValue
            Dim query As String = " SELECT tblClass.ClassID, tblCourses.CourseName AS Course, tblTeacher.KhName AS Teacher, tblRoom.Room AS Room, tblSchedule.Schedule, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudents, tblClassStatus.Status
                                    FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblTeacher.ID = tblClass.TeacherID
                                    GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.Room, tblSchedule.Schedule, tblClassStatus.Status, tblTeacher.ID, tblClassStatus.ID
                                    HAVING (((tblClass.ClassID) Like [@Classid]) AND ((tblTeacher.ID) Like [@Teacher]) AND ((tblClassStatus.ID) Like [@StatusID])) OR (((tblCourses.CourseName) Like [@Classid]) AND ((tblTeacher.ID) Like [@Teacher]) AND ((tblClassStatus.ID) Like [@StatusID]));"
            Dim cmd As New OleDbCommand(query, manageClass.GetConnection())
            cmd.Parameters.AddWithValue("@Classid", textSearch)
            cmd.Parameters.AddWithValue("@Teacher", teacherSearch)
            cmd.Parameters.AddWithValue("@StatusID", StatusID)
            InsertData(manageClass.ExecuteQuery(cmd))
        End If
    End Sub

    Private Sub ManageClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Load the form and initialize components


    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click 'Show the Schedule form
        Dim ScheduleForm As New Schedule()
        ScheduleForm.ShowDialog()
        ScheduleForm.Dispose()
        GetCbTime()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click 'Show the Room form
        Dim RoomForm As New Room()
        RoomForm.ShowDialog()
        RoomForm.Dispose()
        GetCbRoom()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel2.Visible = True 'Show the panel for adding a new class
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtClassID.Text = ""
        cbCourse.SelectedIndex = cbCourse.Items.Count - 1
        cbRoom.SelectedIndex = cbRoom.Items.Count - 1
        cbTeacher.SelectedIndex = cbTeacher.Items.Count - 1
        cbTime.SelectedIndex = cbTime.Items.Count - 1
        dtpStartDate.Value = DateTime.Now
        Panel2.Visible = False
    End Sub

    Private Sub DataGridView2_Sorted(sender As Object, e As EventArgs) Handles DataGridView2.Sorted
        Regonize() 'Prepare the DataGridView after sorting
    End Sub


End Class