Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmRegistration
    Dim st1 As String
    Sub Reset()
        chkBackoffice.Checked = False
        chkBill.Checked = False
        chkquotation.Checked = False
        chksales.Checked = False
        chkSalesList.Checked = False
        chkCredit.Checked = False
        CheckBox1.Checked = False
        txtContactNo.Text = ""
        txtEmailID.Text = ""
        txtSSN.Text = ""
        txtName.Text = ""
        txtPassword.Text = ""
        txtUserID.Text = ""
        cmbUserType.SelectedIndex = -1
        txtCardNo.Text = ""
        chkActive.Checked = True
        txtUserID.Focus()

        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtUserID.Enabled = True
        cmbPayrollType.SelectedIndex = 0
        txtlev3.Clear()
        txtlev2.Clear()
        txtlev1.Clear()
        LoadFaculty()
        LoadLevel()
        Getdata()
        cmbdept.DataSource = Nothing
    End Sub



    Private Sub DeleteRecord()

        Try
            If txtUserID.Text = "admin" Or txtUserID.Text = "Admin" Then
                MessageBox.Show("Admin account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cl4 As String = "select Registration.UserID from Registration,Quotation where Registration.UserID=Quotation.UserID and Registration.UserID=@d1"
            cmd = New SqlCommand(cl4)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Quotation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cl1 As String = "select Registration.UserID from Registration,Payroll where Registration.UserID=Payroll.UserID and Registration.UserID=@d1"
            cmd = New SqlCommand(cl1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Payroll", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cl2 As String = "select Registration.UserID from Registration,Payroll_MB where Registration.UserID=Payroll_MB.UserID and Registration.UserID=@d1"
            cmd = New SqlCommand(cl2)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Payroll", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cl As String = "select Registration.UserID from Registration,POS_OpeningCash where Registration.UserID=POS_OpeningCash.UserID and Registration.UserID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in POS Opening Cash", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Registration where userid=@d1"
            cmd = New SqlCommand(cq)
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    Public Sub Getdata()
        con = New SqlConnection(cs)
        con.Open()

        If con.State = ConnectionState.Open Then
            cmd = New SqlCommand("SELECT RTRIM(userid), RTRIM(UserType), RTRIM(Password), RTRIM(Name), RTRIM(EmailID), RTRIM(ContactNo), RTRIM(CardNo), RTRIM(SSN), RTRIM(PayrollType), RTRIM(Active), JoiningDate, AllowAccess, Quotation, BillReprint, CreditCustomer, SalesReturn, SalesList, lall, plev1, plev2, plev3, RTRIM(FacultyId), RTRIM(DeptId), RTRIM(LevelId) FROM Registration ORDER BY JoiningDate", con)

            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()

            If rdr.HasRows Then
                While rdr.Read()
                    dgw.Rows.Add(rdr(0), rdr(1), Decrypt(rdr(2)), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21), rdr(22), rdr(23))
                End While
            Else
                MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            rdr.Close()
            con.Close()
        Else
            MessageBox.Show("Unable to connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        ' Try
        If dgw.Rows.Count > 0 AndAlso dgw.SelectedRows.Count > 0 Then
                Dim dr As DataGridViewRow = dgw.SelectedRows(0)
                txtUserID.Text = dr.Cells(0).Value.ToString()
                TextBox1.Text = dr.Cells(0).Value.ToString()
                cmbUserType.Text = dr.Cells(1).Value.ToString()
                txtPassword.Text = dr.Cells(2).Value.ToString()
                txtPIN.Text = dr.Cells(2).Value.ToString()
                txtName.Text = dr.Cells(3).Value.ToString()
                txtContactNo.Text = dr.Cells(5).Value.ToString()
                txtEmailID.Text = dr.Cells(4).Value.ToString()
                txtEmail.Text = dr.Cells(4).Value.ToString()
                txtCardNo.Text = dr.Cells(6).Value.ToString()
                txtCNo.Text = dr.Cells(6).Value.ToString()
                txtSSN.Text = dr.Cells(7).Value.ToString()
                txtlev3.Text = dr.Cells(20).Value.ToString()
                txtlev1.Text = dr.Cells(18).Value.ToString()
                txtlev2.Text = dr.Cells(19).Value.ToString()
                cmbPayrollType.Text = dr.Cells(8).Value.ToString()
            cmbfac.SelectedValue = dr.Cells(21).Value.ToString()
            cmbdept.SelectedValue = dr.Cells(22).Value.ToString()
            cmblev.SelectedValue = dr.Cells(23).Value.ToString()

            CheckBox1.Checked = If(dr.Cells(17).Value Is DBNull.Value, False, Convert.ToBoolean(dr.Cells(17).Value))

                chkActive.Checked = (dr.Cells(9).Value.ToString() = "Yes")
                chkBackoffice.Checked = (dr.Cells(11).Value.ToString() = "Yes")
                chkquotation.Checked = (dr.Cells(12).Value.ToString() = "Yes")
                chkBill.Checked = (dr.Cells(13).Value.ToString() = "Yes")
                chkCredit.Checked = (dr.Cells(14).Value.ToString() = "Yes")
                chksales.Checked = (dr.Cells(15).Value.ToString() = "Yes")
                chkSalesList.Checked = (dr.Cells(16).Value.ToString() = "Yes")

                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                btnSave.Enabled = False
                txtUserID.Enabled = False
            End If

    End Sub


    Private Sub dgw_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub


    Private Sub btnCheckAvailability_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckAvailability.Click
        If txtUserID.Text = "" Then
            MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserID.Focus()
            Return
        End If
        Try
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select userid from registration where userid=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("User ID not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            Else
                MessageBox.Show("User ID available", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Try
            If txtUserID.Text = "" Then
                MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUserID.Focus()
                Return
            End If
            If cmbUserType.Text = "" Then
                MessageBox.Show("Please select user type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbUserType.Focus()
                Return
            End If
            If txtPassword.Text = "" Then
                MessageBox.Show("Please enter pin", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Focus()
                Return
            End If
            If txtName.Text = "" Then
                MessageBox.Show("Please enter name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtName.Focus()
                Return
            End If
            If txtEmailID.Text = "" Then
                MessageBox.Show("Please enter email id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmailID.Focus()
                Return
            End If
            If txtContactNo.Text = "" Then
                MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContactNo.Focus()
                Return
            End If

            ' Validate the new fields
            If cmbfac.SelectedValue Is Nothing Then
                MessageBox.Show("Please select a faculty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbfac.Focus()
                Return
            End If
            If cmbdept.SelectedValue Is Nothing Then
                MessageBox.Show("Please select a department", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbdept.Focus()
                Return
            End If
            If cmblev.SelectedValue Is Nothing Then
                MessageBox.Show("Please select a level", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmblev.Focus()
                Return
            End If

            If chkActive.Checked = True Then
                st1 = "Yes"
            Else
                st1 = "No"
            End If

            If txtPassword.Text <> txtPIN.Text Then
                con = New SqlConnection(cs)
                con.Open()
                Dim ct As String = "select Password from registration where Password=@d1"
                cmd = New SqlCommand(ct)
                cmd.Parameters.AddWithValue("@d1", Encrypt(txtPassword.Text))
                cmd.Connection = con
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    MessageBox.Show("PIN is already in use", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
                con.Close()
            End If

            If txtEmail.Text <> txtEmailID.Text Then
                con = New SqlConnection(cs)
                con.Open()
                Dim ct2 As String = "select EmailID from registration where EmailID=@d1"
                cmd = New SqlCommand(ct2)
                cmd.Parameters.AddWithValue("@d1", txtEmailID.Text)
                cmd.Connection = con
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    MessageBox.Show("Email id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
                con.Close()
            End If

            If txtCardNo.Text <> txtCNo.Text Then
                con = New SqlConnection(cs)
                con.Open()
                Dim ct11 As String = "select CardNo from registration where CardNo=@d1 and CardNo is Not NULL and CardNo <> ''"
                cmd = New SqlCommand(ct11)
                cmd.Parameters.AddWithValue("@d1", txtCardNo.Text)
                cmd.Connection = con
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    MessageBox.Show("Card No. already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    txtCardNo.Text = ""
                    txtCardNo.Focus()
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    Return
                End If
                con.Close()
            End If

            If chkActive.Checked = True Then
                st1 = "Yes"
            Else
                st1 = "No"
            End If

            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "update registration set userid=@d1, usertype=@d2, password=@d3, name=@d4, contactno=@d5, emailid=@d6, Active=@d8, SSN=@d9, PayrollType=@d10, CardNo=@d11, AllowAccess=@d12, Quotation=@d13, BillReprint=@d14, CreditCustomer=@d15, SalesReturn=@d16, SalesList=@d17, lall=@lall, plev1=@plev1, plev2=@plev2, plev3=@plev3, FacultyId=@d18, DeptId=@d19, LevelId=@d20 where userid=@d7"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
            cmd.Parameters.AddWithValue("@d2", cmbUserType.Text)
            cmd.Parameters.AddWithValue("@d3", Encrypt(txtPassword.Text.Trim()))
            cmd.Parameters.AddWithValue("@d4", txtName.Text)
            cmd.Parameters.AddWithValue("@d5", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d6", txtEmailID.Text)
            cmd.Parameters.AddWithValue("@d7", TextBox1.Text)
            cmd.Parameters.AddWithValue("@d8", st1)
            cmd.Parameters.AddWithValue("@d9", txtSSN.Text)
            cmd.Parameters.AddWithValue("@d10", cmbPayrollType.Text)
            cmd.Parameters.AddWithValue("@d11", txtCardNo.Text)
            cmd.Parameters.AddWithValue("@plev1", If(String.IsNullOrEmpty(txtlev1.Text), DBNull.Value, txtlev1.Text))
            cmd.Parameters.AddWithValue("@plev2", If(String.IsNullOrEmpty(txtlev2.Text), DBNull.Value, txtlev2.Text))
            cmd.Parameters.AddWithValue("@plev3", If(String.IsNullOrEmpty(txtlev3.Text), DBNull.Value, txtlev3.Text))
            cmd.Parameters.AddWithValue("@lall", CheckBox1.CheckState)
            cmd.Parameters.AddWithValue("@d18", cmbfac.SelectedValue)
            cmd.Parameters.AddWithValue("@d19", cmbdept.SelectedValue)
            cmd.Parameters.AddWithValue("@d20", cmblev.SelectedValue)

            If chkBackoffice.Checked = True Then
                cmd.Parameters.AddWithValue("@d12", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d12", "No")
            End If
            If chkquotation.Checked = True Then
                cmd.Parameters.AddWithValue("@d13", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d13", "No")
            End If
            If chkBill.Checked = True Then
                cmd.Parameters.AddWithValue("@d14", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d14", "No")
            End If
            If chkCredit.Checked = True Then
                cmd.Parameters.AddWithValue("@d15", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d15", "No")
            End If
            If chksales.Checked = True Then
                cmd.Parameters.AddWithValue("@d16", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d16", "No")
            End If
            If chkSalesList.Checked = True Then
                cmd.Parameters.AddWithValue("@d17", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d17", "No")
            End If

            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("Successfully updated", "User Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtUserID.Text = "" Then
            MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUserID.Focus()
            Return
        End If
        If cmbUserType.Text = "" Then
            MessageBox.Show("Please select user type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbUserType.Focus()
            Return
        End If
        If txtPassword.Text = "" Then
            MessageBox.Show("Please enter pin", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If
        If txtName.Text = "" Then
            MessageBox.Show("Please enter name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If
        If txtEmailID.Text = "" Then
            MessageBox.Show("Please enter email id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmailID.Focus()
            Return
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If

        ' Validate the new fields
        If cmbfac.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a faculty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbfac.Focus()
            Return
        End If
        If cmbdept.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a department", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbdept.Focus()
            Return
        End If
        If cmblev.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a level", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmblev.Focus()
            Return
        End If

        Try
            Using con As New SqlConnection(cs)
                con.Open()
                Dim ct As String = "select userid from registration where userid=@d1"
                Using cmd As New SqlCommand(ct, con)
                    cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("user id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            txtUserID.Text = ""
                            txtUserID.Focus()
                            Return
                        End If
                    End Using
                End Using
            End Using

            Using con As New SqlConnection(cs)
                con.Open()
                Dim ct2 As String = "select EmailID from registration where EmailID=@d1"
                Using cmd As New SqlCommand(ct2, con)
                    cmd.Parameters.AddWithValue("@d1", txtEmailID.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Email id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            Return
                        End If
                    End Using
                End Using
            End Using

            Using con As New SqlConnection(cs)
                con.Open()
                Dim ct1 As String = "select password from registration where Password=@d1"
                Using cmd As New SqlCommand(ct1, con)
                    cmd.Parameters.AddWithValue("@d1", Encrypt(txtPassword.Text))
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Pin is already in use for other user", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            txtPassword.Text = ""
                            txtPassword.Focus()
                            Return
                        End If
                    End Using
                End Using
            End Using

            Using con As New SqlConnection(cs)
                con.Open()
                Dim ct11 As String = "select CardNo from registration where CardNo=@d1 and CardNo is Not NULL and CardNo <> ''"
                Using cmd As New SqlCommand(ct11, con)
                    cmd.Parameters.AddWithValue("@d1", txtCardNo.Text)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            MessageBox.Show("Card No. already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                            txtCardNo.Text = ""
                            txtCardNo.Focus()
                            Return
                        End If
                    End Using
                End Using
            End Using

            Dim st1 As String = If(chkActive.Checked, "Yes", "No")

            Using con As New SqlConnection(cs)
                con.Open()
                Dim cb As String = "insert into Registration(userid, UserType, Password, Name, ContactNo, EmailID, JoiningDate, Active, SSN, PayrollType, CardNo, AllowAccess, Quotation, BillReprint, CreditCustomer, SalesReturn, SalesList, lall, plev1, plev2, plev3, FacultyId, DeptId, LevelId) VALUES (@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8, @d9, @d10, @d11, @d12, @d13, @d14, @d15, @d16, @d17, @lall, @plev1, @plev2, @plev3, @d18, @d19, @d20)"
                Using cmd As New SqlCommand(cb, con)
                    cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
                    cmd.Parameters.AddWithValue("@d2", cmbUserType.Text)
                    cmd.Parameters.AddWithValue("@d3", Encrypt(txtPassword.Text.Trim()))
                    cmd.Parameters.AddWithValue("@d4", txtName.Text)
                    cmd.Parameters.AddWithValue("@d5", txtContactNo.Text)
                    cmd.Parameters.AddWithValue("@d6", txtEmailID.Text)
                    cmd.Parameters.AddWithValue("@d7", Now)
                    cmd.Parameters.AddWithValue("@d8", st1)
                    cmd.Parameters.AddWithValue("@d9", txtSSN.Text)
                    cmd.Parameters.AddWithValue("@d10", cmbPayrollType.Text)
                    cmd.Parameters.AddWithValue("@d11", txtCardNo.Text)
                    cmd.Parameters.AddWithValue("@plev1", If(String.IsNullOrEmpty(txtlev1.Text), DBNull.Value, txtlev1.Text))
                    cmd.Parameters.AddWithValue("@plev2", If(String.IsNullOrEmpty(txtlev2.Text), DBNull.Value, txtlev2.Text))
                    cmd.Parameters.AddWithValue("@plev3", If(String.IsNullOrEmpty(txtlev3.Text), DBNull.Value, txtlev3.Text))
                    cmd.Parameters.AddWithValue("@lall", CheckBox1.CheckState)
                    cmd.Parameters.AddWithValue("@d12", If(chkBackoffice.Checked, "Yes", "No"))
                    cmd.Parameters.AddWithValue("@d13", If(chkquotation.Checked, "Yes", "No"))
                    cmd.Parameters.AddWithValue("@d14", If(chkBill.Checked, "Yes", "No"))
                    cmd.Parameters.AddWithValue("@d15", If(chkCredit.Checked, "Yes", "No"))
                    cmd.Parameters.AddWithValue("@d16", If(chksales.Checked, "Yes", "No"))
                    cmd.Parameters.AddWithValue("@d17", If(chkSalesList.Checked, "Yes", "No"))
                    cmd.Parameters.AddWithValue("@d18", cmbfac.SelectedValue)
                    cmd.Parameters.AddWithValue("@d19", cmbdept.SelectedValue)
                    cmd.Parameters.AddWithValue("@d20", cmblev.SelectedValue)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub dgw_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgw.CellFormatting
        If (e.ColumnIndex = 2) AndAlso e.Value IsNot Nothing Then
            dgw.Rows(e.RowIndex).Tag = e.Value
            e.Value = New [String]("●"c, e.Value.ToString().Length)
        End If
    End Sub

    Private Sub dgw_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgw.EditingControlShowing
        If dgw.CurrentCell.ColumnIndex = 2 Then
            'select target column
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = True
            End If
        Else
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = False
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim obj As frmBackOffice = DirectCast(Application.OpenForms("frmBackOffice"), frmBackOffice)
        obj.lblUser.Text = lblUser.Text
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPassword_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtPassword.Validating
        If txtPassword.Text.Length < 4 Then
            MessageBox.Show("PIN must be of 4 digits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            Exit Sub
        End If
        If txtPassword.Text.Length > 4 Then
            MessageBox.Show("Only 4 digits pin is allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            Exit Sub
        End If
    End Sub



    Private Sub LoadFaculty()
        Dim Sql As String = "SELECT id, faculty FROM faculty"
        Dim parameters As New List(Of SqlClient.SqlParameter)()
        Dim dt As DataTable = Crud(Sql, parameters)
        cmbfac.DisplayMember = "faculty"
        cmbfac.ValueMember = "id"
        cmbfac.DataSource = dt
    End Sub

    Private Sub LoadLevel()
        Dim Sql As String = "SELECT id, Level FROM levels"
        Dim parameters As New List(Of SqlClient.SqlParameter)()
        Dim dt As DataTable = Crud(Sql, parameters)
        cmblev.DisplayMember = "Level"
        cmblev.ValueMember = "id"
        cmblev.DataSource = dt
    End Sub

    Private Sub LoadDepartment()
        If cmbfac.SelectedValue IsNot Nothing Then
            Dim facultyId As Integer = CInt(cmbfac.SelectedValue)
            Dim Sql As String = "SELECT id, dept FROM dept WHERE facultyid = @facultyid"
            Dim parameters As New List(Of SqlClient.SqlParameter)() From {
                New SqlClient.SqlParameter("@facultyid", facultyId)
            }
            Dim dt As DataTable = Crud(Sql, parameters)

            cmbdept.DisplayMember = "dept"
            cmbdept.ValueMember = "id"
            cmbdept.DataSource = dt
        End If
    End Sub

    Private Sub cmbFac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfac.SelectedIndexChanged
        LoadDepartment()
    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFaculty()
        LoadLevel()
        Getdata()
    End Sub
End Class
