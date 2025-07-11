﻿Imports System.Data.OleDb

Public Class Dashboard
    Inherits ConnectionDB
    Public totalStudent As Int16
    Public completeStudent As Int16
    Public totalCourse As Int16
    Public completeCourse As Int16
    Public totalTeacher As Int16
    Public TotalSubject As Int16
    Public CourseList As New Dictionary(Of String, Int16)
    Public SubjectList As New Dictionary(Of String, Int16)
    Public Sub New()
        GetData()
    End Sub
    Public Sub GetData()
        Dim query As String = "SELECT COUNT(*) FROM tblRegister;"
        totalStudent = Int16.Parse(ExecuteScalar(query))
        query = "SELECT Count(*) AS TotalStudent FROM tblRegister INNER JOIN tblCourse ON tblRegister.CourseID = tblCourse.ID GROUP BY tblCourse.StatusID HAVING (((tblCourse.StatusID)=3));"
        Dim result = ExecuteScalar(query)
        completeStudent = If(result IsNot Nothing, Convert.ToInt16(result), 0)
        query = "SELECT COUNT(*) FROM tblCourse;"
        totalCourse = Int16.Parse(ExecuteScalar(query))
        query = "SELECT COUNT(*) FROM tblCourse WHERE StatusID = 3 ;"
        completeCourse = Int16.Parse(ExecuteScalar(query))
        query = "SELECT COUNT(*) FROM tblTeacher;"
        totalTeacher = Int16.Parse(ExecuteScalar(query))
        query = "SELECT COUNT(*) FROM tblSubject"
        TotalSubject = Int16.Parse(ExecuteScalar(query))
        query = "SELECT tblSubject.Subject, SUM(tblCourse.CurrentEnrollment) AS TotalStudent FROM tblCourse INNER JOIN tblSubject ON tblCourse.SubjectID = tblSubject.ID GROUP BY tblSubject.Subject;"
        Dim cmd As New OleDbCommand(query, GetConnection())
        OpenConnection()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            CourseList.Add(reader("Subject").ToString(), Convert.ToInt16(reader("TotalStudent")))
        End While
        reader.Close()
        cmd.CommandText = "SELECT tblSubject.Subject, (SELECT COUNT (*) FROM tblCourse WHERE tblCourse.SubjectID = tblSubject.ID) AS TotalCourse FROM tblSubject"
        reader = cmd.ExecuteReader()
        While reader.Read()
            SubjectList.Add(reader("Subject").ToString(), Convert.ToInt16(reader("TotalCourse")))
        End While
        reader.Close()
    End Sub
    'Courses DataTable
    Public Function GetCourseDataTable() As DataTable
        Dim query As String = "SELECT tblSubject.Subject, tblTeacher.KhName, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.CourseID = tblCourse.ID) AS TotalStudent, tblCourse.StartDate, tblCourse.EndDate, tblCourseStatus.Status
                                FROM tblTeacher INNER JOIN (tblSubject INNER JOIN (tblCourseStatus INNER JOIN tblCourse ON (tblCourseStatus.ID = tblCourse.StatusID) AND (tblCourseStatus.ID = tblCourse.StatusID)) ON tblSubject.ID = tblCourse.SubjectID) ON tblTeacher.ID = tblCourse.TeacherID
                                WHERE (((tblCourse.StatusID)<=2));"
        Dim dt = ExecuteQuery(query)
        Return dt
    End Function
    Public Function GetNewRegister() As DataTable
        Dim query As String = "SELECT * FROM
                                 (SELECT  TOP  10 *
                                FROM qtyRegister
                                ORDER BY ID DESC)
                                ORDER BY ID  ASC;"
        Dim dt = ExecuteQuery(query)
        Return dt
    End Function
    Public Function CourseCoomingSoon() As DataTable
        Dim query As String = "SELECT DCount( '*','tblCourse','StartDate >= #' & Format([StartDate],'yyyy-mm-dd hh:nn : ss') & '#') AS [No], tblSubject.Subject, tblCourse.StartDate, tblCourse.CurrentEnrollment
                            From tblSubject INNER Join tblCourse On tblSubject.ID = tblCourse.SubjectID
                            Where (((tblCourse.StartDate) > Now()));"
        Dim dt = ExecuteQuery(query)
        Return dt
    End Function
    Public Function GetSubjectList() As DataTable
        Dim query As String = " SELECT 
                                    tblSubject.ID, 
                                    tblSubject.Subject,
                                    COUNT(tblCourse.ID) AS TotalCourse,
                                    SUM(IIf(tblCourse.StatusID = 3, 1, 0)) AS CompleteCourse,
                                    SUM(tblCourse.CurrentEnrollment) AS SumOfCurrentEnrollment
                                FROM 
                                    tblSubject 
                                    INNER JOIN tblCourse ON tblSubject.ID = tblCourse.SubjectID
                                GROUP BY 
                                    tblSubject.ID, tblSubject.Subject;"
        Dim dt = ExecuteQuery(query)
        Return dt
    End Function
End Class