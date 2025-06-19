Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
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
        Dim teacherReport As New TeacherReport()
        teacherReport.Database.Tables("tblTeacherReport").SetDataSource(report.GetTeacherReport())
        crsReport.ReportSource = teacherReport
        'reportDocument.Load(Application.StartupPath & "Report\TeacherReport.rpt")
        'reportDocument.Database.Tables("tblTeacherReport").SetDataSource(report.GetTeacherReport())
        'crsReport.ReportSource = reportDocument
    End Sub
    Sub StudentReport()
        Dim studentReport As New StudentReport()
        studentReport.Database.Tables("tblStudentReport").SetDataSource(report.GetStudentReport())
        crsReport.ReportSource = studentReport
    End Sub
    Sub CourseReport()
        Dim CourseReport As New CourseReport()
        CourseReport.Database.Tables("tblCourseReport").SetDataSource(report.GetCourseReport())
        crsReport.ReportSource = CourseReport
    End Sub
    Sub SubjectReport()
        Dim subjectReport As New SubjectReport()
        subjectReport.Database.Tables("tblSubjectReport").SetDataSource(report.GetSubjectReport())
        crsReport.ReportSource = subjectReport
    End Sub
    Sub PaymentReport()
        Dim paymentReport As New PaymentReport()
        paymentReport.Database.Tables("tblPaymentReport").SetDataSource(report.GetPaymentReport())
        crsReport.ReportSource = paymentReport
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
                reportDocument.PrintToPrinter(dlg.PrinterSettings.Copies, False, 0, 0)
                MessageBox.Show("របាយការណ៍ត្រូវបានPrintរួចរាល់!!!!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("របាយការណ៍័មិនអាច")
        End Try

    End Sub
End Class