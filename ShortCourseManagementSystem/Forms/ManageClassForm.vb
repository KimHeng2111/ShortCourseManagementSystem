Public Class ManageClassForm
    Dim manageClass As ManageClass = New ManageClass()
    Public Sub New()
        ' Constructor for ManageClassForm class
        InitializeComponent()
        display()
    End Sub
    Private Sub display()
        DataGridView2.DataSource = manageClass.GetClassData()
    End Sub
End Class