Public Class Product
    Inherits CommonBase
    Public Property Name() As String
    Public Property ProductNumber() As String
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal

    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now
    End Sub

    Sub CalculateSellEndDate(ByVal days As Integer)
        SellEndDate = SellStartDate.AddDays(days)
    End Sub

    Function IncrementSellEndDate() As DateTime
        SellEndDate = SellEndDate.AddDays(1)
        Return SellEndDate
    End Function

    Function CalculateProfit(Optional ByVal newCost As Decimal = 0)
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        Return ListPrice - StandardCost
    End Function

    Shared Function CalculateTheProfit(ByVal cost As Decimal, ByVal price As Decimal) As Decimal
        'can be accessed via the class name
        Return price - cost
    End Function
    Overrides Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Product Number: " + ProductNumber)
        sb.AppendLine(MyBase.GetClassData)

        Return sb.ToString()
    End Function
End Class
