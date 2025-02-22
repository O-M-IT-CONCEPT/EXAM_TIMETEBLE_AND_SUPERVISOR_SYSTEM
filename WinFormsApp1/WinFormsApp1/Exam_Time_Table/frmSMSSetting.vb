﻿Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports System.Data.SqlClient

Public Class frmSMSSetting
    Dim st1, st2, st3 As String
    Sub Reset()
        txtAPIURL.Text = ""
        chkIsDefault.Checked = False
        chkIsEnabled.Checked = True
        If IsViewAllowed(lblUser.Text, "Settings") = True Then
            Getdata()
        Else
            dgw.Rows.Clear()
        End If
        If IsSaveAllowed(lblUser.Text, "Settings") = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtAPIURL.Text)) = 0 Then
            MessageBox.Show("Please enter API URL", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAPIURL.Focus()
            Exit Sub
        End If
        Try
            If chkIsDefault.Checked = True Then
                con = New SqlConnection(cs)
                con.Open()
                Dim ct As String = "select IsDefault from SMSSetting where IsDefault='Yes'"
                cmd = New SqlCommand(ct)
                cmd.Connection = con
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    MessageBox.Show("Other HTTP API is already set as default", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
            End If
            If chkIsDefault.Checked = True Then
                st1 = "Yes"
            Else
                st1 = "No"
            End If
            If chkIsEnabled.Checked = True Then
                st2 = "Yes"
            Else
                st2 = "No"
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into SMSSetting(APIURL,IsDefault,IsEnabled) VALUES (@d1,@d2,@d3)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtAPIURL.Text)
            cmd.Parameters.AddWithValue("@d2", st1)
            cmd.Parameters.AddWithValue("@d3", st2)
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Successfully saved", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
    Public Sub Getdata()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT ID,RTRIM(APIURL), RTRIM(IsEnabled), RTRIM(IsDefault) from SMSSetting", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (rdr.Read() = True)
                dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DeleteRecord()

        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from SMSSetting where ID=@d1"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", Val(txtID.Text))
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            Else
                MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            If dgw.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgw.SelectedRows(0)
                txtID.Text = dr.Cells(0).Value
                txtAPIURL.Text = dr.Cells(1).Value.ToString()
                If dr.Cells(3).Value.ToString() = "Yes" Then
                    chkIsDefault.Checked = True
                Else
                    chkIsDefault.Checked = False
                End If
                If dr.Cells(2).Value.ToString() = "Yes" Then
                    chkIsEnabled.Checked = True
                Else
                    chkIsEnabled.Checked = False
                End If
                If IsDeleteAllowed(lblUser.Text, "Settings") = True Then
                    btnDelete.Enabled = True
                Else
                    btnDelete.Enabled = False
                End If
                If IsUpdateAllowed(lblUser.Text, "Settings") = True Then
                    btnUpdate.Enabled = True
                Else
                    btnUpdate.Enabled = False
                End If
                btnSave.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If Len(Trim(txtAPIURL.Text)) = 0 Then
            MessageBox.Show("Please enter API URL", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAPIURL.Focus()
            Exit Sub
        End If
        Try
            If chkIsDefault.Checked = True Then
                con = New SqlConnection(cs)
                con.Open()
                Dim ct As String = "Update SMSSetting set IsDefault='No'"
                cmd = New SqlCommand(ct)
                cmd.Connection = con
                cmd.ExecuteReader()
            End If
            If chkIsDefault.Checked = True Then
                st1 = "Yes"
            Else
                st1 = "No"
            End If
            If chkIsEnabled.Checked = True Then
                st2 = "Yes"
            Else
                st2 = "No"
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update SMSSetting set APIURL=@d1,IsDefault=@d2,IsEnabled=@d3 where ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtAPIURL.Text)
            cmd.Parameters.AddWithValue("@d2", st1)
            cmd.Parameters.AddWithValue("@d3", st2)
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Successfully updated", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub frmSMSSetting_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

    Private Sub frmSMSSetting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class