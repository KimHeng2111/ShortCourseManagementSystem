<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ViewInvoice = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Invoice1 = New StudentManagementSystem.Invoice()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ViewInvoice
        '
        Me.ViewInvoice.ActiveViewIndex = -1
        Me.ViewInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ViewInvoice.Cursor = System.Windows.Forms.Cursors.Default
        Me.ViewInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewInvoice.Location = New System.Drawing.Point(0, 0)
        Me.ViewInvoice.Name = "ViewInvoice"
        Me.ViewInvoice.ShowCloseButton = False
        Me.ViewInvoice.ShowCopyButton = False
        Me.ViewInvoice.ShowExportButton = False
        Me.ViewInvoice.ShowGotoPageButton = False
        Me.ViewInvoice.ShowGroupTreeButton = False
        Me.ViewInvoice.ShowLogo = False
        Me.ViewInvoice.ShowPageNavigateButtons = False
        Me.ViewInvoice.ShowParameterPanelButton = False
        Me.ViewInvoice.ShowPrintButton = False
        Me.ViewInvoice.ShowRefreshButton = False
        Me.ViewInvoice.ShowTextSearchButton = False
        Me.ViewInvoice.ShowZoomButton = False
        Me.ViewInvoice.Size = New System.Drawing.Size(817, 846)
        Me.ViewInvoice.TabIndex = 0
        Me.ViewInvoice.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 846)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ViewInvoice)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InvoiceView"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewInvoice As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Invoice1 As Invoice
    Friend WithEvents btnPrint As Button
End Class
