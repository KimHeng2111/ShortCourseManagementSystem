Public Class LoginForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = 2
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = 1
        Me.Close()
    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If txtPassWord.PasswordChar = True Then
            txtPassWord.PasswordChar = False
            btnShowHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Else
            txtPassWord.PasswordChar = True
            btnShowHide.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub
End Class