Public Class frm_SEGAcceso
    Private Sub get_users()
        Conexion.Open()
        Dim dummy As String
        dummy = "Select Usuario,Nombre from seg_usuarios"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGUser.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub ObtieneOpciones(ByVal nodo As TreeNode, ByRef ListaNodos As String)
        If nodo.Checked Then ListaNodos = ListaNodos & nodo.Name & "|"
        If nodo.Nodes.Count > 0 Then
            For a = 0 To nodo.Nodes.Count - 1
                ObtieneOpciones(nodo.Nodes(a), ListaNodos)
            Next a
        End If

    End Sub

    Private Sub GrabaCambios()
        Dim r As Integer = DGUser.CurrentCell.RowIndex
        Dim U As String = DGUser.Rows(r).Cells(0).Value.ToString
        Dim CodUser As Integer = 0
        If MsgBox("Desea guardar los cambios al usuario " & U & "?", vbQuestion + vbYesNo + vbDefaultButton1) = vbYes Then
            Conexion.Open()
            Dim DC As New SqlClient.SqlCommand("Select CodUsuario from SEG_Usuarios where Usuario='" & U & "'", Conexion)
            Dim DR As SqlClient.SqlDataReader : DR = DC.ExecuteReader
            While DR.Read
                CodUser = DR("CodUsuario")
            End While
            Conexion.Close()
            Dim Opciones As String = ""
            Dim Opcion As String = ""
            Conexion.Open()
            Dim tmpq = New SqlClient.SqlCommand("delete from SEG_OpcionesUsuario Where CodUsuario=" & CodUser.ToString, Conexion)
            tmpq.ExecuteNonQuery()
            Conexion.Close()

            ObtieneOpciones(tvOpciones.Nodes(0), Opciones)
            While Opciones.Length > 0
                Opcion = Opciones.Substring(0, InStr(Opciones, "|") - 1)
                Opciones = Opciones.Substring(InStr(Opciones, "|"))
                Conexion.Open()
                tmpq = New SqlClient.SqlCommand("Insert into SEG_OpcionesUsuario values(" & CodUser.ToString & ",'" & Opcion & "')", Conexion)
                tmpq.ExecuteNonQuery()
                Conexion.Close()
            End While

        End If

        HayCambios = False
    End Sub
    Dim HayCambios As Boolean = False
    Private Sub Get_Opciones()
        Try

            'Obtiene el codigo del Usuario
            Dim r As Integer = DGUser.CurrentCell.RowIndex
            Dim U As String = DGUser.Rows(r).Cells(0).Value.ToString
            Dim CodUser As Integer = 0
            Conexion.Open()
            Dim DC As New SqlClient.SqlCommand("Select CodUsuario from SEG_Usuarios where Usuario='" & U & "'", Conexion)
            Dim DR As SqlClient.SqlDataReader : DR = DC.ExecuteReader
            While DR.Read
                CodUser = DR("CodUsuario")
            End While
            Conexion.Close()

            'Conexion = New SqlClient.SqlConnection(MemConnect)
            Conexion.Open()
            Dim tmpQry As New SqlClient.SqlCommand
            Dim leeSQL As SqlClient.SqlDataReader
            tmpQry.Connection = Conexion
            tmpQry.CommandText = "Select * from Seg_OpcionesMenu order by CodigoOpcion"
            leeSQL = tmpQry.ExecuteReader
            tvOpciones.Nodes.Clear()
            tvOpciones.Nodes.Add("X", "Opciones del Sistema")
            Dim dummy As String = ""
            While leeSQL.Read
                Dim Nodo As New TreeNode
                dummy = leeSQL("CodigoOpcion")
                If dummy.Length > 2 Then dummy = dummy.Substring(0, dummy.Length - 3) Else dummy = "X"
                Nodo.Name = leeSQL("CodigoOpcion")
                Nodo.Text = leeSQL("Descripcion")
                Nodo.Checked = Funciones.Acceso(CodUser, leeSQL("CodigoOpcion"))
                If dummy.Length > 0 Then
                    For a = 0 To tvOpciones.Nodes.Count - 1
                        If tvOpciones.Nodes(a).Name = dummy Then tvOpciones.Nodes(a).Nodes.Add(Nodo)
                        If tvOpciones.Nodes(a).Nodes.Count > 0 Then
                            For b = 0 To tvOpciones.Nodes(a).Nodes.Count - 1
                                If tvOpciones.Nodes(a).Nodes(b).Name = dummy Then tvOpciones.Nodes(a).Nodes(b).Nodes.Add(Nodo)
                                If tvOpciones.Nodes(a).Nodes(b).Nodes.Count > 0 Then
                                    For c = 0 To tvOpciones.Nodes(a).Nodes(b).Nodes.Count - 1
                                        If tvOpciones.Nodes(a).Nodes(b).Nodes(c).Name = dummy Then tvOpciones.Nodes(a).Nodes(b).Nodes(c).Nodes.Add(Nodo)
                                        '---------------
                                        If tvOpciones.Nodes(a).Nodes(b).Nodes(c).Nodes.Count > 0 Then
                                            For d = 0 To tvOpciones.Nodes(a).Nodes(b).Nodes(c).Nodes.Count - 1
                                                If tvOpciones.Nodes(a).Nodes(b).Nodes(c).Nodes(d).Name = dummy Then tvOpciones.Nodes(a).Nodes(b).Nodes(c).Nodes(d).Nodes.Add(Nodo)
                                            Next
                                        End If
                                        '---------------
                                    Next
                                End If
                            Next
                        End If
                        'tvOpciones.Nodes(dummy).Nodes.Add(Nodo)
                    Next a
                Else
                    tvOpciones.Nodes.Add(Nodo)
                End If
            End While
            Conexion.Close()
            tvOpciones.Nodes(0).Expand()
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub
    Private Sub frm_SEGAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_users()
        Get_Opciones()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tvOpciones_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvOpciones.AfterCheck
        For Each node As TreeNode In e.Node.Nodes
            node.Checked = e.Node.Checked
        Next

        'Dim childNodeCK As TreeNode = e.Node
        'Dim NodeChecked As Boolean = e.Node.Checked

        'For Each ChildNode As TreeNode In childNodeCK.Nodes
        '    If NodeChecked = True Then
        '        ChildNode.Checked = NodeChecked
        '    End If
        'Next

        'If childNodeCK.Checked = False Then
        '    If e.Node.Parent Is Nothing = False Then
        '        e.Node.Parent.Checked = False
        '    End If
        'End If
        HayCambios = True
    End Sub



    Private Sub DGUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUser.CellClick
        Get_Opciones()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GrabaCambios()
    End Sub

    Private Sub DGUser_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGUser.CellLeave
        If HayCambios Then
            GrabaCambios()
        End If
    End Sub

    Private Sub DGUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUser.CellContentClick

    End Sub
End Class