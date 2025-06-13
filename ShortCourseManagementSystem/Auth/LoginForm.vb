Public Class LoginForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
        Dim test As Boolean = ("A" = "a")
        MsgBox(test.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.DialogResult = 2
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If CheckField() Then
            If User.CheckLogin(txtUserName.Texts.Trim(), txtPassWord.Texts.Trim()) Then
                MessageBox.Show("សូមស្វាគមន៍ " & User.userName, "ការជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.DialogResult = 1
                Me.Close()
            Else
                MessageBox.Show("ឈ្មោះអ្នកប្រើប្រាស់ ឬ ពាក្យសម្ងាត់មិនត្រឹមត្រូវទេ", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserName.Focus()
            End If
        End If
    End Sub
    Function CheckField() As Boolean
        If txtUserName.Texts = "" Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះអ្នកប្រើប្រាស់", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserName.Focus()
            Return False
        Else
            If txtPassWord.Texts = "" Then
                MessageBox.Show("សូមបញ្ចូលពាក្យសម្ងាត់", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassWord.Focus()
                Return False
            Else
                Return True
            End If
        End If
    End Function
    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        If txtPassWord.PasswordChar = True Then
            txtPassWord.PasswordChar = False
            btnShowHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Else
            txtPassWord.PasswordChar = True
            btnShowHide.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = 2
        Me.Close()
    End Sub
End Class