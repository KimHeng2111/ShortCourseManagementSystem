Imports System.Data.OleDb
Public Class PaymentForm
    Dim conn As OleDbConnection
    Dim stuID, ClassID As Integer
    Dim cmd As OleDbCommand
    Public Sub New(conn As OleDbConnection, sutName As String, phone As String, email As String, course As String, price As String, dis As String, total As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.conn = conn
        ' Add any initialization after the InitializeComponent() call.
        lbName.Text = sutName
        lbPhone.Text = phone
        lbEmail.Text = email
        lbCourse.Text = course
        lbPrice.Text = price
        lbDis.Text = dis
        lbTotal.Text = total
        lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy")

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

    End Sub
    Sub GetStudentID(name As String)

    End Sub
End Class