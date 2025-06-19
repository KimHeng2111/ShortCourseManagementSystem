Imports Guna.UI2.WinForms

Public Class DashboardForm
    Dim dashboard As New Dashboard()

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)



    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTotalStudnet.Text = dashboard.totalStudent.ToString()
        lbCompleteStudent.Text = dashboard.completeStudent.ToString()
        lbTotalClass.Text = dashboard.totalCourse
        lbCompleteClass.Text = dashboard.completeCourse
        lbTotalTeacher.Text = dashboard.totalTeacher
        lbActionTeacher.Text = dashboard.actionTeacher
        lbTotalCourse.Text = dashboard.TotalSubject
        lbActionCourse.Text = dashboard.actionSubject
        'Insert Data to chart
        StudentChart.DataSource = dashboard.CourseList
        StudentChart.Series(0).XValueMember = "Key"
        StudentChart.Series(0).YValueMembers = "Value"
        StudentChart.DataBind()
        CourseChart.DataSource = dashboard.SubjectList
        CourseChart.Series(0).XValueMember = "Key"
        CourseChart.Series(0).YValueMembers = "Value"
        CourseChart.DataBind()
    End Sub
End Class