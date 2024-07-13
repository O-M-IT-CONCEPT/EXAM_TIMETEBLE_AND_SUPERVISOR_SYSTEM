Imports System.Data.SqlClient
Imports System.IO
Imports Newtonsoft.Json
Imports RevmaxAPI
Public Class frmCompany
    Dim s1, s2, s3, s4, s5, s6 As String

    Sub Reset()
        chkBelow.Checked = False
        chkZero.Checked = False
        chkActiveBelow.Checked = False
        txtAddressLine1.Text = ""
        txtAddressLine2.Text = ""
        txtCompanyName.Text = ""
        txtContactNo.Text = ""
        chkCheckTax.Checked = False
        txtEmail.Text = ""
        txtFax.Text = ""
        txtProcessingFeePer.Text = "0.00"
        cmbWSGB.SelectedIndex = 0
        txtPinCode.Text = ""
        txtAddressLine3.Text = ""
        txtTIN.Text = ""
        cmbDefaultPrintSize.SelectedIndex = 0
        cmbCountry.Text = ""
        chkAskPIN.Checked = False
        txtBillFooterNote.Text = "Thanks....Visit Again!"
        txtBaseCurrency.Text = ""
        txtCurrencyCode.Text = ""
        PictureBox1.Image = My.Resources.havano_pos_logo
        txtCompanyName.Focus()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        chkShowLogo.Checked = False
        txtCapitalAccount.Enabled = True
        chkQRCode.Checked = False
        chkBarcode.Checked = True
        txtNoOfCopy.Text = 1
        txtCapitalAccount.Text = "0.00"
        txtInvoiceHeader.Text = "TAX INVOICE"
        txtQTandC.Text = ""
        chkItemwiseVAT.Checked = True
        companyInfo = getOrgName()
        Getdata()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtCompanyName.Text = "" Then
            MessageBox.Show("Please enter company name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCompanyName.Focus()
            Return
        End If
        If cmbCountry.Text = "" Then
            MessageBox.Show("Please select country", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCountry.Focus()
            Return
        End If
        If txtAddressLine1.Text = "" Then
            MessageBox.Show("Please enter address line 1", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddressLine1.Focus()
            Return
        End If
        If txtAddressLine2.Text = "" Then
            MessageBox.Show("Please enter address line 2", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddressLine2.Focus()
            Return
        End If
        If txtAddressLine3.Text = "" Then
            MessageBox.Show("Please enter address line 3", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddressLine3.Focus()
            Return
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If

        If txtEmail.Text = "" Then
            MessageBox.Show("Please enter email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If
        If txtTIN.Text = "" Then
            MessageBox.Show("Please enter TIN number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTIN.Focus()
            Return
        End If

        If txtVatNo.Text = "" Then
            MessageBox.Show("Please enter Vat Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtVatNo.Focus()
            Return
        End If



        If txtBaseCurrency.Text = "" Then
            MessageBox.Show("Please enter base currency", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBaseCurrency.Focus()
            Return
        End If
        If txtCurrencyCode.Text = "" Then
            MessageBox.Show("Please enter currency code", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCurrencyCode.Focus()
            Return
        End If
        If txtBillFooterNote.Text = "" Then
            MessageBox.Show("Please enter bill footer note", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBillFooterNote.Focus()
            Return
        End If
        If Val(txtNoOfCopy.Text) < 1 Then
            MessageBox.Show("Print no. of copies of sales invoice can't be less than 1", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNoOfCopy.Text = ""
            txtNoOfCopy.Focus()
            Return
        End If
        Try
            If chkShowLogo.Checked = True Then
                s1 = "Yes"
            Else
                s1 = "No"
            End If
            If chkCheckTax.Checked = True Then
                s2 = "Yes"
            Else
                s2 = "No"
            End If
            If chkAskPIN.Checked = True Then
                s3 = "Yes"
            Else
                s3 = "No"
            End If
            If chkBarcode.Checked = True Then
                s4 = "Yes"
            Else
                s4 = "No"
            End If
            If chkQRCode.Checked = True Then
                s5 = "Yes"
            Else
                s5 = "No"
            End If
            If chkItemwiseVAT.Checked = True Then
                s6 = "Yes"
            Else
                s6 = "No"
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "insert into Company(CompanyName, MailingName, Country, Address, 
City, State, PinCode, ContactNo, Fax, Email, Website, TIN, LicenseNo, CST,PAN,ServiceTaxNo,Currency, 
CurrencyCode,Logo,ShowLogo,CapitalAccount,BCode,QCode,NP,InvoiceHeader,ItemwiseVAT,QTC,ZeroPrice,BelowCost, 
 ActiveBelow,pscalable,wscalable,MultiCurrencyReceipt,ShowMultiCurrency,VatNo,RevMaxKey,ShowDiscount,EnableRevMax,selnegative,patchinter) 
VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19 
 ,@d20," & Val(txtCapitalAccount.Text) & ",@d21,@d22,@d23,@d24,@d25,@d26,@d27,@d28,@d29,@d30,@d31,@d32, 
 @d33,@d34,@d35,@d36,@d37,@selnegative,@patchinter)"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@d2", cmbWSGB.Text)
            cmd.Parameters.AddWithValue("@d3", cmbCountry.Text)
            cmd.Parameters.AddWithValue("@d4", txtAddressLine1.Text)
            cmd.Parameters.AddWithValue("@d5", txtAddressLine2.Text)
            cmd.Parameters.AddWithValue("@d6", txtAddressLine3.Text)
            cmd.Parameters.AddWithValue("@d7", txtPinCode.Text)
            cmd.Parameters.AddWithValue("@d8", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d9", txtFax.Text)
            cmd.Parameters.AddWithValue("@d10", txtEmail.Text)
            cmd.Parameters.AddWithValue("@d11", cmbDefaultPrintSize.Text)
            cmd.Parameters.AddWithValue("@d12", txtTIN.Text)
            cmd.Parameters.AddWithValue("@d13", Val(txtProcessingFeePer.Text))
            cmd.Parameters.AddWithValue("@d14", s2)
            cmd.Parameters.AddWithValue("@d15", s3)
            cmd.Parameters.AddWithValue("@d16", txtBillFooterNote.Text)
            cmd.Parameters.AddWithValue("@d17", txtBaseCurrency.Text)
            cmd.Parameters.AddWithValue("@d18", txtCurrencyCode.Text)
            cmd.Parameters.AddWithValue("@d20", s1)
            cmd.Parameters.AddWithValue("@d21", s4)
            cmd.Parameters.AddWithValue("@d22", s5)
            cmd.Parameters.AddWithValue("@d23", Val(txtNoOfCopy.Text))
            cmd.Parameters.AddWithValue("@d24", txtInvoiceHeader.Text)
            cmd.Parameters.AddWithValue("@d25", s6)
            cmd.Parameters.AddWithValue("@d26", txtQTandC.Text)
            cmd.Parameters.AddWithValue("@patchinter", CheckBox2.CheckState)
            If chkZero.Checked = True Then
                cmd.Parameters.AddWithValue("@d27", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d27", "No")
            End If
            If chkBelow.Checked = True Then
                cmd.Parameters.AddWithValue("@d28", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d28", "No")
            End If
            If chkActiveBelow.Checked = True Then
                cmd.Parameters.AddWithValue("@d29", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d29", "No")
            End If
            cmd.Parameters.AddWithValue("@d30", chkPriceScalable.CheckState)
            cmd.Parameters.AddWithValue("@d31", chkWeightScalable.CheckState)
            cmd.Parameters.AddWithValue("@d32", chkMultiCurrency.CheckState)
            cmd.Parameters.AddWithValue("@d33", chkShowMulti.CheckState)
            cmd.Parameters.AddWithValue("@d34", txtVatNo.Text)
            cmd.Parameters.AddWithValue("@d35", txtRevMaxKey.Text)
            cmd.Parameters.AddWithValue("@d36", chkDiscount.CheckState)
            cmd.Parameters.AddWithValue("@d37", chkRevMax.CheckState)
            cmd.Parameters.AddWithValue("@selnegative", CheckBox1.CheckState)
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PictureBox1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d19", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con.Close()
            If Val(txtCapitalAccount.Text) > 0 Then
                LedgerSave(Today, "Cash", "1", "Initial Fund", Val(txtCapitalAccount.Text), 0, "", "Capital A/c", "")
                LedgerSave(Today, "Capital A/c", "1", "Initial Fund", 0, Val(txtCapitalAccount.Text), "", "Cash", "")
            End If
            Dim st As String = "added the comapany '" & txtCompanyName.Text & "' info"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtCompanyName.Text = "" Then
            MessageBox.Show("Please enter company name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCompanyName.Focus()
            Return
        End If
        If cmbCountry.Text = "" Then
            MessageBox.Show("Please select country", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCountry.Focus()
            Return
        End If
        If txtAddressLine1.Text = "" Then
            MessageBox.Show("Please enter address line 1", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddressLine1.Focus()
            Return
        End If
        If txtAddressLine2.Text = "" Then
            MessageBox.Show("Please enter address line 2", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddressLine2.Focus()
            Return
        End If
        If txtAddressLine3.Text = "" Then
            MessageBox.Show("Please enter address line 3", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddressLine3.Focus()
            Return
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNo.Focus()
            Return
        End If

        If txtEmail.Text = "" Then
            MessageBox.Show("Please enter email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If
        If txtBaseCurrency.Text = "" Then
            MessageBox.Show("Please enter base currency", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBaseCurrency.Focus()
            Return
        End If
        If txtCurrencyCode.Text = "" Then
            MessageBox.Show("Please enter currency code", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCurrencyCode.Focus()
            Return
        End If
        Try
            If chkShowLogo.Checked = True Then
                s1 = "Yes"
            Else
                s1 = "No"
            End If
            If chkCheckTax.Checked = True Then
                s2 = "Yes"
            Else
                s2 = "No"
            End If
            If chkAskPIN.Checked = True Then
                s3 = "Yes"
            Else
                s3 = "No"
            End If
            If chkBarcode.Checked = True Then
                s4 = "Yes"
            Else
                s4 = "No"
            End If
            If chkQRCode.Checked = True Then
                s5 = "Yes"
            Else
                s5 = "No"
            End If
            If chkItemwiseVAT.Checked = True Then
                s6 = "Yes"
            Else
                s6 = "No"
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim cb3 As String = "update InvoiceInfo set CurrencyCode=@d1 where CurrencyCode=@d2"
            cmd = New SqlCommand(cb3)
            cmd.Parameters.AddWithValue("@d1", txtCurrencyCode.Text)
            cmd.Parameters.AddWithValue("@d2", txtCcode.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb1 As String = "update Product_OpeningStock set Warehouse_Store=@d1 where Warehouse_Store=@d2"
            cmd = New SqlCommand(cb1)
            cmd.Parameters.AddWithValue("@d1", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@d2", txtCName.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb2 As String = "update Purchase_Join set Warehouse_Store=@d1 where Warehouse_Store=@d2"
            cmd = New SqlCommand(cb2)
            cmd.Parameters.AddWithValue("@d1", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@d2", txtCName.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb4 As String = "update PurchaseReturn_Join set Warehouse_Store=@d1 where Warehouse_Store=@d2"
            cmd = New SqlCommand(cb4)
            cmd.Parameters.AddWithValue("@d1", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@d2", txtCName.Text)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update Company set CompanyName=@d1, MailingName=@d2, Country=@d3, 
Address=@d4, City=@d5, State=@d6, PinCode=@d7, ContactNo=@d8, Fax=@d9, Email=@d10, Website=@d11, TIN=@d12,  
LicenseNo=@d13, CST=@d14,PAN=@d15,ServiceTaxNo=@d16,Currency=@d17, CurrencyCode=@d18,Logo=@d19,ShowLogo=@d20, 
 CapitalAccount=" & Val(txtCapitalAccount.Text) & ",BCode=@d21,QCode=@d22,NP=@d23,InvoiceHeader=@d24,ItemwiseVAT=@d25,QTC=@d26, 
 ZeroPrice=@d27,BelowCost=@d28,ActiveBelow=@d29,pscalable=@d30, wscalable=@d31, MultiCurrencyReceipt=@d32,ShowMultiCurrency=@d33, 
 VatNo=@d34,RevMaxKey=@d35,ShowDiscount=@d36,EnableRevMax=@d37, selnegative =@selnegative, patchinter =@patchinter,cash=@cash,autoprint=@autoprint 
 , autoprintshift=@autoprintshift  where ID=" & txtID.Text & ""
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtCompanyName.Text)
            cmd.Parameters.AddWithValue("@d2", cmbWSGB.Text)
            cmd.Parameters.AddWithValue("@d3", cmbCountry.Text)
            cmd.Parameters.AddWithValue("@d4", txtAddressLine1.Text)
            cmd.Parameters.AddWithValue("@d5", txtAddressLine2.Text)
            cmd.Parameters.AddWithValue("@d6", txtAddressLine3.Text)
            cmd.Parameters.AddWithValue("@d7", txtPinCode.Text)
            cmd.Parameters.AddWithValue("@d8", txtContactNo.Text)
            cmd.Parameters.AddWithValue("@d9", txtFax.Text)
            cmd.Parameters.AddWithValue("@d10", txtEmail.Text)
            cmd.Parameters.AddWithValue("@d11", cmbDefaultPrintSize.Text)
            cmd.Parameters.AddWithValue("@d12", txtTIN.Text)
            cmd.Parameters.AddWithValue("@d13", Val(txtProcessingFeePer.Text))
            cmd.Parameters.AddWithValue("@d14", s2)
            cmd.Parameters.AddWithValue("@d15", s3)
            cmd.Parameters.AddWithValue("@d16", txtBillFooterNote.Text)
            cmd.Parameters.AddWithValue("@d17", txtBaseCurrency.Text)
            cmd.Parameters.AddWithValue("@d18", txtCurrencyCode.Text)
            cmd.Parameters.AddWithValue("@d20", s1)
            cmd.Parameters.AddWithValue("@d21", s4)
            cmd.Parameters.AddWithValue("@d22", s5)
            cmd.Parameters.AddWithValue("@d23", Val(txtNoOfCopy.Text))
            cmd.Parameters.AddWithValue("@d24", txtInvoiceHeader.Text)
            cmd.Parameters.AddWithValue("@d25", s6)
            cmd.Parameters.AddWithValue("@d26", txtQTandC.Text)
            cmd.Parameters.AddWithValue("@selnegative", CheckBox1.CheckState)
            cmd.Parameters.AddWithValue("@patchinter", CheckBox2.CheckState)
            cmd.Parameters.AddWithValue("@cash", chkcash.CheckState)
            cmd.Parameters.AddWithValue("@autoprint", chkautoprint.CheckState)
            cmd.Parameters.AddWithValue("@autoprintshift", chkautoprintshift.CheckState)
            If chkZero.Checked = True Then
                cmd.Parameters.AddWithValue("@d27", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d27", "No")
            End If
            If chkBelow.Checked = True Then
                cmd.Parameters.AddWithValue("@d28", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d28", "No")
            End If
            If chkActiveBelow.Checked = True Then
                cmd.Parameters.AddWithValue("@d29", "Yes")
            Else
                cmd.Parameters.AddWithValue("@d29", "No")
            End If
            cmd.Parameters.AddWithValue("@d30", chkPriceScalable.CheckState)
            cmd.Parameters.AddWithValue("@d31", chkWeightScalable.CheckState)
            cmd.Parameters.AddWithValue("@d32", chkMultiCurrency.CheckState)
            cmd.Parameters.AddWithValue("@d33", chkShowMulti.CheckState)
            cmd.Parameters.AddWithValue("@d34", txtVatNo.Text)
            cmd.Parameters.AddWithValue("@d35", txtRevMaxKey.Text)
            cmd.Parameters.AddWithValue("@d36", chkDiscount.CheckState)
            cmd.Parameters.AddWithValue("@d37", chkRevMax.CheckState)

            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(PictureBox1.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@d19", SqlDbType.Image)
            p.Value = data
            cmd.Parameters.Add(p)
            cmd.ExecuteNonQuery()
            con.Close()
            Dim st As String = "updated the comapany '" & txtCompanyName.Text & "' info"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnDelete.Enabled = False
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Public Sub Getdata()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT (ID), RTRIM(CompanyName), RTRIM(MailingName), RTRIM(Country), RTRIM(Address), RTRIM(City), RTRIM(State), RTRIM(PinCode), RTRIM(ContactNo), RTRIM(Fax), RTRIM(Email), RTRIM(Website), RTRIM(TIN), RTRIM(LicenseNo),CapitalAccount, RTRIM(CST),RTRIM(PAN),RTRIM(ServiceTaxNo),RTRIM(Currency), RTRIM(CurrencyCode),Logo,RTRIM(ShowLogo),RTRIM(BCode),RTRIM(QCode),NP,RTRIM(InvoiceHeader),RTRIM(ItemwiseVAT),RTRIM(QTC),ZeroPrice,BelowCost,ActiveBelow,pscalable, wscalable,MultiCurrencyReceipt,ShowMultiCurrency,VatNo,RevMaxKey,ShowDiscount,EnableRevMax,selnegative,patchinter from Company", con)
            Dim rdr1 As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If (rdr1.Read() = True) Then
                If IsViewAllowed(lblUser.Text, "Company Master") = True Then
                    txtID.Text = rdr1.GetValue(0)
                    txtCompanyName.Text = rdr1.GetValue(1).ToString()
                    txtCName.Text = rdr1.GetValue(1).ToString()
                    cmbWSGB.Text = rdr1.GetValue(2).ToString()
                    cmbCountry.Text = rdr1.GetValue(3).ToString()
                    txtAddressLine1.Text = rdr1.GetValue(4).ToString()
                    txtAddressLine2.Text = rdr1.GetValue(5).ToString()
                    txtAddressLine3.Text = rdr1.GetValue(6).ToString()
                    txtPinCode.Text = rdr1.GetValue(7).ToString()
                    txtContactNo.Text = rdr1.GetValue(8).ToString()
                    txtFax.Text = rdr1.GetValue(9).ToString()
                    txtEmail.Text = rdr1.GetValue(10).ToString()
                    cmbDefaultPrintSize.Text = rdr1.GetValue(11).ToString()
                    txtTIN.Text = rdr1.GetValue(12).ToString()
                    txtProcessingFeePer.Text = rdr1.GetValue(13).ToString()
                    txtCapitalAccount.Text = rdr1.GetValue(14).ToString()
                    Try
                        CheckBox1.Checked = Convert.ToBoolean(rdr1.GetValue(39).ToString()) '39
                    Catch ex As Exception
                        CheckBox1.Checked = False
                        MsgBox(ex.ToString())
                    End Try

                    If rdr1.GetValue(15).ToString() = "Yes" Then
                        chkCheckTax.Checked = True
                    Else
                        chkCheckTax.Checked = False
                    End If
                    If rdr1.GetValue(16).ToString() = "Yes" Then
                        chkAskPIN.Checked = True
                    Else
                        chkAskPIN.Checked = False
                    End If
                    txtBillFooterNote.Text = rdr1.GetValue(17).ToString()
                    txtBaseCurrency.Text = rdr1.GetValue(18).ToString()
                    txtCurrencyCode.Text = rdr1.GetValue(19).ToString()
                    txtCcode.Text = rdr1.GetValue(19).ToString()
                    Try
                        Dim data As Byte() = DirectCast(rdr1.GetValue(20), Byte())
                        Dim ms As New MemoryStream(data)
                        Me.PictureBox1.Image = Image.FromStream(ms)
                    Catch ex As Exception
                        PictureBox1.Image = My.Resources.havano_pos_logo
                    End Try

                    If rdr1.GetValue(21).ToString() = "Yes" Then
                        chkShowLogo.Checked = True
                    Else
                        chkShowLogo.Checked = False
                    End If
                    If rdr1.GetValue(22).ToString() = "Yes" Then
                        chkBarcode.Checked = True
                    Else
                        chkBarcode.Checked = False
                    End If
                    If rdr1.GetValue(23).ToString() = "Yes" Then
                        chkQRCode.Checked = True
                    Else
                        chkQRCode.Checked = False
                    End If
                    txtNoOfCopy.Text = rdr1.GetValue(24).ToString()
                    If rdr1.GetValue(26).ToString() = "Yes" Then
                        chkItemwiseVAT.Checked = True
                    Else
                        chkItemwiseVAT.Checked = False
                    End If
                    txtInvoiceHeader.Text = rdr1.GetValue(25).ToString()
                    txtQTandC.Text = rdr1.GetValue(27).ToString()
                End If
                If IsDeleteAllowed(lblUser.Text, "Company Master") = True Then
                    btnDelete.Enabled = True
                Else
                    btnDelete.Enabled = False
                End If
                ' If IsUpdateAllowed(lblUser.Text, "Company Master") = True Then
                btnUpdate.Enabled = True
                'Else
                '   btnUpdate.Enabled = False
                'End If
                txtCapitalAccount.Enabled = False
                btnSave.Enabled = False
            Else
                If IsSaveAllowed(lblUser.Text, "Company Master") = True Then
                    btnSave.Enabled = True
                Else
                    btnSave.Enabled = False
                End If
            End If
            If rdr1.GetValue(28).ToString() = "Yes" Then
                chkZero.Checked = True
            Else
                chkZero.Checked = False
            End If
            If rdr1.GetValue(29).ToString() = "Yes" Then
                chkBelow.Checked = True
            Else
                chkBelow.Checked = False
            End If
            If rdr1.GetValue(30).ToString() = "Yes" Then
                chkActiveBelow.Checked = True
            Else
                chkActiveBelow.Checked = False
            End If
            chkPriceScalable.Checked = Convert.ToBoolean(rdr1.GetValue(31).ToString())
            chkWeightScalable.Checked = Convert.ToBoolean(rdr1.GetValue(32).ToString())
            chkMultiCurrency.Checked = Convert.ToBoolean(rdr1.GetValue(33).ToString())
            chkShowMulti.Checked = Convert.ToBoolean(rdr1.GetValue(34).ToString())
            txtVatNo.Text = rdr1.GetValue(35).ToString()
            txtRevMaxKey.Text = rdr1.GetValue(36).ToString()
            chkDiscount.Checked = Convert.ToBoolean(rdr1.GetValue(37).ToString())
            chkRevMax.Checked = Convert.ToBoolean(rdr1.GetValue(38).ToString())
            CheckBox2.Checked = CBool(rdr1.GetValue(40).ToString())
            CheckBox1.Checked = CBool(rdr1.GetValue(39).ToString())
            chkcash.Checked = companyInfo.cash
            chkautoprint.Checked = companyInfo.autoprint
            chkautoprintshift.Checked = companyInfo.autoprintshift
            con.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cl2 As String = "select Warehouse_Store from Product_OpeningStock,Company where Product_OpeningStock.Warehouse_Store=Company.CompanyName and Warehouse_Store=@d1"
            cmd = New SqlCommand(cl2)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtCName.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Product Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cl As String = "select ID from Company,StockTransfer where Company.ID=StockTransfer.CompanyID and ID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", Val(txtID.Text))
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Stock Transfer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Company where ID=@d1"
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", Val(txtID.Text))
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the Company '" & txtCompanyName.Text & "' info"
                LogFunc(lblUser.Text, st)
                LedgerDelete("1", "Initial Fund")
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub txtCurrencyCode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurrencyCode.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

    Private Sub chkPriceScalable_CheckedChanged(sender As Object, e As EventArgs) Handles chkPriceScalable.CheckedChanged
        If chkPriceScalable.Checked = True And chkWeightScalable.Checked = True Then
            chkWeightScalable.CheckState = False
        End If
    End Sub

    Private Sub chkWeightScalable_CheckedChanged(sender As Object, e As EventArgs) Handles chkWeightScalable.CheckedChanged
        If chkPriceScalable.Checked = True And chkWeightScalable.Checked = True Then
            chkPriceScalable.CheckState = False
        End If
    End Sub

    Private Sub btnSetLicense_Click(sender As Object, e As EventArgs) Handles btnSetLicense.Click
        If txtRevMaxKey.Text = "" Then
            MessageBox.Show("Please enter License Key", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRevMaxKey.Focus()
            Return
        End If

        Dim revmax As New Revmaxlib()
        Dim revresponse As String = revmax.SetLicense(txtRevMaxKey.Text.Trim())
        Dim revMsg As LicenseRoot = JsonConvert.DeserializeObject(Of LicenseRoot)(revresponse)
        MessageBox.Show(revMsg.Message)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        companyInfo = getOrgName()
    End Sub



    Private Sub txtProcessingFeePer_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtProcessingFeePer.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtProcessingFeePer.Text
            Dim selectionStart = Me.txtProcessingFeePer.SelectionStart
            Dim selectionLength = Me.txtProcessingFeePer.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txtCapitalAccount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapitalAccount.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtCapitalAccount.Text
            Dim selectionStart = Me.txtCapitalAccount.SelectionStart
            Dim selectionLength = Me.txtCapitalAccount.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub frmCompany_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

    Private Sub txtNoOfCopy_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoOfCopy.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
End Class
Public Class LicenseData
    Public Status As String
    Public Start As String
    Public [End] As String
End Class

Public Class LicenseRoot
    Public Code As String
    Public Message As String
    Public QRcode As String
    Public VerificationCode As String
    Public FiscalDay As String
    Public LicenseData As LicenseData
End Class
