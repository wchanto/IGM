<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RHTiposDeduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RHTiposDeduccion))
        Me.chkDist = New System.Windows.Forms.CheckBox()
        Me.chkEmbargo = New System.Windows.Forms.CheckBox()
        Me.TxDescrip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDel = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.TxCod = New System.Windows.Forms.TextBox()
        Me.DGTDed = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxCta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OptFija = New System.Windows.Forms.RadioButton()
        Me.optPorc = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGTDed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkDist
        '
        Me.chkDist.AutoSize = True
        Me.chkDist.Enabled = False
        Me.chkDist.Location = New System.Drawing.Point(231, 122)
        Me.chkDist.Name = "chkDist"
        Me.chkDist.Size = New System.Drawing.Size(66, 17)
        Me.chkDist.TabIndex = 143
        Me.chkDist.Text = "Distribuir"
        Me.chkDist.UseVisualStyleBackColor = True
        '
        'chkEmbargo
        '
        Me.chkEmbargo.AutoSize = True
        Me.chkEmbargo.Enabled = False
        Me.chkEmbargo.Location = New System.Drawing.Point(123, 122)
        Me.chkEmbargo.Name = "chkEmbargo"
        Me.chkEmbargo.Size = New System.Drawing.Size(83, 17)
        Me.chkEmbargo.TabIndex = 142
        Me.chkEmbargo.Text = "Es Embargo"
        Me.chkEmbargo.UseVisualStyleBackColor = True
        '
        'TxDescrip
        '
        Me.TxDescrip.Enabled = False
        Me.TxDescrip.Location = New System.Drawing.Point(123, 38)
        Me.TxDescrip.MaxLength = 50
        Me.TxDescrip.Name = "TxDescrip"
        Me.TxDescrip.Size = New System.Drawing.Size(490, 20)
        Me.TxDescrip.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Descripcion"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnDel, Me.btnUndo, Me.btnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(218, 12)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(181, 25)
        Me.ToolStrip1.TabIndex = 139
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
        'TxCod
        '
        Me.TxCod.Enabled = False
        Me.TxCod.Location = New System.Drawing.Point(123, 12)
        Me.TxCod.MaxLength = 10
        Me.TxCod.Name = "TxCod"
        Me.TxCod.Size = New System.Drawing.Size(103, 20)
        Me.TxCod.TabIndex = 137
        '
        'DGTDed
        '
        Me.DGTDed.AllowUserToAddRows = False
        Me.DGTDed.AllowUserToDeleteRows = False
        Me.DGTDed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTDed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTDed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTDed.Location = New System.Drawing.Point(14, 157)
        Me.DGTDed.MultiSelect = False
        Me.DGTDed.Name = "DGTDed"
        Me.DGTDed.ReadOnly = True
        Me.DGTDed.RowHeadersVisible = False
        Me.DGTDed.Size = New System.Drawing.Size(852, 323)
        Me.DGTDed.TabIndex = 138
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Codigo"
        '
        'TxCta
        '
        Me.TxCta.Enabled = False
        Me.TxCta.Location = New System.Drawing.Point(123, 64)
        Me.TxCta.MaxLength = 50
        Me.TxCta.Name = "TxCta"
        Me.TxCta.Size = New System.Drawing.Size(490, 20)
        Me.TxCta.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Cod, Ctas por Pagar"
        '
        'OptFija
        '
        Me.OptFija.AutoSize = True
        Me.OptFija.Checked = True
        Me.OptFija.Enabled = False
        Me.OptFija.Location = New System.Drawing.Point(126, 90)
        Me.OptFija.Name = "OptFija"
        Me.OptFija.Size = New System.Drawing.Size(41, 17)
        Me.OptFija.TabIndex = 146
        Me.OptFija.TabStop = True
        Me.OptFija.Text = "Fija"
        Me.OptFija.UseVisualStyleBackColor = True
        '
        'optPorc
        '
        Me.optPorc.AutoSize = True
        Me.optPorc.Enabled = False
        Me.optPorc.Location = New System.Drawing.Point(173, 90)
        Me.optPorc.Name = "optPorc"
        Me.optPorc.Size = New System.Drawing.Size(76, 17)
        Me.optPorc.TabIndex = 147
        Me.optPorc.Text = "Porcentual"
        Me.optPorc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Tipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Indicadores"
        '
        'frm_RHTiposDeduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 492)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.optPorc)
        Me.Controls.Add(Me.OptFija)
        Me.Controls.Add(Me.TxCta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkDist)
        Me.Controls.Add(Me.chkEmbargo)
        Me.Controls.Add(Me.TxDescrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TxCod)
        Me.Controls.Add(Me.DGTDed)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_RHTiposDeduccion"
        Me.Text = "Tipos de Deduccion"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGTDed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkDist As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmbargo As System.Windows.Forms.CheckBox
    Friend WithEvents TxDescrip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxCod As System.Windows.Forms.TextBox
    Friend WithEvents DGTDed As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxCta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OptFija As System.Windows.Forms.RadioButton
    Friend WithEvents optPorc As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
