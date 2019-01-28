
Imports Prism.Mvvm
Imports Prism.Commands


Public Class MVMEmpleado
    Inherits BindableBase
    Private _empleado As EmpleadoModel
    Private _list As List(Of EmpleadoModel)



    Sub New()
        _show_details = New DelegateCommand(AddressOf Show_Details)
        _add = New DelegateCommand(AddressOf Add)
        _list = New List(Of EmpleadoModel) From {
            New EmpleadoModel() With {.id = 1, .nombre = "Bernardo"},
            New EmpleadoModel() With {.id = 2, .nombre = "Danira"}
        }

        _empleado = New EmpleadoModel()










    End Sub

    Public Property GetList() As List(Of EmpleadoModel)

        Get
            Return _list

        End Get

        Set(ByVal value As List(Of EmpleadoModel))
            _list = value
            RaisePropertyChanged("GetList")
        End Set

    End Property
    Public Property GetEmpleado() As EmpleadoModel
        Get
            Return _empleado

        End Get

        Set(ByVal value As EmpleadoModel)

            _empleado = value

            RaisePropertyChanged("GetEmpleado")
        End Set

    End Property
    Private _show_details As ICommand
    Public Property CommandShowDetails() As ICommand
        Get
            Return _show_details
        End Get
        Set(ByVal value As ICommand)
            _show_details = value
        End Set
    End Property


    Private _add As ICommand
    Public Property CommandAdd() As ICommand
        Get
            Return _add
        End Get
        Set(ByVal value As ICommand)
            _add = value
        End Set
    End Property


    Public Sub Add()

        MsgBox(GetEmpleado.nombre)

        If GetEmpleado IsNot Nothing Then


            _list.Add(GetEmpleado)
        End If



    End Sub
    Public Sub Show_Details()
        Dim ventana As Details = New Details()





        ventana.DataContext = Me





        ventana.Show()

    End Sub

End Class
