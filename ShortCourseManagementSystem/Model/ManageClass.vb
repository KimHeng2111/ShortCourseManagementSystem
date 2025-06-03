Public Class ManageClass
    Inherits ConnectionDB
    Public ClassID As String
    Public Course As Course
    Public teacherName As String
    Public startDate As Date

    Public Function GetClassData() As DataTable
        Dim query As String = "SELECT tblClass.ClassID, tblCourses.CourseName AS មុខវិជ្ជា, tblTeacher.KhName, tblRoom.RoomID, tblClass.SecheduleID, tblClass.StartDate, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS CountOfClassID
FROM tblRoom INNER JOIN (tblTeacher INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblTeacher.ID = tblClass.TeacherID) ON tblRoom.ID = tblClass.RoomID
GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.RoomID, tblClass.SecheduleID, tblClass.StartDate;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
End Class
