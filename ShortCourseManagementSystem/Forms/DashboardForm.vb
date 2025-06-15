Imports Guna.UI2.WinForms

Public Class DashboardForm
    Dim dashboard As New Dashboard()

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint
        lbTotalStudnet.Text = dashboard.totalStudent.ToString()
        lbCompleteStudent.Text = dashboard.completeStudent.ToString()
        lbTotalClass.Text = dashboard.totalClass
        lbCompleteClass.Text = dashboard.completeClass
        lbTotalTeacher.Text = dashboard.totalTeacher
        lbActionTeacher.Text = dashboard.actionTeacher
        lbTotalCourse.Text = dashboard.totalCourse
        lbActionCourse.Text = dashboard.actionCourse

    End Sub

    Sub GetDataClass()
        Dim dt = dashboard.GetCourseDataTable
        Dim date1 As New DateTime
        Dim date2 As New DateTime
        For Each row As DataRow In dt.Rows
            date1 = Convert.ToDateTime(row(3))
            date2 = If(row(4).ToString() = "", date1.AddDays(30), Convert.ToDateTime(row(4)))
            ClassList.Rows.Add(row(0), row(1), row(2), date1.ToString("dd/MM/yyyy"), date2.ToString("dd/MM/yyyy"), row(5))
        Next

    End Sub
    Sub GetNewRegister()
        Dim dt = dashboard.GetNewRegister()
        Dim date1 As New DateTime
        For Each row As DataRow In dt.Rows
            date1 = Convert.ToDateTime(row(4))
            RegisterList.Rows.Add(row(0), row(1), row(2), row(3), date1.ToString("d"), row(5))
        Next

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub


    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles PanelRegisterList.Paint

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles PanelCourse.Paint

    End Sub
    Sub Display()
        GetNewRegister()
        GetDataClass()
        Regonize()
    End Sub
    Sub Regonize()
        'DatagridView Class
        For i As Integer = 0 To ClassList.Columns.Count - 1
            ClassList.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        For i As Integer = 0 To ClassList.Rows.Count - 1
            If i Mod 2 = 1 Then
                ClassList.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(123, 150, 240) ' Alternate row color

            Else
                ClassList.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(223, 239, 255)
            End If
        Next i
        ClassList.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ClassList.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ClassList.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ClassList.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ClassList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ClassList.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ClassList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ClassList.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dim height1 = ClassList.Rows(0).Height
        height1 += height1 + 40 + 60
        PanelRegisterList.Size = New Size(PanelCourse.Width, height1)
        ClassList.ClearSelection()
        'DatagridView NewRegister
        For i As Integer = 0 To ClassList.Rows.Count - 1
            If i Mod 2 = 1 Then
                ClassList.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(123, 150, 240) ' Alternate row color

            Else
                ClassList.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(223, 239, 255)
            End If
        Next i
        For i As Integer = 0 To 5
            RegisterList.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
        RegisterList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        RegisterList.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        RegisterList.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        RegisterList.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        RegisterList.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        RegisterList.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        RegisterList.ClearSelection()
        Dim height = RegisterList.Rows(1).Height
        height += height + 40 + 60
        PanelCourse.Size = New Size(PanelCourse.Width, height)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Regonize()
    End Sub
End Class