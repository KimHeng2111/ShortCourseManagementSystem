Imports System.Data.OleDb
Imports System.Data.SqlTypes
Imports System.Windows
Public Class CourseForm
    Dim course As Course = New Course()
    Dim startup As Boolean = True
    Public Sub New()

        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        GetcbStatus()
        GetcbSearch()
    End Sub

    'Check Validation
    Function CheckValidation() As Boolean
        If Not CheckField() Then
            Return False
        End If
        Dim result As Boolean = True
        Dim query As String = "SELECT COUNT(*) FROM tblCourse WHERE ScheduleID = @ScheduleID AND RoomID = @RoomID AND StatusID <= 2;" 'Check if the room and schedule are already in use
        Dim cmd As New OleDbCommand(query, course.GetConnection())
        cmd.Parameters.AddWithValue("@ScheduleID", cbSchedule.SelectedValue)
        cmd.Parameters.AddWithValue("@RoomID", cbRoom.SelectedValue)
        Dim count As Integer = Convert.ToInt32(course.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("បន្ទប់ និង វេនសិក្សា ត្រូវបានប្រើប្រាស់រួចហើយ។ សូមជ្រើសរើសវេនសិក្សា ឬ បន្ទប់ផ្សេងទៀត។", "ទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        query = "SELECT COUNT(*) FROM tblCourse WHERE ID = @ID;"
        cmd = New OleDbCommand(query, course.GetConnection())
        cmd.Parameters.AddWithValue("@ID", txtCourseID.Text.Trim())
        count = Convert.ToInt32(course.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("លេខកូដវគ្គសិក្សា នេះមានរួចហើយ.", "ទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        query = "SELECT COUNT(*) FROM tblCourse WHERE ID = @subjectID AND StatusID <= 2 AND ScheduleID = @ScheduleID ;" 'Check if the subject and teacher are already assigned
        cmd = New OleDbCommand(query, course.GetConnection())
        cmd.Parameters.AddWithValue("@subjectID", cbSubject.SelectedValue)
        cmd.Parameters.AddWithValue("@ScheduleID", cbSchedule.SelectedValue)
        count = Convert.ToInt32(course.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("វគ្គសិក្សា ត្រូវបានប្រើប្រាស់រួចហើយនៅក្នុងវេនសិក្សានេះ ។ សូមជ្រើសរើស វគ្គសិក្សាថ្មី។", "ទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        query = "SELECT COUNT(*) FROM tblCourse WHERE TeacherID = @TeacherID AND StatusID <= 2 AND ScheduleID = @ScheduleID ;" 'Check if the subject and teacher are already assigned
        cmd = New OleDbCommand(query, course.GetConnection())
        cmd.Parameters.AddWithValue("@TeacherID", cbTeacher.SelectedValue)
        cmd.Parameters.AddWithValue("@ScheduleID", cbSchedule.SelectedValue)
        count = Convert.ToInt32(course.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("គ្រូបង្រៀននេះ ត្រូវបានប្រើប្រាស់រួចហើយនៅក្នុងវេនសិក្សានេះ ។ សូមជ្រើសរើស គ្រូបង្រៀនថ្មី ។", "ទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        If dtpStartDate.Value.Date <= DateTime.Now().Date Then
            MessageBox.Show("សូមបញ្ចូលថ្ងៃចូលរៀនអោយបានត្រឹមត្រូវ !!!!", "ទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButton.OK, MessageBoxIcon.Warning)
        End If
        If dtpEndDate.Value.Date <= dtpStartDate.Value.Date.AddDays(10) Then
            MessageBox.Show("សូមបញ្ចូលថ្ងៃចូលរៀនអោយបានត្រឹមត្រូវ !!!!", "ទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButton.OK, MessageBoxIcon.Warning)
        End If
        Return result
    End Function
    'Check User Input
    Private Function CheckField() As Boolean
        Dim ClassName As String = txtCourseID.Text.Trim()
        Dim TimeID As Integer = Convert.ToInt32(cbSchedule.SelectedValue)
        Dim RoomID As Integer = Convert.ToInt32(cbRoom.SelectedValue)
        Dim TeacherID As Integer = cbTeacher.SelectedValue
        Dim CourseID As Integer = cbSubject.SelectedValue
        course.startDate = dtpStartDate.Value
        If String.IsNullOrEmpty(ClassName) Then
            MessageBox.Show("សូមបញ្ចូលលេខកូដវគ្គសិក្សា", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If TimeID <= 0 Or RoomID <= 0 Or TeacherID <= 0 Or CourseID <= 0 Then
            MessageBox.Show("សូមជ្រើសរើវេនសិក្សា បន្ទប់ គ្រូបង្រៀន និង វគ្គសិក្សា", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    'GetData From Class ManageClass
    Private Sub Display()
        InsertData(course.GetCourseData())
    End Sub
    Sub GetCbTime()
        Dim timeList = course.GetTimeList()
        timeList.Add("ជ្រើសរើសវេនសិក្សា", -1)
        cbSchedule.DataSource = New BindingSource(timeList, Nothing)
        cbSchedule.DisplayMember = "Key"
        cbSchedule.ValueMember = "Value"
        cbSchedule.SelectedIndex = cbSchedule.Items.Count - 1
    End Sub
    Sub GetCbRoom()
        Dim RoomList = course.GetRoomList()
        RoomList.Add("ជ្រើសរើសបន្ទប់រៀន", -1)
        cbRoom.DataSource = New BindingSource(RoomList, Nothing)
        cbRoom.DisplayMember = "Key"
        cbRoom.ValueMember = "Value"
        cbRoom.SelectedIndex = cbRoom.Items.Count - 1
    End Sub
    Sub GetCbTeacher()
        Dim teacherList = course.GetTeacherList()
        teacherList.Add("ជ្រើសរើសគ្រូបង្រៀន", "-1")
        cbTeacher.DataSource = New BindingSource(teacherList, Nothing)
        cbTeacher.DisplayMember = "Key"
        cbTeacher.ValueMember = "Value"
        cbTeacher.SelectedIndex = cbTeacher.Items.Count - 1
    End Sub
    Sub GetcbCourse()
        Dim courseList = course.GetCourseList()
        courseList.Add("ជ្រើសរើសវគ្គសិក្សា", -1)
        cbSubject.DataSource = New BindingSource(courseList, Nothing)
        cbSubject.DisplayMember = "Key"
        cbSubject.ValueMember = "Value"
        cbSubject.SelectedIndex = cbSubject.Items.Count - 1 ' Select the last item (which is "All")
    End Sub
    Sub GetcbSearch()
        Dim teacherList = course.GetTeacherList()
        teacherList.Add("គ្រប់គ្រូទាំងអស់", "%")
        cbSearchTeacher.DataSource = New BindingSource(teacherList, Nothing)
        cbSearchTeacher.DisplayMember = "Key"
        cbSearchTeacher.ValueMember = "Value"
        cbSearchTeacher.SelectedIndex = cbSearchTeacher.Items.Count - 1
    End Sub
    Sub GetcbStatus()
        Dim classStatusList = course.GetClassStatusList()
        classStatusList.Add("គ្រប់ស្ថានភាព", 0)
        cbSearchStatus.DataSource = New BindingSource(classStatusList, Nothing)
        cbSearchStatus.DisplayMember = "Key"
        cbSearchStatus.ValueMember = "Value"
        cbSearchStatus.SelectedIndex = cbSearchStatus.Items.Count - 1 ' Select the last item (which is "All")
    End Sub
    Private Sub btnNewClass_Click(sender As Object, e As EventArgs) Handles btnNewClass.Click
        If Not CheckValidation() Then
            Return
        End If
        course.ID = txtCourseID.Text.Trim()
        course.scheduleID = Convert.ToInt32(cbSchedule.SelectedValue.ToString())
        course.room.GetRoomByID(cbRoom.SelectedValue)
        course.teacher.TeacherID = cbTeacher.SelectedValue.ToString()
        course.subject.ID = cbSubject.SelectedValue.ToString()
        course.startDate = dtpStartDate.Value
        course.endDate = dtpEndDate.Value
        course.AddCourse()
        Display()
    End Sub

    Sub SearchCourseData() Handles txtSearch.TextChanged, cbSearchTeacher.SelectedIndexChanged, cbSearchStatus.SelectedIndexChanged
        If startup Then
            Return
        Else
            Dim textSearch = If(txtSearch.Text.Trim() = "", "%", txtSearch.Text.Trim())
            Dim id As String = If(IsNumeric(textSearch), textSearch & "%", "%")
            Dim subject As String = If(IsNumeric(textSearch), "%", textSearch & "%")
            Dim StatusID As String = If(cbSearchStatus.SelectedValue = 0, "%", cbSearchStatus.SelectedValue.ToString())
            Dim teacherSearch = cbSearchTeacher.SelectedValue.ToString()
            Dim query As String = " SELECT tblCourse.ID, tblSubject.Subject, tblTeacher.KhName, tblRoom.Room, 
                                tblSchedule.Schedule, tblCourse.CurrentEnrollment, tblCourseStatus.Status
                                FROM tblSchedule INNER JOIN (tblRoom INNER JOIN (tblTeacher 
                                INNER JOIN (tblSubject INNER JOIN (tblCourseStatus INNER JOIN tblCourse
                                ON (tblCourseStatus.ID = tblCourse.StatusID) AND (tblCourseStatus.ID = tblCourse.StatusID)) 
                                ON tblSubject.ID = tblCourse.SubjectID) ON tblTeacher.ID = tblCourse.TeacherID) 
                                ON tblRoom.ID = tblCourse.RoomID) ON tblSchedule.ID = tblCourse.ScheduleID
                                WHERE tblCourse.ID LIKE @id AND tblSubject.Subject LIKE @subject AND tblTeacher.ID LIKE @teacher AND tblCourse.StatusID LIKE @StatusID;"
            Dim cmd As New OleDbCommand(query, course.GetConnection())
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@subject", subject)
            cmd.Parameters.AddWithValue("@Teacher", teacherSearch)
            cmd.Parameters.AddWithValue("@StatusID", StatusID)
            InsertData(course.ExecuteQuery(cmd))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbSearchTeacher.SelectedIndex = cbSearchTeacher.Items.Count - 1
        cbSearchStatus.SelectedIndex = cbSearchStatus.Items.Count - 1
        txtSearch.Text = ""
        Display()
    End Sub

    'Insert DATA To DataGridView
    Private Sub InsertData(data As DataTable)
        DataGridView1.DataSource = data
        Regonize()
    End Sub
    ' Regonize DataGridView2
    Sub Regonize()

        If DataGridView1.Columns.Count = 7 Then
            DataGridView1.Columns(0).HeaderText = "លេខកូដ"
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
        cbStatus.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtCourseID.Text = ""
        cbSubject.SelectedIndex = cbSubject.Items.Count - 1
        cbRoom.SelectedIndex = cbRoom.Items.Count - 1
        cbTeacher.SelectedIndex = cbTeacher.Items.Count - 1
        cbSchedule.SelectedIndex = cbSchedule.Items.Count - 1
        dtpStartDate.Value = DateTime.Now
        Panel2.Visible = False
        btnEdit.Visible = False
        txtCourseID.ReadOnly = False
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
                course.GetCourseByID(ClassID)
                menu.Show(DataGridView1, e.Location)
            End If
        End If

    End Sub

    Private Sub DeleteCourse()
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុបថ្នាក់រៀននេះមែនទេ?", "លុបវគ្គសិក្សា", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            course.DeleteCourse()
            Display()
        End If
    End Sub

    Private Sub ShowDetails()
        Dim classDetail As New CourseDetail(course)
        classDetail.ShowDialog()
        classDetail.Dispose()
        Display()
        startup = True
        GetcbSearch()
        GetcbStatus()
        startup = False
    End Sub
    Private Sub EditClass()
        txtCourseID.Text = course.ID
        cbSubject.SelectedIndex = cbSubject.FindStringExact(course.subject.Subject)
        cbTeacher.SelectedValue = course.teacher.TeacherID
        cbRoom.SelectedValue = course.room.id
        cbSchedule.SelectedValue = course.scheduleID
        dtpStartDate.Value = course.startDate
        dtpEndDate.Value = course.endDate
        cbStatus.SelectedIndex = course.statusID - 1
        Panel2.Visible = True
        btnEdit.Visible = True
        btnNewClass.Visible = False
        cbStatus.Enabled = True

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtCourseID.Text = course.ID And cbSubject.SelectedValue = course.subject.ID And cbRoom.SelectedValue = course.room.id And cbTeacher.SelectedValue = course.teacher.TeacherID And dtpStartDate.Value = course.startDate And dtpEndDate.Value = course.endDate And
            cbSchedule.SelectedValue = course.scheduleID And cbStatus.SelectedIndex = course.statusID - 1 Then
            MessageBox.Show("សូមកែប្រែវគ្គសិក្សា", "ទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return
        End If
        If Not CheckField() Then
            Return
        End If
        course.ID = txtCourseID.Text.Trim()
        course.scheduleID = Convert.ToInt32(cbSchedule.SelectedValue.ToString())
        course.room.GetRoomByID(cbRoom.SelectedValue)
        course.teacher.TeacherID = cbTeacher.SelectedValue.ToString()
        course.subject.ID = cbSubject.SelectedValue.ToString()
        course.startDate = dtpStartDate.Value
        course.endDate = dtpEndDate.Value
        course.statusID = cbStatus.SelectedIndex + 1
        txtCourseID.ReadOnly = True
        course.UpdateCourse()
        MessageBox.Show("វគ្គសិក្សា ត្រូវបានកែប្រែដោយជោគជ័យ!", "បច្ចុប្បន្នភាពវគ្គសិក្សា", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Display()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Display()
        startup = False
    End Sub

End Class