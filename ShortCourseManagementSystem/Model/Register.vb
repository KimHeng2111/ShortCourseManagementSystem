Imports System.Data.OleDb
Imports System.Web.UI

Public Class Register
    Inherits ConnectionDB
    Public registerID As String
    Public manageClass As Course
    Public student As Student
    Public discount As Byte
    Public payment As Payment

    'Method to register a student for a subject
    Public Function GetRegisterData() As DataTable
        Dim query As String = "SELECT tblCourse.ID, tblSubject.Subject, tblTeacher.EngName, tblCourse.StartDate, tblSchedule.Schedule, tblRoom.Room, (SELECT COUNT(*) FROM tblRegister WHERE tblCourse.ID = tblRegister.CourseID) AS TotalStudent
                                FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblSubject INNER JOIN (tblCourseStatus INNER JOIN tblCourse ON tblCourseStatus.ID = tblCourse.StatusID) ON tblSubject.ID = tblCourse.ID) ON tblRoom.ID = tblCourse.RoomID) ON tblSchedule.ID = tblCourse.ScheduleID) ON tblTeacher.ID = tblCourse.TeacherID
                                WHERE (((tblCourse.StatusID)<=2))
                                ORDER BY tblCourse.ID;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function

    Public Sub New()
        ' Constructor for Register class
        MyBase.New()
        manageClass = New Course()
        student = New Student()
        payment = New Payment()
    End Sub

    'Register a student for a class
    Public Sub RegisterStudent()
        Dim query As String = "INSERT INTO tblRegister (CourseID, StudentID, Discount,PaymentID) VALUES (@CourseID, @StudentID, @Discount,@PaymentID);"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", manageClass.ID)
        cmd.Parameters.AddWithValue("@StudentID", student.id)
        cmd.Parameters.AddWithValue("@Discount", discount)
        cmd.Parameters.AddWithValue("@PaymentID", payment.paymentID)
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT @@IDENTITY;"
        Dim id As String = cmd.ExecuteScalar().ToString()
        query = "UPDATE tblCourse SET CurrentEnrollment = CurrentEnrollment + 1 WHERE ID = @id"
        cmd.CommandText = query
        cmd.Parameters.AddWithValue("@id", manageClass.ID)
        ExecuteNonQuery(cmd)
        GetRegisterByID(id)
    End Sub
    'Get register by ID
    Public Sub GetRegisterByID(id As String)
        Dim query As String = "SELECT * FROM tblRegister WHERE ID = @RegisterID;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@RegisterID", Convert.ToInt16(id))
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            registerID = reader("ID").ToString()
            manageClass.GetCourseByID(reader("CourseID").ToString())
            student.GetStudentByID(reader("StudentID").ToString())

            discount = Convert.ToByte(reader("Discount"))
            payment.GetPaymentByID(reader("PaymentID").ToString())
        End If
        reader.Close()
        CloseConnection()
    End Sub
    'Update register information
    Public Sub UpdateRegister(id As String)
        Dim query As String = "UPDATE tblRegister SET CourseID = @CourseID, StudentID = @StudentID, Discount = @Discount, PaymentID = @PaymentID WHERE RegisterID = @RegisterID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", manageClass.ID)
        cmd.Parameters.AddWithValue("@StudentID", student.id)
        cmd.Parameters.AddWithValue("@Discount", discount)
        cmd.Parameters.AddWithValue("@PaymentID", payment.paymentID)
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
    Public Function GetCourseList() As Dictionary(Of String, Integer)
        Dim CourseList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT DISTINCT tblSubject.Subject, tblSubject.ID
                                FROM tblSubject INNER JOIN tblCourse ON tblSubject.ID = tblCourse.ID
                                GROUP BY tblSubject.Subject, tblSubject.ID, tblCourse.StatusID, tblCourse.ID
                                HAVING (((tblCourse.StatusID)<=2));"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            CourseList.Add(reader("Subject"), Integer.Parse(reader("ID")))
        End While
        CourseList.Add("ជ្រើសរើសវគ្គសិក្សា", -1)
        reader.Close()
        CloseConnection()
        Return CourseList
    End Function
    Public Function GetTimeList(courseID As String) As Dictionary(Of String, Integer)
        Dim TimeList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblSchedule.Schedule, tblCourse.ID
                                FROM tblSchedule INNER JOIN tblCourse ON tblSchedule.ID = tblCourse.ScheduleID
                                WHERE (((tblCourse.ID)=@ID) AND ((tblCourse.StatusID)<=2))
                                ORDER BY tblSchedule.Schedule;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", courseID)
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