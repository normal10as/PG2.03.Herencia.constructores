Public Class Animal
    Sub New()
        Console.WriteLine("Soy animal ")
    End Sub

    Sub New(vertebrado As Boolean)
        Me.New()
        Console.WriteLine(If(vertebrado, "Vertebrado", "Invertebrado"))
    End Sub
End Class
