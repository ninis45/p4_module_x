Class MainWindow

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub ShowDetails()
        Dim ventana As Details = New Details()

        ventana.Show()



    End Sub
End Class
