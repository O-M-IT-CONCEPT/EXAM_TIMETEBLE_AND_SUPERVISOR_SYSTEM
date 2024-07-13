Imports System.Data.SqlClient
Imports System.IO
Imports System.Management
Imports System.Text
Imports System.Threading.Tasks


Module cruds
    Public usertypeonpc As Boolean
    Public first_time_runner As Boolean = True
    Public useronpc As String
    Public parameters As New List(Of SqlParameter)()
    Public Function Crud(sql As String, sqlParameters As List(Of SqlParameter)) As DataTable
        Dim dt As New DataTable()
        ' Using block to ensure the connection is closed properly
        Using conn As New SqlConnection(cs)
            Try
                conn.Open()

                ' Create a command object
                Using cmd As New SqlCommand(sql, conn)
                    ' Add the parameters to the command
                    If sqlParameters IsNot Nothing Then
                        cmd.Parameters.AddRange(sqlParameters.ToArray())
                    End If

                    ' Check if the SQL statement is a query or a non-query
                    If sql.Trim().ToUpper().StartsWith("SELECT") Then
                        Using da As New SqlDataAdapter(cmd)
                            da.Fill(dt)
                        End Using
                    Else
                        ' Execute non-query (INSERT, UPDATE, DELETE)
                        cmd.ExecuteNonQuery()
                    End If
                End Using

            Catch ex As Exception
                ' Handle any errors
                MsgBox("An error occurred: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using

        Return dt
    End Function
    Public Async Function UpdateDecimalFieldsAsync(connectionString As String) As Task
        Try
            Using con As New SqlConnection(connectionString)
                Await con.OpenAsync()
                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandTimeout = 0 ' Set the command timeout to infinite

                ' Get all tables in the database
                cmd.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"
                Dim tables As New List(Of String)
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    While Await reader.ReadAsync()
                        tables.Add(reader("TABLE_NAME").ToString())
                    End While
                End Using

                ' Loop through each table
                For Each table As String In tables
                    ' Get all decimal fields in the table
                    cmd.CommandText = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}' AND DATA_TYPE = 'decimal'"
                    Dim decimalFields As New List(Of String)
                    Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                        While Await reader.ReadAsync()
                            decimalFields.Add(reader("COLUMN_NAME").ToString())
                        End While
                    End Using

                    ' Alter each decimal field to have 2 decimal places
                    For Each field As String In decimalFields
                        cmd.CommandText = $"ALTER TABLE {table} ALTER COLUMN {field} DECIMAL(18, 2)"
                        Await cmd.ExecuteNonQueryAsync()
                    Next
                Next

                MsgBox("Decimal fields updated successfully.")
            End Using
        Catch ex As Exception
            MsgBox($"An error occurred: {ex.Message}")
        End Try
    End Function

    Function GetHardwareID() As String
        Dim hardwareID As String = String.Empty
        Try
            Dim searcher As New ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor")
            For Each obj As ManagementObject In searcher.Get()
                hardwareID = obj("ProcessorId").ToString()
                Exit For
            Next
        Catch ex As Exception
            MsgBox("Unable to retrieve hardware ID: " & ex.Message)
        End Try
        Return hardwareID
    End Function

    Public Function CheckAndWriteHardwareID() As Boolean
        Dim appPath As String = AppDomain.CurrentDomain.BaseDirectory
        Dim filePath As String = Path.Combine(appPath, "first_time_execution.dll")
        Dim currentHardwareID As String = GetHardwareID()

        If File.Exists(filePath) Then
            Dim fileHardwareID As String = File.ReadAllText(filePath, Encoding.UTF8)
            If fileHardwareID = currentHardwareID Then
                Return True
            Else
                File.WriteAllText(filePath, currentHardwareID, Encoding.UTF8)
                Return False
            End If
        Else
            File.WriteAllText(filePath, currentHardwareID, Encoding.UTF8)
            Return False
        End If
    End Function


    Private Sub AddSubMenuItemsToDatabase(menuItem As ToolStripMenuItem, connection As SqlConnection)
        For Each subItem As ToolStripItem In menuItem.DropDownItems
            If TypeOf subItem Is ToolStripMenuItem Then
                Dim subMenuItem As ToolStripMenuItem = CType(subItem, ToolStripMenuItem)

                ' Check if the menu item already exists in the database
                Dim query As String = "SELECT COUNT(*) FROM [dbo].[ASECURITY] WHERE [Menu] = @Menu"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Menu", subMenuItem.Text)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' If the menu item does not exist, insert it
                    If count = 0 Then
                        query = "INSERT INTO [dbo].[ASECURITY] ([Menu], [LEV1], [LEV2], [LEV3]) VALUES (@Menu, @LEV1, @LEV2, @LEV3)"
                        Using insertCmd As New SqlCommand(query, connection)
                            insertCmd.Parameters.AddWithValue("@Menu", subMenuItem.Text)
                            insertCmd.Parameters.AddWithValue("@LEV1", False) ' Set default value for LEV1
                            insertCmd.Parameters.AddWithValue("@LEV2", False) ' Set default value for LEV2
                            insertCmd.Parameters.AddWithValue("@LEV3", False) ' Set default value for LEV3
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                ' Recursively add submenu items
                AddSubMenuItemsToDatabase(subMenuItem, connection)
            End If
        Next
    End Sub

    Sub AddMenuItemsToDatabase(connectionString As String, menuStrip As MenuStrip)
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                For Each menuItem As ToolStripMenuItem In menuStrip.Items.OfType(Of ToolStripMenuItem)()
                    AddSubMenuItemsToDatabase(menuItem, con)
                Next
            End Using
        Catch ex As Exception
            MsgBox($"An error occurred: {ex.Message}")
        End Try
    End Sub









End Module
