Public Class frm_PLSRegTramite3

    Private Sub frm_PLSRegTramite3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = frm_PLSRegTramite2.Height : Me.Width = frm_PLSRegTramite2.Width
        Me.Left = frm_PLSRegTramite2.Left : Me.Top = frm_PLSRegTramite2.Top
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        frm_PLSRegTramite2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro de que desea cancelar el registro del tramite", vbQuestion + vbYesNo + vbDefaultButton2) = MsgBoxResult.Yes Then
            Me.Close()
            frm_PLSRegTramite2.Close()
            MemObjForm.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class