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

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        MsgBox(cbCourse.SelectedValue.ToString())
    End Sub
End Class