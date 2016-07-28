Public Class frm_FINCtasContables
    Sub get_Tipos()
        Conexion.Open()
        Dim Qry As New SqlClient.SqlCommand
        Dim LeeSQL As SqlClient.SqlDataReader
        Dim dummy As String
        Qry.Connection = Conexion
        Qry.CommandText = "Select Valor from sys_Valores where CodValor='FCTA'"
        LeeSQL = Qry.ExecuteReader
        Do While LeeSQL.Read
            MemFIN_FormatoCuenta = LeeSQL.Item("Valor")
        Loop
        Conexion.Close()
        'txCuenta.Mask = MemFIN_FormatoCuenta
        Conexion.Open()
        Qry.CommandText = "Select * FROM FIN_TipoCuenta"
        LeeSQL = Qry.ExecuteReader
        Do While LeeSQL.Read
            dummy = LeeSQL.Item("DescripTipoCuenta") '.ToString.PadRight(100, " ") & " (" & LeeSQL.Item("TipoCuenta") & ")"
            cmbTC.Items.Add(dummy)
        Loop
        If cmbTC.Items.Count > 0 Then cmbTC.SelectedIndex = 0
        Conexion.Close()

    End Sub
    Private Sub Habilita(Hab As Boolean)
        txCuenta.Enabled = Hab
        TxDescrip.Enabled = Hab
        cmbTC.Enabled = Hab
        chkMov.Enabled = Hab
        DGCuentas.Enabled = Not Hab

    End Sub

    Private Sub get_Cuentas()
        Conexion.Open()
        Dim dummy As String
        dummy = "select cc.NumeroCuenta as Cuenta, cc.DescripCuenta as Descripcion, tc.DescripTipoCuenta as [Tipo de Cuenta], "
        dummy = dummy & "cc.PermiteMovimientos as [Permite Movimientos],  cc.EsDebito as [Es Debito] from FIN_CuentasContables CC "
        dummy = dummy & "inner join FIN_TipoCuenta TC on CC.TipoCuenta=Tc.TipoCuenta"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGCuentas.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub frm_FINCtasContables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_Tipos()
        get_Cuentas()

        Conexion.Open()
        Dim Qry As New SqlClient.SqlCommand
        Dim LeeSQL As SqlClient.SqlDataReader
        Qry.Connection = Conexion
        Qry.CommandText = "select  NumeroCuenta,DescripCuenta from FIN_CuentasContables"
        LeeSQL = Qry.ExecuteReader
        Dim dummy As String
        Do While LeeSQL.Read
            dummy = LeeSQL.Item("NumeroCuenta") & " " & LeeSQL.Item("DescripCuenta")
            cmbCta.Items.Add(dummy)
        Loop
        Conexion.Close()

    End Sub

    Private Sub DGCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCuentas.CellClick
        Dim r As Integer
        r = DGCuentas.CurrentCell.RowIndex
        txCuenta.Text = DGCuentas.Rows(r).Cells(0).Value.ToString
        TxDescrip.Text = DGCuentas.Rows(r).Cells(1).Value.ToString

        chkMov.Checked = DGCuentas.Rows(r).Cells(3).Value
        Dim i As Integer = -1
        For a = 0 To cmbTC.Items.Count - 1
            If DGCuentas.Rows(r).Cells(2).Value.ToString = cmbTC.Items(a).ToString Then i = a
        Next a
        cmbTC.SelectedIndex = i

    End Sub




    Private Sub txCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCuenta.KeyPress
        'Conexion.Open()
        'Dim Qry As New SqlClient.SqlCommand
        'Dim LeeSQL As SqlClient.SqlDataReader
        'Dim dummy As String
        'Qry.Connection = Conexion
        'Qry.CommandText = "Select top 1 * FROM FIN_CuentasContables where NumeroCuenta like '" & txCuenta.Text & "%'"
        'LeeSQL = Qry.ExecuteReader
        'Do While LeeSQL.Read
        ' TxDescrip.Text = LeeSQL.Item("NumeroCuenta")
        ' TxDescrip.SelectionStart = 0
        'TxDescrip.SelectionLength = txCuenta.Text.Length
        'Loop

        '        Conexion.Close()
    End Sub

    Private Sub txCuenta_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txCuenta.MaskInputRejected

    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        txCuenta.Text = ""
        TxDescrip.Text = ""
        Habilita(True)
        txCuenta.Focus()
        btn_Save.Enabled = True
        btn_Undo.Enabled = True
        btn_New.Enabled = False
        btn_Edit.Enabled = False
        btn_Delete.Enabled = False
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        Habilita(True)
        txCuenta.Focus()
        btn_Save.Enabled = True
        btn_Undo.Enabled = True
        btn_New.Enabled = False
        btn_Edit.Enabled = False
        btn_Delete.Enabled = False

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Habilita(False)
        btn_Save.Enabled = False
        btn_Undo.Enabled = False
        btn_New.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True

        'Graba el registro
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from FIN_CuentasContables where NumeroCuenta='" & txCuenta.Text & "'", Conexion)
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


        Conexion.Open()
        DC.CommandText = "Select top 1 * from FIN_TipoCuenta where DescripTipocuenta='" & cmbTC.SelectedItem.ToString & "'"
        DR = DC.ExecuteReader()
        Dim TC As Integer = 0
        Do While DR.Read
            TC = DR.Item("TipoCuenta")
        Loop
        Conexion.Close()
        Dim PM As Integer = 0
        If chkMov.Checked Then PM = 1

        If nuevo Then
            Conexion.Open()
            Dim tmpQry As String = "Insert into FIN_CuentasContables (NumeroCuenta,DescripCuenta,TipoCuenta,CuentaMadre,UltimoNivel,PermiteMovimientos,EsDebito) "
            tmpQry = tmpQry & "Values('" & txCuenta.Text & "','"
            tmpQry = tmpQry & TxDescrip.Text & "'," & TC & ",'',''," & PM.ToString & ",0)"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            Dim tmpqry As String = "Update FIN_CuentasContables set DescripCuenta='" & TxDescrip.Text & "'"
            tmpqry = tmpqry & ",TipoCuenta=" & TC.ToString
            tmpqry = tmpqry & ",PermiteMovimientos=" & PM.ToString
            tmpqry = tmpqry & " where NumeroCuenta='" & txCuenta.Text & "'"
            Conexion.Open()
            DC.CommandText = tmpqry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If

        '------------
        get_Cuentas()
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If txCuenta.Text = "" Then
            MsgBox("No hay ninguna cuenta seleccionada", vbExclamation)
            Exit Sub
        End If


        If MsgBox("Esta seguro que desea eliminar la cuenta " & txCuenta.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
            Dim tmpQry As String = "Delete from FIN_CuentasContables where NumeroCuenta='" & txCuenta.Text & "'"
            Dim DC As New SqlClient.SqlCommand(tmpQry, Conexion)
            Conexion.Open()
            DC.ExecuteNonQuery()
            Conexion.Close()
            get_Cuentas()
            txCuenta.Text = "" : TxDescrip.Text = ""
            MsgBox("La cuenta se borro exitosamente", vbInformation)
        End If

    End Sub

    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        txCuenta.Text = ""
        TxDescrip.Text = ""
        Habilita(True)
        btn_Save.Enabled = False
        btn_Undo.Enabled = False
        btn_New.Enabled = True
        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
        get_Cuentas()
    End Sub

    Private Sub DGCuentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCuentas.CellContentClick

    End Sub
End Class