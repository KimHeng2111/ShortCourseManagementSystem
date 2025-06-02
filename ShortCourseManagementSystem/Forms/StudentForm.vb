Public Class StudentForm
    Dim student As Student = New Student()
    Public Sub New()
        ' Constructor for StudentForm class
        InitializeComponent()
        display()
        picStudent.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
    End Sub
    Private Sub display()
        DataGridView2.DataSource = student.GetStudentData()
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Dim id As String = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        student.GetStudentByID(id)
        txtName.Texts = student.khName
        txtEngName.Texts = student.engName
        cbGender.Text = student.gender
        dtpDob.Value = student.DateOfBirth
        txtEmail.Texts = student.email
        txtPhone.Texts = student.phone
        txtAddress.Texts = student.address
        If Not String.IsNullOrEmpty(student.picture) Then
            picStudent.ImageLocation = student.picture
        Else
            picStudent.ImageLocation = Application.StartupPath & "\Images\defaultStudent.png"
        End If
    End Sub
End Class