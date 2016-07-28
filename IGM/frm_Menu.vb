
Public Class frm_Menu
    Private Sub CargaOpcionesMenu()
        'Revisa que Opciones mostrar
        Dim Posicion As Integer = 3
        Conexion = New SqlClient.SqlConnection(MemConnect)
        Conexion.Open()
        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader
        tmpQry.Connection = Conexion
        'Financiero
        tmpQry.CommandText = "Select * from vw_seg_opcionesMenuUsuario where CodigoOpcion ='01' and CodUsuario=" & MemCodigoUsuario.ToString
        leeSQL = tmpQry.ExecuteReader
        While leeSQL.Read
            btnOp1.Visible = leeSQL("Visible")
            If btnOp1.Visible Then
                btnOp1.Top = Posicion : Posicion = Posicion + 39
            End If
        End While
        Conexion.Close()
        'Activos Fijos
        Conexion.Open()
        tmpQry.CommandText = "Select * from vw_seg_opcionesMenuUsuario where CodigoOpcion ='02' and CodUsuario=" & MemCodigoUsuario.ToString
        leeSQL = tmpQry.ExecuteReader
        While leeSQL.Read
            btnOpc3.Visible = leeSQL("Visible")
            If btnOpc3.Visible Then
                btnOpc3.Top = Posicion : Posicion = Posicion + 39
            End If

        End While
        Conexion.Close()
        'Plataforma de Servicios
        Conexion.Open()
        tmpQry.CommandText = "Select * from vw_seg_opcionesMenuUsuario where CodigoOpcion ='04' and CodUsuario=" & MemCodigoUsuario.ToString
        leeSQL = tmpQry.ExecuteReader
        While leeSQL.Read
            btnOpc5.Visible = leeSQL("Visible")
            If btnOpc5.Visible Then
                btnOpc5.Top = Posicion : Posicion = Posicion + 39
            End If

        End While
        Conexion.Close()

        'Recursos Humanos
        BtnOpc2.Visible = False
        Conexion.Open()
        tmpQry.CommandText = "Select * from vw_seg_opcionesMenuUsuario where CodigoOpcion ='05' and CodUsuario=" & MemCodigoUsuario.ToString
        leeSQL = tmpQry.ExecuteReader
        While leeSQL.Read
            BtnOpc2.Visible = leeSQL("Visible")
            If BtnOpc2.Visible Then
                BtnOpc2.Top = Posicion : Posicion = Posicion + 39
            End If

        End While
        Conexion.Close()

        'Opciones del sistema
        Conexion.Open()
        tmpQry.CommandText = "Select * from vw_seg_opcionesMenuUsuario where CodigoOpcion ='99' and CodUsuario=" & MemCodigoUsuario.ToString
        leeSQL = tmpQry.ExecuteReader
        While leeSQL.Read
            btnOpc4.Visible = leeSQL("Visible")
            If btnOpc4.Visible Then
                btnOpc4.Top = Posicion : Posicion = Posicion + 39
            End If

        End While
        Conexion.Close()
    End Sub
    Private Sub LeeOpciones(Codigo As String, Caption As String)
        Conexion = New SqlClient.SqlConnection(MemConnect)
        Conexion.Open()

        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader


        tmpQry.Connection = Conexion
        '
        'tmpQry.CommandText = "Select * from Seg_OpcionesMenu where CodigoOpcion like '" & Codigo & ".%' and visible = 1 order by CodigoOpcion"
        tmpQry.CommandText = "Select * from vw_SEG_OpcionesMenuUsuario where CodUsuario=" & MemCodigoUsuario & " and CodigoOpcion like '" & Codigo & ".%' and  visible = 1 order by CodigoOpcion"
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
        ImagenMenu.Image = btnOp1.Image
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub frm_Menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbNomCia.Text = MemNombreCompania
        TSS1.Text = MemDatabase & " @ " & MemServer
        TSS2.Text = Today.ToShortDateString
        TSS3.Text = MemUsuarioSistema

        CargaOpcionesMenu()
        If btnOp1.Top = 3 Then Button2_Click(sender, e)
        If BtnOpc2.Top = 3 Then BtnOpc2_Click(sender, e)
        If btnOpc3.Top = 3 Then btnOpc3_Click(sender, e)
        If btnOpc4.Top = 3 Then Button1_Click(sender, e)
        If btnOpc5.Top = 3 Then Button2_Click_1(sender, e)
    End Sub



    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)

        If Not e.Node.IsExpanded Then
            e.Node.Expand()
        Else
            e.Node.Collapse()
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOpc4.Click
        LeeOpciones("99", "Configuracion y Administracion del Sistema       ")
        ImagenMenu.Image = btnOpc4.Image
    End Sub

    Private Sub BtnOpc2_Click(sender As Object, e As EventArgs) Handles BtnOpc2.Click
        LeeOpciones("05", "Recursos Humanos    ")
        ImagenMenu.Image = BtnOpc2.Image
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
        Try

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

            'Dim objForm As Form
            Dim sValue As String
            Dim FullTypeName As String
            Dim FormInstanceType As Type
            sValue = NombreObjeto
            FullTypeName = Application.ProductName & "." & sValue
            FormInstanceType = Type.GetType(FullTypeName, True, True)
            MemObjForm = CType(Activator.CreateInstance(FormInstanceType), Form)
            MemObjForm.Show()

            System.Windows.Forms.Cursor.Current = Cursors.Default
        Catch er As Exception
            MsgBox(er.Message)
        End Try



    End Sub

    Private Sub btnOpc3_Click(sender As Object, e As EventArgs) Handles btnOpc3.Click
        LeeOpciones("02", "Activos Fijos    ")
        ImagenMenu.Image = btnOpc3.Image
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnOpc5.Click
        LeeOpciones("04", "Plataforma de Servicios       ")
        ImagenMenu.Image = btnOpc5.Image
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class


