Imports System.Data.OleDb
Imports Org.BouncyCastle.Bcpg

Public Class Schedule
    Dim conn As New ConnectionDB()
    Dim id As Integer = 0


    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbDay.SelectedIndex = cbDay.Items.Count - 1
        Display()
    End Sub
    Sub Display()

        Dim query As String = "SELECT * FROM tblSchedule"
        Dim dt As DataTable = conn.ExecuteQuery(query)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 100 ' ID column width
        DataGridView2.ClearSelection()
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            If i Mod 2 = 1 Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
            Else
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
            End If
        Next i

    End Sub

    'Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
    '    Dim schedule() As String = DataGridView2.CurrentRow.Cells(1).Value.ToString().Split(" ")
    '    If schedule(0) = cbDay.Items(0) Then
    '        cbDay.SelectedIndex = 0 ' Weekday
    '    Else
    '        cbDay.SelectedIndex = 1 ' Weekend
    '    End If

    '    Dim time As String = schedule(1) + " " + schedule(2)
    '    MsgBox(time)
    '    cbTime.SelectedIndex = cbTime.FindStringExact(time)
    'End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cbDay.SelectedIndex = -1 Then
            MsgBox("Please select a dayu.")
            Return
        End If
        Dim schedule As String = cbDay.SelectedItem.ToString() + " " + tpStart.Value.ToString("hh:mm tt").Split(" "c)(0) + "-" + tpEnd.Value.ToString("hh:mm tt")
        If IsDuplicate(schedule) Then
            MsgBox("This schedule already exists.")
            Return
        End If
        Dim query As String = "INSERT INTO tblSchedule (Schedule) VALUES (@Schedule);"
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

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim schedule() As String = DataGridView2.CurrentRow.Cells(1).Value.ToString().Split(" ")
        cbDay.SelectedIndex = If(schedule(0) = cbDay.Items(0).ToString(), 0, 1) ' Weekday or Weekend
        Dim time() As String = schedule(1).Split("-")
        Dim parsedTime As DateTime = DateTime.Parse(time(0) & " " & schedule(2))
        tpStart.Value = DateTime.Today.AddHours(parsedTime.Hour)
        parsedTime = DateTime.Parse(time(1) & " " & schedule(2))
        tpEnd.Value = DateTime.Today.AddHours(parsedTime.Hour)

    End Sub
End Class