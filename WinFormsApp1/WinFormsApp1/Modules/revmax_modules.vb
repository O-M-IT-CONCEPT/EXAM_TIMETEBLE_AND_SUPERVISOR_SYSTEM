Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Module revmax_modules

    Public Function IsRevMaxEnabled() As Boolean
        Dim isRev As Boolean = False
        con = New SqlConnection(cs)
        con.Open()
        cmd = con.CreateCommand()
        cmd = New SqlCommand("select EnableRevMax from Company", con)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            If Boolean.TryParse(rdr.GetValue(0).ToString(), isRev) Then
                isRev = Convert.ToBoolean(rdr.GetValue(0).ToString())
            End If
        End If
        con.Close()
        Return isRev
    End Function
    Public Function IsHavanoZimraEnabled() As Boolean
        Dim isHZimra As Boolean = False

        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd = New SqlCommand("select Ishavanozimra from Company", con)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                isHZimra = Convert.ToBoolean(rdr.GetValue(0).ToString())
            End If
            con.Close()
            Return isHZimra
        Catch ex As Exception
            Return isHZimra
        End Try
        Return isHZimra

    End Function

    Public Sub SendMail(ByVal s1 As String, ByVal s2 As String, ByVal s3 As String, ByVal s5 As String, ByVal s6 As String, ByVal s7 As Integer, ByVal s8 As String, ByVal s9 As String)
        Dim msg As New MailMessage()
        Try
            msg.From = New MailAddress(s1)
            msg.[To].Add(s2)
            msg.Body = s3
            msg.IsBodyHtml = True
            msg.Subject = s5
            Dim smt As New SmtpClient(s6)
            smt.Port = s7
            smt.Credentials = New NetworkCredential(s8, s9)
            smt.EnableSsl = True
            smt.Send(msg)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SendMail1(ByVal s1 As String, ByVal s2 As String, ByVal s3 As String, ByVal s4 As String, ByVal s5 As String, ByVal s6 As String, ByVal s7 As Integer, ByVal s8 As String, ByVal s9 As String)
        Dim msg As New MailMessage()
        Try
            msg.From = New MailAddress(s1)
            msg.[To].Add(s2)
            msg.Body = s3
            msg.Attachments.Add(New Attachment(s4))
            msg.IsBodyHtml = True
            msg.Subject = s5
            Dim smt As New SmtpClient(s6)
            smt.Port = s7
            smt.Credentials = New NetworkCredential(s8, s9)
            smt.EnableSsl = True
            smt.Send(msg)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function IsConnectionAvailable() As Boolean
        Dim objUrl As New System.Uri("http://www.google.com")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objresp As System.Net.WebResponse

        Try
            objresp = objWebReq.GetResponse
            objresp.Close()
            objresp = Nothing
            Return True

        Catch ex As Exception
            objresp = Nothing
            objWebReq = Nothing
            Return False
        End Try
    End Function


    Sub SMSFunc(ByVal st1 As String, ByVal st2 As String, ByVal st3 As String)
        st3 = st3.Replace("@MobileNo", st1).Replace("@Message", st2)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim myUri As New Uri(st3)
        request = DirectCast(WebRequest.Create(myUri), HttpWebRequest)
        response = DirectCast(request.GetResponse(), HttpWebResponse)
    End Sub

End Module
