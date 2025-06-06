Imports System.Data.OleDb
Imports System.Web.UI

Public Class Register
    Inherits ConnectionDB
    Public registerID As String
    Public manageClass As ManageClass
    Public student As Student
    Public discount As Byte
    Public payment As Payment

    'Method to register a student for a course
    Public Function GetRegisterData() As DataTable
        Dim query As String = "SELECT tblClass.ClassID, tblCourses.CourseName, tblTeacher.engName AS TeacherName, tblClass.StartDate, tblSchedule.Schedule, tblRoom.RoomID, (SELECT COUNT(*) FROM tblRegister WHERE tblClass.ClassID = tblRegister.ClassID) AS TotalStudent
                                FROM tblTeacher INNER JOIN (tblSchedule INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblSchedule.ID = tblClass.ScheduleID) ON tblTeacher.ID = tblClass.TeacherID
                                WHERE (((tblClass.StatusID)<=2))
                                ORDER BY tblClass.ClassID;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function

    Public Sub New()
        ' Constructor for Register class
        MyBase.New()
        manageClass = New ManageClass()
        student = New Student()
        payment = New Payment()
    End Sub

    'Register a student for a class
    Public Sub RegisterStudent()
        Dim query As String = "INSERT INTO tblRegister (ClassID, StudentID, Discount,PaymentID) VALUES (@ClassID, @StudentID, @Discount,@PaymentID);"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ClassID", manageClass.classID)
        cmd.Parameters.AddWithValue("@StudentID", student.id)
        cmd.Parameters.AddWithValue("@Discount", discount)
        cmd.Parameters.AddWithValue("@PaymentID", payment.paymentID)
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT @@IDENTITY;"
        Dim id As String = cmd.ExecuteScalar().ToString()
        GetRegisterByID(id)
    End Sub
    'Get register by ID
    Public Sub GetRegisterByID(id As String)
        Dim query As String = "SELECT * FROM tblRegister WHERE ID = @RegisterID;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@RegisterID", Convert.ToInt16(id))
        MessageBox.Show("Register ID : " & id)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            registerID = reader("ID").ToString()
            manageClass.GetClassByID(reader("ClassID").ToString())
            student.GetStudentByID(reader("StudentID").ToString())

            discount = Convert.ToByte(reader("Discount"))
            payment.GetPaymentByID(reader("PaymentID").ToString())
        End If
        reader.Close()
        CloseConnection()
    End Sub
    'Update register information
    Public Sub UpdateRegister(id As String)
        Dim query As String = "UPDATE tblRegister SET ClassID = @ClassID, StudentID = @StudentID, Discount = @Discount, PaymentID = @PaymentID WHERE RegisterID = @RegisterID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ClassID", manageClass.classID)
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
    End Sub

    'Insert DATA TO combobox
    Public Function GetCourseList() As Dictionary(Of String, Integer)
        Dim CourseList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblCourses.CourseName, tblCourses.ID
                                FROM tblCourses INNER JOIN tblClass ON tblCourses.ID = tblClass.CourseID
                                GROUP BY tblCourses.CourseName, tblCourses.ID, tblClass.StatusID
                                HAVING (((tblClass.StatusID)<=2))
                                ORDER BY Var(tblClass.ClassID) ASC;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            CourseList.Add(reader("CourseName"), Integer.Parse(reader("ID")))
        End While
        CourseList.Add("ជ្រើសរើសវគ្គសិក្សា", -1)
        reader.Close()
        CloseConnection()
        Return CourseList
    End Function
    Public Function GetTimeList(courseID As String) As Dictionary(Of String, Integer)
        Dim TimeList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblSchedule.Schedule, tblClass.ClassID
                                FROM tblSchedule INNER JOIN tblClass ON tblSchedule.ID = tblClass.ScheduleID
                                WHERE (((tblClass.CourseID)=@courseID) AND ((tblClass.StatusID)<=2))
                                ORDER BY tblSchedule.Schedule;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@courseID", courseID)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            TimeList.Add(reader("Schedule"), Integer.Parse(reader("ClassID")))
        End While
        TimeList.Add("ជ្រើសរើសម៉ោង", -1)
        reader.Close()
        CloseConnection()
        Return TimeList
    End Function

End Class