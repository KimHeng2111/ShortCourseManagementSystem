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
    End Sub
    Sub Display()
        GetData()
        DataGridView1.Columns(0).HeaderText = "ClassID"
        DataGridView1.Columns(1).HeaderText = "វគ្គសិក្សា"
        DataGridView1.Columns(2).HeaderText = "ប្រាក់មិនទាន់បង"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "C2" ' Format as currency
        DataGridView1.Columns(3).HeaderText = "ស្ថានភាពថ្នាក់"
    End Sub
    Sub GetData()
        Dim query As String = "SELECT tblClass.ClassID, tblCourses.CourseName, tblPayment.Unpaid, tblClassStatus.Status
                FROM (tblClassStatus INNER JOIN (tblCourses INNER JOIN tblClass ON tblCourses.ID = tblClass.CourseID) ON (tblClassStatus.ID = tblClass.StatusID) AND (tblClassStatus.ID = tblClass.StatusID)) INNER JOIN (tblPayment INNER JOIN tblRegister ON tblPayment.ID = tblRegister.PaymentID) ON tblClass.ClassID = tblRegister.ClassID
                WHERE (((tblRegister.StudentID)=" & student.id & "));"
        Dim dt As DataTable = student.ExecuteQuery(query)
        DataGridView1.DataSource = dt
    End Sub
End Class