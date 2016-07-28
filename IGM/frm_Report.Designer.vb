<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.FIN_CuentasContablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IGMDataSet = New IGM.IGMDataSet()
        Me.FIN_TipoCuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FIN_CuentasContablesTableAdapter = New IGM.IGMDataSetTableAdapters.FIN_CuentasContablesTableAdapter()
        Me.FIN_TipoCuentaTableAdapter = New IGM.IGMDataSetTableAdapters.FIN_TipoCuentaTableAdapter()
        CType(Me.FIN_CuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IGMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIN_TipoCuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FIN_CuentasContablesBindingSource
        '
        Me.FIN_CuentasContablesBindingSource.DataMember = "FIN_CuentasContables"
        Me.FIN_CuentasContablesBindingSource.DataSource = Me.IGMDataSet
        '
        'IGMDataSet
        '
        Me.IGMDataSet.DataSetName = "IGMDataSet"
        Me.IGMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FIN_TipoCuentaBindingSource
        '
        Me.FIN_TipoCuentaBindingSource.DataMember = "FIN_TipoCuenta"
        Me.FIN_TipoCuentaBindingSource.DataSource = Me.IGMDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AccessibleRole = System.Windows.Forms.AccessibleRole.Application
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.FIN_CuentasContablesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IGM.FIN_CatCuentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.ReportPath = "/FINCatalogoCuentas"
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://ocpinfings02/ReportServer", System.UriKind.Absolute)
        Me.ReportViewer1.Size = New System.Drawing.Size(451, 460)
        Me.ReportViewer1.TabIndex = 0
        '
        'FIN_CuentasContablesTableAdapter
        '
        Me.FIN_CuentasContablesTableAdapter.ClearBeforeFill = True
        '
        'FIN_TipoCuentaTableAdapter
        '
        Me.FIN_TipoCuentaTableAdapter.ClearBeforeFill = True
        '
        'frm_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 459)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_Report"
        Me.ShowIcon = False
        Me.Text = "Reporte "
        CType(Me.FIN_CuentasContablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IGMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIN_TipoCuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FIN_CuentasContablesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IGMDataSet As IGM.IGMDataSet
    Friend WithEvents FIN_CuentasContablesTableAdapter As IGM.IGMDataSetTableAdapters.FIN_CuentasContablesTableAdapter
    Friend WithEvents FIN_TipoCuentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIN_TipoCuentaTableAdapter As IGM.IGMDataSetTableAdapters.FIN_TipoCuentaTableAdapter
End Class
