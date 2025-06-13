Imports System.Data.OleDb

Public Class TeachersForm
    Dim teacher As Teacher = New Teacher()
    Dim startup As Boolean = True
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        'Dim addressData = teacher.GetAddressData()
        'addressData.Add("ជ្រើសរើសខេត្ត")
        'cbAddress.DataSource = addressData
        'cbAddress.SelectedIndex = cbAddress.Items.Count - 1
    End Sub
    'Display all teachers in DataGridView
    Sub Display()
        DataGridView1.DataSource = teacher.GetTeacherData()
        Regonize()
    End Sub

    'Check User Input
    Private Function CheckField() As Boolean
        Dim khName As String = txtKhName.Texts
        Dim engName As String = txtEngName.Texts.Trim()
        Dim Gender As String = cbGender.Text
        Dim DoB As Date = dtpDob.Value
        Dim Address As String = cbAddress.Text.Trim()
        Dim Phone As String = txtPhone.Texts.Trim()
        Dim Email As String = txtEmail.Texts.Trim()
        ' Validate inputs
        If String.IsNullOrEmpty(khName) Then
            MessageBox.Show("សូមបញ្ចូល គោត្តនាម នាម", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(engName) Then
            MessageBox.Show("សូមបញ្ចូល ឈ្មោះឡាតាំង", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Gender) Then
            MessageBox.Show("សូមជ្រើសភេទ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(DoB.ToString()) Then
            MessageBox.Show("សូមបញ្ចូលថ្ងៃខែឆ្មាំកំណើត.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Address) Then
            MessageBox.Show("សូមបញ្ជូលអាស័យដ្ឋាន", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Phone) Or IsNumeric(Phone) = False Then
            MessageBox.Show("សូមបញ្ចូលលេខទូរស័ព្ទ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf String.IsNullOrEmpty(Email) Or Not Email.Contains("@") Then
            MessageBox.Show("សូមបញ្ចូល Email", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        Dim teacterID As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        teacher.GetTeacherByID(teacterID)
        txtKhName.Texts = teacher.KhName
        txtEngName.Texts = teacher.EngName
        cbAddress.Text = teacher.Address
        dtpDob.Value = teacher.DoB
        txtPhone.Texts = teacher.Phone
        cbGender.Text = teacher.Gender
        txtEmail.Texts = teacher.Email
        If Not String.IsNullOrEmpty(teacher.Picture) Then
            picTeacher.ImageLocation = teacher.Picture
        Else
            picTeacher.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        If CheckField() Then

        End If
        Display()
    End Sub

    Private Sub btnChooseImage_Click(sender As Object, e As EventArgs) Handles btnChooseImage.Click
        OpenPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenPic.Title = "Select a Picture"
        OpenPic.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        If OpenPic.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenPic.FileName
            picTeacher.ImageLocation = filePath
        End If
    End Sub
    Sub Regonize()
        If DataGridView1.Columns.Count = 7 Then
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(1).HeaderText = "គោត្តនាម នាម"
            DataGridView1.Columns(2).Width = 250
            DataGridView1.Columns(2).HeaderText = "ឈ្មោះឡាតាំង"
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(3).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).Width = 200
            DataGridView1.Columns(4).HeaderText = "អាស័យដ្ឋាន"
            DataGridView1.Columns(5).Width = 250
            DataGridView1.Columns(5).HeaderText = "Email"
            DataGridView1.Columns(6).Width = 200
            DataGridView1.Columns(6).HeaderText = "លេខទូរស័ព្ទ"
            DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If i Mod 2 = 1 Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
                End If
            Next i
        End If
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint
        Display()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel2.Visible = True
        picTeacher.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
        btnAddNew.Visible = True
        btnEdit.Visible = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not CheckField() Then
            Return
        End If
        Dim count = 0
        If txtKhName.Texts <> teacher.KhName Then
            count += 1
        End If
        If txtEngName.Texts <> teacher.EngName Then
            count += 1
        End If
        If dtpDob.Value <> teacher.DoB Then
            count += 1
        End If
        If cbAddress.Text <> teacher.Address Then
            count += 1
        End If
        If txtPhone.Texts <> teacher.Phone Then
            count += 1
        End If
        If cbGender.Text <> teacher.Gender Then
            count += 1
        End If
        If txtEmail.Texts <> teacher.Email Then
            count += 1
        End If
        If count = 0 Then
            MessageBox.Show("មិនមានការផ្លាស់ប្តូរទេ។", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        teacher.KhName = txtKhName.Texts
        teacher.EngName = txtEngName.Texts.Trim()
        teacher.DoB = dtpDob.Value
        teacher.Address = cbAddress.Text.Trim()
        teacher.Phone = txtPhone.Texts.Trim()
        teacher.Gender = cbGender.Text
        teacher.Email = txtEmail.Texts.Trim()
        teacher.Picture = picTeacher.ImageLocation
        teacher.UpdateTeacher()
        Display()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If Not CheckField() Then
            Return
        Else
            teacher.KhName = txtKhName.Texts
            teacher.EngName = txtEngName.Texts.Trim()
            teacher.DoB = dtpDob.Value
            teacher.Address = cbAddress.Text.Trim()
            teacher.Phone = txtPhone.Texts.Trim()
            teacher.Gender = cbGender.Text
            teacher.Email = txtEmail.Texts.Trim()
            teacher.Picture = picTeacher.ImageLocation
            teacher.AddTeacher()
        End If
        Display()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel2.Visible = False
        txtKhName.Texts = ""
        txtEngName.Texts = ""
        cbAddress.Text = ""
        txtPhone.Texts = ""
        txtEmail.Texts = ""
        cbGender.Text = ""
        dtpDob.Value = DateTime.Now
        picTeacher.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
        btnAddNew.Visible = False
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim menu As New ContextMenuStrip()
        menu.Font = New Font("Khmer OS System", 9)
        menu.Items.Add("លម្អិត", Nothing, AddressOf ShowDetails)
        menu.Items.Add("កែប្រែ", Nothing, AddressOf EditClass)
        menu.Items.Add("លុប", Nothing, AddressOf DeleteCourse)
        menu.Items(0).BackColor = Color.FromArgb(245, 250, 253)
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                Dim teacherID As String = DataGridView1.Rows(hit.RowIndex).Cells(0).Value.ToString()
                teacher.GetTeacherByID(teacherID)
                menu.Show(DataGridView1, e.Location)
            End If
        End If
    End Sub
    Private Sub DeleteCourse()
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុប គ្រូបង្រៀនឈ្មោះ " & teacher.KhName & " នេះ មែនទេ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            teacher.DeleteTeacher(teacher.TeacherID)
            Display()
        End If

    End Sub

    Private Sub ShowDetails()
        Dim detailForm As New TeacherDetail(teacher)
        detailForm.ShowDialog()
        detailForm.Dispose()
        Display()
    End Sub
    Private Sub EditClass()
        Panel2.Visible = True
        txtKhName.Texts = teacher.KhName
        txtEngName.Texts = teacher.EngName
        cbAddress.Text = teacher.Address
        txtPhone.Texts = teacher.Phone
        dtpDob.Value = teacher.DoB
        cbGender.SelectedIndex = cbGender.FindStringExact(teacher.Gender)
        txtEmail.Texts = teacher.Email
        picTeacher.ImageLocation = teacher.Picture
        btnEdit.Visible = True
        btnAddNew.Visible = False
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint
        startup = False
        GetCbAddress()
    End Sub

    Sub SearchData() Handles cbSearchAddress.SelectedIndexChanged, txtSearch._TextChanged
        If startup Then
            Return
        End If
        Dim query As String = "SELECT tblTeacher.ID, tblTeacher.KhName AS KhmerName, tblTeacher.engName AS EnglishName, tblTeacher.DOB AS DateOfBirth, 
                                tblTeacher.Address AS PlaceOfBirth, tblTeacher.Email, tblTeacher.Phone FROM tblTeacher
                                WHERE Address LIKE @address AND (ID Like @id AND (KhName Like @name OR engName Like @name));"
        Dim cmd As OleDbCommand = New OleDbCommand(query, teacher.GetConnection())
        Dim name As String = If(txtSearch.Texts.Trim() = "", "%", txtSearch.Texts.Trim() & "%")
        Dim id As String = If(IsNumeric(txtSearch.Texts.Trim()), txtSearch.Texts.Trim(), "%")
        Dim address As String = If(cbSearchAddress.SelectedIndex = cbSearchAddress.Items.Count - 1, "%", cbSearchAddress.SelectedItem.ToString())
        address = "%" & address & "%"
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)

        Dim dt As DataTable = teacher.ExecuteQuery(cmd)
        DataGridView1.DataSource = dt
        Regonize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
        txtSearch.Texts = ""
    End Sub
    Sub GetCbAddress()

        Dim SearchAddressData As ArrayList = teacher.GetAddressData()
        SearchAddressData.Add("គ្រប់ខេត្តទាំងអស់")
        cbSearchAddress.DataSource = SearchAddressData
        cbSearchAddress.SelectedIndex = cbSearchAddress.Items.Count - 1
        Dim addressData = teacher.GetAddressData()
        addressData.Add("ជ្រើសរើសខេត្ត")
        cbAddress.DataSource = addressData
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
    End Sub

    Private Sub cbSearchAddress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchAddress.SelectedIndexChanged
        SearchData()
    End Sub
End Class