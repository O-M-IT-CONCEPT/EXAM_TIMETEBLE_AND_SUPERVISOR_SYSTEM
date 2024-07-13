Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Public Class frmBackOffice
    Dim Filename As String
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Sub SetR()

        If screenWidth <= 1024 Then
            'Do Nothing
        Else
            '    TableLayoutPanel2.Location = New Point(Me.ClientSize.Width / 2 - TableLayoutPanel2.Size.Width / 2, (Me.ClientSize.Height + 80) / 2 - (TableLayoutPanel2.Size.Height) / 2)
            '   TableLayoutPanel2.Anchor = AnchorStyles.None
        End If
    End Sub


    Sub Restore()
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer3.Enabled = True
                SqlConnection.ClearAllPools()
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "USE Master ALTER DATABASE WinFormsApp1_DB SET Single_User WITH Rollback Immediate Restore database WinFormsApp1_DB FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE WinFormsApp1_DB SET Multi_User "
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.CommandTimeout = 0
                cmd.ExecuteReader()
                con.Close()
                'Dim st As String = "Sucessfully performed the restore"
                'LogFunc(lblUser.Text, st)
                MessageBox.Show("Database Successfully Restored", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Backup()
        Try

            Dim destdir As String = "WinFormsApp1_DB " & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") & ".bak"
            Dim objdlg As New SaveFileDialog
            objdlg.Filter = ("DB Backup File|*.bak")
            objdlg.FileName = destdir
            objdlg.ShowDialog()
            Filename = objdlg.FileName
            Cursor = Cursors.WaitCursor
            Timer3.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "backup database WinFormsApp1_DB to disk='" & Filename & "'with init,stats=10"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.CommandTimeout = 0
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Database Backup Successfully Completed", "HavanoPOS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdjustLabelFontSize()
        ' Calculate new font size based on the form's width
        Dim formWidth As Integer = Me.ClientSize.Width
        Dim newFontSize As Single = formWidth / 15 ' Adjust the divisor to fit your needs

        ' Set the new font size
        'Me.Label1.Font = New Font("New Century Schoolbook Short", newFontSize, FontStyle.Italic)
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AdjustLabelFontSize()
    End Sub



    Private Sub LogOut()
        Dim st As String = "Successfully logged out"
        LogFunc(lblUser.Text, st)
        Me.Hide()
        frmLogin.Show()
        frmLogin.UserID.Text = ""
        frmLogin.Password.Text = ""
        frmLogin.UserID.Focus()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        frm_course_reg.Dispose()
        frm_course_reg.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Form1.Dispose()
        Form1.ShowDialog()
    End Sub

    Private Sub ManufacturingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManufacturingToolStripMenuItem.Click
        dep.Dispose()
        dep.ShowDialog()
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesToolStripMenuItem.Click
        Frm_TimeTable_genration_system.Dispose()
        Frm_TimeTable_genration_system.ShowDialog()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        frmRegistration.Dispose()
        frmRegistration.ShowDialog()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click

    End Sub

    Private Sub AddLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddLevelToolStripMenuItem.Click
        frm_lev.Dispose()
        frm_lev.ShowDialog()
    End Sub


End Class