Imports System.Windows
Imports System.Windows.Controls

Public Class CoursesForm
    Dim course As New Course()
    Dim startup As Boolean = True
    Sub Display()
        DataGridView1.DataSource = course.GetCourseData()
        Regonize()
        Panel1.Visible = False
    End Sub

    Function CheckField() As Boolean
        Dim courseName As String = txtCourseName.Texts.Trim()
        Dim description As String = txtDes.Texts.Trim()
        Dim duration As String = txtDuration.Texts.Trim()
        Dim basePrice As String = txtBasePrice.Texts.Trim()
        If String.IsNullOrEmpty(courseName) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(duration) OrElse Not IsNumeric(duration) Then
            MessageBox.Show("Please enter a valid duration in hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(basePrice) OrElse Not IsNumeric(basePrice) Then
            MessageBox.Show("Please enter a valid base price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btmCreate_Click(sender As Object, e As EventArgs) Handles btmCreate.Click
        If Not CheckField() Then
            Return
        Else
            course.AddCourse(txtCourseName.Texts.Trim(), txtDes.Texts.Trim(), Convert.ToInt32(txtDuration.Texts.Trim()), Convert.ToDecimal(txtBasePrice.Texts.Trim()))
            MessageBox.Show("វគ្គសិក្សា ៖ " & txtCourseName.Texts & "ត្រូវបានបង្កើតបានដោយជោគជ័យ!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Display()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Display()
        startup = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel1.Visible = True
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim menu As New ContextMenuStrip()
        menu.Font = New Font("Khmer OS System", 9)
        menu.Items.Add("លម្អិត", Nothing, AddressOf ShowDetails)
        menu.Items.Add("លុប", Nothing, AddressOf DeleteCourse)
        menu.Items(0).BackColor = Color.FromArgb(245, 250, 253)

        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                DataGridView1.Rows(hit.RowIndex).Selected = True
                Dim CoursID As String = DataGridView1.Rows(hit.RowIndex).Cells(0).Value.ToString()
                course.GetCourseByID(CoursID)
                menu.Show(DataGridView1, e.Location)
            End If
        End If

    End Sub

    Private Sub DeleteCourse()
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុបវគ្គសិក្សានេះទេ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            course.DeleteCourse()
            MessageBox.Show("វគ្គសិក្សា ៖ " & course.courseName & " ត្រូវបានលុបដោយជោគជ័យ!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Display()
        End If
    End Sub

    Private Sub ShowDetails()
        Dim courseDialog As New CourseDetail(course)
        courseDialog.ShowDialog()
        Display()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtBasePrice.Text = ""
        txtCourseName.Text = ""
        txtDes.Text = ""
        txtDuration.Text = ""
        course.courseID = ""
        course.courseName = ""
        course.Description = ""
        course.durations = 0
        course.basePrice = 0D
        Panel1.Visible = False
    End Sub

    Private Sub txtSearch__TextChanged(sender As Object, e As EventArgs) Handles txtSearch._TextChanged
        If startup Then
            Return
        End If
        Dim dt As New DataTable()
        Dim query As String = "SELECT tblCourses.ID, tblCourses.CourseName, tblCourses.Description, tblCourses.DurationHours, tblCourses.BasePrice, 
                        (SELECT COUNT(*) FROM tblClass WHERE tblClass.CourseID = tblCourses.ID) AS AllClass, 
                        (SELECT COUNT(*) FROM tblClass WHERE StatusID = 3 AND tblClass.CourseID = tblCourses.ID) AS CompleteClass
                        FROM tblCourses
                        WHERE ((tblCourses.ID = @id) or (tblCourses.CourseName LIKE @Condition));"
        Dim cmd As New OleDb.OleDbCommand(query, course.GetConnection())
        Dim id As Integer
        Dim condition As String = txtSearch.Texts.Trim()
        If IsNumeric(Condition) Then
            id = Integer.Parse(Condition)
        Else
            id = 0
        End If
        condition = condition + "%"
        cmd.Parameters.AddWithValue("@id", id)
        Condition = Condition & "%"
        cmd.Parameters.AddWithValue("@Condition", condition)
        DataGridView1.DataSource = course.ExecuteQuery(cmd)
        Regonize()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Texts = ""
        Display()
    End Sub
    Sub Regonize()
        DataGridView1.ColumnHeadersHeight = 40
        DataGridView1.Columns(0).Width = 50 ' ID column width
        DataGridView1.Columns(1).Width = 200 ' Course Name column width
        DataGridView1.Columns(2).Width = 250 ' Description column width
        DataGridView1.Columns(3).Width = 150 ' Description column width
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(5).Width = 150
        DataGridView1.Columns(6).Width = 150
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "វគ្គសិក្សា"
        DataGridView1.Columns(2).HeaderText = "ការពិពណ៌នា"
        DataGridView1.Columns(3).HeaderText = "រយៈពេល (ម៉ោង)"
        DataGridView1.Columns(4).HeaderText = "តម្លៃ ($)"
        DataGridView1.Columns(5).HeaderText = "ចំនួនថ្នាក់រៀន"
        DataGridView1.Columns(6).HeaderText = "ចំនួនថ្នាក់បញ្ចប់"
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
        DataGridView1.ClearSelection()
    End Sub
End Class