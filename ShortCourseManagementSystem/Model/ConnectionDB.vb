Imports System.Data.OleDb
Public Class ConnectionDB
    Private connstring As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Data\StudentManagementSystem.accdb;Persist Security Info=False;"
    Private conn As OleDbConnection
    Public Sub New()
        conn = New OleDbConnection(connstring)
    End Sub
    Public Function GetConnection() As OleDbConnection
        If conn Is Nothing Then
            conn = New OleDbConnection(connstring)
        End If
        Return conn
    End Function
    Public Sub OpenConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Public Function ExecuteQuery(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Dim cmd As New OleDbCommand(query, conn)
            Dim adapter As New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Error executing query: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function
    Public Function ExecuteQuery(cmd As OleDbCommand) As DataTable
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Dim adapter As New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Error executing query: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function
    Public Sub ExecuteNonQuery(query As String)
        Try
            OpenConnection()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            Throw New Exception("Error executing non-query: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Function ExecuteScalar(query As String) As Object
        Dim result As Object = Nothing
        Try
            OpenConnection()
            Dim cmd As New OleDbCommand(query, conn)
            result = cmd.ExecuteScalar()
            cmd.Dispose()
        Catch ex As Exception
            Throw New Exception("Error executing scalar: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return result
    End Function
    Public Sub ExecuteNonQuery(cmd As OleDbCommand)
        Try
            OpenConnection()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox("Error executing non-query: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class
