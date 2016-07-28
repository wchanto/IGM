<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RHCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RHCargos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDel = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.TxCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbLabor = New System.Windows.Forms.ComboBox()
        Me.cmbDepto = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbSalarioBase = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxProh = New System.Windows.Forms.TextBox()
        Me.TxDed = New System.Windows.Forms.TextBox()
        Me.txDisp = New System.Windows.Forms.TextBox()
        Me.DGCargos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnDel, Me.btnUndo, Me.btnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(189, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(181, 25)
        Me.ToolStrip1.TabIndex = 123
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(23, 22)
        Me.btnAdd.Text = "Nuevo"
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(23, 22)
        Me.btnEdit.Text = "Editar"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Grabar"
        '
        'btnDel
        '
        Me.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(23, 22)
        Me.btnDel.Text = "Eliminar "
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Enabled = False
        Me.btnUndo.Image = CType(resources.GetObject("btnUndo.Image"), System.Drawing.Image)
        Me.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(23, 22)
        Me.btnUndo.Text = "Deshacer"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Imprimir"
        '
        'TxNombre
        '
        Me.TxNombre.Enabled = False
        Me.TxNombre.Location = New System.Drawing.Point(104, 37)
        Me.TxNombre.MaxLength = 40
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(380, 20)
        Me.TxNombre.TabIndex = 127
        '
        'TxCod
        '
        Me.TxCod.Enabled = False
        Me.TxCod.Location = New System.Drawing.Point(104, 11)
        Me.TxCod.MaxLength = 11
        Me.TxCod.Name = "TxCod"
        Me.TxCod.Size = New System.Drawing.Size(82, 20)
        Me.TxCod.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Puesto"
        '
        'cmbLabor
        '
        Me.cmbLabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLabor.Enabled = False
        Me.cmbLabor.FormattingEnabled = True
        Me.cmbLabor.Location = New System.Drawing.Point(104, 64)
        Me.cmbLabor.Name = "cmbLabor"
        Me.cmbLabor.Size = New System.Drawing.Size(380, 21)
        Me.cmbLabor.TabIndex = 129
        '
        'cmbDepto
        '
        Me.cmbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepto.Enabled = False
        Me.cmbDepto.FormattingEnabled = True
        Me.cmbDepto.Location = New System.Drawing.Point(104, 91)
        Me.cmbDepto.Name = "cmbDepto"
        Me.cmbDepto.Size = New System.Drawing.Size(380, 21)
        Me.cmbDepto.TabIndex = 131
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Departamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(567, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Salario Base"
        '
        'lbSalarioBase
        '
        Me.lbSalarioBase.AutoSize = True
        Me.lbSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSalarioBase.Location = New System.Drawing.Point(658, 37)
        Me.lbSalarioBase.Name = "lbSalarioBase"
        Me.lbSalarioBase.Size = New System.Drawing.Size(2, 15)
        Me.lbSalarioBase.TabIndex = 133
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(567, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "% Prohibición"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(566, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "% Dedicación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(566, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "% Disponibilidad"
        '
        'TxProh
        '
        Me.TxProh.Enabled = False
        Me.TxProh.Location = New System.Drawing.Point(658, 62)
        Me.TxProh.MaxLength = 11
        Me.TxProh.Name = "TxProh"
        Me.TxProh.Size = New System.Drawing.Size(66, 20)
        Me.TxProh.TabIndex = 137
        '
        'TxDed
        '
        Me.TxDed.Enabled = False
        Me.TxDed.Location = New System.Drawing.Point(658, 88)
        Me.TxDed.MaxLength = 11
        Me.TxDed.Name = "TxDed"
        Me.TxDed.Size = New System.Drawing.Size(66, 20)
        Me.TxDed.TabIndex = 138
        '
        'txDisp
        '
        Me.txDisp.Enabled = False
        Me.txDisp.Location = New System.Drawing.Point(658, 114)
        Me.txDisp.MaxLength = 11
        Me.txDisp.Name = "txDisp"
        Me.txDisp.Size = New System.Drawing.Size(66, 20)
        Me.txDisp.TabIndex = 139
        '
        'DGCargos
        '
        Me.DGCargos.AllowUserToAddRows = False
        Me.DGCargos.AllowUserToDeleteRows = False
        Me.DGCargos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCargos.Location = New System.Drawing.Point(12, 154)
        Me.DGCargos.MultiSelect = False
        Me.DGCargos.Name = "DGCargos"
        Me.DGCargos.ReadOnly = True
        Me.DGCargos.RowHeadersVisible = False
        Me.DGCargos.Size = New System.Drawing.Size(895, 365)
        Me.DGCargos.TabIndex = 140
        '
        'frm_RHCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 531)
        Me.Controls.Add(Me.DGCargos)
        Me.Controls.Add(Me.txDisp)
        Me.Controls.Add(Me.TxDed)
        Me.Controls.Add(Me.TxProh)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbSalarioBase)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbDepto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbLabor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxNombre)
        Me.Controls.Add(Me.TxCod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_RHCargos"
        Me.Text = "Cargos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGCargos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLabor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepto As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbSalarioBase As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxProh As System.Windows.Forms.TextBox
    Friend WithEvents TxDed As System.Windows.Forms.TextBox
    Friend WithEvents txDisp As System.Windows.Forms.TextBox
    Friend WithEvents DGCargos As System.Windows.Forms.DataGridView
End Class
