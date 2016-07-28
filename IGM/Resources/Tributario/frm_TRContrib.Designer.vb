<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TRContrib
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TRContrib))
        Me.lbID = New System.Windows.Forms.Label()
        Me.txIdentificacion = New System.Windows.Forms.TextBox()
        Me.txNombreCompleto = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.lbNom = New System.Windows.Forms.Label()
        Me.txApellido1 = New System.Windows.Forms.TextBox()
        Me.lbApell1 = New System.Windows.Forms.Label()
        Me.txApellido2 = New System.Windows.Forms.TextBox()
        Me.lbApellido2 = New System.Windows.Forms.Label()
        Me.optFisico = New System.Windows.Forms.RadioButton()
        Me.OptJuridico = New System.Windows.Forms.RadioButton()
        Me.lbTIpoPer = New System.Windows.Forms.Label()
        Me.chkPublico = New System.Windows.Forms.CheckBox()
        Me.lbAtrib = New System.Windows.Forms.Label()
        Me.DGCampos = New System.Windows.Forms.DataGridView()
        Me.lb_TiposCampo = New System.Windows.Forms.Label()
        Me.empImagen = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDel = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.txCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DPNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.DPDefun = New System.Windows.Forms.DateTimePicker()
        Me.lbNaci = New System.Windows.Forms.Label()
        Me.lbDefu = New System.Windows.Forms.Label()
        CType(Me.DGCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(13, 13)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(70, 13)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "Identificacion"
        '
        'txIdentificacion
        '
        Me.txIdentificacion.Location = New System.Drawing.Point(110, 10)
        Me.txIdentificacion.Name = "txIdentificacion"
        Me.txIdentificacion.Size = New System.Drawing.Size(133, 20)
        Me.txIdentificacion.TabIndex = 1
        '
        'txNombreCompleto
        '
        Me.txNombreCompleto.Enabled = False
        Me.txNombreCompleto.Location = New System.Drawing.Point(110, 147)
        Me.txNombreCompleto.Name = "txNombreCompleto"
        Me.txNombreCompleto.Size = New System.Drawing.Size(489, 20)
        Me.txNombreCompleto.TabIndex = 7
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(11, 150)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(91, 13)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "Nombre Completo"
        '
        'txNombre
        '
        Me.txNombre.Enabled = False
        Me.txNombre.Location = New System.Drawing.Point(110, 69)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(228, 20)
        Me.txNombre.TabIndex = 4
        '
        'lbNom
        '
        Me.lbNom.AutoSize = True
        Me.lbNom.Location = New System.Drawing.Point(13, 72)
        Me.lbNom.Name = "lbNom"
        Me.lbNom.Size = New System.Drawing.Size(44, 13)
        Me.lbNom.TabIndex = 4
        Me.lbNom.Text = "Nombre"
        '
        'txApellido1
        '
        Me.txApellido1.Enabled = False
        Me.txApellido1.Location = New System.Drawing.Point(110, 95)
        Me.txApellido1.Name = "txApellido1"
        Me.txApellido1.Size = New System.Drawing.Size(228, 20)
        Me.txApellido1.TabIndex = 5
        '
        'lbApell1
        '
        Me.lbApell1.AutoSize = True
        Me.lbApell1.Location = New System.Drawing.Point(11, 98)
        Me.lbApell1.Name = "lbApell1"
        Me.lbApell1.Size = New System.Drawing.Size(76, 13)
        Me.lbApell1.TabIndex = 6
        Me.lbApell1.Text = "Primer Apellido"
        '
        'txApellido2
        '
        Me.txApellido2.Enabled = False
        Me.txApellido2.Location = New System.Drawing.Point(110, 121)
        Me.txApellido2.Name = "txApellido2"
        Me.txApellido2.Size = New System.Drawing.Size(228, 20)
        Me.txApellido2.TabIndex = 6
        '
        'lbApellido2
        '
        Me.lbApellido2.AutoSize = True
        Me.lbApellido2.Location = New System.Drawing.Point(11, 124)
        Me.lbApellido2.Name = "lbApellido2"
        Me.lbApellido2.Size = New System.Drawing.Size(90, 13)
        Me.lbApellido2.TabIndex = 8
        Me.lbApellido2.Text = "Segundo Apellido"
        '
        'optFisico
        '
        Me.optFisico.AutoSize = True
        Me.optFisico.Enabled = False
        Me.optFisico.Location = New System.Drawing.Point(108, 36)
        Me.optFisico.Name = "optFisico"
        Me.optFisico.Size = New System.Drawing.Size(52, 17)
        Me.optFisico.TabIndex = 2
        Me.optFisico.TabStop = True
        Me.optFisico.Text = "Fisica"
        Me.optFisico.UseVisualStyleBackColor = True
        '
        'OptJuridico
        '
        Me.OptJuridico.AutoSize = True
        Me.OptJuridico.Enabled = False
        Me.OptJuridico.Location = New System.Drawing.Point(166, 36)
        Me.OptJuridico.Name = "OptJuridico"
        Me.OptJuridico.Size = New System.Drawing.Size(61, 17)
        Me.OptJuridico.TabIndex = 3
        Me.OptJuridico.TabStop = True
        Me.OptJuridico.Text = "Juridica"
        Me.OptJuridico.UseVisualStyleBackColor = True
        '
        'lbTIpoPer
        '
        Me.lbTIpoPer.AutoSize = True
        Me.lbTIpoPer.Location = New System.Drawing.Point(13, 40)
        Me.lbTIpoPer.Name = "lbTIpoPer"
        Me.lbTIpoPer.Size = New System.Drawing.Size(70, 13)
        Me.lbTIpoPer.TabIndex = 12
        Me.lbTIpoPer.Text = "Tipo Persona"
        '
        'chkPublico
        '
        Me.chkPublico.AutoSize = True
        Me.chkPublico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPublico.Enabled = False
        Me.chkPublico.Location = New System.Drawing.Point(12, 185)
        Me.chkPublico.Name = "chkPublico"
        Me.chkPublico.Size = New System.Drawing.Size(127, 17)
        Me.chkPublico.TabIndex = 8
        Me.chkPublico.Text = "Es Institución Pública"
        Me.chkPublico.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkPublico.UseVisualStyleBackColor = True
        '
        'lbAtrib
        '
        Me.lbAtrib.AutoSize = True
        Me.lbAtrib.Location = New System.Drawing.Point(17, 226)
        Me.lbAtrib.Name = "lbAtrib"
        Me.lbAtrib.Size = New System.Drawing.Size(123, 13)
        Me.lbAtrib.TabIndex = 14
        Me.lbAtrib.Text = "Datos del Contribuyente:"
        '
        'DGCampos
        '
        Me.DGCampos.AllowUserToAddRows = False
        Me.DGCampos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCampos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCampos.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGCampos.Enabled = False
        Me.DGCampos.Location = New System.Drawing.Point(16, 253)
        Me.DGCampos.Name = "DGCampos"
        Me.DGCampos.RowHeadersVisible = False
        Me.DGCampos.Size = New System.Drawing.Size(728, 291)
        Me.DGCampos.TabIndex = 15
        '
        'lb_TiposCampo
        '
        Me.lb_TiposCampo.AutoSize = True
        Me.lb_TiposCampo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_TiposCampo.ForeColor = System.Drawing.Color.Blue
        Me.lb_TiposCampo.Location = New System.Drawing.Point(157, 226)
        Me.lb_TiposCampo.Name = "lb_TiposCampo"
        Me.lb_TiposCampo.Size = New System.Drawing.Size(110, 13)
        Me.lb_TiposCampo.TabIndex = 16
        Me.lb_TiposCampo.Text = "Editar tipos de Campo"
        '
        'empImagen
        '
        Me.empImagen.ImageStream = CType(resources.GetObject("empImagen.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.empImagen.TransparentColor = System.Drawing.Color.Transparent
        Me.empImagen.Images.SetKeyName(0, "user_green.png")
        Me.empImagen.Images.SetKeyName(1, "table_money.png")
        Me.empImagen.Images.SetKeyName(2, "user_student.png")
        Me.empImagen.Images.SetKeyName(3, "page_white_magnify.png")
        Me.empImagen.Images.SetKeyName(4, "calendar.png")
        Me.empImagen.Images.SetKeyName(5, "medical_record.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnSave, Me.btnDel, Me.btnUndo})
        Me.ToolStrip1.Location = New System.Drawing.Point(255, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(127, 25)
        Me.ToolStrip1.TabIndex = 128
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
        'txCuenta
        '
        Me.txCuenta.Enabled = False
        Me.txCuenta.Location = New System.Drawing.Point(279, 183)
        Me.txCuenta.Name = "txCuenta"
        Me.txCuenta.Size = New System.Drawing.Size(228, 20)
        Me.txCuenta.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Cuenta Contable"
        '
        'DPNacimiento
        '
        Me.DPNacimiento.Location = New System.Drawing.Point(521, 69)
        Me.DPNacimiento.Name = "DPNacimiento"
        Me.DPNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.DPNacimiento.TabIndex = 10
        '
        'DPDefun
        '
        Me.DPDefun.Location = New System.Drawing.Point(521, 107)
        Me.DPDefun.Name = "DPDefun"
        Me.DPDefun.Size = New System.Drawing.Size(200, 20)
        Me.DPDefun.TabIndex = 11
        '
        'lbNaci
        '
        Me.lbNaci.AutoSize = True
        Me.lbNaci.Location = New System.Drawing.Point(422, 72)
        Me.lbNaci.Name = "lbNaci"
        Me.lbNaci.Size = New System.Drawing.Size(93, 13)
        Me.lbNaci.TabIndex = 134
        Me.lbNaci.Text = "Fecha Nacimiento"
        '
        'lbDefu
        '
        Me.lbDefu.AutoSize = True
        Me.lbDefu.Location = New System.Drawing.Point(422, 113)
        Me.lbDefu.Name = "lbDefu"
        Me.lbDefu.Size = New System.Drawing.Size(89, 13)
        Me.lbDefu.TabIndex = 135
        Me.lbDefu.Text = "Fecha Defunción"
        '
        'frm_TRContrib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 556)
        Me.Controls.Add(Me.lbDefu)
        Me.Controls.Add(Me.lbNaci)
        Me.Controls.Add(Me.DPDefun)
        Me.Controls.Add(Me.DPNacimiento)
        Me.Controls.Add(Me.txCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lb_TiposCampo)
        Me.Controls.Add(Me.DGCampos)
        Me.Controls.Add(Me.lbAtrib)
        Me.Controls.Add(Me.chkPublico)
        Me.Controls.Add(Me.lbTIpoPer)
        Me.Controls.Add(Me.OptJuridico)
        Me.Controls.Add(Me.optFisico)
        Me.Controls.Add(Me.txApellido2)
        Me.Controls.Add(Me.lbApellido2)
        Me.Controls.Add(Me.txApellido1)
        Me.Controls.Add(Me.lbApell1)
        Me.Controls.Add(Me.txNombre)
        Me.Controls.Add(Me.lbNom)
        Me.Controls.Add(Me.txNombreCompleto)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.txIdentificacion)
        Me.Controls.Add(Me.lbID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_TRContrib"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contribuyentes"
        CType(Me.DGCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents txIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents txNombreCompleto As System.Windows.Forms.TextBox
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents txNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbNom As System.Windows.Forms.Label
    Friend WithEvents txApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lbApell1 As System.Windows.Forms.Label
    Friend WithEvents txApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents lbApellido2 As System.Windows.Forms.Label
    Friend WithEvents optFisico As System.Windows.Forms.RadioButton
    Friend WithEvents OptJuridico As System.Windows.Forms.RadioButton
    Friend WithEvents lbTIpoPer As System.Windows.Forms.Label
    Friend WithEvents chkPublico As System.Windows.Forms.CheckBox
    Friend WithEvents lbAtrib As System.Windows.Forms.Label
    Friend WithEvents DGCampos As System.Windows.Forms.DataGridView
    Friend WithEvents lb_TiposCampo As System.Windows.Forms.Label
    Friend WithEvents empImagen As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents txCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DPNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents DPDefun As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbNaci As System.Windows.Forms.Label
    Friend WithEvents lbDefu As System.Windows.Forms.Label
End Class
