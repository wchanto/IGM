Public Class frm_RHEmpleado

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles lbN.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles LbA.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tbEmple_Selected(sender As Object, e As TabControlEventArgs) Handles tbEmple.Selected
        LbA.ForeColor = Color.ForestGreen : lbP.ForeColor = Color.ForestGreen : lbH.ForeColor = Color.ForestGreen
        lbN.ForeColor = Color.ForestGreen : lbV.ForeColor = Color.ForestGreen : lbM.ForeColor = Color.ForestGreen

        Select Case tbEmple.SelectedTab.Name
            Case "tbNomina"
                lbN.ForeColor = Color.DarkBlue
            Case "tbPersonal"
                lbP.ForeColor = Color.DarkBlue
            Case "tbEstudio"
                LbA.ForeColor = Color.DarkBlue
            Case "tbHisto"
                lbH.ForeColor = Color.DarkBlue
            Case "tbVacaciones"
                lbV.ForeColor = Color.DarkBlue
            Case "tbMedico"
                lbM.ForeColor = Color.DarkBlue
        End Select
    End Sub

    Private Sub tbPersonal_Click(sender As Object, e As EventArgs) Handles tbPersonal.Click

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub
End Class