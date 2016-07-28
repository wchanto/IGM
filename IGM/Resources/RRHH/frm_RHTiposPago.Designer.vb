<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RHTiposPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RHTiposPago))
        Me.ImagenesBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TxCod = New System.Windows.Forms.TextBox()
        Me.DGTPago = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxDescrip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFactor = New System.Windows.Forms.ComboBox()
        Me.txFactor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkDedFija = New System.Windows.Forms.CheckBox()
        Me.chkDedGen = New System.Windows.Forms.CheckBox()
        Me.chkDist = New System.Windows.Forms.CheckBox()
        Me.chkMov = New System.Windows.Forms.CheckBox()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDel = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGTPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenesBotones
        '
        Me.ImagenesBotones.ImageStream = CType(resources.GetObject("ImagenesBotones.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImagenesBotones.TransparentColor = System.Drawing.Color.Transparent
        Me.ImagenesBotones.Images.SetKeyName(0, "add.png")
        Me.ImagenesBotones.Images.SetKeyName(1, "page_edit.png")
        Me.ImagenesBotones.Images.SetKeyName(2, "save_as.png")
        Me.ImagenesBotones.Images.SetKeyName(3, "delete.png")
        Me.ImagenesBotones.Images.SetKeyName(4, "arrow_undo.png")
        Me.ImagenesBotones.Images.SetKeyName(5, "directory_listing.png")
        Me.ImagenesBotones.Images.SetKeyName(6, "door_out.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnDel, Me.btnUndo, Me.btnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(179, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(150, 25)
        Me.ToolStrip1.TabIndex = 126
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TxCod
        '
        Me.TxCod.Enabled = False
        Me.TxCod.Location = New System.Drawing.Point(84, 9)
        Me.TxCod.MaxLength = 10
        Me.TxCod.Name = "TxCod"
        Me.TxCod.Size = New System.Drawing.Size(82, 20)
        Me.TxCod.TabIndex = 124
        '
        'DGTPago
        '
        Me.DGTPago.AllowUserToAddRows = False
        Me.DGTPago.AllowUserToDeleteRows = False
        Me.DGTPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTPago.Location = New System.Drawing.Point(12, 166)
        Me.DGTPago.MultiSelect = False
        Me.DGTPago.Name = "DGTPago"
        Me.DGTPago.ReadOnly = True
        Me.DGTPago.RowHeadersVisible = False
        Me.DGTPago.Size = New System.Drawing.Size(810, 325)
        Me.DGTPago.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Codigo"
        '
        'TxDescrip
        '
        Me.TxDescrip.Enabled = False
        Me.TxDescrip.Location = New System.Drawing.Point(84, 35)
        Me.TxDescrip.MaxLength = 50
        Me.TxDescrip.Name = "TxDescrip"
        Me.TxDescrip.Size = New System.Drawing.Size(469, 20)
        Me.TxDescrip.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Factor Pago"
        '
        'cmbFactor
        '
        Me.cmbFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFactor.Enabled = False
        Me.cmbFactor.FormattingEnabled = True
        Me.cmbFactor.Items.AddRange(New Object() {"Día", "Hora", "Fijo", "Sesión"})
        Me.cmbFactor.Location = New System.Drawing.Point(84, 65)
        Me.cmbFactor.Name = "cmbFactor"
        Me.cmbFactor.Size = New System.Drawing.Size(121, 21)
        Me.cmbFactor.TabIndex = 130
        '
        'txFactor
        '
        Me.txFactor.Enabled = False
        Me.txFactor.Location = New System.Drawing.Point(346, 66)
        Me.txFactor.MaxLength = 11
        Me.txFactor.Name = "txFactor"
        Me.txFactor.Size = New System.Drawing.Size(42, 20)
        Me.txFactor.TabIndex = 132
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Multiplicador del Factor"
        '
        'chkDedFija
        '
        Me.chkDedFija.AutoSize = True
        Me.chkDedFija.Enabled = False
        Me.chkDedFija.Location = New System.Drawing.Point(83, 124)
        Me.chkDedFija.Name = "chkDedFija"
        Me.chkDedFija.Size = New System.Drawing.Size(148, 17)
        Me.chkDedFija.TabIndex = 133
        Me.chkDedFija.Text = "Aplicar Deducciones Fijas"
        Me.chkDedFija.UseVisualStyleBackColor = True
        '
        'chkDedGen
        '
        Me.chkDedGen.AutoSize = True
        Me.chkDedGen.Enabled = False
        Me.chkDedGen.Location = New System.Drawing.Point(83, 101)
        Me.chkDedGen.Name = "chkDedGen"
        Me.chkDedGen.Size = New System.Drawing.Size(175, 17)
        Me.chkDedGen.TabIndex = 134
        Me.chkDedGen.Text = "Aplicar Deducciones Generales"
        Me.chkDedGen.UseVisualStyleBackColor = True
        '
        'chkDist
        '
        Me.chkDist.AutoSize = True
        Me.chkDist.Enabled = False
        Me.chkDist.Location = New System.Drawing.Point(269, 101)
        Me.chkDist.Name = "chkDist"
        Me.chkDist.Size = New System.Drawing.Size(154, 17)
        Me.chkDist.TabIndex = 135
        Me.chkDist.Text = "Distribucion Presupuestaria"
        Me.chkDist.UseVisualStyleBackColor = True
        '
        'chkMov
        '
        Me.chkMov.AutoSize = True
        Me.chkMov.Enabled = False
        Me.chkMov.Location = New System.Drawing.Point(269, 124)
        Me.chkMov.Name = "chkMov"
        Me.chkMov.Size = New System.Drawing.Size(140, 17)
        Me.chkMov.TabIndex = 136
        Me.chkMov.Text = "No Permite Movimientos"
        Me.chkMov.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Indicadores"
        '
        'frm_RHTiposPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 503)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkMov)
        Me.Controls.Add(Me.chkDist)
        Me.Controls.Add(Me.chkDedGen)
        Me.Controls.Add(Me.chkDedFija)
        Me.Controls.Add(Me.txFactor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbFactor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxDescrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TxCod)
        Me.Controls.Add(Me.DGTPago)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_RHTiposPago"
        Me.Text = "Tipos de Pago"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGTPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImagenesBotones As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxCod As System.Windows.Forms.TextBox
    Friend WithEvents DGTPago As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxDescrip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFactor As System.Windows.Forms.ComboBox
    Friend WithEvents txFactor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDedFija As System.Windows.Forms.CheckBox
    Friend WithEvents chkDedGen As System.Windows.Forms.CheckBox
    Friend WithEvents chkDist As System.Windows.Forms.CheckBox
    Friend WithEvents chkMov As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
