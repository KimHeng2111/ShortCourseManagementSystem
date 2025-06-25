Imports System.Data.OleDb
Public Class CourseDetail
    Dim course As New Course()
    Public Sub New(classDetail As Course)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.course = classDetail
        FillClassDetails()

    End Sub
    Sub FillClassDetails()
        txtID.Text = course.ID
        txtCourse.Text = course.subject.Subject
        txtTeacher.Text = course.teacher.KhName
        txtStartDate.Text = course.startDate.ToString("dd/MM/yyyy")
        txtEndDate.Text = course.endDate.ToString("dd/MM/yyyy")
        txtRoom.Text = course.room.room
        txtSchedule.Text = course.GetSchedule()
        txtStatus.Text = course.GetStatus()
    End Sub
    Sub GetData()
        Dim query As String = "SELECT tblStudent.ID, tblStudent.KhName, tblStudent.Phone, tblStudent.Address, tblPaymentStatus.Status
            FROM (tblPaymentStatus INNER JOIN tblPayment ON tblPaymentStatus.ID = tblPayment.StatusID) INNER JOIN (tblStudent INNER JOIN tblRegister ON tblStudent.ID = tblRegister.StudentID) ON tblPayment.RegisterID = tblRegister.ID
            WHERE (((tblRegister.CourseID)=" & course.ID & "));"
        Dim dt As DataTable = course.ExecuteQuery(query)
        DataGridView1.DataSource = dt
        Regonize()
    End Sub
    Sub Regonize()
        If DataGridView1.Columns.Count = 5 Then
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(0).HeaderText = "StudentID"
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(1).HeaderText = "ឈ្មោះ"
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(2).HeaderText = "លេខទូរស័ព្ទ"
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(3).HeaderText = "អាស័យដ្ឋាន"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(4).HeaderText = "ស្ថានភាពបង់ប្រាក់"
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For Each col As DataGridViewColumn In DataGridView1.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        End If
        DataGridView1.ClearSelection()
    End Sub
    Private Sub CourseDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

End Class