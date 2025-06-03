Imports System.Data.OleDb
Imports System.Windows.Media.Animation
Public Class ManageClass
    Inherits ConnectionDB
    Public ClassID As String
    Public Course As Course
    Public teacherName As String
    Public startDate As Date


    Public Function GetClassData() As DataTable
        Dim query As String = "SELECT tblClass.ClassID, tblCourses.CourseName AS Course, tblTeacher.KhName AS Teacher, tblRoom.RoomID AS Room, tblClass.SecheduleID AS Schedule, tblClass.StartDate, (SELECT COUNT(*) FROM tblRegister WHERE tblRegister.ClassID = tblClass.ClassID) AS TotalStudents
            FROM tblRoom INNER JOIN (tblTeacher INNER JOIN (tblCourses INNER JOIN (tblClassStatus INNER JOIN tblClass ON tblClassStatus.ID = tblClass.StatusID) ON tblCourses.ID = tblClass.CourseID) ON tblTeacher.ID = tblClass.TeacherID) ON tblRoom.ID = tblClass.RoomID
            GROUP BY tblClass.ClassID, tblCourses.CourseName, tblTeacher.KhName, tblRoom.RoomID, tblClass.SecheduleID, tblClass.StartDate;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
    Public Sub AddClass()
        Dim query As String = "INSERT INTO tblClass"
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
