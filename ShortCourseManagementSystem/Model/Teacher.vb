Imports System.Data.OleDb
Public Class Teacher
    Inherits ConnectionDB
    Public Sub New()
        ' Constructor for Teacher class
        MyBase.New()
    End Sub
    Public TeacherID As String
    Public KhName As String
    Public EngName As String
    Public Gender As String
    Public DoB As Date
    Public Address As String
    Public Phone As String
    Public Email As String
    Public Picture As String

    Public Function GetTeacherData() As DataTable
        Dim query As String = "SELECT tblTeacher.ID, tblTeacher.KhName AS KhmerName, tblTeacher.engName AS EnglishName, tblTeacher.DOB AS DateOfBirth, tblTeacher.POB AS PlaceOfBirth, tblTeacher.Email, tblTeacher.Phone FROM tblTeacher;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function

    Public Sub AddTeacher()
        Dim query As String = "INSERT INTO tblTeacher(khName , engName ,Gender , DOB , POB , Email , Phone ,Picture ,IsActive) 
                                                     VALUES (@KhName, @EngName, @Gender, @DoB, @Address, @Email, @Phone, @Picture, 1)"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@KhName", Me.KhName)
        cmd.Parameters.AddWithValue("@EngName", Me.EngName)
        cmd.Parameters.AddWithValue("@Gender", Me.Gender)
        cmd.Parameters.AddWithValue("@DoB", Me.DoB)
        cmd.Parameters.AddWithValue("@Address", Me.Address)
        cmd.Parameters.AddWithValue("@Email", Me.Email)
        cmd.Parameters.AddWithValue("@Phone", Me.Phone)
        cmd.Parameters.AddWithValue("@Picter", Me.Picture)
        ExecuteNonQuery(cmd)
        MessageBox.Show("Teacher Name : " & KhName & " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub UpdateTeacher()
        Dim query As String = "UPDATE tblTeacher SET KhName = @KhName, engName = @engName, Gender = @Gender, DOB = @DOB, POB = @POB, Email = @Email, Phone = @Phone, Picture = @Picture WHERE ID = @ID"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@khName", KhName)
        cmd.Parameters.AddWithValue("@engName", EngName)
        cmd.Parameters.AddWithValue("@Gender", Gender)
        cmd.Parameters.AddWithValue("@DOB", DoB)
        cmd.Parameters.AddWithValue("@POB", Address)
        cmd.Parameters.AddWithValue("@Email", Email)
        cmd.Parameters.AddWithValue("@Phone", Phone)
        cmd.Parameters.AddWithValue("@Picture", Picture)
        cmd.Parameters.AddWithValue("@ID", TeacherID)
        ExecuteNonQuery(cmd)
        MessageBox.Show("Teacher with ID: " & TeacherID & " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub DeleteTeacher(teacherID As String)
        Dim query As String = "DELETE FROM tblTeacher WHERE ID = @ID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", teacherID)
        ExecuteNonQuery(cmd)
        MessageBox.Show("Teacher with ID: " & teacherID & " has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub GetTeacherByID(ID As String)
        Dim query As String = "SELECT * FROM tblTeacher WHERE ID = @ID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", ID)
        OpenConnection()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Me.TeacherID = reader("ID").ToString()
            Me.KhName = reader("KhName").ToString()
            Me.EngName = reader("EngName").ToString()
            Me.Address = reader("POB").ToString()
            Me.DoB = Convert.ToDateTime(reader("DOB"))
            Me.Gender = reader("Gender").ToString()
            Me.Phone = reader("Phone").ToString()
            Me.Email = reader("Email").ToString()
            If Not IsDBNull(reader("Picture")) Then
                Me.Picture = reader("Picture").ToString()
            Else
                Me.Picture = String.Empty
            End If
        End While
        reader.Close()
        CloseConnection()
    End Sub
    Public Sub GetTeacherByName(name As String)
        Dim query As String = "SELECT * FROM tblTeacher WHERE KhName = @khName;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@khName", name)
        OpenConnection()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Me.TeacherID = reader("ID").ToString()
            Me.KhName = reader("KhName").ToString()
            Me.EngName = reader("EngName").ToString()
            Me.Address = reader("POB").ToString()
            Me.DoB = Convert.ToDateTime(reader("DOB"))
            Me.Gender = reader("Gender").ToString()
            Me.Phone = reader("Phone").ToString()
            Me.Email = reader("Email").ToString()
            If Not IsDBNull(reader("Picture")) Then
                Me.Picture = reader("Picture").ToString()
            Else
                Me.Picture = String.Empty
            End If
        End While
        reader.Close()
        CloseConnection()
    End Sub
    Public Function GetAddressData() As ArrayList
        Dim addressList As New ArrayList()
        Dim query As String = "SELECT * FROM tblProvince;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        OpenConnection()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            addressList.Add(reader(0).ToString)
        End While
        reader.Close()
        CloseConnection()
        Return addressList
    End Function
End Class
