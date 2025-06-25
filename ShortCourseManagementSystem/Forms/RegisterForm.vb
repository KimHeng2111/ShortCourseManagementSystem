Imports System.Data.OleDb
Imports System.Data.SqlTypes
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Guna.UI2.WinForms
Imports Microsoft.SqlServer
Public Class RegisterForm
    Dim register As New Register()
    Dim startup As Boolean = True
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GetCbSubject()
        GetCbAddress()
        picStudent.ImageLocation = Application.StartupPath & "\Images\default.png"

    End Sub

    Sub Display()
        DataGridView1.DataSource = register.GetRegisterData()
        Regonize()
    End Sub



    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        OpenPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenPic.Title = "Select a Picture"
        OpenPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If OpenPic.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenPic.FileName
            picStudent.ImageLocation = filePath
        End If
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
        If txtPay.Text.Length <= 0 Or Not IsNumeric(txtPay.Text) Then
            MessageBox.Show("សូមបញ្ចូលចំនួនទឹកប្រាក់ដែលសិស្សបង់", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPay.Focus()
            Return False
        End If
        Return True
    End Function

    Function CheckValidation() As Boolean
        'Check if the student has already registered for the Course
        Dim studentID As Integer = register.student.id
        Dim courseID As Integer = register.course.ID
        Dim query As String = "SELECT COUNT(*) FROM tblRegister WHERE StudentID = @StudentID AND CourseID = @CourseID"
        Dim cmd As New OleDbCommand(query, register.GetConnection())
        cmd.Parameters.AddWithValue("@StudentID", studentID)
        cmd.Parameters.AddWithValue("@CourseID", courseID)
        register.OpenConnection()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        register.CloseConnection()
        If count > 0 Then
            MessageBox.Show("សូមអភ័យទោសសិស្សឈ្មោះ " & register.student.khName & " ចានចុះឈ្មោះវគ្គសិក្សានេះរូចហើយ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        'Check if the Student has already Other at this Schedule
        Dim scheduleQuery As String = "SELECT Count(*) 
                                        FROM tblCourse INNER JOIN tblRegister ON tblCourse.ID = tblRegister.CourseID
                                        WHERE (((tblRegister.StudentID)=@StudentID) AND ((tblCourse.StatusID)=@ScheduleID));"
        cmd = New OleDbCommand(scheduleQuery, register.GetConnection())
        cmd.Parameters.AddWithValue("@StudentID", studentID)
        cmd.Parameters.AddWithValue("@ScheduleID", register.course.scheduleID)
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
        If Path.GetFileName(picStudent.ImageLocation) = "default.png" Then
            Return picStudent.ImageLocation
        End If

        Dim source As String = picStudent.ImageLocation
        Dim imagesDir As String = Path.Combine(Application.StartupPath, "Images")
        Dim destination As String = Path.Combine(imagesDir, Path.GetFileName(source))

        Try
            If Not Directory.Exists(imagesDir) Then
                Directory.CreateDirectory(imagesDir)
            End If

            FileCopy(source, destination)
            Return destination
        Catch ex As Exception
            MessageBox.Show("Failed to copy image: " & ex.Message)
            Return ""
        End Try
    End Function

    Sub GetCbSubject()
        cbCourse.DataSource = New BindingSource(register.GetSubjectList(), Nothing)
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

        Dim SubjectID As Integer = Convert.ToInt32(cbCourse.SelectedValue)
        cbTime.DataSource = New BindingSource(register.GetTimeList(SubjectID), Nothing)
        register.course.subject.GetSubjectByID(SubjectID)
        txtPrice.Text = register.course.subject.basePrice.ToString("F2")
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
        'if don't Choose Student From List Thus Create a new student 
        If register.student.id = String.Empty Then
            register.student.AddStudent(txtKhName.Text.Trim(), txtEngName.Text.Trim(), cbGender.Text, dtpDob.Text, cbAddress.Text.Trim(), txtPhone.Text.Trim(), SaveImageAndReturnPath())
        End If
        'Assign Course Data to Register
        register.course.GetCourseByID(cbTime.SelectedValue.ToString())
        'Check Student Duplicate Course or Schedule
        If Not CheckValidation() Then
            Return
        End If
        Dim Price = Convert.ToDecimal(txtPrice.Text)
        Dim Dis = Convert.ToInt16(txtDis.Text)
        register.discount = Price * Dis / 100.0
        Dim amount As Decimal = Decimal.Parse(txtAmount.Text)
        Dim unpaid As Decimal = amount - Convert.ToDecimal(txtPay.Text)
        'Step 2 : Create Register
        register.RegisterStudent()
        register.payment.NewPayment(register.registerID, amount, unpaid) 'Create Payment
        'Print Invoice
        ExportAndShow()
        'Step 4 Display Data
        Display()
        register = New Register()
        btnClear.PerformClick()
    End Sub

    Private Sub cbTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTime.SelectedIndexChanged
        If cbTime.Items.Count = 1 Then
            Return
        End If
        If Not IsNumeric(cbTime.SelectedValue.ToString()) Then
            Return
        End If
        If cbTime.SelectedValue = -1 Then
            Return
        End If
        register.course.GetCourseByID(cbTime.SelectedValue.ToString())
        txtRoom.Text = register.course.room.room
        txtPrice.Text = register.course.subject.basePrice.ToString("F2")
        txtAmount.Text = register.course.subject.basePrice.ToString("F2")
        txtDis.Text = "0"
        txtPay.Text = register.course.subject.basePrice.ToString("F2")
    End Sub
    Sub Regonize()
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        With DataGridView1
            .ColumnHeadersHeight = 40
            .Columns(0).Width = 50 ' ID column width
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Format = "000"
            .Columns(1).Width = 250 ' Course Name column width
            .Columns(2).Width = 200 ' Description column width
            .Columns(3).Width = 150 ' Description column width
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).Width = 150
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(0).HeaderText = "លេខកូដ"
            .Columns(1).HeaderText = "វគ្គសិក្សា"
            .Columns(2).HeaderText = "គ្រូបង្រៀន"
            .Columns(3).HeaderText = "ថ្ងៃចូលរៀន"
            .Columns(4).HeaderText = "វេនសិក្សា"
            .Columns(5).HeaderText = "បន្ទប់រៀន"
            .Columns(6).HeaderText = "សិស្សសរុប"
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ClearSelection()
        End With
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
        txtDis.Text = "0"
        txtPay.Clear()
        txtPhone.Clear()
        txtAmount.Text = "0"
        txtPrice.Text = "0"
        dtpDob.Clear()
        txtRoom.Text = ""
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
        cbCourse.SelectedIndex = cbCourse.Items.Count - 1
        cbGender.SelectedIndex = cbGender.Items.Count - 1
        cbTime.SelectedIndex = cbTime.Items.Count - 1
        cbTime.Enabled = False
        picStudent.ImageLocation = Application.StartupPath & "\Images\default.png"
        register = New Register()
    End Sub

    Private Sub txtDis_TextChanged(sender As Object, e As EventArgs) Handles txtDis.TextChanged
        If cbCourse.SelectedIndex = cbCourse.Items.Count - 1 Then
            Return
        End If
        Dim dis As Decimal
        If cbCourse.Text = String.Empty Then
            txtDis.Text = 0
            Return
        End If
        If Not (Decimal.TryParse(txtDis.Text, dis)) Or dis < 0 Or dis > 100 Then
            MessageBox.Show("សូមបញ្ចូលភាគរយបញ្ចុះតម្លៃអោយបានត្រឹមត្រូវ!!!", "បញ្ចូលទិន្ន័យមិនត្រឹមត្រូវ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDis.Focus()
            txtDis.SelectAll()
            Return
        End If
        Dim amount As Decimal
        Dim price As Decimal = Decimal.Parse(txtPrice.Text)
        amount = price - price * (dis / 100.0) ' Ensures decimal division
        txtAmount.Text = amount.ToString("F2") ' Formats output as 2 decimal places
        amount.ToString("F2")
    End Sub

    Private Sub btnChooseStudent_Click_1(sender As Object, e As EventArgs) Handles btnChooseStudent.Click
        Dim student As New StudentList()
        If student.ShowDialog() = 2 Then
            Return
        End If
        register.student = student.student
        txtKhName.Text = register.student.khName
        txtEngName.Text = register.student.engName
        txtPhone.Text = register.student.phone
        cbGender.SelectedIndex = cbGender.FindStringExact(register.student.gender)
        dtpDob.Text = register.student.DateOfBirth.ToString("dd/MM/yyyy")
        cbAddress.SelectedIndex = cbAddress.FindStringExact(register.student.address)
        picStudent.ImageLocation = register.student.picture
    End Sub
    Private Sub ExportAndShow()
        Dim rdReport As New ReportDocument
        rdReport.Load("Report\Invoice.rpt")
        Dim num As Integer = Convert.ToInt16(register.payment.paymentID)
        rdReport.SetParameterValue("PaymentID", num.ToString("0000"))
        rdReport.SetParameterValue("khName", register.student.khName)
        rdReport.SetParameterValue(2, register.student.engName)
        rdReport.SetParameterValue(3, register.student.address)
        rdReport.SetParameterValue(4, register.student.phone)
        rdReport.SetParameterValue(7, register.registerID)
        rdReport.SetParameterValue(9, register.course.subject.Subject)
        rdReport.SetParameterValue(8, register.course.subject.basePrice)
        rdReport.SetParameterValue(5, register.payment.amount)
        rdReport.SetParameterValue(6, register.payment.unpaid)
        rdReport.SetParameterValue(10, register.course.startDate)
        rdReport.SetParameterValue(11, register.course.GetSchedule())
        rdReport.SetParameterValue(12, register.course.room.room)
        rdReport.PrintOptions.PaperSize = PaperSize.PaperA4
        Dim exportPath As String = Application.StartupPath & "\Export\Invoices"
        If Not Directory.Exists(exportPath) Then
            Directory.CreateDirectory(exportPath)
        End If
        exportPath = (exportPath + "\") & register.student.khName & "_" & Date.Now().ToString("dd-MMM-yyyy") & ".pdf"
        rdReport.ExportToDisk(ExportFormatType.PortableDocFormat, exportPath)
        Process.Start(exportPath)
    End Sub
    Sub SearchData() Handles txtSearch.TextChanged
        If startup Then
            Return
        End If
        Dim query As String = "SELECT tblCourse.ID, tblSubject.Subject, tblTeacher.EngName, tblCourse.StartDate, tblSchedule.Schedule, tblRoom.Room, (Select COUNT(*) FROM tblRegister WHERE tblCourse.ID = tblRegister.CourseID) As TotalStudent
                                From tblTeacher INNER Join (tblSchedule INNER Join (tblRoom INNER Join (tblSubject INNER Join (tblCourseStatus INNER Join tblCourse On tblCourseStatus.ID = tblCourse.StatusID) ON tblSubject.ID = tblCourse.SubjectID) ON tblRoom.ID = tblCourse.RoomID) ON tblSchedule.ID = tblCourse.ScheduleID) ON tblTeacher.ID = tblCourse.TeacherID
                                Where tblCourse.StatusID <= 2 AND tblSubject.Subject LIKE @subject
                                Order By tblCourse.ID;"
        Dim subject As String = If(txtSearch.Text = "", "%", txtSearch.Text & "%")
        Dim cmd As New OleDbCommand(query, register.GetConnection())
        cmd.Parameters.AddWithValue("@subject", subject)
        DataGridView1.DataSource = register.ExecuteQuery(cmd)
        Regonize()
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startup = False
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim courseID As String = DataGridView1.SelectedRows(0).Cells(0).Value
        register.course.GetCourseByID(courseID)
        cbCourse.SelectedIndex = cbCourse.FindStringExact(register.course.subject.Subject)
        cbTime.SelectedIndex = cbTime.FindStringExact(register.course.GetSchedule)
    End Sub

    Private Sub txtDis_Leave(sender As Object, e As EventArgs) Handles txtDis.Leave
        If txtDis.Text.Length = 0 Then
            txtDis.Text = "0"
        End If
    End Sub

    Private Sub SearchData(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtSearch.Clear()
    End Sub
End Class