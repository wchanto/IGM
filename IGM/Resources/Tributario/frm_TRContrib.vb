Imports System.Text.RegularExpressions

Public Class frm_TRContrib
    Public vTRBIDContrib As String
    Public Sub get_campos()
        Conexion.Open()
        Dim dummy As String
        dummy = "SELECT TOP 1000 TC.Descripcion,CC.Contenido AS Valor,tc.tipocampo FROM TRB_TipoCampo TC"
        dummy = dummy & " LEFT JOIN TRB_ContribCampos CC ON CC.TipoCampo=TC.TipoCampo"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGCampos.DataSource = DS.Tables(0)
        Conexion.Close()
        DGCampos.RowHeadersVisible = True
        DGCampos.Columns(0).ReadOnly = True

        DGCampos.Columns(2).Visible = False
        'DGCampos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DGCampos.Columns(1).Width = 500
        DGCampos.Columns(0).Width = 200
        DGCampos.Columns(0).Frozen = True
        DGCampos.SelectionMode = DataGridViewSelectionMode.CellSelect
        DGCampos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub
    Public Shared Function formatoTexto(phoneNum As String, phoneFormat As String) As String

        If phoneFormat = "" Then
            ' Default format is (###) ###-####
            phoneFormat = "(###) ###-####"
        End If

        ' First, remove everything except of numbers
        Dim regexObj As Regex = New Regex("[^\d]")
        phoneNum = regexObj.Replace(phoneNum, "")

        ' Second, format numbers to phone string
        If phoneNum.Length > 0 Then
            phoneNum = Convert.ToInt64(phoneNum).ToString(phoneFormat)
        End If

        Return phoneNum
    End Function
    Private Sub habilitar(Valor As Boolean)
        txIdentificacion.Enabled = Valor
        txApellido1.Enabled = Valor
        txApellido2.Enabled = Valor
        txNombre.Enabled = Valor
        txNombreCompleto.Enabled = Valor
        chkPublico.Enabled = Valor
        optFisico.Enabled = Valor
        OptJuridico.Enabled = Valor
        DGCampos.Enabled = Valor
        DPDefun.Enabled = Valor
        DPNacimiento.Enabled = Valor
        btnAdd.Enabled = Not Valor
        btnEdit.Enabled = Not Valor
        btnSave.Enabled = Valor
        btnDel.Enabled = Not Valor
        btnUndo.Enabled = Valor
    End Sub
    Private Sub limpiar()
        txIdentificacion.Text = ""
        txApellido1.Text = ""
        txApellido2.Text = ""
        txNombre.Text = ""
        txNombreCompleto.Text = ""
        DPNacimiento.Format = DateTimePickerFormat.Custom
        DPNacimiento.CustomFormat = "    "
        DPDefun.Format = DateTimePickerFormat.Custom
        DPDefun.CustomFormat = "    "
    End Sub

    Private Sub txNombreCompleto_TextChanged(sender As Object, e As EventArgs) Handles txNombreCompleto.TextChanged

    End Sub

    Private Sub frm_TRContrib_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_TiposCampo.Visible = Funciones.Acceso(MemCodigoUsuario, "03.01.01.50")
        btnAdd.Visible = Funciones.Acceso(MemCodigoUsuario, "03.01.01.10")
        btnEdit.Visible = Funciones.Acceso(MemCodigoUsuario, "03.01.01.10")
        btnDel.Visible = Funciones.Acceso(MemCodigoUsuario, "03.01.01.20")
        btnSave.Visible = Funciones.Acceso(MemCodigoUsuario, "03.01.01.10")
        btnUndo.Visible = Funciones.Acceso(MemCodigoUsuario, "03.01.01.10")
        get_campos()

        DPDefun.Format = DateTimePickerFormat.Custom
        DPDefun.CustomFormat = "    "
    End Sub

    Private Sub DGCampos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCampos.CellContentClick

    End Sub

    Private Sub DGCampos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGCampos.CellEndEdit
        With DGCampos.CurrentCell
            If .ColumnIndex = 1 Then
                If Not IsDBNull(.Value) Then
                    Conexion.Open()
                    Dim tmp_qry As String = "Select largo,formato from TRB_TipoCampo where TipoCampo=" & DGCampos.CurrentRow.Cells(2).Value.ToString
                    Dim dc As New SqlClient.SqlCommand(tmp_qry, Conexion)
                    Dim dr As SqlClient.SqlDataReader
                    dr = dc.ExecuteReader
                    Dim tx_formato As String = ""
                    Dim tx_largo As Int16
                    Do While dr.Read
                        tx_largo = dr("Largo")
                        tx_formato = dr("Formato")
                    Loop
                    Conexion.Close()
                    If tx_formato <> "" Then
                        .Value = formatoTexto(.Value, tx_formato)
                    End If
                End If
            End If
        End With

        '----------------------


    End Sub

    Private Sub DGCampos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGCampos.CellEnter
        'If DGCampos.CurrentCell.ColumnIndex = 2 Then
        'DGCampos.EditMode = DataGridViewEditMode.EditOnEnter
        'End If
        With DGCampos.CurrentCell
            ' If .RowIndex = 0 Then
            .ValueType = GetType(Decimal)
            .Style.Format = "C2" '"####-####"
            'End If
        End With
    End Sub

    Private Sub DGCampos_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGCampos.CellLeave

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lb_TiposCampo.Click
        TRB_TiposCampo.ShowDialog()
        get_campos()
    End Sub


    Private Sub lb_TiposCampo_MouseHover(sender As Object, e As EventArgs) Handles lb_TiposCampo.MouseHover
        Dim tmpFont As Font = lb_TiposCampo.Font
        Dim tmpFontU As New Font(tmpFont, FontStyle.Underline)
        lb_TiposCampo.Font = tmpFontU
    End Sub

    Private Sub lb_TiposCampo_MouseLeave(sender As Object, e As EventArgs) Handles lb_TiposCampo.MouseLeave
        Dim tmpFont As Font = lb_TiposCampo.Font
        Dim tmpFontU As New Font(tmpFont, FontStyle.Regular)
        lb_TiposCampo.Font = tmpFontU
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        habilitar(True)
        limpiar()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        habilitar(False)
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        habilitar(False)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        habilitar(True)
    End Sub

    Private Sub DPDefun_KeyDown(sender As Object, e As KeyEventArgs) Handles DPDefun.KeyDown
        If e.KeyCode = Keys.Delete Then
            DPDefun.Format = DateTimePickerFormat.Custom
            DPDefun.CustomFormat = "    "
        End If
    End Sub



    Private Sub DPDefun_ValueChanged(sender As Object, e As EventArgs) Handles DPDefun.ValueChanged
        DPDefun.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub DPNacimiento_KeyDown(sender As Object, e As KeyEventArgs) Handles DPNacimiento.KeyDown
        If e.KeyCode = Keys.Delete Then
            DPNacimiento.Format = DateTimePickerFormat.Custom
            DPNacimiento.CustomFormat = "    "
        End If
    End Sub

    Private Sub DPNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DPNacimiento.ValueChanged
        DPNacimiento.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        frm_TRGetContribuyente.ShowDialog()
        txIdentificacion.Text = frm_TRGetContribuyente.DGContrib.Tag
        frm_TRGetContribuyente.Close()
        txIdentificacion_Leave(sender, e)
    End Sub

    Private Sub txIdentificacion_Leave(sender As Object, e As EventArgs) Handles txIdentificacion.Leave
        Conexion = New SqlClient.SqlConnection(MemConnect)
        Conexion.Open()

        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader

        tmpQry.Connection = Conexion
        tmpQry.CommandText = "select top 1 * from TRB_Contribuyentes where identificacion='" & txIdentificacion.Text & "'"
        leeSQL = tmpQry.ExecuteReader
        Dim clave As String = ""
        Do While leeSQL.Read
            txNombreCompleto.Text = leeSQL.Item("nombre")
            txNombre.Text = leeSQL.Item("nombrefisico")
            txApellido1.Text = leeSQL.Item("apellido1")
            txApellido2.Text = leeSQL.Item("Apellido2")
        Loop
        Conexion.Close()
    End Sub


    Private Sub txIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles txIdentificacion.TextChanged

    End Sub
End Class