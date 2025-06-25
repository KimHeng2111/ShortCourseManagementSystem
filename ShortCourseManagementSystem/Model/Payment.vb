Imports System.Data.OleDb

Public Class Payment
    Inherits ConnectionDB
    Public paymentID As String
    Public registerID As String
    Public amount As Decimal
    Public unpaid As Decimal
    Public statusID As String

    'Method 
    Public Sub NewPayment(registerID As String, amount As Decimal, unpaid As Decimal)
        Dim statusID As String = If(unpaid > 0, "1", "2")
        Dim query As String = "INSERT INTO tblPayment(RegisterID, Amount, Unpaid ,StatusID) VALUES(@registerID, @amount, @unpaid ,@statusID);"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@registerID", registerID)
        cmd.Parameters.AddWithValue("@amount", amount)
        cmd.Parameters.AddWithValue("@unpaid", unpaid)
        cmd.Parameters.AddWithValue("@statusID", statusID)
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SELECT @@IDENTITY;"
        Dim id As String = cmd.ExecuteScalar().ToString()
        paymentID = id
        Me.amount = amount
        Me.unpaid = unpaid
        Me.registerID = registerID
        Me.statusID = statusID
        cmd.Dispose()
        CloseConnection()
    End Sub
    Public Sub GetPaymentByID(registerID As String)
        Dim query As String = "SELECT * FROM tblPayment WHERE RegisterID = @id;"
        OpenConnection()
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@id", registerID)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            paymentID = reader("ID")
            registerID = reader("RegisterID")
            amount = Convert.ToDecimal(reader("Amount"))
            unpaid = Convert.ToDecimal(reader("Unpaid"))
            statusID = reader("StatusID")
        End If
        reader.Close()
        cmd.Dispose()
        CloseConnection()
    End Sub
    Public Sub UpdatePayment(registerID As String)
        Dim query As String = "UPDATE tblePayment SET Unpaid = @unpaid WHERE RegisterID = @id;"
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@id", registerID)
        ExecuteNonQuery(cmd)
        UpdateStatus(registerID)
    End Sub
    Private Sub UpdateStatus(registerID As String)
        Dim query As String = "UPDATE tblPayment SET StatusID = IIf(Unpaid > 0, 2, 1) WHERE REgisterID = @id;"
        Dim cmd As New OleDbCommand(query, GetConnection())
        cmd.Parameters.AddWithValue("@id", registerID)
        ExecuteNonQuery(cmd)
    End Sub
End Class
