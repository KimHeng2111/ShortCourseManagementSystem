Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Public Class RegisterForm
    Dim register As New Register()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Display()
        GetCbCourse()
        picStudent.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
    End Sub

    Sub Display()
        DataGridView2.DataSource = register.GetRegisterData()
    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenPic.Title = "Select a Picture"
        OpenPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If OpenPic.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenPic.FileName
            picStudent.ImageLocation = filePath
        End If
    End Sub


    Private Sub txtDis_TextChanged_1(sender As Object, e As EventArgs) Handles txtDis.TextChanged
        Dim dis As Decimal
        If cbCourse.Text = String.Empty Then
            MessageBox.Show("Please Choose Course !!!!!", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not (Decimal.TryParse(txtDis.Text, dis)) Or dis < 0 Or dis > 100 Then
            MessageBox.Show("Please enter a valid number for the discount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDis.Focus()
            txtDis.SelectAll()
            Return
        End If
        Dim amount As Decimal
        Dim price As Decimal = Decimal.Parse(lbPrice.Text)
        amount = price - price * (dis / 100.0) ' Ensures decimal division
        lbAmount.Text = amount.ToString("F2") ' Formats output as 2 decimal places
        amount.ToString("F2")
    End Sub

    Private Function CheckField() As Boolean

        If txtKhName.Texts.Length <= 0 Then
            MessageBox.Show("Please enter Student's KhmerName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKhName.PlaceholderColor = Color.Red
            txtKhName.Focus()
            Return False
        End If
        If txtEngName.Texts.Length <= 0 Then
            MessageBox.Show("Please enter Student's EnglishName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEngName.Focus()
            Return False
        End If
        If txtPOB.Texts.Length <= 0 Then
            MessageBox.Show("Please enter Student's place of birth", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPOB.Focus()

            Return False
        End If
        If (txtPhone.Texts.Length < 9 Or txtPhone.Texts.Length > 10) And txtPhone.Texts.Length <> 0 Then
            MessageBox.Show("Please enter a valid phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.PlaceholderColor = Color.Red
            txtPhone.Focus()
            'txtPhone.SelectAll()
            Return False
        ElseIf txtPhone.Texts.Length = 0 Then
            Dim result = MessageBox.Show("Do not have Phone Number", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End If
        If txtEmail.Texts.Length <= 0 Then
            MessageBox.Show("Please enter Student's email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        ElseIf Not IsValidEmail(txtEmail.Texts) Then
            MessageBox.Show("Please enter a valid email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If
        If cbCourse.Text.Length <= 0 Then
            MessageBox.Show("Please select a course", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCourse.Focus()
            Return False
        End If
        If txtpay.Text.Length <= 0 Or Not IsNumeric(txtpay.Text) Then
            MessageBox.Show("Please Enter payment amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpay.Focus()
            Return False
        End If
        Return True
    End Function

    'IsValidEmail
    Function IsValidEmail(ByVal email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return True
        Catch
            Return False
        End Try
    End Function

    'Save Image and reture the path
    Function SaveImageAndReturnPath() As String
        If Path.GetFileName(picStudent.ImageLocation) = "defalutStudent.png" Then
            Return picStudent.ImageLocation
        End If
        Dim source As String = picStudent.ImageLocation
        Dim destination As String = "\Images\" & Path.GetFileName(source)
        FileCopy(source, destination)
        Return destination
    End Function

    Sub GetCbCourse()
        cbCourse.DataSource = New BindingSource(register.GetCourseList(), Nothing)
        cbCourse.DisplayMember = "Key"
        cbCourse.ValueMember = "Value"
        cbCourse.SelectedIndex = cbCourse.Items.Count - 1 ' Set to the last item
    End Sub
    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        If Integer.TryParse(cbCourse.SelectedValue.ToString(), Nothing) = False Then
            Return
        End If
        If Integer.Parse(cbCourse.SelectedValue) = -1 Then
            Return
        End If
        register.manageClass.course.GetCourseByID(cbCourse.SelectedValue.ToString())
        Dim courseID As Integer = Convert.ToInt32(cbCourse.SelectedValue)
        cbTime.DataSource = New BindingSource(register.GetTimeList(courseID), Nothing)
        cbTime.DisplayMember = "Key"
        cbTime.ValueMember = "Value"
        cbTime.SelectedIndex = cbTime.Items.Count - 1
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Step 1 : Check Field   
        If Not CheckField() Then
            Return
        End If
        'Step 2 : Create Student
        register.student.AddStudent(txtKhName.Texts.Trim(), txtEngName.Texts.Trim(), cbGender.Text, dtpDob.Value, txtPOB.Texts.Trim(), txtPhone.Texts.Trim(), txtEmail.Texts.Trim(), SaveImageAndReturnPath())
        'Assign data to register
        register.manageClass.GetClassByID(cbTime.SelectedValue.ToString()) 'ADD ManageClass
        register.discount = If(txtDis.Text = String.Empty, 0, Convert.ToDecimal(txtDis.Text))
        Dim amount As Decimal = Decimal.Parse(lbAmount.Text)
        Dim unpaid As Decimal = amount - Convert.ToDecimal(txtpay.Text)
        register.payment.NewPayment(amount, unpaid) 'Create Payment
        'Step 3 : Create Register
        register.RegisterStudent()

        'Print Invoice
        Dim invoice As New Form1(register)
        invoice.ShowDialog()
        'Step 4 Display Data
        Display()

    End Sub

    Private Sub cbTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTime.SelectedIndexChanged
        If Integer.TryParse(cbTime.SelectedValue.ToString(), Nothing) = False Then
            Return
        End If
        lbPrice.Text = register.manageClass.course.basePrice.ToString("F2")
        txtDis.Text = "0"
    End Sub

End Class