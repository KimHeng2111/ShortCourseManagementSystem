Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine

Public Class Form1
    Dim register As New Register()
    Public Sub New(reg As Register)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        register = reg
    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles ViewInvoice.Load
        Dim invoice As New Invoice()
        invoice.SetParameterValue("PaymentID", register.payment.paymentID) ' Example parameter, replace with actual value
        invoice.SetParameterValue("khName", register.student.khName)
        invoice.SetParameterValue("EngName", register.student.engName) ' Example parameter, replace with actual value)
        invoice.SetParameterValue("Address", register.student.address)
        invoice.SetParameterValue("Phone", register.student.phone)
        invoice.SetParameterValue("registerID", register.registerID)
        invoice.SetParameterValue("Course", register.manageClass.course.courseName)
        invoice.SetParameterValue("CoursePrice", register.manageClass.course.basePrice)
        invoice.SetParameterValue("Amount", register.payment.amount)
        invoice.SetParameterValue("Unpaid", register.payment.unpaid)
        ViewInvoice.ReportSource = invoice
        Dim invName As String = "Invoice_" & register.registerID & ".pdf"
        Dim path As String = Application.StartupPath & "\Invoices\" & invName

    End Sub
End Class