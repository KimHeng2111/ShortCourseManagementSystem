Imports System.Windows.Controls

Public Class StudentDetail
    Dim student As New Student()
    Public Sub New(student As Student)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.student = student
        FillStudentDetails()
        Display()
    End Sub

    Sub FillStudentDetails()
        txtID.Text = student.id
        txtkhName.Text = student.khName
        txtEngName.Text = student.engName
        txtAddress.Text = student.address
        txtPhone.Text = student.phone
        txtDob.Text = student.DateOfBirth.ToString("dd/MM/yyyy")
        txtGender.Text = student.gender
        picStudent.ImageLocation = student.picture
    End Sub
    Sub Display()
        GetData()
        With DataGridView1
            .Columns(0).HeaderText = "លេខកូដវគ្គសិក្សា"
            .Columns(0).Width = 60
            .Columns(0).DefaultCellStyle.Format = "000"
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).Width = 220
            .Columns(1).HeaderText = "វគ្គសិក្សា"
            .Columns(2).Width = 70
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderText = "ប្រាក់មិនទាន់បង"
            .Columns(2).DefaultCellStyle.Format = "C2" ' Format as currency
            .Columns(3).HeaderText = "ស្ថានភាពវគ្គសិក្សា"
            .Columns(3).Width = 180
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For Each col As DataGridViewColumn In .Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        End With
    End Sub
    Sub GetData()
        Dim query As String = "SELECT tblCourse.ID, tblSubject.Subject, tblPayment.Unpaid, tblCourseStatus.Status
                FROM (tblCourseStatus INNER JOIN (tblSubject INNER JOIN tblCourse ON tblSubject.ID = tblCourse.SubjectID) ON (tblCourseStatus.ID = tblCourse.StatusID) AND (tblCourseStatus.ID = tblCourse.StatusID)) INNER JOIN (tblPayment INNER JOIN tblRegister ON tblPayment.RegisterID = tblRegister.ID) ON tblCourse.ID = tblRegister.CourseID
                WHERE (((tblRegister.StudentID)=" & student.id & "));"
        Dim dt As DataTable = student.ExecuteQuery(query)
        DataGridView1.DataSource = dt
    End Sub
End Class