Public Class MixEntry
    Public Property MixId As Integer
    Public Property MixTitle As String
    Public Property ProductId As Integer
    Public Property InvoiceId As String

    Public Sub New(mixId As Integer, mixTitle As String, productId As Integer, invoiceId As String)
        Me.MixId = mixId
        Me.MixTitle = mixTitle
        Me.ProductId = productId
        Me.InvoiceId = invoiceId
    End Sub

    Public Overrides Function ToString() As String
        Return $"{MixId}, {MixTitle}, {ProductId}, {InvoiceId}"
    End Function



End Class
