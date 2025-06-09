Public Class CoursesForm
    Dim course As New Course()

    Sub Display()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = course.GetCourseData()
        DataGridView1.ColumnHeadersHeight = 40
        'DataGridView1.AllowUserToResizeColumns = True
        'Customize DataGridView columns
        DataGridView1.Columns(0).Width = 50 ' ID column width
        DataGridView1.Columns(1).Width = 200 ' Course Name column width
        DataGridView1.Columns(3).Width = 100 ' Description column width
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 130
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
        Panel1.Visible = False
    End Sub

    Function CheckField() As Boolean
        Dim courseName As String = txtCourseName.Text.Trim()
        Dim description As String = txtDes.Text.Trim()
        Dim duration As String = txtDuration.Text.Trim()
        Dim basePrice As String = txtBasePrice.Text.Trim()
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
            course.AddCourse(txtCourseName.Text.Trim(), txtDes.Text.Trim(), Convert.ToInt32(txtDuration.Text.Trim()), Convert.ToDecimal(txtBasePrice.Text.Trim()))
            MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Display()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not CheckField() Then
            Return
        Else
            course.courseName = txtCourseName.Text.Trim()
            course.Description = txtDes.Text.Trim()
            course.durations = Convert.ToInt32(txtDuration.Text.Trim())
            course.basePrice = Convert.ToDecimal(txtBasePrice.Text.Trim())
            course.UpdateCourse()
            MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Display()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not CheckField() Then
            Return
        Else
            course.DeleteCourse()
            MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Display()
    End Sub
    Sub Clear() Handles btnClear.Click
        txtBasePrice.Text = ""
        txtCourseName.Text = ""
        txtDes.Text = ""
        txtDuration.Text = ""
        course.courseID = ""
        course.courseName = ""
        course.Description = ""
        course.durations = 0
        course.basePrice = 0D
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim CoursID As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        course.GetCourseByID(CoursID)
        txtCourseName.Text = course.courseName
        txtDes.Text = course.Description
        txtDuration.Text = course.durations.ToString()
        txtBasePrice.Text = course.basePrice.ToString("F2")
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
        Display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class