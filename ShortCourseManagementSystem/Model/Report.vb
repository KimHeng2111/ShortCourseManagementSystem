Imports System.Data.OleDb

Public Class Report
    Inherits ConnectionDB
    Public Function GetTeacherReport() As DataTable
        Dim query As String = "SELECT tblTeacher.ID, tblTeacher.KhName, tblTeacher.engName, tblTeacher.Address, tblTeacher.Phone, tblTeacher.Email, tblTeacher.StartDate, tblTeacher.IsActive FROM tblTeacher;"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("KhName", GetType(String))
        dt.Columns.Add("engName", GetType(String))
        dt.Columns.Add("Address", GetType(String))
        dt.Columns.Add("Phone", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("StartDate", GetType(String)) ' Change to String for formatting
        dt.Columns.Add("IsActive", GetType(String))
        While reader.Read()
            Dim formattedDate As String = Convert.ToDateTime(reader("StartDate")).ToString("dd/MM/yyyy") ' Example format
            Dim formattedActive As String = If(reader("IsActive").ToString().ToLower() = "true", "សកម្ម", "អសកម្ម")
            dt.Rows.Add(reader("ID"), reader("KhName"), reader("EngName"), reader("Address"),
                    reader("Phone"), reader("Email"), formattedDate, formattedActive)
        End While
        Return dt
    End Function
    Public Function GetStudentReport() As DataTable
        Dim query As String = "SELECT tblStudent.ID, tblStudent.KhName, tblStudent.EngName, tblStudent.Gender, tblStudent.DateOfBirth, tblStudent.Address, tblStudent.Phone, tblSubject.Subject
                        FROM tblStudent INNER JOIN ((tblPaymentStatus INNER JOIN tblPayment ON tblPaymentStatus.ID = tblPayment.StatusID) INNER JOIN (tblRegister INNER JOIN (tblSubject 
                        INNER JOIN tblCourse ON tblSubject.ID = tblCourse.SubjectID) ON tblRegister.CourseID = tblCourse.ID)
                         ON tblPayment.ID = tblRegister.PaymentID) ON tblStudent.ID = tblRegister.StudentID;"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("KhName", GetType(String))
        dt.Columns.Add("EngName", GetType(String))
        dt.Columns.Add("Gender", GetType(String))
        dt.Columns.Add("Address", GetType(String))
        dt.Columns.Add("Phone", GetType(String))
        dt.Columns.Add("DateOfBirth", GetType(String)) ' Change to String for formatting
        dt.Columns.Add("Subject", GetType(String))
        While reader.Read()
            Dim formattedDate As String = Convert.ToDateTime(reader("DateOfBirth")).ToString("dd/MM/yyyy") ' Example format
            dt.Rows.Add(reader("ID"), reader("KhName"), reader("EngName"), reader("Gender"), reader("Address"),
                    reader("Phone"), formattedDate, reader("Subject"))
        End While
        Return dt
    End Function
    Public Function GetCourseReport() As DataTable
        Dim query As String = "SELECT tblCourse.ID, tblSubject.Subject, tblTeacher.KhName, tblSchedule.Schedule, tblRoom.Room, tblCourse.StartDate, 
                                tblCourse.EndDate, tblCourse.CurrentEnrollment, tblCourseStatus.Status
                                FROM tblCourseStatus INNER JOIN (tblTeacher INNER JOIN (tblSchedule 
                                INNER JOIN (tblRoom INNER JOIN (tblSubject INNER JOIN tblCourse ON tblSubject.ID = tblCourse.[SubjectID]) 
                                ON tblRoom.ID = tblCourse.RoomID) ON tblSchedule.ID = tblCourse.ScheduleID) ON tblTeacher.ID = tblCourse.TeacherID) 
                                ON (tblCourseStatus.ID = tblCourse.StatusID) AND (tblCourseStatus.ID = tblCourse.StatusID);"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Subject", GetType(String))
        dt.Columns.Add("KhName", GetType(String))
        dt.Columns.Add("Schedule", GetType(String))
        dt.Columns.Add("Room", GetType(String))
        dt.Columns.Add("StartDate", GetType(String))
        dt.Columns.Add("EndDate", GetType(String)) ' Change to String for formatting
        dt.Columns.Add("CurrentEnrollment", GetType(Integer))
        dt.Columns.Add("Status", GetType(String))
        While reader.Read()
            Dim startDate As String = Convert.ToDateTime(reader("StartDate")).ToString("dd/MM/yyyy") ' Example format
            Dim EndDate As String = Convert.ToDateTime(reader("EndDate")).ToString("dd/MM/yyyy")
            dt.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
                   startDate, EndDate, reader(7), reader(8))
        End While
        Return dt
    End Function

End Class
