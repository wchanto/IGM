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
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", New System.Windows.Forms.TreeNode() {TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", 1, 3, New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSS1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSS2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSS3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnOpc3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnOp1 = New System.Windows.Forms.Button()
        Me.BtnOpc2 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpc3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOp1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnOpc2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(834, 533)
        Me.SplitContainer1.SplitterDistance = 203
        Me.SplitContainer1.TabIndex = 1
        '
        'btnOpc3
        '
        Me.btnOpc3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpc3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOpc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpc3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOpc3.Image = Global.IGM.My.Resources.Resources.layer_label
        Me.btnOpc3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpc3.Location = New System.Drawing.Point(3, 42)
        Me.btnOpc3.Name = "btnOpc3"
        Me.btnOpc3.Size = New System.Drawing.Size(196, 38)
        Me.btnOpc3.TabIndex = 3
        Me.btnOpc3.Text = "Activos Fijos"
        Me.btnOpc3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpc3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Image = Global.IGM.My.Resources.Resources.cog_edit
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Opciones del Sistema"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnOp1
        '
        Me.btnOp1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOp1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOp1.Image = Global.IGM.My.Resources.Resources.finance
        Me.btnOp1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOp1.Location = New System.Drawing.Point(3, 3)
        Me.btnOp1.Name = "btnOp1"
        Me.btnOp1.Size = New System.Drawing.Size(196, 38)
        Me.btnOp1.TabIndex = 0
        Me.btnOp1.Text = "Finanzas"
        Me.btnOp1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOp1.UseVisualStyleBackColor = False
        '
        'BtnOpc2
        '
        Me.BtnOpc2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpc2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnOpc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpc2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnOpc2.Image = Global.IGM.My.Resources.Resources.group
        Me.BtnOpc2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOpc2.Location = New System.Drawing.Point(0, 212)
        Me.BtnOpc2.Name = "BtnOpc2"
        Me.BtnOpc2.Size = New System.Drawing.Size(196, 38)
        Me.BtnOpc2.TabIndex = 1
        Me.BtnOpc2.Text = "Recursos Humanos"
        Me.BtnOpc2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnOpc2.UseVisualStyleBackColor = False
        Me.BtnOpc2.Visible = False
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.Black
        Me.TreeView1.ImageIndex = 10
        Me.TreeView1.ImageList = Me.Imagenes
        Me.TreeView1.ItemHeight = 22
        Me.TreeView1.LineColor = System.Drawing.Color.Blue
        Me.TreeView1.Location = New System.Drawing.Point(11, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode5.Name = "Node3"
        TreeNode5.Text = "Node3"
        TreeNode6.Name = "Node1"
        TreeNode6.Text = "Node1"
        TreeNode7.Name = "Node2"
        TreeNode7.Text = "Node2"
        TreeNode8.ImageIndex = 1
        TreeNode8.Name = "Prueba"
        TreeNode8.SelectedImageIndex = 3
        TreeNode8.Text = "Node0"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.TreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TreeView1.SelectedImageIndex = 11
        Me.TreeView1.ShowLines = False
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(604, 509)
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
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Image = Global.IGM.My.Resources.Resources.group
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Plataforma de Servicios"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Text = "IGM"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnOpc2 As System.Windows.Forms.Button
    Friend WithEvents Imagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnOp1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TSS1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSS2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TSS3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnOpc3 As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
