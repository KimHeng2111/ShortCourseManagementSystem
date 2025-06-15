Imports FontAwesome.Sharp
Public Class MainForm
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Public login As Integer
    'Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(10, btnReport.Height)
        panelMenu.Controls.Add(leftBorderBtn)
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        'Dim test As LoginForm = New LoginForm()
        'login = test.ShowDialog()
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
            Dim middle As Integer = ((panelTitlebar.Size.Width / 2) - (lbFormTitle.Size.Width / 2))
            lbFormTitle.Location = New Point(middle, lbFormTitle.Location.Y)
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

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Gainsboro
        lbFormTitle.Text = "Home"
    End Sub


    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Activatebutton(sender, ThemeColor.DashboardColor)
        OpenChildForm(New DashboardForm())
    End Sub
    Private Sub BtnStudent_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New RegisterForm())
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New CoursesForm())
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New TeachersForm())
    End Sub

    Private Sub btnStudent_Click_1(sender As Object, e As EventArgs) Handles btnStudent.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New StudentForm())
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Activatebutton(sender, ThemeColor.activeColor)
        OpenChildForm(New ManageClassForm())
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If login = 2 Then
            Application.Exit()
        End If
        btnDashboard.PerformClick()
    End Sub
End Class
