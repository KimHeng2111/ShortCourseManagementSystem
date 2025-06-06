Imports System.Data.OleDb

Public Class Schedule
    Dim conn As New ConnectionDB()
    Dim WeekdayTime() As String = {"7:00-8:00 AM", "8:00-9:00 AM", "9:00-10:00 AM", "10:00-11:00 AM", "1:00-2:00 PM", "2:00-3:00 PM", "3:00-4:00 PM", "4:00-5:00 PM", "5:00-6:00 PM"}
    Dim WeekendTime() As String = {"7:30-11:00 AM", "1:30-5:00 AM"}
    Dim id As Integer = 0
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDay.SelectedIndexChanged
        If cbDay.SelectedIndex = 0 Then
            cbTime.DataSource = WeekdayTime
        ElseIf cbDay.SelectedIndex = 1 Then
            cbTime.DataSource = WeekendTime
        Else
            cbTime.DataSource = Nothing
        End If
    End Sub

    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbDay.SelectedIndex = cbDay.Items.Count - 1
        Display()
    End Sub
    Sub Display()

        Dim query As String = "SELECT * FROM tblSchedule"
        Dim dt As DataTable = conn.ExecuteQuery(query)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Dim schedule() As String = DataGridView2.CurrentRow.Cells(1).Value.ToString().Split(" ")
        If schedule(0) = cbDay.Items(0) Then
            cbDay.SelectedIndex = 0 ' Weekday
        Else
            cbDay.SelectedIndex = 1 ' Weekend
        End If

        Dim time As String = schedule(1) + " " + schedule(2)
        MsgBox(time)
        cbTime.SelectedIndex = cbTime.FindStringExact(time)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cbDay.SelectedIndex = -1 Or cbTime.SelectedIndex = -1 Then
            MsgBox("Please select a day and time.")
            Return
        End If
        If IsDuplicate(cbDay.SelectedItem.ToString() + " " + cbTime.SelectedItem.ToString()) Then
            MsgBox("This schedule already exists.")
            Return
        End If
        Dim query As String = "INSERT INTO tblSchedule (Schedule) VALUES (@Schedule);"
        Dim schedule As String = cbDay.SelectedItem.ToString() + " " + cbTime.SelectedItem.ToString()
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn.GetConnection())
        cmd.Parameters.AddWithValue("@Schedule", schedule)
        conn.ExecuteNonQuery(cmd)
        Display()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("Please select a row to delete.")
            Return
        End If
        Dim id As Integer = Convert.ToInt32(DataGridView2.CurrentRow.Cells(0).Value)
        Dim query As String = "DELETE FROM tblSchedule WHERE ID = @ID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn.GetConnection())
        cmd.Parameters.AddWithValue("@ID", id)
        conn.ExecuteNonQuery(cmd)
        Display()
        id = 0 ' Reset id after deletion
    End Sub
    Function IsDuplicate(value As String)
        Dim query As String = "SELECT COUNT(*) FROM tblSchedule WHERE Schedule = @Schedule;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn.GetConnection())
        cmd.Parameters.AddWithValue("@Schedule", value)
        conn.OpenConnection()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        conn.CloseConnection()
        Return count > 0
    End Function
End Class