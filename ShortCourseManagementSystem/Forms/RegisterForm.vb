Imports System.Data.OleDb
Imports System.IO
Imports Guna.UI2.WinForms
Public Class RegisterForm
    Dim register As New Register()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GetCbCourse()
        GetCbAddress()
        picStudent.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
    End Sub

    Sub Display()
        DataGridView1.DataSource = register.GetRegisterData()
        Regonize()
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


    Private Sub txtDis_TextChanged_1(sender As Object, e As EventArgs) Handles txtDis.Click
        Dim dis As Decimal
        If cbCourse.Text = String.Empty Then
            txtDis.Text = 0
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

        If txtKhName.Text.Length <= 0 Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះសិស្ស", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKhName.Focus()
            Return False
        End If
        If txtEngName.Text.Length <= 0 Then
            MessageBox.Show("សូមបញ្ចូលឈ្មោះឡាតាំងរបស់សិស្ស", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEngName.Focus()
            Return False
        End If
        If cbAddress.SelectedIndex = cbAddress.Items.Count - 1 Then
            MessageBox.Show("សូមជ្រើសរើសអាស័យដ្ឋាន", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbAddress.Focus()
            Return False
        End If
        If txtPhone.Text.Length = 0 Then
            Dim result = MessageBox.Show("តើអ្នកសិស្សមិនមានលេខទូរស័ព្ទមែនទេ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                txtPhone.Focus()
                Return False
            End If
        ElseIf (txtPhone.Text.Length < 9 Or txtPhone.Text.Length > 10) And txtPhone.Text.Length <> 0 Then
            MessageBox.Show("សូមបញ្ចូលលេខទូរស័ព្ទដែលត្រឹមត្រូវ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return False
        End If
        If txtpay.Text.Length <= 0 Or Not IsNumeric(txtpay.Text) Then
            MessageBox.Show("សូមបញ្ចូលចំនួនទឹកប្រាក់ដែលសិស្សបង់", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpay.Focus()
            Return False
        End If
        Return True
    End Function

    Function CheckValidation() As Boolean
        'Check if the student has already registered for the class
        Dim studentID As Integer = register.student.id
        Dim classID As Integer = Convert.ToInt32(cbTime.SelectedValue)
        Dim query As String = "SELECT COUNT(*) FROM tblRegister WHERE StudentID = @StudentID AND ClassID = @ClassID"
        Dim cmd As New OleDbCommand(query, register.GetConnection())
        cmd.Parameters.AddWithValue("@StudentID", studentID)
        cmd.Parameters.AddWithValue("@ClassID", classID)
        register.OpenConnection()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        register.CloseConnection()
        If count > 0 Then
            MessageBox.Show("សូមអភ័យទោសសិស្សឈ្មោះ " & register.student.khName & " ចានចុះឈ្មោះវគ្គសិក្សានេះរូចហើយ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        'Check if the Student has already Other at this Schedule
        Dim scheduleQuery As String = "SELECT COUNT(*) FROM tblRegister WHERE StudentID = @StudentID AND ScheduleID = @ScheduleID;"
        cmd = New OleDbCommand(scheduleQuery, register.GetConnection())
        cmd.Parameters.AddWithValue("@StudentID", studentID)
        cmd.Parameters.AddWithValue("@ScheduleID", cbTime.SelectedValue)
        register.OpenConnection()
        count = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            MessageBox.Show("សូមអភ័យទោសសិស្សឈ្មោះ " & register.student.khName & " ចានចុះឈ្មោះវេនសិក្សានេះរូចហើយ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
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
    Sub GetCbAddress()
        Dim addressData = register.student.GetAddressData()
        addressData.Add("ជ្រើសរើសខេត្ត")
        cbAddress.DataSource = addressData
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
    End Sub
    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        If Integer.TryParse(cbCourse.SelectedValue.ToString(), Nothing) = False Then
            Return
        End If
        If Integer.Parse(cbCourse.SelectedValue) = -1 Then
            cbTime.Enabled = False
            Return
        End If

        Dim courseID As Integer = Convert.ToInt32(cbCourse.SelectedValue)
        cbTime.DataSource = New BindingSource(register.GetTimeList(courseID), Nothing)
        cbTime.DisplayMember = "Key"
        cbTime.ValueMember = "Value"
        cbTime.SelectedIndex = cbTime.Items.Count - 1
        cbTime.Enabled = True
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Step 1 : Check Field   
        If Not CheckField() Then
            Return
        End If
        If Not CheckValidation() Then
            Return
        End If
        'Step 2 : Create Student
        register.student.AddStudent(txtKhName.Text.Trim(), txtEngName.Text.Trim(), cbGender.Text, dtpDob.Text, cbAddress.Text.Trim(), txtPhone.Text.Trim(), SaveImageAndReturnPath())
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
        If cbTime.Items.Count = 1 Then
            Return
        End If
        If Not IsNumeric(cbTime.SelectedValue.ToString()) Then
            Return
        End If
        'If cbTime.SelectedValue =  Then
        '    Return
        'End If
        If cbTime.SelectedValue = -1 Then
            Return
        End If
        register.manageClass.GetClassByID(cbTime.SelectedValue.ToString())
        lbRoom.Text = register.manageClass.room.room
        lbPrice.Text = register.manageClass.course.basePrice.ToString("F2")
        txtDis.Text = "0"
    End Sub
    Sub Regonize()
        DataGridView1.ColumnHeadersHeight = 40
        DataGridView1.Columns(0).Width = 50 ' ID column width
        DataGridView1.Columns(1).Width = 250 ' Course Name column width
        DataGridView1.Columns(2).Width = 200 ' Description column width
        DataGridView1.Columns(3).Width = 150 ' Description column width
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(5).Width = 150
        DataGridView1.Columns(6).Width = 150
        DataGridView1.Columns(0).HeaderText = "ClassID"
        DataGridView1.Columns(1).HeaderText = "វគ្គសិក្សា"
        DataGridView1.Columns(2).HeaderText = "គ្រូបង្រៀន"
        DataGridView1.Columns(3).HeaderText = "ថ្ងៃចូលរៀន"
        DataGridView1.Columns(4).HeaderText = "វេនសិក្សា"
        DataGridView1.Columns(5).HeaderText = "បន្ទប់រៀន"
        DataGridView1.Columns(6).HeaderText = "សិស្សសរុប"
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ClearSelection()
    End Sub


    Private Sub btnChooseStudent_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelListShow_Paint(sender As Object, e As PaintEventArgs) Handles PanelListShow.Paint
        Display()
    End Sub
    Private Sub dtpDob_TextChanged(sender As Object, e As EventArgs) Handles dtpDob.TextChanged
        Dim input As String = dtpDob.Text.Replace("/", "") ' Remove existing slashes
        If input.Length >= 2 AndAlso input.Length < 4 Then
            dtpDob.Text = input.Insert(2, "/") ' Add slash after day
            dtpDob.SelectionStart = dtpDob.Text.Length ' Move cursor to end
        ElseIf input.Length >= 4 Then
            dtpDob.Text = input.Insert(2, "/").Insert(5, "/") ' Add slash after month
            dtpDob.SelectionStart = dtpDob.Text.Length ' Move cursor to end
        End If
    End Sub

    Private Sub dtpDob_Leave(sender As Object, e As EventArgs) Handles dtpDob.Leave
        Dim inputDate As DateTime
        If DateTime.TryParse(dtpDob.Text, inputDate) Then
            dtpDob.Text = inputDate.ToString("dd/MM/yyyy")
        Else
            If dtpDob.Text.Length = 0 Then
                Return
            End If
            MessageBox.Show("សូមបញ្ចូលថ្ងៃខែឆ្នាំកំណើតរបស់សិស្ស", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtKhName.Clear()
        txtEngName.Clear()
        txtDis.Clear()
        txtpay.Clear()
        txtPhone.Clear()
        lbAmount.Text = "$"
        lbPrice.Text = "$"
        dtpDob.Clear()
        lbRoom.Text = ".........."
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
        cbCourse.SelectedIndex = cbCourse.Items.Count - 1
        cbGender.SelectedIndex = cbGender.Items.Count - 1
        cbTime.SelectedIndex = cbTime.Items.Count - 1
        cbTime.Enabled = False
        picStudent.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
    End Sub
End Class