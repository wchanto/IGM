<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PLSTipoTramite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PLSTipoTramite))
        Me.ImagenesBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Undo = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.TxDias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxNombre = New System.Windows.Forms.TextBox()
        Me.TxCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DGTramites = New System.Windows.Forms.DataGridView()
        Me.lstReq = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGTramites, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImagenesBotones
        Me.Button1.Location = New System.Drawing.Point(317, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 28)
        Me.Button1.TabIndex = 48
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Enabled = False
        Me.btn_Save.ImageIndex = 2
        Me.btn_Save.ImageList = Me.ImagenesBotones
        Me.btn_Save.Location = New System.Drawing.Point(226, 7)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(29, 28)
        Me.btn_Save.TabIndex = 47
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Undo
        '
        Me.btn_Undo.Enabled = False
        Me.btn_Undo.ImageKey = "arrow_undo.png"
        Me.btn_Undo.ImageList = Me.ImagenesBotones
        Me.btn_Undo.Location = New System.Drawing.Point(282, 7)
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Size = New System.Drawing.Size(29, 28)
        Me.btn_Undo.TabIndex = 46
        Me.btn_Undo.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.ImageKey = "delete.png"
        Me.btn_Delete.ImageList = Me.ImagenesBotones
        Me.btn_Delete.Location = New System.Drawing.Point(254, 7)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(29, 28)
        Me.btn_Delete.TabIndex = 45
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.ImageIndex = 1
        Me.btn_Edit.ImageList = Me.ImagenesBotones
        Me.btn_Edit.Location = New System.Drawing.Point(198, 7)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(29, 28)
        Me.btn_Edit.TabIndex = 44
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.ImageIndex = 0
        Me.btn_New.ImageList = Me.ImagenesBotones
        Me.btn_New.Location = New System.Drawing.Point(170, 7)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(29, 28)
        Me.btn_New.TabIndex = 43
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'TxDias
        '
        Me.TxDias.Enabled = False
        Me.TxDias.Location = New System.Drawing.Point(520, 38)
        Me.TxDias.Multiline = True
        Me.TxDias.Name = "TxDias"
        Me.TxDias.Size = New System.Drawing.Size(57, 20)
        Me.TxDias.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Dias"
        '
        'TxNombre
        '
        Me.TxNombre.Enabled = False
        Me.TxNombre.Location = New System.Drawing.Point(82, 38)
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(380, 20)
        Me.TxNombre.TabIndex = 40
        '
        'TxCod
        '
        Me.TxCod.Enabled = False
        Me.TxCod.Location = New System.Drawing.Point(82, 12)
        Me.TxCod.Name = "TxCod"
        Me.TxCod.Size = New System.Drawing.Size(82, 20)
        Me.TxCod.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Codigo"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(16, 64)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGTramites)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstReq)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Size = New System.Drawing.Size(801, 362)
        Me.SplitContainer1.SplitterDistance = 468
        Me.SplitContainer1.TabIndex = 49
        '
        'DGTramites
        '
        Me.DGTramites.AllowUserToAddRows = False
        Me.DGTramites.AllowUserToDeleteRows = False
        Me.DGTramites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGTramites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGTramites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTramites.Location = New System.Drawing.Point(3, 9)
        Me.DGTramites.MultiSelect = False
        Me.DGTramites.Name = "DGTramites"
        Me.DGTramites.ReadOnly = True
        Me.DGTramites.RowHeadersVisible = False
        Me.DGTramites.Size = New System.Drawing.Size(462, 348)
        Me.DGTramites.TabIndex = 33
        '
        'lstReq
        '
        Me.lstReq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstReq.Enabled = False
        Me.lstReq.FormattingEnabled = True
        Me.lstReq.Location = New System.Drawing.Point(6, 25)
        Me.lstReq.Name = "lstReq"
        Me.lstReq.Size = New System.Drawing.Size(313, 334)
        Me.lstReq.TabIndex = 53
        Me.lstReq.ThreeDCheckBoxes = True
        Me.lstReq.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Requisitos"
        '
        'frm_PLSTipoTramite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 438)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Undo)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.TxDias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxNombre)
        Me.Controls.Add(Me.TxCod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_PLSTipoTramite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Tramite"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGTramites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImagenesBotones As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Undo As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents TxDias As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DGTramites As System.Windows.Forms.DataGridView
    Friend WithEvents lstReq As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
