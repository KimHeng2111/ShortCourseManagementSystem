Imports System.Data.OleDb

Public Class Payment
    Inherits ConnectionDB
    Public paymentID As String
    Public unpaid As Decimal
    Public statusID As String

    'Method 
    Public Sub NewPayment(unpaid As Decimal)
        Dim query As String = "INSERT INTO tblPayment(Unpaid) VALUES(" & unpaid & ");"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT @@IDENTITY;"
        Dim id As String = cmd.ExecuteScalar().ToString()
        GetPaymentByID(id)
    End Sub
    Public Function GetPaymentByID(id As String)
        Dim query As String = "SELECT * FORM tblPayment WHERE ID = @id;"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            paymentID = reader("ID")
            unpaid = Convert.ToDecimal(reader("Unpaid"))
            statusID = reader("StatusID")
        End If
        reader.Close()
        cmd.Dispose()
        CloseConnection()
    End Function
    Public Sub UpdatePayment(id As String)
        Dim query As String = "UPDATE tblePayment SET Unpaid = @unpaid WHERE ID = @id;"
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@id", id)
        ExecuteNonQuery(cmd)
    End Sub
    Private Sub UpdateStatus(id As String)
        Dim query As String = "UPDATE tblPayment SET StatusID = IIf(Unpaid > 0, 2, 1) WHERE ID = @id;"
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@id", id)
        ExecuteNonQuery(cmd)
    End Sub
End Class
