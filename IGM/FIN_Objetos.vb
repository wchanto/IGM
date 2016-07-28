Public Class FIN_Objetos
    Public Class Asiento
        Private NumeroAsiento As String
        Public Property Numero As String
            Get
                Return NumeroAsiento
            End Get
            Set(value As String)
                NumeroAsiento = value
            End Set
        End Property
        Private DFechaAsiento As Date
        Public Property FechaAsiento As String
            Get
                Return DFechaAsiento
            End Get
            Set(value As String)
                DFechaAsiento = value
            End Set
        End Property
        Private txtDetalle As String
        Public Property Detalle As String
            Get
                Return txtDetalle
            End Get
            Set(value As String)
                txtDetalle = value
            End Set
        End Property

        Public Sub Graba()
            ' MsgBox("Se grabo correctamente")
        End Sub
    End Class
End Class
