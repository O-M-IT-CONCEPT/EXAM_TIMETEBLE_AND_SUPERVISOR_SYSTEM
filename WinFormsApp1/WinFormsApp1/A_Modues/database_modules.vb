Imports System.Data.SqlClient
Imports System.Text
Imports System.Threading.Tasks
Imports Microsoft.Office.Interop.Excel

Module database_modules

    Public Sub EnsureErpFieldExists()
        Using conn As New SqlConnection(cs)
            conn.Open()

            ' Check and add 'erp' column in 'InvoiceInfo' table if not exists
            Dim checkInvoiceInfoQuery As String = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'InvoiceInfo') AND name = 'erp') " &
                                              "BEGIN ALTER TABLE InvoiceInfo ADD erp BIT DEFAULT 0 END"
            Using checkInvoiceInfoCmd As New SqlCommand(checkInvoiceInfoQuery, conn)
                checkInvoiceInfoCmd.ExecuteNonQuery()
            End Using

            ' Check and add 'erp' column in 'SalesReturn' table if not exists
            Dim checkSalesReturnQuery As String = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'SalesReturn') AND name = 'erp') " &
                                              "BEGIN ALTER TABLE SalesReturn ADD erp BIT DEFAULT 0 END"
            Using checkSalesReturnCmd As New SqlCommand(checkSalesReturnQuery, conn)
                checkSalesReturnCmd.ExecuteNonQuery()
            End Using

            ' Check and add 'Printername2' column in 'PosPrinterSetting' table if not exists
            Dim checkPosPrinterSettingQuery As String = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'PosPrinterSetting') AND name = 'Printername2') " &
                                                    "BEGIN ALTER TABLE PosPrinterSetting ADD Printername2 NVARCHAR(255) END"
            Using checkPosPrinterSettingCmd As New SqlCommand(checkPosPrinterSettingQuery, conn)
                checkPosPrinterSettingCmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Public Function Dispatchto_invoiceinfo() As Integer
        Using con As New SqlConnection(cs)
            con.Open()

            ' Query to check and add columns if they do not exist
            Dim checkAndAddColumnQuery As String = "
        IF NOT EXISTS (
            SELECT 1 
            FROM sys.columns 
            WHERE Name = N'dispatch' 
            AND Object_ID = Object_ID(N'Invoiceinfo')
        )
        BEGIN
            ALTER TABLE Invoiceinfo 
            ADD dispatch BIT NOT NULL DEFAULT 0
        END

        IF NOT EXISTS (
            SELECT 1 
            FROM sys.columns 
            WHERE Name = N'dispatchby' 
            AND Object_ID = Object_ID(N'Invoiceinfo')
        )
        BEGIN
            ALTER TABLE Invoiceinfo 
            ADD dispatchby NCHAR(255) NULL
        END"

            Using cmd As New SqlCommand(checkAndAddColumnQuery, con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return 0
    End Function

    Public Sub CreateBranchesTableIfNotExists()
        Using con As New SqlConnection(cs)
            con.Open()
            Dim checkTableQuery As String = "
            IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'branches')
            BEGIN
                CREATE TABLE [dbo].[branches] (
                    id INT IDENTITY(1,1) PRIMARY KEY,
                    BranchName CHAR(255)
                )
            END"

            Using cmd As New SqlCommand(checkTableQuery, con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AddPackQtyAndPackNameIfNotExists()
        Dim checkPackQtyQuery As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Purchase_Join' AND COLUMN_NAME = 'packqty'"
        Dim checkPackNameQuery As String = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Purchase_Join' AND COLUMN_NAME = 'packname'"
        Dim addPackQtyQuery As String = "ALTER TABLE Purchase_Join ADD packqty DECIMAL"
        Dim addPackNameQuery As String = "ALTER TABLE Purchase_Join ADD packname CHAR(255)"
        Using con As New SqlConnection(cs)
            con.Open()
            Dim packQtyExists As Boolean
            Using checkCmd As New SqlCommand(checkPackQtyQuery, con)
                packQtyExists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
            End Using
            If Not packQtyExists Then
                Using addCmd As New SqlCommand(addPackQtyQuery, con)
                    addCmd.ExecuteNonQuery()
                End Using
            End If
            Dim packNameExists As Boolean
            Using checkCmd As New SqlCommand(checkPackNameQuery, con)
                packNameExists = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
            End Using
            If Not packNameExists Then
                Using addCmd As New SqlCommand(addPackNameQuery, con)
                    addCmd.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub

    Function CreateBinTable() As Boolean
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Bin') " &
                          "BEGIN " &
                          "CREATE TABLE Bin (id INT IDENTITY(1,1) PRIMARY KEY, bin nchar(255), code nchar(255)) " &
                          "END"
        Try
            Using con As New SqlConnection(cs)
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Return True ' Table created successfully
                End Using
            End Using
        Catch ex As Exception
            ' MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function Stock_adjst_dated_columCheckAndAlterDateField()
        Dim query As String = "IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'stock_adjustment_card' AND COLUMN_NAME = 'dated' AND DATA_TYPE = 'date') " &
                          "BEGIN " &
                          "    ALTER TABLE stock_adjustment_card ALTER COLUMN dated datetime " &
                          "END"
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True ' Indicate success
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False ' Indicate failure
        End Try
    End Function

    Function first_time_login_sql()
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Registration' AND COLUMN_NAME = 'flogin') " &
                    "BEGIN " &
                    "    ALTER TABLE Registration ADD flogin BIT DEFAULT 1; " &
                    "END;"
        Try
            Using con As New SqlConnection(cs)
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Return True ' Field added successfully or already exists
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return False ' Failed to add or already exists
    End Function

    Function pos_uiinterface()
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Company' AND COLUMN_NAME = 'patchinter') " &
                    "BEGIN " &
                    "    ALTER TABLE Company ADD patchinter BIT  NULL DEFAULT ((1)); " &
                                      "END;"
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function


    Function alter_table_product_include_bin_ifnot() As Boolean
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'PRODUCT' AND COLUMN_NAME = 'bin')
                       BEGIN
                           ALTER TABLE PRODUCT
                           ADD bin INT
                       END"
        Try
            Using con As New SqlConnection(cs)
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function altertable_invoice_include_vat_name() As String
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CUSTOMER' AND COLUMN_NAME IN ('TradeName', 'TRN', 'VatNumber')) BEGIN ALTER TABLE CUSTOMER ADD TradeName VARCHAR(255), TRN VARCHAR(255), VatNumber VARCHAR(255) END"
        Dim resultMessage As String = ""
        Using con As New SqlConnection(cs)
            Try
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using
                resultMessage = "Operation successful."
            Catch ex As Exception
                resultMessage = "Error: " & ex.Message
            End Try
        End Using
        Return resultMessage
    End Function
    Function FieldExists(ByVal connection As SqlConnection, ByVal fieldName As String) As Boolean
        Dim query As String = $"SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Customer' AND COLUMN_NAME = '{fieldName}'"
        Using command As New SqlCommand(query, connection)
            Dim result As Object = command.ExecuteScalar()
            Return (result IsNot Nothing)
        End Using
    End Function
    Function CreateAdvanceSettingsTable() As Boolean
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Advance_settings') " &
                              "BEGIN " &
                              "CREATE TABLE Advance_settings (dmarkup FLOAT, phar BIT,dispatch BIT) " &
                              "END"
        Try
            Using con As New SqlConnection(cs)
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Return True ' Table created successfully
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function includefiled_Api_inovoiceid() As String
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'SalesReturn' AND COLUMN_NAME = 'API_ID')"
        query += " ALTER TABLE SalesReturn ADD API_ID NVARCHAR(36)"
        con = New SqlConnection(cs)
        Try
            con.Open()

            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            Return "Error: " & ex.Message
        Finally
            con.Close()
        End Try
        Return "Field API_ID included successfully (if needed)."
    End Function
    Function check_if_exist_and_includ_if_not_customer_data()
        Dim fields() As String = {"TradeName", "VatNumber", "Email", "Province", "Street", "HouseNo", "City"}
        Using connection As New SqlConnection(cs)
            connection.Open()
            For Each field As String In fields
                If Not FieldExists(connection, field) Then
                    AddField(connection, field)
                End If
            Next
        End Using
    End Function
    Function AddField(ByVal connection As SqlConnection, ByVal fieldName As String)
        ' Adjust the SQL command according to your database type and field requirements
        Dim query As String = $"ALTER TABLE Customer ADD {fieldName} VARCHAR(255) NULL"
        Using command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
        End Using
    End Function
    Public Function includefiled_Api_inovoiceid_() As String
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'InvoiceInfo' AND COLUMN_NAME = 'API_ID')"
        query += " ALTER TABLE InvoiceInfo ADD API_ID NVARCHAR(46)"
        con = New SqlConnection(cs)
        Try
            con.Open()
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error: " & ex.Message
        Finally
            con.Close()
        End Try
        Return "Field API_ID included successfully (if needed)."
    End Function
    Public Function EnsureMarkupColumnsExist()
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'product' AND COLUMN_NAME IN ('markup', 'markuppercent')) " &
                              "BEGIN " &
                              "ALTER TABLE product " &
                              "ADD markup DECIMAL(18, 2) NULL, " &
                              "markuppercent DECIMAL(18, 2) NULL " &
                              "END"
        Using con As New SqlConnection(cs)
            con.Open()
            Using cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return 0
    End Function
    Public Function AlterTableToAddCodeField()
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                '<<<<<<< HEAD
                ' Check if the column exists
                Dim columnExists As Boolean
                Using cmdCheck As SqlCommand = con.CreateCommand()
                    cmdCheck.CommandText = "SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'doz' AND COLUMN_NAME = 'Code'"
                    columnExists = cmdCheck.ExecuteScalar() IsNot Nothing
                End Using
                If Not columnExists Then
                    ' Execute ALTER TABLE SQL statement to add the "Code" field
                    Using cmd As SqlCommand = con.CreateCommand()
                        cmd.CommandText = "ALTER TABLE doz ADD Code VARCHAR(255) NULL"
                        cmd.ExecuteNonQuery()
                    End Using
                End If

                ' Execute ALTER TABLE SQL statement to add the "Code" field
                Using cmd As SqlCommand = con.CreateCommand()
                    Dim sql As String = "IF NOT EXISTS (
                    SELECT * 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE TABLE_NAME = 'doz' 
                    AND COLUMN_NAME = 'Code'
                    )
                    BEGIN
                       ALTER TABLE doz ADD Code VARCHAR(255) NULL
                    END"
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                End Using
                '===================
                Using cmd As SqlCommand = con.CreateCommand()
                    Dim sql As String = "IF NOT EXISTS (
                    SELECT * 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE TABLE_NAME = 'InvoiceInfo' 
                    AND (COLUMN_NAME = 'DeviceID' OR COLUMN_NAME = 'FiscalDay' OR COLUMN_NAME = 'ReceiptNo' OR COLUMN_NAME = 'CustomerRef' OR COLUMN_NAME = 'Vcode')
                    )
                    BEGIN
                       ALTER TABLE InvoiceInfo ADD
                        DeviceID varchar(50) NULL,
	                    FiscalDay varchar(50) NULL,
	                    ReceiptNo varchar(50) NULL,
	                    CustomerRef varchar(50) NULL,
	                    Vcode varchar(80) NULL
                    END"
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                End Using

                '===================
                Using cmd As SqlCommand = con.CreateCommand()
                    Dim sql As String = "IF NOT EXISTS (
                    SELECT * 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE TABLE_NAME = 'SalesReturn' 
                    AND (COLUMN_NAME = 'DeviceID' OR COLUMN_NAME = 'FiscalDay' OR COLUMN_NAME = 'ReceiptNo' OR COLUMN_NAME = 'CustomerRef' OR COLUMN_NAME = 'Vcode'OR COLUMN_NAME = 'qrcode')
                    )
                    BEGIN
                       ALTER TABLE SalesReturn ADD
                        DeviceID varchar(50) NULL,
	                    FiscalDay varchar(50) NULL,
	                    ReceiptNo varchar(50) NULL,
	                    CustomerRef varchar(50) NULL,
	                    Vcode varchar(80) NULL,
                        qrcode image NULL
                    END"
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                End Using

                '>>>>>>> f0dd0d43c45033b346c6e015c93842c296cb9a93
            End Using
        Catch ex As Exception
            '    MessageBox.Show("Error while adding the 'Code' field to the table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

    Public Function create_docTabele()
        Try
            Using con As New SqlConnection(cs)
                con.Open()

                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'doclist') " &
                              "BEGIN " &
                              "CREATE TABLE doclist ( " &
                              "id INT IDENTITY(1,1) PRIMARY KEY, " &
                              "fname VARCHAR(255), " &
                              "lname VARCHAR(255), " &
                              "initials VARCHAR(255), " &
                              "samdcno VARCHAR(255), " &
                              "groupno VARCHAR(255), " &
                              "phone VARCHAR(255), " &
                              "address VARCHAR(255) " &
                              ") " &
                              "END"
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while optimizing database", "HavanoPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Function

    Function change_field_invoicenumber()
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Try
            ' Connect to the database
            con = New SqlConnection(cs)
            con.Open()
            ' Modify the field length using ALTER TABLE statement
            Dim sql As String = "ALTER TABLE InvoiceInfo ALTER COLUMN InvoiceNo NVARCHAR(36)"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            ' Close the connection
            con.Close()
            '      MessageBox.Show("InvoiceNo field length changed to 36 characters.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            '     MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Clean up resources
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function
    Public Async Function return_creation_of_db() As Task(Of Integer)
        ReadApiCredentials()
        Dim tasks As New List(Of Task)
        ' Add each function to the list of tasks
        tasks.Add(Task.Run(AddressOf allproductINcluded))
        tasks.Add(Task.Run(AddressOf CreateMANULST))
        tasks.Add(Task.Run(AddressOf AlterTableToAddCodeField))
        tasks.Add(Task.Run(AddressOf EnsureMarkupColumnsExist))
        tasks.Add(Task.Run(AddressOf includefiled_Api_inovoiceid))
        tasks.Add(Task.Run(AddressOf includefiled_Api_inovoiceid_))
        tasks.Add(Task.Run(AddressOf CreateAdvanceSettingsTable))
        tasks.Add(Task.Run(AddressOf create_docTabele))
        tasks.Add(Task.Run(AddressOf CreateBinTable))
        'tasks.Add(Task.Run(AddressOf CreateAdvanceSettingsTable))
        ' tasks.Add(Task.Run(AddressOf change_field_invoicenumber))
        tasks.Add(Task.Run(AddressOf altertable_invoice_include_vat_name))
        tasks.Add(Task.Run(AddressOf check_if_exist_and_includ_if_not_customer_data))
        tasks.Add(Task.Run(AddressOf alter_table_product_include_bin_ifnot))
        tasks.Add(Task.Run(AddressOf addfield_mixtitle_mixstatus))
        tasks.Add(Task.Run(AddressOf pos_uiinterface))
        tasks.Add(Task.Run(AddressOf first_time_login_sql))
        tasks.Add(Task.Run(AddressOf Stock_adjst_dated_columCheckAndAlterDateField))
        tasks.Add(Task.Run(AddressOf CreateMixingTable))
        tasks.Add(Task.Run(AddressOf AddPackQtyAndPackNameIfNotExists))
        tasks.Add(Task.Run(Sub() DeleteDuplicateStockData(cs))) ' Using a lambda to pass the parameter
        tasks.Add(Task.Run(Sub() INCLUDE_IFNOTEXIST(cs))) ' Using a lambda to pass the parameter
        tasks.Add(Task.Run(AddressOf CreateBranchesTableIfNotExists))
        tasks.Add(Task.Run(AddressOf Dispatchto_invoiceinfo))
        tasks.Add(Task.Run(AddressOf EnsureErpFieldExists))
        tasks.Add(Task.Run(AddressOf CheckHavanoZimraField))

        '   tasks.Add(Task.Run(AddressOf ProcessSalesReturnsAsync))
        ' tasks.Add(Task.Run(AddressOf ProcessInvoicesAsync))

        ' tasks.Add(Task.Run(AddressOf BlockTest_UpdateDatedColumnToDateTime(cs))) EnsureErpFieldExists()  ProcessSalesReturnsAsync().Wait()
        ' Wait for all tasks to complete
        Await Task.WhenAll(tasks)
        Return 0
    End Function
    ''''''''''''''''''ENCRYPTION AND DECRYSTION
    Public Function CreateMANULST() As Integer
        Dim createTableQuery As String = "
    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MANU_LST]') AND type in (N'U'))
    BEGIN
        CREATE TABLE [dbo].[MANU_LST] (
            ID INT IDENTITY(1,1) PRIMARY KEY,
            qty FLOAT NOT NULL,
            ProductID INT NOT NULL,
            TRNSID INT NOT NULL,
            DATED DATETIME NOT NULL
        )
    END"

        Using con As New SqlConnection(cs)
            Try
                con.Open()
                Using cmd As New SqlCommand(createTableQuery, con)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                ' Handle the error appropriately (e.g., log or display error message)
                MessageBox.Show("Error creating MANU_LST table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        createTableQuery = "
    IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[blocktest_LST]') AND type in (N'U'))
    BEGIN
        CREATE TABLE [dbo].[blocktest_LST] (
            ID INT IDENTITY(1,1) PRIMARY KEY,
            qty FLOAT NOT NULL,
            ProductID INT NOT NULL,
            TRNSID INT NOT NULL,
            DATED DATETIME NOT NULL
        )
    END"

        Using con As New SqlConnection(cs)
            Try
                con.Open()
                Using cmd As New SqlCommand(createTableQuery, con)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                ' Handle the error appropriately (e.g., log or display error message)
                MessageBox.Show("Error creating blocktest_LST table: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return 0
    End Function

    Public Function EncryptToBase64(ByVal input As String) As String
        Dim bytesToEncode As Byte() = Encoding.UTF8.GetBytes(input)
        Dim base64String As String = Convert.ToBase64String(bytesToEncode)
        Return base64String
    End Function

    Function LogFunc(st1 As String, st2 As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into Logs(UserID,Date,Operation) VALUES (@d1,@d2,@d3)"
        cmd = New SqlCommand(cb)
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@d1", st1)
        cmd.Parameters.AddWithValue("@d2", System.DateTime.Now)
        cmd.Parameters.AddWithValue("@d3", st2)
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
        Return 0
    End Function

    Public Function addfield_mixtitle_mixstatus()
        Dim query As String = "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'POS_HoldBill' AND COLUMN_NAME = 'mixtitle')
                          ALTER TABLE POS_HoldBill ADD mixtitle nvarchar(50)"
        query &= ";"
        query &= "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'POS_HoldBillItems ' AND COLUMN_NAME = 'mixstatus')
                            ALTER TABLE POS_HoldBillItems  ADD mixstatus bit"
        Using con As New SqlConnection(cs)
            Using cmd As New SqlCommand(query, con)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return 0
    End Function


    Public Function CreateMixingTable() As Boolean
        Dim query As String
        Dim tableName As String = "MIXING"
        Dim checkTableQuery As String = $"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}')"
        Dim createTableQuery As String = $"
        CREATE TABLE {tableName} (
            ID INT IDENTITY(1,1) PRIMARY KEY,
            TITLE NVARCHAR(255),
            PID INT,
            IDS INT,
            INVID NVARCHAR(255)
        )"

        query = $"{checkTableQuery} BEGIN {createTableQuery} END"

        Try
            Using con As New SqlConnection(cs)
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Return True ' Table created successfully
                End Using
            End Using
        Catch ex As Exception
            ' Uncomment the next line to show a message box with the error
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function DeleteDuplicateStockData(cons As String)
        Dim sqlDelete As String = "DELETE FROM Temp_Stock_Company WHERE ProductID IN (SELECT ProductID FROM (SELECT ProductID, ROW_NUMBER() OVER (PARTITION BY ProductID ORDER BY (SELECT NULL)) AS RowNumber FROM Temp_Stock_Company) AS T WHERE RowNumber > 1);"
        sqlDelete = "DELETE TOP (1) FROM Temp_Stock_Company WHERE ProductID IN (SELECT ProductID FROM (SELECT ProductID, ROW_NUMBER() OVER (PARTITION BY ProductID ORDER BY (SELECT NULL)) AS RowNumber FROM Temp_Stock_Company) AS T WHERE RowNumber > 1);"
        Using con As New SqlConnection(cons)
            con.Open()
            Using command As New SqlCommand(sqlDelete, con)
                command.ExecuteNonQuery()
            End Using
        End Using
        '  MessageBox.Show("One instance of duplicate data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return "One instance of duplicate data deleted successfully"
    End Function
    Public Sub INCLUDE_IFNOTEXIST(cons As String)
        ' SQL to select all products
        Dim selectSql As String = "SELECT PID, SALESCOST, BARCODE, PURCHASECOST FROM PRODUCT"

        ' SQL to check existence and insert if not exists
        Dim checkAndInsertSql As String = "
        IF NOT EXISTS (SELECT 1 FROM Temp_Stock_Company WHERE ProductID = @ProductID)
        BEGIN
            INSERT INTO Temp_Stock_Company (ProductID, Barcode, PurchaseRate, SalesRate, ManufacturingDate, ExpiryDate, Qty)
            VALUES (@ProductID, @Barcode, @PurchaseRate, @SalesRate, NULL, NULL, 0)
        END"

        Using con As New SqlConnection(cons)
            con.Open()

            ' Fetch all products
            Using selectCommand As New SqlCommand(selectSql, con)
                Using reader As SqlDataReader = selectCommand.ExecuteReader()
                    While reader.Read()
                        ' Extract product details
                        Dim productId As Integer = reader("PID")
                        Dim salesCost As Decimal = reader("SALESCOST")
                        Dim barcode As String = reader("BARCODE").ToString()
                        Dim purchaseCost As Decimal = reader("PURCHASECOST")
                        If barcode.Length > 30 Then
                            barcode = barcode.Substring(0, 30)
                        End If
                        ' Check existence and insert if not exists
                        Using checkAndInsertCommand As New SqlCommand(checkAndInsertSql, con)
                            checkAndInsertCommand.Parameters.AddWithValue("@ProductID", productId)
                            checkAndInsertCommand.Parameters.AddWithValue("@Barcode", barcode)
                            checkAndInsertCommand.Parameters.AddWithValue("@PurchaseRate", purchaseCost)
                            checkAndInsertCommand.Parameters.AddWithValue("@SalesRate", salesCost)

                            checkAndInsertCommand.ExecuteNonQuery()
                        End Using
                    End While
                End Using
            End Using
        End Using
    End Sub


    Public Function BlockTest_UpdateDatedColumnToDateTime(connectionString As String)
        Using con As New SqlConnection(connectionString)
            con.Open()

            Dim checkQuery As String = "SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS " &
                                   "WHERE TABLE_NAME = 'block_test' AND COLUMN_NAME = 'Dated'"

            Dim currentDataType As String = String.Empty
            Using checkCmd As New SqlCommand(checkQuery, con)
                Dim reader As SqlDataReader = checkCmd.ExecuteReader()
                If reader.Read() Then
                    currentDataType = reader("DATA_TYPE").ToString()
                End If
                reader.Close()
            End Using

            ' If the current data type is already datetime, no need to change
            If currentDataType.ToLower() = "datetime" Then
                Return 0
            End If

            ' Step 1: Add a new column of type datetime
            Dim addColumnQuery As String = "ALTER TABLE block_test ADD Dated_New datetime"
            Using addColumnCmd As New SqlCommand(addColumnQuery, con)
                addColumnCmd.ExecuteNonQuery()
            End Using

            ' Step 2: Update the new column with converted values from the old column
            Dim updateColumnQuery As String = "UPDATE block_test SET Dated_New = " &
                                          "CASE WHEN ISDATE(Dated) = 1 THEN CAST(Dated AS datetime) ELSE NULL END"
            Using updateColumnCmd As New SqlCommand(updateColumnQuery, con)
                updateColumnCmd.ExecuteNonQuery()
            End Using

            ' Step 3: Drop the old column
            Dim dropColumnQuery As String = "ALTER TABLE block_test DROP COLUMN Dated"
            Using dropColumnCmd As New SqlCommand(dropColumnQuery, con)
                dropColumnCmd.ExecuteNonQuery()
            End Using

            ' Step 4: Rename the new column to the original column name
            Dim renameColumnQuery As String = "EXEC sp_rename 'block_test.Dated_New', 'Dated', 'COLUMN'"
            Using renameColumnCmd As New SqlCommand(renameColumnQuery, con)
                renameColumnCmd.ExecuteNonQuery()
            End Using
        End Using
        Return 0
    End Function

    Public Sub CheckHavanoZimraField()
        ' SQL queries to check if the columns exist and to add them if they do not
        Dim checkColumnIshavanozimra As String = "IF COL_LENGTH('Company', 'Ishavanozimra') IS NULL ALTER TABLE Company ADD Ishavanozimra BIT"
        Dim checkColumnHavanozimrakey As String = "IF COL_LENGTH('Company', 'havanozimrakey') IS NULL ALTER TABLE Company ADD havanozimrakey VARCHAR(500)"

        Using connection As New SqlConnection(cs)
            Try
                ' Open the connection to the database
                connection.Open()
                ' Create a command to execute the check and add column queries
                Using command As New SqlCommand()
                    command.Connection = connection
                    ' Check and add Ishavanozimra column if it doesn't exist
                    command.CommandText = checkColumnIshavanozimra
                    command.ExecuteNonQuery()
                    ' Check and add havanozimrakey column if it doesn't exist
                    command.CommandText = checkColumnHavanozimrakey
                    command.ExecuteNonQuery()
                End Using


            Catch ex As Exception

            End Try
        End Using
    End Sub


End Module


