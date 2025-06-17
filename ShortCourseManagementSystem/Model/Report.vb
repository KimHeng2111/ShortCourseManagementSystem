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
            dt.Rows.Add(reader("ID"), reader("KhName"), reader("engName"), reader("Address"),
                    reader("Phone"), reader("Email"), formattedDate, formattedActive)
        End While
        Return dt
    End Function
    Public Function GetStudentReport() As DataTable
        Dim query As String = "SELECT tblStudent.ID, tblStudent.KhName, tblStudent.EngName, tblStudent.Gender, tblStudent.DateOfBirth, tblStudent.Address, tblStudent.Phone, tblCourses.CourseName
                                FROM tblPaymentStatus INNER JOIN (tblPayment INNER JOIN ((tblStudent INNER JOIN tblRegister ON tblStudent.ID = tblRegister.StudentID)
                                INNER JOIN (tblCourses INNER JOIN tblClass ON tblCourses.ID = tblClass.CourseID) 
                                ON tblRegister.ClassID = tblClass.ClassID) ON tblPayment.ID = tblRegister.PaymentID) ON tblPaymentStatus.ID = tblPayment.StatusID;"
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
        dt.Columns.Add("CourseName", GetType(String))
        While reader.Read()
            Dim formattedDate As String = Convert.ToDateTime(reader("DateOfBirth")).ToString("dd/MM/yyyy") ' Example format
            dt.Rows.Add(reader("ID"), reader("KhName"), reader("EngName"), reader("Gender"), reader("Address"),
                    reader("Phone"), formattedDate, reader("CourseName"))
        End While
        Return dt
    End Function
End Class
