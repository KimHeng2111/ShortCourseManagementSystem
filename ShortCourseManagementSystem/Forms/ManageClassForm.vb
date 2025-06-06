Public Class ManageClassForm
    Dim manageClass As ManageClass = New ManageClass()
    Public Sub New()
        ' Constructor for ManageClassForm class
        InitializeComponent()
        display()
        GetCbTime()
        GetCbRoom()
        GetCbTeacher()
        GetcbCourse()

    End Sub








    'GetData From Class ManageClass
    Private Sub display()
        DataGridView2.DataSource = manageClass.GetClassData()
    End Sub
    Sub GetCbTime()
        cbTime.DataSource = New BindingSource(manageClass.GetTimeList, Nothing)
        cbTime.DisplayMember = "Key"
        cbTime.ValueMember = "Value"
    End Sub
    Sub GetCbRoom()
        cbRoom.DataSource = New BindingSource(manageClass.GetRoomList(), Nothing)
        cbRoom.DisplayMember = "Key"
        cbRoom.ValueMember = "Value"
    End Sub
    Sub GetCbTeacher()
        cbTeacher.DataSource = New BindingSource(manageClass.GetTeacherList(), Nothing)
        cbTeacher.DisplayMember = "Key"
        cbTeacher.ValueMember = "Value"
    End Sub
    Sub GetcbCourse()
        cbCourse.DataSource = New BindingSource(manageClass.GetCourseList(), Nothing)
        cbCourse.DisplayMember = "Key"
        cbCourse.ValueMember = "Value"
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

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Dim id As String = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        manageClass.GetClassByID(id)
        txtClassID.Text = manageClass.classID
        cbCourse.SelectedIndex = cbCourse.FindStringExact(manageClass.course.courseName)
        cbTeacher.SelectedIndex = cbTeacher.FindStringExact(manageClass.teacher.EngName)
        dtpStartDate.Value = manageClass.startDate
        For i As Integer = 0 To cbTime.Items.Count - 1
            If cbTime.Items(i).Value = manageClass.scheduleID Then
                cbTime.SelectedIndex = i
                Exit For
            End If
        Next i
        For i As Integer = 0 To cbRoom.Items.Count - 1
            If cbRoom.Items(i).Value = manageClass.roomID Then
                cbRoom.SelectedIndex = i
                Exit For
            End If
        Next i

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class