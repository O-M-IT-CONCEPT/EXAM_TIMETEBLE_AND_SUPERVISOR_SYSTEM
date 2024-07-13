Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Data.Sql
Imports System.Data
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common
Imports MetroFramework
Imports MetroFramework.Forms
Imports Microsoft.Data.Sql
Public Class frmSqlServerSetting
    Dim st As String
    Dim SqlConnStr As String
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnDemoDB.Click
        DeleteApiCredentialsFile()
        Deletefirsttimerunning()
        If cmbInstallationType.SelectedIndex = 0 Then
            If cmbServerName.Text = "" Then
                MsgBox("Please Select/Enter Server Name", MsgBoxStyle.Information)
                cmbServerName.Focus()
                Exit Sub
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                If txtUserName.Text.Length = 0 Then
                    MsgBox("please enter user name", MsgBoxStyle.Information)
                    txtUserName.Focus()
                    Exit Sub
                End If
                If txtPassword.Text.Length = 0 Then
                    MsgBox("please enter password", MsgBoxStyle.Information)
                    txtPassword.Focus()
                    Exit Sub
                End If
            End If
            Cursor = Cursors.WaitCursor
            Timer5.Enabled = True
            If cmbAuthentication.SelectedIndex = 0 Then
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                con = New SqlConnection("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
            End If
            con.Open()
            If (con.State = ConnectionState.Open) Then
                If MsgBox("It will create the DB and configure the sql server, Do you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                    Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")
                        If cmbAuthentication.SelectedIndex = 0 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;Integrated Security=True;MultipleActiveResultSets=True")
                            sw.Close()
                        End If
                        If cmbAuthentication.SelectedIndex = 1 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                            sw.Close()
                        End If
                        If CheckBox1.Checked = False Then
                            CreateDB()
                        Else
                            CreateDB_new()
                        End If

                        MetroMessageBox.Show(Me, "DB has been created and SQL Server setting has been saved successfully..." & vbCrLf & "Application will be closed,Please start it again", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End
                    End Using
                End If
            End If
        ElseIf cmbInstallationType.SelectedIndex = 1 Then
            If cmbServerName.Text = "" Then
                MsgBox("Please Select/Enter Server Name", MsgBoxStyle.Information)
                cmbServerName.Focus()
                Exit Sub
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                If txtUserName.Text.Length = 0 Then
                    MsgBox("please enter user name", MsgBoxStyle.Information)
                    txtUserName.Focus()
                    Exit Sub
                End If
                If txtPassword.Text.Length = 0 Then
                    MsgBox("please enter password", MsgBoxStyle.Information)
                    txtPassword.Focus()
                    Exit Sub
                End If
            End If
            Cursor = Cursors.WaitCursor
            Timer5.Enabled = True
            If MsgBox("It will configure the sql server, Do you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")
                    If cmbAuthentication.SelectedIndex = 0 Then
                        sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;Integrated Security=True;MultipleActiveResultSets=True")
                        sw.Close()
                    End If
                    If cmbAuthentication.SelectedIndex = 1 Then
                        sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                        sw.Close()
                    End If
                    MetroMessageBox.Show(Me, "SQL Server setting has been saved successfully..." & vbCrLf & "Application will be closed,Please start it again", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                End Using
            End If
        End If
        '  Catch ex As Exception
        'MetroMessageBox.Show(Me, "Unable to connect to sql server" + vbCrLf + Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If lblSet.Text = "Main Form" Then
            Me.Close()
        Else
            If MsgBox("Do you want to close the application....", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                End
            End If
        End If
    End Sub
    Sub CreateDBOLD()
        Try
            con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
            con.Open()
            Dim cb2 As String = "Select * from sysdatabases where name='DATA_PROCESSING'"
            cmd = New SqlCommand(cb2)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                con.Open()
                Dim cb1 As String = "USE Master ALTER DATABASE DATA_PROCESSING SET Single_User WITH Rollback Immediate DROP database DATA_PROCESSING"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                con.Open()
                Dim cb As String = "Create Database DATA_PROCESSING"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                'Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DBScript.sql")
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DATA_PROCESSING.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(con))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            Else
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                con.Open()
                Dim cb3 As String = "Create Database DATA_PROCESSING"
                cmd = New SqlCommand(cb3)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DATA_PROCESSING.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(con))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CreateDB()
        Try
            Dim conString As String = "Data Source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True"
            Using con As New SqlConnection(conString)
                con.Open()
                Dim cb2 As String = "SELECT * FROM sys.databases WHERE name='DATA_PROCESSING'"
                Using cmd As New SqlCommand(cb2, con)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            Dim cb1 As String = "USE Master ALTER DATABASE DATA_PROCESSING SET Single_User WITH Rollback Immediate DROP DATABASE DATA_PROCESSING"
                            Using cmdDrop As New SqlCommand(cb1, con)
                                cmdDrop.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                End Using

                Dim cb3 As String = "CREATE DATABASE DATA_PROCESSING"
                Using cmdCreateDB As New SqlCommand(cb3, con)
                    cmdCreateDB.ExecuteNonQuery()
                End Using

                Using sr As New StreamReader(Application.StartupPath & "\DATA_PROCESSING.sql")
                    Dim st As String = sr.ReadToEnd()
                    Dim server As New Microsoft.SqlServer.Management.Smo.Server(New Microsoft.SqlServer.Management.Common.ServerConnection(con))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            End Using
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CreateDB_new()
        '  Try
        Dim conString As String = "Data Source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True"

            Using con As New SqlConnection(conString)
                con.Open()

                ' Check if the database exists
                Dim cb2 As String = "SELECT * FROM sys.databases WHERE name='DATA_PROCESSING'"
                Using cmd As New SqlCommand(cb2, con)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            ' If the database exists, alter it to single user mode and drop it
                            Dim cb1 As String = "ALTER DATABASE DATA_PROCESSING SET Single_User WITH Rollback Immediate"
                            Using cmdDrop As New SqlCommand(cb1, con)
                                cmdDrop.ExecuteNonQuery()
                            End Using

                            Dim cbDrop As String = "DROP DATABASE DATA_PROCESSING"
                            Using cmdDropDB As New SqlCommand(cbDrop, con)
                                cmdDropDB.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                End Using

                ' Create the database
                Dim cb3 As String = "CREATE DATABASE DATA_PROCESSING"
                Using cmdCreateDB As New SqlCommand(cb3, con)
                    cmdCreateDB.ExecuteNonQuery()
                End Using
            End Using

                ' Read SQL script from file and execute
                Using sr As New StreamReader(Application.StartupPath & "\DATA_PROCESSING.sql")
                Dim script As String = sr.ReadToEnd()
                Dim commands As String() = script.Split(New String() {"GO"}, StringSplitOptions.RemoveEmptyEntries)

                Using con As New SqlConnection(conString)
                    con.Open()
                    For Each cmdText As String In commands
                        If cmdText.Trim() <> "" Then
                            Using cmdExecuteScript As New SqlCommand(cmdText, con)
                                cmdExecuteScript.ExecuteNonQuery()
                            End Using
                        End If
                    Next
                End Using
            End Using

            ' Catch ex As Exception
        '    MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '   End Try
    End Sub

    Private Sub cmbAuthentication_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAuthentication.SelectedIndexChanged
        If cmbAuthentication.SelectedIndex = 0 Then
            txtUserName.ReadOnly = True
            txtPassword.ReadOnly = True
            txtUserName.Text = ""
            txtPassword.Text = ""
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            txtUserName.ReadOnly = False
            txtPassword.ReadOnly = False
        End If
    End Sub

    Private Sub cmbServerName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbServerName.SelectedIndexChanged
        cmbAuthentication.Enabled = True
    End Sub

    Sub Reset()
        txtPassword.Text = ""
        txtUserName.Text = ""
        cmbServerName.Text = ""
        cmbAuthentication.SelectedIndex = 0
        cmbInstallationType.SelectedIndex = 0
    End Sub

    Private Sub btnTestConnection_Click_1(sender As System.Object, e As System.EventArgs) Handles btnTestConnection.Click
        If cmbServerName.Text = "" Then
            MsgBox("Please select/enter Server Name", MsgBoxStyle.Information)
            cmbServerName.Focus()
            Exit Sub
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            If txtUserName.Text.Length = 0 Then
                MsgBox("please enter user name", MsgBoxStyle.Information)
                txtUserName.Focus()
                Exit Sub
            End If
            If txtPassword.Text.Length = 0 Then
                MsgBox("please enter password", MsgBoxStyle.Information)
                txtPassword.Focus()
                Exit Sub
            End If
        End If
        Cursor = Cursors.WaitCursor
        Timer5.Enabled = True
        Dim SqlConn As New SqlConnection

        If cmbAuthentication.SelectedIndex = 0 Then
            SqlConnStr = "Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True"
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            SqlConnStr = "Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True"
        End If
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.ConnectionString = SqlConnStr
            Try
                SqlConn.Open()
                MetroMessageBox.Show(Me, "Succsessfull DB Connnection", "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Invalid DB SqlConnnection" + vbCrLf + Err.Description, "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnBlankDB.Click
        DeleteApiCredentialsFile()
        Deletefirsttimerunning()

        Try
            If cmbInstallationType.SelectedIndex = 0 Then
                If cmbServerName.Text = "" Then
                    MsgBox("Please Select/Enter Server Name", MsgBoxStyle.Information)
                    cmbServerName.Focus()
                    Exit Sub
                End If
                If cmbAuthentication.SelectedIndex = 1 Then
                    If txtUserName.Text.Length = 0 Then
                        MsgBox("please enter user name", MsgBoxStyle.Information)
                        txtUserName.Focus()
                        Exit Sub
                    End If
                    If txtPassword.Text.Length = 0 Then
                        MsgBox("please enter password", MsgBoxStyle.Information)
                        txtPassword.Focus()
                        Exit Sub
                    End If
                End If
                Cursor = Cursors.WaitCursor
                Timer5.Enabled = True
                If cmbAuthentication.SelectedIndex = 0 Then
                    con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                End If
                If cmbAuthentication.SelectedIndex = 1 Then
                    con = New SqlConnection("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                End If
                con.Open()
                If (con.State = ConnectionState.Open) Then
                    If MsgBox("It will create the DB and configure the sql server, Do you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                        Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")
                            If cmbAuthentication.SelectedIndex = 0 Then
                                sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;Integrated Security=True;MultipleActiveResultSets=True")
                                sw.Close()
                            End If
                            If cmbAuthentication.SelectedIndex = 1 Then
                                sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                                sw.Close()
                            End If
                            CreateBlankDB()
                            MetroMessageBox.Show(Me, "DB has been created and SQL Server setting has been saved successfully..." & vbCrLf & "Application will be closed,Please start it again", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End
                        End Using
                    End If
                End If
            ElseIf cmbInstallationType.SelectedIndex = 1 Then
                If cmbServerName.Text = "" Then
                    MsgBox("Please Select/Enter Server Name", MsgBoxStyle.Information)
                    cmbServerName.Focus()
                    Exit Sub
                End If
                If cmbAuthentication.SelectedIndex = 1 Then
                    If txtUserName.Text.Length = 0 Then
                        MsgBox("please enter user name", MsgBoxStyle.Information)
                        txtUserName.Focus()
                        Exit Sub
                    End If
                    If txtPassword.Text.Length = 0 Then
                        MsgBox("please enter password", MsgBoxStyle.Information)
                        txtPassword.Focus()
                        Exit Sub
                    End If
                End If
                Cursor = Cursors.WaitCursor
                Timer5.Enabled = True
                If cmbAuthentication.SelectedIndex = 0 Then
                    con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                End If
                If cmbAuthentication.SelectedIndex = 1 Then
                    con = New SqlConnection("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                End If
                If MsgBox("It will configure the sql server, Do you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                    Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")
                        If cmbAuthentication.SelectedIndex = 0 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;Integrated Security=True;MultipleActiveResultSets=True")
                            sw.Close()
                        End If
                        If cmbAuthentication.SelectedIndex = 1 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                            sw.Close()
                        End If
                        MetroMessageBox.Show(Me, "SQL Server setting has been saved successfully..." & vbCrLf & "Application will be closed,Please start it again", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End
                    End Using
                End If
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Unable to connect to sql server" + vbCrLf + Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub CreateBlankDB()
        Try
            con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
            con.Open()
            Dim cb2 As String = "Select * from sysdatabases where name='DATA_PROCESSING'"
            cmd = New SqlCommand(cb2)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                con.Open()
                Dim cb1 As String = "USE Master ALTER DATABASE DATA_PROCESSING SET Single_User WITH Rollback Immediate DROP database DATA_PROCESSING"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                con.Open()
                Dim cb As String = "Create Database DATA_PROCESSING"
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DATA_PROCESSING.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(con))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            Else
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                con.Open()
                Dim cb3 As String = "Create Database DATA_PROCESSING"
                cmd = New SqlCommand(cb3)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DATA_PROCESSING.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(con))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub frmSqlServerSetting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub cmbInstallationType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbInstallationType.SelectedIndexChanged
        If cmbInstallationType.SelectedIndex = 1 Then
            cmbAuthentication.SelectedIndex = 1
            cmbAuthentication.Enabled = False
            btnTestConnection.Visible = True
            btnSearchServers.Visible = False
            btnBlankDB.Visible = False
            btnDemoDB.Text = "Save Setting"
        End If
        If cmbInstallationType.SelectedIndex = 0 Then
            cmbAuthentication.SelectedIndex = 0
            cmbAuthentication.Enabled = True
            btnTestConnection.Visible = True
            btnSearchServers.Visible = True
            'btnBlankDB.Visible = True
            btnDemoDB.Text = "Create DB and Proceed"

        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Cursor = Cursors.Default
        Timer5.Enabled = False
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSearchServers.Click
        If CheckBox1.Checked = False Then
            Try
                Cursor = Cursors.WaitCursor
                Timer5.Enabled = True
                Dim dataTable As DataTable = SmoApplication.EnumAvailableSqlServers(True)
                cmbServerName.ValueMember = "Name"
                cmbServerName.DataSource = dataTable
                Dim serverName As String = cmbServerName.SelectedValue.ToString()
                Dim server As New Server(serverName)
            Catch ex As Exception
                MetroMessageBox.Show(Me, "Sorry unable to find SQL Server instance" & vbCrLf & "If you have installed SQL Server then enter name of SQL Server instance manually", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            Try
                ' Use SqlDataSourceEnumerator to enumerate available SQL Servers
                Dim serverList As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()
                Dim servers As New List(Of String)()
                For Each row As DataRow In serverList.Rows
                    Dim serverName As String = row("ServerName").ToString()
                    Dim instanceName As String = row("InstanceName").ToString()
                    If String.IsNullOrEmpty(instanceName) Then
                        servers.Add(serverName)
                    Else
                        servers.Add(serverName & "\" & instanceName)
                    End If
                Next
                cmbServerName.DataSource = servers
            Catch ex1 As Exception
                ' Handle any exceptions here
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        DeleteApiCredentialsFile()
        Deletefirsttimerunning()
        Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")
            If cmbAuthentication.SelectedIndex = 0 Then
                sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;Integrated Security=True;MultipleActiveResultSets=True")
                sw.Close()
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=DATA_PROCESSING;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                sw.Close()
            End If

            MetroMessageBox.Show(Me, "SQL Server setting has been connected" & vbCrLf & "Application will be closed,Please start it again", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End Using
        Application.Exit()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmSqlServerSetting2.ShowDialog()
    End Sub
End Class
