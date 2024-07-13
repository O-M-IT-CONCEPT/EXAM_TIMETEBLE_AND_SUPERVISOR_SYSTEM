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
        AddComboBoxColumn("Dept", FetchDepartments())
        AddComboBoxColumn("Session", FetchSessions())
    End Sub

    Private Sub AddComboBoxColumn(columnName As String, items As IEnumerable)
        Dim comboBoxColumn As New DataGridViewComboBoxColumn()
        comboBoxColumn.Name = columnName
        comboBoxColumn.HeaderText = columnName
        comboBoxColumn.DataSource = items
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

    Private Function FetchDepartments() As List(Of String)
        Dim sql As String = "SELECT dept FROM Dept"
        Dim dt As DataTable = Crud(sql, Nothing)
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

    Private Function Crud(sql As String, parameters As List(Of SqlParameter)) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection("your_connection_string")
            Using cmd As New SqlCommand(sql, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
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

                ' Save to database
                SaveSchedule(courseId, day, timeSlot, faculty, dept, session)
            End If
        Next
    End Sub

    Private Sub SaveSchedule(courseId As Integer, day As String, timeSlot As String, faculty As String, dept As String, session As String)
        Dim sql As String = "INSERT INTO Schedule (course_id, day, time_slot, faculty, dept, session) VALUES (@course_id, @day, @time_slot, @faculty, @dept, @session)"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@course_id", SqlDbType.Int) With {.Value = courseId},
            New SqlParameter("@day", SqlDbType.VarChar) With {.Value = day},
            New SqlParameter("@time_slot", SqlDbType.VarChar) With {.Value = timeSlot},
            New SqlParameter("@faculty", SqlDbType.VarChar) With {.Value = faculty},
            New SqlParameter("@dept", SqlDbType.VarChar) With {.Value = dept},
            New SqlParameter("@session", SqlDbType.VarChar) With {.Value = session}
        }
        Crud(sql, parameters)
    End Sub
End Class
