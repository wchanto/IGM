Public Class frm_FINRegAsiento
    Private Sub GetAsientos()

        Try
            Conexion.Close()

            Conexion.Open()
            Dim dummy As String
            dummy = "Select Periodo,Mes,NumeroAsiento,Debitos,Creditos,FechaAsiento,FechaElaborado,FechaAprobado,FechaAplicado,Elaboro,Aprobo,Aplico,Estado,Detalle from vw_FINAsientoEncabezado where 1=1 "

            If cmbMes.SelectedIndex > 0 Then dummy = dummy & "and Mes='" & cmbMes.SelectedItem.ToString & "' "
            If cmbPeriodo.SelectedIndex > 0 Then dummy = dummy & "and Periodo='" & cmbPeriodo.SelectedItem.ToString & "' "
            If cmbUsuario.SelectedIndex > 0 Then dummy = dummy & "and Elaboro='" & cmbUsuario.SelectedItem.ToString & "' "
            If cmbEstado.SelectedIndex > 0 Then dummy = dummy & "and Estado='" & cmbEstado.SelectedItem.ToString & "' "

            Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
            'Dim DALineas As New SqlClient.SqlDataAdapter("Select * from FIN_AsientoDetalle", Conexion)
            Dim DS As New DataSet

            'DALineas.Fill(DS, "Detalle")
            DA.Fill(DS, "Encabezado")
            'DS.Relations.Add("AsientoDetalle", DS.Tables("Encabezado").Columns("NumeroAsiento"), DS.Tables("Detalle").Columns("NumeroAsiento"))

            'DA.Fill(DS)
            DGAsientos.DataSource = DS.Tables(0)
            Conexion.Close()

            Dim style = New DataGridViewCellStyle
            style.Format = "N2"
            DGAsientos.Columns(3).DefaultCellStyle = style
            DGAsientos.Columns(4).DefaultCellStyle = style


        Catch erro As Exception
            MsgBox(erro.Message)
        End Try
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_FINRegAsiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MESES
        Conexion.Open()
        Dim Qry As New SqlClient.SqlCommand
        Dim LeeSQL As SqlClient.SqlDataReader
        cmbMes.Items.Clear() : cmbMes.Items.Add("[Todos]")
        Qry.Connection = Conexion
        Qry.CommandText = "select Distinct(Mes) from vw_FINAsientoEncabezado"
        LeeSQL = Qry.ExecuteReader
        Dim dummy As String
        Do While LeeSQL.Read
            cmbMes.Items.Add(LeeSQL.Item(0))
        Loop
        Conexion.Close()
        'PERIODOS
        cmbPeriodo.Items.Clear() : cmbPeriodo.Items.Add("[Todos]")
        Conexion.Open()
        Qry.Connection = Conexion
        Qry.CommandText = "select Distinct(Periodo) from vw_FINAsientoEncabezado"
        LeeSQL = Qry.ExecuteReader
        Do While LeeSQL.Read
            cmbPeriodo.Items.Add(LeeSQL.Item(0))
        Loop
        Conexion.Close()
        'Usuarios
        cmbUsuario.Items.Clear() : cmbUsuario.Items.Add("[Todos]")
        Conexion.Open()
        Qry.Connection = Conexion
        Qry.CommandText = "select Distinct(Elaboro) from vw_FINAsientoEncabezado"
        LeeSQL = Qry.ExecuteReader
        Do While LeeSQL.Read
            cmbUsuario.Items.Add(LeeSQL.Item(0))
        Loop
        Conexion.Close()
        'Estados
        cmbEstado.Items.Clear() : cmbEstado.Items.Add("[Todos]")
        Conexion.Open()
        Qry.Connection = Conexion
        Qry.CommandText = "select descripcion from fin_estadoasiento"
        LeeSQL = Qry.ExecuteReader
        Do While LeeSQL.Read
            cmbEstado.Items.Add(LeeSQL.Item(0))
        Loop
        Conexion.Close()

        cmbPeriodo.SelectedIndex = cmbPeriodo.Items.Count - 1
        cmbMes.SelectedIndex = cmbMes.Items.Count - 1
        cmbUsuario.SelectedIndex = 0
        cmbEstado.SelectedIndex = 0

        GetAsientos()
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        GetAsientos()
    End Sub

    Private Sub cmbPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.SelectedIndexChanged
        GetAsientos()
    End Sub

    Private Sub cmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsuario.SelectedIndexChanged
        GetAsientos()
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged
        GetAsientos()
    End Sub

    Private Sub mVer_Click(sender As Object, e As EventArgs) Handles mVer.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim r As Integer
        r = DGAsientos.CurrentCell.RowIndex
        MemFINAsiento = DGAsientos.Rows(r).Cells(2).Value.ToString
        MemFINPeriodo = DGAsientos.Rows(r).Cells(0).Value.ToString
        MemFINMes = DGAsientos.Rows(r).Cells(1).Value.ToString
        frm_FINAsiento.ShowDialog()

    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        MemFINAsiento = ""
        frm_FINAsiento.ShowDialog()
    End Sub

    Private Sub DGAsientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAsientos.CellContentClick


    End Sub

    Private Sub mBorrar_Click(sender As Object, e As EventArgs) Handles mBorrar.Click
        Dim msg As String
        Dim r As Integer = DGAsientos.CurrentCell.RowIndex
        msg = "Esta seguro que desea borrar el asiento " & DGAsientos.Rows(r).Cells(2).Value.ToString & " de " & DGAsientos.Rows(r).Cells(1).Value.ToString & "?"
        If vbYes = MsgBox(msg, vbYesNo + vbDefaultButton2 + vbQuestion) Then
            Dim qry As String
            Dim nmes As Integer
            For i = 0 To cmbMes.Items.Count - 1
                If DGAsientos.Rows(r).Cells(1).Value.ToString = cmbMes.Items(i).ToString Then nmes = i
            Next
            qry = " where NumeroAsiento='" & DGAsientos.Rows(r).Cells(2).Value.ToString & "' and "
            qry = qry & "Periodo='" & DGAsientos.Rows(r).Cells(0).Value.ToString & "' and "
            qry = qry & "mes=" & nmes.ToString
            Conexion.Open()
            Dim tqry As New SqlClient.SqlCommand
            tqry.Connection = Conexion
            tqry.CommandText = "Delete from FIN_AsientoDetalle " & qry
            tqry.ExecuteNonQuery()
            tqry.CommandText = "Delete from FIN_AsientoEncabezado " & qry
            tqry.ExecuteNonQuery()
            Conexion.Close()
            GetAsientos()
            MsgBox("El asiento fue borrado", vbInformation)
        End If
    End Sub

    Private Sub DGAsientos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAsientos.CellContentDoubleClick

    End Sub

    Private Sub DGAsientos_DoubleClick(sender As Object, e As EventArgs) Handles DGAsientos.DoubleClick
        mVer_Click(sender, e)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class