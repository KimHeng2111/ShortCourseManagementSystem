Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StudentForm
    Dim student As Student = New Student()
    Dim startup As Boolean = True ' To prevent initial search on form load
    Public Sub New()
        ' Constructor for StudentForm class
        InitializeComponent()
        picStudent.ImageLocation = Application.StartupPath & "\Images\default.png"
        GetCbAddress()
    End Sub
    Private Sub Display()
        DataGridView1.DataSource = student.GetStudentData()
        Regonize()
    End Sub

    'Check User Input
    Private Function CheckField() As Boolean
        Dim khName As String = txtKhName.Text.Trim()
        Dim engName As String = txtEngName.Text.Trim()
        Dim address As String = cbAddress.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        If String.IsNullOrEmpty(khName) Then
            MessageBox.Show("សូ​មបញ្ជូលឈ្មោះសិស្ស", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(engName) Then
            MessageBox.Show("សូ​មបញ្ជូលឈ្មោះឡាតាំង", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(address) Then
            MessageBox.Show("សូមបញ្ជូលអាសស័យដ្ឋាន", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If String.IsNullOrEmpty(phone) Then
            MessageBox.Show("សូមបញ្ជូលលេខទូរស័ព្ទ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Dim result As Boolean = True
        If Not IsNumeric(phone) Or phone.Length <= 8 Or phone.Length >= 11 Then
            MessageBox.Show("លេខទូរស័ព្ទត្រូវតែជាលេខ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        Dim count As Integer = 0
        If student.khName <> khName Then
            count += 1
        End If
        If student.engName <> engName Then
            count += 1
        End If
        If student.address <> address Then
            count += 1
        End If
        If student.phone <> phone Then
            count += 1
        End If
        If student.gender <> cbGender.Text Then
            count += 1
        End If
        If student.DateOfBirth <> Convert.ToDateTime(dtpDob.Text) Then
            count += 1
        End If
        If count = 0 Then
            MessageBox.Show("មិនមានការផ្លាស់ប្តូរទេ", "កែប្រែព័ត៌មានសិស្ស", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return result
    End Function
    Sub Regonize()
        If DataGridView1.Columns.Count = 7 Then
            With DataGridView1
                .Columns(0).Width = 75
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).Width = 250
                .Columns(1).HeaderText = "គោត្តនាម នាម"
                .Columns(2).Width = 200
                .Columns(2).HeaderText = "ឈ្មោះឡាតាំង"
                .Columns(3).Width = 75
                .Columns(3).HeaderText = "ភេទ"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).Width = 200
                .Columns(4).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(5).Width = 150
                .Columns(5).HeaderText = "អាស័យដ្ឋាន"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(6).Width = 200
                .Columns(6).HeaderText = "លេខទូរស័ព្ទ"
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
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

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim menu As New ContextMenuStrip()
        menu.Font = New Font("Khmer OS System", 9)
        menu.Items.Add("លម្អិត", Nothing, AddressOf ShowDetails)
        menu.Items.Add("កែប្រែ", Nothing, AddressOf EditStudent)
        menu.Items.Add("លុប", Nothing, AddressOf DeleteStudent)
        menu.Items(0).BackColor = Color.FromArgb(245, 250, 253)
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                Dim studentID As String = DataGridView1.Rows(hit.RowIndex).Cells(0).Value.ToString()
                student.GetStudentByID(Convert.ToInt32(studentID))
                menu.Show(DataGridView1, e.Location)
            End If
        End If
    End Sub
    Private Sub DeleteStudent()
        If DialogResult.Yes = MessageBox.Show("តើអ្នកពិតជាចង់លុប សិស្សឈ្មោះ" & student.khName & " នេះ មែនទេ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            student.DeleteStudent()
            Display()
        End If

    End Sub

    Private Sub ShowDetails()
        Dim detailForm As New StudentDetail(student)
        detailForm.ShowDialog()
        detailForm.Dispose()
        Display()
    End Sub
    Private Sub EditStudent()
        Panel2.Visible = True
        txtKhName.Text = student.khName
        txtEngName.Text = student.engName
        cbAddress.SelectedIndex = cbAddress.FindStringExact(student.address)
        txtPhone.Text = student.phone
        dtpDob.Text = student.DateOfBirth.ToString("dd/MM/yyyy")
        cbGender.SelectedIndex = cbGender.FindStringExact(student.gender)
        picStudent.ImageLocation = student.picture
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = False
        txtKhName.Text = ""
        txtEngName.Text = ""
        cbAddress.Text = ""
        txtPhone.Text = ""
        dtpDob.Text = DateTime.Now().ToString("dd/MM/yyyy")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If CheckField() Then

            student.UpdateStudent(student.id, txtKhName.Text.Trim(), txtEngName.Text.Trim(), cbGender.SelectedItem.ToString(), dtpDob.Text, cbAddress.Text.Trim(), txtPhone.Text.Trim(), picStudent.ImageLocation)
            MessageBox.Show("ព័ត៌មានសិស្សបានកែប្រែដោយជោគជ័យ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Display()
        End If
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
    Sub GetCbAddress()

        Dim SearchAddressData As ArrayList = student.GetAddressData()
        SearchAddressData.Add("គ្រប់ខេត្តទាំងអស់")
        cbSearchAddress.DataSource = SearchAddressData
        cbSearchAddress.SelectedIndex = cbSearchAddress.Items.Count - 1
        Dim addressData = student.GetAddressData()
        addressData.Add("ជ្រើសរើសខេត្ត")
        cbAddress.DataSource = addressData
        cbAddress.SelectedIndex = cbAddress.Items.Count - 1
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        GetCbAddress()
        startup = False
    End Sub
    Sub SearchData() Handles cbSearchAddress.SelectedIndexChanged, txtSearch._TextChanged
        If startup Then
            Return
        End If
        Dim query As String = "SELECT tblStudent.ID, tblStudent.KhName, tblStudent.EngName, tblStudent.Gender, 
                                tblStudent.DateOfBirth, tblStudent.Address, tblStudent.Phone FROM tblStudent
                                WHERE Address LIKE @address AND (ID Like @id AND (KhName Like @name OR EngName Like @name));"
        Dim cmd As OleDbCommand = New OleDbCommand(query, student.GetConnection())
        Dim id As String = If(IsNumeric(txtSearch.Texts.Trim()), txtSearch.Texts.Trim() & "%", "%")
        Dim name As String = If(txtSearch.Texts.Trim() = "", "%", If(IsNumeric(txtSearch.Texts.Trim()), "%", "%" & txtSearch.Texts.Trim() & "%"))
        Dim address As String = If(cbSearchAddress.SelectedIndex = cbSearchAddress.Items.Count - 1, "%", cbSearchAddress.SelectedItem.ToString())
        address = "%" & address & "%"
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        Dim dt As DataTable = student.ExecuteQuery(cmd)
        DataGridView1.DataSource = dt
        Regonize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtSearch.Texts = ""
        cbSearchAddress.SelectedIndex = cbSearchAddress.Items.Count - 1
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
End Class