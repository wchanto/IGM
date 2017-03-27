Public Class TRB_TiposCampo

    Private Sub TRB_TiposCampo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If vbNo = MsgBox("¿Desea guardar los cambios?", vbQuestion + vbYesNo + vbDefaultButton1) Then Exit Sub

        'Lee la tabla en la base de datos, si el registro no existe en el array lo elimina de lo contrario lo modifica
        Conexion.Open()
        Dim DC As New SqlClient.SqlCommand("Select tipoCampo from TRB_TipoCampo", Conexion)
        Dim DR As SqlClient.SqlDataReader
        DR = DC.ExecuteReader
        Dim nuevo As Boolean = True
        Do While DR.Read
            Dim t_cod As Int16 = DR("TipoCampo")
            Dim existe As Boolean = False
            For a = 0 To dgCampos.Rows.Count - 1
                If dgCampos.Rows(a).Cells(0).Value = t_cod Then existe = True
            Next
            If Not existe Then
                Dim tmp_Conexion As New SqlClient.SqlConnection(MemConnect)
                tmp_Conexion.Open()
                Dim DC_Temp As New SqlClient.SqlCommand("delete from trb_TipoCampo where TipoCampo=" & t_cod.ToString, tmp_Conexion)
                DC_Temp.ExecuteNonQuery()
                tmp_Conexion.Close()
            End If
        Loop
        Conexion.Close()

        'lee el array para agregar registros que no esten en la base de datos.
        Dim tm_cod As String
        Dim tmp_qry As String
        For a = 0 To dgCampos.Rows.Count - 1
            tm_cod = dgCampos.Rows(a).Cells(0).Value
            If Not tm_cod = Nothing Then
                Conexion.Open()
                Dim DC1 As New SqlClient.SqlCommand("SELECT TOP 1 * FROM TRB_TipoCampo where TipoCampo=" & tm_cod.ToString, Conexion)
                Dim DR1 As SqlClient.SqlDataReader
                DR1 = DC1.ExecuteReader
                Dim es_nuevo As Boolean = True
                Do While DR1.Read
                    es_nuevo = False
                Loop

                Conexion.Close()
                Dim vRequerido As Integer = 0
                'CBool(DataGridView1.Rows(RowIndex).Cells(ColumnIndex).Value) 
                If CBool(dgCampos.Rows(a).Cells(4).Value) Then vRequerido = 1

                If es_nuevo Then
                    Conexion.Open()
                    tmp_qry = "INSERT INTO TRB_TipoCampo (TipoCampo,Descripcion,Largo,Formato,Requerido) values ("
                    tmp_qry = tmp_qry & dgCampos.Rows(a).Cells(0).Value & ",'"
                    tmp_qry = tmp_qry & dgCampos.Rows(a).Cells(1).Value & "',"
                    tmp_qry = tmp_qry & dgCampos.Rows(a).Cells(2).Value & ",'"
                    tmp_qry = tmp_qry & dgCampos.Rows(a).Cells(3).Value & "',"
                    tmp_qry = tmp_qry & vRequerido.ToString & ")"
                    DC1.CommandText = tmp_qry
                    DC1.ExecuteNonQuery()
                Else
                    Conexion.Open()
                    tmp_qry = "UPDATE TRB_TipoCampo SET Descripcion='" & dgCampos.Rows(a).Cells(1).Value & "',"
                    tmp_qry = tmp_qry & "Largo=" & dgCampos.Rows(a).Cells(2).Value & ","
                    tmp_qry = tmp_qry & "Formato='" & dgCampos.Rows(a).Cells(3).Value & "', "
                    tmp_qry = tmp_qry & "Requerido=" & vRequerido.ToString
                    tmp_qry = tmp_qry & " where TipoCampo=" & dgCampos.Rows(a).Cells(0).Value
                    DC1.CommandText = tmp_qry
                    DC1.ExecuteNonQuery()
                End If

                    Conexion.Close()
                End If
        Next
        Conexion.Close()
    End Sub

    Private Sub TRB_TiposCampo_Leave(sender As Object, e As EventArgs) Handles Me.Leave
    End Sub

    Private Sub TRB_TiposCampo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_Campos()
    End Sub
    Private Sub get_Campos()
        Conexion.Open()
        Dim dummy As String
        dummy = "select TipoCampo,Descripcion,Largo,Formato,Requerido from TRB_TipoCampo order by TipoCampo"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        dgCampos.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub

    Private Sub dgCampos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCampos.CellContentClick

    End Sub

    Private Sub dgCampos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgCampos.RowsRemoved
    End Sub
End Class