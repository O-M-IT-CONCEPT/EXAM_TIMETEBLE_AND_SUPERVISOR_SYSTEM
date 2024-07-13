Imports System.Data.SqlClient
Public Class frmOption
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnFrontOffice.Click

        con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT Top 1 OpenID,RTRIM(TillDetails) FROM POS_OpeningCash,Registration where POS_OpeningCash.UserID=Registration.UserID and Registration.UserID=@d1 and TillDetails=@d2 and Closed=0 order by OpenID desc"
            cmd.Parameters.AddWithValue("@d1", lblUser.Text)
            cmd.Parameters.AddWithValue("@d2", System.Net.Dns.GetHostName)
            Dim rdr1 As SqlDataReader = cmd.ExecuteReader()
            If rdr1.Read() Then
                If IsOpenSettle(System.Net.Dns.GetHostName) = "Layout 2" Then
                    Me.Hide()
                    Dim st As String = "Successfully logged in"
                    LogFunc(lblUser.Text, st)


            End If


        End If
            con.Close()

    End Sub

    Private Sub btnBackOffice_Click(sender As System.Object, e As System.EventArgs) Handles btnBackOffice.Click
        frmBackOffice.lblUser.Text = lblUser.Text
        frmBackOffice.txtOpenID.Text = ""
        If IsViewAllowed(lblUser.Text, "Barcode Label Printing") = True Then
            ' frmBackOffice.BarcodeLabelsToolStripMenuItem.Enabled = True
            ' frmBackOffice.rbtnBLP.Enabled = True
        Else
            'frmBackOffice.BarcodeLabelsToolStripMenuItem.Enabled = False
            ' frmBackOffice.rbtnBLP.Enabled = False
        End If
        Me.Hide()
        frmBackOffice.Show()
    End Sub

    Private Sub frmOption_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If expiry_status = True Then
            btnBackOffice.Enabled = False
            MsgBox("License Expired ", vbInformation + vbOKOnly, "License Expired")
        End If

        BackColor = Color.Coral
        TransparencyKey = BackColor
        If frmLogin.CLICKED >= 9 Then
            btnBackOffice.Enabled = True
        End If
    End Sub



    Private Sub frmOption_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        frmLogin.Automatically_BackUp()
        End
    End Sub

    Private Sub btnFrontOffice_ClickButtonArea(Sender As Object, e As MouseEventArgs) Handles btnFrontOffice.ClickButtonArea

    End Sub
End Class