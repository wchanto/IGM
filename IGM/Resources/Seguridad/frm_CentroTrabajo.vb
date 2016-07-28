Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_CentroTrabajo

    Private Sub frm_CentroTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_Centros()
    End Sub
    Private Sub Habilita(Hab As Boolean)
        TxCod.Enabled = Hab
        txBanco.Enabled = Hab
        txCuenta.Enabled = Hab
        txGrupo.Enabled = Hab
        TxNombre.Enabled = Hab
    End Sub
    Private Sub get_Centros()
        Conexion.Open()
        Dim dummy As String
        dummy = "select CentroTrab, Descripcion, Banco, Cuenta, GrupoContable from centrotrabajo order by 1"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGCentros.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        Habilita(True)
        TxCod.Text = "" : txBanco.Text = "" : txCuenta.Text = "" : txGrupo.Text = "" : TxNombre.Text = ""
        DGCentros.Enabled = False
        btn_New.Enabled = False
        btn_Save.Enabled = True
        btn_Undo.Enabled = True
        btn_Delete.Enabled = False
        btn_Edit.Enabled = False
        TxCod.Focus()

    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbExclamation)
            Exit Sub
        End If
        Habilita(True)
        DGCentros.Enabled = False
        btn_New.Enabled = False
        btn_Save.Enabled = True
        btn_Undo.Enabled = True
        btn_Delete.Enabled = False
        btn_Edit.Enabled = False
        TxCod.Focus()
    End Sub

    Private Sub DGCentros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCentros.CellClick
        Dim r As Integer
        r = DGCentros.CurrentCell.RowIndex
        TxCod.Text = DGCentros.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGCentros.Rows(r).Cells(1).Value.ToString
        txBanco.Text = DGCentros.Rows(r).Cells(2).Value.ToString
        txCuenta.Text = DGCentros.Rows(r).Cells(3).Value.ToString
        txGrupo.Text = DGCentros.Rows(r).Cells(4).Value.ToString
    End Sub

    Private Sub DGCentros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCentros.CellContentClick

    End Sub

    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        Habilita(False)
        TxCod.Text = "" : txBanco.Text = "" : txCuenta.Text = "" : txGrupo.Text = "" : TxNombre.Text = ""
        DGCentros.Enabled = True
        btn_New.Enabled = True
        btn_Save.Enabled = False
        btn_Undo.Enabled = False
        btn_Delete.Enabled = True
        btn_Edit.Enabled = True
        get_Centros()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Habilita(False)

        DGCentros.Enabled = True
        btn_New.Enabled = True
        btn_Save.Enabled = False
        btn_Undo.Enabled = False
        btn_Delete.Enabled = True
        btn_Edit.Enabled = True

        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from CentroTrabajo where CentroTrab='" & TxCod.Text & "'", Conexion)
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
        Dim tmpQry As String
        If nuevo Then
            'obtiene nuevo codigo
            Conexion.Open()

            tmpQry = "Insert into CentroTrabajo (CentroTrab,Descripcion,Banco,Cuenta,GrupoContable) "
            tmpQry = tmpQry & "Values('" & TxCod.Text & "','" & TxNombre.Text & "','" & txBanco.Text & "','"
            tmpQry = tmpQry & txCuenta.Text & "','" & txGrupo.Text & "')"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update CentroTrabajo set Descripcion='" & TxNombre.Text
            tmpQry = tmpQry & "',Banco='" & txBanco.Text & "'"
            tmpQry = tmpQry & ",Cuenta='" & txCuenta.Text & "'"
            tmpQry = tmpQry & ",GrupoContable='" & txGrupo.Text & "'"
            tmpQry = tmpQry & " where CentroTrab='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If
        TxCod.Text = "" : txBanco.Text = "" : txCuenta.Text = "" : txGrupo.Text = "" : TxNombre.Text = ""
        get_Centros()

    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun codigo seleccionado", vbInformation)
            Exit Sub
        End If

        Try
            If MsgBox("Esta seguro que desea eliminar el codigo " & TxCod.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then

                Dim tmpQry As String = "delete from CentroTrabajo where CentroTrab='" & TxCod.Text & "'"
                Dim DC As New SqlClient.SqlCommand(tmpQry, Conexion)
                Conexion.Open()
                DC.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                tmpQry = "Delete from CentroTrabajo where CentroTrab='" & TxCod.Text & "'"
                DC = New SqlClient.SqlCommand(tmpQry, Conexion)
                DC.ExecuteNonQuery()

                Conexion.Close()
                MsgBox("El codigo se borro exitosamente", vbInformation)
            End If
            get_Centros()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_CentroTrabajo
        connectionInfo.ServerName = MemServer
        connectionInfo.DatabaseName = MemDatabase
        connectionInfo.IntegratedSecurity = False
        connectionInfo.UserID = "sa"
        connectionInfo.Password = "$$soporte"
        SetDBLogonForReport(connectionInfo, cr)
        frm_REP.CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("NombreCompania", MemNombreCompania)
        frm_REP.Show()
    End Sub
End Class