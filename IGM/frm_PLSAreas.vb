Public Class frm_PLSAreas
    Private Sub get_areas()
        Conexion.Open()
        Dim dummy As String
        dummy = "select Area as Codidog,descripcionarea as Descripcion ,iif(PermiteBorrar=1,'Si','No') as [Permite Borrar] from plsareas order by 1"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGAreas.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub Get_Users(Codigo As String)
        Try
            lstEncarg.Items.Clear()
            Conexion.Open()
            Dim tmpQry As New SqlClient.SqlCommand
            Dim leeSQL As SqlClient.SqlDataReader
            tmpQry.Connection = Conexion

            Dim dummy As String

            dummy = "select us.CodUsuario,us.Nombre,x.CodUsuario as Existe from seg_usuarios US left join "
            dummy = dummy & "(Select Ea.CodUsuario,Area from PLSEncargadosArea EA INNER JOIN SEG_Usuarios u ON U.CodUsuario=EA.CodUsuario  where area='" & Codigo & "') x "
            dummy = dummy & "on x.CodUsuario=us.CodUsuario "
            dummy = dummy & "order by CodUsuario, Existe"

            tmpQry.CommandText = dummy
            leeSQL = tmpQry.ExecuteReader
            Dim x As Integer = 0
            While leeSQL.Read
                lstEncarg.Items.Add(leeSQL("CodUsuario") & " " & leeSQL("Nombre"))
                x = lstEncarg.Items.Count - 1
                If Not IsDBNull(leeSQL("Existe")) Then lstEncarg.SetItemChecked(x, True)
            End While
            Conexion.Close()
        Catch er As Exception
            MsgBox(er.Message)
        End Try
    End Sub
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub frm_PLSAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_areas()
        Get_Users("")
    End Sub

    Private Sub DGAreas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAreas.CellClick
        Dim r As Integer
        r = DGAreas.CurrentCell.RowIndex
        TxCod.Text = DGAreas.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGAreas.Rows(r).Cells(1).Value.ToString
        chkElimina.Checked = DGAreas.Rows(r).Cells(2).Value.ToString = "Si"
        Get_Users(TxCod.Text)
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        btn_New.Enabled = False : btn_Edit.Enabled = False : btn_Delete.Enabled = False : btn_Save.Enabled = True : btn_Undo.Enabled = True : chkElimina.Enabled = False
        TxCod.Text = "" : TxNombre.Text = ""
        TxCod.Enabled = True : TxNombre.Enabled = True : DGAreas.Enabled = False : lstEncarg.Enabled = True
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbInformation)
            Exit Sub
        End If
        btn_New.Enabled = False : btn_Edit.Enabled = False : btn_Delete.Enabled = False : btn_Save.Enabled = True : btn_Undo.Enabled = True : chkElimina.Enabled = False
        chkElimina.Checked = False
        TxCod.Enabled = False : TxNombre.Enabled = True : DGAreas.Enabled = False : lstEncarg.Enabled = True
    End Sub

    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        btn_New.Enabled = True : btn_Edit.Enabled = True : btn_Delete.Enabled = True : btn_Save.Enabled = False : btn_Undo.Enabled = False : chkElimina.Enabled = True
        TxCod.Text = "" : TxNombre.Text = ""
        TxCod.Enabled = True : TxNombre.Enabled = False : DGAreas.Enabled = True : lstEncarg.Enabled = False
    End Sub



    Private Sub TxCod_LostFocus(sender As Object, e As EventArgs) Handles TxCod.LostFocus
        Conexion.Open()
        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader
        tmpQry.Connection = Conexion

        Dim dummy As String = "select top 1 * from PLSAreas where Area='" & TxCod.Text & "'"

        tmpQry.CommandText = dummy
        leeSQL = tmpQry.ExecuteReader
        Dim x As Integer = 0
        While leeSQL.Read
            MsgBox("El area " & TxCod.Text & " ya existe.  Por favor verifique", vbExclamation)
            TxCod.SelectAll() : TxCod.Focus()
            Exit Sub
        End While
        Conexion.Close()
    End Sub

  
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        btn_New.Enabled = True : btn_Edit.Enabled = True : btn_Delete.Enabled = True : btn_Undo.Enabled = False : btn_Save.Enabled = False
        TxCod.Enabled = False : TxNombre.Enabled = False : DGAreas.Enabled = True : lstEncarg.Enabled = False
        chkElimina.Enabled = False

        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from PLSAreas where Area='" & TxCod.Text & "'", Conexion)
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

        'Borra y graba la asociacion entre usuarios y areas
        Conexion.Open()
        Dim tmpQry As String = "Delete from PLSEncargadosArea where Area='" & TxCod.Text & "'"
        DC = New SqlClient.SqlCommand(tmpQry, Conexion)
        DC.ExecuteNonQuery()
        Conexion.Close()
        Dim dummy As String
        For Each item In lstEncarg.CheckedItems
            dummy = item.ToString : dummy = dummy.Substring(0, InStr(dummy, " ") - 1)
            tmpQry = "Insert into PLSEncargadosArea Values(" & dummy & ",'" & TxCod.Text & "')"
            Conexion.Open()
            DC.CommandText = tmpQry : DC.ExecuteNonQuery()
            Conexion.Close()
        Next item

        Dim x As Integer = 0
        If chkElimina.Checked Then x = 1
        If nuevo Then
            'obtiene nuevo codigo
            Conexion.Open()
            tmpQry = "Insert into PLSAreas (Area,DescripcionArea,PermiteBorrar,Ingreso,F_Ingreso) "
            tmpQry = tmpQry & "Values('" & TxCod.Text & "','" & TxNombre.Text & "'," & x.ToString & ",'" & MemUsuario & "',GETDATE())"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update PLSAreas set DescripcionArea='" & TxNombre.Text
            tmpQry = tmpQry & "',PermiteBorrar=" & x.ToString
            tmpQry = tmpQry & ",Modifico='" & MemUsuario
            tmpQry = tmpQry & "',F_Modifico= getdate() where Area='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If
        get_areas()
        Get_Users(TxCod.Text)
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun codigo seleccionado", vbInformation)
            Exit Sub
        End If

        Try
            If MsgBox("Esta seguro que desea eliminar el codigo " & TxCod.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then

                Dim tmpQry As String = "delete from PLSEncargadosArea where Area='" & TxCod.Text & "'"
                Dim DC As New SqlClient.SqlCommand(tmpQry, Conexion)
                Conexion.Open()
                DC.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                tmpQry = "Delete from PLSAreas where Area='" & TxCod.Text & "'"
                DC = New SqlClient.SqlCommand(tmpQry, Conexion)
                DC.ExecuteNonQuery()

                Conexion.Close()
                get_areas()
                Get_Users("")
                MsgBox("El codigo se borro exitosamente", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub DGAreas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAreas.CellContentClick

    End Sub
End Class