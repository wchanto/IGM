Public Class frm_FINAsiento



    Private Sub frm_FINAsiento_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            'MESES
            cmbMes.Items.Clear()
            Conexion.Open()
            Dim Qry As New SqlClient.SqlCommand
            Dim LeeSQL As SqlClient.SqlDataReader
            Qry.Connection = Conexion
            Qry.CommandText = "select Distinct(Mes) from vw_FINAsientoEncabezado"
            LeeSQL = Qry.ExecuteReader
            Do While LeeSQL.Read
                cmbMes.Items.Add(LeeSQL.Item(0))
            Loop
            Conexion.Close()
            TxNAsiento.Text = MemFINAsiento
            'PERIODOS
            cmbPeriodo.Items.Clear()
            Conexion.Open()
            Qry.Connection = Conexion
            Qry.CommandText = "select Distinct(Periodo) from vw_FINAsientoEncabezado"
            LeeSQL = Qry.ExecuteReader
            Do While LeeSQL.Read
                cmbPeriodo.Items.Add(LeeSQL.Item(0))
            Loop
            Conexion.Close()
            Dim x As Integer = 0
            For i = 0 To cmbMes.Items.Count - 1
                If cmbMes.Items(i).ToString = MemFINMes Then x = i
            Next
            cmbMes.SelectedIndex = x
            x = -1
            For i = 0 To cmbPeriodo.Items.Count - 1
                If cmbPeriodo.Items(i).ToString = MemFINPeriodo Then x = i
            Next
            cmbPeriodo.SelectedIndex = 0
            Dim dummy As String = ""
            'Busca el asiento
            If MemFINAsiento <> "" Then
                TxNAsiento.Enabled = False
                cmbMes.Enabled = False
                cmbPeriodo.Enabled = False
                Conexion.Open()
                Qry.Connection = Conexion
                Dim nmes As String = cmbMes.SelectedItem.ToString
                Qry.CommandText = "select * from vw_FINAsientoEncabezado where periodo='" & cmbPeriodo.SelectedItem.ToString & "' and mes='" & nmes & "' and NumeroAsiento='" & TxNAsiento.Text & "'"
                LeeSQL = Qry.ExecuteReader
                Do While LeeSQL.Read
                    If Not IsDBNull(LeeSQL("FechaAsiento")) Then
                        dtFAsiento.Value = LeeSQL("FechaAsiento")
                    End If
                    If Not IsDBNull(LeeSQL("Detalle")) Then
                        TxDetalle.Text = LeeSQL("Detalle")
                    End If
                    If Not IsDBNull(LeeSQL("Elaboro")) Then
                        lbElaboro.Text = LeeSQL("Elaboro")
                    End If
                    If Not IsDBNull(LeeSQL("Aprobo")) Then
                        lbAprobo.Text = LeeSQL("Aprobo")
                    End If
                Loop
                Conexion.Close()
                'Graba los registros en una tabla temporal de trabajo

                Conexion.Open()
                Qry.Connection = Conexion
                dummy = "Delete from FIN_temp_AsientoDetalle "
                dummy = dummy & "where Periodo='" & cmbPeriodo.SelectedItem.ToString & "' and mes=" & cmbMes.SelectedIndex + 1
                dummy = dummy & " and NumeroAsiento='" & TxNAsiento.Text & "'"
                Qry.CommandText = dummy
                Qry.ExecuteNonQuery()
                dummy = "insert into  FIN_temp_AsientoDetalle "
                dummy = dummy & "select * from FIN_AsientoDetalle where Periodo='" & cmbPeriodo.SelectedItem.ToString & "' and mes=" & cmbMes.SelectedIndex + 1
                dummy = dummy & " and NumeroAsiento='" & TxNAsiento.Text & "'"
                Qry.CommandText = dummy
                Qry.ExecuteNonQuery()
                Conexion.Close()
            Else
                TxNAsiento.Enabled = True
                cmbMes.Enabled = True
                cmbPeriodo.Enabled = True
                lbAprobo.Text = ""
                lbElaboro.Text = ""
                TxDetalle.Text = ""
                dtFAsiento.Value = Now
            End If


            dummy = "select td.NumeroLinea as Linea,td.NumeroCuenta as [Numero Cuenta] ,CC.DescripCuenta as Cuenta,TD.Debito,td.Credito,td.Comentario "
            dummy = dummy & "from FIN_temp_AsientoDetalle TD inner join FIN_CuentasContables CC on CC.NumeroCuenta=TD.NumeroCuenta "
            dummy = dummy & " where Periodo='" & cmbPeriodo.SelectedItem.ToString & "' and mes=" & cmbMes.SelectedIndex + 1
            dummy = dummy & " and NumeroAsiento='" & TxNAsiento.Text & "'"

            Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
            Dim DS As New DataSet
            DA.Fill(DS)
            DGLineas.DataSource = DS.Tables(0)
            Conexion.Close()
            Dim style = New DataGridViewCellStyle
            style.Format = "N2"
            style.Alignment = DataGridViewContentAlignment.MiddleRight
            DGLineas.Columns(4).DefaultCellStyle = style
            DGLineas.Columns(3).DefaultCellStyle = style
            Me.Visible = True
            Me.Refresh()

            Conexion.Open()
            Qry.Connection = Conexion
            Qry.CommandText = "select NumeroCuenta, DescripCuenta from FIN_CuentasContables"
            LeeSQL = Qry.ExecuteReader
            cmbCuenta.Items.Clear()
            Do While LeeSQL.Read
                cmbCuenta.Items.Add(LeeSQL("Numerocuenta") & " " & LeeSQL("DescripCuenta"))
            Loop
            Conexion.Close()
            System.Windows.Forms.Cursor.Current = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub


    Private Sub DGLineas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGLineas.CellContentClick
        Dim r As Integer = DGLineas.CurrentCell.RowIndex
        Dim debito As Decimal = 0
        Dim credito As Decimal = 0
        Try
            If Not IsDBNull(DGLineas.Rows(r).Cells(3).Value) Then debito = DGLineas.Rows(r).Cells(3).Value
            If Not IsDBNull(DGLineas.Rows(r).Cells(4).Value) Then credito = DGLineas.Rows(r).Cells(4).Value
            txDebito.Text = Format(debito, "N2")
            txCredito.Text = Format(credito, "N2")
            Dim cuenta As String = DGLineas.Rows(r).Cells(1).Value.ToString
            Dim indice As Integer = -1, i As Integer = 0
            Do While i <= cmbCuenta.Items.Count - 1
                If cmbCuenta.Items(i).ToString.Length > cuenta.Length Then
                    If cmbCuenta.Items(i).ToString.Substring(0, cuenta.Length) = cuenta Then
                        indice = i
                        Exit Do
                    End If
                End If
                i += 1
            Loop
            cmbCuenta.SelectedIndex = indice
        Catch er As Exception
            MsgBox(er.Message)

        End Try
    End Sub

    Private Sub TxNAsiento_LostFocus(sender As Object, e As EventArgs) Handles TxNAsiento.LostFocus
        Try
            Conexion.Close()
            Conexion.Open()
            Dim qry As New SqlClient.SqlCommand
            Dim rdr As SqlClient.SqlDataReader
            Dim nmes As String = cmbMes.SelectedItem.ToString
            qry.Connection = Conexion
            qry.CommandText = "select * from vw_FINAsientoEncabezado where periodo='" & cmbPeriodo.SelectedItem.ToString & "' and mes='" & nmes & "' and NumeroAsiento='" & TxNAsiento.Text & "'"
            rdr = qry.ExecuteReader()
            If rdr.HasRows Then
                MsgBox("El asiento " & TxNAsiento.Text & " ya existe " & vbNewLine & "Favor verificar", vbExclamation)
                TxNAsiento.SelectAll()
                TxNAsiento.Focus()
                Conexion.Close()
            End If
            Conexion.Close()
            Dim oAsiento As FIN_Objetos.Asiento
            oAsiento = New FIN_Objetos.Asiento
            oAsiento.Detalle = "123"
            oAsiento.FechaAsiento = Now
            oAsiento.Numero = "222"
            oAsiento.Graba()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 
    
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class