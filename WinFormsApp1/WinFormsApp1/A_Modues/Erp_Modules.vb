Imports System.Data.Entity.Core
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Controls
Imports System.Windows.Forms.DataVisualization.Charting
Imports Newtonsoft.Json
Imports System.IO
Imports System.Text.RegularExpressions
Imports RevmaxAPI
Imports System.ComponentModel.Design

Module Erp_Modules
    Public companyInfo As Company = getOrgName()
    Public apiSecret As String '= "6110aa808c9ddd3"
    Public apikey As String ' = "4c88387ea9131dd"
    Public baseUrl As String '= baseurl
    Public erpstatus As Boolean = False
    Public Function GetInvoiceCount() As Integer
        Dim count As Integer = 0
        Using con As New SqlConnection("YourConnectionStringHere")
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM Invoice_info WHERE erp = 0"
            Using cmd As New SqlCommand(query, con)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
        Return count
    End Function
    Public Function ReadApiCredentials()
        companyInfo = getOrgName()
        '  Dim filePath As String = System.IO.Path.Combine(Application.StartupPath, "ERP_API.txt")
        Dim filePath As String = Path.Combine(Application.StartupPath, "ERP_API.txt")
        If Not System.IO.File.Exists(filePath) Then
            erpstatus = False
            '   MsgBox("Not exist")
            Return 0
        Else
            erpstatus = True
        End If
        Dim lines As String() = System.IO.File.ReadAllLines(filePath)
        apikey = lines(3).Trim()
        apiSecret = lines(1).Trim()
        baseUrl = lines(4).Trim()
        'MsgBox("Succededd")
        Return erpstatus
    End Function




    Public Async Function AddUomAsync(uomName As String) As Task
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return
        End If
        Dim cookieContainer As New CookieContainer()
        cookieContainer.Add(New Uri(baseUrl), New Cookie("full_name", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("sid", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("system_user", "no"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_id", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_image", ""))

        Dim handler As New HttpClientHandler() With {
            .CookieContainer = cookieContainer
        }

        Using client As New HttpClient(handler)
            ' Add the authorization header with the token
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authValue)

            ' Create the UOM data object
            Dim uomData As New With {
                .uom_name = uomName
            }

            ' Serialize the UOM data to JSON
            Dim json As String = JsonConvert.SerializeObject(uomData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            ' Send the POST request to the API
            Dim response As HttpResponseMessage = Await client.PostAsync($"{baseUrl}/api/resource/UOM", content)

            ' Check if the response is successful
            If response.IsSuccessStatusCode Then
                '  MsgBox($"Successfully added UOM: {uomName}")
            Else
                ' Show an error message if the request failed
                'MsgBox($"Failed to add UOM: {Await response.Content.ReadAsStringAsync()}")
            End If
        End Using
    End Function
    Public Async Function AddItemGroupAsync(itemGroupName As String) As Task
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return
        End If
        Dim cookieContainer As New CookieContainer()
        cookieContainer.Add(New Uri(baseUrl), New Cookie("full_name", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("sid", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("system_user", "no"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_id", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_image", ""))

        Dim handler As New HttpClientHandler() With {
        .CookieContainer = cookieContainer
    }

        Using client As New HttpClient(handler)
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authValue)
            ' Create the item group data object
            Dim itemGroupData As New With {
            .item_group_name = itemGroupName
        }
            Dim json As String = JsonConvert.SerializeObject(itemGroupData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync($"{baseUrl}/api/resource/Item Group", content)
            ' Check if the response is successful
            If response.IsSuccessStatusCode Then
                ' MessageBox.Show("Item group added successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                '  MsgBox($"Failed to add item group ERP: {Await response.Content.ReadAsStringAsync()}")
            End If
        End Using
    End Function


    Private Function GeneratenewpID() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 PID FROM Product ORDER BY PID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("PID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Public Function GetAllItemsAndCategories() As List(Of String)
        ReadApiCredentials()
        Try
            If Not IsInternetAvailable() OrElse Not erpstatus Then
                Return New List(Of String)()
            End If

            Dim items As New List(Of String)()
            Dim categories As New List(Of String)()

            ' Set up the cookie container and handler
            Dim cookieContainer As New CookieContainer()
            cookieContainer.Add(New Uri(baseUrl), New Cookie("full_name", "Guest"))
            cookieContainer.Add(New Uri(baseUrl), New Cookie("sid", "Guest"))
            cookieContainer.Add(New Uri(baseUrl), New Cookie("system_user", "no"))
            cookieContainer.Add(New Uri(baseUrl), New Cookie("user_id", "Guest"))
            cookieContainer.Add(New Uri(baseUrl), New Cookie("user_image", ""))

            Dim handler As New HttpClientHandler() With {
        .CookieContainer = cookieContainer
    }

            Using client As New HttpClient(handler)
                ' Set up the authentication header
                Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", authValue)



                Dim categoryResponse As HttpResponseMessage = client.GetAsync($"{baseUrl}/api/resource/Item Group").Result
                Dim categoryResponseData As String = categoryResponse.Content.ReadAsStringAsync().Result
                If categoryResponse.IsSuccessStatusCode Then
                    ' Deserialize the response data
                    Dim categoryJsonResponse = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(categoryResponseData)
                    Dim categoryDataArray = CType(categoryJsonResponse("data"), IEnumerable(Of Object))

                    Using conn As New SqlConnection(cs)
                        conn.Open()

                        ' Process each category from the response
                        For Each category In categoryDataArray
                            Dim categoryName = category("name").ToString()

                            ' Prepare the SQL query to insert category if it does not exist
                            Dim categoryQuery As String = "IF NOT EXISTS (SELECT 1 FROM Category WHERE CategoryName = @CategoryName)
                                                   INSERT INTO Category (CategoryName) VALUES (@CategoryName)"

                            ' Prepare the SQL command and parameters
                            Using categoryCmd As New SqlCommand(categoryQuery, conn)
                                categoryCmd.Parameters.AddWithValue("@CategoryName", categoryName)
                                categoryCmd.ExecuteNonQuery()
                            End Using

                            categories.Add(categoryName)
                        Next
                    End Using
                Else
                    ' Show an error message if the request failed
                    MsgBox($"Failed to fetch categories: {categoryResponseData}")
                End If





                ' Fetch items
                Dim itemResponse As HttpResponseMessage = client.GetAsync($"{baseUrl}/api/method/pos_api.api.get_items").Result
                Dim itemResponseData As String = itemResponse.Content.ReadAsStringAsync().Result

                If itemResponse.IsSuccessStatusCode Then
                    ' Deserialize the response data
                    Dim itemJsonResponse = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(itemResponseData)
                    Dim itemDataArray = CType(itemJsonResponse("message"), IEnumerable(Of Object))

                    Using conn As New SqlConnection(cs)
                        conn.Open()

                        ' Process each item from the response
                        For Each item In itemDataArray
                            Dim itemCode = item("name").ToString()
                            Dim itemName = item("item_name").ToString()
                            Dim description = item("description").ToString()
                            Dim itemGroup = item("item_group").ToString()
                            Dim categoryQuery As String = "IF NOT EXISTS (SELECT 1 FROM Category WHERE CategoryName = @CategoryName)
                                                   INSERT INTO Category (CategoryName) VALUES (@CategoryName)"
                            Dim parameters As New List(Of SqlParameter)()
                            parameters.Add(New SqlParameter("@CategoryName", itemGroup))
                            Dim dt As DataTable = Crud(categoryQuery, parameters)

                            Dim stockUom = item("stock_uom").ToString()
                            Dim truncatedStockUom = If(stockUom.Length > 10, stockUom.Substring(0, 10), stockUom)
                            Dim valuationRate = Convert.ToDecimal(item("valuation_rate"))
                            Dim standardRate = Convert.ToDecimal(item("standard_rate"))
                            If standardRate = 0 Then
                                standardRate = valuationRate
                            End If
                            Dim pid As Integer

                            Dim numericPart As String = Regex.Replace(itemCode, "[^\d]", "")

                            If Integer.TryParse(numericPart, pid) = False Then
                                pid = 0
                            End If

                            If pid = 0 Then
                                pid = Val(GeneratenewpID)
                            End If
                            ' Prepare the SQL query to insert or update item
                            Dim query As String = "IF EXISTS (SELECT 1 FROM Product WHERE PID = @Pid or  ProductName= @ProductName )
                                           BEGIN
                                               UPDATE Product
                                               SET ProductCode = @ProductCode,
                                                   ProductName = @ProductName,
                                                   Description = @Description,
                                                   Category = @Category,
                                                   SalesUnit = @SalesUnit,
                                                   PurchaseUnit = @PurchaseUnit,
                                                   Barcode = @Barcode,
                                                   ReorderPoint = @ReorderPoint,
                                                   AddedDate = @AddedDate,
                                                   PurchaseCost = @PurchaseCost,
                                                   SalesCost = @SalesCost,
                                                   VATCommodity = @VATCommodity,
                                                   ShowPS = @ShowPS
                                               WHERE PID = @Pid or  ProductName= @ProductName  
                                           END
                                           ELSE
                                           BEGIN
                                               INSERT INTO Product (PID, ProductCode, ProductName, Description, Category, SalesUnit, PurchaseUnit, Barcode, ReorderPoint, AddedDate, PurchaseCost, SalesCost, VATCommodity, ShowPS) 
                                               VALUES (@Pid, @ProductCode, @ProductName, @Description, @Category, @SalesUnit, @PurchaseUnit, @Barcode, @ReorderPoint, @AddedDate, @PurchaseCost, @SalesCost, @VATCommodity, @ShowPS)
                                           END"

                            ' Prepare the SQL command and parameters
                            Using cmd As New SqlCommand(query, conn)
                                cmd.Parameters.AddWithValue("@ProductCode", itemCode)
                                cmd.Parameters.AddWithValue("@ProductName", itemName)
                                cmd.Parameters.AddWithValue("@Description", description)
                                cmd.Parameters.AddWithValue("@Category", itemGroup)
                                cmd.Parameters.AddWithValue("@SalesUnit", truncatedStockUom)
                                cmd.Parameters.AddWithValue("@PurchaseUnit", truncatedStockUom)
                                cmd.Parameters.AddWithValue("@Barcode", itemCode)
                                cmd.Parameters.AddWithValue("@ReorderPoint", 1)
                                cmd.Parameters.AddWithValue("@AddedDate", DateTime.Now)
                                cmd.Parameters.AddWithValue("@PurchaseCost", valuationRate)
                                cmd.Parameters.AddWithValue("@SalesCost", standardRate)
                                cmd.Parameters.AddWithValue("@VATCommodity", "VAT") 'ShowPS
                                cmd.Parameters.AddWithValue("@ShowPS", "Yes") 'ShowPS
                                cmd.Parameters.AddWithValue("@Pid", pid) 'ShowPS
                                cmd.ExecuteNonQuery()
                            End Using

                            Try

                                ' Prepare the SQL query to insert or update into Temp_Stock_Company
                                Dim cb3 As String = "IF EXISTS (SELECT 1 FROM Temp_Stock_Company WHERE ProductID = @Pid)
                                         BEGIN
                                             UPDATE Temp_Stock_Company
                                             SET Qty = @Qty,
                                                 ManufacturingDate = @ManufacturingDate,
                                                 ExpiryDate = @ExpiryDate,
                                                 SalesRate = @SalesRate,
                                                 PurchaseRate = @PurchaseRate,
                                                 Barcode = @Barcode
                                             WHERE ProductID = @Pid
                                         END
                                         ELSE
                                         BEGIN
                                             INSERT INTO Temp_Stock_Company (ProductID, Qty, ManufacturingDate, ExpiryDate, SalesRate, PurchaseRate, Barcode) 
                                             VALUES (@Pid, @Qty, @ManufacturingDate, @ExpiryDate, @SalesRate, @PurchaseRate, @Barcode)
                                         END"

                                Using tempCmd As New SqlCommand(cb3, conn)
                                    tempCmd.Parameters.AddWithValue("@Pid", pid)
                                    tempCmd.Parameters.AddWithValue("@Qty", 0)
                                    tempCmd.Parameters.AddWithValue("@ManufacturingDate", DateTime.Now)
                                    tempCmd.Parameters.AddWithValue("@ExpiryDate", DBNull.Value)
                                    tempCmd.Parameters.AddWithValue("@SalesRate", standardRate)
                                    tempCmd.Parameters.AddWithValue("@PurchaseRate", valuationRate)
                                    tempCmd.Parameters.AddWithValue("@Barcode", itemCode)
                                    tempCmd.ExecuteNonQuery()
                                End Using
                            Catch ex As Exception

                            End Try
                            items.Add(itemCode)
                        Next
                    End Using
                Else
                    ' Show an error message if the request failed
                    'MsgBox($"Failed to fetch items: {itemResponseData}")
                End If
            End Using

            Return items.Concat(categories).ToList()
        Catch ex As Exception

        End Try
    End Function


    Public Function IsInternetAvailable() As Boolean
        If My.Computer.Network.IsAvailable Then
            Try
                Using ping As New Ping()
                    Dim reply As PingReply = ping.Send("www.google.com")
                    If reply.Status = IPStatus.Success Then
                        Return True
                    End If
                End Using
            Catch ex As Exception
                Return False
            End Try
        End If
        Return False
    End Function

    Public Async Function AddProductAsync(productDataJson As String) As Task
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return
        End If
        Dim content As New StringContent(productDataJson, Encoding.UTF8, "application/json")
        Using client As New HttpClient()
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", authValue)
            Dim response As HttpResponseMessage = Await client.PostAsync($"{baseUrl}/api/resource/Item", content)
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            '   MsgBox(responseData)
            If response.IsSuccessStatusCode Then
                'MessageBox.Show("Product added successfully.")
            Else
                '  MessageBox.Show($"Failed to add product: {responseData}")
            End If
        End Using
    End Function


    Public Async Function updateProductAsync(productDataJson As String, barcode As String) As Task
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return
        End If
        Dim content As New StringContent(productDataJson, Encoding.UTF8, "application/json")
        Using client As New HttpClient()
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", authValue)
            Dim response As HttpResponseMessage = Await client.PutAsync($"{baseUrl}/api/resource/Item/{barcode}", content)
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            '   MsgBox(responseData)
            If response.IsSuccessStatusCode Then
                ' MessageBox.Show("Product Updated successfully.")
            Else
                ' MessageBox.Show($"Failed to update product on ERP: {responseData}")
            End If
        End Using
    End Function
    Public Async Function AddCurrencyAsync(currencyDataJson As String) As Task
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return
        End If
        Dim content As New StringContent(currencyDataJson, Encoding.UTF8, "application/json")
        Using client As New HttpClient()
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", authValue)
            Dim response As HttpResponseMessage = Await client.PostAsync($"{baseUrl}/api/method/pos_api.api.add_currency", content)
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            If response.IsSuccessStatusCode Then
                '   MessageBox.Show("Currency added successfully.")
            Else
                '  MessageBox.Show($"Failed to add currency: {responseData}")
            End If
        End Using
    End Function
    Public Async Function updateCurrencyAsync(currencyDataJson As String, currency As String) As Task
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return
        End If
        Dim content As New StringContent(currencyDataJson, Encoding.UTF8, "application/json")
        Using client As New HttpClient()
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", authValue)
            Dim response As HttpResponseMessage = Await client.PutAsync($"{baseUrl}/api/resource/Currency/{currency}", content)
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            If response.IsSuccessStatusCode Then
                '   MessageBox.Show("Currency added successfully.")
            Else
                '  MessageBox.Show($"Failed to add currency: {responseData}")
            End If
        End Using
    End Function
    Public Async Function GenerateTokenAsync() As Task(Of String)
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return 0
        End If
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("https://pos.alphazentechnologies.com/api/method/frappe.core.doctype.user.user.generate_keys?user=""user""")
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Return responseBody
        End Using
    End Function


    Function GetCurrencyRate(currencyCode As String) As Double
        Dim query As String = "SELECT Rate FROM Currency WHERE currencycode = @currencycode"
        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@currencycode", currencyCode))
        Dim dt As DataTable = FetchInvoiceData(query, parameters)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            If Val(dt.Rows(0)("Rate")) > 0 Then
                Return Convert.ToDouble(dt.Rows(0)("Rate"))
            Else
                Return 1
            End If
        Else
            Return 1
        End If
    End Function




    Public Async Function MakePaymentAsync(paymentType As String, partyType As String, party As String, postingDate As String, modeOfPayment As String,
                                           paidFrom As String, paidFromAccountType As String, paidFromAccountCurrency As String, paidTo As String, paidToAccountType As String,
                                           paidToAccountCurrency As String, receivedAmount As Decimal, targetExchangeRate As Decimal, referenceName As String) As Task
        Try
            Dim paymentDataJson As String = "{
            ""payment_type"": """ & paymentType & """,
            ""party_type"": """ & partyType & """,
            ""party"": """ & party & """,
            ""company"": """ & companyInfo.CompanyName & """,
            ""posting_date"": """ & postingDate & """,
            ""mode_of_payment"": """ & modeOfPayment & """,
            ""paid_from"": """ & paidFrom & """,
            ""paid_from_account_type"": """ & paidFromAccountType & """,
            ""paid_from_account_currency"": """ & paidFromAccountCurrency & """,
            ""paid_to"": """ & paidTo & """,
            ""paid_to_account_type"": """ & paidToAccountType & """,
            ""paid_to_account_currency"": """ & paidToAccountCurrency & """,
            ""received_amount"": " & receivedAmount & ",
            ""target_exchange_rate"": " & targetExchangeRate & ",
            ""reference_name"": """ & referenceName & """
        }"
            Dim content As New StringContent(paymentDataJson, Encoding.UTF8, "application/json")
            Using client As New HttpClient()
                Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", authValue)

                Dim response As HttpResponseMessage = Await client.PostAsync($"{baseUrl}/api/method/pos_api.api.make_payment", content)
                Dim responseData As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    '        MessageBox.Show("Payment made successfully.")
                Else
                    '       MessageBox.Show($"Failed to make payment: {responseData}")
                End If
            End Using
        Catch ex As Exception
            ' MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Function
    Public Async Function allproductINcluded() As Task(Of Integer)
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return 0
        End If
        Dim query1 As String = "SELECT CategoryName FROM category"
        Dim parameters1 As New List(Of SqlParameter)()
        dt = New DataTable
        dt = FetchInvoiceData(query1, parameters1)
        For Each row1 As DataRow In dt.Rows
            Await AddItemGroupAsync(row1(0).ToString().Trim())
        Next


        query1 = "select barcode, productname, product.category, salescost FROM product"
        parameters1 = New List(Of SqlParameter)()
        Dim dt1 = New DataTable
        dt1 = FetchInvoiceData(query1, parameters1)
        For Each row As DataRow In dt1.Rows
            Dim itemCode As String = row(0).ToString().Trim()
            Dim itemName As String = row(1).ToString().Trim()
            Dim itemGroup As String = row(2).ToString().Trim()
            Await AddUomAsync(itemName)
            Dim stockUOM As String = itemName
            Dim valuationRate As Decimal = Convert.ToDecimal(row(3))
            Dim productDataJson As String = "{
            ""item_code"": """ & itemCode & """,
            ""item_name"": """ & itemName & """,
            ""item_group"": """ & itemGroup & """,
            ""stock_uom"": """ & stockUOM & """,
            ""valuation_rate"": " & valuationRate & "
        }"

            ' Add the product
            Await AddProductAsync(productDataJson)

            ' Update the product
            Await updateProductAsync(productDataJson, itemCode)
        Next

        Return 0
    End Function



    Public Async Function ProcessSalesReturnsAsync() As Task
        ReadApiCredentials()

        If IsInternetAvailable() = False Or erpstatus = False Then
            Return
        End If
        Dim cookieContainer As New CookieContainer()
        cookieContainer.Add(New Uri(baseUrl), New Cookie("full_name", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("sid", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("system_user", "no"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_id", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_image", ""))
        Dim handler As New HttpClientHandler() With {
        .CookieContainer = cookieContainer
    }
        ' Create the HttpClient with the handler
        Using client As New HttpClient(handler)
            ' Add the authorization header with the token
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authValue)
            ' Open a new SQL connection
            Using conn As New SqlConnection(cs)
                Await conn.OpenAsync()
                ' Query to select sales returns that have not been processed (erp = 0 or NULL)
                Dim salesReturnsQuery As String = "SELECT * FROM SalesReturn WHERE erp = 0 OR erp IS NULL"
                Dim salesReturnsCmd As New SqlCommand(salesReturnsQuery, conn)

                ' Execute the sales returns query
                Using salesReturns As SqlDataReader = Await salesReturnsCmd.ExecuteReaderAsync()
                    ' Loop through each sales return
                    While Await salesReturns.ReadAsync()
                        ' Extract sales return details
                        Dim srId As Integer = Convert.ToInt32(salesReturns("SR_ID"))
                        Dim query1 = "select cname,currencycode from invoiceinfo where inv_id=@srid"
                        Dim parameters1 As New List(Of SqlParameter)()
                        parameters1.Add(New SqlParameter("@srid", srId))
                        dt = New DataTable
                        dt = FetchInvoiceData(query1, parameters1)
                        Dim customer As String = dt(0)(0)
                        Dim company As String = companyInfo.CompanyName
                        Dim currency As String = dt(0)(1).ToString().Trim()
                        Dim postingDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                        Dim dueDate As String = Convert.ToDateTime(salesReturns("Date")).ToString("yyyy-MM-dd")
                        Dim warehouse As String = "Finished Goods - PDD"
                        Dim updateStock As Integer = 1
                        Dim conversionRate As Double = 1.0
                        Dim returnAgainst As String = salesReturns("SalesID").ToString().Trim()
                        ' Query to select the items for the current sales return
                        Dim itemsQuery As String = "SELECT * FROM SalesReturn_Join WHERE SalesReturnID = @SalesReturnID"
                        Dim itemsCmd As New SqlCommand(itemsQuery, conn)
                        itemsCmd.Parameters.AddWithValue("@SalesReturnID", srId)

                        ' Create a list to hold the sales return items
                        Dim salesReturnItems As New List(Of Object)()
                        Using items As SqlDataReader = Await itemsCmd.ExecuteReaderAsync()
                            ' Loop through each item
                            While Await items.ReadAsync()
                                Dim productId As Integer = Val(items("ProductID").ToString())
                                Dim query As String = "SELECT ProductName FROM Product WHERE PID=@PID"
                                Dim parameters As New List(Of SqlParameter)()
                                parameters.Add(New SqlParameter("@PID", productId))
                                Dim dt As DataTable = FetchInvoiceData(query, parameters)
                                salesReturnItems.Add(New With {
                               .item_code = items("Barcode").ToString().Trim(),
                                .item_name = dt(0)(0).ToString().Trim(),
                                .qty = Convert.ToInt32(items("ReturnQty")),
                                .rate = Convert.ToDouble(items("SalesCost"))
                            })
                            End While
                        End Using

                        ' Create the sales return data object
                        Dim salesReturnData As New With {
                        .selling_price_list = "Standard Selling",
                        .price_list_currency = currency,
                        .plc_conversion_rate = 1,
                        .customer = customer,
                        .company = company,
                        .currency = currency,
                        .posting_date = postingDate,
                        .due_date = dueDate,
                        .set_warehouse = warehouse,
                        .update_stock = updateStock,
                        .conversion_rate = GetCurrencyRate(currency),'conversionRate
                        .is_return = 1,
                        .return_against = returnAgainst,
                        .items = salesReturnItems
                    }
                        ' Serialize the sales return data to JSON
                        Dim json As String = JsonConvert.SerializeObject(salesReturnData)
                        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

                        Dim response As HttpResponseMessage = Await client.PostAsync($"{baseUrl}/api/method/pos_api.api.make_sales_invoice", content)

                        ' Read the response content as a string
                        Dim responseData As String = Await response.Content.ReadAsStringAsync()
                        If response.IsSuccessStatusCode Then
                            ' Update the sales return status in the database
                            Dim updateQuery As String = "UPDATE SalesReturn SET erp = 1 WHERE SR_ID = @SR_ID"
                            Dim updateCmd As New SqlCommand(updateQuery, conn)
                            updateCmd.Parameters.AddWithValue("@SR_ID", srId)
                            Await updateCmd.ExecuteNonQueryAsync()

                            ' Show a success message
                            'MsgBox("Sales return posted successfully.")
                        Else
                            ' Show an error message if the request failed
                            MsgBox($"Failed to post sales return {srId}: {responseData}")
                            Return
                        End If
                    End While
                End Using
            End Using
        End Using
    End Function
    Public Async Function ERMODULES_EXECUTION() As Task(Of Integer)
        ReadApiCredentials()
        If IsInternetAvailable() = False Or erpstatus = False Then
            Return 0
        End If
        Do
            Dim tasks As New List(Of Task)

            tasks.Add(Task.Run(AddressOf GetAllItemsAndCategories))
            ' tasks.Add(Task.Run(AddressOf allproductINcluded))
            tasks.Add(Task.Run(AddressOf ProcessInvoices))
            '    tasks.Add(Task.Run(AddressOf ProcessSalesReturnsAsync))
            tasks.Add(Task.Run(AddressOf SyncCustomers))
            '  
            Await Task.WhenAll(tasks)
            ' Delay for 20 seconds before restarting the loop  GetAllItemsAsync()
            Await Task.Delay(20000)
        Loop
        Return 0
    End Function



    Public Function DeleteApiCredentialsFile()
        ' Define the file path
        Dim filePath As String = Path.Combine(Application.StartupPath, "ERP_API.txt")
        If File.Exists(filePath) Then
            File.Delete(filePath)

        End If
        Return 0
    End Function

    Public Function Deletefirsttimerunning()
        ' Define the file path
        Dim filePath As String = Path.Combine(Application.StartupPath, "first_time_execution.dll")
        If File.Exists(filePath) Then
            File.Delete(filePath)
        End If
        Return 0
    End Function


    Public Async Function ProcessInvoices() As Task
        ReadApiCredentials()
        If Not IsInternetAvailable() OrElse Not erpstatus Then
            Return
        End If

        Dim cookieContainer As New CookieContainer()
        cookieContainer.Add(New Uri(baseUrl), New Cookie("full_name", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("sid", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("system_user", "no"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_id", "Guest"))
        cookieContainer.Add(New Uri(baseUrl), New Cookie("user_image", ""))
        Dim handler As New HttpClientHandler() With {
        .CookieContainer = cookieContainer
    }
        Using client As New HttpClient(handler)
            Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authValue)
            Using conn As New SqlConnection(cs)
                conn.Open()
                Dim invoicesQuery As String = "SELECT * FROM InvoiceInfo WHERE erp = 0 OR erp IS NULL"
                Dim invoicesCmd As New SqlCommand(invoicesQuery, conn)
                Using invoices As SqlDataReader = invoicesCmd.ExecuteReader()
                    While invoices.Read()
                        Dim invoiceId As Integer = Convert.ToInt32(invoices("Inv_ID"))
                        Dim customer As String = invoices("CName").ToString().Trim()
                        If customer.Length = 0 Then
                            customer = "Walk In"
                        End If
                        Dim GrandTotal As String = invoices("GrandTotal").ToString().Trim()
                        Dim taxtype As String = invoices("taxtype").ToString().Trim()
                        Dim company As String = companyInfo.CompanyName.ToString.Trim()
                        Dim currency As String = invoices("CurrencyCode").ToString().Trim()
                        Dim postingDate As String = DateTime.Now.ToString("yyyy-MM-dd")
                        Dim dueDate As String = Convert.ToDateTime(invoices("InvoiceDate")).AddDays(7).ToString("yyyy-MM-dd")
                        Dim warehouse As String = "Finished Goods - PDD"
                        Dim updateStock As Integer = 1
                        Dim conversionRate As Double = GetCurrencyRate(currency)

                        Dim itemsQuery As String = "SELECT * FROM Invoice_Product WHERE InvoiceID = @InvoiceID"
                        Dim itemsCmd As New SqlCommand(itemsQuery, conn)
                        itemsCmd.Parameters.AddWithValue("@InvoiceID", invoiceId)
                        Dim invoiceItems As New List(Of Object)()
                        Using items As SqlDataReader = itemsCmd.ExecuteReader()
                            While items.Read()
                                Dim productId As Integer = Convert.ToInt32(items("ProductID"))
                                Dim query As String = "SELECT ProductName FROM Product WHERE PID=@PID"
                                Dim parameters As New List(Of SqlParameter)()
                                parameters.Add(New SqlParameter("@PID", productId))
                                Dim dt As DataTable = FetchInvoiceData(query, parameters)
                                invoiceItems.Add(New With {
                                .item_code = items("Barcode").ToString().Trim(),
                                .item_name = dt(0)(0).ToString().Trim(),
                                .qty = Convert.ToInt32(items("Qty")),
                                .rate = Convert.ToDouble(items("SalesRate"))
                            })
                            End While
                        End Using

                        Dim invoiceData As New With {
                        .selling_price_list = "Standard Selling",
                        .price_list_currency = currency,
                        .plc_conversion_rate = 1,
                        .customer = customer,
                        .company = company,
                        .currency = currency,
                        .posting_date = postingDate,
                        .due_date = dueDate,
                        .set_warehouse = warehouse,
                        .update_stock = updateStock,
                        .conversion_rate = conversionRate,
                        .items = invoiceItems
                    }

                        Dim json As String = JsonConvert.SerializeObject(invoiceData)
                        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                        Dim response As HttpResponseMessage = client.PostAsync($"{baseUrl}/api/method/pos_api.api.make_sales_invoice", content).Result
                        Dim responseData As String = response.Content.ReadAsStringAsync().Result

                        If response.IsSuccessStatusCode Then
                            Dim jsonResponse = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseData)
                            Dim message = jsonResponse("message")
                            Dim REFNO As String = message("name").ToString()
                            Await MakePaymentAsync("Receive", "Customer", "Grant Plastics Ltd.", dueDate, "Cash", "Debtors - PDD", "Receivable", currency, "Cash - INR - PDD",
                                              "Cash", currency, Val(GrandTotal), Val(GetCurrencyRate(currency)), REFNO)
                        Else
                            MsgBox($"Failed to post invoice {invoiceId}: {responseData}")
                        End If
                        Dim updateQuery As String = "UPDATE InvoiceInfo SET erp = 1 WHERE Inv_ID = @Inv_ID"
                        Dim updateCmd As New SqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@Inv_ID", invoiceId)
                        updateCmd.ExecuteNonQuery()
                    End While
                End Using
            End Using
        End Using
        Return
    End Function



    Public Async Function SyncCustomers() As Task
        ' Read API credentials
        ReadApiCredentials()

        ' Get customers from the database
        Dim dbCustomers As List(Of DbCustomer) = GetCustomersFromDatabase()

        ' Get customers from the API
        Dim apiCustomers As List(Of ApiCustomer) = Await GetCustomersFromApi()

        ' Find missing customers in the API
        Dim missingInApi As List(Of DbCustomer) = dbCustomers.Where(Function(dbCust) Not apiCustomers.Any(Function(apiCust) apiCust.Name.Equals(dbCust.Name, StringComparison.OrdinalIgnoreCase))).ToList()

        ' Add missing customers to the API
        For Each customer In missingInApi
            Await AddCustomerToApi(customer)
        Next

        Dim missingInDb As List(Of ApiCustomer) = apiCustomers.Where(Function(apiCust) Not dbCustomers.Any(Function(dbCust) dbCust.Name.Equals(apiCust.customer_name, StringComparison.OrdinalIgnoreCase))).ToList()

        ' Add missing customers to the database
        For Each customer In missingInDb
            AddCustomerToDatabase(customer)
        Next
    End Function

    Private Function GetCustomersFromDatabase() As List(Of DbCustomer)
        Dim customers As New List(Of DbCustomer)
        Using con As New SqlConnection(cs)
            con.Open()
            Dim query As String = "SELECT CC_ID, RTRIM(Customerid) AS Customerid, RTRIM(Name) AS Name, RTRIM(Address) AS Address, RTRIM(ContactNo) AS ContactNo, RTRIM(TRN) AS TRN, RTRIM(RateType) AS RateType, RTRIM(Active) AS Active, RegistrationDate, Discount FROM Customer ORDER BY Name"
            Using cmd As New SqlCommand(query, con)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim customer As New DbCustomer With {
                        .Customerid = reader("Customerid").ToString(),
                        .Name = reader("Name").ToString(),
                        .Address = reader("Address").ToString(),
                        .ContactNo = reader("ContactNo").ToString(),
                        .TRN = reader("TRN").ToString(),
                        .RateType = reader("RateType").ToString(),
                        .Active = reader("Active").ToString(),
                        .RegistrationDate = Convert.ToDateTime(reader("RegistrationDate")),
                        .Discount = Convert.ToDecimal(reader("Discount"))
                    }
                        customers.Add(customer)
                    End While
                End Using
            End Using
        End Using
        Return customers
    End Function

    Private Async Function GetCustomersFromApi() As Task(Of List(Of ApiCustomer))
        Dim customers As New List(Of ApiCustomer)
        Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authValue)
            Dim response As HttpResponseMessage = Await client.GetAsync($"{baseUrl}/api/method/pos_api.api.get_customers")
            If response.IsSuccessStatusCode Then
                Dim responseData As String = Await response.Content.ReadAsStringAsync()
                Dim apiResponse = JsonConvert.DeserializeObject(Of ApiResponse)(responseData)
                customers = apiResponse.Message
            End If
        End Using
        Return customers
    End Function

    Private Async Function AddCustomerToApi(customer As DbCustomer) As Task
        Dim authValue As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{apikey}:{apiSecret}"))
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authValue)
            Dim customerData As New With {
            .customer_name = customer.Name,
            .customer_type = "Individual"
        }
            Dim json As String = JsonConvert.SerializeObject(customerData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync($"{baseUrl}/api/resource/Customer", content)
            If Not response.IsSuccessStatusCode Then
                Dim responseData As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show($"Failed to add customer {customer.Name} to API: {responseData}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Function

    Public Function GenerateID() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 CC_ID FROM Customer ORDER BY CC_ID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("CC_ID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then ' Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then ' Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then ' Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function

    Dim cids As String
    Dim cid As Integer
    Sub Auto()
        cid = GenerateID()
        cids = "C-" + GenerateID()
    End Sub

    Private Sub AddCustomerToDatabase(customer As ApiCustomer)
        Auto()
        Using con As New SqlConnection(cs)
            con.Open()
            Dim query As String = "INSERT INTO Customer (CC_ID, Customerid, Name, Address, ContactNo, TRN, RateType, Active, RegistrationDate, Discount) " &
                              "VALUES (@CC_ID, @Customerid, @Name, @Address, @ContactNo, @TRN, @RateType, @Active, @RegistrationDate, @Discount)"
            Using cmd As New SqlCommand(query, con)
                ' Check for null or empty values and provide defaults if necessary
                cmd.Parameters.AddWithValue("@CC_ID", If(String.IsNullOrEmpty(cid), GenerateID(), cid))
                cmd.Parameters.AddWithValue("@Customerid", If(String.IsNullOrEmpty(customer.Name), "Unknown", customer.Name))
                cmd.Parameters.AddWithValue("@Name", If(String.IsNullOrEmpty(customer.customer_name), "Unknown", customer.customer_name))
                cmd.Parameters.AddWithValue("@Address", String.Empty) ' Provide a default value or modify as needed
                cmd.Parameters.AddWithValue("@ContactNo", String.Empty) ' Provide a default value or modify as needed
                cmd.Parameters.AddWithValue("@TRN", String.Empty) ' Provide a default value or modify as needed
                cmd.Parameters.AddWithValue("@RateType", "Retail Cost") ' Provide a default value or modify as needed
                cmd.Parameters.AddWithValue("@Active", "Yes") ' Provide a default value or modify as needed
                cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Now) ' Use current date as default or modify as needed
                cmd.Parameters.AddWithValue("@Discount", 0) ' Provide a default value or modify as needed

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    ' Define classes to represent customers
    Public Class DbCustomer
        Public Property Customerid As String
        Public Property Name As String
        Public Property Address As String
        Public Property ContactNo As String
        Public Property TRN As String
        Public Property RateType As String
        Public Property Active As String
        Public Property RegistrationDate As DateTime
        Public Property Discount As Decimal
    End Class

    Public Class ApiCustomer
        Public Property Name As String
        Public Property customer_name As String
        Public Property CustomerGroup As String
        Public Property CustomerType As String
    End Class

    Public Class ApiResponse
        Public Property Message As List(Of ApiCustomer)
    End Class




End Module
