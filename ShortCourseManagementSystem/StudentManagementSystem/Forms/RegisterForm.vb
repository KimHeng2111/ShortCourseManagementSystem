Imports System.Data.OleDb

Public Class RegisterForm
    Dim conn As OleDbConnection

    Private Sub btnStudentImage_Click(sender As Object, e As EventArgs) Handles btnStudentImage.Click, picStudent.Click
        OpenFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picStudent.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbDate.Text = DateTime.Now.ToString("dddd dd/MMM/yyyy")
        conn = New OleDbConnection(ConnectionDB.connString)
        Try
            Conn.open()
            Dim query As String = "SELECT tblCourses.CourseName FROM tblCourses INNER JOIN tblClass ON tblCourses.ID = tblClass.CourseID;"
            Dim cmd As New OleDbCommand(query, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim courseName As String = reader("CourseName").ToString()
                cbCourses.Items.Add(courseName)
            End While
        Catch ex As Exception

        End Try
    End Sub

End Class