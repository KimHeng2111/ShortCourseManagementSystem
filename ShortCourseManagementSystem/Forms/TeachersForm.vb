Imports System.Data.OleDb
Imports System.IO

Public Class TeachersForm
    Dim teacher As Teacher = New Teacher()
    Dim startup As Boolean = True
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    'Display all teachers in DataGridView
    Sub Display()
        DataGridView1.DataSource = teacher.GetTeacherData()
        Regonize()
    End Sub

    'Check User Input
    Private Function CheckField() As Boolean
        Dim khName As String = txtKhName.Text
        Dim engName As String = txtEngName.Text.Trim()
        Dim Gender As String = cbGender.Text
        Dim DoB As Date = Convert.ToDateTime(dtpDob.Text.Trim())
        Dim Address As String = cbAddress.Text.Trim()
        Dim Phone As String = txtPhone.Text.Trim()
        Dim Email As String = txtEmail.Text.Trim()
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

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.CellClick
        If btnEdit.Visible = False Then
            Return
        End If
        Dim teacterID As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        teacher.GetTeacherByID(teacterID)
        txtKhName.Text = teacher.KhName
        txtEngName.Text = teacher.EngName
        cbAddress.SelectedIndex = cbAddress.FindStringExact(teacher.Address)
        dtpDob.Text = teacher.DoB.ToString("dd/MM/yyyy")
        txtPhone.Text = teacher.Phone
        cbGender.Text = teacher.Gender
        txtEmail.Text = teacher.Email
        If Not String.IsNullOrEmpty(teacher.Picture) Then
            picTeacher.ImageLocation = teacher.Picture
        Else
            picTeacher.ImageLocation = Application.StartupPath & "\Images\default.png"
        End If
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
            With DataGridView1
                .Columns(0).HeaderText = "លេខកូដ"
                .Columns(0).Width = 100
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(0).DefaultCellStyle.Format = "000"
                .Columns(1).Width = 250
                .Columns(1).HeaderText = "គោត្តនាម នាម"
                .Columns(2).Width = 250
                .Columns(2).HeaderText = "ឈ្មោះឡាតាំង"
                .Columns(3).Width = 200
                .Columns(3).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).Width = 200
                .Columns(4).HeaderText = "អាស័យដ្ឋាន"
                .Columns(5).Width = 250
                .Columns(5).HeaderText = "Email"
                .Columns(6).Width = 200
                .Columns(6).HeaderText = "លេខទូរស័ព្ទ"
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If i Mod 2 = 1 Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(254, 254, 254) ' Alternate row color
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(245, 250, 253)
                End If
                For Each col As DataGridViewColumn In DataGridView1.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next
            Next i
        End If
        DataGridView1.ClearSelection()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel2.Visible = True
        picTeacher.ImageLocation = Application.StartupPath & "\Images\default.png"
        btnAddNew.Visible = True
        btnEdit.Visible = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not CheckField() Then
            Return
        End If
        Dim count = 0
        If txtKhName.Text <> teacher.KhName Then
            count += 1
        End If
        If txtEngName.Text <> teacher.EngName Then
            count += 1
        End If
        If Convert.ToDateTime(dtpDob.Text) <> teacher.DoB Then
            count += 1
        End If
        If cbAddress.Text <> teacher.Address Then
            count += 1
        End If
        If txtPhone.Text <> teacher.Phone Then
            count += 1
        End If
        If cbGender.Text <> teacher.Gender Then
            count += 1
        End If
        If txtEmail.Text <> teacher.Email Then
            count += 1
        End If
        If count = 0 Then
            MessageBox.Show("មិនមានការផ្លាស់ប្តូរទេ។", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        teacher.KhName = txtKhName.Text
        teacher.EngName = txtEngName.Text.Trim()
        teacher.DoB = Convert.ToDateTime(dtpDob.Text)
        teacher.Address = cbAddress.Text.Trim()
        teacher.Phone = txtPhone.Text.Trim()
        teacher.Gender = cbGender.Text
        teacher.Email = txtEmail.Text.Trim()
        teacher.Picture = picTeacher.ImageLocation
        teacher.UpdateTeacher()
        Display()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        If Not CheckField() Then
            Return
        Else
            teacher.KhName = txtKhName.Text
            teacher.EngName = txtEngName.Text.Trim()
            teacher.DoB = Convert.ToDateTime(dtpDob.Text)
            teacher.Address = cbAddress.Text
            teacher.Phone = txtPhone.Text.Trim()
            teacher.Gender = cbGender.Text
            teacher.Email = txtEmail.Text.Trim()
            teacher.Picture = SaveImageAndReturnPath()
            teacher.AddTeacher()
        End If
        Display()
    End Sub
    Function SaveImageAndReturnPath() As String
        If Path.GetFileName(picTeacher.ImageLocation) = "default.png" Then
            Return picTeacher.ImageLocation
        End If

        Dim source As String = picTeacher.ImageLocation
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
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel2.Visible = False
        txtKhName.Text = ""
        txtEngName.Text = ""
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
        txtPhone.Text = ""
        txtEmail.Text = ""
        cbGender.SelectedText = cbGender.Items.Count - 1
        dtpDob.Text = DateTime.Now().ToString("dd/MM/yyyy")
        picTeacher.ImageLocation = Application.StartupPath & "\Images\default.png"
        btnAddNew.Visible = False
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim menu As New ContextMenuStrip()
        menu.Font = New Font("Khmer OS System", 11)
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
        txtKhName.Text = teacher.KhName
        txtEngName.Text = teacher.EngName
        cbAddress.SelectedIndex = cbAddress.FindStringExact(teacher.Address)
        txtPhone.Text = teacher.Phone
        dtpDob.Text = teacher.DoB.ToString("dd/MM/yyyy")
        cbGender.SelectedIndex = cbGender.FindStringExact(teacher.Gender)
        txtEmail.Text = teacher.Email
        picTeacher.ImageLocation = teacher.Picture
        btnEdit.Visible = True
        btnAddNew.Visible = False
    End Sub


    Sub SearchData() Handles cbSearchAddress.SelectedIndexChanged, txtSearch.TextChanged
        If startup Then
            Return
        End If
        Dim query As String = "SELECT tblTeacher.ID, tblTeacher.KhName AS KhmerName, tblTeacher.EngName AS EnglishName, tblTeacher.DOB AS DateOfBirth, 
                                tblTeacher.Address AS PlaceOfBirth, tblTeacher.Email, tblTeacher.Phone FROM tblTeacher
                                WHERE Address LIKE @address AND (ID Like @id OR (KhName Like @name OR engName Like @name));"
        Dim cmd As OleDbCommand = New OleDbCommand(query, teacher.GetConnection())
        Dim name As String = If(txtSearch.Text.Trim() = "", "%", txtSearch.Text.Trim() & "%")
        Dim id As String = If(IsNumeric(txtSearch.Text.Trim()), txtSearch.Text.Trim() & "%", "0")
        Dim address As String = If(cbSearchAddress.SelectedIndex = cbSearchAddress.Items.Count - 1, "%", cbSearchAddress.SelectedItem.ToString())
        address = "%" & address & "%"
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        Dim dt As DataTable = teacher.ExecuteQuery(cmd)
        DataGridView1.DataSource = dt
        Regonize()
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
        txtSearch.Text = ""
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel2.Visible = True
    End Sub

    Private Sub Panel9_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

        startup = False
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        Display()
        GetCbAddress()
    End Sub
End Class