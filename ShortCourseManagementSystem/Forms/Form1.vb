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
        ViewInvoice.ReportSource = invoice
        invoice.SetParameterValue("PaymentID", register.payment.paymentID) ' Example parameter, replace with actual value
        invoice.SetParameterValue("khName", register.student.khName)
        invoice.SetParameterValue(2, register.student.engName) ' Example parameter, replace with actual value)
        invoice.SetParameterValue(3, register.student.address)
        invoice.SetParameterValue(4, register.student.phone)
        invoice.SetParameterValue(7, register.registerID)
        invoice.SetParameterValue(9, register.manageClass.course.courseName)
        invoice.SetParameterValue(8, register.manageClass.course.basePrice)
        invoice.SetParameterValue(5, register.payment.amount)
        invoice.SetParameterValue(6, register.payment.unpaid)
        invoice.SetParameterValue(10, register.manageClass.startDate)
        ViewInvoice.Refresh()

    End Sub
End Class