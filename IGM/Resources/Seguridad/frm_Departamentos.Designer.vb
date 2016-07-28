<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Departamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Departamentos))
        Me.ImagenesBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Undo = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.TxCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGDeptos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCtroTrab = New System.Windows.Forms.ComboBox()
        CType(Me.DGDeptos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'Button2
        '
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.ImagenesBotones
        Me.Button2.Location = New System.Drawing.Point(340, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 28)
        Me.Button2.TabIndex = 116
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Enabled = False
        Me.btn_Save.ImageIndex = 2
        Me.btn_Save.ImageList = Me.ImagenesBotones
        Me.btn_Save.Location = New System.Drawing.Point(256, 7)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(29, 28)
        Me.btn_Save.TabIndex = 113
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Undo
        '
        Me.btn_Undo.Enabled = False
        Me.btn_Undo.ImageKey = "arrow_undo.png"
        Me.btn_Undo.ImageList = Me.ImagenesBotones
        Me.btn_Undo.Location = New System.Drawing.Point(312, 7)
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Size = New System.Drawing.Size(29, 28)
        Me.btn_Undo.TabIndex = 115
        Me.btn_Undo.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.ImageKey = "delete.png"
        Me.btn_Delete.ImageList = Me.ImagenesBotones
        Me.btn_Delete.Location = New System.Drawing.Point(284, 7)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(29, 28)
        Me.btn_Delete.TabIndex = 114
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.ImageIndex = 1
        Me.btn_Edit.ImageList = Me.ImagenesBotones
        Me.btn_Edit.Location = New System.Drawing.Point(228, 7)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(29, 28)
        Me.btn_Edit.TabIndex = 112
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.ImageIndex = 0
        Me.btn_New.ImageList = Me.ImagenesBotones
        Me.btn_New.Location = New System.Drawing.Point(200, 7)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(29, 28)
        Me.btn_New.TabIndex = 111
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'TxNombre
        '
        Me.TxNombre.Enabled = False
        Me.TxNombre.Location = New System.Drawing.Point(112, 38)
        Me.TxNombre.MaxLength = 40
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(380, 20)
        Me.TxNombre.TabIndex = 110
        '
        'TxCod
        '
        Me.TxCod.Enabled = False
        Me.TxCod.Location = New System.Drawing.Point(112, 12)
        Me.TxCod.MaxLength = 11
        Me.TxCod.Name = "TxCod"
        Me.TxCod.Size = New System.Drawing.Size(82, 20)
        Me.TxCod.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Codigo"
        '
        'DGDeptos
        '
        Me.DGDeptos.AllowUserToAddRows = False
        Me.DGDeptos.AllowUserToDeleteRows = False
        Me.DGDeptos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGDeptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDeptos.Location = New System.Drawing.Point(12, 111)
        Me.DGDeptos.MultiSelect = False
        Me.DGDeptos.Name = "DGDeptos"
        Me.DGDeptos.ReadOnly = True
        Me.DGDeptos.RowHeadersVisible = False
        Me.DGDeptos.Size = New System.Drawing.Size(629, 261)
        Me.DGDeptos.TabIndex = 117
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Centro de Trabajo"
        '
        'cmbCtroTrab
        '
        Me.cmbCtroTrab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCtroTrab.Enabled = False
        Me.cmbCtroTrab.FormattingEnabled = True
        Me.cmbCtroTrab.Location = New System.Drawing.Point(112, 66)
        Me.cmbCtroTrab.Name = "cmbCtroTrab"
        Me.cmbCtroTrab.Size = New System.Drawing.Size(380, 21)
        Me.cmbCtroTrab.TabIndex = 120
        '
        'frm_Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 384)
        Me.Controls.Add(Me.cmbCtroTrab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGDeptos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Undo)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.TxNombre)
        Me.Controls.Add(Me.TxCod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Departamentos"
        Me.Text = "Mantenimiento de Departamentos"
        CType(Me.DGDeptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImagenesBotones As System.Windows.Forms.ImageList
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Undo As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents TxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGDeptos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCtroTrab As System.Windows.Forms.ComboBox
End Class
