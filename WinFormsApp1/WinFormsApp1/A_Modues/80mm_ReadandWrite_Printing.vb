Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO

Module _80mm_ReadandWrite_Printing
    Private WithEvents pd As New PrintDocument()
    Private receiptData As ReceiptData

    Public Sub SetReceiptData(data As ReceiptData)
        receiptData = data
    End Sub

    Public Sub PrintReceipt(ByVal TillID)
        Dim query As String = "SELECT RTRIM(PrinterName) ,RTRIM(PrinterName2) FROM POSPrinterSetting WHERE TillID=@d1 AND IsEnabled='Yes'"
        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@D1", TillID))
        Dim dt As DataTable = Crud(query, parameters)
        If dt.Rows.Count > 0 Then

            If receiptData Is Nothing Then
                Throw New InvalidOperationException("Receipt data has not been set.")
            End If
            If dt(0)(1).ToString().Trim().Length = 0 Then
                Return
            End If
            pd.PrinterSettings.PrinterName = dt(0)(1).ToString().Trim()
            pd.Print()
        End If
    End Sub

    Private Sub kitchen_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Dim font As New Font("Arial", 10)
        Dim boldFont As New Font("Arial", 10, FontStyle.Bold)
        Dim largerBoldFont As New Font("Arial", 12, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim pen As New Pen(Color.Black)
        Dim dashPen As New Pen(Color.Black) With {.DashPattern = {2, 2}}
        Dim yPosition As Single = 0
        Dim leftMargin As Single = 5 ' Small left margin
        Dim rightMargin As Single = e.MarginBounds.Right
        Dim centerMargin As Single = (e.MarginBounds.Left + e.MarginBounds.Right) / 2

        ' Center align text function
        Dim centerAlign As Action(Of String, Font) = Sub(text As String, f As Font)
                                                         Dim textSize As SizeF = e.Graphics.MeasureString(text, f)
                                                         e.Graphics.DrawString(text, f, brush, centerMargin - (textSize.Width / 2), yPosition)
                                                         yPosition += f.GetHeight(e.Graphics)
                                                     End Sub

        ' Print "ORDER" at the top, bold, and increased font size
        centerAlign("ORDER", largerBoldFont)

        ' Print company name and additional details
        centerAlign(receiptData.CompanyName, font)
        centerAlign(receiptData.CompanyAddress, font)

        ' Print dashed line after header
        yPosition += 5
        e.Graphics.DrawLine(dashPen, leftMargin, yPosition, rightMargin, yPosition)
        yPosition += 5

        ' Change Sales Open No to Order No and make it bold
        centerAlign("Order No: " & receiptData.SalesOpenNo, boldFont)
        centerAlign("Invoice No: " & receiptData.InvoiceNo, font)
        centerAlign("Invoice Date: " & receiptData.InvoiceDate, font)
        centerAlign("Cashier: " & receiptData.CashierName, font)

        ' Print dashed line after subheader
        yPosition += 5
        e.Graphics.DrawLine(dashPen, leftMargin, yPosition, rightMargin, yPosition)
        yPosition += 5

        ' Print table headers
        centerAlign("Product Name", font)
        centerAlign("Qty", font)

        ' Print dashed line after table headers
        yPosition += 5
        e.Graphics.DrawLine(dashPen, leftMargin, yPosition, rightMargin, yPosition)
        yPosition += 5

        ' Print details
        For Each detail In receiptData.Details
            ' Print product name
            centerAlign(detail.ProductName, font)

            ' Print Qty on the same line
            centerAlign(detail.Qty.ToString(), font)

            ' Print dashed line after each product
            yPosition += 5
            e.Graphics.DrawLine(dashPen, leftMargin, yPosition, rightMargin, yPosition)
            yPosition += 5
        Next

        ' Print dashed line before summary
        yPosition += 5
        e.Graphics.DrawLine(dashPen, leftMargin, yPosition, rightMargin, yPosition)
        yPosition += 5

        ' Print footer summary
        centerAlign("Total: " & receiptData.TotalSummary, font)
        centerAlign(receiptData.Footer, font)

        ' Include note after the summary at the footer
        If Not String.IsNullOrEmpty(receiptData.NOTE) Then
            Dim noteLines As String() = receiptData.NOTE.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            For Each line As String In noteLines
                centerAlign(line, font)
            Next
        End If

        ' Include "Havano Point of Sale" below the footer
        yPosition += font.GetHeight(e.Graphics)
        centerAlign("Havano Point of Sale", font)
    End Sub

    Public Function SaveImageFromBytes(imageBytes As Byte(), filePath As String) As String
        Using ms As New MemoryStream(imageBytes)
            Dim image As Image = Image.FromStream(ms)
            image.Save(filePath)
        End Using
        Return filePath
    End Function

    Public Function SaveLogoImage(logoBytes As Byte(), filePath As String) As String
        Try
            Using ms As New MemoryStream(logoBytes)
                Dim image As Image = Image.FromStream(ms)
                image.Save(filePath)
            End Using
            Return filePath
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
End Module
Public Class ReceiptData
    Public Property CompanyLogoPath As String
    Public Property CompanyName As String
    Public Property CompanyAddress As String
    Public Property CompanyEmail As String
    Public Property TIN As String
    Public Property VATNo As String
    Public Property Tel As String
    Public Property SalesOpenNo As String
    Public Property InvoiceNo As String
    Public Property InvoiceDate As String
    Public Property CashierName As String
    Public Property CustomerName As String
    Public Property Customeraddress As String
    Public Property NOTE As String
    Public Property Details As List(Of ReceiptDetail)
    Public Property TotalSummary As String
    Public Property AmountTendered As String
    Public Property Change As String
    Public Property QRCodePath As String
    Public Property Currency As String
    Public Property Footer As String
    Public Property MultiCurrencyDetails As List(Of KeyValuePair(Of String, Decimal))
    Public Property DeviceID As String
    Public Property FiscalDay As String
    Public Property ReceiptNo As String
    Public Property CustomerRef As String
    Public Property VCode As String
    Public Property QRCode As String
    Public Property RoundOff As Decimal
    Public Property SN As String
    Public Property PColor As String
    Public Property PSize As String
    Public Property CCN As String
    Public Property DiscAmt As Decimal
    Public Property GrandTotal As Decimal
    Public Property TaxType As String
    Public Property MemberID As String
    Public Property PaymentMode As String
End Class

Public Class ReceiptDetail
    Public Property ProductName As String
    Public Property Qty As Integer
    Public Property Amount As Decimal
    Public Property Price As Decimal
End Class
