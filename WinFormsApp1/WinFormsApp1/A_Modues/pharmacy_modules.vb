Imports System.Data.SqlClient
Imports System.Net
Imports System.Windows

Module pharmacy_modules
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean

    Public da As SqlDataAdapter = Nothing
    Public dt As New DataTable()
    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Function user_phar_status(id As String)
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT * FROM UserRights WHERE UserID = @userid AND UR_save = 1 AND ModuleName = 'Pharmacy'"
            cmd.Parameters.AddWithValue("@userid", id) ' Replace YourUserID with the actual value
            rdr1 = cmd.ExecuteReader()
            If rdr1.Read() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            '  MsgBox(ex.ToString())
            Return False
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function

    Public Function U_I() As Boolean
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT TOP 1 patchinter FROM COMPANY"
                    Using rdr1 As SqlDataReader = cmd.ExecuteReader()
                        If rdr1.Read() Then
                            Return rdr1.GetBoolean(0)
                        Else
                            Return False ' Or handle the case where no rows are returned
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function FetchAdvanceSettings()
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Dim query As String = "SELECT TOP 1 * FROM Advance_settings" ' Select the first row

                Using cmd As New SqlCommand(query, con)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then ' Check if data exists
                            Return Convert.ToBoolean(reader("phar"))

                        Else
                            Return False

                        End If
                    End Using '
                End Using ' 
            End Using ' 
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function FetchAdvanceSettingsDATA()
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Dim query As String = "SELECT TOP 1 * FROM Advance_settings" ' Select the first row

                Using cmd As New SqlCommand(query, con)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then ' Check if data exists
                            If Convert.ToBoolean(reader("phar")) Then
                                Return (Convert.ToDouble(reader("dmarkup")).ToString())
                            Else
                                Return 0
                            End If
                        Else
                            Return 0
                        End If
                    End Using '
                End Using ' 
            End Using ' 
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error In Advance Settings Modules", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
        Return 0
    End Function
    Public Function IsBatchStatus(id As String) As Boolean
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Dim query As String = "SELECT * FROM product WHERE pid = @id AND RTRIM(TrackBatches)= 'Yes'"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return True
                        Else
                            Return False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            '  MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function IsBatchCOUNT(id As String) As Boolean
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Dim query As String = "SELECT * FROM BATCHES WHERE pid = @id"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return True
                        Else
                            Return False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            '  MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function NextMixing_ID() As Integer
        Dim nextID As Integer = 1
        Dim query As String = "SELECT ISNULL(MAX(id), 0) + 1 FROM Mixing"
        con = New SqlConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = query
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot DBNull.Value Then
            nextID = Convert.ToInt32(result)
        End If
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return nextID
    End Function


    Public Function FetchInvoiceData(ByVal query As String, ByVal parameters As List(Of SqlParameter)) As DataTable
        Dim con As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim da As SqlDataAdapter = Nothing
        Dim dt As New DataTable()
        Try
            con = New SqlConnection(cs) ' Replace with your connection string
            con.Open()
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddRange(parameters.ToArray())
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Return dt
    End Function

    Function getOrgName() As Company
        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Using cmd As SqlCommand = con.CreateCommand()
                    cmd.CommandText = "SELECT * FROM Company"
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim company As New Company() With {
                            .CompanyName = reader("CompanyName").ToString(),
                            .MailingName = reader("MailingName").ToString(),
                            .Country = reader("Country").ToString(),
                            .Address = reader("Address").ToString(),
                            .City = reader("City").ToString(),
                            .State = reader("State").ToString(),
                            .PinCode = reader("PinCode").ToString(),
                            .ContactNo = reader("ContactNo").ToString(),
                            .Fax = reader("Fax").ToString(),
                            .Email = reader("Email").ToString(),
                            .Website = reader("Website").ToString(),
                            .TIN = reader("TIN").ToString(),
                            .LicenseNo = reader("LicenseNo").ToString(),
                            .ServiceTaxNo = reader("ServiceTaxNo").ToString(),
                            .CST = reader("CST").ToString(),
                            .PAN = reader("PAN").ToString(),
                            .CurrencyCode = reader("CurrencyCode").ToString(),
                            .Currency = reader("Currency").ToString(),
                            .Logo = If(IsDBNull(reader("Logo")), Nothing, DirectCast(reader("Logo"), Byte())),
                            .ShowLogo = SafeConvertToBoolean(reader("ShowLogo")),
                            .CapitalAccount = reader("CapitalAccount").ToString(),
                            .NP = reader("NP").ToString(),
                            .QCode = reader("QCode").ToString(),
                            .BCode = reader("BCode").ToString(),
                            .InvoiceHeader = reader("InvoiceHeader").ToString(),
                            .ItemWiseVAT = SafeConvertToBoolean(reader("ItemWiseVAT")),
                            .QTC = SafeConvertToBoolean(reader("QTC")),
                            .ZeroPrice = SafeConvertToBoolean(reader("ZeroPrice")),
                            .BelowCost = SafeConvertToBoolean(reader("BelowCost")),
                            .ActiveBelow = SafeConvertToBoolean(reader("ActiveBelow")),
                            .wscalable = SafeConvertToBoolean(reader("wscalable")),
                            .pscalable = SafeConvertToBoolean(reader("pscalable")),
                            .MultiCurrencyReceipt = SafeConvertToBoolean(reader("MultiCurrencyReceipt")),
                            .ShowMultiCurrency = SafeConvertToBoolean(reader("ShowMultiCurrency")),
                            .VatNo = reader("VatNo").ToString(),
                            .RevMaxKey = reader("RevMaxKey").ToString(),
                            .ShowDiscount = SafeConvertToBoolean(reader("ShowDiscount")),
                            .EnableRevMax = SafeConvertToBoolean(reader("EnableRevMax")),
                            .selnegative = SafeConvertToBoolean(reader("selnegative")),
                            .patchinter = SafeConvertToBoolean(reader("patchinter")),
                            .autoprint = SafeConvertToBoolean(reader("autoprint")),
                            .autoprintshift = SafeConvertToBoolean(reader("autoprintshift")),
                            .textprinting = SafeConvertToBoolean(reader("textprinting")),
                            .cash = SafeConvertToBoolean(reader("cash"))
                        }
                            Return company
                        Else
                            Return Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception as needed, possibly logging it
            Return Nothing
        End Try
    End Function

    Private Function SafeConvertToBoolean(value As Object) As Boolean
        If value Is Nothing OrElse IsDBNull(value) Then
            Return False
        End If

        Dim boolValue As Boolean
        If Boolean.TryParse(value.ToString(), boolValue) Then
            Return boolValue
        End If

        ' Additional checks for numeric representation of booleans
        If IsNumeric(value) Then
            Dim intValue As Integer
            If Integer.TryParse(value.ToString(), intValue) Then
                Return intValue <> 0
            End If
        End If

        ' Default to false if conversion fails
        Return False
    End Function





End Module
