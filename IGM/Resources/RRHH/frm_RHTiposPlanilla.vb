Public Class frm_RHTiposPlanilla
    Private Sub GetPlan()
        Conexion.Open()
        Dim dummy As String
        dummy = "select TipoPago,Descripcion,CantPagos as Pagos, DiasPago as Dias from rh_tipoPlanilla order by TipoPlanilla"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGPlan.DataSource = DS.Tables(0)
        Conexion.Close()
        DGPlan.Columns("Pagos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGPlan.Columns("Dias").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxCant.TextChanged

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub frm_RHTiposPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPlan()
    End Sub

    Private Sub DGPlan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPlan.CellContentClick
        Dim r As Integer
        r = DGPlan.CurrentCell.RowIndex
        TxCod.Text = DGPlan.Rows(r).Cells(0).Value.ToString
        TxDescrip.Text = DGPlan.Rows(r).Cells(1).Value.ToString
        TxCant.Text = DGPlan.Rows(r).Cells(2).Value
        TxDias.Text = DGPlan.Rows(r).Cells(3).Value
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
        TxCant.Enabled = H
        TxDias.Enabled = H
        DGPlan.Enabled = Not H

        TxCod.Text = "" : TxDescrip.Text = "" : TxCant.Text = "0" : TxDias.Text = "0"
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
        TxCant.Enabled = H
        TxDias.Enabled = H
        DGPlan.Enabled = Not H

        TxDescrip.Focus()
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
        TxCant.Enabled = H
        TxDias.Enabled = H
        DGPlan.Enabled = Not H

        'Graba el registro
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from rh_TipoPlanilla where TipoPago='" & TxCod.Text & "'", Conexion)
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
            DC = New SqlClient.SqlCommand("Select max(TipoPlanilla) as N from RH_TipoPlanilla", Conexion)
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


            Conexion.Open()
            tmpQry = "Insert into RH_TipoPlanilla (TipoPago,Descripcion,CantPagos,DiasPago, TipoPlanilla) VALUES('"
            tmpQry = tmpQry & TxCod.Text & "','"
            tmpQry = tmpQry & TxDescrip.Text & "',"
            tmpQry = tmpQry & TxCant.Text & ","
            tmpQry = tmpQry & TxDias.Text & ","
            tmpQry = tmpQry & cons & ")"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update RH_TipoPlanilla set Descripcion='" & TxDescrip.Text & "',"
            tmpQry = tmpQry & "CantPagos=" & TxCant.Text & ","
            tmpQry = tmpQry & "DiasPago=" & TxDias.Text
            tmpQry = tmpQry & " where TipoPago='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If
        GetPlan()

        TxCod.Text = "" : TxDescrip.Text = "" : TxCant.Text = "0" : TxDias.Text = "0"
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
        TxCant.Enabled = H
        TxDias.Enabled = H
        DGPlan.Enabled = Not H

        TxCod.Text = "" : TxDescrip.Text = "" : TxCant.Text = "0" : TxDias.Text = "0"
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbInformation)
            Exit Sub
        End If
        If MsgBox("¿Esta seguro que desea borrar el codigo " & TxCod.Text & "?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
            Conexion.Open()
            Dim DC As New SqlClient.SqlCommand("delete from rh_TipoPlanilla where TipoPago='" & TxCod.Text & "'", Conexion)
            DC.ExecuteNonQuery()
            Conexion.Close()
            GetPlan()
        End If
        TxCod.Text = "" : TxDescrip.Text = "" : TxCant.Text = "0" : TxDias.Text = "0"
    End Sub
End Class