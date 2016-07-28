Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_RHTiposPago
    Private Sub Get_Tipos()
        Conexion.Open()
        Dim dummy As String
        dummy = "select codPago as Codigo,Descripcion,"
        dummy = dummy & "case Factor when 'D' then 'Día' when 'F' then 'Fijo' when 'S' then 'Sesión' else 'Hora' end as Factor"
        dummy = dummy & ",Multiplica,Aplicaded as [Deduc. Generales],AplicaDedGen as [Deduc. Fijas], Distribuye, NoAplicar "
        dummy = dummy & "from rh_TiposPago order by codPago"

        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGTPago.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub frm_RHTiposPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFactor.SelectedIndex = 0
        Get_Tipos()
    End Sub

    Private Sub DGTPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTPago.CellContentClick
        Dim r As Integer
        r = DGTPago.CurrentCell.RowIndex
        TxCod.Text = DGTPago.Rows(r).Cells(0).Value.ToString
        TxDescrip.Text = DGTPago.Rows(r).Cells(1).Value.ToString
        Dim F As String : Dim s As Integer
        F = DGTPago.Rows(r).Cells(2).Value.ToString() : s = 0
        For a = 0 To cmbFactor.Items.Count - 1
            If cmbFactor.Items(a).ToString = F Then s = a
        Next
        cmbFactor.SelectedIndex = s
        txFactor.Text = DGTPago.Rows(r).Cells(3).Value
        chkDedGen.Checked = DGTPago.Rows(r).Cells(4).Value
        chkDedFija.Checked = DGTPago.Rows(r).Cells(5).Value
        chkDist.Checked = DGTPago.Rows(r).Cells(6).Value
        chkMov.Checked = DGTPago.Rows(r).Cells(7).Value
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles chkMov.CheckedChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim H As Boolean
        H = True

        btnAdd.Enabled = Not H
        btnEdit.Enabled = Not H
        btnDel.Enabled = Not H
        btnPrint.Enabled = Not H
        btnUndo.Enabled = H
        btnSave.Enabled = H
        TxCod.Enabled = H

        TxDescrip.Enabled = H
        chkDedFija.Enabled = H
        chkDedGen.Enabled = H
        chkDist.Enabled = H
        chkMov.Enabled = H
        txFactor.Enabled = H
        DGTPago.Enabled = Not H
        cmbFactor.Enabled = H

        TxCod.Text = "" : TxDescrip.Text = "" : txFactor.Text = "1"
        TxCod.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim H As Boolean
        H = True

        btnAdd.Enabled = Not H
        btnEdit.Enabled = Not H
        btnDel.Enabled = Not H
        btnPrint.Enabled = Not H
        btnUndo.Enabled = H
        btnSave.Enabled = H
        TxCod.Enabled = H

        TxDescrip.Enabled = H
        chkDedFija.Enabled = H
        chkDedGen.Enabled = H
        chkDist.Enabled = H
        chkMov.Enabled = H
        txFactor.Enabled = H
        DGTPago.Enabled = Not H
        cmbFactor.Enabled = H
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim H As Boolean
        H = False

        btnAdd.Enabled = Not H
        btnEdit.Enabled = Not H
        btnDel.Enabled = Not H
        btnPrint.Enabled = Not H
        btnUndo.Enabled = H
        btnSave.Enabled = H
        TxCod.Enabled = H

        TxDescrip.Enabled = H
        chkDedFija.Enabled = H
        chkDedGen.Enabled = H
        chkDist.Enabled = H
        chkMov.Enabled = H
        txFactor.Enabled = H
        cmbFactor.Enabled = H
        DGTPago.Enabled = Not H

        'Graba el registro
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from rh_TiposPago where CodPago='" & TxCod.Text & "'", Conexion)
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
        Dim Factor As String
        Select Case cmbFactor.SelectedItem.ToString
            Case "Día" : Factor = "D"
            Case "Hora" : Factor = "H"
            Case "Sesión" : Factor = "S"
            Case Else : Factor = "F"
        End Select
        Dim DedFij As Integer = 0, DedGen As Integer = 0, Dist As Integer = 0, Mov As Integer = 0
        If chkDedFija.Checked Then DedFij = 1
        If chkDedGen.Checked Then DedGen = 1
        If chkDist.Checked Then Dist = 1
        If chkMov.Checked Then Mov = 1

        Dim tmpQry As String
        If nuevo Then
            'obtiene nuevo codigo
            Conexion.Open()
            tmpQry = "Insert into RH_TiposPago (CodPago,Descripcion,Factor,Multiplica,AplicaDed,AplicaDedGen,Distribuye,NoAplicar) VALUES('"
            tmpQry = tmpQry & TxCod.Text & "','"
            tmpQry = tmpQry & TxDescrip.Text & "','"
            tmpQry = tmpQry & Factor & "',"
            tmpQry = tmpQry & txFactor.Text & ","
            tmpQry = tmpQry & DedFij & ","
            tmpQry = tmpQry & DedGen & ","
            tmpQry = tmpQry & Dist & ","
            tmpQry = tmpQry & Mov & ")"

            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update RH_TiposPago set Descripcion='" & TxDescrip.Text & "'"
            tmpQry = tmpQry & ",Factor='" & Factor & "',"
            tmpQry = tmpQry & "Multiplica=" & txFactor.Text & ","
            tmpQry = tmpQry & "AplicaDed=" & DedFij & ","
            tmpQry = tmpQry & "AplicaDedGen=" & DedGen & ","
            tmpQry = tmpQry & "Distribuye=" & Dist & ","
            tmpQry = tmpQry & "NoAplicar=" & Mov & " where CodPago='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If

        TxCod.Text = "" : TxDescrip.Text = "" : txFactor.Text = "1"
        Get_Tipos()


    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbInformation)
            Exit Sub
        End If
        If MsgBox("¿Esta seguro que desea borrar el codigo " & TxCod.Text & "?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            Dim tmpQry As String
            Conexion.Open()
            Dim DC As New SqlClient.SqlCommand("delete from rh_TiposPago where CodPago='" & TxCod.Text & "'", Conexion)
            DC.ExecuteNonQuery()
            Conexion.Close()
            Get_Tipos()
        End If
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

        TxDescrip.Enabled = H
        chkDedFija.Enabled = H
        chkDedGen.Enabled = H
        chkDist.Enabled = H
        chkMov.Enabled = H
        txFactor.Enabled = H
        DGTPago.Enabled = Not H
        cmbFactor.Enabled = H

        TxCod.Text = "" : TxDescrip.Text = "" : txFactor.Text = "1"

    End Sub

    Private Sub txFactor_KeyDown(sender As Object, e As KeyEventArgs) Handles txFactor.KeyDown

    End Sub

    Private Sub txFactor_LostFocus(sender As Object, e As EventArgs) Handles txFactor.LostFocus
        If Not IsNumeric(txFactor.Text) Then
            MsgBox("No es un dato válido", vbExclamation)
            txFactor.SelectAll()
            txFactor.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txFactor_TextChanged(sender As Object, e As EventArgs) Handles txFactor.TextChanged

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_RHTiposPago
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