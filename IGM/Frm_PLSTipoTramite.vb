Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_PLSTipoTramite
    Dim ConnectionInfo As ConnectionInfo

    Private Sub get_Tipos()
        Conexion.Open()
        Dim dummy As String
        dummy = "select TipoTramite as Tipo,NombreTramite as Nombre,DiasTramite as Dias from PLSTipos"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGTramites.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub get_Requisitos(Codigo As String)
        Try
            lstReq.Items.Clear()
            Conexion.Open()
            Dim tmpQry As New SqlClient.SqlCommand
            Dim leeSQL As SqlClient.SqlDataReader
            tmpQry.Connection = Conexion

            Dim dummy As String
            dummy = "SELECT x.Requisitos,R.Requisito as Codigo,r.NombreRequisito as Nombre FROM plsrequisitos R left join "
            dummy = dummy & "(select TipoTramite as Tipo,NombreTramite as Nombre,DiasTramite as Dias,TR.Requisitos from PLSTipos T "
            dummy = dummy & "INNER join PLSTipoRequisitos TR on t.TipoTramite = tr.Tipo "
            dummy = dummy & "where t.TipoTramite='" & Codigo & "')  X "
            dummy = dummy & "on x.Requisitos = r.Requisito "
            dummy = dummy & "order by Requisitos desc, Requisito asc"

            tmpQry.CommandText = dummy
            leeSQL = tmpQry.ExecuteReader
            Dim x As Integer = 0
            While leeSQL.Read
                lstReq.Items.Add(leeSQL("Codigo") & " " & leeSQL("Nombre"))
                x = lstReq.Items.Count - 1
                If Not IsDBNull(leeSQL("REquisitos")) Then lstReq.SetItemChecked(x, True)
            End While
            Conexion.Close()
        Catch er As Exception
            MsgBox(er.Message)
        End Try
    End Sub
    Private Sub frm_PLSTipoTramite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_Tipos()
        Dim c As String
        get_Requisitos(c)
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub DGTramites_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTramites.CellClick
        Dim r As Integer
        r = DGTramites.CurrentCell.RowIndex
        TxCod.Text = DGTramites.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGTramites.Rows(r).Cells(1).Value.ToString
        TxDias.Text = DGTramites.Rows(r).Cells(2).Value.ToString
        get_Requisitos(TxCod.Text)
    End Sub

    Private Sub DGTramites_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTramites.CellContentClick

    End Sub

    Private Sub TxNombre_TextChanged(sender As Object, e As EventArgs) Handles TxNombre.TextChanged

    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        TxCod.Enabled = True : TxCod.Text = ""
        TxDias.Enabled = True : TxDias.Text = "0"
        lstReq.Enabled = True
        TxNombre.Enabled = True : TxNombre.Text = ""
        DGTramites.Enabled = False
        btn_New.Enabled = False
        btn_Save.Enabled = True
        btn_Delete.Enabled = False
        btn_Undo.Enabled = True
        btn_Edit.Enabled = False
        get_Requisitos("")
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbEmpty)
            Exit Sub
        End If
        DGTramites.Enabled = False
        btn_New.Enabled = False
        btn_Save.Enabled = True
        btn_Delete.Enabled = False
        btn_Undo.Enabled = True
        btn_Edit.Enabled = False
        TxDias.Enabled = True
        TxNombre.Enabled = True
        lstReq.Enabled = True
    End Sub

    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        TxCod.Enabled = False : TxCod.Text = ""
        TxDias.Enabled = False : TxDias.Text = ""
        TxNombre.Enabled = False : TxNombre.Text = ""
        DGTramites.Enabled = True
        lstReq.Enabled = False
        btn_New.Enabled = True
        btn_Save.Enabled = False
        btn_Delete.Enabled = True
        btn_Undo.Enabled = False
        btn_Edit.Enabled = True
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        btn_New.Enabled = True : btn_Save.Enabled = False : btn_Delete.Enabled = True
        btn_Undo.Enabled = False : btn_Edit.Enabled = True : DGTramites.Enabled = True
        lstReq.Enabled = False : TxCod.Enabled = False
        TxDias.Enabled = False : TxNombre.Enabled = False

        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from PLSTipos where TipoTramite='" & TxCod.Text & "'", Conexion)
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
        'Borra y graba la asociacion entre tramites y requisitos
        Conexion.Open()
        Dim tmpQry As String = "Delete from PLSTipoRequisitos where Tipo='" & TxCod.Text & "'"
        DC = New SqlClient.SqlCommand(tmpQry, Conexion)
        DC.ExecuteNonQuery()
        Conexion.Close()
        Dim dummy As String
        For Each item In lstReq.CheckedItems
            dummy = item.ToString : dummy = dummy.Substring(0, InStr(dummy, " ") - 1)
            tmpQry = "Insert into PLSTipoRequisitos Values('" & TxCod.Text & "','" & dummy & "')"
            Conexion.Open()
            DC.CommandText = tmpQry : DC.ExecuteNonQuery()
            Conexion.Close()
        Next item

        If nuevo Then
            'obtiene nuevo codigo
            Conexion.Open()
            tmpQry = "Insert into PLSTipos (RTipoTramite,NombreTramite,DiasTramite,Ingreso,F_Ingreso) "
            tmpQry = tmpQry & "Values('" & TxCod.Text & "','" & TxNombre.Text & "'," & TxDias.Text & ",'" & MemUsuario & "',GETDATE())"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update PLSTipos set NombreTramite='" & TxNombre.Text
            tmpQry = tmpQry & "',DiasTramite=" & TxDias.Text
            tmpQry = tmpQry & ",Modifico='" & MemUsuario
            tmpQry = tmpQry & "',F_Modifico= getdate() where TipoTramite='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If
        get_Requisitos(TxCod.Text)
        get_Tipos()

    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun codigo seleccionado", vbInformation)
            Exit Sub
        End If

        Try
            If MsgBox("Esta seguro que desea eliminar el codigo " & TxCod.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then

                Dim tmpQry As String = "delete from PLSTipoRequisitos where tipo='" & TxCod.Text & "'"
                Dim DC As New SqlClient.SqlCommand(tmpQry, Conexion)
                Conexion.Open()
                DC.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                tmpQry = "Delete from PLSTipos where TipoTramite='" & TxCod.Text & "'"
                DC = New SqlClient.SqlCommand(tmpQry, Conexion)
                DC.ExecuteNonQuery()

                Conexion.Close()
                get_Tipos()
                get_Requisitos("")
                MsgBox("El codigo se borro exitosamente", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxCod_LostFocus(sender As Object, e As EventArgs) Handles TxCod.LostFocus
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from PLSTipos where TipoTramite='" & TxCod.Text & "'", Conexion)
        Dim DR As SqlClient.SqlDataReader
        DR = DC.ExecuteReader
        Dim nuevo As Boolean = True
        Do While DR.Read
            TxNombre.Text = DR("NombreTramite")
            TxDias.Text = DR("DiasTramite")
            Dim res As Boolean
            If MsgBox("El codigo " & TxCod.Text & " ya existe. Desea editarlo", vbYesNo + vbQuestion + vbDefaultButton2) = MsgBoxResult.No Then
                TxNombre.Text = "" : TxCod.Text = "" : TxDias.Text = ""
                TxCod.Focus()
                Conexion.Close()
                Exit Sub
            End If
        Loop
        Conexion.Close()
    End Sub

    Private Sub TxCod_TextChanged(sender As Object, e As EventArgs) Handles TxCod.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_PLSTipoTramite
        connectionInfo.ServerName = MemServer
        connectionInfo.DatabaseName = MemDatabase
        connectionInfo.IntegratedSecurity = True
        SetDBLogonForReport(connectionInfo, cr)
        cr.Refresh()
        frm_REP.CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("NombreCompania", MemNombreCompania)
        frm_REP.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class