Public Class LoginForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If CheckField() Then
            If User.CheckLogin(txtUserName.Text.Trim(), txtPassWord.Text.Trim()) Then
                MainForm.Visible = True
                Me.Hide()
            Else
                MessageBox.Show("ឈ្មោះអ្នកប្រើប្រាស់ ឬ ពាក្យសម្ងាត់មិនត្រឹមត្រូវទេ", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserName.Focus()
            End If
        End If
    End Sub
    Function CheckField() As Boolean
        If txtUserName.Text = "" Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះអ្នកប្រើប្រាស់", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.Focus()
            Return False
        Else
            If txtPassWord.Text = "" Then
                MessageBox.Show("សូមបញ្ចូលពាក្យសម្ងាត់", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassWord.Focus()
                Return False
            Else
                Return True
            End If
        End If
    End Function
    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If txtPassWord.UseSystemPasswordChar = True Then
            txtPassWord.UseSystemPasswordChar = False
            btnShowHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Else
            txtPassWord.UseSystemPasswordChar = True
            btnShowHide.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub txtPassWord_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassWord.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class