Imports System.Data.SqlClient

Public Class FrmManualGeneration

    Private Sub FrmManualGeneration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim courses As DataTable = FetchCourses()
        dgwManual.DataSource = courses

        ' Add ComboBox columns
        AddComboBoxColumn("Day", {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        AddComboBoxColumn("TimeSlot", {"8:00am-11:00am", "12:00pm-3:00pm", "3:30pm-6:00pm"})
        AddComboBoxColumn("Faculty", FetchFaculties())
        AddComboBoxColumn("Dept", New List(Of String)) ' Initially empty, will be populated based on selected faculty
        AddComboBoxColumn("Session", FetchSessions())
        AddComboBoxColumn("User", New List(Of String)) ' Initially empty, will be populated based on selected faculty or department
    End Sub

    Private Sub AddComboBoxColumn(columnName As String, items As IEnumerable)
        Dim comboBoxColumn As New DataGridViewComboBoxColumn()
        comboBoxColumn.Name = columnName
        comboBoxColumn.HeaderText = columnName
        comboBoxColumn.DataSource = items
        comboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
        dgwManual.Columns.Add(comboBoxColumn)
    End Sub

    Private Function FetchCourses() As DataTable
        Dim sql As String = "SELECT id, course_name FROM Courses"
        Return Crud(sql, Nothing)
    End Function

    Private Function FetchFaculties() As List(Of String)
        Dim sql As String = "SELECT faculty FROM Faculty"
        Dim dt As DataTable = Crud(sql, Nothing)
        Return dt.AsEnumerable().Select(Function(row) row.Field(Of String)("faculty")).ToList()
    End Function

    Private Function FetchDepartments(facultyId As Integer) As List(Of String)
        Dim sql As String = "SELECT dept FROM Dept WHERE facultyid = @faculty_id"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@faculty_id", SqlDbType.Int) With {.Value = facultyId}
        }
        Dim dt As DataTable = Crud(sql, parameters)
        Return dt.AsEnumerable().Select(Function(row) row.Field(Of String)("dept")).ToList()
    End Function

    Private Function FetchSessions() As List(Of String)
        Dim currentYear As Integer = DateTime.Now.Year
        Dim sessions As New List(Of String)
        For i As Integer = -3 To 3
            sessions.Add($"{currentYear + i}-{currentYear + i + 1}")
        Next
        Return sessions
    End Function

    Private Function FetchUsers(Optional facultyId As Integer = -1, Optional deptId As Integer = -1) As List(Of String)
        Dim sql As String = "SELECT userid FROM Registration"
        Dim parameters As New List(Of SqlParameter)

        If facultyId <> -1 Then
            sql &= " WHERE facultyid = @faculty_id"
            parameters.Add(New SqlParameter("@faculty_id", SqlDbType.Int) With {.Value = facultyId})
        End If

        If deptId <> -1 Then
            sql &= If(parameters.Count > 0, " AND ", " WHERE ") & "deptid = @dept_id"
            parameters.Add(New SqlParameter("@dept_id", SqlDbType.Int) With {.Value = deptId})
        End If

        Dim dt As DataTable = Crud(sql, parameters)
        Return dt.AsEnumerable().Select(Function(row) row.Field(Of String)("userid")).ToList()
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveData()
    End Sub

    Private Sub SaveData()
        For Each row As DataGridViewRow In dgwManual.Rows
            If Not row.IsNewRow Then
                Dim courseId As Integer = CInt(row.Cells("id").Value)
                Dim day As String = row.Cells("Day").Value.ToString()
                Dim timeSlot As String = row.Cells("TimeSlot").Value.ToString()
                Dim faculty As String = row.Cells("Faculty").Value.ToString()
                Dim dept As String = row.Cells("Dept").Value.ToString()
                Dim session As String = row.Cells("Session").Value.ToString()
                Dim userId As String = row.Cells("User").Value.ToString()

                ' Save to database
                SaveSchedule(courseId, day, timeSlot, faculty, dept, session, userId)
            End If
        Next
    End Sub

    Private Sub SaveSchedule(courseId As Integer, day As String, timeSlot As String, faculty As String, dept As String, session As String, userId As String)
        Dim sql As String = "INSERT INTO Schedule (course_id, day, time_slot, faculty, dept, session, userid) VALUES (@course_id, @day, @time_slot, @faculty, @dept, @session, @userid)"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@course_id", SqlDbType.Int) With {.Value = courseId},
            New SqlParameter("@day", SqlDbType.VarChar) With {.Value = day},
            New SqlParameter("@time_slot", SqlDbType.VarChar) With {.Value = timeSlot},
            New SqlParameter("@faculty", SqlDbType.VarChar) With {.Value = faculty},
            New SqlParameter("@dept", SqlDbType.VarChar) With {.Value = dept},
            New SqlParameter("@session", SqlDbType.VarChar) With {.Value = session},
            New SqlParameter("@userid", SqlDbType.VarChar) With {.Value = userId}
        }
        Crud(sql, parameters)
    End Sub



    Private Sub dgwManual_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgwManual.EditingControlShowing
        If TypeOf e.Control Is ComboBox Then
            Dim comboBox As ComboBox = CType(e.Control, ComboBox)
            RemoveHandler comboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
            AddHandler comboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
        End If
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = CType(sender, ComboBox)
        Dim columnName As String = dgwManual.Columns(dgwManual.CurrentCell.ColumnIndex).Name

        If comboBox.SelectedItem Is Nothing Then
            Exit Sub
        End If

        If columnName = "Faculty" Then
            Dim facultyId As Integer = CInt(FetchFacultyId(comboBox.SelectedItem.ToString()))
            UpdateDeptColumn(facultyId)
            UpdateUserColumn(facultyId)
        ElseIf columnName = "Dept" Then
            Dim facultyId As Integer = CInt(FetchFacultyId(dgwManual.CurrentRow.Cells("Faculty").Value.ToString()))
            Dim deptId As Integer = CInt(FetchDeptId(comboBox.SelectedItem.ToString(), facultyId))
            UpdateUserColumn(facultyId, deptId)
        End If
    End Sub

    Private Function FetchFacultyId(faculty As String) As Integer
        Dim sql As String = "SELECT id FROM Faculty WHERE faculty = @faculty"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@faculty", SqlDbType.VarChar) With {.Value = faculty}
        }
        Dim dt As DataTable = Crud(sql, parameters)
        If dt.Rows.Count > 0 Then
            Return CInt(dt.Rows(0)("id"))
        End If
        Return -1
    End Function

    Private Function FetchDeptId(dept As String, facultyId As Integer) As Integer
        Dim sql As String = "SELECT id FROM Dept WHERE dept = @dept AND facultyid = @faculty_id"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@dept", SqlDbType.VarChar) With {.Value = dept},
            New SqlParameter("@faculty_id", SqlDbType.Int) With {.Value = facultyId}
        }
        Dim dt As DataTable = Crud(sql, parameters)
        If dt.Rows.Count > 0 Then
            Return CInt(dt.Rows(0)("id"))
        End If
        Return -1
    End Function

    Private Sub UpdateDeptColumn(facultyId As Integer)
        Dim deptColumn As DataGridViewComboBoxColumn = CType(dgwManual.Columns("Dept"), DataGridViewComboBoxColumn)
        deptColumn.DataSource = FetchDepartments(facultyId)
    End Sub

    Private Sub UpdateUserColumn(facultyId As Integer, Optional deptId As Integer = -1)
        Dim userColumn As DataGridViewComboBoxColumn = CType(dgwManual.Columns("User"), DataGridViewComboBoxColumn)
        userColumn.DataSource = FetchUsers(facultyId, deptId)
    End Sub
End Class
