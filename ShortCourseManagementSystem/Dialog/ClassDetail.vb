Imports System.Data.OleDb
Public Class ClassDetail
    Dim classDetail As New ManageClass()
    Public Sub New(classDetail As ManageClass)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.classDetail = classDetail
        FillClassDetails()

    End Sub
    Sub FillClassDetails()
        txtID.Text = classDetail.classID
        txtCourse.Text = classDetail.course.courseName
        txtTeacher.Text = classDetail.teacher.KhName
        txtStartDate.Text = classDetail.startDate.ToString("dd/MM/yyyy")
        txtEndDate.Text = classDetail.endDate.ToString("dd/MM/yyyy")
        txtRoom.Text = classDetail.GetRoomByID()
        txtSchedule.Text = classDetail.GetScheduleByID()
        txtTotal.Text = classDetail.GetCurrentEnrollments().ToString()
        txtStatus.Text = classDetail.GetStatusByID()
    End Sub
    Sub GetData()
        Dim query As String = "SELECT tblStudent.ID, tblStudent.KhName, tblStudent.Phone, tblStudent.Address, tblPaymentStatus.Status
            FROM (tblPaymentStatus INNER JOIN tblPayment ON tblPaymentStatus.ID = tblPayment.StatusID) INNER JOIN (tblStudent INNER JOIN tblRegister ON tblStudent.ID = tblRegister.StudentID) ON tblPayment.ID = tblRegister.PaymentID
            WHERE (((tblRegister.ClassID)=" & classDetail.classID & "));"
        Dim dt As DataTable = classDetail.ExecuteQuery(query)
        DataGridView1.DataSource = dt
        Regonize()
    End Sub
    Sub Regonize()
        If DataGridView1.Columns.Count = 6 Then
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(0).HeaderText = "StudentID"
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(1).HeaderText = "ឈ្មោះ"
            DataGridView1.Columns(2).Width = 250
            DataGridView1.Columns(2).HeaderText = "Email"
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(3).HeaderText = "លេខទូរស័ព្ទ"
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).Width = 200
            DataGridView1.Columns(4).HeaderText = "អាស័យដ្ឋាន"
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(5).HeaderText = "ស្ថានភាពបង់ប្រាក់"
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If i Mod 2 = 1 Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(150, 203, 175) ' Alternate row color
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(235, 255, 255)
                End If
            Next i
        End If
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        GetData()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnCancel.Visible = True
        btnSave.Visible = True
        btnUpdate.Visible = False
        cbStatus.Visible = True
        dtpEndDate.Visible = True
        txtEndDate.Visible = False
        txtStatus.Visible = False
        FillData()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCancel.Visible = False
        btnSave.Visible = False
        btnUpdate.Visible = True
        cbStatus.Visible = False
        dtpEndDate.Visible = False
        txtEndDate.Visible = True
        txtStatus.Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String = "UPDATE tblClass 
            SET StatusID = @StatusID, EndDate = @EndDate 
            WHERE ClassID = @ClassID;"
        Dim cmd As OleDbCommand = New OleDbCommand(query, classDetail.GetConnection())
        cmd.Parameters.AddWithValue("@StatusID", Convert.ToInt32(cbStatus.SelectedValue))
        cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date)
        cmd.Parameters.AddWithValue("@ClassID", Convert.ToInt32(classDetail.classID))
        classDetail.ExecuteNonQuery(cmd)
        MessageBox.Show("ថ្នាក់រៀន ត្រូវបានធ្វើបច្ចុប្បន្នភាពដោយជោគជ័យ!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnCancel.PerformClick()
        classDetail.StatusID = cbStatus.SelectedValue
        classDetail.endDate = dtpEndDate.Value.Date
        txtStatus.Text = classDetail.GetStatusByID()
        txtEndDate.Text = dtpEndDate.Value.ToString("dd/MM/yyyy")
    End Sub
    Sub FillData()
        Dim StatusList = classDetail.GetClassStatusList()
        cbStatus.DataSource = New BindingSource(StatusList, Nothing)
        cbStatus.DisplayMember = "Key"
        cbStatus.ValueMember = "Value"
        cbStatus.SelectedValue = classDetail.StatusID
        dtpEndDate.Value = classDetail.endDate
    End Sub
End Class