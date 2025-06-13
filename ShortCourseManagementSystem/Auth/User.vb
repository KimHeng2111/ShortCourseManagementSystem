Imports System.Data.OleDb
Public Class User
    Public Shared userID As String
    Public Shared userName As String
    Public Shared password As String
    Public Shared role As String
    Public Shared conn As OleDbConnection
    Public Shared connString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Data\StudentManagementSystem.accdb;Persist Security Info=False;"
    Public Shared Function CheckLogin(username As String, password As String) As Boolean
        conn = New OleDbConnection(connString)
        conn.Open()
        Dim query As String = "SELECT * FROM tblUser WHERE UserName = @UserName;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserName", username)
        cmd.Parameters.AddWithValue("@Password", password)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            userID = reader("ID").ToString()
            username = reader("UserName").ToString()
            role = reader("Role").ToString()
            If reader("Password") = password Then
                Return True
            Else
                Return False
            End If
            reader.Close()
            conn.Close()

        Else
            reader.Close()
            conn.Close()
            Return False
        End If
    End Function
End Class
