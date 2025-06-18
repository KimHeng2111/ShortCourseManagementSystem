Imports System.Data.OleDb
Imports System.Windows.Media.Animation
Public Class Course
    Inherits ConnectionDB
    Public ID As String
    Public subject As Subject
    Public teacher As Teacher
    Public startDate As Date
    Public endDate As Date
    Public room As Room
    Public scheduleID As Integer
    Public StatusID As Integer
    Public Sub New()
        ' Constructor for ManageClass class
        MyBase.New()
        subject = New Subject()
        teacher = New Teacher()
        room = New Room()
    End Sub
    Public Function GetCourseData() As DataTable
        Dim query As String = "SELECT tblCourse.ID, tblSubject.Subject, tblTeacher.KhName, tblRoom.Room, 
                                tblSchedule.Schedule, tblCourse.CurrentEnrollment, tblCourseStatus.Status
                                FROM tblSchedule INNER JOIN (tblRoom INNER JOIN (tblTeacher 
                                INNER JOIN (tblSubject INNER JOIN (tblCourseStatus INNER JOIN tblCourse
                                ON (tblCourseStatus.ID = tblCourse.StatusID) AND (tblCourseStatus.ID = tblCourse.StatusID)) 
                                ON tblSubject.ID = tblCourse.SubjectID) ON tblTeacher.ID = tblCourse.TeacherID) 
                                ON tblRoom.ID = tblCourse.RoomID) ON tblSchedule.ID = tblCourse.ScheduleID;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
    Public Sub GetCourseByID(id As String)
        Dim query As String = "SELECT * FROM tblCourse WHERE ID = @ID;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", id)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Me.ID = reader("ID").ToString()
            subject.GetCourseByID(reader("ID").ToString())
            teacher.GetTeacherByID(reader("TeacherID").ToString())
            startDate = Convert.ToDateTime(reader("StartDate"))
            room.GetRoomByID(Convert.ToInt16(reader("RoomID")))
            scheduleID = Convert.ToInt32(reader("ScheduleID"))
            endDate = If(IsDBNull(reader("EndDate")), Date.Now(), Convert.ToDateTime(reader("EndDate")))
            StatusID = Convert.ToInt32(reader("StatusID"))
        End If
        reader.Close()
        CloseConnection()
    End Sub
    Public Sub AddCourse()
        Dim query As String = "INSERT INTO tblCourse ( ID, ID, TeacherID, StartDate, RoomID, ScheduleID ) 
                                VALUES (@ID, @ID, @TeacherID, @StartDate, @RoomID, @ScheduleID) "
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", ID)
        cmd.Parameters.AddWithValue("@ID", subject.ID)
        cmd.Parameters.AddWithValue("@TeacherID", teacher.TeacherID)
        cmd.Parameters.AddWithValue("@StartDate", startDate)
        cmd.Parameters.AddWithValue("@RoomID", room.id)
        cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
        ExecuteNonQuery(cmd)
    End Sub
    Public Sub UpdateCourse(courseID As String, subjectID As String, teacherID As String, startDate As String, roomID As Integer, scheduleID As Integer)
        Dim query As String = "UPDATE tblCourse
                            SET ID = @subjectID, TeacherID = @TeacherID, StartDate = @StartDate, Room = @RoomID, ScheduleID = @ScheduleID 
                            WHERE ID = @ID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@subjectID", subjectID)
        cmd.Parameters.AddWithValue("@TeacherID", teacherID)
        cmd.Parameters.AddWithValue("@StartDate", startDate)
        cmd.Parameters.AddWithValue("@RoomID", roomID)
        cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
        cmd.Parameters.AddWithValue("@ID", courseID)
        ExecuteNonQuery(cmd)
    End Sub

    Public Sub DeleteCourse()
        Dim query As String = "DELETE FROM tblCourse WHERE ID = @ID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", ID)
        ExecuteNonQuery(cmd)
    End Sub

    Public Function GetCurrentEnrollments() As Integer
        Dim query As String = "SELECT CurrentEnrollment FROM tblCourse;"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count
    End Function

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
        Dim query As String = "SELECT tblRoom.Room, tblRoom.ID
FROM tblRoom;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            RoomList.Add(reader("Room"), Integer.Parse(reader("ID")))
        End While
        reader.Close()
        CloseConnection()
        Return RoomList
    End Function
    Public Function GetClassStatusList() As Dictionary(Of String, Integer)
        Dim StatusList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT * FROM  tblCourseStatus;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            StatusList.Add(reader("Status"), Integer.Parse(reader("ID")))
        End While
        reader.Close()
        CloseConnection()
        Return StatusList
    End Function
    Public Function GetTeacherList() As Dictionary(Of String, String)
        Dim TeacherList As New Dictionary(Of String, String)
        Dim query As String = "SELECT tblTeacher.ID, tblTeacher.KhName FROM tblTeacher;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            TeacherList.Add(reader("KhName"), reader("ID"))
        End While
        reader.Close()
        CloseConnection()
        Return TeacherList
    End Function
    Public Function GetCourseList() As Dictionary(Of String, Integer)
        Dim CourseList As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT tblSubject.Subject, tblSubject.ID FROM tblSubject;"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            CourseList.Add(reader("Subject"), Integer.Parse(reader("ID")))
        End While
        reader.Close()
        CloseConnection()
        Return CourseList
    End Function
    Function GetScheduleByID() As String
        Dim query As String = "SELECT Schedule FROM tblSchedule WHERE ID = @ScheduleID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
        OpenConnection()
        Dim scheduleName As String = String.Empty
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            scheduleName = reader("Schedule").ToString()
        End If
        reader.Close()
        CloseConnection()
        Return scheduleName
    End Function
    Function GetStatusByID() As String
        Dim query As String = "SELECT Status FROM tblClassStatus WHERE ID = @StatusID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@StatusID", StatusID)
        OpenConnection()
        Dim statusName As String = String.Empty
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            statusName = reader("Status").ToString()
        End If
        reader.Close()
        CloseConnection()
        Return statusName
    End Function
End Class
