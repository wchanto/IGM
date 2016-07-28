Imports Microsoft.Reporting.WinForms

Public Class frm_Report

    Private Sub frm_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IGMDataSet.FIN_TipoCuenta' table. You can move, or remove it, as needed.
        Me.FIN_TipoCuentaTableAdapter.Fill(Me.IGMDataSet.FIN_TipoCuenta)

        Try


            'Dim myCred As New Net.NetworkCredential("wrodriguez", "wrc$$ti", "automercados")

            'ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred

            ReportViewer1.ServerReport.ReportServerUrl = New Uri("http://localhost/ReportServer/")
            ReportViewer1.ServerReport.ReportPath = "/FINCatalogoCuentas"


            '---------------------------------------------------------------------------
            ''Dim total As Integer = Me.ReportViewer1.ServerReport.GetDataSources().Count
            ' Creo un array de DataSourceCredentials con el total 
            ' de DataSources que tiene el informe.
            ''Dim permisos(total) As DataSourceCredentials
            ' Obtengo los datasources del informe.
            ''Dim datasources As ReportDataSourceInfoCollection = Me.ReportViewer1.ServerReport.GetDataSources()
            ' Ahora por cada fuente de datos, le asignaremos al array de credenciales
            ' el nombre, userid y password.
            ''For i As Integer = 0 To total - 1
            '' permisos(i).Name = datasources(i).Name
            '' permisos(i).UserId = "sa"
            '' permisos(i).Password = "$$soporte"
            ''Next
            '---------------------------------------------------------------------------



            ReportViewer1.RefreshReport()


            'ReportViewer1.ServerReport.SetDataSourceCredentials(cred)

            Me.FIN_CuentasContablesTableAdapter.Fill(Me.IGMDataSet.FIN_CuentasContables)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class