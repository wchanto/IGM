Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_RHPuestos
    Private Sub get_Puestos()
        Conexion.Open()
        Dim dummy As String
        dummy = "select Labor,Descripcion,SalarioBase, descLabores as Detalle from rh_labores order by labor"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGLabores.DataSource = DS.Tables(0)
        Conexion.Close()
        DGLabores.Columns("Salariobase").DefaultCellStyle.Format = "n"
        DGLabores.Columns("SalarioBase").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim H As Boolean
        H = False
        btnAdd.Enabled = Not H
        btnEdit.Enabled = Not H
        btnDel.Enabled = Not H
        btnPrint.Enabled = Not H
        btnUndo.Enabled = H
        btnSave.Enabled = H
        TxCod.Enabled = H
        txDetalle.Enabled = H
        TxNombre.Enabled = H
        txSalario.Enabled = H
        DGLabores.Enabled = Not H

        'Graba el registro
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from rh_labores where Labor='" & TxCod.Text & "'", Conexion)
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
            tmpQry = "Insert into rh_Labores (Labor,Descripcion,DescLabores,SalarioBase) "
            tmpQry = tmpQry & "Values('" & TxCod.Text & "','" & TxNombre.Text & "','" & txDetalle.Text & "',"
            tmpQry = tmpQry & txSalario.Text & ")"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update rh_Labores set Descripcion='" & TxNombre.Text
            tmpQry = tmpQry & "',DescLabores='" & txDetalle.Text & "'"
            tmpQry = tmpQry & ",SalarioBase='" & txSalario.Text & "'"
            tmpQry = tmpQry & " where Labor='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If

        TxCod.Text = "" : TxNombre.Text = "" : txDetalle.Text = "" : txSalario.Text = ""
        get_Puestos()



    End Sub

    Private Sub frm_RHPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_Puestos()
    End Sub

    Private Sub DGLabores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLabores.CellContentClick
        Dim r As Integer
        r = DGLabores.CurrentCell.RowIndex
        TxCod.Text = DGLabores.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGLabores.Rows(r).Cells(1).Value.ToString
        txSalario.Text = Format(DGLabores.Rows(r).Cells(2).Value, "N")
        txDetalle.Text = DGLabores.Rows(r).Cells(3).Value.ToString

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim H As Boolean
        H = True

        btnAdd.Enabled = Not H
        btnEdit.Enabled = Not H
        btnDel.Enabled = Not H
        btnPrint.Enabled = Not H
        btnUndo.Enabled = H
        btnSave.Enabled = H
        TxCod.Enabled = H
        txDetalle.Enabled = H
        TxNombre.Enabled = H
        txSalario.Enabled = H
        DGLabores.Enabled = Not H

        TxCod.Text = "" : txDetalle.Text = "" : TxNombre.Text = "" : txSalario.Text = "0.00"
        TxCod.Focus()


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbExclamation)
            Exit Sub
        End If

        Dim H As Boolean
        H = True

        btnAdd.Enabled = Not H
        btnEdit.Enabled = Not H
        btnDel.Enabled = Not H
        btnPrint.Enabled = Not H
        btnUndo.Enabled = H
        btnSave.Enabled = H
        TxCod.Enabled = H
        txDetalle.Enabled = H
        TxNombre.Enabled = H
        txSalario.Enabled = H
        DGLabores.Enabled = Not H

        TxCod.Focus()

    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Dim H As Boolean
        H = False

        btnAdd.Enabled = Not H
        btnEdit.Enabled = Not H
        btnDel.Enabled = Not H
        btnPrint.Enabled = Not H
        btnUndo.Enabled = H
        btnSave.Enabled = H
        TxCod.Enabled = H
        txDetalle.Enabled = H
        TxNombre.Enabled = H
        txSalario.Enabled = H
        DGLabores.Enabled = Not H

        TxCod.Text = "" : txDetalle.Text = "" : TxNombre.Text = "" : txSalario.Text = "0.00"
    End Sub

    Private Sub txSalario_LostFocus(sender As Object, e As EventArgs) Handles txSalario.LostFocus
        Dim valor As Decimal
        If Not IsNumeric(txSalario.Text) Then
            MsgBox("No es un dato valido.", vbCritical)
            txSalario.SelectAll()
            txSalario.Focus()
            Exit Sub
        Else
            valor = txSalario.Text
            txSalario.Text = Format(valor, "N")
        End If
    End Sub

    Private Sub txSalario_TextChanged(sender As Object, e As EventArgs) Handles txSalario.TextChanged

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbInformation)
            Exit Sub
        End If
        If MsgBox("¿Esta seguro que desea borrar el codigo " & TxCod.Text & "?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            Dim tmpQry As String
            Conexion.Open()
            Dim DC As New SqlClient.SqlCommand("delete from rh_Labores where labor='" & TxCod.Text & "'", Conexion)
            DC.ExecuteNonQuery()
            Conexion.Close()
            get_Puestos()
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_RHPuestos
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