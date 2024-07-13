Imports System.ComponentModel
Imports System.IO
Imports System.Data
Imports System.Security
Imports System.Security.Principal.WindowsIdentity
Imports System.Net
Imports System.Net.Dns
Imports System.Management

Public Class frmSystemInfo
    Dim hostname As String
    Dim ipaddress As String
    Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
    Dim mc As System.Management.ManagementClass
    Dim mo As ManagementObject

    Private Sub clear()
        txtProcessorName.Text = ""
        txtProcessorID.Text = ""
        txtProcessorDescription.Text = ""
        txtProcessorManufacturer.Text = ""
        txtProcessorL2CacheSize.Text = ""
        txtProcessorClockSpeed.Text = ""
        txtProcessorDataWidth.Text = ""
        txtProcessorExtClock.Text = ""
        txtProcessorFamily.Text = ""

        txtBoardDescription.Text = ""
        txtBoardManufacturer.Text = ""
        txtBoardName.Text = ""
        txtBoardSerialNumber.Text = ""

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
    End Sub
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
        Timer1.Enabled = True
        Try
            Dim i As System.Management.ManagementObject
            Dim searchInfo_Processor As New System.Management.ManagementObjectSearcher("Select * from Win32_Processor")
            For Each i In searchInfo_Processor.Get()
                txtProcessorName.Text = i("Name").ToString
                txtProcessorID.Text = i("ProcessorID").ToString
                txtProcessorDescription.Text = i("Description").ToString
                txtProcessorManufacturer.Text = i("Manufacturer").ToString
                txtProcessorL2CacheSize.Text = i("L2CacheSize").ToString
                txtProcessorClockSpeed.Text = i("CurrentClockSpeed").ToString & " Mhz"
                txtProcessorDataWidth.Text = i("DataWidth").ToString
                txtProcessorExtClock.Text = i("ExtClock").ToString & " Mhz"
                txtProcessorFamily.Text = i("Family").ToString
            Next
            Dim searchInfo_Board As New System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard")
            For Each i In searchInfo_Board.Get()
                txtBoardDescription.Text = i("Description").ToString
                txtBoardManufacturer.Text = i("Manufacturer").ToString
                txtBoardName.Text = i("Name").ToString
                txtBoardSerialNumber.Text = i("SerialNumber").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try

        Try
            ipaddress = (CType(h.AddressList.GetValue(0), Net.IPAddress).ToString)
            hostname = Dns.GetHostName()
            TextBox9.Text = ipaddress
            TextBox1.Text = hostname
            TextBox2.Text = Environment.UserName
            mc = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            For Each mo In moc
                If mo.Item("IPEnabled") = True Then
                    TextBox11.Text = mo.Item("MacAddress")
                End If
            Next
            TextBox10.Text = GetPublicIP().ToString()
        Catch ex As Exception

        End Try
        TextBox3.Text = My.Computer.Info.AvailablePhysicalMemory
        TextBox4.Text = My.Computer.Info.TotalPhysicalMemory
        TextBox5.Text = My.Computer.Info.OSFullName
        TextBox6.Text = My.Computer.Info.OSPlatform
        TextBox7.Text = My.Computer.Info.OSVersion
        TextBox8.Text = My.Computer.Screen.WorkingArea.ToString
        TextBox3.Text = TextBox3.Text & " KB"
        TextBox4.Text = TextBox4.Text & " KB"
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox12.Text = Date.Now.ToString("dd-MMM-yyyy | hh:mm:ss tt | dddd")
    End Sub
    Public Function GetPublicIP() As String
        Dim direction As [String] = ""
        Dim request As WebRequest = WebRequest.Create("http://checkip.dyndns.org/")
        Using response As WebResponse = request.GetResponse()
            Using stream As New StreamReader(response.GetResponseStream())
                direction = stream.ReadToEnd()
            End Using
        End Using

        'Search for the ip in the html
        Dim first As Integer = direction.IndexOf("Address: ") + 9
        Dim last As Integer = direction.LastIndexOf("</body>")
        direction = direction.Substring(first, last - first)

        Return direction
    End Function

    Private Sub SaveToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToFileToolStripMenuItem.Click
        Try
            Dim fs As New FileStream("temp.txt", FileMode.Create, FileAccess.Write)
            Dim w As New StreamWriter(fs)
            w.Write("****** Processor Information ******")
            w.WriteLine()
            w.WriteLine()
            w.WriteLine("Name")
            w.WriteLine(txtProcessorName.Text)
            w.WriteLine()
            w.WriteLine("ID")
            w.WriteLine(txtProcessorID.Text)
            w.WriteLine()
            w.WriteLine("Description")
            w.WriteLine(txtProcessorDescription.Text)
            w.WriteLine()
            w.WriteLine("Manufacturer")
            w.WriteLine(txtProcessorManufacturer.Text)
            w.WriteLine()
            w.WriteLine("L2 Cache Size")
            w.WriteLine(txtProcessorL2CacheSize.Text)
            w.WriteLine()
            w.WriteLine("Clock Speed")
            w.WriteLine(txtProcessorClockSpeed.Text)
            w.WriteLine()
            w.WriteLine("Data Width")
            w.WriteLine(txtProcessorDataWidth.Text)
            w.WriteLine()
            w.WriteLine("Ext Clock")
            w.WriteLine(txtProcessorExtClock.Text)
            w.WriteLine()
            w.WriteLine("Family")
            w.WriteLine(txtProcessorFamily.Text)
            w.WriteLine()
            w.WriteLine("****** MotherBoard Information *****")
            w.WriteLine()
            w.WriteLine("Name")
            w.WriteLine(txtBoardDescription.Text)
            w.WriteLine()
            w.WriteLine("Manufacturer")
            w.WriteLine(txtBoardManufacturer.Text)
            w.WriteLine()
            w.WriteLine("Description")
            w.WriteLine(txtBoardDescription.Text)
            w.WriteLine()
            w.WriteLine("Serial Number")
            w.WriteLine(txtBoardSerialNumber.Text)
            w.WriteLine()
            w.WriteLine("****** My PC *****")
            w.WriteLine()
            w.WriteLine("Computer Name")
            w.WriteLine(TextBox1.Text)
            w.WriteLine()
            w.WriteLine("User Name")
            w.WriteLine(TextBox2.Text)
            w.WriteLine()
            w.WriteLine("RAM Avail Memory")
            w.WriteLine(TextBox3.Text)
            w.WriteLine()
            w.WriteLine("RAM Full Memory")
            w.WriteLine(TextBox4.Text)
            w.WriteLine()
            w.WriteLine("Operating System")
            w.WriteLine(TextBox5.Text)
            w.WriteLine()
            w.WriteLine("Platform")
            w.WriteLine(TextBox6.Text)
            w.WriteLine()
            w.WriteLine("Version")
            w.WriteLine(TextBox7.Text)
            w.WriteLine()
            w.WriteLine("Screen Resolution")
            w.WriteLine(TextBox8.Text)
            w.WriteLine()
            w.WriteLine("Local IP Address")
            w.WriteLine(TextBox9.Text)
            w.WriteLine()
            w.WriteLine("Online IP Address")
            w.WriteLine(TextBox10.Text)
            w.WriteLine()
            w.WriteLine("MAC Address")
            w.WriteLine(TextBox11.Text)
            w.WriteLine()
            w.WriteLine("Date / Time")
            w.WriteLine(TextBox12.Text)
            w.WriteLine()
            w.Flush()
            w.Close()
            With SaveFileDialog1
                .AddExtension = True
                .OverwritePrompt = True
                .DefaultExt = "txt"
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .FileName = "SystemInfo"
                .Filter = "Text files (*.txt)|*.txt|All files|*.*"
                .FilterIndex = 1
                .Title = "SystemInfo - Save file"
                If .ShowDialog() = DialogResult.OK Then
                    My.Computer.FileSystem.MoveFile("temp.txt", .FileName, True)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    Private Sub frmSystemInfo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
