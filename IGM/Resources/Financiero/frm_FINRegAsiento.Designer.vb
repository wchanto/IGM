<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FINRegAsiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FINRegAsiento))
        Me.DGAsientos = New System.Windows.Forms.DataGridView()
        Me.MenuAsientos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mImprime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBorrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.ImagenesBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_New = New System.Windows.Forms.Button()
        CType(Me.DGAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAsientos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGAsientos
        '
        Me.DGAsientos.AllowUserToAddRows = False
        Me.DGAsientos.AllowUserToDeleteRows = False
        Me.DGAsientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAsientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAsientos.ContextMenuStrip = Me.MenuAsientos
        Me.DGAsientos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGAsientos.Location = New System.Drawing.Point(12, 102)
        Me.DGAsientos.MultiSelect = False
        Me.DGAsientos.Name = "DGAsientos"
        Me.DGAsientos.Size = New System.Drawing.Size(889, 367)
        Me.DGAsientos.TabIndex = 8
        '
        'MenuAsientos
        '
        Me.MenuAsientos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mVer, Me.mImprime, Me.mBorrar})
        Me.MenuAsientos.Name = "MenuAsientos"
        Me.MenuAsientos.Size = New System.Drawing.Size(198, 70)
        '
        'mVer
        '
        Me.mVer.Image = Global.IGM.My.Resources.Resources.document_view_book
        Me.mVer.Name = "mVer"
        Me.mVer.Size = New System.Drawing.Size(197, 22)
        Me.mVer.Text = "Vista detalla del asiento"
        '
        'mImprime
        '
        Me.mImprime.Image = Global.IGM.My.Resources.Resources.printer
        Me.mImprime.Name = "mImprime"
        Me.mImprime.Size = New System.Drawing.Size(197, 22)
        Me.mImprime.Text = "Imprimir Asiento"
        '
        'mBorrar
        '
        Me.mBorrar.Image = Global.IGM.My.Resources.Resources.delete
        Me.mBorrar.Name = "mBorrar"
        Me.mBorrar.Size = New System.Drawing.Size(197, 22)
        Me.mBorrar.Text = "Eliminar Asiento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbPeriodo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 84)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Estado"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(233, 46)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(105, 21)
        Me.cmbEstado.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Usuario"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(233, 19)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(320, 21)
        Me.cmbUsuario.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Mes"
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(63, 46)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(105, 21)
        Me.cmbMes.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Periodo"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(63, 19)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(105, 21)
        Me.cmbPeriodo.TabIndex = 13
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
        '
        'btn_New
        '
        Me.btn_New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_New.ImageIndex = 0
        Me.btn_New.ImageList = Me.ImagenesBotones
        Me.btn_New.Location = New System.Drawing.Point(585, 25)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(103, 31)
        Me.btn_New.TabIndex = 21
        Me.btn_New.Text = "Nuevo Asiento"
        Me.btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'frm_FINRegAsiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 494)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGAsientos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_FINRegAsiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Asientos Contables"
        CType(Me.DGAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAsientos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGAsientos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents ImagenesBotones As System.Windows.Forms.ImageList
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents MenuAsientos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mVer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mImprime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBorrar As System.Windows.Forms.ToolStripMenuItem
End Class
