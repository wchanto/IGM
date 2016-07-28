Public Class frm_PLSRegTramite

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro de que desea cancelar el registro del tramite", vbQuestion + vbYesNo + vbDefaultButton2) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_PLSRegTramite2.Top = Me.Top : frm_PLSRegTramite2.Left = Me.Left
        frm_PLSRegTramite2.ShowDialog()
    End Sub
End Class