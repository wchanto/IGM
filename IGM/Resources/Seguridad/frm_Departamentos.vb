Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_Departamentos
    Private Function GetCodigo(ByVal Texto As String) As String
        Dim Posicion As Int16
        Dim PosicionInicial As Int16
        PosicionInicial = 0
        For Posicion = Texto.Length To 1 Step -1
            If Texto.Substring(Posicion - 1, 1) = "(" Then PosicionInicial = Posicion
        Next
        GetCodigo = Texto.Substring(PosicionInicial)
        GetCodigo = GetCodigo.Substring(0, GetCodigo.Length - 1)
    End Function
    Private Sub getDeptos()
        Conexion.Open()
        Dim dummy As String
        dummy = "select Departamentos.Departamento,Departamentos.Descripcion,centroTrabajo.descripcion+'  ('+Departamentos.CentroTrab+')' as CentroTrabajo "
        dummy = dummy & "from Departamentos inner join CentroTrabajo on CentroTrabajo.CentroTrab=Departamentos.CentroTrab"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGDeptos.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub frm_Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCtroTrab.Items.Clear()
        Conexion.Open()
        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader
        tmpQry.Connection = Conexion
        Dim dummy As String

        dummy = "select CentroTrab,Descripcion from CentroTrabajo order by 1 "
        tmpQry.CommandText = dummy
        leeSQL = tmpQry.ExecuteReader
        Dim x As Integer = 0
        While leeSQL.Read
            cmbCtroTrab.Items.Add(leeSQL("Descripcion") & "  (" & leeSQL("CentroTrab") & ")")
            x = cmbCtroTrab.Items.Count - 1
        End While
        Conexion.Close()
        If cmbCtroTrab.Items.Count > 0 Then
            cmbCtroTrab.SelectedIndex = 0
        End If

        getDeptos()
    End Sub

    Private Sub DGCentros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDeptos.CellClick
        Dim r As Integer
        r = DGDeptos.CurrentCell.RowIndex
        TxCod.Text = DGDeptos.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGDeptos.Rows(r).Cells(1).Value.ToString
        cmbCtroTrab.SelectedIndex = -1
        Dim nIndice As Int16
        nIndice = -1
        For x = 0 To cmbCtroTrab.Items.Count - 1
            If GetCodigo(cmbCtroTrab.Items(x).ToString) = GetCodigo(DGDeptos.Rows(r).Cells(2).Value.ToString) Then nIndice = x
        Next
        cmbCtroTrab.SelectedIndex = nIndice

    End Sub



    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        TxCod.Enabled = True : TxNombre.Enabled = True : cmbCtroTrab.Enabled = True
        TxCod.Text = "" : TxNombre.Text = ""
        btn_New.Enabled = Not btn_New.Enabled
        btn_Save.Enabled = Not btn_Save.Enabled
        btn_Edit.Enabled = Not btn_Edit.Enabled
        btn_Delete.Enabled = Not btn_Delete.Enabled
        btn_Undo.Enabled = Not btn_Undo.Enabled

    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun codigo seleccionado", vbInformation)
            Exit Sub
        End If
        TxCod.Enabled = True : TxNombre.Enabled = True : cmbCtroTrab.Enabled = True
        btn_New.Enabled = Not btn_New.Enabled
        btn_Save.Enabled = Not btn_Save.Enabled
        btn_Edit.Enabled = Not btn_Edit.Enabled
        btn_Delete.Enabled = Not btn_Delete.Enabled
        btn_Undo.Enabled = Not btn_Undo.Enabled
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        TxCod.Enabled = True : TxNombre.Enabled = True : cmbCtroTrab.Enabled = True
        btn_New.Enabled = Not btn_New.Enabled
        btn_Save.Enabled = Not btn_Save.Enabled
        btn_Edit.Enabled = Not btn_Edit.Enabled
        btn_Delete.Enabled = Not btn_Delete.Enabled
        btn_Undo.Enabled = Not btn_Undo.Enabled

        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from Departamentos where Departamento='" & TxCod.Text & "'", Conexion)
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

            tmpQry = "Insert into Departamentos (Departamento,CentroTrab,Descripcion) "
            tmpQry = tmpQry & "Values('" & TxCod.Text & "','"
            tmpQry = tmpQry & GetCodigo(cmbCtroTrab.SelectedItem.ToString) & "','"
            tmpQry = tmpQry & TxNombre.Text & "')"

            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            tmpQry = "Update Departamentos set Descripcion='" & TxNombre.Text
            tmpQry = tmpQry & "',CentroTrab='" & GetCodigo(cmbCtroTrab.SelectedItem.ToString) & "' "
            tmpQry = tmpQry & " where Departamento='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If
        TxCod.Text = "" : TxNombre.Text = ""
        getDeptos()
    End Sub

    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        TxCod.Enabled = True : TxNombre.Enabled = True : cmbCtroTrab.Enabled = True
        TxCod.Text = "" : TxNombre.Text = ""
        btn_New.Enabled = Not btn_New.Enabled
        btn_Save.Enabled = Not btn_Save.Enabled
        btn_Edit.Enabled = Not btn_Edit.Enabled
        btn_Delete.Enabled = Not btn_Delete.Enabled
        btn_Undo.Enabled = Not btn_Undo.Enabled
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun codigo seleccionado", vbInformation)
            Exit Sub
        End If

        Try
            If MsgBox("Esta seguro que desea eliminar el codigo " & TxCod.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then

                Dim tmpQry As String = "delete from Departamentos where Departamento='" & TxCod.Text & "'"
                Dim DC As New SqlClient.SqlCommand(tmpQry, Conexion)
                Conexion.Open()
                DC.ExecuteNonQuery()
                Conexion.Close()
                getDeptos()
                MsgBox("El codigo se borro exitosamente", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_Departamentos

        connectionInfo.ServerName = MemServer
        connectionInfo.DatabaseName = MemDatabase
        'connectionInfo.IntegratedSecurity = False
        connectionInfo.UserID = MemUser
        connectionInfo.Password = MemPassword
        SetDBLogonForReport(connectionInfo, cr)
        frm_REP.CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("NombreCompania", MemNombreCompania)

        frm_REP.Show()
    End Sub
End Class