Public Class Product
    Public Property IsActive() As Boolean
    Public Property Name() As String
    Public Property ProductNumber() As String
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Sub CalculateSellEndDate(ByVal days As Integer)
        SellEndDate = SellStartDate.AddDays(days)
    End Sub
End Class
