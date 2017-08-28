Public Class Mamifero
    Inherits Animal

    Sub New()
        Me.New(True)
    End Sub

    Sub New(terrestre As Boolean)
        MyBase.New(True)    'vertebrado
        Console.WriteLine("Soy mamífero")
        Console.WriteLine(If(terrestre, "Vivo en la tierra", "Vivo en el agua"))
    End Sub
End Class