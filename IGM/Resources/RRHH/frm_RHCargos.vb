Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_RHCargos
    Private Sub Get_Cargos()
        Conexion.Open()
        Dim dummy As String
        dummy = "SELECT c.Cargo as Codigo, c.Descripcion,l.Descripcion + ' (' + l.labor + ')' as Puesto,d.Descripcion + ' (' + d.Departamento + ')' as Departamento, "
        dummy = dummy & "c.SalarioBase, C.CargoProhibicion as Prohibicion ,C.CargoDedicacion as Dedicacion,c.cargoDisponibilidad as Disponibilidad, c.Asignado  FROM RH_CARGOS c "
        dummy = dummy & "inner join RH_Labores L on l.Labor=c.Labor "
        dummy = dummy & "inner join Departamentos D on D.Departamento = c.departamento "
        dummy = dummy & "order by Cargo"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGCargos.DataSource = DS.Tables(0)
        Conexion.Close()
        DGCargos.Columns("Salariobase").DefaultCellStyle.Format = "n" : DGCargos.Columns("SalarioBase").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGCargos.Columns("Dedicacion").DefaultCellStyle.Format = "n" : DGCargos.Columns("Dedicacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGCargos.Columns("Prohibicion").DefaultCellStyle.Format = "n" : DGCargos.Columns("Prohibicion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGCargos.Columns("Disponibilidad").DefaultCellStyle.Format = "n" : DGCargos.Columns("Disponibilidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub txDisp_LostFocus(sender As Object, e As EventArgs) Handles txDisp.LostFocus
        If Not IsNumeric(txDisp.Text) Then
            MsgBox("No es un dato valido.", vbExclamation)
            txDisp.SelectAll()
            txDisp.Focus()
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txDisp.TextChanged

    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub frm_RHCargos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_Cargos()

        'Carga Lista de Departamentos
        cmbDepto.Items.Clear()
        Conexion.Open()
        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader
        tmpQry.Connection = Conexion
        Dim dummy As String
        dummy = "select Departamento,Descripcion from Departamentos order by 1 "
        tmpQry.CommandText = dummy
        leeSQL = tmpQry.ExecuteReader
        Dim x As Integer = 0
        While leeSQL.Read
            cmbDepto.Items.Add(leeSQL("Descripcion") & " (" & leeSQL("Departamento") & ")")
            x = cmbDepto.Items.Count - 1
        End While
        Conexion.Close()
        If cmbDepto.Items.Count > 0 Then
            cmbDepto.SelectedIndex = 0
        End If

        'Carga Lista de Puestos
        cmbLabor.Items.Clear()
        Conexion.Open()
        tmpQry.Connection = Conexion
        dummy = "select Labor,Descripcion from RH_Labores order by 1 "
        tmpQry.CommandText = dummy
        leeSQL = tmpQry.ExecuteReader
        x = 0
        While leeSQL.Read
            cmbLabor.Items.Add(leeSQL("Descripcion") & " (" & leeSQL("Labor") & ")")
            x = cmbDepto.Items.Count - 1
        End While
        Conexion.Close()
        If cmbLabor.Items.Count > 0 Then
            cmbLabor.SelectedIndex = 0
        End If
        cmbLabor_SelectedIndexChanged(sender, e)
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
        TxNombre.Enabled = H
        TxProh.Enabled = H
        TxDed.Enabled = H
        txDisp.Enabled = H
        cmbDepto.Enabled = H
        cmbLabor.Enabled = H
        DGCargos.Enabled = Not H

        TxCod.Text = "" : TxNombre.Text = "" : TxProh.Text = "0.00" : TxDed.Text = "0.00" : txDisp.Text = "0.00" : lbSalarioBase.Text = "0.00"

        'Buscar nuevo codigo
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select max(cargo) as N from RH_Cargos", Conexion)
        Dim DR As SqlClient.SqlDataReader
        DR = DC.ExecuteReader
        Dim cons As Integer = 0
        Do While DR.Read
            If IsDBNull(DR.Item(0)) Then
                cons = 1
            Else
                cons = cons + DR.Item(0) + 1
            End If
        Loop
        Conexion.Close()
        TxCod.Text = cons
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
        TxNombre.Enabled = H
        TxProh.Enabled = H
        TxDed.Enabled = H
        txDisp.Enabled = H
        cmbDepto.Enabled = H
        cmbLabor.Enabled = H
        DGCargos.Enabled = Not H

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
        TxNombre.Enabled = H
        TxProh.Enabled = H
        TxDed.Enabled = H
        txDisp.Enabled = H
        cmbDepto.Enabled = H
        cmbLabor.Enabled = H
        DGCargos.Enabled = Not H

        'Graba el registro
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from rh_cargos where cargo=" & TxCod.Text, Conexion)
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

        'Codigo Labor
        Dim dummy As String = cmbLabor.SelectedItem.ToString
        Dim pos As Integer = dummy.Length - 2
        Dim Labor As String = ""
        While dummy.Substring(pos, 1) <> "("
            Labor = dummy.Substring(pos, 1) & Labor
            pos = pos - 1
        End While
        'Codigo Departamento
        dummy = cmbDepto.SelectedItem.ToString
        pos = dummy.Length - 2
        Dim Depto As String = ""
        While dummy.Substring(pos, 1) <> "("
            Depto = dummy.Substring(pos, 1) & Depto
            pos = pos - 1
        End While

        Dim SB As Decimal = lbSalarioBase.Text
        Dim P As Decimal = TxProh.Text
        Dim D As Decimal = TxDed.Text
        Dim Di As Decimal = txDisp.Text

        If nuevo Then
            Conexion.Open()
            tmpQry = "Insert into rh_Cargos (Cargo,Descripcion,Labor,Departamento,SalarioBase,CargoProhibicion,CargoDedicacion,CargoDisponibIlidad,asignado) "
            tmpQry = tmpQry & "Values(" & TxCod.Text & ",'" & TxNombre.Text & "','" & Labor & "','" & Depto & "',"
            tmpQry = tmpQry & SB.ToString & "," & P.ToString & "," & D.ToString & "," & Di.ToString & ",0)"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update RH_CARGOS set Descripcion='" & TxNombre.Text
            tmpQry = tmpQry & "',Labor='" & Labor & "'"
            tmpQry = tmpQry & ",Departamento='" & Depto & "'"
            tmpQry = tmpQry & ",SalarioBase=" & SB.ToString
            tmpQry = tmpQry & ",CargoProhibicion=" & P.ToString
            tmpQry = tmpQry & ",CargoDedicacion=" & D.ToString
            tmpQry = tmpQry & ",CargoDisponibilidad=" & Di.ToString
            tmpQry = tmpQry & " where Cargo=" & TxCod.Text
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If
        Get_Cargos()

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
        TxNombre.Enabled = H
        TxProh.Enabled = H
        TxDed.Enabled = H
        txDisp.Enabled = H
        cmbDepto.Enabled = H
        cmbLabor.Enabled = H
        DGCargos.Enabled = Not H
        TxCod.Text = "" : TxNombre.Text = "" : TxProh.Text = "0.00" : TxDed.Text = "0.00" : txDisp.Text = "0.00" : lbSalarioBase.Text = "0.00"
    End Sub

    Private Sub DGCargos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCargos.CellContentClick
        Dim r As Integer
        r = DGCargos.CurrentCell.RowIndex
        TxCod.Text = DGCargos.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGCargos.Rows(r).Cells(1).Value.ToString
        lbSalarioBase.Text = Format(DGCargos.Rows(r).Cells(4).Value, "N")
        TxProh.Text = Format(DGCargos.Rows(r).Cells(5).Value, "N")
        TxDed.Text = Format(DGCargos.Rows(r).Cells(6).Value, "N")
        txDisp.Text = Format(DGCargos.Rows(r).Cells(7).Value, "N")

        Dim dummy As String = DGCargos.Rows(r).Cells(2).Value.ToString
        Dim x As Integer = -1
        For a = 0 To cmbLabor.Items.Count - 1
            If cmbLabor.Items(a).ToString = dummy Then x = a
        Next
        cmbLabor.SelectedIndex = x

        dummy = DGCargos.Rows(r).Cells(3).Value.ToString
        x = -1
        For a = 0 To cmbDepto.Items.Count - 1
            If cmbDepto.Items(a).ToString = dummy Then x = a
        Next
        cmbDepto.SelectedIndex = x

    End Sub

    Private Sub lbSalarioBase_Click(sender As Object, e As EventArgs) Handles lbSalarioBase.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TxProh_LostFocus(sender As Object, e As EventArgs) Handles TxProh.LostFocus
        If Not IsNumeric(TxProh.Text) Then
            MsgBox("No es un dato valido.", vbExclamation)
            TxProh.SelectAll()
            TxProh.Focus()
        End If
    End Sub

    Private Sub TxProh_TextChanged(sender As Object, e As EventArgs) Handles TxProh.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub cmbLabor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLabor.SelectedIndexChanged
        Dim dummy As String = cmbLabor.SelectedItem.ToString
        Dim pos As Integer = dummy.Length - 2
        Dim cod As String = ""
        While dummy.Substring(pos, 1) <> "("
            cod = dummy.Substring(pos, 1) & cod
            pos = pos - 1
        End While

        'Buscar Labor
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select SalarioBase from RH_Labores where Labor='" & cod & "'", Conexion)
        Dim DR As SqlClient.SqlDataReader
        DR = DC.ExecuteReader
        Dim valor As Integer = 0
        Do While DR.Read
            If IsDBNull(DR.Item(0)) Then
                valor = 0
            Else
                valor = DR.Item(0)
            End If
        Loop
        lbSalarioBase.Text = Format(valor, "N")
        Conexion.Close()

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If MsgBox("¿Desea borrar el Cargo #" & TxCod.Text & "?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            Conexion.Open()
            Dim DC As New SqlClient.SqlCommand("delete from rh_cargos where Cargo='" & TxCod.Text & "'", Conexion)
            DC.ExecuteNonQuery()
            Conexion.Close()
            TxCod.Text = "" : TxNombre.Text = "" : lbSalarioBase.Text = "0.00" : TxProh.Text = "0.00" : TxDed.Text = "0.00" : txDisp.Text = "0.00"
            Get_Cargos()
        End If
    End Sub

    Private Sub TxDed_LostFocus(sender As Object, e As EventArgs) Handles TxDed.LostFocus
        If Not IsNumeric(TxDed.Text) Then
            MsgBox("No es un dato valido.", vbExclamation)
            TxDed.SelectAll()
            TxDed.Focus()
        End If
    End Sub

    Private Sub TxDed_TextChanged(sender As Object, e As EventArgs) Handles TxDed.TextChanged

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click        
        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_RHCargos
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