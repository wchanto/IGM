
Public Class frm_TRGetContribuyente

    Private Sub frm_TRGetContribuyente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.Open()
        Dim dummy As String
        dummy = "SELECT Identificacion,Nombre,NombreFisico,Apellido1,Apellido2 FROM TRB_Contribuyentes"
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGContrib.DataSource = DS.Tables(0)
        Conexion.Close()
        DGContrib.Columns(0).Width = 80
        DGContrib.Columns(1).Width = 700
        DGContrib.Columns(1).Width = 200
    End Sub

    Private Sub txFiltro_TextChanged(sender As Object, e As EventArgs) Handles txFiltro.TextChanged
        Dim dummy As String
        dummy = "SELECT Identificacion,Nombre,NombreFisico,Apellido1,Apellido2 FROM TRB_Contribuyentes"

        If txFiltro.Text.Length > 0 Then
            dummy = dummy & " where Nombre like '%" & txFiltro.Text & "%'"
        End If

        Conexion.Open()
        Dim DA As New SqlClient.SqlDataAdapter(dummy, Conexion)
        Dim DS As New DataSet
        DA.Fill(DS)
        DGContrib.DataSource = DS.Tables(0)
        Conexion.Close()
    End Sub

    Private Sub DGContrib_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGContrib.CellContentClick

    End Sub

    Private Sub DGContrib_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGContrib.CellDoubleClick
        Dim r As Integer
        r = DGContrib.CurrentCell.RowIndex
        DGContrib.Tag = DGContrib.Rows(r).Cells(0).Value.ToString
        'frm_TRContrib.txIdentificacion.Text = DGContrib.Rows(r).Cells(0).Value.ToString
        Me.Hide()
    End Sub
End Class