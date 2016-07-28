Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frm_RHTiposDeduccion
    Private Sub Get_Ded()
        Conexion.Open()
        Dim dummy As String
        dummy = "select CodDedu as Codigo,Descripcion,Fija,Embargo,Distribuir, PartidaCxp as [Codigo CxP] from rh_tiposdeduccion order by CodDedu"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGTDed.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub chkDedGen_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmbargo.CheckedChanged

    End Sub

    Private Sub frm_RHTiposDeduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Ded()
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
        chkEmbargo.Enabled = H
        TxCta.Enabled = H
        chkDist.Enabled = H
        OptFija.Enabled = H
        optPorc.Enabled = H
        DGTDed.Enabled = Not H

        TxCod.Text = "" : TxDescrip.Text = "" : TxCta.Text = ""
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
        TxCta.Enabled = H
        TxDescrip.Enabled = H
        chkEmbargo.Enabled = H
        chkDist.Enabled = H
        OptFija.Enabled = H
        optPorc.Enabled = H
        DGTDed.Enabled = Not H
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
        TxCta.Enabled = H
        TxDescrip.Enabled = H
        chkEmbargo.Enabled = H
        chkDist.Enabled = H
        OptFija.Enabled = H
        optPorc.Enabled = H
        DGTDed.Enabled = Not H

        'Graba el registro
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from rh_TiposDeduccion where CodDedu='" & TxCod.Text & "'", Conexion)
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

        Dim DedFij As Integer = 0, Embargo As Integer = 0, Dist As Integer = 0
        If OptFija.Checked Then DedFij = 1
        If chkDist.Checked Then Dist = 1
        If chkEmbargo.Checked Then Embargo = 1

        Dim tmpQry As String
        If nuevo Then
            'obtiene nuevo codigo
            Conexion.Open()
            tmpQry = "Insert into RH_TiposDeduccion (CodDedu,Descripcion,Fija,PartidaCxP,Embargo,Distribuir) VALUES('"
            tmpQry = tmpQry & TxCod.Text & "','"
            tmpQry = tmpQry & TxDescrip.Text & "',"
            tmpQry = tmpQry & DedFij & ",'"
            tmpQry = tmpQry & TxCta.Text & "',"
            tmpQry = tmpQry & Embargo & ","
            tmpQry = tmpQry & Dist & ")"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update RH_TiposDeduccion set Descripcion='" & TxDescrip.Text & "',"
            tmpQry = tmpQry & "Fija=" & DedFij & ","
            tmpQry = tmpQry & "PartidaCxP='" & TxCta.Text & "',"
            tmpQry = tmpQry & "Embargo=" & Embargo & ","
            tmpQry = tmpQry & "Distribuir=" & Dist
            tmpQry = tmpQry & " where CodDedu='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If

        TxCod.Text = "" : TxDescrip.Text = "" : TxCta.Text = ""
        Get_Ded()

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
        TxCta.Enabled = H
        TxDescrip.Enabled = H
        chkEmbargo.Enabled = H
        chkDist.Enabled = H
        OptFija.Enabled = H
        optPorc.Enabled = H
        DGTDed.Enabled = Not H
    End Sub

    Private Sub DGTDed_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTDed.CellContentClick
        Dim r As Integer
        r = DGTDed.CurrentCell.RowIndex
        TxCod.Text = DGTDed.Rows(r).Cells(0).Value.ToString
        TxDescrip.Text = DGTDed.Rows(r).Cells(1).Value.ToString
        OptFija.Checked = DGTDed.Rows(r).Cells(2).Value : optPorc.Checked = Not DGTDed.Rows(r).Cells(2).Value
        chkEmbargo.Checked = DGTDed.Rows(r).Cells(3).Value
        chkDist.Checked = DGTDed.Rows(r).Cells(4).Value
        TxCta.Text = DGTDed.Rows(r).Cells(5).Value.ToString
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbInformation)
            Exit Sub
        End If
        If MsgBox("¿Esta seguro que desea borrar el codigo " & TxCod.Text & "?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            Conexion.Open()
            Dim DC As New SqlClient.SqlCommand("delete from rh_TiposDeduccion where CodDedu='" & TxCod.Text & "'", Conexion)
            DC.ExecuteNonQuery()
            Conexion.Close()
            Get_Ded()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_RHTiposDeduccion
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