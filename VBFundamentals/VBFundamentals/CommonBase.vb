Public Class CommonBase
    Sub New()
        IsActive = True
        ModifiedDate = DateTime.Now
        CreatedBy = Environment.UserName
    End Sub
    Public Property IsActive As Boolean
    Public Property ModifiedDate As DateTime
    Public Property CreatedBy As String

End Class
