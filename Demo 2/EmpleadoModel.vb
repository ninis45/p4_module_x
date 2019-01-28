Public Class EmpleadoModel

    Public Property id() As Integer
        Private _nombre As String

        Sub New()

        End Sub
        Public Property nombre() As String
            Get
                Return _nombre
            End Get

            Set(ByVal value As String)
                _nombre = value
            End Set

        End Property








End Class
