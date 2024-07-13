Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports MetroFramework
Imports Newtonsoft.Json
Imports RevmaxAPI
Imports WK.Libraries.TrialMakerNS
Imports WK.Libraries.TrialMakerNS.Models
Imports WinFormsApp1.posclass
Imports System.Net.Http

Imports System.Text
Imports System.Threading.Tasks
Imports System.Net
Public Class frmLogin
    Public frmpmenu As New frmBackOffice
    Dim frm As New frmOption
    Dim sign_Indicator As Integer = 0
    Public CLICKED As Integer = 0
    Dim variable1 As Double
    Dim variable2 As Double
    Dim fl As Boolean = False
    Dim s, x As String
    '   Private Shared tm As New TrialMaker()
    Dim allowBackOffice As String = "No"
    Dim vatFlag As String = ""
    Dim DriveLabel As String = ""
    Dim vatA As String = ""
    Dim vatB As String = ""
    Dim vatC As String = ""
    Dim vatD As String = ""
    Dim vatE As String = ""
    Dim vatF As String = ""
    Dim taxRate As Double = 0.0
    Public flogin As Boolean
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click, GelButton1.Click
        'frmCustomDialog8X.ShowDialog()
        Automatically_BackUp()
        End
    End Sub
    Public Sub Automatically_BackUp()
        Dim backupDir As String = "C:\posbck"
        If Not Directory.Exists(backupDir) Then
            Directory.CreateDirectory(backupDir)
        End If
        Dim backupFileName As String = "WinFormsApp1_DB_" & DateTime.Now.ToString("yyyy-MM") & ".bak"
        Dim backupFilePath As String = Path.Combine(backupDir, backupFileName)
        If File.Exists(backupFilePath) Then
            File.Delete(backupFilePath)
        End If
        Cursor = Cursors.WaitCursor
        Timer2.Enabled = True
        SqlConnection.ClearAllPools()
        Using con As New SqlConnection(cs)
            con.Open()
            Dim backupQuery As String = "BACKUP DATABASE WinFormsApp1_DB TO DISK='" & backupFilePath & "' WITH INIT, STATS=10"
            Using cmd As New SqlCommand(backupQuery, con)
                cmd.CommandTimeout = 0
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Cursor = Cursors.Default
        'MessageBox.Show("Backup Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Private Async Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        ' Await AddProductAsync()
        'Panel1.Location = New Point(Me.ClientSize.Width / 2 - Panel1.Size.Width / 2, Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
        'Panel1.Anchor = AnchorStyles.None
        Panel2.Width = Me.Width
        cmbLoginType.SelectedIndex = 0
        'Dim result As Boolean = HandleRegistry()
        'If result = False Then 'something went wrong
        '    MessageBox.Show("Trial expired" & vbCrLf & "for purchasing the full version of software call us at +919827858191", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End

        ReadConfigurations()

    End Sub

    Public Function IsRevMaxEnabled() As Boolean
        Dim isRev As Boolean = False

        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd = New SqlCommand("select EnableRevMax from Company", con)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                isRev = Convert.ToBoolean(rdr.GetValue(0).ToString())
            End If
            con.Close()
            Return isRev
        Catch ex As Exception
            Return isRev
        End Try
        Return isRev

    End Function
    Private Sub frmLogin_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Sub GetNumerpadValue(ByVal a As Integer)
        If cmbLoginType.SelectedIndex = 0 Then
            If Password.Text = "ENTER PIN" Then
                Password.Text = ""
            End If
            Password.PasswordChar = "•"
            If sign_Indicator = 0 Then
                Password.Text = Password.Text + Convert.ToString(a)
            ElseIf sign_Indicator = 1 Then
                Password.Text = Convert.ToString(a)
                sign_Indicator = 0
            End If
            fl = True
        End If
    End Sub
    Private Sub btnTA0_Click(sender As System.Object, e As System.EventArgs) Handles btnTA0.Click
        GetNumerpadValue(0)
    End Sub
    Private Sub btnX_Click(sender As System.Object, e As System.EventArgs) Handles btnX.Click
        If Password.Text = "ENTER PIN" Then
            Password.Text = ""
        End If
        If Password.Text = "SCAN CARD" Then
            Password.Text = ""
        End If
        s = Password.Text
        Dim l As Integer = s.Length
        For i As Integer = 0 To l - 2
            x += s(i)
        Next
        Password.Text = x
        x = ""
    End Sub
    Private Sub btnTA9_Click(sender As System.Object, e As System.EventArgs) Handles btnTA9.Click
        GetNumerpadValue(9)
    End Sub
    Private Sub btnTA8_Click(sender As System.Object, e As System.EventArgs) Handles btnTA8.Click
        GetNumerpadValue(8)
    End Sub
    Private Sub btnTA7_Click(sender As System.Object, e As System.EventArgs) Handles btnTA7.Click
        GetNumerpadValue(7)
    End Sub
    Private Sub btnTA6_Click(sender As System.Object, e As System.EventArgs) Handles btnTA6.Click
        GetNumerpadValue(6)
    End Sub
    Private Sub btnTA5_Click(sender As System.Object, e As System.EventArgs) Handles btnTA5.Click
        GetNumerpadValue(5)
    End Sub
    Private Sub btnTA4_Click(sender As System.Object, e As System.EventArgs) Handles btnTA4.Click
        GetNumerpadValue(4)
    End Sub
    Private Sub btnTA3_Click(sender As System.Object, e As System.EventArgs) Handles btnTA3.Click
        GetNumerpadValue(3)
    End Sub
    Private Sub btnTA2_Click(sender As System.Object, e As System.EventArgs) Handles btnTA2.Click
        GetNumerpadValue(2)
    End Sub
    Private Sub btnTA1_Click(sender As System.Object, e As System.EventArgs) Handles btnTA1.Click
        GetNumerpadValue(1)
    End Sub
    Private Sub OK_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnScanCard.MouseHover
        btnScanCard.BackColor = Color.Yellow
    End Sub
    Private Sub OK_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnScanCard.MouseLeave
        btnScanCard.BackColor = Color.Transparent
    End Sub
    Private Sub Cancel_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCancel.MouseHover
        btnCancel.BackColor = Color.Red
    End Sub
    Private Sub Cancel_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = Color.Transparent
    End Sub
    Private Sub btnForgetPassword_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnForgetPassword.MouseHover
        btnForgetPassword.BackColor = Color.Blue
    End Sub
    Private Sub btnForgetPassword_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnForgetPassword.MouseLeave
        btnForgetPassword.BackColor = Color.Transparent
    End Sub

    Private Sub Password_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Password.KeyPress
        If cmbLoginType.SelectedIndex = 0 Then
            If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
                e.Handled = True
            End If
            If Password.Text = "ENTER PIN" Then
                Password.Text = ""
            End If
            Password.PasswordChar = "•"
        End If

        If cmbLoginType.SelectedIndex = 1 Then
            If Password.Text = "SCAN CARD" Then
                Password.Text = ""
            End If
            Password.PasswordChar = "•"
        End If
    End Sub
    Sub GetCardData()
        con = New SqlConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT RTRIM(UserID),RTRIM(Password),RTRIM(UserType) FROM Registration where CardNo=@d1 and Active='Yes'"
        cmd.Parameters.AddWithValue("@d1", Password.Text.Replace(";", "").Replace("?", "").Replace("%", ""))
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            UserID.Text = rdr.GetValue(0).ToString()
            UserType.Text = rdr.GetValue(2).ToString()
        Else
            btnScanCard.PerformClick()
        End If
        con.Close()
    End Sub

    Function updatefirst_timer_login()
        Dim con As New SqlConnection(cs)
        con.Open()
        Dim cmd As New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = "UPDATE REGISTRATION SET flogin = @flogin WHERE userid = @userid"
        cmd.Parameters.AddWithValue("@flogin", False)
        cmd.Parameters.AddWithValue("@userid", UserID.Text)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
        con.Close()
        Return rowsAffected
    End Function

    Private Sub Password_TextChanged(sender As System.Object, e As System.EventArgs) Handles Password.TextChanged
        '  And CLICKED < 9

        If (errorex.Length > 0 And CLICKED < 9) And ((Password.Text.Length = 4) Or cmbLoginType.SelectedIndex = 1) Then
            MessageBox.Show(errorex, "License Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Password.Clear()
            Return
        End If
        If cmbLoginType.SelectedIndex = 0 Then
            If Password.Text.Length = 4 Then
                GetData()
            End If
        End If
        If cmbLoginType.SelectedIndex = 1 Then
            If Password.Text.Contains("?") Then
                GetCardData()
            End If
        End If
        If CLICKED > 9 Then
            expiry_status = False
        End If
    End Sub
    Sub GetData()
        '  Try
        con = New SqlConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandText = "SELECT RTRIM(UserID),RTRIM(Password),RTRIM(UserType),flogin FROM Registration where Password=@d1 And Active='Yes'"
        cmd.Parameters.AddWithValue("@d1", EncryptToBase64(Password.Text))
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            UserID.Text = rdr.GetValue(0).ToString()
            useronpc = rdr.GetValue(0).ToString()
            UserType.Text = rdr.GetValue(2).ToString()
            usertypeonpc = False
            frmBackOffice.lblUser.Text = rdr.GetValue(2).ToString()



        Else
            Password.PasswordChar = ""
            Password.Text = "ENTER PIN"
        End If
        cmd.Dispose()
        con.Close()
        '       MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '  End Catch ex As Exception
        ' Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        frmAbout.ShowDialog()
    End Sub

    Sub CheckFirstTimeClockIn(ByVal User As String)
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT * from ClockIN where UserID=@d1"
            cmd.Parameters.AddWithValue("@d1", User)
            rdr = cmd.ExecuteReader()
            If Not rdr.Read() Then
                ClockINSave(User)
            End If
            If (rdr IsNot Nothing) Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        lblDate.Text = System.DateTime.Now.ToString("dddd, dd MMMM yyyy")
        lblTime.Text = System.DateTime.Now.ToString("hh:mm:ss tt")
    End Sub



    Private Sub cmbLoginType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbLoginType.SelectedIndexChanged
        If cmbLoginType.SelectedIndex = 0 Then
            Password.PasswordChar = ""
            Password.Text = "ENTER PIN"
            Password.Focus()
        End If
        If cmbLoginType.SelectedIndex = 1 Then
            Password.PasswordChar = ""
            Password.Text = "SCAN CARD"
            Password.Focus()
        End If
    End Sub

    Private Sub btnScanCard_Click(sender As System.Object, e As System.EventArgs) Handles btnScanCard.Click
        cmbLoginType.SelectedIndex = 1
        If cmbLoginType.SelectedIndex = 1 Then
            Password.PasswordChar = ""
            Password.Text = "SCAN CARD"
            Password.Focus()
        End If
    End Sub
    Private Sub frmLogin_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Password.Focus()
    End Sub


    Private Sub Password_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Password.KeyDown
        If cmbLoginType.SelectedIndex = 1 Then
            If e.KeyCode = Keys.Enter Then
                GetCardData()
            End If
        End If
    End Sub

    Dim errorex As String = ""


    Public Function GetDaySuffix(ByVal day As Integer) As String
        Select Case day
            Case 1, 21, 31
                Return "st"
            Case 2, 22
                Return "nd"
            Case 3, 23
                Return "rd"
            Case Else
                Return "th"
        End Select
    End Function

    Private Sub btnReconnect_Click(sender As Object, e As EventArgs) Handles btnReconnect.Click
        Me.Dispose()
        frmSqlServerSetting.ShowDialog()
    End Sub



    Sub IntCulturalFormattingChanges()
        Dim cultureInfo As CultureInfo = DirectCast(Thread.CurrentThread.CurrentCulture.Clone(), CultureInfo)
        cultureInfo.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Thread.CurrentThread.CurrentCulture = cultureInfo
    End Sub

    Public Sub ReadConfigurations()
        Dim drives As DriveInfo() = DriveInfo.GetDrives()
        Dim path As String = ""
        For Each driveInfo As DriveInfo In drives
            Try
                If driveInfo.VolumeLabel.Equals("REVMAX") Then
                    DriveLabel = driveInfo.Name.Substring(0, 1)
                End If
                If driveInfo.VolumeLabel.Equals("SWISSBIT") Then
                    DriveLabel = driveInfo.Name.Substring(0, 1)
                End If
            Catch
            End Try
        Next

        If File.Exists(DriveLabel & ":\config.ini") Then
            path = DriveLabel & ":\config.ini"
        ElseIf File.Exists("config.ini") Then
            path = "config.ini"
        End If
        If path.Trim().Length <= 5 Then
            Return
        End If

        Try
            For Each readAllLine As String In File.ReadAllLines(path)
                Select Case True
                    Case readAllLine.Contains("VatFlag:")
                        vatFlag = readAllLine.Substring(readAllLine.LastIndexOf(":") + 1, readAllLine.Length - (readAllLine.LastIndexOf(":") + 1))
                        Try
                            Dim num As Double = 0.0
                            num = Double.Parse(vatFlag) * 1.0
                        Catch ex As Exception
                            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
                        End Try
                    Case readAllLine.Contains("VatA:")
                        vatA = readAllLine.Substring(readAllLine.LastIndexOf(":") + 1, readAllLine.Length - (readAllLine.LastIndexOf(":") + 1))
                        Try
                            Dim num As Double = 0.0
                            num = Double.Parse(vatA) * 1.0
                        Catch ex As Exception
                            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
                        End Try
                    Case readAllLine.Contains("VatB:")
                        vatB = readAllLine.Substring(readAllLine.LastIndexOf(":") + 1, readAllLine.Length - (readAllLine.LastIndexOf(":") + 1))
                        Try
                            Dim num As Double = 0.0
                            num = Double.Parse(vatB) * 1.0
                        Catch ex As Exception
                            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
                        End Try
                    Case readAllLine.Contains("VatC:")
                        vatC = readAllLine.Substring(readAllLine.LastIndexOf(":") + 1, readAllLine.Length - (readAllLine.LastIndexOf(":") + 1))
                        Try
                            Dim num As Double = 0.0
                            num = Double.Parse(vatC) * 1.0
                        Catch ex As Exception
                            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
                        End Try
                    Case readAllLine.Contains("VatD:")
                        vatD = readAllLine.Substring(readAllLine.LastIndexOf(":") + 1, readAllLine.Length - (readAllLine.LastIndexOf(":") + 1))
                        Try
                            Dim num As Double = 0.0
                            num = Double.Parse(vatD) * 1.0
                        Catch ex As Exception
                            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
                        End Try
                    Case readAllLine.Contains("VatE:")
                        vatE = readAllLine.Substring(readAllLine.LastIndexOf(":") + 1, readAllLine.Length - (readAllLine.LastIndexOf(":") + 1))
                        Try
                            Dim num As Double = 0.0
                            num = Double.Parse(vatE) * 1.0
                        Catch ex As Exception
                            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
                        End Try
                    Case readAllLine.Contains("VatF:")
                        vatF = readAllLine.Substring(readAllLine.LastIndexOf(":") + 1, readAllLine.Length - (readAllLine.LastIndexOf(":") + 1))
                        Try
                            Dim num As Double = 0.0
                            num = Double.Parse(vatF) * 1.0
                        Catch ex As Exception
                            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
                        End Try
                End Select
            Next

            If taxRate <> Double.Parse(vatA) AndAlso taxRate <> Double.Parse(vatB) AndAlso taxRate <> Double.Parse(vatC) AndAlso taxRate <> Double.Parse(vatD) AndAlso taxRate <> Double.Parse(vatE) AndAlso taxRate <> Double.Parse(vatF) Then
                Dim num1 As Integer = MessageBox.Show("Invalid TAX Rate on Item")
            End If
        Catch ex As Exception
            Dim num As Integer = MessageBox.Show("Failed to Read Tax Configuration: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEndDay_Click(sender As Object, e As EventArgs)
        Try
            'Dim revmax As New Revmaxlib()
            Dim revresponse As String = revmax.ZReport()
            Dim revMsg As ZRoot = JsonConvert.DeserializeObject(Of ZRoot)(revresponse)
            MessageBox.Show(Me, revMsg.Message, "D", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Panel3_Click(sender As Object, e As EventArgs)
        ' CLICKED += 1
        If CLICKED >= 9 Then
            LinkLabel1.Visible = True
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub OnTimeTrackerRunning(ByVal sender As Object, ByVal e As TrialMaker.TimeTrackingEventArgs)
        If Focused Then
            e.Continue()
            'lblTimerStatus.Text = e.TimeSpan.ToString("hh\:mm\:ss")
        Else
            e.Pause()
        End If
    End Sub
End Class
Public Class HEADER
    Public LINE As String()
End Class

Public Class TOTALS
    Public DAILYTOTALAMOUNT As String
    Public GROSS As String
    Public CORRECTIONS As String
    Public DISCOUNTS As String
    Public SURCHARGES As String
    Public TICKETSVOID As String
    Public TICKETSVOIDTOTAL As String
    Public TICKETSFISCAL As String
    Public TICKETSNONFISCAL As String
End Class

Public Class VATTOTAL
    Public VATRATE As String
    Public NETTAMOUNT As String
    Public TAXAMOUNT As String
End Class

Public Class ZREPORT
    Public Signature As String
    Public [DATE] As String
    Public TIME As String
    Public HEADER As HEADER
    Public VATNUM As String
    Public BPNUM As String
    Public TAXOFFICE As String
    Public Znumber As String
    Public EFDSERIAL As String
    Public REGISTRATIONDATE As String
    Public USER As String
    Public CURRENCY As String
    Public TOTALS As TOTALS
    Public VATTOTALS As VATTOTAL()
End Class



Public Class ZRoot
    Public Code As String
    Public Message As String
    Public QRcode As String
    Public VerificationCode As String
    Public VerificationLink As String
    Public DeviceID As String
    Public FiscalDay As String
    Public Data As Data
End Class


