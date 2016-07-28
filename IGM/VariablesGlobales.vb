Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Net
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



    



Module VariablesGlobales
        'Uso comun
        Public Conexion As SqlConnection
        Public MemServer As String
        Public MemDatabase As String
        Public MemUser As String
        Public MemPassword As String
        Public MemTrusted As Boolean = False
        Public MemConnect As String
        Public MemUsuarioSistema As String
        Public MemCodigoUsuario As Integer
        Public MemUsuario As String
        Public MemNombreCompania As String
        'Financiero
        Public MemFIN_FormatoCuenta As String
        Public MemFINAsiento As String
        Public MemFINPeriodo As String
        Public MemFINMes As String
        'Objetos
        Public MemObjForm As Form


        Public Sub SetDBLogonForReport(ByVal connectionInfo As ConnectionInfo, ByVal reportDocument As ReportDocument)
            Dim tables As Tables
            tables = reportDocument.Database.Tables
            For Each table As CrystalDecisions.CrystalReports.Engine.Table In tables
                Dim tableLogonInfo As New TableLogOnInfo
                tableLogonInfo = table.LogOnInfo
                tableLogonInfo.ConnectionInfo = connectionInfo
                table.ApplyLogOnInfo(tableLogonInfo)
            Next
        End Sub
    End Module

    Public Class ReportServerCredentials

        'Implements IReportServerCredentials

        Private _userName As String
        Private _password As String
        Private _domain As String

        Public Sub New(ByVal userName As String, ByVal password As String, ByVal domain As String)
            _userName = userName
            _password = password
            _domain = domain
        End Sub

        Public ReadOnly Property ImpersonationUser() As System.Security.Principal.WindowsIdentity
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property NetworkCredentials() As ICredentials
            Get
                Return New NetworkCredential(_userName, _password, _domain)
            End Get
        End Property

        Public Function GetFormsCredentials(ByRef authCookie As System.Net.Cookie, ByRef userName As String, ByRef password As String, ByRef authority As String) As Boolean
            authCookie = Nothing
            userName = password = authority = Nothing
            Return False
        End Function

        'Public Function GetFormsCredentials1(ByRef authCookie As System.Net.Cookie, ByRef userName As String, ByRef password As String, ByRef authority As String) As Boolean Implements Microsoft.Reporting.WebForms.IReportServerCredentials.GetFormsCredentials

        'End Function

        'Public ReadOnly Property ImpersonationUser1() As System.Security.Principal.WindowsIdentity Implements Microsoft.Reporting.WebForms.IReportServerCredentials.ImpersonationUser
        '    Get
        '
        '       End Get
        '   End Property

        'Public ReadOnly Property NetworkCredentials1() As System.Net.ICredentials Implements Microsoft.Reporting.WebForms.IReportServerCredentials.NetworkCredentials
        '    Get

        '    End Get

        'End Property


    End Class

    Public Class Reportes
        Public Sub SetDBLogonForReport(ByVal connectionInfo As ConnectionInfo, ByVal reportDocument As ReportDocument)
            Dim tables As Tables
            tables = reportDocument.Database.Tables
            For Each table As CrystalDecisions.CrystalReports.Engine.Table In tables
                Dim tableLogonInfo As New TableLogOnInfo
                tableLogonInfo = table.LogOnInfo
                tableLogonInfo.ConnectionInfo = connectionInfo
                table.ApplyLogOnInfo(tableLogonInfo)
            Next
        End Sub
    End Class
    Public Class Funciones
        Public Shared Function Acceso(ByVal CodUsuario As Integer, ByVal Opcion As String, Optional ByVal Mensaje As Boolean = False) As Boolean
            Acceso = False
            Dim Con As New SqlConnection(MemConnect)
            Con.Open()
            Dim tmpQry As New SqlClient.SqlCommand("Select top 1 * from SEG_OpcionesUsuario where CodUsuario=" & CodUsuario.ToString & " and CodigoOpcion='" & Opcion & "'", Con)
            Dim DR As SqlClient.SqlDataReader
            DR = tmpQry.ExecuteReader
            While DR.Read
                Acceso = True
            End While
            Con.Close()
            If Mensaje And Not Acceso Then MsgBox("Usted no tiene acceso a esta opcion", vbExclamation)
        End Function
End Class

