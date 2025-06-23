Imports System.Data.OleDb
Public Class RoomForm
    Dim conn As New ConnectionDB()
    Dim room As New Room
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
        If txtRoom.Text.Trim() = "" Then
            MsgBox("សូមបញ្ចូលឈ្មោះបន្ទប់")
            Return
        End If
        Dim query As String = "SELECT COUNT(*) FROM tblRoom WHERE Room = @room;"
        Dim cmd As New OleDbCommand(query, room.GetConnection())
        cmd.Parameters.AddWithValue("@room", txtRoom.Text.Trim())
        Dim count As Integer = Convert.ToInt16(room.ExecuteScalar(cmd))
        If count > 0 Then
            MessageBox.Show("បន្ទប់សិកស្សានេះមានរួចហើយ", "បន្ទប់មានរួចហើយ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        query = "INSERT INTO tblRoom (Room) VALUES (@RoomName);"
        cmd = New OleDbCommand(query, conn.GetConnection())
        cmd.Parameters.AddWithValue("@RoomName", txtRoom.Text.Trim())
        conn.ExecuteNonQuery(cmd)
        txtRoom.Text = ""
        MessageBox.Show("បន្ទប់សិក្សា " & txtRoom.Text & " នេះត្រូវបានបង្កើតដោយជោគជ័យ", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Display()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុបបន្ទប់នេះមែនទេ?", "បញ្ជាក់", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Dim query As String = "DELETE FROM tblRoom WHERE ID = @ID;"
            Dim cmd As OleDbCommand = New OleDbCommand(query, conn.GetConnection())
            cmd.Parameters.AddWithValue("@ID", room.id)
            conn.ExecuteNonQuery(cmd)
            Display()
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        room.GetRoomByID(Convert.ToInt16(DataGridView2.CurrentRow.Cells(0).Value))
        txtRoom.Text = room.room
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRoom.Clear()
    End Sub
End Class