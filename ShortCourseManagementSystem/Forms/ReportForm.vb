Imports CrystalDecisions.CrystalReports.Engine

Public Class ReportForm
    Dim report As New Report()
    Private Sub CrsReport_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReport.SelectedIndexChanged
        If cbReport.SelectedIndex = cbReport.Items.Count - 1 Then
            Return
        ElseIf cbReport.SelectedIndex = 1 Then
            TeacherReport()
        End If


    End Sub
    Sub TeacherReport()
        Dim teacherReport As New TeacherReport()
        teacherReport.Database.Tables("tblTeacherReport").SetDataSource(report.GetTeacherReport)
        crsReport.ReportSource = teacherReport

    End Sub
End Class