
Public Class frm_Menu
    Private Sub LeeOpciones(Codigo As String, Caption As String)
        Conexion = New SqlClient.SqlConnection(MemConnect)
        Conexion.Open()

        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader


        tmpQry.Connection = Conexion
        tmpQry.CommandText = "Select * from Seg_OpcionesMenu where CodigoOpcion like '" & Codigo & ".%' and visible = 1 order by CodigoOpcion"
        leeSQL = tmpQry.ExecuteReader
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(Codigo, Caption)
        TreeView1.Nodes(Codigo).ForeColor = Color.Blue
        TreeView1.Nodes(Codigo).NodeFont = New Font(TreeView1.Font, FontStyle.Bold)

        TreeView1.Nodes(Codigo).SelectedImageIndex = 3

        Dim indice As Integer
        Dim i1 As Integer
        Dim i2 As Integer
        Dim i3 As Integer
        Dim r1 As String
        Dim r2 As String
        Dim r3 As String

        Do While leeSQL.Read
            Codigo = leeSQL.Item(0)
            Caption = leeSQL.Item(1)
            Dim raiz As String = Codigo
            raiz = raiz.Substring(0, raiz.Length - 3)

            If Len(Codigo) = 5 Then
                indice = TreeView1.Nodes.IndexOfKey(raiz)
                If indice >= 0 Then
                    TreeView1.Nodes(indice).Nodes.Add(Codigo, Caption)
                End If
            End If

            If Len(Codigo) = 8 Then
                r1 = Codigo.Substring(0, 2)
                r2 = Codigo.Substring(0, 5)
                i1 = TreeView1.Nodes.IndexOfKey(r1)
                i2 = TreeView1.Nodes(i1).Nodes.IndexOfKey(r2)
                TreeView1.Nodes(i1).Nodes(i2).Nodes.Add(Codigo, Caption)
            End If
            If Len(Codigo) = 11 Then
                r1 = Codigo.Substring(0, 2)
                r2 = Codigo.Substring(0, 5)
                r3 = Codigo.Substring(0, 8)
                i1 = TreeView1.Nodes.IndexOfKey(r1)
                i2 = TreeView1.Nodes(i1).Nodes.IndexOfKey(r2)
                i3 = TreeView1.Nodes(i1).Nodes(i2).Nodes.IndexOfKey(r3)
                TreeView1.Nodes(i1).Nodes(i2).Nodes(i3).Nodes.Add(Codigo, Caption)
            End If

        Loop



        Conexion.Close()
        TreeView1.Nodes(0).Expand()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOp1.Click
        LeeOpciones("01", "Finanzas    ")
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub frm_Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        TSS1.Text = MemDatabase & " @ " & MemServer
        TSS2.Text = Today.ToShortDateString
        TSS3.Text = MemUsuarioSistema
        Button2_Click(sender, e)
    End Sub

    Private Sub frm_Menu_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged


    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub TreeView1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)

        If Not e.Node.IsExpanded Then
            e.Node.Expand()
        Else
            e.Node.Collapse()
        End If

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LeeOpciones("99", "Configuracion y Administracion del Sistema       ")
    End Sub

    Private Sub BtnOpc2_Click(sender As Object, e As EventArgs) Handles BtnOpc2.Click
        LeeOpciones("02", "Recursos Humanos    ")
    End Sub

    Private Sub TreeView1_Click1(sender As Object, e As EventArgs) Handles TreeView1.Click
        Dim mousePos As Point = TreeView1.PointToClient(Control.MousePosition)
        Dim node As TreeNode = Me.TreeView1.GetNodeAt(mousePos)
        If node IsNot Nothing Then
            Dim textArea As RectangleF = node.Bounds
            If textArea.Contains(mousePos) Then
                node.Toggle()
            End If
        End If
    End Sub

    

    Private Sub TreeView1_DoubleClick(sender As Object, e As EventArgs) Handles TreeView1.DoubleClick

        If TreeView1.SelectedNode.Name = "01.01.02" Then
            frm_Report.Show()
            Exit Sub
        End If

        Conexion = New SqlClient.SqlConnection(MemConnect)
        Conexion.Open()

        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader

        tmpQry.Connection = Conexion
        tmpQry.CommandText = "Select * from Seg_OpcionesMenu where CodigoOpcion ='" & TreeView1.SelectedNode.Name & "'"
        leeSQL = tmpQry.ExecuteReader

        If leeSQL.HasRows = False Then
            MsgBox("No existe Opcion", vbExclamation)
            Conexion.Close()
            Exit Sub
        End If

        Dim NombreObjeto As String = ""
        Do While leeSQL.Read

            If IsDBNull(leeSQL("Objeto")) Then
                Conexion.Close()
                Exit Sub
            Else
                NombreObjeto = leeSQL("Objeto")

            End If
        Loop
        Conexion.Close()

        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        Dim objForm As Form
        Dim sValue As String
        Dim FullTypeName As String
        Dim FormInstanceType As Type
        sValue = NombreObjeto
        FullTypeName = Application.ProductName & "." & sValue
        FormInstanceType = Type.GetType(FullTypeName, True, True)
        objForm = CType(Activator.CreateInstance(FormInstanceType), Form)
        objForm.Show()

        System.Windows.Forms.Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnOpc3_Click(sender As Object, e As EventArgs) Handles btnOpc3.Click
        LeeOpciones("02", "Activos Fijos    ")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        LeeOpciones("04", "Plataforma de Servicios       ")
    End Sub
End Class


