Public Class frm_PLSRegTramite2

   
    Private Sub frm_PLSRegTramite2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Left = MemObjForm.Left : Me.Top = MemObjForm.Top
        Me.Width = MemObjForm.Width : Me.Height = MemObjForm.Height
        MemObjForm.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro de que desea cancelar el registro del tramite", vbQuestion + vbYesNo + vbDefaultButton2) = MsgBoxResult.Yes Then
            Me.Close()
            MemObjForm.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        MemObjForm.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_PLSRegTramite3.Show()
        Me.Visible = False
    End Sub
End Class