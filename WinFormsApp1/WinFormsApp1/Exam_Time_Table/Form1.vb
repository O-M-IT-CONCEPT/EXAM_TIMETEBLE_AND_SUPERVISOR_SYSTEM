
Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            AddFacultyIfNotExist(TextBox1.Text.Trim())
            TextBox1.Clear()
            e.Handled = True ' Prevents the beep sound on Enter key press
        End If
    End Sub
    Private Sub AddFacultyIfNotExist(facultyName As String)
        If String.IsNullOrWhiteSpace(facultyName) Then
            Return ' Ignore blank data
        End If

        Dim Sql As String
        Dim parameters As List(Of SqlClient.SqlParameter)
        Dim dt As DataTable

        ' Check if the faculty already exists
        Sql = "SELECT * FROM faculty WHERE faculty = @faculty"
        parameters = New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@faculty", facultyName)
        }
        dt = Crud(Sql, parameters)

        If dt.Rows.Count = 0 Then
            ' Insert new faculty if it does not exist
            Sql = "INSERT INTO faculty (faculty) VALUES (@faculty)"
            parameters = New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@faculty", facultyName)
            }
            Crud(Sql, parameters)
            MsgBox("Faculty added successfully.", vbInformation + vbOKOnly)
        Else
            MsgBox("Faculty already exists.", vbExclamation + vbOKOnly)
        End If
        dep.Bfacultys()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
