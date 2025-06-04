Imports System.Data.OleDb

Public Class Payment
    Inherits ConnectionDB
    Public paymentID As String
    Public amount As Decimal
    Public unpaid As Decimal
    Public statusID As String

    'Method 
    Public Sub NewPayment(amount As Decimal, unpaid As Decimal)
        Dim statusID As String = If(unpaid > 0, "1", "2")
        Dim query As String = "INSERT INTO tblPayment(Amount, Unpaid ,StatusID) VALUES(@amount, @unpaid ,@statusID);"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@amount", amount)
        cmd.Parameters.AddWithValue("@unpaid", unpaid)
        cmd.Parameters.AddWithValue("@statusID", statusID)
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT @@IDENTITY;"
        Dim id As String = cmd.ExecuteScalar().ToString()
        paymentID = id
        Me.amount = amount
        Me.unpaid = unpaid
        Me.statusID = statusID
        cmd.Dispose()
        CloseConnection()
    End Sub
    Public Sub GetPaymentByID(id As String)
        Dim query As String = "SELECT * FROM tblPayment WHERE ID = @id;"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@id", id)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            paymentID = reader("ID")
            amount = Convert.ToDecimal(reader("Amount"))
            unpaid = Convert.ToDecimal(reader("Unpaid"))
            statusID = reader("StatusID")
        End If
        reader.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub
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
