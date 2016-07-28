
Public Class frm_Conexion

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txUser.Enabled = RadioButton2.Checked
        txPassword.Enabled = RadioButton2.Checked
    End Sub

    Private Sub txUser_TextChanged(sender As Object, e As EventArgs) Handles txUser.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txUser.Enabled = RadioButton2.Checked
        txPassword.Enabled = RadioButton2.Checked
    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus

        Dim TxConnect As String = "Data Source=" & TxServer.Text & ";Initial catalog=master;"
        If RadioButton1.Checked Then
            TxConnect = TxConnect & "Trusted_Connection = yes"
        Else
            TxConnect = TxConnect & "User ID=" & txUser.Text & ";Password=" & txPassword.Text
        End If
        Dim con As New SqlClient.SqlConnection(TxConnect)

        ComboBox1.Items.Clear()
        con.Open()
        Dim cmd As New SqlClient.SqlCommand("Select * From sys.databases Where name not in('master','tempdb','model','msdb')", con)
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader()
        Do While sdr.Read()
            ComboBox1.Items.Add(sdr("name").ToString())
        Loop
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex < 0 Then
            MsgBox("No se ha seleccionado una base de datos", vbExclamation)
            Exit Sub
        End If
        Dim TxConnect As String = "Data Source=" & TxServer.Text & ";Initial catalog=" & ComboBox1.SelectedItem.ToString & ";"
        If RadioButton1.Checked Then
            TxConnect = TxConnect & "Trusted_Connection = yes"
        Else
            TxConnect = TxConnect & "User ID=" & txUser.Text & ";Password=" & txPassword.Text
        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IGM", "Server", TxServer.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IGM", "User", txUser.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IGM", "Password", txPassword.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IGM", "Trusted", RadioButton1.Checked)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IGM", "StringConexion", TxConnect)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\IGM", "Database", ComboBox1.SelectedItem.ToString)
        IGM.My.Settings("IGMConnectionString") = MemConnect
        MsgBox("Los valores se grabaron correctamente", vbInformation)
        Me.Close()
    End Sub

    Private Sub frm_Conexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxServer.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "Server", Nothing)
        txUser.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "User", Nothing)
        txPassword.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "Password", Nothing)
        RadioButton1.Checked = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "Trusted", Nothing)
        RadioButton2.Checked = Not RadioButton1.Checked
    End Sub
End Class