Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader

Public Class Room
    Inherits ConnectionDB
    Public id As Integer
    Public room As String
    Public Function GetRoomList() As DataTable
        Dim query As String = "SELECT * FROM tblRoom;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
    Public Sub GetRoomByID(id As Integer)
        Dim query As String = "SELECT * FROM tblRoom WHERE ID = " & id & ";"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Me.id = reader(0)
            Me.room = reader(1)
        End If
    End Sub
End Class
