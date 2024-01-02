Imports System.Runtime.CompilerServices

Module MainModule
    Dim ProductId As Integer = 1
    Dim isActive As Boolean = True
    Dim Name As String = "10 Speed Bike"
    Dim ListPrice As Decimal = 999.99D
    Dim SellStartDate As DateTime = #1/1/2019#
    Dim newObject As Object = "anythng can go here but this datatype is heavy"
    Private Const DEFAULT_LIST_PRICE As Decimal = 999.99D

    Sub Main()
        IncrementListPrice()
        IncrementListPrice()
        IncrementListPrice()
        Dim prod As New Product()
        prod.SellStartDate = Date.Now()
        prod.CalculateSellEndDate(5)
        Console.WriteLine(prod.SellEndDate)
        prod.IncrementSellEndDate()
        Console.WriteLine(prod.SellEndDate)
        Console.WriteLine(prod.CalculateProfit())
        Console.WriteLine(prod.CalculateProfit(700))
        Console.WriteLine(Product.CalculateTheProfit(100, 200))


        Console.ReadKey()

    End Sub

    Sub IncrementListPrice()
        Static ListPrice As Decimal = 0
        ListPrice = ListPrice + 1
        Console.WriteLine(ListPrice)
    End Sub



End Module
