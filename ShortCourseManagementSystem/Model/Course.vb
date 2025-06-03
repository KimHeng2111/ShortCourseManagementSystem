Imports System.Data.OleDb
Public Class Course
    Inherits ConnectionDB
    Public Sub New()
        ' Constructor for Course class
        MyBase.New()
    End Sub
    Public courseID As String
    Public courseName As String
    Public Description As String
    Public durations As Integer
    Public basePrice As Decimal

    Public Function GetCourseData() As DataTable

        Dim query As String = "SELECT 
        tblCourses.ID, 
        tblCourses.CourseName, 
        tblCourses.Description, 
        tblCourses.DurationHours, 
        tblCourses.BasePrice, 
        (SELECT COUNT(*) FROM tblClass WHERE  tblClass.CourseID = tblCourses.ID) AS AllClass, 
        (SELECT COUNT(*) FROM tblClass WHERE StatusID = 3 AND tblClass.CourseID = tblCourses.ID) AS CompleteClass
        FROM tblCourses 
        GROUP BY 
        tblCourses.ID, 
        tblCourses.CourseName, 
        tblCourses.Description, 
        tblCourses.DurationHours, 
        tblCourses.BasePrice;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
    Public Sub GetCourseByID(courseID As String)
        Dim query As String = "SELECT * FROM tblCourses WHERE ID = @CourseID"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", courseID)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Me.courseID = reader("ID").ToString()
            Me.courseName = reader("CourseName").ToString()
            Me.Description = reader("Description").ToString()
            Me.durations = Convert.ToInt32(reader("DurationHours"))
            Me.basePrice = Convert.ToDecimal(reader("BasePrice"))
        End While
        reader.Close()
        CloseConnection()
    End Sub
    Public Sub GetCourseByName(courseName As String)
        Dim query As String = "SELECT * FROM tblCourses WHERE CourseName = @CourseName"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseName", courseName)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Me.courseID = reader("ID").ToString()
            Me.courseName = reader("CourseName").ToString()
            Me.Description = reader("Description").ToString()
            Me.durations = Convert.ToInt32(reader("DurationHours"))
            Me.basePrice = Convert.ToDecimal(reader("BasePrice"))
        End While
        reader.Close()
        CloseConnection()
    End Sub
    Public Sub AddCourse(courseName As String, description As String, durationHours As Integer, basePrice As Decimal)
        Dim query As String = "INSERT INTO tblCourses (CourseName, Description, DurationHours, BasePrice) VALUES (@CourseName, @Description, @DurationHours, @BasePrice)"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseName", courseName)
        cmd.Parameters.AddWithValue("@Description", description)
        cmd.Parameters.AddWithValue("@DurationHours", durationHours)
        cmd.Parameters.AddWithValue("@BasePrice", basePrice)
        ExecuteNonQuery(cmd)
    End Sub
    Public Sub DeleteCourse()
        Dim query As String = "DELETE FROM tblCourses WHERE ID = @CourseID"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", Me.courseID)
        ExecuteNonQuery(cmd)
    End Sub
    Public Sub UpdateCourse()
        Dim query As String = "UPDATE tblCourses SET CourseName = @CourseName, Description = @Description, DurationHours = @DurationHours, BasePrice = @BasePrice WHERE ID = @CourseID"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseName", Me.courseName)
        cmd.Parameters.AddWithValue("@Description", Me.Description)
        cmd.Parameters.AddWithValue("@DurationHours", Me.durations)
        cmd.Parameters.AddWithValue("@BasePrice", Me.basePrice)
        cmd.Parameters.AddWithValue("@CourseID", Me.courseID)
        ExecuteNonQuery(cmd)
    End Sub
End Class
