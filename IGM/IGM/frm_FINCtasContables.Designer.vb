<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FINCtasContables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FINCtasContables))
        Me.DGCuentas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxDescrip = New System.Windows.Forms.TextBox()
        Me.cmbTC = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkMov = New System.Windows.Forms.CheckBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.ImagenesBotones = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_Undo = New System.Windows.Forms.Button()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.cmbCta = New System.Windows.Forms.ComboBox()
        CType(Me.DGCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGCuentas
        '
        Me.DGCuentas.AllowUserToAddRows = False
        Me.DGCuentas.AllowUserToDeleteRows = False
        Me.DGCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCuentas.Location = New System.Drawing.Point(12, 120)
        Me.DGCuentas.MultiSelect = False
        Me.DGCuentas.Name = "DGCuentas"
        Me.DGCuentas.ReadOnly = True
        Me.DGCuentas.Size = New System.Drawing.Size(1038, 402)
        Me.DGCuentas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo Cuenta"
        '
        'txCuenta
        '
        Me.txCuenta.Enabled = False
        Me.txCuenta.HidePromptOnLeave = True
        Me.txCuenta.Location = New System.Drawing.Point(101, 12)
        Me.txCuenta.Name = "txCuenta"
        Me.txCuenta.Size = New System.Drawing.Size(244, 20)
        Me.txCuenta.TabIndex = 3
        Me.txCuenta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción"
        '
        'TxDescrip
        '
        Me.TxDescrip.Enabled = False
        Me.TxDescrip.Location = New System.Drawing.Point(101, 48)
        Me.TxDescrip.Name = "TxDescrip"
        Me.TxDescrip.Size = New System.Drawing.Size(560, 20)
        Me.TxDescrip.TabIndex = 5
        '
        'cmbTC
        '
        Me.cmbTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTC.Enabled = False
        Me.cmbTC.FormattingEnabled = True
        Me.cmbTC.Location = New System.Drawing.Point(101, 75)
        Me.cmbTC.Name = "cmbTC"
        Me.cmbTC.Size = New System.Drawing.Size(248, 21)
        Me.cmbTC.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo de Cuenta"
        '
        'chkMov
        '
        Me.chkMov.AutoSize = True
        Me.chkMov.Enabled = False
        Me.chkMov.Location = New System.Drawing.Point(391, 78)
        Me.chkMov.Name = "chkMov"
        Me.chkMov.Size = New System.Drawing.Size(123, 17)
        Me.chkMov.TabIndex = 8
        Me.chkMov.Text = "Permite Movimientos"
        Me.chkMov.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Enabled = False
        Me.btn_Save.ImageIndex = 2
        Me.btn_Save.ImageList = Me.ImagenesBotones
        Me.btn_Save.Location = New System.Drawing.Point(407, 7)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(29, 28)
        Me.btn_Save.TabIndex = 17
        Me.btn_Save.UseVisualStyleBackColor = True
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
        '
        'btn_Undo
        '
        Me.btn_Undo.Enabled = False
        Me.btn_Undo.ImageKey = "arrow_undo.png"
        Me.btn_Undo.ImageList = Me.ImagenesBotones
        Me.btn_Undo.Location = New System.Drawing.Point(463, 7)
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Size = New System.Drawing.Size(29, 28)
        Me.btn_Undo.TabIndex = 16
        Me.btn_Undo.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.ImageKey = "delete.png"
        Me.btn_Delete.ImageList = Me.ImagenesBotones
        Me.btn_Delete.Location = New System.Drawing.Point(435, 7)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(29, 28)
        Me.btn_Delete.TabIndex = 15
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.ImageIndex = 1
        Me.btn_Edit.ImageList = Me.ImagenesBotones
        Me.btn_Edit.Location = New System.Drawing.Point(379, 7)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(29, 28)
        Me.btn_Edit.TabIndex = 14
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.ImageIndex = 0
        Me.btn_New.ImageList = Me.ImagenesBotones
        Me.btn_New.Location = New System.Drawing.Point(351, 7)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(29, 28)
        Me.btn_New.TabIndex = 13
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'cmbCta
        '
        Me.cmbCta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCta.FormattingEnabled = True
        Me.cmbCta.Location = New System.Drawing.Point(526, 78)
        Me.cmbCta.Name = "cmbCta"
        Me.cmbCta.Size = New System.Drawing.Size(135, 21)
        Me.cmbCta.TabIndex = 18
        Me.cmbCta.Visible = False
        '
        'frm_FINCtasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 534)
        Me.Controls.Add(Me.cmbCta)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.btn_Undo)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.chkMov)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTC)
        Me.Controls.Add(Me.TxDescrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_FINCtasContables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Cuentas Contables"
        CType(Me.DGCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txCuenta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxDescrip As System.Windows.Forms.TextBox
    Friend WithEvents cmbTC As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkMov As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Undo As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents ImagenesBotones As System.Windows.Forms.ImageList
    Friend WithEvents cmbCta As System.Windows.Forms.ComboBox
End Class
