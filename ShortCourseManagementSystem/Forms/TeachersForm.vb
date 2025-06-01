Public Class TeachersForm
    Dim teacher As Teacher = New Teacher()
    Public Sub New()
        ' Constructor for TeachersForm class
        InitializeComponent()
        Display()
        picTeacher.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
    End Sub




    'Display all teachers in DataGridView
    Sub Display()
        DataGridView2.DataSource = teacher.GetTeacherData()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not CheckField() Then
            Return
        Else
            teacher.AddTeacher(txtName.Texts.Trim(), txtEngName.Texts.Trim(), cbGender.Text, dtpDob.Value, txtPOB.Texts.Trim(), txtPhone.Texts.Trim(), txtEmail.Texts.Trim(), picTeacher.ImageLocation)
        End If
        Display()
    End Sub



    'Check User Input
    Private Function CheckField() As Boolean
        Dim khName As String = txtName.Texts
        Dim engName As String = txtEngName.Texts.Trim()
        Dim Gender As String = cbGender.Text
        Dim DoB As Date = dtpDob.Value
        Dim Address As String = txtPOB.Texts.Trim()
        Dim Phone As String = txtPhone.Texts.Trim()
        Dim Email As String = txtEmail.Texts.Trim()

        ' Validate inputs
        If String.IsNullOrEmpty(khName) Then
            MessageBox.Show("Khmer Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(engName) Then
            MessageBox.Show("English Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Gender) Then
            MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(DoB.ToString()) Then
            MessageBox.Show("Date of Birth is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Address) Then
            MessageBox.Show("Place of Birth is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Phone) Or IsNumeric(Phone) = False Then
            MessageBox.Show("Valid Phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Email) Or Not Email.Contains("@") Then
            MessageBox.Show("Valid Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenPic.Title = "Select a Picture"
        OpenPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If OpenPic.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenPic.FileName
            picTeacher.ImageLocation = filePath
        End If
    End Sub


    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Dim teacterID As String = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        teacher.GetTeacherByID(teacterID)
        txtName.Texts = teacher.KhName
        txtEngName.Texts = teacher.EngName
        txtPOB.Texts = teacher.Address
        dtpDob.Value = teacher.DoB.ToString("D")
        txtPhone.Texts = teacher.Phone
        cbGender.Text = teacher.Gender
        txtEmail.Texts = teacher.Email
        If Not String.IsNullOrEmpty(teacher.Picture) Then
            picTeacher.ImageLocation = teacher.Picture
        Else
            picTeacher.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If CheckField() Then
            teacher.KhName = txtName.Texts
            teacher.EngName = txtEngName.Texts.Trim()
            teacher.DoB = dtpDob.Value
            teacher.Address = txtPOB.Texts.Trim()
            teacher.Phone = txtPhone.Texts.Trim()
            teacher.Gender = cbGender.Text
            teacher.Email = txtEmail.Texts.Trim()
            teacher.Picture = picTeacher.ImageLocation

            teacher.UpdateTeacher()
        End If
        Display()
    End Sub
End Class