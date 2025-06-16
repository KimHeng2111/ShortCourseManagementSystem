Public Class Dashboard
    Inherits ConnectionDB
    Public totalStudent As Int16
    Public completeStudent As Int16
    Public totalClass As Int16
    Public completeClass As Int16
    Public totalTeacher As Int16
    Public actionTeacher As Int16
    Public totalCourse As Int16
    Public actionCourse As Int16

    Public Sub New()
        GetData()
    End Sub
    Public Sub GetData()
        Dim query As String = "SELECT COUNT(*) FROM tblRegister;"
        totalStudent = Int16.Parse(ExecuteScalar(query))
        query = "SELECT Count(*) AS TotalStudent FROM tblRegister INNER JOIN tblClass ON tblRegister.ClassID = tblClass.ClassID GROUP BY tblClass.StatusID HAVING (((tblClass.StatusID)=3));"
        completeStudent = Int16.Parse(ExecuteScalar(query))
        query = "SELECT COUNT(*) FROM tblClass;"
        totalClass = Int16.Parse(ExecuteScalar(query))
        query = "SELECT COUNT(*) FROM tblClass WHERE StatusID = 3 ;"
        completeClass = Int16.Parse(ExecuteScalar(query))
        query = "SELECT COUNT(*) FROM tblTeacher;"
        totalTeacher = Int16.Parse(ExecuteScalar(query))
        query = "SELECT Count(*) FROM tblTeacher WHERE isActive=True;"
        actionTeacher = Int16.Parse(ExecuteScalar(query))
        query = "SELECT COUNT(*) FROM tblCourses"
        totalCourse = Int16.Parse(ExecuteScalar(query))
        query = "SELECT Count(*) FROM tblCourses WHERE isActive=True;"
        actionCourse = Int16.Parse(ExecuteScalar(query))
    End Sub
    'Courses DataTable
    Public Function GetCourseDataTable() As DataTable
        Dim query As String = "SELECT tblCourses.CourseName, tblTeacher.KhName, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudent, tblClass.StartDate, tblClass.EndDate, tblClassStatus.Status
                                FROM tblTeacher INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON (tblClassStatus.ID = tblClass.StatusID) AND (tblClassStatus.ID = tblClass.StatusID)) ON tblCourses.ID = tblClass.CourseID) ON tblTeacher.ID = tblClass.TeacherID
                                WHERE (((tblClass.StatusID)<=2));"
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
End Class