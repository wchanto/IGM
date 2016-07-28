Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGMDataSet.FIN_CuentasContables' table. You can move, or remove it, as needed.
        Me.FIN_CuentasContablesTableAdapter.Fill(Me.IGMDataSet.FIN_CuentasContables)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
