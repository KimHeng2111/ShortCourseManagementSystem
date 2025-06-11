Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Student
    Inherits ConnectionDB
    Public id As String
    Public khName As String
    Public engName As String
    Public DateOfBirth As Date
    Public gender As String
    Public phone As String
    Public address As String
    Public picture As String
    Public Sub New()
        ' Constructor for Student class
        MyBase.New()
    End Sub
    Public Function GetStudentData() As DataTable
        Dim query As String = "SELECT tblStudent.ID, tblStudent.KhName, tblStudent.EngName, tblStudent.Gender, tblStudent.DateOfBirth, tblStudent.Address , tblStudent.Phone FROM tblStudent;"
        Dim dt As DataTable = ExecuteQuery(query)
        Return dt
    End Function
    Public Sub AddStudent(khName As String, EngName As String, Gender As String, DOB As Date, Address As String, Phone As String, Email As String, Picture As String)
        Dim query As String = "INSERT INTO tblStudent(KhName , EngName ,Gender , DateOfBirth , Address , Phone ,Picture ) 
                                                     VALUES (@KhName, @EngName, @Gender, @DateOfBirth, @Address,  @Phone, @Picture)"
        OpenConnection()
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@KhName", khName)
        cmd.Parameters.AddWithValue("@EngName", EngName)
        cmd.Parameters.AddWithValue("@Gender", Gender)
        cmd.Parameters.AddWithValue("@DateOfBirth", DOB)
        cmd.Parameters.AddWithValue("@Address", Address)
        cmd.Parameters.AddWithValue("@Phone", Phone)
        cmd.Parameters.AddWithValue("@Picter", Picture)
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT @@IDENTITY;"
        Dim id As String = cmd.ExecuteScalar().ToString()
        GetStudentByID(Convert.ToInt32(id))
    End Sub
    Public Sub UpdateStudent(studentID As Integer, khName As String, EngName As String, Gender As String, DOB As Date, Address As String, Phone As String, Picture As String)
        Dim query As String = "UPDATE tblStudent 
                           SET KhName = @KhName, EngName = @EngName, Gender = @Gender, DateOfBirth = @DateOfBirth, 
                               Address = @Address, Phone = @Phone, Picture = @Picture 
                           WHERE ID = @StudentID"

        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@KhName", khName)
        cmd.Parameters.AddWithValue("@EngName", EngName)
        cmd.Parameters.AddWithValue("@Gender", Gender)
        cmd.Parameters.AddWithValue("@DateOfBirth", DOB)
        cmd.Parameters.AddWithValue("@Address", Address)
        cmd.Parameters.AddWithValue("@Phone", Phone)
        cmd.Parameters.AddWithValue("@Picture", Picture)
        cmd.Parameters.AddWithValue("@StudentID", studentID) ' Ensure you reference the correct ID field
        ExecuteNonQuery(cmd)
    End Sub
    Public Sub DeleteStudent()
        Dim query As String = "DELETE FROM tblStudent WHERE ID = @ID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@ID", Me.id)
        ExecuteNonQuery(cmd)
        MessageBox.Show("Student with ID: " & Me.id & " has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub GetStudentByID(studentID As Integer)
        Dim query As String = "SELECT * FROM tblStudent WHERE ID = @StudentID"
        Dim cmd As OleDbCommand = New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@StudentID", studentID)
        OpenConnection()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        While reader.Read()
            Me.id = reader("ID").ToString()
            Me.khName = reader("KhName").ToString()
            Me.engName = reader("EngName").ToString()
            Me.DateOfBirth = reader("DateOfBirth").ToString()
            Me.gender = reader("Gender").ToString()
            Me.phone = reader("Phone").ToString()
            Me.address = reader("Address").ToString()
            Me.picture = reader("Picture").ToString()
        End While
    End Sub


End Class
