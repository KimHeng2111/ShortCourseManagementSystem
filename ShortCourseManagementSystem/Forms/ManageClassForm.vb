Imports System.Data.OleDb
Imports System.Windows
Public Class ManageClassForm
    Dim manageClass As ManageClass = New ManageClass()
    Dim startup As Boolean = True
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GetcbStatus()
        GetcbSearch()
    End Sub

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
            MessageBox.Show("សូមបញ្ចូលClassID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If TimeID <= 0 Or RoomID <= 0 Or TeacherID <= 0 Or CourseID <= 0 Then
            MessageBox.Show("Please select valid options for time, room, teacher, and course.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    'GetData From Class ManageClass
    Private Sub Display()
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
        cbCourse.SelectedIndex = cbCourse.Items.Count - 1 ' Select the last item (which is "All")
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
        classStatusList.Add("គ្រប់ស្ថានភាព", 0)
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
        manageClass.room.GetRoomByID(cbRoom.SelectedValue)
        manageClass.teacher.TeacherID = cbTeacher.SelectedValue.ToString()
        manageClass.course.courseID = cbCourse.SelectedValue.ToString()
        manageClass.startDate = dtpStartDate.Value
        manageClass.AddClass()
        Display()
    End Sub



    'Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
    '    If CheckField() Then
    '        Dim id As String = txtClassID.Text.Trim()
    '        Dim courseID As String = cbCourse.SelectedValue.ToString()
    '        Dim teacherID As String = cbTeacher.SelectedValue.ToString()
    '        Dim startDate As String = dtpStartDate.Value
    '        Dim roomID As Integer = Convert.ToInt32(cbRoom.SelectedValue)
    '        Dim secheduleID As Integer = Convert.ToInt32(cbTime.SelectedValue)
    '        manageClass.UpdateClass(id, courseID, teacherID, startDate, roomID, secheduleID)
    '    End If
    '    Display()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbSearchTeacher.SelectedIndex = cbSearchTeacher.Items.Count - 1
        cbStatus.SelectedIndex = cbStatus.Items.Count - 1
        txtSearch.Texts = ""
        Display()
    End Sub

    'Insert DATA To DataGridView
    Private Sub InsertData(data As DataTable)
        DataGridView1.DataSource = data
        Regonize()
    End Sub
    'Regonize DataGridView2 
    Sub Regonize()
        If DataGridView1.Columns.Count = 7 Then
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(1).HeaderText = "វគ្គសិក្សា"
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(2).HeaderText = "គ្រូបង្រៀន"
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(3).HeaderText = "បន្ទប់"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).Width = 200
            DataGridView1.Columns(4).HeaderText = "វេនសិក្សា"
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(5).HeaderText = "សិស្សសរុប"
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(6).Width = 200
            DataGridView1.Columns(6).HeaderText = "ស្ថានភាព"
            DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If i Mod 2 = 1 Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
                End If
            Next i
        End If
        DataGridView1.ClearSelection()
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
        GetCbTime()
        GetCbRoom()
        GetCbTeacher()
        GetcbCourse()
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click 'Show the Schedule form
        Dim ScheduleForm As New Schedule()
        ScheduleForm.ShowDialog()
        ScheduleForm.Dispose()
        startup = True
        GetCbTime()
        GetcbStatus()
        GetcbSearch()
        startup = False
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click 'Show the Room form
        Dim RoomForm As New RoomForm()
        RoomForm.ShowDialog()
        RoomForm.Dispose()
        GetCbRoom()
        GetcbSearch()
        GetcbStatus()
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
        btnEdit.Visible = False
        txtClassID.ReadOnly = False
        btnNewClass.Visible = True 'Hide the panel for adding a new class
    End Sub

    Private Sub DataGridView2_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        Regonize() 'Prepare the DataGridView after sorting
    End Sub


    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim menu As New ContextMenuStrip()
        menu.Font = New Font("Khmer OS System", 9)
        menu.Items.Add("លម្អិត", Nothing, AddressOf ShowDetails)
        menu.Items.Add("កែប្រែ", Nothing, AddressOf EditClass)
        menu.Items.Add("លុប", Nothing, AddressOf DeleteCourse)

        menu.Items(0).BackColor = Color.FromArgb(245, 250, 253)

        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                Dim ClassID As String = DataGridView1.Rows(hit.RowIndex).Cells(0).Value.ToString()
                manageClass.GetClassByID(ClassID)
                menu.Show(DataGridView1, e.Location)
            End If
        End If

    End Sub

    Private Sub DeleteCourse()
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុបថ្នាក់រៀននេះមែនទេ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            manageClass.DeleteClass()
            Display()
        End If
    End Sub

    Private Sub ShowDetails()
        Dim classDetail As New ClassDetail(manageClass)
        classDetail.ShowDialog()
        classDetail.Dispose()
        Display()
        startup = True
        GetcbSearch()
        GetcbStatus()
        startup = False
    End Sub
    Private Sub EditClass()
        txtClassID.Text = manageClass.classID
        cbCourse.SelectedIndex = cbCourse.FindStringExact(manageClass.course.courseName)
        MsgBox(manageClass.teacher.TeacherID)
        cbTeacher.SelectedValue = manageClass.teacher.TeacherID
        cbRoom.SelectedValue = manageClass.room.id
        cbTime.SelectedValue = manageClass.scheduleID
        dtpStartDate.Value = manageClass.startDate
        Panel2.Visible = True
        btnEdit.Visible = True
        btnNewClass.Visible = False

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtClassID.Text = manageClass.classID And cbCourse.SelectedValue = manageClass.course.courseID And cbRoom.SelectedValue = manageClass.room.id And cbTeacher.SelectedValue = manageClass.teacher.TeacherID And dtpStartDate.Value = manageClass.startDate And
            cbTime.SelectedValue = manageClass.scheduleID Then
            MessageBox.Show("សូមកែប្រែវគ្គសិក្សា", "Edit Class", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Not CheckValidation() Then
            Return
        End If
        txtClassID.ReadOnly = True
        manageClass.UpdateClass(txtClassID.Text.Trim(), cbCourse.SelectedValue.ToString(), cbTeacher.SelectedValue.ToString(), dtpStartDate.Value, Convert.ToInt32(cbRoom.SelectedValue), Convert.ToInt32(cbTime.SelectedValue))
        MessageBox.Show("វគ្គសិក្សា ត្រូវបានកែប្រែដោយជោគជ័យ!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Display()
        startup = False
    End Sub
End Class