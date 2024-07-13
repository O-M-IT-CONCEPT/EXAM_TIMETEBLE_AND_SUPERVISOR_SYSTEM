Imports System.Data.SqlClient
Public Class frmSplash


    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        ' Try
        Label3.Visible = Not Label3.Visible

        If System.IO.File.Exists(Application.StartupPath & "\SQLSettings.dat") Then
            If txtActivationID.Text = TextBox1.Text Then
                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 20) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 40) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 60) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 80) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 100) Then

                    Timer2.Enabled = False
                    Me.Hide()
                    frmLogin.Show()
                End If
            End If
        Else

            ProgressBar1.Value = ProgressBar1.Value + 2
            If (ProgressBar1.Value = 10) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 20) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 40) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 60) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 80) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 100) Then
                frmSqlServerSetting.Reset()
                frmSqlServerSetting.Show()
                Timer2.Enabled = False
                Me.Hide()
            End If
        End If
        If System.IO.File.Exists(Application.StartupPath & "\SQLSettings.dat") Then
            If txtActivationID.Text <> TextBox1.Text Then

                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 20) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 40) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 60) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 80) Then
                    Label3.Text = "Loading..."
                ElseIf (ProgressBar1.Value = 100) Then
                    ' MsgBox("Here")
                    Timer2.Enabled = False
                    Timer2.Stop()
                    'frmActivation.Show()
                    Timer2.Enabled = False
                    Me.Hide()
                End If
            End If
        Else

            ProgressBar1.Value = ProgressBar1.Value + 2
            If (ProgressBar1.Value = 10) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 20) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 40) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 60) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 80) Then
                Label3.Text = "Loading..."
            ElseIf (ProgressBar1.Value = 100) Then
                frmSqlServerSetting.Dispose()
                frmSqlServerSetting.Show()
                Timer2.Enabled = False
                Me.Hide()
            End If
        End If
        'Catch ex As Exception
        '   MsgBox(ex.Message & " hgjhgj", MsgBoxStyle.Critical, "Error!")
        ' End Try
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Panel1.Location = New Point(Me.ClientSize.Width / 2 - Panel1.Size.Width / 2, Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
            Panel1.Anchor = AnchorStyles.None
            If System.IO.File.Exists(Application.StartupPath & "\SQLSettings.dat") Then

                'txtCPU_ID.Text = key.GetSystemKey()


                '    con = New SqlConnection(cs)
                '    con.Open()
                '    Dim ct As String = "select RTRIM(ActivationID) from Activation where HardwareID=@d1"
                '    cmd = New SqlCommand(ct)
                '    cmd.Connection = con
                '    cmd.Parameters.AddWithValue("@d1", txtCPU_ID.Text)
                '    rdr = cmd.ExecuteReader()
                '    If rdr.Read() Then
                '        Dim lic = TrialMaker.Instance.Activate(rdr.GetValue(0))
                '        If lic.Status = LicenseStatus.Invalid Then
                '            Dim errors As String = String.Join($"{vbCrLf}", TrialMaker.Instance.ValidationErrors)
                '            MessageBox.Show($"The license is invalid.{vbCrLf}{vbCrLf}Errors:{vbCrLf}{errors}")
                '            Me.Hide()
                '            frmActivation.ShowDialog()
                '            Timer2.Stop()
                '            Timer2.Enabled = False
                '            Return
                '        Else
                '            'MessageBox.Show(
                '            '$"Thank you {lic.Client} for purchasing {lic.Product}!{vbCrLf}" +
                '            '$"Here is your license information:{vbCrLf}{vbCrLf}" +
                '            '$" * Product: {lic.Product}{vbCrLf}" +
                '            '$" * License Type: {lic.Type}{vbCrLf}" +
                '            '$" * License Key: {lic.LicenseKey}{vbCrLf}" +
                '            '$" * License Status: {lic.Status}{vbCrLf}" +
                '            '$" * Activation Date: {lic.ActivationDate}{vbCrLf}",
                '            '"Premium License Activated")
                '            Me.Hide()
                '            Timer2.Stop()
                '            Timer2.Enabled = False
                '            frmActivation.ShowDialog()

                '            Close()
                '        End If

                '        'Dim check_status As SystemVarible = key.CheckValidLicKey(rdr.GetValue(0), txtCPU_ID.Text, EncryptionPassword)
                '        'If (check_status.IsValidate = True) And (check_status.EndDate <= Now.Date.ToShortDateString) Then
                '        '    MessageBox.Show(Me, "Your Activation key has expired. Please contact software provider for buying full licence", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '        '    Me.Hide()
                '        '    frmActivation.ShowDialog()
                '        '    Timer2.Stop()
                '        '    Timer2.Enabled = False
                '        '    Return
                '        'End If

                '        'If check_status.IsValidate = False Then
                '        '    MessageBox.Show(Me, "Your Activation key is invalid. Please contact software provider for buying full licence", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '        '    Me.Hide()
                '        '    Timer2.Stop()
                '        '    Timer2.Enabled = False
                '        '    frmActivation.ShowDialog()
                '        'End If
                '    Else
                '        Me.Hide()
                '        Timer2.Stop()
                '        Timer2.Enabled = False
                '        frmActivation.ShowDialog()
                '    End If
                '    Timer2.Enabled = True
            End If
            Timer2.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub


End Class