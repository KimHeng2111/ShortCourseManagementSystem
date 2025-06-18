Imports System.Data.OleDb
Public Class Subject
    Inherits ConnectionDB
    Public Sub New()
        ' Constructor for Course class
        MyBase.New()
    End Sub
    Public ID As String
    Public Subject As String
    Public Description As String
    Public CreditHours As Integer
    Public basePrice As Decimal

    Public Function GetSubjectData() As DataTable

        Dim query As String = "SELECT 
        tblSubject.ID, 
        tblSubject.Subject, 
        tblSubject.Description, 
        tblSubject.CreditHours, 
        tblSubject.BasePrice, 
        (SELECT COUNT(*) FROM tblCourse WHERE  tblCourse.SubjectID = tblSubject.ID) AS AllCourse, 
        (SELECT COUNT(*) FROM tblCourse WHERE StatusID = 3 AND tblCourse.SubjectID = tblSubject.ID) AS CompleteClass
        FROM tblSubject
        GROUP BY 
        tblSubject.ID, 
        tblSubject.Subject, 
        tblSubject.Description, 
        tblSubject.CreditHours, 
        tblSubject.BasePrice;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
    Public Sub GetCourseByID(courseID As String)
        Dim query As String = "SELECT * FROM tblSubject WHERE ID = @ID"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", courseID)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Me.ID = reader("ID").ToString()
            Me.Subject = reader("Subject").ToString()
            Me.Description = reader("Description").ToString()
            Me.CreditHours = Convert.ToInt32(reader("CreditHours"))
            Me.basePrice = Convert.ToDecimal(reader("BasePrice"))
        End While
        reader.Close()
        CloseConnection()
    End Sub
    Public Sub GetCourseByName(subject As String)
        Dim query As String = "SELECT * FROM tblSubject WHERE Subject = @subject"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@subject", Me.Subject)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Me.ID = reader("ID").ToString()
            Me.Subject = reader("Subject").ToString()
            Me.Description = reader("Description").ToString()
            Me.CreditHours = Convert.ToInt32(reader("CreditHours"))
            Me.basePrice = Convert.ToDecimal(reader("BasePrice"))
        End While
        reader.Close()
        CloseConnection()
    End Sub
    Public Sub AddCourse(subject As String, description As String, creditHours As Integer, basePrice As Decimal)
        Dim query As String = "INSERT INTO tblSubject (Subject, Description, CreditHours, BasePrice) VALUES (@subject, @Description, @CreditHours, @BasePrice)"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@subject", subject)
        cmd.Parameters.AddWithValue("@Description", description)
        cmd.Parameters.AddWithValue("@CreditHours", creditHours)
        cmd.Parameters.AddWithValue("@BasePrice", basePrice)
        ExecuteNonQuery(cmd)
    End Sub
    Public Sub DeleteCourse()
        Dim query As String = "DELETE FROM tblSubject WHERE ID = @ID"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", Me.ID)
        ExecuteNonQuery(cmd)
    End Sub
    Public Sub UpdateCourse()
        Dim query As String = "UPDATE tblSubject SET Subject = @subject, Description = @Description, CreditHours = @CreditHours, BasePrice = @BasePrice WHERE ID = @ID"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@subject", Me.Subject)
        cmd.Parameters.AddWithValue("@Description", Me.Description)
        cmd.Parameters.AddWithValue("@CreditHours", Me.CreditHours)
        cmd.Parameters.AddWithValue("@BasePrice", Me.basePrice)
        cmd.Parameters.AddWithValue("@ID", Me.ID)
        ExecuteNonQuery(cmd)
    End Sub
End Class
