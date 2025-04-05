Public Class Student
    Private Sub txtSearchStudent__TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudent._TextChanged
        If txtSearchStudent.Texts.Length >= 1 Then
            btnSerach.Visible = True
        Else
            btnSerach.Visible = False
        End If
    End Sub
End Class