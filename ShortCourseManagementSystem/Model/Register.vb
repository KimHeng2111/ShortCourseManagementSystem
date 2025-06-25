Imports System.Data.OleDb
Imports System.Web.UI

Public Class Register
    Inherits ConnectionDB
    Public registerID As String
    Public course As Course
    Public student As Student
    Public discount As Decimal
    Public payment As Payment

    'Method to register a student for a subject
    Public Function GetRegisterData() As DataTable
        Dim query As String = "SELECT tblCourse.ID, tblSubject.Subject, tblTeacher.EngName, tblCourse.StartDate, tblSchedule.Schedule, tblRoom.Room, (SELECT COUNT(*) FROM tblRegister WHERE tblCourse.ID = tblRegister.CourseID) AS TotalStudent
                                FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblSubject INNER JOIN (tblCourseStatus INNER JOIN tblCourse ON tblCourseStatus.ID = tblCourse.StatusID) ON tblSubject.ID = tblCourse.SubjectID) ON tblRoom.ID = tblCourse.RoomID) ON tblSchedule.ID = tblCourse.ScheduleID) ON tblTeacher.ID = tblCourse.TeacherID
                                WHERE (((tblCourse.StatusID)<=2))
                                ORDER BY tblCourse.ID;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function

    Public Sub New()
        ' Constructor for Register class
        MyBase.New()
        course = New Course()
        student = New Student()
        payment = New Payment()
    End Sub

    'Register a student for a class
    Public Sub RegisterStudent()
        Dim query As String = "INSERT INTO tblRegister (CourseID, StudentID, Discount) VALUES (@CourseID, @StudentID, @Discount);"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", course.ID)
        cmd.Parameters.AddWithValue("@StudentID", student.id)
        cmd.Parameters.AddWithValue("@Discount", discount)
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT @@IDENTITY;"
        Dim id As String = cmd.ExecuteScalar().ToString()
        query = "UPDATE tblCourse SET CurrentEnrollment = CurrentEnrollment + 1 WHERE ID = @id"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@id", course.ID)
        ExecuteNonQuery(cmd)
        GetRegisterByID(id)
    End Sub
    'Get register by ID
    Public Sub GetRegisterByID(id As String)
        Dim query As String = "SELECT * FROM tblRegister WHERE ID = @RegisterID;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@RegisterID", id)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            registerID = reader("ID").ToString()
            course.GetCourseByID(reader("CourseID").ToString())
            student.GetStudentByID(reader("StudentID").ToString())
            discount = Convert.ToByte(reader("Discount"))
            payment.GetPaymentByID(registerID)
        End If
        reader.Close()
        CloseConnection()
    End Sub
    'Update register information
    Public Sub UpdateRegister(id As String)
        Dim query As String = "UPDATE tblRegister SET CourseID = @CourseID, StudentID = @StudentID, Discount = @Discount WHERE RegisterID = @RegisterID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", course.ID)
        cmd.Parameters.AddWithValue("@StudentID", student.id)
        cmd.Parameters.AddWithValue("@Discount", discount)
        cmd.Parameters.AddWithValue("@RegisterID", id)
        ExecuteNonQuery(cmd)
    End Sub
    'Delete a register entry by ID
    Public Sub DeleteRegister(id As String)
        Dim query As String = "DELETE FROM tblRegister WHERE RegisterID = @RegisterID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@RegisterID", id)
        ExecuteNonQuery(cmd)
        query = "UPDATE tblCourse SET CurrentEnrollment = CurrentEnrollment - 1 WHERE ID IN (SELECT ClassID FROM tblRegister WHERE ID = @id"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@id", id)
        ExecuteNonQuery(cmd)
    End Sub

    'Insert DATA TO combobox
    Public Function GetSubjectList() As Dictionary(Of String, Integer)
        Dim subjectList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT DISTINCT tblSubject.Subject, tblSubject.ID
                                FROM tblSubject INNER JOIN tblCourse ON tblSubject.ID = tblCourse.SubjectID
                                GROUP BY tblSubject.Subject, tblSubject.ID, tblCourse.StatusID, tblCourse.SubjectID
                                HAVING (((tblCourse.StatusID)<=2));"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            subjectList.Add(reader("Subject"), Integer.Parse(reader("ID")))
        End While
        subjectList.Add("ជ្រើសរើសវគ្គសិក្សា", -1)
        reader.Close()
        CloseConnection()
        Return subjectList
    End Function
    Public Function GetTimeList(subjectID As String) As Dictionary(Of String, Integer)
        Dim TimeList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblSchedule.Schedule, tblCourse.ID
                                FROM tblSchedule INNER JOIN tblCourse ON tblSchedule.ID = tblCourse.ScheduleID
                                WHERE (((tblCourse.SubjectID)=@ID) AND ((tblCourse.StatusID)<=2))
                                ORDER BY tblSchedule.Schedule;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", subjectID)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            TimeList.Add(reader("Schedule"), Integer.Parse(reader("ID")))
        End While
        TimeList.Add("ជ្រើសរើសម៉ោង", -1)
        reader.Close()
        CloseConnection()
        Return TimeList
    End Function

End Class