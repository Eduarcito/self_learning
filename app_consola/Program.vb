Imports System

Module Program
    Sub Main(args As String())

        'declaracion de array
        Dim miArray(2, 2) As String
        miArray(0, 0) = "Eduardo"
        miArray(0, 1) = "20"
        miArray(0, 2) = "60697187"


        miArray(1, 0) = "Wilber"
        miArray(1, 1) = "21"
        miArray(1, 2) = "60697187"

        miArray(2, 0) = "Iraheta"
        miArray(2, 1) = "22"
        miArray(2, 2) = "60697187"

        'mostrar el valor en la consola
        Console.WriteLine(miArray(2, 0) & " " & miArray(2, 1) & " " & miArray(2, 2))
        Console.Read()
    End Sub
End Module
