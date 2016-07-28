<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", 1, 3, New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSS1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSS2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSS3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lbNomCia = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.btnOpc6 = New System.Windows.Forms.Button()
        Me.btnOpc5 = New System.Windows.Forms.Button()
        Me.btnOpc3 = New System.Windows.Forms.Button()
        Me.btnOpc4 = New System.Windows.Forms.Button()
        Me.btnOp1 = New System.Windows.Forms.Button()
        Me.BtnOpc2 = New System.Windows.Forms.Button()
        Me.ImagenMenu = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ImagenMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSS1, Me.TSS2, Me.TSS3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(834, 24)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSS1
        '
        Me.TSS1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSS1.Name = "TSS1"
        Me.TSS1.Size = New System.Drawing.Size(4, 19)
        '
        'TSS2
        '
        Me.TSS2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSS2.Name = "TSS2"
        Me.TSS2.Size = New System.Drawing.Size(125, 19)
        Me.TSS2.Text = "ToolStripStatusLabel1"
        '
        'TSS3
        '
        Me.TSS3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSS3.Name = "TSS3"
        Me.TSS3.Size = New System.Drawing.Size(125, 19)
        Me.TSS3.Text = "ToolStripStatusLabel1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpc6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpc5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpc3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpc4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOp1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnOpc2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.ImagenMenu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbNomCia)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(834, 533)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.TabIndex = 1
        '
        'lbNomCia
        '
        Me.lbNomCia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbNomCia.BackColor = System.Drawing.Color.Gainsboro
        Me.lbNomCia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNomCia.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomCia.ForeColor = System.Drawing.Color.Black
        Me.lbNomCia.Location = New System.Drawing.Point(11, 9)
        Me.lbNomCia.Name = "lbNomCia"
        Me.lbNomCia.Size = New System.Drawing.Size(592, 36)
        Me.lbNomCia.TabIndex = 2
        Me.lbNomCia.Text = "Municipalidad de Alvarado"
        Me.lbNomCia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TreeView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.Black
        Me.TreeView1.ImageIndex = 1
        Me.TreeView1.ImageList = Me.Imagenes
        Me.TreeView1.ItemHeight = 22
        Me.TreeView1.LineColor = System.Drawing.Color.Blue
        Me.TreeView1.Location = New System.Drawing.Point(11, 52)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node3"
        TreeNode1.Text = "Node3"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "Node1"
        TreeNode3.Name = "Node2"
        TreeNode3.Text = "Node2"
        TreeNode4.ImageIndex = 1
        TreeNode4.Name = "Prueba"
        TreeNode4.SelectedImageIndex = 3
        TreeNode4.Text = "Node0"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TreeView1.SelectedImageKey = "page_white_go.png"
        Me.TreeView1.ShowLines = False
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(592, 469)
        Me.TreeView1.StateImageList = Me.Imagenes
        Me.TreeView1.TabIndex = 1
        '
        'Imagenes
        '
        Me.Imagenes.ImageStream = CType(resources.GetObject("Imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagenes.Images.SetKeyName(0, "color_adjustment.png")
        Me.Imagenes.Images.SetKeyName(1, "bullet_arrow_right.png")
        Me.Imagenes.Images.SetKeyName(2, "bullet_green.png")
        Me.Imagenes.Images.SetKeyName(3, "bullet_arrow_down.png")
        Me.Imagenes.Images.SetKeyName(4, "bullet_blue.png")
        Me.Imagenes.Images.SetKeyName(5, "server_components.png")
        Me.Imagenes.Images.SetKeyName(6, "world.png")
        Me.Imagenes.Images.SetKeyName(7, "world_go.png")
        Me.Imagenes.Images.SetKeyName(8, "page_white.png")
        Me.Imagenes.Images.SetKeyName(9, "page_white_go.png")
        Me.Imagenes.Images.SetKeyName(10, "brick.png")
        Me.Imagenes.Images.SetKeyName(11, "brick_go.png")
        Me.Imagenes.Images.SetKeyName(12, "bricks.png")
        Me.Imagenes.Images.SetKeyName(13, "bullet_arrow_right.png")
        Me.Imagenes.Images.SetKeyName(14, "bullet_arrow_down.png")
        '
        'btnOpc6
        '
        Me.btnOpc6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpc6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpc6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnOpc6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOpc6.Image = Global.IGM.My.Resources.Resources.table_money1
        Me.btnOpc6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpc6.Location = New System.Drawing.Point(3, 254)
        Me.btnOpc6.Name = "btnOpc6"
        Me.btnOpc6.Size = New System.Drawing.Size(208, 38)
        Me.btnOpc6.TabIndex = 5
        Me.btnOpc6.Text = "Tributario"
        Me.btnOpc6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpc6.UseVisualStyleBackColor = False
        Me.btnOpc6.Visible = False
        '
        'btnOpc5
        '
        Me.btnOpc5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpc5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpc5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnOpc5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOpc5.Image = Global.IGM.My.Resources.Resources.client_account_template2
        Me.btnOpc5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpc5.Location = New System.Drawing.Point(3, 81)
        Me.btnOpc5.Name = "btnOpc5"
        Me.btnOpc5.Size = New System.Drawing.Size(208, 38)
        Me.btnOpc5.TabIndex = 4
        Me.btnOpc5.Text = "  Plataforma de Servicios"
        Me.btnOpc5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpc5.UseVisualStyleBackColor = False
        Me.btnOpc5.Visible = False
        '
        'btnOpc3
        '
        Me.btnOpc3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpc3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnOpc3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOpc3.Image = Global.IGM.My.Resources.Resources.layer_label1
        Me.btnOpc3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpc3.Location = New System.Drawing.Point(3, 42)
        Me.btnOpc3.Name = "btnOpc3"
        Me.btnOpc3.Size = New System.Drawing.Size(208, 38)
        Me.btnOpc3.TabIndex = 3
        Me.btnOpc3.Text = "  Activos Fijos"
        Me.btnOpc3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpc3.UseVisualStyleBackColor = False
        Me.btnOpc3.Visible = False
        '
        'btnOpc4
        '
        Me.btnOpc4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpc4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpc4.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOpc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpc4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpc4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOpc4.Image = Global.IGM.My.Resources.Resources.cog_edit1
        Me.btnOpc4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpc4.Location = New System.Drawing.Point(3, 120)
        Me.btnOpc4.Name = "btnOpc4"
        Me.btnOpc4.Size = New System.Drawing.Size(208, 38)
        Me.btnOpc4.TabIndex = 2
        Me.btnOpc4.Text = "  Opciones del Sistema"
        Me.btnOpc4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpc4.UseVisualStyleBackColor = False
        Me.btnOpc4.Visible = False
        '
        'btnOp1
        '
        Me.btnOp1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btnOp1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOp1.Image = Global.IGM.My.Resources.Resources.finance1
        Me.btnOp1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOp1.Location = New System.Drawing.Point(3, 3)
        Me.btnOp1.Name = "btnOp1"
        Me.btnOp1.Size = New System.Drawing.Size(208, 38)
        Me.btnOp1.TabIndex = 0
        Me.btnOp1.Text = "  Finanzas"
        Me.btnOp1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOp1.UseVisualStyleBackColor = False
        Me.btnOp1.Visible = False
        '
        'BtnOpc2
        '
        Me.BtnOpc2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpc2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnOpc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpc2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnOpc2.Image = Global.IGM.My.Resources.Resources.group1
        Me.BtnOpc2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOpc2.Location = New System.Drawing.Point(4, 210)
        Me.BtnOpc2.Name = "BtnOpc2"
        Me.BtnOpc2.Size = New System.Drawing.Size(208, 38)
        Me.BtnOpc2.TabIndex = 1
        Me.BtnOpc2.Text = "  Recursos Humanos"
        Me.BtnOpc2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOpc2.UseVisualStyleBackColor = False
        Me.BtnOpc2.Visible = False
        '
        'ImagenMenu
        '
        Me.ImagenMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenMenu.Image = Global.IGM.My.Resources.Resources.index
        Me.ImagenMenu.Location = New System.Drawing.Point(558, 61)
        Me.ImagenMenu.Name = "ImagenMenu"
        Me.ImagenMenu.Size = New System.Drawing.Size(35, 35)
        Me.ImagenMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenMenu.TabIndex = 3
        Me.ImagenMenu.TabStop = False
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 557)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGEM - Sistema de Gestión Municipal"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ImagenMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnOpc2 As System.Windows.Forms.Button
    Friend WithEvents Imagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnOp1 As System.Windows.Forms.Button
    Friend WithEvents TSS1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSS2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnOpc4 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TSS3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnOpc3 As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents btnOpc5 As System.Windows.Forms.Button
    Friend WithEvents lbNomCia As System.Windows.Forms.Label
    Friend WithEvents ImagenMenu As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpc6 As System.Windows.Forms.Button

End Class
