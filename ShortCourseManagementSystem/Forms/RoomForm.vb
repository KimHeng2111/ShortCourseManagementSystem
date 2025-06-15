Imports System.Data.OleDb
Public Class RoomForm
    Dim conn As New ConnectionDB()
    Dim id As Integer = 0
    Sub Display()
        Dim query As String = "SELECT tblRoom.* FROM tblRoom;"
        Dim dt As DataTable = conn.ExecuteQuery(query)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 100 ' ID column width)
        DataGridView2.Columns(1).HeaderText = "ឈ្មោះបន្ទប់"
        DataGridView2.ClearSelection()
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            If i Mod 2 = 1 Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
            Else
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
            End If

        Next i
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Display()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtRoom.Texts.Trim() = "" Then
            MsgBox("សូមបញ្ចូលឈ្មោះបន្ទប់")
            Return
        End If
        Dim query As String = "INSERT INTO tblRoom (Room) VALUES (@RoomName);"
        Dim cmd As OleDbCommand = New OleDbCommand(query, conn.GetConnection())
        cmd.Parameters.AddWithValue("@RoomName", txtRoom.Texts.Trim())
        conn.ExecuteNonQuery(cmd)
        txtRoom.Texts = ""
        Display()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុបបន្ទប់នេះមែនទេ?", "បញ្ជាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Dim query As String = "DELETE FROM tblRoom WHERE ID = @ID;"
            Dim cmd As OleDbCommand = New OleDbCommand(query, conn.GetConnection())
            cmd.Parameters.AddWithValue("@ID", id)
            conn.ExecuteNonQuery(cmd)
            Display()
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        id = Convert.ToInt32(DataGridView2.CurrentRow.Cells(0).Value)
        txtRoom.Texts = DataGridView2.CurrentRow.Cells(1).Value.ToString()
    End Sub
End Class