Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frm_PLSRequisitos

    Private Sub get_Requisitos()
        Conexion.Open()
        Dim dummy As String
        dummy = "SELECT Requisito as Codigo,NombreRequisito as Nombre,descripcionRequisito as Detalle from PLSRequisitos"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGReq.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub
    Private Sub frm_PLSRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_Requisitos()
    End Sub

    Private Sub DGReq_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReq.CellClick
        Dim r As Integer
        r = DGReq.CurrentCell.RowIndex
        TxCod.Text = DGReq.Rows(r).Cells(0).Value.ToString
        TxNombre.Text = DGReq.Rows(r).Cells(1).Value.ToString
        TxDescrip.Text = DGReq.Rows(r).Cells(2).Value.ToString
    End Sub


    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        TxCod.Enabled = True : TxCod.Text = ""
        TxDescrip.Enabled = True : TxDescrip.Text = ""
        TxNombre.Enabled = True : TxNombre.Text = ""
        btn_New.Enabled = False
        btn_Save.Enabled = True
        btn_Delete.Enabled = False
        btn_Undo.Enabled = True
        btn_Edit.Enabled = False
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If TxCod.Text = "" Then
            MsgBox("No hay ningun registro seleccionado", vbEmpty)
            Exit Sub
        End If
        btn_New.Enabled = False
        btn_Save.Enabled = True
        btn_Delete.Enabled = False
        btn_Undo.Enabled = True
        btn_Edit.Enabled = False
        TxDescrip.Enabled = True
        TxNombre.Enabled = True
    End Sub

    Private Sub btn_Undo_Click(sender As Object, e As EventArgs) Handles btn_Undo.Click
        TxCod.Enabled = False : TxCod.Text = ""
        TxDescrip.Enabled = False : TxDescrip.Text = ""
        TxNombre.Enabled = False : TxNombre.Text = ""
        btn_New.Enabled = True
        btn_Save.Enabled = False
        btn_Delete.Enabled = True
        btn_Undo.Enabled = False
        btn_Edit.Enabled = True
    End Sub

    Private Sub TxCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxCod.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub



    Private Sub TxCod_LostFocus(sender As Object, e As EventArgs) Handles TxCod.LostFocus
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from PLSRequisitos where Requisito='" & TxCod.Text & "'", Conexion)
        Dim DR As SqlClient.SqlDataReader
        DR = DC.ExecuteReader
        Dim nuevo As Boolean = True
        Do While DR.Read
            TxNombre.Text = DR("NombreRequisito")
            TxDescrip.Text = DR("DescripcionRequisito")
            Dim res As Boolean
            If MsgBox("El codigo " & TxCod.Text & " ya existe. Desea editarlo", vbYesNo + vbQuestion + vbDefaultButton2) = MsgBoxResult.No Then
                TxNombre.Text = "" : TxCod.Text = "" : TxDescrip.Text = ""
                TxCod.Focus()
                Conexion.Close()
                Exit Sub
            End If
        Loop
        Conexion.Close()

    End Sub

    Private Sub TxCod_TextChanged(sender As Object, e As EventArgs) Handles TxCod.TextChanged

    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If Not Funciones.Acceso(MemCodigoUsuario, "04.01.80", True) Then Exit Sub
        If TxCod.Text = "" Then
            MsgBox("No hay ningun codigo seleccionado", vbInformation)
            Exit Sub
        End If

        If MsgBox("Esta seguro que desea eliminar el codigo " & TxCod.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
            Dim tmpQry As String = "Delete from PLSRequisitos where Requisito='" & TxCod.Text & "'"
            Dim DC As New SqlClient.SqlCommand(tmpQry, Conexion)
            Conexion.Open()
            DC.ExecuteNonQuery()
            Conexion.Close()
            get_Requisitos()
            MsgBox("El codigo se borro exitosamente", vbInformation)
        End If
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        btn_New.Enabled = True
        btn_Save.Enabled = False
        btn_Delete.Enabled = True
        btn_Undo.Enabled = False
        btn_Edit.Enabled = True
        TxCod.Enabled = False : TxDescrip.Enabled = False : TxNombre.Enabled = False

        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select top 1 * from PLSRequisitos where Requisito='" & TxCod.Text & "'", Conexion)
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

        If nuevo Then
            'obtiene nuevo codigo
            Conexion.Open()
            Dim tmpQry As String = "Insert into PLSRequisitos (Requisito,NombreRequisito,DescripcionRequisito,Ingreso,Modificio,Excluyo,F_Ingreso,F_Modifico,F_Excluyo) "
            tmpQry = tmpQry & "Values('" & TxCod.Text & "','" & TxNombre.Text & "','" & TxDescrip.Text & "','" & MemUsuario & "',NULL,NULL,GETDATE()"
            tmpQry = tmpQry & ",NULL,NULL)"
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        Else
            Dim tmpQry As String
            tmpQry = "Update PLSRequisitos set NombreRequisito='" & TxNombre.Text
            tmpQry = tmpQry & "',DescripcionRequisito='" & TxDescrip.Text
            tmpQry = tmpQry & "',Modificio='" & MemUsuario
            tmpQry = tmpQry & "',F_Modifico= getdate() where Requisito='" & TxCod.Text & "'"
            Conexion.Close()
            Conexion.Open()
            DC.CommandText = tmpQry
            DC.ExecuteNonQuery()
            Conexion.Close()
        End If
        get_Requisitos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim connectionInfo As New ConnectionInfo
        Dim cr As New rpt_PLS_Requisitos
        connectionInfo.ServerName = MemServer
        connectionInfo.DatabaseName = MemDatabase
        connectionInfo.IntegratedSecurity = True
        SetDBLogonForReport(connectionInfo, cr)
        frm_REP.CrystalReportViewer1.ReportSource = cr
        cr.SetParameterValue("NombreCompania", MemNombreCompania)
        frm_REP.Show()
    End Sub

    Private Sub DGReq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReq.CellContentClick

    End Sub
End Class