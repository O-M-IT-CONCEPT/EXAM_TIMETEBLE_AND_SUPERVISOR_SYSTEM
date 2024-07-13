Imports System.Data.SqlClient

Public Class frm_lev
    Private Sub frm_lev_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadLevels()
        clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtBatchName.Text) OrElse String.IsNullOrWhiteSpace(txtCode.Text) Then
            MsgBox("Please enter a level name and code.", vbExclamation + vbOKOnly)
            Return
        End If

        AddLevelIfNotExist(txtBatchName.Text.Trim(), txtCode.Text.Trim())
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgw.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgw.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Column2").Value)

            UpdateLevel(id, txtBatchName.Text.Trim(), txtCode.Text.Trim())
        Else
            MsgBox("Please select a level to update.", vbExclamation + vbOKOnly)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgw.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgw.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Column2").Value)
            DeleteLevel(id)
        Else
            MsgBox("Please select a level to delete.", vbExclamation + vbOKOnly)
        End If
    End Sub
    Sub clear()
        txtBatchName.Clear()
        txtCode.Clear()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub dgw_SelectionChanged(sender As Object, e As EventArgs) Handles dgw.SelectionChanged
        If dgw.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgw.SelectedRows(0)
            txtBatchName.Text = selectedRow.Cells("Column3").Value.ToString()
            txtCode.Text = selectedRow.Cells("Column4").Value.ToString() ' Assuming Column4 is for code
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        Else
            txtBatchName.Clear()
            txtCode.Clear()
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub AddLevelIfNotExist(levelName As String, code As String)
        Dim sql As String
        Dim parameters As List(Of SqlParameter)
        Dim dt As DataTable

        ' Check if the level already exists
        sql = "SELECT * FROM levels WHERE Level = @LevelName AND code = @Code"
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@LevelName", levelName),
            New SqlParameter("@Code", code)
        }
        dt = Crud(sql, parameters)
        If dt.Rows.Count = 0 Then
            ' Insert new level if it does not exist
            sql = "INSERT INTO levels (Level, code) VALUES (@LevelName, @Code)"
            parameters = New List(Of SqlParameter) From {
                New SqlParameter("@LevelName", levelName),
                New SqlParameter("@Code", code)
            }
            Crud(sql, parameters)
            MsgBox("Level added successfully.", vbInformation + vbOKOnly)
            LoadLevels()
        Else
            MsgBox("Level already exists.", vbExclamation + vbOKOnly)
        End If
        clear()

    End Sub

    Private Sub LoadLevels()
        Dim sql As String = "SELECT id, Level, code FROM levels"
        Dim parameters As New List(Of SqlParameter)
        Dim dt As DataTable = Crud(sql, parameters)
        dgw.Rows.Clear()
        Dim sn As Integer = 1
        For Each row As DataRow In dt.Rows
            dgw.Rows.Add(sn, row("id"), row("Level"), row("code"))
            sn += 1
        Next
    End Sub

    Private Sub UpdateLevel(id As Integer, levelName As String, code As String)
        Dim sql As String
        Dim parameters As List(Of SqlParameter)

        sql = "UPDATE levels SET Level = @LevelName, code = @Code WHERE id = @id"
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@LevelName", levelName),
            New SqlParameter("@Code", code),
            New SqlParameter("@id", id)
        }
        Crud(sql, parameters)
        MsgBox("Level updated successfully.", vbInformation + vbOKOnly)
        LoadLevels()
        clear()
    End Sub

    Private Sub DeleteLevel(id As Integer)
        Dim sql As String
        Dim parameters As List(Of SqlParameter)

        sql = "DELETE FROM levels WHERE id = @id"
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@id", id)
        }
        Crud(sql, parameters)
        MsgBox("Level deleted successfully.", vbInformation + vbOKOnly)
        LoadLevels()
    End Sub

End Class
