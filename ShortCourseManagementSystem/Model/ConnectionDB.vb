Imports System.Data.OleDb
Public MustInherit Class ConnectionDB
    Private ReadOnly connString As String
    Private Shared conn As OleDbConnection
    Public Sub New()
        connString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Data\StudentManagementSystem.accdb;Persist Security Info=False;"
    End Sub
    Function GetConnection() As OleDbConnection
        If conn Is Nothing Then
            conn = New OleDbConnection(connString)
        End If
        Return conn
    End Function
End Class