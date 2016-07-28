Public Class frm_Intro

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Revisa Usuario/Clave
        Conexion = New SqlClient.SqlConnection(MemConnect)
        Conexion.Open()

        Dim tmpQry As New SqlClient.SqlCommand
        Dim leeSQL As SqlClient.SqlDataReader

        tmpQry.Connection = Conexion
        tmpQry.CommandText = "Select * from Seg_Usuarios where Usuario ='" & TxUser.Text & "'"
        leeSQL = tmpQry.ExecuteReader

        If leeSQL.HasRows = False Then
            MsgBox("No existe el usuario", vbExclamation)
            Conexion.Close()
            TxUser.SelectAll()
            TxUser.Focus()
            Exit Sub
        End If

        Do While leeSQL.Read
            If TxPassword.Text <> leeSQL("Clave") Then
                MsgBox("Clave Incorrecta", vbExclamation)
                Conexion.Close()
                TxPassword.SelectAll()
                TxPassword.Focus()
                Exit Sub
            End If
            MemCodigoUsuario = leeSQL("CodUsuario")
            MemUsuarioSistema = leeSQL("Nombre")
            MemUsuario = leeSQL("Usuario")
        Loop
        Conexion.Close()

        Conexion.Open()
        tmpQry.Connection = Conexion : tmpQry.CommandText = "Select Valor from SYS_Valores where CodValor='NCIA'"
        leeSQL = tmpQry.ExecuteReader
        Do While leeSQL.Read
            MemNombreCompania = leeSQL("Valor")
        Loop
        Conexion.Close()

        frm_Menu.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_Conexion.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frm_Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Obtiene parametros de conexion
        MemServer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "Server", Nothing)
        MemUser = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "User", Nothing)
        MemDatabase = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "Database", Nothing)
        MemPassword = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "Password", Nothing)
        MemConnect = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "StringConexion", Nothing)
        MemTrusted = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\IGM", "Trusted", Nothing)
        IGM.My.Settings("IGMConnectionString") = MemConnect
        If MemServer = Nothing Then
            frm_Conexion.ShowDialog()
        End If
        Button1.Focus()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class