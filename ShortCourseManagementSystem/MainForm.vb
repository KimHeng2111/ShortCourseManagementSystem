Imports FontAwesome.Sharp
Public Class MainForm
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(10, btnCourse.Height)
        panelMenu.Controls.Add(leftBorderBtn)
    End Sub
    Private Sub Activatebutton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = ThemeColor.ChangeColorBrightness(customColor, -0.7)
            currentBtn.ForeColor = ThemeColor.ChangeColorBrightness(customColor, 0.5)
            currentBtn.IconColor = ThemeColor.ChangeColorBrightness(customColor, 0.5)
            currentBtn.Font = New Font(currentBtn.Font.FontFamily, 12.0, FontStyle.Bold)
            If panelMenu.Width >= 200 Then
                currentBtn.ImageAlign = ContentAlignment.MiddleRight
                currentBtn.Padding = New Padding(10, 0, 20, 0)

            End If
            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            'Current Form Icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = ThemeColor.ChangeColorBrightness(customColor, 0.5)
            'Current Form Title
            lbFormTitle.Text = LTrim(currentBtn.Tag.ToString)
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = ThemeColor.menuBackColor
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.Font = New Font(currentBtn.Font.FontFamily, 10.0, FontStyle.Bold)
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.Padding = New Padding(10, 0, 20, 0)
            If panelMenu.Width < 200 Then
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter
            End If
        End If
    End Sub

    'Open Child Form
    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelChildForm.Controls.Add(childForm)
        'panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        If panelMenu.Width >= 200 Then
            panelMenu.Width = 100
            btnMenu.Dock = DockStyle.Top
            Panel1.Visible = False
            If currentBtn IsNot Nothing Then
                leftBorderBtn.Location = New Point(currentBtn.Location.X, currentBtn.Location.Y)
            End If
            For Each btn As IconButton In panelMenu.Controls.OfType(Of IconButton)()
                btn.Text = String.Empty
                btn.ImageAlign = ContentAlignment.MiddleCenter
                btn.Padding = New Padding(0)

            Next
        Else
            panelMenu.Width = 230
            btnMenu.Dock = DockStyle.None
            Panel1.Visible = True
            If currentBtn IsNot Nothing Then
                leftBorderBtn.Location = New Point(currentBtn.Location.X, currentBtn.Location.Y)
                currentBtn.TextAlign = ContentAlignment.MiddleCenter
                currentBtn.ImageAlign = ContentAlignment.MiddleRight
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            End If
            For Each btn As IconButton In panelMenu.Controls.OfType(Of IconButton)()
                btn.Text = btn.Tag.ToString()
                btn.ImageAlign = ContentAlignment.MiddleLeft
                btn.Padding = New Padding(10, 0, 20, 0)
            Next
        End If
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Gainsboro
        lbFormTitle.Text = "Home"
    End Sub


    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Activatebutton(sender, ThemeColor.DashboardColor)

    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New RegisterForm())
    End Sub

    Private Sub BtnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New Student())
    End Sub

    Private Sub BtnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        Activatebutton(sender, ThemeColor.CourseColor)
    End Sub

    Private Sub BtnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Activatebutton(sender, ThemeColor.activeColor)
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Activatebutton(sender, ThemeColor.activeColor)
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New ClassForm())
    End Sub
End Class
