Imports System.Windows.Forms.DataVisualization.Charting
Imports Guna.UI2.WinForms

Public Class DashboardForm
    Dim dashboard As New Dashboard()

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
        StudentChart.Legends(0).CustomItems.Clear()
        CourseChart.DataSource = dashboard.SubjectList
        CourseChart.Series(0).XValueMember = "Key"
        CourseChart.Series(0).YValueMembers = "Value"
        CourseChart.DataBind()

        'Insert Data To DG CourseCoomingSoon
        CoomingCouseList.DataSource = dashboard.CourseCoomingSoon()
        With CoomingCouseList
            .Columns(0).Width = 60
            .Columns(0).HeaderText = "Nº"
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).Width = 150
            .Columns(1).HeaderText = "មុខវិជ្ជា"
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "ថ្ងៃចូលរៀន"
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).Width = 90
            .Columns(3).HeaderText = "សិស្សសរុប"
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With 'Insert Data To DG CourseCoomingSoon
        dgSubjectList.DataSource = dashboard.GetSubjectList()
        With dgSubjectList
            .Columns(0).Width = 80
            .Columns(0).HeaderText = "លេខកូដ"
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).Width = 170
            .Columns(1).HeaderText = "មុខវិជ្ជា"
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "វគ្គសិក្សាសរុប"
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).Width = 90
            .Columns(3).HeaderText = "បានបញ្ចប់"
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).Width = 90
            .Columns(4).HeaderText = "សិស្សសរុប"
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

End Class