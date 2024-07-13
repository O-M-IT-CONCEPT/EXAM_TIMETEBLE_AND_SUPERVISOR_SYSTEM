Public Class frm_lev
    Private Sub frm_lev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLevels()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtBatchName.Text) Then
            MsgBox("Please enter a level name.", vbExclamation + vbOKOnly)
            Return
        End If

        AddLevelIfNotExist(txtBatchName.Text.Trim())
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgw.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgw.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("Column2").Value)

            UpdateLevel(id, txtBatchName.Text.Trim())
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

    Private Sub dgw_SelectionChanged(sender As Object, e As EventArgs) Handles dgw.SelectionChanged
        If dgw.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgw.SelectedRows(0)
            txtCode.Text = selectedRow.Cells("Column3").Value.ToString()
            txtBatchName.Text = selectedRow.Cells("Column4").Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Else
            txtCode.Clear()
            txtBatchName.Clear()
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub AddLevelIfNotExist(levelName As String)
        Dim Sql As String
        Dim parameters As List(Of SqlClient.SqlParameter)
        Dim dt As DataTable

        ' Check if the level already exists
        Sql = "SELECT * FROM levels WHERE LevelName = @LevelName"
        parameters = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@LevelName", levelName)
        }
        dt = Crud(Sql, parameters)

        If dt.Rows.Count = 0 Then
            ' Insert new level if it does not exist
            Sql = "INSERT INTO levels (LevelName) VALUES (@LevelName)"
            parameters = New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@LevelName", levelName)
            }
            Crud(Sql, parameters)
            MsgBox("Level added successfully.", vbInformation + vbOKOnly)
            LoadLevels()
        Else
            MsgBox("Level already exists.", vbExclamation + vbOKOnly)
        End If
    End Sub

    Private Sub LoadLevels()
        Dim Sql As String = "SELECT * FROM levels"
        Dim parameters As New List(Of SqlClient.SqlParameter)
        Dim dt As DataTable = Crud(Sql, parameters)
        dgw.Rows.Clear()
        Dim sn As Integer = 1
        For Each row As DataRow In dt.Rows
            dgw.Rows.Add(sn, row("id"), row("Code"), row("Level"))
            sn += 1
        Next
    End Sub

    Private Sub UpdateLevel(id As Integer, levelName As String)
        Dim Sql As String
        Dim parameters As List(Of SqlClient.SqlParameter)

        Sql = "UPDATE levels SET LevelName = @LevelName WHERE id = @id"
        parameters = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@LevelName", levelName),
            New SqlClient.SqlParameter("@id", id)
        }
        Crud(Sql, parameters)
        MsgBox("Level updated successfully.", vbInformation + vbOKOnly)
        LoadLevels()
    End Sub

    Private Sub DeleteLevel(id As Integer)
        Dim Sql As String
        Dim parameters As List(Of SqlClient.SqlParameter)

        Sql = "DELETE FROM levels WHERE id = @id"
        parameters = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@id", id)
        }
        Crud(Sql, parameters)
        MsgBox("Level deleted successfully.", vbInformation + vbOKOnly)
        LoadLevels()
    End Sub


End Class
