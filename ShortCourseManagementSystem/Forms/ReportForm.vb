Imports System.Drawing.Printing
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports Org.BouncyCastle.Asn1

Public Class ReportForm
    Dim report As New Report()
    Dim reportDocument As New ReportDocument
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReport.SelectedIndexChanged
        If cbReport.SelectedIndex = cbReport.Items.Count - 1 Then
            crsReport.ReportSource = Nothing
            Return
        ElseIf cbReport.SelectedIndex = 0 Then
            StudentReport()
        ElseIf cbReport.SelectedIndex = 1 Then
            TeacherReport()
        ElseIf cbReport.SelectedIndex = 2 Then
            CourseReport()
        ElseIf cbReport.SelectedIndex = 3 Then
            SubjectReport()
        ElseIf cbReport.SelectedIndex = 4 Then
            PaymentReport()
        End If
    End Sub
    Sub TeacherReport()
        reportDocument.Load(Application.StartupPath & "\Report\TeacherReport.rpt")
        reportDocument.Database.Tables("tblTeacherReport").SetDataSource(report.GetTeacherReport())
        crsReport.ReportSource = reportDocument
    End Sub
    Sub StudentReport()
        reportDocument.Load(Application.StartupPath & "\Report\StudentReport.rpt")
        reportDocument.Database.Tables("tblStudentReport").SetDataSource(report.GetStudentReport())
        crsReport.ReportSource = reportDocument
    End Sub
    Sub CourseReport()
        reportDocument.Load(Application.StartupPath & "\Report\CourseReport.rpt")
        reportDocument.Database.Tables("tblCourseReport").SetDataSource(report.GetCourseReport())
        crsReport.ReportSource = reportDocument
    End Sub
    Sub SubjectReport()
        reportDocument.Load(Application.StartupPath & "\Report\SubjectReport.rpt")
        reportDocument.Database.Tables("tblSubjectReport").SetDataSource(report.GetSubjectReport())
        crsReport.ReportSource = reportDocument
    End Sub
    Sub PaymentReport()
        reportDocument.Load(Application.StartupPath & "\Report\PaymentReport.rpt")
        reportDocument.Database.Tables("tblPaymentReport").SetDataSource(report.GetPaymentReport())
        crsReport.ReportSource = reportDocument
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If cbReport.SelectedIndex = cbReport.Items.Count - 1 Then
            MessageBox.Show("សូមជ្រើសរើរបាយការណ៍ជាមុនសិន!!!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            Dim dlg As New PrintDialog()
            dlg.AllowSomePages = True
            dlg.PrinterSettings = New PrinterSettings()
            If dlg.ShowDialog() = DialogResult.OK Then
                reportDocument.PrintOptions.PrinterName = dlg.PrinterSettings.PrinterName
                reportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                reportDocument.PrintOptions.PaperOrientation = PaperOrientation.Landscape
                reportDocument.PrintToPrinter(dlg.PrinterSettings.Copies, False, 0, 0)
            End If
        Catch ex As Exception
            MessageBox.Show("របាយការណ៍័មិនអាច")
        End Try

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If cbReport.SelectedIndex = cbReport.Items.Count - 1 Then
            MessageBox.Show("សូមជ្រើសរើសរបាយការណ៍!!!!", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim exportOption As ExportOptions
        Dim diskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim exportPath As String = Application.StartupPath & "\Export\Report"
        If Not Directory.Exists(exportPath) Then
            Directory.CreateDirectory(exportPath)
        End If
        Dim sfd As New SaveFileDialog()
        sfd.InitialDirectory = exportPath
        sfd.Filter = "PDF Files|*.pdf|Excel Files|*.xls"
        sfd.FileName = cbReport.Text & "_" & DateTime.Now().ToString("dd-MM-yyyy")

        If sfd.ShowDialog() = DialogResult.OK Then
            diskFileDestinationOptions.DiskFileName = sfd.FileName
        Else
            Return
        End If

        exportOption = reportDocument.ExportOptions
        exportOption.ExportDestinationType = ExportDestinationType.DiskFile
        exportOption.ExportDestinationOptions = diskFileDestinationOptions

        Select Case Path.GetExtension(sfd.FileName).ToLower()
            Case ".pdf"
                exportOption.ExportFormatType = ExportFormatType.PortableDocFormat
                exportOption.FormatOptions = New PdfRtfWordFormatOptions()
            Case ".xls"
                exportOption.ExportFormatType = ExportFormatType.Excel
                exportOption.FormatOptions = New ExcelFormatOptions() With {
            .ExcelUseConstantColumnWidth = True
        }
            Case ".html"
                exportOption.ExportFormatType = ExportFormatType.HTML40
                exportOption.FormatOptions = New HTMLFormatOptions() With {
            .HTMLBaseFolderName = Path.GetDirectoryName(sfd.FileName),
            .HTMLFileName = Path.GetFileName(sfd.FileName)
        }
            Case Else
                MessageBox.Show("Unsupported export format.")
                Return
        End Select

        reportDocument.Export()
        Process.Start(sfd.FileName)

    End Sub
End Class