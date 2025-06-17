Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class ReportForm
    Dim report As New Report()
    Private Sub CrsReport_Load(sender As Object, e As EventArgs)
        crsReport.PrintMode = PrintMode.
    End Sub

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

        End If
    End Sub
    Sub TeacherReport()
        Dim teacherReport As New TeacherReport()
        teacherReport.Database.Tables("tblTeacherReport").SetDataSource(report.GetTeacherReport())
        crsReport.ReportSource = teacherReport
    End Sub
    Sub StudentReport()
        Dim studentReport As New StudentReport()
        studentReport.Database.Tables("tblStudentReport").SetDataSource(report.GetStudentReport())
        crsReport.ReportSource = studentReport
    End Sub

End Class