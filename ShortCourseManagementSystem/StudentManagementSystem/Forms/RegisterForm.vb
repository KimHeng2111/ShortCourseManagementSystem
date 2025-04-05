Public Class RegisterForm
    Private Sub btnStudentImage_Click(sender As Object, e As EventArgs) Handles btnStudentImage.Click, picStudent.Click
        OpenFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picStudent.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbDate.Text = DateTime.Now.ToString("dddd dd/MMM/yyyy")
    End Sub

End Class