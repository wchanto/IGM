<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Usuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxUsuario = New System.Windows.Forms.TextBox()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxClave1 = New System.Windows.Forms.TextBox()
        Me.TxClave2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ImagenesBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Undo = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.DGUsers = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Completo"
        '
        'TxUsuario
        '
        Me.TxUsuario.Enabled = False
        Me.TxUsuario.Location = New System.Drawing.Point(133, 28)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.Size = New System.Drawing.Size(82, 20)
        Me.TxUsuario.TabIndex = 2
        '
        'TxNombre
        '
        Me.TxNombre.Enabled = False
        Me.TxNombre.Location = New System.Drawing.Point(133, 54)
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(380, 20)
        Me.TxNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Clave"
        '
        'TxClave1
        '
        Me.TxClave1.Enabled = False
        Me.TxClave1.Location = New System.Drawing.Point(133, 86)
        Me.TxClave1.Name = "TxClave1"
        Me.TxClave1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxClave1.Size = New System.Drawing.Size(82, 20)
        Me.TxClave1.TabIndex = 5
        '
        'TxClave2
        '
        Me.TxClave2.Enabled = False
        Me.TxClave2.Location = New System.Drawing.Point(133, 112)
        Me.TxClave2.Name = "TxClave2"
        Me.TxClave2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxClave2.Size = New System.Drawing.Size(82, 20)
        Me.TxClave2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Confirmacion Clave"
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
        'btn_Save
        '
        Me.btn_Save.Enabled = False
        Me.btn_Save.ImageIndex = 2
        Me.btn_Save.ImageList = Me.ImagenesBotones
        Me.btn_Save.Location = New System.Drawing.Point(287, 23)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(29, 28)
        Me.btn_Save.TabIndex = 22
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Undo
        '
        Me.btn_Undo.Enabled = False
        Me.btn_Undo.ImageKey = "arrow_undo.png"
        Me.btn_Undo.ImageList = Me.ImagenesBotones
        Me.btn_Undo.Location = New System.Drawing.Point(343, 23)
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Size = New System.Drawing.Size(29, 28)
        Me.btn_Undo.TabIndex = 21
        Me.btn_Undo.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.ImageKey = "delete.png"
        Me.btn_Delete.ImageList = Me.ImagenesBotones
        Me.btn_Delete.Location = New System.Drawing.Point(315, 23)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(29, 28)
        Me.btn_Delete.TabIndex = 20
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.ImageIndex = 1
        Me.btn_Edit.ImageList = Me.ImagenesBotones
        Me.btn_Edit.Location = New System.Drawing.Point(259, 23)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(29, 28)
        Me.btn_Edit.TabIndex = 19
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.ImageIndex = 0
        Me.btn_New.ImageList = Me.ImagenesBotones
        Me.btn_New.Location = New System.Drawing.Point(231, 23)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(29, 28)
        Me.btn_New.TabIndex = 18
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'DGUsers
        '
        Me.DGUsers.AllowUserToAddRows = False
        Me.DGUsers.AllowUserToDeleteRows = False
        Me.DGUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsers.Location = New System.Drawing.Point(12, 159)
        Me.DGUsers.MultiSelect = False
        Me.DGUsers.Name = "DGUsers"
        Me.DGUsers.ReadOnly = True
        Me.DGUsers.Size = New System.Drawing.Size(500, 341)
        Me.DGUsers.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImagenesBotones
        Me.Button1.Location = New System.Drawing.Point(378, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 28)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 512)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGUsers)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Undo)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.TxClave2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxClave1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxNombre)
        Me.Controls.Add(Me.TxUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Usuarios"
        Me.Text = "Usuarios del Sistema"
        CType(Me.DGUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxClave1 As System.Windows.Forms.TextBox
    Friend WithEvents TxClave2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImagenesBotones As System.Windows.Forms.ImageList
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Undo As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents DGUsers As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
