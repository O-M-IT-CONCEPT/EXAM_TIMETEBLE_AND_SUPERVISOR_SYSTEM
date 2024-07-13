Imports System.Data.SqlClient

Public Class frm_course_reg

    Private Sub LoadFaculties()
        Dim sql As String = "SELECT id, faculty FROM Faculty"
        Dim dt As DataTable = Crud(sql, Nothing)
        cmbfac.DataSource = dt
        cmbfac.DisplayMember = "faculty"
        cmbfac.ValueMember = "id"
        cmbfacFilter.DataSource = dt.Copy()
        cmbfacFilter.DisplayMember = "faculty"
        cmbfacFilter.ValueMember = "id"
    End Sub

    Private Sub LoadDepartments()
        Dim selectedValue As Object = cmbfac.SelectedValue
        If selectedValue IsNot Nothing Then
            Dim facultyId As Integer

            ' Check if the selected value is a DataRowView, if so, get the actual value.
            If TypeOf selectedValue Is DataRowView Then
                facultyId = Convert.ToInt32(CType(selectedValue, DataRowView)("id"))
            Else
                facultyId = Convert.ToInt32(selectedValue)
            End If

            Dim sql As String = "SELECT id, dept FROM dept WHERE facultyid = @id"
            Dim sqlParameters As New List(Of SqlParameter)
            sqlParameters.Add(New SqlParameter("@id", SqlDbType.Int) With {.Value = facultyId})

            ' Load departments for cmbdept
            Dim dtDept As DataTable = Crud(sql, sqlParameters)
            cmbdept.DataSource = dtDept
            cmbdept.DisplayMember = "dept"
            cmbdept.ValueMember = "id"

            ' Load departments for cmbfilterdept
            Dim dtFilterDept As DataTable = dtDept.Copy()
            cmbfilterdept.DataSource = dtFilterDept
            cmbfilterdept.DisplayMember = "dept"
            cmbfilterdept.ValueMember = "id"
        End If
    End Sub

    Private Sub cmbfac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfac.SelectedIndexChanged
        LoadDepartments()
    End Sub

    Private Function ValidateCourseData() As Boolean
        If String.IsNullOrWhiteSpace(txtcourseName.Text) OrElse String.IsNullOrWhiteSpace(txtcourseCode.Text) Then
            MessageBox.Show("Please enter all the required course information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateCourseData() Then
            Dim sql As String = "INSERT INTO Courses (course_code, course_name, facultyid, deptid, program, level) VALUES (@course_code, @course_name, @facultyid, @deptid, @program, @level)"
            Dim sqlParameters As New List(Of SqlParameter) From {
                New SqlParameter("@course_code", SqlDbType.VarChar) With {.Value = txtcourseCode.Text},
                New SqlParameter("@course_name", SqlDbType.VarChar) With {.Value = txtcourseName.Text},
                New SqlParameter("@facultyid", SqlDbType.Int) With {.Value = cmbfac.SelectedValue},
                New SqlParameter("@deptid", SqlDbType.Int) With {.Value = cmbdept.SelectedValue},
                New SqlParameter("@program", SqlDbType.VarChar) With {.Value = cmbprog.SelectedItem.ToString()},
                New SqlParameter("@level", SqlDbType.VarChar) With {.Value = cmblev.SelectedItem.ToString()}
            }
            Crud(sql, sqlParameters)
            LoadCourses()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidateCourseData() Then
            Dim sql As String = "UPDATE Courses SET course_name = @course_name, facultyid = @facultyid, deptid = @deptid, program = @program, level = @level, course_code=@course_code WHERE id = @id"
            Dim sqlParameters As New List(Of SqlParameter) From {
                New SqlParameter("@id", SqlDbType.VarChar) With {.Value = id_c},
                New SqlParameter("@course_code", SqlDbType.VarChar) With {.Value = txtcourseCode.Text},
                New SqlParameter("@course_name", SqlDbType.VarChar) With {.Value = txtcourseName.Text},
                New SqlParameter("@facultyid", SqlDbType.Int) With {.Value = cmbfac.SelectedValue},
                New SqlParameter("@deptid", SqlDbType.Int) With {.Value = cmbdept.SelectedValue},
                New SqlParameter("@program", SqlDbType.VarChar) With {.Value = cmbprog.SelectedItem.ToString()},
                New SqlParameter("@level", SqlDbType.VarChar) With {.Value = cmblev.SelectedItem.ToString()}
            }
            Crud(sql, sqlParameters)
            LoadCourses()
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM Courses WHERE course_code = @course_code"
            Dim sqlParameters As New List(Of SqlParameter) From {
                New SqlParameter("@course_code", SqlDbType.VarChar) With {.Value = txtcourseCode.Text}
            }
            Crud(sql, sqlParameters)
            LoadCourses()
        End If
    End Sub

    Private Sub CLEAR()
        txtcourseCode.Clear()
        txtcourseName.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub
    Private Sub LoadCourses()
        Dim sql As String = "SELECT c.id, c.course_code, c.course_name, f.faculty, d.dept, c.program, c.level " &
                        "FROM Courses c " &
                        "JOIN Faculty f ON c.facultyid = f.id " &
                        "JOIN dept d ON c.deptid = d.id"
        Dim dt As DataTable = Crud(sql, Nothing)

        dgw.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dgw.Rows.Add(row("id"), row("course_code"), row("course_name"), row("faculty"), row("dept"), row("program"), row("level"))
        Next

        ' Clear the input fields
        CLEAR()
    End Sub


    Private Sub frm_course_reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFaculties()
        LoadCourses()
        CLEAR()
    End Sub
    Private Sub FilterCourses()
        If cmbfacFilter.SelectedValue IsNot Nothing AndAlso cmbfilterdept.SelectedValue IsNot Nothing AndAlso cmblevelFilter.SelectedItem IsNot Nothing Then
            Dim facultyId As Integer
            Dim deptId As Integer

            ' Extract the actual values
            If TypeOf cmbfacFilter.SelectedValue Is DataRowView Then
                facultyId = Convert.ToInt32(CType(cmbfacFilter.SelectedValue, DataRowView)("id"))
            Else
                facultyId = Convert.ToInt32(cmbfacFilter.SelectedValue)
            End If

            If TypeOf cmbfilterdept.SelectedValue Is DataRowView Then
                deptId = Convert.ToInt32(CType(cmbfilterdept.SelectedValue, DataRowView)("id"))
            Else
                deptId = Convert.ToInt32(cmbfilterdept.SelectedValue)
            End If

            Dim sql As String = "SELECT c.course_code, c.course_name, f.faculty, d.dept, c.program, c.level " &
                            "FROM Courses c " &
                            "JOIN Faculty f ON c.facultyid = f.id " &
                            "JOIN dept d ON c.deptid = d.id " &
                            "WHERE c.facultyid = @facultyid AND c.deptid = @deptid AND c.level = @level"
            Dim sqlParameters As New List(Of SqlParameter) From {
            New SqlParameter("@facultyid", SqlDbType.Int) With {.Value = facultyId},
            New SqlParameter("@deptid", SqlDbType.Int) With {.Value = deptId},
            New SqlParameter("@level", SqlDbType.VarChar) With {.Value = cmblevelFilter.SelectedItem.ToString()}
        }
            Dim dt As DataTable = Crud(sql, sqlParameters)

            ' Clear the DataGridView
            dgw.Rows.Clear()

            ' Add rows to the DataGridView
            For Each row As DataRow In dt.Rows
                dgw.Rows.Add(row(0), row("course_code"), row("course_name"), row("faculty"), row("dept"), row("program"), row("level"))
            Next
        Else
            '   MessageBox.Show("Please select valid values for all filters.", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmbfacFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfacFilter.SelectedIndexChanged, cmbfilterdept.SelectedIndexChanged, cmblevelFilter.SelectedIndexChanged
        FilterCourses()
    End Sub

    Dim id_c As Integer

    Private Sub dgw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellClick
        ' Ensure that the row index is valid
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgw.Rows(e.RowIndex)
            id_c = row.Cells(0).Value
            txtcourseCode.Text = row.Cells(1).Value.ToString()
            txtcourseName.Text = row.Cells(2).Value.ToString()
            cmbfac.SelectedValue = GetFacultyIdByName(row.Cells(3).Value.ToString())
            cmbdept.SelectedValue = GetDeptIdByName(row.Cells(4).Value.ToString())
            cmbprog.SelectedItem = row.Cells(5).Value.ToString()
            cmblev.SelectedItem = row.Cells(6).Value.ToString()
            btnSave.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Function GetFacultyIdByName(facultyName As String) As Integer
        Dim sql As String = "SELECT id FROM Faculty WHERE faculty = @faculty"
        Dim sqlParameters As New List(Of SqlParameter) From {
            New SqlParameter("@faculty", SqlDbType.NVarChar) With {.Value = facultyName}
        }
        Dim dt As DataTable = Crud(sql, sqlParameters)
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("id"))
        Else
            Return -1 ' Or handle this case as needed
        End If
    End Function
    Private Function GetDeptIdByName(deptName As String) As Integer
        Dim sql As String = "SELECT id FROM dept WHERE dept = @dept"
        Dim sqlParameters As New List(Of SqlParameter) From {
            New SqlParameter("@dept", SqlDbType.NVarChar) With {.Value = deptName}
        }
        Dim dt As DataTable = Crud(sql, sqlParameters)
        If dt.Rows.Count > 0 Then
            Return Convert.ToInt32(dt.Rows(0)("id"))
        Else
            Return -1 ' Or handle this case as needed
        End If
    End Function
End Class
