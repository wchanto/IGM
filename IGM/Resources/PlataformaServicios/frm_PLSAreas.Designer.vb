<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PLSAreas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PLSAreas))
        Me.ImagenesBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DGAreas = New System.Windows.Forms.DataGridView()
        Me.lstEncarg = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Undo = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.TxCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkElimina = New System.Windows.Forms.CheckBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGAreas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 89)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGAreas)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstEncarg)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Size = New System.Drawing.Size(815, 430)
        Me.SplitContainer1.SplitterDistance = 476
        Me.SplitContainer1.TabIndex = 62
        '
        'DGAreas
        '
        Me.DGAreas.AllowUserToAddRows = False
        Me.DGAreas.AllowUserToDeleteRows = False
        Me.DGAreas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAreas.Location = New System.Drawing.Point(3, 9)
        Me.DGAreas.MultiSelect = False
        Me.DGAreas.Name = "DGAreas"
        Me.DGAreas.ReadOnly = True
        Me.DGAreas.RowHeadersVisible = False
        Me.DGAreas.Size = New System.Drawing.Size(470, 416)
        Me.DGAreas.TabIndex = 33
        '
        'lstEncarg
        '
        Me.lstEncarg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstEncarg.Enabled = False
        Me.lstEncarg.FormattingEnabled = True
        Me.lstEncarg.Location = New System.Drawing.Point(6, 25)
        Me.lstEncarg.Name = "lstEncarg"
        Me.lstEncarg.Size = New System.Drawing.Size(319, 394)
        Me.lstEncarg.TabIndex = 53
        Me.lstEncarg.ThreeDCheckBoxes = True
        Me.lstEncarg.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Encargados"
        '
        'btn_Save
        '
        Me.btn_Save.Enabled = False
        Me.btn_Save.ImageIndex = 2
        Me.btn_Save.ImageList = Me.ImagenesBotones
        Me.btn_Save.Location = New System.Drawing.Point(227, 7)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(29, 28)
        Me.btn_Save.TabIndex = 60
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Undo
        '
        Me.btn_Undo.Enabled = False
        Me.btn_Undo.ImageKey = "arrow_undo.png"
        Me.btn_Undo.ImageList = Me.ImagenesBotones
        Me.btn_Undo.Location = New System.Drawing.Point(283, 7)
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Size = New System.Drawing.Size(29, 28)
        Me.btn_Undo.TabIndex = 59
        Me.btn_Undo.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.ImageKey = "delete.png"
        Me.btn_Delete.ImageList = Me.ImagenesBotones
        Me.btn_Delete.Location = New System.Drawing.Point(255, 7)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(29, 28)
        Me.btn_Delete.TabIndex = 58
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.ImageIndex = 1
        Me.btn_Edit.ImageList = Me.ImagenesBotones
        Me.btn_Edit.Location = New System.Drawing.Point(199, 7)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(29, 28)
        Me.btn_Edit.TabIndex = 57
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.ImageIndex = 0
        Me.btn_New.ImageList = Me.ImagenesBotones
        Me.btn_New.Location = New System.Drawing.Point(171, 7)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(29, 28)
        Me.btn_New.TabIndex = 56
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'TxNombre
        '
        Me.TxNombre.Enabled = False
        Me.TxNombre.Location = New System.Drawing.Point(83, 38)
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(380, 20)
        Me.TxNombre.TabIndex = 53
        '
        'TxCod
        '
        Me.TxCod.Enabled = False
        Me.TxCod.Location = New System.Drawing.Point(83, 12)
        Me.TxCod.Name = "TxCod"
        Me.TxCod.Size = New System.Drawing.Size(82, 20)
        Me.TxCod.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Codigo"
        '
        'chkElimina
        '
        Me.chkElimina.AutoSize = True
        Me.chkElimina.Enabled = False
        Me.chkElimina.Location = New System.Drawing.Point(83, 66)
        Me.chkElimina.Name = "chkElimina"
        Me.chkElimina.Size = New System.Drawing.Size(100, 17)
        Me.chkElimina.TabIndex = 63
        Me.chkElimina.Text = "Permite Eliminar"
        Me.chkElimina.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.chkElimina.UseVisualStyleBackColor = True
        '
        'frm_PLSAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.Controls.Add(Me.chkElimina)
        Me.Controls.Add(Me.SplitContainer1)
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
        Me.Name = "frm_PLSAreas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Areas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImagenesBotones As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DGAreas As System.Windows.Forms.DataGridView
    Friend WithEvents lstEncarg As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Undo As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents TxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkElimina As System.Windows.Forms.CheckBox
End Class
