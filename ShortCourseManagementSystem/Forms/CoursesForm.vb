Public Class CoursesForm
    Dim course As Course = New Course()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        display()
    End Sub

    Sub display()
        DataGridView1.DataSource = course.GetCourseData()
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
        display()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim CoursID As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        course.GetCourseByID(CoursID)
        txtCourseName.Text = course.courseName
        txtDes.Text = course.Description
        txtDuration.Text = course.durations.ToString()
        txtBasePrice.Text = course.basePrice.ToString("F2")

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
        display()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not CheckField() Then
            Return
        Else
            course.DeleteCourse()
            MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        display()
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
End Class