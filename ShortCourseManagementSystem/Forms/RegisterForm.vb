Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Printing
Public Class RegisterForm
    Dim conn As OleDbConnection
    Dim newStudent As Boolean = True
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Data\StudentManagementSystem.accdb;Persist Security Info=False;"
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.AllowUserToAddRows = False
        conn = New OleDbConnection(connString)
        ImportDataToDataGridView()
        ImportDataToTextboxCourse()
        picStudent.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
    End Sub

    Sub ImportDataToTextboxCourse()
        Dim cmdString As String = "SELECT tblCourses.CourseName, tblClass.StartDate, tblClass.StatusID FROM tblCourses INNER JOIN tblClass ON tblCourses.ID = tblClass.CourseID WHERE (((tblClass.StartDate)>=([End_Date]-100)) AND ((tblClass.StatusID)<=2));"
        Try
            conn.Open()
            cmd = New OleDbCommand(cmdString, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                cbCourse.Items.Add(reader("CourseName").ToString())
            End While
            reader.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Import Data To CourseList DataGridView
    Sub ImportDataToDataGridView()
        Dim cmdString As String = "SELECT tblClass.ClassID, tblCourses.CourseName, tblTeacher.engName AS TeacherName, tblClass.StartDate, tblSchedule.Schedule, tblRoom.RoomID, (SELECT COUNT(*) FROM tblRegister WHERE tblClass.ClassID = tblRegister.ClassID) AS Current_Enrollments, tblClassStatus.Status
FROM tblClassStatus INNER JOIN (tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN tblClass ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblTeacher.ID = tblClass.TeacherID) ON tblClassStatus.ID = tblClass.StatusID
WHERE (((tblClass.StartDate)>=Now()-100) AND ((tblClass.StatusID)<=2));"
        Try
            conn.Open()
            cmd = New OleDbCommand(cmdString, conn)
            adapter = New OleDbDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            adapter.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        Dim query As String = "SELECT tblCourses.BasePrice, tblSchedule.Schedule, tblRoom.RoomID
From tblCourses INNER Join (tblSchedule INNER Join (tblRoom INNER Join tblClass On tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblCourses.ID = tblClass.CourseID
Where (((tblCourses.CourseName) =@CourseName));"
        Dim courseName As String = cbCourse.Text
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@CourseName", courseName)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lbPrice.Text = reader("BasePrice")
                        lbTime.Text = reader("Schedule")
                        lbRoom.Text = reader("RoomID")
                    End If
                End Using
            End Using
        End Using

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenPic.Title = "Select a Picture"
        OpenPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If OpenPic.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenPic.FileName
            picStudent.ImageLocation = filePath
        End If
    End Sub


    Private Sub txtDis_TextChanged_1(sender As Object, e As EventArgs) Handles txtDis.TextChanged
        Dim dis As Decimal
        If cbCourse.Text = String.Empty Then
            MessageBox.Show("Please Choose Course !!!!!", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not (Decimal.TryParse(txtDis.Text, dis)) Or dis < 0 Or dis > 100 Then
            MessageBox.Show("Please enter a valid number for the discount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDis.Focus()
            txtDis.SelectAll()
            Return
        End If
        Dim amount As Decimal
        Dim price As Decimal = Decimal.Parse(lbPrice.Text)
        amount = price - price * (dis / 100.0) ' Ensures decimal division
        lbAmount.Text = amount.ToString("F2") ' Formats output as 2 decimal places
        amount.ToString("F2")
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If newStudent Then
            If txtKhName.Texts.Length <= 0 Then
                MessageBox.Show("Please enter Student's KhmerName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKhName.PlaceholderColor = Color.Red
                txtKhName.Focus()
                Return
            End If
            If txtEngName.Texts.Length <= 0 Then
                MessageBox.Show("Please enter Student's EnglishName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEngName.Focus()
                Return
            End If
            If txtPOB.Texts.Length <= 0 Then
                MessageBox.Show("Please enter Student's place of birth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPOB.Focus()

                Return
            End If
            If (txtPhone.Texts.Length < 9 Or txtPhone.Texts.Length > 10) And txtPhone.Texts.Length <> 0 Then
                MessageBox.Show("Please enter a valid phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhone.PlaceholderColor = Color.Red
                txtPhone.Focus()
                'txtPhone.SelectAll()
                Return
            ElseIf txtPhone.Texts.Length = 0 Then
                Dim result = MessageBox.Show("Do not have Phone Number", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            End If
            If txtEmail.Texts.Length <= 0 Then
                MessageBox.Show("Please enter Student's email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Return
            ElseIf Not IsValidEmail(txtEmail.Texts) Then
                MessageBox.Show("Please enter a valid email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Focus()
                Return
            End If
        End If

        If cbCourse.Text.Length <= 0 Then
            MessageBox.Show("Please select a course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCourse.Focus()
            Return
        End If
        Dim gender As String = cbGender.Text
        Dim pic As String = SaveImageAndReturnPath()
        Dim query As String = "INSERT INTO tblStudent (KhName, EngName, DateOfBirth, Phone, Email, Gender, PlaceOfBirth, Picture) VALUES (@KhName, @EnghName, @DateOfBirth, @Phone, @Email, @Gender, @PlaceOfBirth, @Picture)"
        Try
            conn.Open()
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@KhName", txtKhName.Texts)
            cmd.Parameters.AddWithValue("@EnghName", txtEngName.Texts)
            cmd.Parameters.AddWithValue("@DateOfBirth", dtpDob.Value)
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Texts)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Texts)
            cmd.Parameters.AddWithValue("@Gender", gender)
            cmd.Parameters.AddWithValue("@PlaceOfBirth", txtPOB.Texts)
            cmd.Parameters.AddWithValue("@Picture", pic)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY"
            Dim test = Convert.ToInt32(cmd.ExecuteScalar())
            MessageBox.Show("Student has been registered successfully " & test, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try




    End Sub

    'IsValidEmail
    Function IsValidEmail(ByVal email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return True
        Catch
            Return False
        End Try
    End Function

    'Save Image and reture the path
    Function SaveImageAndReturnPath() As String
        If Path.GetFileName(picStudent.ImageLocation) = "defalutStudent.png" Then
            Return picStudent.ImageLocation
        End If
        Dim source As String = picStudent.ImageLocation
        Dim destination As String = "\Images\" & Path.GetFileName(source)
        FileCopy(source, destination)
        Return destination
    End Function

    Private Sub btnChooseStudent_Click(sender As Object, e As EventArgs) Handles btnChooseStudent.Click

    End Sub
End Class