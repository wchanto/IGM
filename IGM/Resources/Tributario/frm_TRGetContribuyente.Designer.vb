<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TRGetContribuyente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TRGetContribuyente))
        Me.DGContrib = New System.Windows.Forms.DataGridView()
        Me.lbFiltro = New System.Windows.Forms.Label()
        Me.txFiltro = New System.Windows.Forms.TextBox()
        CType(Me.DGContrib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGContrib
        '
        Me.DGContrib.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGContrib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGContrib.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGContrib.Location = New System.Drawing.Point(12, 43)
        Me.DGContrib.Name = "DGContrib"
        Me.DGContrib.RowHeadersVisible = False
        Me.DGContrib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGContrib.ShowEditingIcon = False
        Me.DGContrib.Size = New System.Drawing.Size(661, 269)
        Me.DGContrib.TabIndex = 1
        '
        'lbFiltro
        '
        Me.lbFiltro.AutoSize = True
        Me.lbFiltro.Location = New System.Drawing.Point(13, 13)
        Me.lbFiltro.Name = "lbFiltro"
        Me.lbFiltro.Size = New System.Drawing.Size(32, 13)
        Me.lbFiltro.TabIndex = 1
        Me.lbFiltro.Text = "Filtrar"
        '
        'txFiltro
        '
        Me.txFiltro.Location = New System.Drawing.Point(51, 10)
        Me.txFiltro.Name = "txFiltro"
        Me.txFiltro.Size = New System.Drawing.Size(295, 20)
        Me.txFiltro.TabIndex = 0
        '
        'frm_TRGetContribuyente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 324)
        Me.Controls.Add(Me.txFiltro)
        Me.Controls.Add(Me.lbFiltro)
        Me.Controls.Add(Me.DGContrib)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_TRGetContribuyente"
        Me.Text = "Buscar Contribuyente"
        CType(Me.DGContrib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGContrib As System.Windows.Forms.DataGridView
    Friend WithEvents lbFiltro As System.Windows.Forms.Label
    Friend WithEvents txFiltro As System.Windows.Forms.TextBox
End Class
