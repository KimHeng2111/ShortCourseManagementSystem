Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.[Shared]

Public Class Form1
    Dim rdReport As New ReportDocument
    Dim register As New Register()
    Public Sub New(reg As Register)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        register = reg
        rdReport.Load("Report\Invoice.rpt")
        rdReport.SetParameterValue("PaymentID", register.payment.paymentID) ' Example parameter, replace with actual value
        rdReport.SetParameterValue("khName", register.student.khName)
        rdReport.SetParameterValue(2, register.student.engName) ' Example parameter, replace with actual value)
        rdReport.SetParameterValue(3, register.student.address)
        rdReport.SetParameterValue(4, register.student.phone)
        rdReport.SetParameterValue(7, register.registerID)
        rdReport.SetParameterValue(9, register.manageClass.course.courseName)
        rdReport.SetParameterValue(8, register.manageClass.course.basePrice)
        rdReport.SetParameterValue(5, register.payment.amount)
        rdReport.SetParameterValue(6, register.payment.unpaid)
        rdReport.SetParameterValue(10, register.manageClass.startDate)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        'Dim exportOption As ExportOptions
        'Dim diskFileDestinationOptions As New DiskFileDestinationOptions()

        'Dim sfd As New SaveFileDialog()
        'sfd.Filter = "Pdf Files|*.pdf"
        'sfd.FileName = "Invoice00" + register.registerID
        'If sfd.ShowDialog() = DialogResult.OK Then
        '    diskFileDestinationOptions.DiskFileName = sfd.FileName
        'Else
        '    Return
        'End If
        'exportOption = rdReport.ExportOptions
        'exportOption.ExportDestinationType = ExportDestinationType.DiskFile
        'exportOption.ExportFormatType = ExportFormatType.PortableDocFormat
        'exportOption.ExportDestinationOptions = diskFileDestinationOptions
        'exportOption.FormatOptions = New PdfRtfWordFormatOptions()
        'rdReport.Export()
    End Sub

    Private Sub ViewInvoice_Load(sender As Object, e As EventArgs) Handles ViewInvoice.Load
        ViewInvoice.ReportSource = rdReport
    End Sub
End Class