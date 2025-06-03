Imports System.Data.OleDb
Imports System.Windows.Media.Animation
Public Class ManageClass
    Inherits ConnectionDB
    Public classID As String
    Public course As Course
    Public teacher As Teacher
    Public startDate As Date
    Public roomID As Integer
    Public scheduleID As Integer
    Public Sub New()
        ' Constructor for ManageClass class
        MyBase.New()
        course = New Course()
        teacher = New Teacher()
    End Sub
    Public Function GetClassData() As DataTable
        Dim query As String = "SELECT tblClass.ClassID, tblCourses.CourseName AS Course, tblTeacher.KhName AS Teacher, tblRoom.RoomID AS Room, tblSchedule.Schedule, tblClass.StartDate, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudents
            FROM tblSchedule INNER JOIN (tblTeacher INNER JOIN (tblRoom INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblRoom.ID = tblClass.RoomID) ON tblTeacher.ID = tblClass.TeacherID) ON tblSchedule.ID = tblClass.ScheduleID
            GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.RoomID, tblSchedule.Schedule, tblClass.StartDate;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
    Public Sub GetClassByID(id As String)
        Dim query As String = "SELECT * FROM tblClass WHERE ClassID = @ClassID;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ClassID", id)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            classID = reader("ClassID").ToString()
            course.GetCourseByID(reader("CourseID").ToString())
            teacher.GetTeacherByID(reader("TeacherID").ToString())
            startDate = Convert.ToDateTime(reader("StartDate"))
            roomID = Convert.ToInt32(reader("RoomID"))
            scheduleID = Convert.ToInt32(reader("ScheduleID"))
        End If
        reader.Close()
        CloseConnection()
    End Sub
    Public Sub AddClass()
        Dim query As String = "INSERT INTO tblClass ( ClassID, CourseID, TeacherID, StartDate, RoomID, ScheduleID ) 
                                VALUES (@ClassID, @CourseID, @TeacherID, @StartDate, @RoomID, @ScheduleID) "
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ClassID", classID)
        cmd.Parameters.AddWithValue("@CourseID", course.courseID)
        cmd.Parameters.AddWithValue("@TeacherID", teacher.TeacherID)
        cmd.Parameters.AddWithValue("@StartDate", startDate)
        cmd.Parameters.AddWithValue("@RoomID", roomID)
        cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
        ExecuteNonQuery(cmd)
    End Sub
    Public Sub UpdateClass(classID As String, courseID As String, teacherID As String, startDate As String, roomID As Integer, scheduleID As Integer)
        Dim query As String = "UPDATE tblClass 
                            SET CourseID = @CourseID, TeacherID = @TeacherID, StartDate = @StartDate, RoomID = @RoomID, ScheduleID = @ScheduleID 
                            WHERE ClassID = @ClassID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@CourseID", courseID)
        cmd.Parameters.AddWithValue("@TeacherID", teacherID)
        cmd.Parameters.AddWithValue("@StartDate", startDate)
        cmd.Parameters.AddWithValue("@RoomID", roomID)
        cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
        cmd.Parameters.AddWithValue("@ClassID", classID)
        ExecuteNonQuery(cmd)
    End Sub

    Public Sub DeleteClass()
        Dim query As String = "DELETE FROM tblClass WHERE ClassID = @ClassID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ClassID", classID)
        ExecuteNonQuery(cmd)
    End Sub


    'Get Dictionary to insert to Combobox
    Public Function GetTimeList() As Dictionary(Of String, Integer)
        Dim TimeList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblSchedule.Schedule, tblSchedule.ID
                                FROM tblSchedule;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            TimeList.Add(reader("Schedule"), Integer.Parse(reader("ID")))
        End While
        reader.Close()
        CloseConnection()
        Return TimeList
    End Function
    Public Function GetRoomList() As Dictionary(Of String, Integer)
        Dim RoomList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblRoom.RoomID, tblRoom.ID
FROM tblRoom;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            RoomList.Add(reader("RoomID"), Integer.Parse(reader("ID")))
        End While
        reader.Close()
        CloseConnection()
        Return RoomList
    End Function
    Public Function GetTeacherList() As Dictionary(Of String, Integer)
        Dim TeacherList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblTeacher.ID, tblTeacher.engName FROM tblTeacher;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            TeacherList.Add(reader("engName"), Integer.Parse(reader("ID")))
        End While
        reader.Close()
        CloseConnection()
        Return TeacherList
    End Function
    Public Function GetCourseList() As Dictionary(Of String, Integer)
        Dim CourseList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblCourses.CourseName, tblCourses.ID FROM tblCourses;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            CourseList.Add(reader("CourseName"), Integer.Parse(reader("ID")))
        End While
        reader.Close()
        CloseConnection()
        Return CourseList

    End Function
End Class
