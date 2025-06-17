Imports System.Data.OleDb

Public Class Report
    Inherits ConnectionDB
    Public Function GetTeacherReport() As DataTable
        Dim query As String = "SELECT tblTeacher.ID, tblTeacher.KhName, tblTeacher.engName, tblTeacher.Address, tblTeacher.Phone, tblTeacher.Email, tblTeacher.StartDate, tblTeacher.IsActive FROM tblTeacher;"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("KhName", GetType(String))
        dt.Columns.Add("engName", GetType(String))
        dt.Columns.Add("Address", GetType(String))
        dt.Columns.Add("Phone", GetType(String))
        dt.Columns.Add("Email", GetType(String))
        dt.Columns.Add("StartDate", GetType(String)) ' Change to String for formatting
        dt.Columns.Add("IsActive", GetType(String))
        While reader.Read()
            Dim formattedDate As String = Convert.ToDateTime(reader("StartDate")).ToString("dd/MM/yyyy") ' Example format
            Dim formattedActive As String = If(reader("IsActive").ToString().ToLower() = "true", "សកម្ម", "អសកម្ម")
            MsgBox(reader("IsActive").ToString())
            MsgBox(formattedActive)
            dt.Rows.Add(reader("ID"), reader("KhName"), reader("engName"), reader("Address"),
                    reader("Phone"), reader("Email"), formattedDate, formattedActive)
        End While


        Return dt
    End Function
End Class
