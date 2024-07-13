

Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Text
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6


Module Inner_function_login
    Public Quotation As String = "No"
    Public BillReprint As String = "No"
    Public CreditCustomer As String = "No"
    Public SalesReturn As String = "No"
    Public SalesList As String = "No"
    Public logged As Boolean = False
    Public loggsta As Boolean = False
    Public Function Encrypt(password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function

    Public Function Decrypt(encryptpwd As String) As String
        Dim decryptpwd As String = String.Empty
        Dim encodepwd As New UTF8Encoding()
        Dim Decode As Decoder = encodepwd.GetDecoder()
        Dim todecode_byte As Byte() = Convert.FromBase64String(encryptpwd)
        Dim charCount As Integer = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)
        Dim decoded_char As Char() = New Char(charCount - 1) {}
        Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0)
        decryptpwd = New [String](decoded_char)
        Return decryptpwd
    End Function

    Sub LedgerSave(ByVal a As DateTime, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As Decimal, ByVal f As Decimal, ByVal g As String, ByVal h As String, ByVal i As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into LedgerBook(Date, Name, LedgerNo, Label,Debit,Credit,PartyID,AccLedger,Rmarks) Values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", c)
        cmd.Parameters.AddWithValue("@d4", d)
        cmd.Parameters.AddWithValue("@d5", e)
        cmd.Parameters.AddWithValue("@d6", f)
        cmd.Parameters.AddWithValue("@d7", g)
        cmd.Parameters.AddWithValue("@d8", h)
        cmd.Parameters.AddWithValue("@d9", i)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub LedgerDelete(ByVal a As String, ByVal b As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cq As String = "delete from LedgerBook where LedgerNo=@d1 and Label=@d2"
        cmd = New SqlCommand(cq)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub LedgerUpdate(ByVal a As DateTime, ByVal b As String, ByVal e As Decimal, ByVal f As Decimal, ByVal g As String, ByVal h As String, ByVal i As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Update LedgerBook set Date=@d1, Name=@d2,Debit=@d3,Credit=@d4,PartyID=@d5 where LedgerNo=@d6 and Label=@d7"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", e)
        cmd.Parameters.AddWithValue("@d4", f)
        cmd.Parameters.AddWithValue("@d5", g)
        cmd.Parameters.AddWithValue("@d6", h)
        cmd.Parameters.AddWithValue("@d7", i)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub LedgerUpdate1(ByVal a As DateTime, ByVal b As String, ByVal e As Decimal, ByVal f As Decimal, ByVal g As String, ByVal h As String, ByVal i As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Update LedgerBook set Date=@d1, Name=@d2,Debit=@d3,Credit=@d4 where LedgerNo=@d6 and Label=@d7 and PartyID=@d5 "
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", e)
        cmd.Parameters.AddWithValue("@d4", f)
        cmd.Parameters.AddWithValue("@d5", g)
        cmd.Parameters.AddWithValue("@d6", h)
        cmd.Parameters.AddWithValue("@d7", i)

        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub

    Sub MemberLedgerSave(ByVal a As DateTime, ByVal b As Integer, ByVal c As String, ByVal d As String, ByVal e As Decimal, ByVal f As Decimal, ByVal g As Integer)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into MemberLedger(Date,ID, LedgerNo, Label,Debit,Credit,MemberID) Values (@d1,@d2,@d3,@d4,@d5,@d6,@d7)"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", c)
        cmd.Parameters.AddWithValue("@d4", d)
        cmd.Parameters.AddWithValue("@d5", e)
        cmd.Parameters.AddWithValue("@d6", f)
        cmd.Parameters.AddWithValue("@d7", g)
        cmd.CommandTimeout = 0
        cmd.Connection = con
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub MemberLedgerDelete(ByVal a As String, ByVal b As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cq As String = "delete from MemberLedger where LedgerNo=@d1 and Label=@d2"
        cmd = New SqlCommand(cq)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.CommandTimeout = 0
        cmd.Connection = con
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub MemberLedgerUpdate(ByVal a As DateTime, ByVal b As Integer, ByVal e As Decimal, ByVal f As Decimal, ByVal g As Integer, ByVal h As String, ByVal i As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Update MemberLedger set Date=@d1,ID=@d2,Debit=@d3,Credit=@d4,memberID=@d5 where LedgerNo=@d6 and Label=@d7"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", e)
        cmd.Parameters.AddWithValue("@d4", f)
        cmd.Parameters.AddWithValue("@d5", g)
        cmd.Parameters.AddWithValue("@d6", h)
        cmd.Parameters.AddWithValue("@d7", i)
        cmd.CommandTimeout = 0
        cmd.Connection = con
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub BankAccountLedgerSave(ByVal a As DateTime, ByVal b As String, ByVal c As String, ByVal d As String, ByVal e As Decimal, ByVal f As Decimal)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into BankAccountLedger(Date,AccNo, LedgerNo, Label,Debit,Credit) Values (@d1,@d2,@d3,@d4,@d5,@d6)"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", c)
        cmd.Parameters.AddWithValue("@d4", d)
        cmd.Parameters.AddWithValue("@d5", e)
        cmd.Parameters.AddWithValue("@d6", f)
        cmd.CommandTimeout = 0
        cmd.Connection = con
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub BankAccountLedgerDelete(ByVal a As String, ByVal b As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cq As String = "delete from BankAccountLedger where LedgerNo=@d1 and Label=@d2"
        cmd = New SqlCommand(cq)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.CommandTimeout = 0
        cmd.Connection = con
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub BankAccountLedgerUpdate(ByVal a As DateTime, ByVal b As String, ByVal e As Decimal, ByVal f As Decimal, ByVal h As String, ByVal i As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Update BankAccountLedger set Date=@d1, AccNo=@d2,Debit=@d3,Credit=@d4 where LedgerNo=@d6 and Label=@d7"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", e)
        cmd.Parameters.AddWithValue("@d4", f)
        cmd.Parameters.AddWithValue("@d6", h)
        cmd.Parameters.AddWithValue("@d7", i)
        cmd.CommandTimeout = 0
        cmd.Connection = con
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Public Function IsSaveAllowed(ByVal UserID As String, ByVal ModuleName As String) As Boolean
        Dim Value As Boolean
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Select UR_Save from UserRights where UserID=@d1 and ModuleName=@d2"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", UserID)
        cmd.Parameters.AddWithValue("@d2", ModuleName)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        rdr = cmd.ExecuteReader()
        If rdr.Read Then
            Value = rdr.GetBoolean(0)
        End If
        con.Close()
        Return Value
    End Function
    Public Function IsViewAllowed(ByVal UserID As String, ByVal ModuleName As String) As Boolean
        Dim Value As Boolean
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Select UR_View from UserRights where UserID=@d1 and ModuleName=@d2"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", UserID)
        cmd.Parameters.AddWithValue("@d2", ModuleName)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        rdr = cmd.ExecuteReader()
        If rdr.Read Then
            Value = rdr.GetBoolean(0)
        End If
        con.Close()
        Return Value
    End Function
    Public Function IsUpdateAllowed(ByVal UserID As String, ByVal ModuleName As String) As Boolean
        Dim Value As Boolean
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Select UR_Update from UserRights where UserID=@d1 and ModuleName=@d2"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", UserID)
        cmd.Parameters.AddWithValue("@d2", ModuleName)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        rdr = cmd.ExecuteReader()
        If rdr.Read Then
            Value = rdr.GetBoolean(0)
        End If
        con.Close()
        Return Value
    End Function
    Public Function IsDeleteAllowed(ByVal UserID As String, ByVal ModuleName As String) As Boolean
        Dim Value As Boolean
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Select UR_Delete from UserRights where UserID=@d1 and ModuleName=@d2"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", UserID)
        cmd.Parameters.AddWithValue("@d2", ModuleName)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        rdr = cmd.ExecuteReader()
        If rdr.Read Then
            Value = rdr.GetBoolean(0)
        End If
        con.Close()
        Return Value
    End Function
    Sub ClockINSave(ByVal b As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into ClockIN(UserID,ClockINDate) Values (@d2,@d3)"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub ClockOUTSave(ByVal a As Integer)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into ClockOUT(ClockINID,ClockOUTDate) Values (@d2,@d3)"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d2", a)
        cmd.Parameters.AddWithValue("@d3", System.DateTime.Now)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub LoyaltyCardMemberLedgerSave(ByVal a As DateTime, ByVal c As String, ByVal d As String, ByVal e As Integer, ByVal f As Integer, ByVal g As Integer)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "insert into LoyaltyMemberLedgerBook(Date, LedgerNo, Label,PointsEarned,PointsRedeem,MemberID) Values (@d1,@d3,@d4,@d5,@d6,@d7)"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d3", c)
        cmd.Parameters.AddWithValue("@d4", d)
        cmd.Parameters.AddWithValue("@d5", e)
        cmd.Parameters.AddWithValue("@d6", f)
        cmd.Parameters.AddWithValue("@d7", g)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub LoyaltyCardMemberLedgerDelete(ByVal a As String, ByVal b As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cq As String = "delete from LoyaltyMemberLedgerBook where LedgerNo=@d1 and Label=@d2"
        cmd = New SqlCommand(cq)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Sub LoyaltyCardMemberLedgerUpdate(ByVal a As String, ByVal b As String, ByVal c As Integer)
        con = New SqlConnection(cs)
        con.Open()
        Dim cq As String = "Update LoyaltyMemberLedgerBook set PointsRedeem=@d3 where LedgerNo=@d1 and Label=@d2"
        cmd = New SqlCommand(cq)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", c)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        cmd.ExecuteReader()
        con.Close()
    End Sub

    Public Sub GetPrinterName(ByVal TillID As String, ByVal rpt As Object)
        ' Initialize the connection
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "SELECT RTRIM(PrinterName) ,RTRIM(PrinterName2) FROM POSPrinterSetting WHERE TillID=@d1 AND IsEnabled='Yes'"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", TillID)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            Dim printerName As String = rdr.GetValue(0).ToString()
            Dim printerName2 As String = If(IsDBNull(rdr.GetValue(1)), String.Empty, rdr.GetValue(1).ToString())
            Dim settings As New System.Drawing.Printing.PrinterSettings()
            settings.PrinterName = printerName
            Dim pagesettings As New System.Drawing.Printing.PageSettings()
            pagesettings.PaperSize = New System.Drawing.Printing.PaperSize("Custom", 2843, 60000)
            rpt.PrintToPrinter(settings, pagesettings, False)
            '   If printerName2.Trim().Length = 0 Then
            '  Return
            'End If
            '   settings = New System.Drawing.Printing.PrinterSettings()
            '  settings.PrinterName = printerName2
            ' rpt.PrintToPrinter(settings, pagesettings, False)
        End If
        con.Close()
    End Sub
    Public Sub GetMultiPrinterName(ByVal TillID As String, ByVal rpt As Object, ByVal rpt2 As Object)
        ' Initialize the connection
        Dim query As String = "SELECT RTRIM(PrinterName) ,RTRIM(PrinterName2) FROM POSPrinterSetting WHERE TillID=@d1 AND IsEnabled='Yes'"
        Dim parameters As New List(Of SqlParameter)()
        parameters.Add(New SqlParameter("@D1", TillID))
        Dim dt As DataTable = Crud(query, parameters)
        If dt.Rows.Count > 0 Then
            Dim printerName As String = dt(0)(0).ToString()
            Dim printerName2 As String = If(IsDBNull(dt(0)(1).ToString()), String.Empty, dt(0)(0).ToString())
            Dim settings As New System.Drawing.Printing.PrinterSettings()
            settings.PrinterName = printerName
            Dim pagesettings As New System.Drawing.Printing.PageSettings()
            pagesettings.PaperSize = New System.Drawing.Printing.PaperSize("Custom", 2843, 60000)
            rpt.PrintToPrinter(settings, pagesettings, False)
            If printerName2.Trim().Length = 0 Then
                Return
            End If
            settings = New System.Drawing.Printing.PrinterSettings()
            settings.PrinterName = printerName2
            rpt2.PrintToPrinter(settings, pagesettings, False)
        End If

    End Sub

    Sub InvoiceDeleteFunc(ByVal a As String, ByVal b As DateTime, ByVal c As Decimal, ByVal d As String, ByVal e As String, ByVal f As String, ByVal g As String, ByVal h As String)
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "Insert Into DeletedInvoices(BillNo, BillDate, GrandTotal, Operator, PaymentMode, Reason, DeletedDate,BillType,Canceled_Deleted) Values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", a)
        cmd.Parameters.AddWithValue("@d2", b)
        cmd.Parameters.AddWithValue("@d3", c)
        cmd.Parameters.AddWithValue("@d4", d)
        cmd.Parameters.AddWithValue("@d5", e)
        cmd.Parameters.AddWithValue("@d6", f)
        cmd.Parameters.AddWithValue("@d7", System.DateTime.Now)
        cmd.Parameters.AddWithValue("@d8", g)
        cmd.Parameters.AddWithValue("@d9", h)
        cmd.Connection = con
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Public Function GetInvoice(ByVal InvoiceNo As String) As Boolean
        Dim result As Boolean = False
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "SELECT * from MultiCurrency where InvoiceID=@d1"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", InvoiceNo)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        Dim rdr1 As SqlDataReader = cmd.ExecuteReader()
        If rdr1.HasRows Then
            result = True
        End If
        con.Close()
        Return result
    End Function
    Public Function GetSalesman(ByVal InvoiceNo As String) As String
        Dim Name As String = ""
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "SELECT RTRIM(Name) from Salesman INNER JOIN InvoiceInfo ON Salesman.SM_ID=InvoiceInfo.SalesmanID where InvoiceNo=@d1"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", InvoiceNo)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        Dim rdr1 As SqlDataReader = cmd.ExecuteReader()
        If rdr1.Read Then
            Name = rdr1.GetValue(0).ToString()
        Else
            Name = ""
        End If
        con.Close()
        Return Name
    End Function
    Public Function GetOperatorName(ByVal InvoiceNo As String) As String
        Dim Name As String = ""
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "SELECT RTRIM(Name) from Registration,POS_OpeningCash,InvoiceInfo where Registration.UserID=POS_OpeningCash.UserID and InvoiceInfo.OpenID=POS_OpeningCash.OpenID and InvoiceNo=@d1"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", InvoiceNo)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        Dim rdr1 As SqlDataReader = cmd.ExecuteReader()
        If rdr1.Read Then
            Name = rdr1.GetValue(0).ToString()
        Else
            Name = ""
        End If
        con.Close()
        Return Name
    End Function
    Public Function GetOpenID(ByVal UserID As String, ByVal TillID As String) As Integer
        Dim OpenID As Integer
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "SELECT Top 1 OpenID FROM POS_OpeningCash,Registration where POS_OpeningCash.UserID=Registration.UserID and Registration.UserID=@d1 and TillDetails=@d2 and Closed=0 order by OpenID desc"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", UserID)
        cmd.Parameters.AddWithValue("@d2", TillID)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        Dim rdr1 As SqlDataReader = cmd.ExecuteReader()
        If rdr1.Read Then
            OpenID = rdr1.GetValue(0)
        End If
        con.Close()
        Return OpenID
    End Function
    Public Function GetMinSalesRate(ByVal ProductID As Integer) As Decimal
        Dim MinSalesRate As Decimal
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "SELECT MinSalesCost from Product where PID=@d1"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", ProductID)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        Dim rdr1 As SqlDataReader = cmd.ExecuteReader()
        If rdr1.Read Then
            MinSalesRate = rdr1.GetValue(0)
        End If
        con.Close()
        Return MinSalesRate.ToString("F")
    End Function
    Public Function GetCreditCustomerBalance(ByVal CreditCustomerID As String) As Decimal
        Dim Balance As Decimal
        con = New SqlConnection(cs)
        con.Open()
        Dim cb As String = "SELECT IsNull(sum(Credit)-sum(Debit),0) as Balance FROM LedgerBook where PartyID=@d1"
        cmd = New SqlCommand(cb)
        cmd.Parameters.AddWithValue("@d1", CreditCustomerID)
        cmd.Connection = con
        cmd.CommandTimeout = 0
        Dim rdr3X As SqlDataReader = cmd.ExecuteReader()
        If rdr3X.Read Then
            Balance = rdr3X.GetValue(0)
        End If
        con.Close()
        Return Balance.ToString("F")
    End Function
    Public Function HandleRegistry() As Boolean
        Dim firstRunDate As Date
        Dim st As Date = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WinFormsApp193", "Set", Nothing)
        firstRunDate = st
        If firstRunDate = Nothing Then
            firstRunDate = System.DateTime.Today.Date
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WinFormsApp193", "Set", firstRunDate)
        ElseIf (Now - firstRunDate).Days > 10 Then
            Return False
        End If
        Return True
    End Function

    Public Function IsOpenSettle(ByVal a As Object) As String
        Dim V1 As String = ""
        con = New SqlConnection(cs)
        con.Open()
        Dim sql As String = "SELECT RTRIM(isOS) from POSPrinterSetting where TillID=@d1"
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@d1", a)
        Dim rdrX12 As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If (rdrX12.Read() = True) Then
            V1 = rdrX12.GetValue(0).ToString()
        End If
        con.Close()
        Return V1
    End Function
    Public Sub OSKeyboard()
        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start("osk.exe")
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start("osk.exe")
        End If
    End Sub
End Module
