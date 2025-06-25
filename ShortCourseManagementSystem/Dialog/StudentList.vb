Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Public Class StudentList
    Public student As New Student()

    Dim startup As Boolean = True
    Public Sub GetData() Handles txtSearch.TextChanged
        Dim query As String = "SELECT tblStudent.ID, tblStudent.KhName,tblStudent.Gender, 
                                tblStudent.DateOfBirth,tblStudent.Phone FROM tblStudent
                                WHERE   (ID Like @id OR KhName Like @name);"
        Dim cmd As New OleDbCommand(query, student.GetConnection())
        Dim name As String = txtSearch.Text.Trim()
        Dim id As String = If(name = "", "0", If(IsNumeric(name), name, "0")) & "%"
        name = If(name = "", "%", "%" & name & "%")
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        DataGridView1.DataSource = student.ExecuteQuery(cmd)
        If Not startup Then
            Regonize()
        End If
    End Sub
    Sub Regonize()
        DataGridView1.Columns(0).HeaderText = "លេខកូដ"
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderText = "គោត្តនាម នាម"
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(2).HeaderText = "ភេទ"
        DataGridView1.Columns(2).Width = 80
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderText = "លេខទូរស័ព្ទ"
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        For i = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim id As Int16 = Convert.ToInt16(DataGridView1.SelectedRows(0).Cells(0).Value)
        student.GetStudentByID(id)
        Me.DialogResult = 1
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtSearch.Clear()
    End Sub

    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        startup = False
        Regonize()
    End Sub
End Class