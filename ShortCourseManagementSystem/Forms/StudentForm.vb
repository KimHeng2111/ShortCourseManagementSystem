Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class StudentForm
    Dim student As Student = New Student()
    Dim startup As Boolean = True ' To prevent initial search on form load
    Public Sub New()
        ' Constructor for StudentForm class
        InitializeComponent()
        picStudent.ImageLocation = Application.StartupPath & "\Images\defalutStudent.png"
    End Sub
    Private Sub Display()
        DataGridView1.DataSource = student.GetStudentData()
        Regonize()
    End Sub

    'Check User Input
    Private Function CheckField() As Boolean
        Dim khName As String = txtKhName.Texts.Trim()
        Dim engName As String = txtEngName.Texts.Trim()
        Dim address As String = cbAddress.Text.Trim()
        Dim phone As String = txtPhone.Texts.Trim()
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
        If student.DateOfBirth <> dtpDob.Value Then
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
            DataGridView1.Columns(0).Width = 75
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(1).HeaderText = "គោត្តនាម នាម"
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(2).HeaderText = "ឈ្មោះឡាតាំង"
            DataGridView1.Columns(3).Width = 75
            DataGridView1.Columns(3).HeaderText = "ភេទ"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).Width = 200
            DataGridView1.Columns(4).HeaderText = "ថ្ងៃខែឆ្នាំកំណើត"
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(5).HeaderText = "អាស័យដ្ឋាន"
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(6).Width = 200
            DataGridView1.Columns(6).HeaderText = "លេខទូរស័ព្ទ"
            DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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
        menu.Items.Add("កែប្រែ", Nothing, AddressOf EditClass)
        menu.Items.Add("លុប", Nothing, AddressOf DeleteCourse)
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
    Private Sub DeleteCourse()
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
    Private Sub EditClass()
        Panel2.Visible = True
        txtKhName.Texts = student.khName
        txtEngName.Texts = student.engName
        cbAddress.Text = student.address
        txtPhone.Texts = student.phone
        dtpDob.Value = student.DateOfBirth
        cbGender.SelectedIndex = cbGender.FindStringExact(student.gender)
        picStudent.ImageLocation = student.picture
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = False
        txtKhName.Texts = ""
        txtEngName.Texts = ""
        cbAddress.Text = ""
        txtPhone.Texts = ""
        dtpDob.Value = DateTime.Now
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If CheckField() Then

            student.UpdateStudent(student.id, txtKhName.Texts.Trim(), txtEngName.Texts.Trim(), cbGender.SelectedItem.ToString(), dtpDob.Value, cbAddress.Text.Trim(), txtPhone.Texts.Trim(), picStudent.ImageLocation)
            MessageBox.Show("ព័ត៌មានសិស្សបានកែប្រែដោយជោគជ័យ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Display()
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
                                WHERE Address LIKE @address AND (ID Like @id OR (KhName Like @name OR EngName Like @name));"
        Dim cmd As OleDbCommand = New OleDbCommand(query, student.GetConnection())
        Dim name As String = If(txtSearch.Texts.Trim() = "", "%", "%" & txtSearch.Texts.Trim() & "%")
        Dim id As String = If(IsNumeric(txtSearch.Texts.Trim()), txtSearch.Texts.Trim(), "%")
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
End Class