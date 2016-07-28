
Public Class frm_Usuarios
    Private Sub get_users()
        Conexion.Open()
        Dim dummy As String
        dummy = "Select usuario,nombre from seg_usuarios"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGUsers.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub frm_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_users()
    End Sub

    Private Sub DGUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsers.CellClick
        Dim r As Integer
        r = DGUsers.CurrentCell.RowIndex
        TxUsuario.Text = DGUsers.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGUsers.Rows(r).Cells(1).Value.ToString

        Conexion = New SqlClient.SqlConnection(MemConnect)
        Conexion.Open()

        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader

        tmpQry.Connection = Conexion
        tmpQry.CommandText = "Select * from Seg_Usuarios where Usuario='" & TxUsuario.Text & "'"
        leeSQL = tmpQry.ExecuteReader
        Dim clave As String = ""
        Do While leeSQL.Read
            TxClave1.Text = leeSQL.Item("Clave")
            TxClave2.Text = TxClave1.Text
        Loop
        Conexion.Close()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        btn_Save.Enabled = True
        btn_Undo.Enabled = True
        btn_New.Enabled = False
        btn_Edit.Enabled = False
        btn_Delete.Enabled = False
        TxUsuario.Enabled = True
        TxNombre.Enabled = True
        TxClave1.Enabled = True
        TxClave2.Enabled = True
        DGUsers.Enabled = False
        TxUsuario.Text = ""
        TxNombre.Text = ""
        TxClave1.Text = ""
        TxClave2.Text = ""
        TxUsuario.Focus()
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If TxUsuario.Text = "" Then
            MsgBox("No hay ningun usuario seleccionado", vbInformation)
            Exit Sub
        End If
        btn_Save.Enabled = True
        btn_Undo.Enabled = True
        btn_New.Enabled = False
        btn_Edit.Enabled = False
        btn_Delete.Enabled = False
        TxUsuario.Enabled = True
        TxNombre.Enabled = True
        TxClave1.Enabled = True
        TxClave2.Enabled = True
        DGUsers.Enabled = False

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If TxClave1.Text <> TxClave2.Text Then
            MsgBox("La clave de acceso no coincide.  Favor verificar", vbExclamation)
            TxClave1.Focus()
            Exit Sub

        End If

        btn_Save.Enabled = False
        btn_Undo.Enabled = False
        btn_New.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        TxUsuario.Enabled = False
        TxNombre.Enabled = False
        TxClave1.Enabled = False
        TxClave2.Enabled = False
        DGUsers.Enabled = True

        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from SEG_Usuarios where usuario='" & TxUsuario.Text & "'", Conexion)
        Dim DR As SqlClient.SqlDataReader
        DR = DC.ExecuteReader
        Dim nuevo As Boolean = True
        Do While DR.Read
            nuevo = False
        Loop
        Conexion.Close()

        If Not nuevo Then
            If vbNo = MsgBox("El registro ya existe. Desea actualizarlo?", vbQuestion + vbYesNo + vbDefaultButton1) Then
                Exit Sub
            End If
        End If

        If nuevo Then
            'obtiene nuevo codigo
            Conexion.Open()
            DC.CommandText = "Select max(codusuario) from SEG_Usuarios"
            DR = DC.ExecuteReader
            Dim cons As Integer = 0
            Do While DR.Read
                cons = DR.Item(0) + 1
            Loop
            Conexion.Close()
            Conexion.Open()
            Dim tmpQry As String = "Insert into SEG_USUARIOS (CodUsuario,Usuario,Nombre,Clave) "
            tmpQry = tmpQry & "Values(" & cons & ",'" & TxUsuario.Text & "','" & TxNombre.Text & "','" & TxClave1.Text & "')"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            Dim tmpqry As String = "Update SEG_Usuarios set Nombre='" & TxNombre.Text & "',Clave='" & TxClave1.Text & "' where usuario='" & TxUsuario.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpqry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If



        get_users()
    End Sub

    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        TxUsuario.Text = ""
        TxNombre.Text = ""
        TxClave1.Text = ""
        TxClave2.Text = ""
        btn_Save.Enabled = False
        btn_Undo.Enabled = False
        btn_New.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        TxUsuario.Enabled = False
        TxNombre.Enabled = False
        TxClave1.Enabled = False
        TxClave2.Enabled = False
        DGUsers.Enabled = True
        get_users()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If TxUsuario.Text = "" Then
            MsgBox("No hay ningun usuario seleccionado", vbInformation)
            Exit Sub
        End If

        If MsgBox("Esta seguro que desea eliminar al usuario " & TxUsuario.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
            Dim tmpQry As String = "Delete from SEG_Usuarios where usuario='" & TxUsuario.Text & "'"
            Dim DC As New SqlClient.SqlCommand(tmpQry, Conexion)
            Conexion.Open()
            DC.ExecuteNonQuery()
            Conexion.Close()
            get_users()
            MsgBox("El usuario se borro exitosamente", vbInformation)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_REP.Show()
    End Sub

    Private Sub DGUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGUsers.CellContentClick

    End Sub

    Private Sub TxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxUsuario.TextChanged

    End Sub
End Class

