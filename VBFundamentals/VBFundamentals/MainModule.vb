Module MainModule
    Dim ProductId As Integer = 1
    Dim isActive As Boolean = True
    Dim Name As String = "10 Speed Bike"
    Dim ListPrice As Decimal = 999.99D
    Dim SellStartDate As DateTime = #1/1/2019#
    Dim newObject As Object = "anythng can go here but this datatype is heavy"

    Sub Main()
        IncrementListPrice()
        IncrementListPrice()
        IncrementListPrice()
        Console.ReadKey()
    End Sub

    Sub IncrementListPrice()
        Static ListPrice As Decimal = 0
        ListPrice = ListPrice + 1
        Console.WriteLine(ListPrice)
    End Sub

End Module
