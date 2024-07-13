Public Class dep
    Dim Sql As String
    Dim parameters As List(Of SqlClient.SqlParameter)
    Dim dt As DataTable

    Public Sub Bfacultys()
        Sql = "SELECT id, faculty FROM faculty"
        parameters = New List(Of SqlClient.SqlParameter)()
        dt = Crud(Sql, parameters)

        ComboBox2.DisplayMember = "faculty"
        ComboBox2.ValueMember = "id"
        ComboBox2.DataSource = dt
    End Sub

    Private Sub Bdept()
        If ComboBox2.SelectedValue IsNot Nothing Then
            Dim facultyId As Integer = Convert.ToInt32(ComboBox2.SelectedValue)
            Sql = "SELECT * FROM dept WHERE facultyid = @facultyid"
            parameters = New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@facultyid", facultyId)
            }
            dt = Crud(Sql, parameters)

            ListBox1.Items.Clear()
            For Each row As DataRow In dt.Rows
                ListBox1.Items.Add(row("dept").ToString())
            Next
        End If
    End Sub

    Private Sub added()
        If ComboBox2.SelectedValue IsNot Nothing Then
            Dim facultyId As Integer = Convert.ToInt32(ComboBox2.SelectedValue)
            Sql = "SELECT * FROM dept WHERE facultyid = @facultyid AND dept = @dept"
            parameters = New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@facultyid", facultyId),
                New SqlClient.SqlParameter("@dept", TextBox1.Text)
            }
            dt = Crud(Sql, parameters)

            If dt.Rows.Count = 0 Then
                Sql = "INSERT INTO dept (facultyid, dept) VALUES (@facultyid, @dept)"
                parameters = New List(Of SqlClient.SqlParameter) From {
                    New SqlClient.SqlParameter("@facultyid", facultyId),
                    New SqlClient.SqlParameter("@dept", TextBox1.Text)
                }
                Crud(Sql, parameters)
                MsgBox("Record Saved", vbInformation + vbOKOnly)
                Bdept() ' Refresh the ListBox1 after insertion
            Else
                MsgBox("Department Already Exists", vbExclamation + vbOKOnly)
            End If
        End If
    End Sub

    Private Sub dep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bfacultys()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Bdept()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GelButton1.Click
        added()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles GelButton2.Click
        Me.Dispose()
    End Sub

    Private Sub GelButton3_Click(sender As Object, e As EventArgs) Handles GelButton3.Click
        Form1.Dispose()
        Form1.ShowDialog()
    End Sub
End Class
