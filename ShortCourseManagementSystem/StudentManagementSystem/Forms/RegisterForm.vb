Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

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
            conn.Open()
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

    Private Sub cbCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourses.SelectedIndexChanged
        Dim query As String = "SELECT tblSchedule.StartTime, tblSchedule.EndTime, tblCourses.BasePrice, tblClass.StartDate, tblCourses.Description
        FROM tblCourses INNER JOIN (tblSchedule INNER JOIN tblClass ON tblSchedule.ID = tblClass.SecheduleID) ON tblCourses.ID = tblClass.CourseID
        WHERE (((tblCourses.CourseName)=@CourseName));
        "
        Dim courseName As String = cbCourses.Text
        Try
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@CourseName", courseName)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                lbDate.Text = reader("StartDate")
                lbPrice.Text = reader("BasePrice")
                lbCourseDes.Text = reader("Description")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
End Class