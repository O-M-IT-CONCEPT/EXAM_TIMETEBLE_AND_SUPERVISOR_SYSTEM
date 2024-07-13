Imports System.Data.SqlClient

Public Class Frm_TimeTable_genration_system

    Private Sub Frm_TimeTable_genration_system_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFaculties()
        LoadSessions()
    End Sub
    Private Sub LoadFaculties()
        Dim sql As String = "SELECT id, faculty FROM Faculty"
        Dim dt As DataTable = Crud(sql, Nothing)
        cmbfac.DataSource = dt
        cmbfac.DisplayMember = "faculty"
        cmbfac.ValueMember = "id"
    End Sub
    Private Sub LoadDepartments()
        Dim sql As String = "SELECT id, dept FROM dept WHERE facultyid = @faculty_id"
        Dim sqlParameters As New List(Of SqlParameter) From {
            New SqlParameter("@faculty_id", SqlDbType.Int) With {.Value = cmbfac.SelectedValue}
        }
        Dim dt As DataTable = Crud(sql, sqlParameters)
        cmbdept.DataSource = dt
        cmbdept.DisplayMember = "dept"
        cmbdept.ValueMember = "id"
    End Sub
    Private Sub LoadSessions()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim sessions As New List(Of String)
        For i As Integer = -3 To 3
            sessions.Add($"{currentYear + i}-{currentYear + i + 1}")
        Next
        cmbses.DataSource = sessions
    End Sub

    Private Sub cmbfac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfac.SelectedIndexChanged
        LoadDepartments()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        AutoGenerateTimetable()
    End Sub

    Private Sub AutoGenerateTimetable()
        Dim session As String = cmbses.SelectedItem.ToString()
        If CheckExistingTimetable(session) Then
            RemoveExistingTimetable(session)
        End If

        Dim staff As DataTable = FetchStaff()
        Dim courses As DataTable = FetchCourses()
        Dim venues As DataTable = FetchVenues()

        Dim startDate As Date = DateTime.Now.AddDays(7)
        Dim timeSlots As String() = {"8:00am-11:00am", "12:00pm-3:00pm", "3:30pm-6:00pm"}
        Dim days As String() = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}

        For Each course As DataRow In courses.Rows
            Dim courseId As Integer = course("id")
            Dim deptId As Integer = course("deptid")
            Dim facultyId As Integer = course("facultyid")
            Dim venueId As Integer = course("venueid")
            Dim assignedLecturers As New List(Of Integer)
            For Each day As String In days
                For Each timeSlot As String In timeSlots
                    Dim lecturer As DataRow = GetAvailableLecturer(staff, assignedLecturers, day, timeSlot, deptId, facultyId)
                    If lecturer IsNot Nothing Then
                        assignedLecturers.Add(lecturer("userid"))
                        ScheduleClass(courseId, lecturer("userid"), venueId, day, timeSlot, startDate, session)
                    End If
                Next
            Next
        Next
    End Sub

    Private Function FetchStaff() As DataTable
        Dim sql As String = "SELECT * FROM Registration"
        Return Crud(sql, Nothing)
    End Function

    Private Function FetchCourses() As DataTable
        Dim sql As String = "SELECT * FROM Courses"
        Return Crud(sql, Nothing)
    End Function

    Private Function FetchVenues() As DataTable
        Dim sql As String = "SELECT * FROM Venues"
        Return Crud(sql, Nothing)
    End Function

    Private Function GetAvailableLecturer(staff As DataTable, assignedLecturers As List(Of Integer), day As String, timeSlot As String, deptId As Integer, facultyId As Integer) As DataRow
        Dim availableLecturers As DataRow() = staff.Select($"deptid = {deptId} AND facultyid = {facultyId} AND userid NOT IN ({String.Join(",", assignedLecturers)})")
        For Each lecturer As DataRow In availableLecturers
            If Not HasScheduleConflict(lecturer("userid"), day, timeSlot) Then
                Return lecturer
            End If
        Next
        Return Nothing
    End Function

    Private Function HasScheduleConflict(staffId As Integer, day As String, timeSlot As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Schedule WHERE userid = @staff_id AND day = @day AND time_slot = @time_slot"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@staff_id", SqlDbType.Int) With {.Value = staffId},
            New SqlParameter("@day", SqlDbType.VarChar) With {.Value = day},
            New SqlParameter("@time_slot", SqlDbType.VarChar) With {.Value = timeSlot}
        }
        Dim dt As DataTable = Crud(sql, parameters)
        Return Convert.ToInt32(dt.Rows(0)(0)) > 0
    End Function

    Private Sub ScheduleClass(courseId As Integer, staffId As Integer, venueId As Integer, day As String, timeSlot As String, startDate As Date, session As String)
        Dim sql As String = "INSERT INTO Schedule (course_id, userid, venue_id, day, time_slot, date, session) VALUES (@course_id, @staff_id, @venue_id, @day, @time_slot, @date, @session)"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@course_id", SqlDbType.Int) With {.Value = courseId},
            New SqlParameter("@staff_id", SqlDbType.Int) With {.Value = staffId},
            New SqlParameter("@venue_id", SqlDbType.Int) With {.Value = venueId},
            New SqlParameter("@day", SqlDbType.VarChar) With {.Value = day},
            New SqlParameter("@time_slot", SqlDbType.VarChar) With {.Value = timeSlot},
            New SqlParameter("@date", SqlDbType.Date) With {.Value = startDate},
            New SqlParameter("@session", SqlDbType.VarChar) With {.Value = session}
        }
        Crud(sql, parameters)
    End Sub

    Private Function CheckExistingTimetable(session As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Schedule WHERE session = @session"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@session", SqlDbType.VarChar) With {.Value = session}
        }
        Dim dt As DataTable = Crud(sql, parameters)
        Return Convert.ToInt32(dt.Rows(0)(0)) > 0
    End Function

    Private Sub RemoveExistingTimetable(session As String)
        Dim sql As String = "DELETE FROM Schedule WHERE session = @session"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@session", SqlDbType.VarChar) With {.Value = session}
        }
        Crud(sql, parameters)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FrmManualGeneration.Dispose()
        FrmManualGeneration.ShowDialog()
    End Sub
End Class
