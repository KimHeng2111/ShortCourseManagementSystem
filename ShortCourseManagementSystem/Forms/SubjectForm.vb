Imports System.Windows
Imports System.Windows.Controls

Public Class SubjectForm
    Dim subject As New Subject()
    Dim startup As Boolean = True
    Sub Display()
        DataGridView1.DataSource = subject.GetSubjectData()
        Regonize()
    End Sub

    Function CheckField() As Boolean
        Dim subject As String = txtSubject.Text.Trim()
        Dim description As String = txtDes.Text.Trim()
        Dim creditHours As String = txtCreditHours.Text.Trim()
        Dim basePrice As String = txtBasePrice.Text.Trim()
        If String.IsNullOrEmpty(subject) Then
            MessageBox.Show("សូមបញ្ចូលមុខវិជ្ជាអោយបានត្រឹមត្រូវ!!!!", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(description) Then
            MessageBox.Show("សូមបញ្ចូលការពិពណ៌នាអំពីមុខវិជ្ជា!!!!", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(creditHours) OrElse Not IsNumeric(creditHours) Then
            MessageBox.Show("សូមបញ្ចូលរយៈពេលសិក្សា!!!!", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(basePrice) OrElse Not IsNumeric(basePrice) Then
            MessageBox.Show("សូមបញ្ចូលតម្លៃនៃមុខវិជ្ជានេះ!!!!", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btmCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If Not CheckField() Then
            Return
        Else
            'Check Duplicate Subject
            Dim dt As DataTable = Me.subject.GetSubjectData()
            For Each row As DataRow In dt.Rows
                If txtSubject.Text.Trim() = row(1).ToString() Then
                    MsgBox("មុខវិជ្ជានេះគឺមានរូចហើយ")
                    Return
                End If
            Next
            subject.AddSubject(txtSubject.Text.Trim(), txtDes.Text.Trim(), Convert.ToInt32(txtCreditHours.Text.Trim()), Convert.ToDecimal(txtBasePrice.Text.Trim()))
            MessageBox.Show("វគ្គសិក្សា ៖ " & txtSubject.Text & "ត្រូវបានបង្កើតបានដោយជោគជ័យ!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Display()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Display()
        startup = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel1.Visible = True
        btnCreate.Visible = True
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim menu As New ContextMenuStrip()
        menu.Font = New Font("Khmer OS System", 11)
        menu.Items.Add("លម្អិត", Nothing, AddressOf ShowDetails)
        menu.Items.Add("កែប្រែ", Nothing, AddressOf EditCourse)
        menu.Items.Add("លុប", Nothing, AddressOf DeleteCourse)
        menu.Items(0).BackColor = Color.FromArgb(245, 250, 253)

        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                DataGridView1.Rows(hit.RowIndex).Selected = True
                Dim subjectID As String = DataGridView1.Rows(hit.RowIndex).Cells(0).Value.ToString()
                subject.GetSubjectByID(subjectID)
                menu.Show(DataGridView1, e.Location)
            End If
        End If

    End Sub

    Private Sub DeleteCourse()
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុបវគ្គសិក្សានេះទេ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            subject.DeleteSubject()
            MessageBox.Show("វគ្គសិក្សា ៖ " & subject.Subject & " ត្រូវបានលុបដោយជោគជ័យ!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Display()
        End If
    End Sub
    Private Sub EditCourse()
        Panel1.Visible = True
        btnEdit.Visible = True
        txtSubject.Text = subject.Subject
        txtDes.Text = subject.Description.ToString()
        txtCreditHours.Text = subject.CreditHours.ToString()
        txtBasePrice.Text = subject.basePrice.ToString("F2")
    End Sub

    Private Sub ShowDetails()
        Dim courseDialog As New SubjectDetail(subject)
        courseDialog.ShowDialog()
        Display()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtBasePrice.Text = ""
        txtSubject.Text = ""
        txtDes.Text = ""
        txtCreditHours.Text = ""
        subject.ID = ""
        subject.Subject = ""
        subject.Description = ""
        subject.CreditHours = 0
        subject.basePrice = 0D
        btnEdit.Visible = False
        btnCreate.Visible = False
        Panel1.Visible = False
    End Sub

    Private Sub txtSearch__TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If startup Then
            Return
        End If
        Dim dt As New DataTable()
        Dim query As String = "SELECT tblSubject.ID, tblSubject.Subject, tblSubject.Description, tblSubject.CreditHours, tblSubject.BasePrice, 
                        (SELECT COUNT(*) FROM tblCourse WHERE tblCourse.ID = tblSubject.ID) AS AllCourses, 
                        (SELECT COUNT(*) FROM tblCourse WHERE StatusID = 3 AND tblCourse.ID = tblSubject.ID) AS CompleteCourse
                        FROM tblSubject
                        WHERE ((tblSubject.ID = @id) or (tblSubject.Subject LIKE @Condition));"
        Dim cmd As New OleDb.OleDbCommand(query, subject.GetConnection())
        Dim id As Integer
        Dim condition As String = txtSearch.Text.Trim()
        If IsNumeric(condition) Then
            id = Integer.Parse(condition)
        Else
            id = 0
        End If
        condition = condition + "%"
        cmd.Parameters.AddWithValue("@id", id)
        condition = condition & "%"
        cmd.Parameters.AddWithValue("@Condition", condition)
        DataGridView1.DataSource = subject.ExecuteQuery(cmd)
        Regonize()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Texts = ""
        Display()
    End Sub
    Sub Regonize()
        With DataGridView1
            .ColumnHeadersHeight = 40
            .Columns(0).Width = 50 ' ID column width
            .Columns(0).DefaultCellStyle.Format = "000"
            .Columns(1).Width = 200 ' Course Name column width
            .Columns(2).Width = 250 ' Description column width
            .Columns(3).Width = 150 ' Description column width
            .Columns(4).Width = 150
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "វគ្គសិក្សា"
            .Columns(2).HeaderText = "ការពិពណ៌នា"
            .Columns(3).HeaderText = "រយៈពេល (ម៉ោង)"
            .Columns(3).DefaultCellStyle.Format = "00ម៉ោង"
            .Columns(4).HeaderText = "តម្លៃ ($)"
            .Columns(4).DefaultCellStyle.Format = "C2"
            .Columns(5).HeaderText = "ចំនួនថ្នាក់រៀន"
            .Columns(6).HeaderText = "ចំនួនថ្នាក់បញ្ចប់"
        End With
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If i Mod 2 = 1 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
            End If
            For j As Integer = 3 To DataGridView1.Columns.Count - 1
                DataGridView1.Rows(i).Cells(j).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next j
        Next i
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If CheckField() Then
            If txtSubject.Text = subject.Subject And txtDes.Text = subject.Description And Convert.ToDecimal(txtBasePrice.Text.Trim()) = subject.basePrice And Convert.ToInt16(txtCreditHours.Text.Trim()) = subject.CreditHours Then
                MessageBox.Show("មិនមានទិន្ន័យណាត្រូវបានកែប្រែទេ!!!")
            Else
                subject.Subject = txtSubject.Text.Trim()
                subject.basePrice = Convert.ToDecimal(txtBasePrice.Text.Trim())
                subject.CreditHours = Convert.ToInt32(txtCreditHours.Text.Trim())
                subject.Description = txtDes.Text.Trim()
                subject.UpdateSubject()
                MsgBox("មុខវិជ្ជាត្រូវបានកែប្រែដោយជោគជ័យ")
                Display()
            End If
        End If
    End Sub
End Class