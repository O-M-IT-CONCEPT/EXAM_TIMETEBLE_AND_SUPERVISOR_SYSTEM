Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing

Public Class ReceiptPrinter
    Private receiptData As ReceiptData

    Public Sub New(data As ReceiptData)
        receiptData = data
    End Sub

    Public Sub PrintReceipt1(ByVal TillID)
        Dim printDoc As New PrintDocument()
        Dim query As String = "SELECT RTRIM(PrinterName) ,RTRIM(PrinterName2) FROM POSPrinterSetting WHERE TillID=@d1 AND IsEnabled='Yes'"
        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@D1", TillID))
        Dim dt As DataTable = Crud(query, parameters)
        If dt.Rows.Count > 0 Then
            If receiptData Is Nothing Then
                Throw New InvalidOperationException("Receipt data has not been set.")
            End If
            If dt(0)(0).ToString().Trim().Length = 0 Then
                Return
            End If
            AddHandler printDoc.PrintPage, AddressOf Me.OnPrintPage
            printDoc.PrinterSettings.PrinterName = dt(0)(0).ToString().Trim()
            printDoc.Print()
        End If
        '   AddHandler printDoc.PrintPage, AddressOf Me.OnPrintPage
        '  printDoc.Print()
    End Sub

    Private Sub OnPrintPage(sender As Object, e As PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim fontRegular As New Font("Arial", 10)
        Dim fontBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fontBlue As New Font("Arial", 10, FontStyle.Regular)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim blackBrush As New SolidBrush(Color.Black)
        Dim grayPen As New Pen(Color.Gray, 1)

        Dim paperWidth As Integer = 215 '80mm paper width in pixels
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim offset As Integer = 20

        ' Print company logo centered
        If Not String.IsNullOrEmpty(receiptData.CompanyLogoPath) AndAlso IO.File.Exists(receiptData.CompanyLogoPath) Then
            Dim logo As Image = Image.FromFile(receiptData.CompanyLogoPath)
            Dim logoWidth As Integer = 140
            Dim logoHeight As Integer = 100
            Dim logoX As Integer = (paperWidth - logoWidth) / 2
            graphics.DrawImage(logo, logoX, startY, logoWidth, logoHeight)
            offset += 80
        End If

        ' Print header centered
        Dim header As String = $"{receiptData.CompanyName}{vbCrLf}TAX INVOICE{vbCrLf}Tel: {receiptData.Tel}{vbCrLf}CUSTOMER REF.: {receiptData.SalesOpenNo}{vbCrLf}DEVICE ID: {receiptData.TIN}{vbCrLf}FISCAL DAY: {receiptData.VATNo}"
        Dim headerSize As SizeF = graphics.MeasureString(header, fontBold)
        Dim headerX As Integer = (paperWidth - headerSize.Width) / 2
        graphics.DrawString(header, fontBold, blackBrush, headerX, startY + offset)
        offset += fontBold.GetHeight(graphics) * 6

        ' Print sub-header
        Dim subHeader As String = $"Invoice No.: {receiptData.InvoiceNo}{vbCrLf}Invoice Date: {receiptData.InvoiceDate}{vbCrLf}Cashier Name: {receiptData.CashierName}{vbCrLf}Customer Name: {receiptData.CustomerName}{vbCrLf}Trade Name: {receiptData.CompanyName}{vbCrLf}Buyer TIN: {receiptData.TIN}{vbCrLf}Buyer VAT: {receiptData.VATNo}{vbCrLf}Address: {receiptData.Customeraddress}{vbCrLf}Contact No.: {receiptData.Tel}"
        graphics.DrawString(subHeader, fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics) * 9

        ' Draw horizontal line
        graphics.DrawLine(Pens.Black, startX, startY + offset, startX + 250, startY + offset)
        offset += 10

        ' Print item description header
        graphics.DrawString("Item Description", fontBlue, blueBrush, startX, startY + offset)
        offset += fontBlue.GetHeight(graphics)

        ' Print details with added space and gray line separation
        For Each detail As ReceiptDetail In receiptData.Details
            graphics.DrawString(detail.ProductName, fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics) + 2 ' Added space
            Dim detailText As String = $"{detail.Qty}   {detail.Price:F2}   {detail.Amount:F2}"
            graphics.DrawString(detailText, fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics) + 5 ' Added space

            ' Draw gray line separator
            graphics.DrawLine(grayPen, startX, startY + offset, startX + 250, startY + offset)
            offset += 2
        Next

        ' Print additional information
        offset += 10
        graphics.DrawString($"Items: {receiptData.Details.Count}", fontRegular, blackBrush, startX, startY + offset)
        graphics.DrawString($"Qty: {receiptData.Details.Sum(Function(d) d.Qty)}", fontRegular, blackBrush, startX + 120, startY + offset)
        offset += fontRegular.GetHeight(graphics)

        ' Draw blue line
        graphics.DrawLine(New Pen(blueBrush, 2), startX, startY + offset, startX + 250, startY + offset)
        offset += 10

        ' Print totals and payment info
        graphics.DrawString($"Sub Total: {receiptData.TotalSummary}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)
        graphics.DrawString($"Total Inclu.: {receiptData.TotalSummary}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)
        graphics.DrawString($"Amount Tendered: {receiptData.AmountTendered}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)
        graphics.DrawString($"Change: {receiptData.Change}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)

        ' Print currency if not null
        If Not String.IsNullOrEmpty(receiptData.Currency) Then
            graphics.DrawString($"Currency: {receiptData.Currency}", fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics) * 2
        End If

        ' Draw horizontal line
        graphics.DrawLine(Pens.Black, startX, startY + offset, startX + 250, startY + offset)
        offset += 10

        ' Print multi-currency details if available
        If receiptData.MultiCurrencyDetails IsNot Nothing AndAlso receiptData.MultiCurrencyDetails.Count > 0 Then
            graphics.DrawString("Multi Currency Details", fontBold, blackBrush, startX, startY + offset)
            offset += fontBold.GetHeight(graphics)
            graphics.DrawString("CURRENCY    AMOUNT", fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics)
            For Each mcDetail As KeyValuePair(Of String, Decimal) In receiptData.MultiCurrencyDetails
                graphics.DrawString($"{mcDetail.Key}       {mcDetail.Value:F2}", fontRegular, blackBrush, startX, startY + offset)
                offset += fontRegular.GetHeight(graphics)
            Next
            offset += fontRegular.GetHeight(graphics)
        End If

        ' Print QR code if not null and centered
        If Not String.IsNullOrEmpty(receiptData.QRCodePath) AndAlso IO.File.Exists(receiptData.QRCodePath) Then
            Dim qrCode As Image = Image.FromFile(receiptData.QRCodePath)
            Dim qrCodeWidth As Integer = 100
            Dim qrCodeHeight As Integer = 100
            Dim qrCodeX As Integer = (paperWidth - qrCodeWidth) / 2
            graphics.DrawImage(qrCode, qrCodeX, startY + offset, qrCodeWidth, qrCodeHeight)
            offset += 110 ' Space for QR code
        End If

        ' Print footer
        Dim footer As String = $"Verification Code:{vbCrLf}{receiptData.Footer}{vbCrLf}You can verify this receipt manually at {vbCrLf} https://fdmstest.zimra.co.zw/{vbCrLf}Havano Point of Sale v11{vbCrLf} Thanks....Visit Again!{vbCrLf}Havano Point of sales"
        graphics.DrawString(footer, fontRegular, blackBrush, startX, startY + offset)
    End Sub



    Private Sub OnPrintPagewithoutline(sender As Object, e As PrintPageEventArgs)
        Dim graphics As Graphics = e.Graphics
        Dim fontRegular As New Font("Arial", 10)
        Dim fontBold As New Font("Arial", 10, FontStyle.Bold)
        Dim fontBlue As New Font("Arial", 10, FontStyle.Regular)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim blackBrush As New SolidBrush(Color.Black)

        Dim paperWidth As Integer = 215 '315 ' 80mm paper width in pixels
        Dim startX As Integer = 10
        Dim startY As Integer = 10
        Dim offset As Integer = 20

        ' Print company logo centered
        If Not String.IsNullOrEmpty(receiptData.CompanyLogoPath) AndAlso IO.File.Exists(receiptData.CompanyLogoPath) Then
            Dim logo As Image = Image.FromFile(receiptData.CompanyLogoPath)
            Dim logoWidth As Integer = 140
            Dim logoHeight As Integer = 100
            Dim logoX As Integer = (paperWidth - logoWidth) / 2
            graphics.DrawImage(logo, logoX, startY, logoWidth, logoHeight)
            offset += 80
        End If

        ' Print header centered
        Dim header As String = $"{receiptData.CompanyName}{vbCrLf}TAX INVOICE{vbCrLf}Tel: {receiptData.Tel}{vbCrLf}CUSTOMER REF.: {receiptData.SalesOpenNo}{vbCrLf}DEVICE ID: {receiptData.TIN}{vbCrLf}FISCAL DAY: {receiptData.VATNo}"
        Dim headerSize As SizeF = graphics.MeasureString(header, fontBold)
        Dim headerX As Integer = (paperWidth - headerSize.Width) / 2
        graphics.DrawString(header, fontBold, blackBrush, headerX, startY + offset)
        offset += fontBold.GetHeight(graphics) * 6

        ' Print sub-header
        Dim subHeader As String = $"Invoice No.: {receiptData.InvoiceNo}{vbCrLf}Invoice Date: {receiptData.InvoiceDate}{vbCrLf}Cashier Name: {receiptData.CashierName}{vbCrLf}Customer Name: {receiptData.CustomerName}{vbCrLf}Trade Name: {receiptData.CompanyName}{vbCrLf}Buyer TIN: {receiptData.TIN}{vbCrLf}Buyer VAT: {receiptData.VATNo}{vbCrLf}Address: {receiptData.Customeraddress}{vbCrLf}Contact No.: {receiptData.Tel}"
        graphics.DrawString(subHeader, fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics) * 9

        ' Draw horizontal line
        graphics.DrawLine(Pens.Black, startX, startY + offset, startX + 250, startY + offset)
        offset += 10

        ' Print item description header
        graphics.DrawString("Item Description", fontBlue, blueBrush, startX, startY + offset)
        offset += fontBlue.GetHeight(graphics)

        ' Print details with added space
        For Each detail As ReceiptDetail In receiptData.Details
            graphics.DrawString(detail.ProductName, fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics) + 2 ' Added space
            Dim detailText As String = $"{detail.Qty}   {detail.Price:F2}   {detail.Amount:F2}"
            graphics.DrawString(detailText, fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics) + 5 ' Added space
        Next

        ' Print additional information
        offset += 10
        graphics.DrawString($"Items: {receiptData.Details.Count}", fontRegular, blackBrush, startX, startY + offset)
        graphics.DrawString($"Qty: {receiptData.Details.Sum(Function(d) d.Qty)}", fontRegular, blackBrush, startX + 120, startY + offset)
        offset += fontRegular.GetHeight(graphics)

        ' Draw blue line
        graphics.DrawLine(New Pen(blueBrush, 2), startX, startY + offset, startX + 250, startY + offset)
        offset += 10

        ' Print totals and payment info
        graphics.DrawString($"Sub Total: {receiptData.TotalSummary}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)
        graphics.DrawString($"Total Inclu.: {receiptData.TotalSummary}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)
        graphics.DrawString($"Amount Tendered: {receiptData.AmountTendered}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)
        graphics.DrawString($"Change: {receiptData.Change}", fontRegular, blackBrush, startX, startY + offset)
        offset += fontRegular.GetHeight(graphics)

        ' Print currency if not null
        If Not String.IsNullOrEmpty(receiptData.Currency) Then
            graphics.DrawString($"Currency: {receiptData.Currency}", fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics) * 2
        End If

        ' Draw horizontal line
        graphics.DrawLine(Pens.Black, startX, startY + offset, startX + 250, startY + offset)
        offset += 10

        ' Print multi-currency details if available
        If receiptData.MultiCurrencyDetails IsNot Nothing AndAlso receiptData.MultiCurrencyDetails.Count > 0 Then
            graphics.DrawString("Multi Currency Details", fontBold, blackBrush, startX, startY + offset)
            offset += fontBold.GetHeight(graphics)
            graphics.DrawString("CURRENCY    AMOUNT", fontRegular, blackBrush, startX, startY + offset)
            offset += fontRegular.GetHeight(graphics)
            For Each mcDetail As KeyValuePair(Of String, Decimal) In receiptData.MultiCurrencyDetails
                graphics.DrawString($"{mcDetail.Key}       {mcDetail.Value:F2}", fontRegular, blackBrush, startX, startY + offset)
                offset += fontRegular.GetHeight(graphics)
            Next
            offset += fontRegular.GetHeight(graphics)
        End If

        ' Print QR code if not null and centered
        If Not String.IsNullOrEmpty(receiptData.QRCodePath) AndAlso IO.File.Exists(receiptData.QRCodePath) Then
            Dim qrCode As Image = Image.FromFile(receiptData.QRCodePath)
            Dim qrCodeWidth As Integer = 100
            Dim qrCodeHeight As Integer = 100
            Dim qrCodeX As Integer = (paperWidth - qrCodeWidth) / 2
            graphics.DrawImage(qrCode, qrCodeX, startY + offset, qrCodeWidth, qrCodeHeight)
            offset += 110 ' Space for QR code
        End If

        ' Print footer
        Dim footer As String = $"Verification Code:{vbCrLf}{receiptData.Footer}{vbCrLf}You can verify this receipt manually at {vbCrLf} https://fdmstest.zimra.co.zw/{vbCrLf}Havano Point of Sale v11{vbCrLf} Thanks....Visit Again!{vbCrLf}Havano Point of sales"
        graphics.DrawString(footer, fontRegular, blackBrush, startX, startY + offset)
    End Sub

End Class
