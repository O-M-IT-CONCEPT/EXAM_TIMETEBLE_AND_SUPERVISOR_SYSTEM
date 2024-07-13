Imports System.Data.SqlClient

Public Class frm_course_reg

    Private Sub LoadFaculties()
        Dim sql As String = "SELECT  id, faculty FROM Faculty"
        Dim dt As DataTable = Crud(sql, Nothing)
        cmbfac.DataSource = dt
        cmbfac.DisplayMember = "faculty"
        cmbfac.ValueMember = "id"
        cmbfacFilter.DataSource = dt.Copy()
        cmbfacFilter.DisplayMember = "faculty"
        cmbfacFilter.ValueMember = "id"
    End Sub

    Private Sub LoadDepartments()
        Dim sql As String = "SELECT id, dept FROM  dept WHERE facultyid = @id"
        Dim sqlParameters As New List(Of SqlParameter)
        sqlParameters.Add(New SqlParameter("@id", SqlDbType.Int) With {.Value = cmbfac.SelectedValue})
        Dim dt As DataTable = Crud(sql, sqlParameters)
        cmbdept.DataSource = dt
        cmbdept.DisplayMember = " dept"
        cmbdept.ValueMember = "id"
        cmbfilterdept.DataSource = dt.Copy()
        cmbfilterdept.DisplayMember = " dept"
        cmbfilterdept.ValueMember = "id"
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
            Dim sql As String = "INSERT INTO Courses (course_code, course_name, facultyid, deptid, program, level) 
VALUES (@course_code, @course_name, @facultyid, @deptid, @program, @level)"
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
            Dim sql As String = "UPDATE Courses SET course_name = @course_name, facultyid = @facultyid, deptid = @deptid, 
program = @program, level = @level WHERE course_code = @course_code"
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
    Sub CLEAR()
        txtcourseCode.Clear()
        txtcourseName.Clear()
    End Sub
    Private Sub LoadCourses()
        Dim sql As String = "SELECT course_code, course_name, facultyid, deptid, program, level FROM Courses"
        Dim dt As DataTable = Crud(sql, Nothing)
        dgw.DataSource = dt
        CLEAR()
    End Sub

    Private Sub frm_course_reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFaculties()
        LoadCourses()
        CLEAR()
    End Sub

    Private Sub FilterCourses()
        Dim sql As String = "SELECT course_code, course_name, facultyid, deptid, program, level FROM Courses WHERE facultyid= @facultyid AND deptid = @deptid AND level = @level"
        Dim sqlParameters As New List(Of SqlParameter) From {
        New SqlParameter("@facultyid", SqlDbType.Int) With {.Value = cmbfacFilter.SelectedValue},
        New SqlParameter("@deptid", SqlDbType.Int) With {.Value = cmbfilterdept.SelectedValue},
        New SqlParameter("@level", SqlDbType.VarChar) With {.Value = cmblevelFilter.SelectedItem.ToString()}
    }
        Dim dt As DataTable = Crud(sql, sqlParameters)
        dgw.DataSource = dt
    End Sub

    Private Sub cmbfacFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfacFilter.SelectedIndexChanged, cmbfilterdept.SelectedIndexChanged, cmblevelFilter.SelectedIndexChanged
        FilterCourses()
    End Sub

End Class