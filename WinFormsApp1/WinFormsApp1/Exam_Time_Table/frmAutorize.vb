Imports System.Data.SqlClient

Public Class frmAutorize
    Dim sign_Indicator As Integer = 0
    Dim variable1 As Double
    Dim variable2 As Double
    Dim fl As Boolean = False
    Dim s, x As String

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

    Private Sub btnTA2_Click(sender As Object, e As EventArgs) Handles btnTA2.Click
        GetNumerpadValue(2)
    End Sub

    Private Sub btnTA3_Click(sender As Object, e As EventArgs) Handles btnTA3.Click
        GetNumerpadValue(3)
    End Sub

    Private Sub btnTA4_Click(sender As Object, e As EventArgs) Handles btnTA4.Click
        GetNumerpadValue(4)
    End Sub

    Private Sub btnTA5_Click(sender As Object, e As EventArgs) Handles btnTA5.Click
        GetNumerpadValue(5)
    End Sub

    Private Sub btnTA6_Click(sender As Object, e As EventArgs) Handles btnTA6.Click
        GetNumerpadValue(6)
    End Sub

    Private Sub btnTA7_Click(sender As Object, e As EventArgs) Handles btnTA7.Click
        GetNumerpadValue(7)
    End Sub

    Private Sub btnTA8_Click(sender As Object, e As EventArgs) Handles btnTA8.Click
        GetNumerpadValue(8)
    End Sub

    Private Sub btnTA9_Click(sender As Object, e As EventArgs) Handles btnTA9.Click
        GetNumerpadValue(9)
    End Sub

    Private Sub btnTA0_Click(sender As Object, e As EventArgs) Handles btnTA0.Click
        GetNumerpadValue(0)
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
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

    Private Sub btnTA1_Click(sender As Object, e As EventArgs) Handles btnTA1.Click
        GetNumerpadValue(1)
    End Sub

    Private Sub Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Password.KeyDown
        'If cmbLoginType.SelectedIndex = 1 Then
        '    If e.KeyCode = Keys.Enter Then
        '        Validate()
        '    End If
        'End If
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        If cmbLoginType.SelectedIndex = 0 Then
            If Password.Text.Length = 4 Then
                logged = Validate()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub frmAutorize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Width = Me.Width
        cmbLoginType.SelectedIndex = 0
    End Sub

    Private Sub frmAutorize_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Password.Focus()
    End Sub

    Private Sub btnScanCard_Click(sender As Object, e As EventArgs) Handles btnScanCard.Click
        Me.Dispose()
    End Sub

    Public Function Validate() As Boolean
        Dim AccessGranted As Boolean = False
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT RTRIM(UserID),RTRIM(Password),RTRIM(UserType) FROM Registration where Password=@d1 and Active='Yes'"
            cmd.Parameters.AddWithValue("@d1", Encrypt(Password.Text))
            rdr = cmd.ExecuteReader()
            If rdr.HasRows Then
                AccessGranted = True
            Else
                MessageBox.Show(Me, "Invalid PIN, Please try again", "HavanoPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                AccessGranted = False
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return AccessGranted
        Me.Dispose()
    End Function
End Class