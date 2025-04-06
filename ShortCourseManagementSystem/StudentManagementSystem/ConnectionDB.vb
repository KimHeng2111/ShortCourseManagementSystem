Imports System.Data.OleDb

Public Class ConnectionDB
    Public Shared connString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\lengk\OneDrive\Desktop\ShortCourseManagementSystem\ShortCourseManagementSystem\StudentManagementSystem\StudentManagementSystem.accdb;Persist Security Info=False;"
    Private Shared conn As OleDbConnection
    Public Sub RegisterQuery(KhName As String, EngName As String, DateOfBirth As String, Gender As String, Phone As String, Address As String)
        Dim query As String = "INSERT INTO Users (KhName, EngName, DateOfBirth, Gender, Phone, Address)
                               VALUES (@KhName, @EngName, @DateOfBirth, @Gender, @Phone, @Address);"
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Try
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@KhName", KhName)
                cmd.Parameters.AddWithValue("@EngName", EngName)
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth)
                cmd.Parameters.AddWithValue("@Gender", Gender)
                cmd.Parameters.AddWithValue("@Phone", Phone)
                cmd.Parameters.AddWithValue("@Address", Address)
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try

        End Using
    End Sub
    Public Shared Function GetConnection() As OleDbConnection
        If conn Is Nothing Then
            conn = New OleDbConnection(connString)
        End If
        Return conn
    End Function
    Public Shared Sub CloseConnection()
        If conn IsNot Nothing Then
            conn.Close()
        End If
    End Sub
End Class
