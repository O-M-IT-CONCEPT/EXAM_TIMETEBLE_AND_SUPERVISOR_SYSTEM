<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_course_reg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_course_reg))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        txtcourseName = New TextBox()
        Label1 = New Label()
        txtcourseCode = New TextBox()
        Label8 = New Label()
        GroupBox1 = New GroupBox()
        Label17 = New Label()
        cmbdept = New ComboBox()
        Label16 = New Label()
        cmbfac = New ComboBox()
        GroupBox3 = New GroupBox()
        Label2 = New Label()
        cmbprog = New ComboBox()
        Label3 = New Label()
        cmblev = New ComboBox()
        btnDelete = New GelButtons.GelButton()
        btnUpdate = New GelButtons.GelButton()
        btnSave = New GelButtons.GelButton()
        dgw = New DataGridView()
        GroupBox4 = New GroupBox()
        cmblevelFilter = New ComboBox()
        cmbfacFilter = New ComboBox()
        cmbfilterdept = New ComboBox()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgw, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(txtcourseName)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtcourseCode)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.SteelBlue
        GroupBox2.Location = New Point(14, 14)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(594, 110)
        GroupBox2.TabIndex = 396
        GroupBox2.TabStop = False
        GroupBox2.Text = "Course"
        ' 
        ' txtcourseName
        ' 
        txtcourseName.BackColor = Color.White
        txtcourseName.Font = New Font("Microsoft Sans Serif", 10F)
        txtcourseName.Location = New Point(132, 67)
        txtcourseName.Margin = New Padding(4, 3, 4, 3)
        txtcourseName.Name = "txtcourseName"
        txtcourseName.Size = New Size(443, 23)
        txtcourseName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(7, 69)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 17)
        Label1.TabIndex = 18
        Label1.Text = "Name :"
        ' 
        ' txtcourseCode
        ' 
        txtcourseCode.BackColor = Color.White
        txtcourseCode.Font = New Font("Microsoft Sans Serif", 10F)
        txtcourseCode.Location = New Point(132, 31)
        txtcourseCode.Margin = New Padding(4, 3, 4, 3)
        txtcourseCode.Name = "txtcourseCode"
        txtcourseCode.Size = New Size(443, 23)
        txtcourseCode.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SteelBlue
        Label8.Location = New Point(12, 31)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 17)
        Label8.TabIndex = 16
        Label8.Text = "Code :"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(cmbdept)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(cmbfac)
        GroupBox1.Location = New Point(14, 130)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(594, 102)
        GroupBox1.TabIndex = 397
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dept And Faculty"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 10F)
        Label17.Location = New Point(7, 66)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(82, 17)
        Label17.TabIndex = 45
        Label17.Text = "Department"
        ' 
        ' cmbdept
        ' 
        cmbdept.DropDownStyle = ComboBoxStyle.DropDownList
        cmbdept.FormattingEnabled = True
        cmbdept.Items.AddRange(New Object() {"Admin", "Cashier", "Store Manager", "Inventory Manager", "Store Keeper", "Employee", "Security Guard"})
        cmbdept.Location = New Point(130, 60)
        cmbdept.Margin = New Padding(4, 3, 4, 3)
        cmbdept.Name = "cmbdept"
        cmbdept.Size = New Size(445, 23)
        cmbdept.TabIndex = 44
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 10F)
        Label16.Location = New Point(7, 25)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(53, 17)
        Label16.TabIndex = 43
        Label16.Text = "Faculty"
        ' 
        ' cmbfac
        ' 
        cmbfac.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfac.FormattingEnabled = True
        cmbfac.Items.AddRange(New Object() {"Admin", "Cashier", "Store Manager", "Inventory Manager", "Store Keeper", "Employee", "Security Guard"})
        cmbfac.Location = New Point(132, 25)
        cmbfac.Margin = New Padding(4, 3, 4, 3)
        cmbfac.Name = "cmbfac"
        cmbfac.Size = New Size(443, 23)
        cmbfac.TabIndex = 42
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(cmbprog)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(cmblev)
        GroupBox3.Location = New Point(14, 239)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(594, 102)
        GroupBox3.TabIndex = 398
        GroupBox3.TabStop = False
        GroupBox3.Text = "Level / Program"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10F)
        Label2.Location = New Point(12, 65)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 17)
        Label2.TabIndex = 45
        Label2.Text = "Program"
        ' 
        ' cmbprog
        ' 
        cmbprog.DropDownStyle = ComboBoxStyle.DropDownList
        cmbprog.FormattingEnabled = True
        cmbprog.Items.AddRange(New Object() {"FT", "PT"})
        cmbprog.Location = New Point(130, 60)
        cmbprog.Margin = New Padding(4, 3, 4, 3)
        cmbprog.Name = "cmbprog"
        cmbprog.Size = New Size(445, 23)
        cmbprog.TabIndex = 44
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10F)
        Label3.Location = New Point(18, 30)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 17)
        Label3.TabIndex = 43
        Label3.Text = "Level"
        ' 
        ' cmblev
        ' 
        cmblev.DropDownStyle = ComboBoxStyle.DropDownList
        cmblev.FormattingEnabled = True
        cmblev.Items.AddRange(New Object() {"ND I", "ND II", "HND I", "HND II"})
        cmblev.Location = New Point(132, 25)
        cmblev.Margin = New Padding(4, 3, 4, 3)
        cmblev.Name = "cmblev"
        cmblev.Size = New Size(443, 23)
        cmblev.TabIndex = 42
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.SteelBlue
        btnDelete.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.GradientBottom = Color.Purple
        btnDelete.GradientTop = Color.DarkMagenta
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(637, 119)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(104, 38)
        btnDelete.TabIndex = 401
        btnDelete.Text = "Delete"
        btnDelete.TextAlign = ContentAlignment.MiddleRight
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SteelBlue
        btnUpdate.Enabled = False
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.GradientBottom = Color.Purple
        btnUpdate.GradientTop = Color.DarkMagenta
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(637, 74)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(104, 38)
        btnUpdate.TabIndex = 400
        btnUpdate.Text = "Update"
        btnUpdate.TextAlign = ContentAlignment.MiddleRight
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SteelBlue
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.GradientBottom = Color.Purple
        btnSave.GradientTop = Color.DarkMagenta
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(637, 27)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 38)
        btnSave.TabIndex = 399
        btnSave.Text = "Save"
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dgw
        ' 
        dgw.AllowUserToAddRows = False
        dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgw.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgw.BackgroundColor = Color.White
        dgw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Purple
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgw.ColumnHeadersHeight = 37
        dgw.Columns.AddRange(New DataGridViewColumn() {Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        dgw.Cursor = Cursors.Hand
        dgw.EnableHeadersVisualStyles = False
        dgw.GridColor = Color.White
        dgw.Location = New Point(4, 400)
        dgw.Margin = New Padding(4, 3, 4, 3)
        dgw.MultiSelect = False
        dgw.Name = "dgw"
        dgw.ReadOnly = True
        dgw.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgw.RowHeadersWidth = 25
        dgw.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        dgw.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgw.RowTemplate.Height = 44
        dgw.RowTemplate.Resizable = DataGridViewTriState.False
        dgw.ScrollBars = ScrollBars.Vertical
        dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgw.Size = New Size(757, 243)
        dgw.TabIndex = 408
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(cmblevelFilter)
        GroupBox4.Controls.Add(cmbfacFilter)
        GroupBox4.Controls.Add(cmbfilterdept)
        GroupBox4.ForeColor = Color.Purple
        GroupBox4.Location = New Point(14, 330)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(594, 63)
        GroupBox4.TabIndex = 409
        GroupBox4.TabStop = False
        GroupBox4.Text = "Filter [faculty, dept,level]"
        ' 
        ' cmblevelFilter
        ' 
        cmblevelFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmblevelFilter.FormattingEnabled = True
        cmblevelFilter.Items.AddRange(New Object() {"FT", "PT"})
        cmblevelFilter.Location = New Point(422, 24)
        cmblevelFilter.Margin = New Padding(4, 3, 4, 3)
        cmblevelFilter.Name = "cmblevelFilter"
        cmblevelFilter.Size = New Size(142, 23)
        cmblevelFilter.TabIndex = 48
        ' 
        ' cmbfacFilter
        ' 
        cmbfacFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfacFilter.FormattingEnabled = True
        cmbfacFilter.Items.AddRange(New Object() {"FT", "PT"})
        cmbfacFilter.Location = New Point(37, 24)
        cmbfacFilter.Margin = New Padding(4, 3, 4, 3)
        cmbfacFilter.Name = "cmbfacFilter"
        cmbfacFilter.Size = New Size(142, 23)
        cmbfacFilter.TabIndex = 47
        ' 
        ' cmbfilterdept
        ' 
        cmbfilterdept.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfilterdept.FormattingEnabled = True
        cmbfilterdept.Items.AddRange(New Object() {"FT", "PT"})
        cmbfilterdept.Location = New Point(227, 24)
        cmbfilterdept.Margin = New Padding(4, 3, 4, 3)
        cmbfilterdept.Name = "cmbfilterdept"
        cmbfilterdept.Size = New Size(142, 23)
        cmbfilterdept.TabIndex = 46
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "ID"
        Column2.HeaderText = "id"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Visible = False
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "Course_code"
        Column3.HeaderText = "Code"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "Course_Name"
        Column4.HeaderText = "Course"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.DataPropertyName = "faculty"
        Column5.HeaderText = "Faculty"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.DataPropertyName = "dept"
        Column6.HeaderText = "Dept"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.DataPropertyName = "program"
        Column7.HeaderText = "Program"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.DataPropertyName = "level"
        Column8.HeaderText = "Level"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' frm_course_reg
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(754, 647)
        Controls.Add(GroupBox4)
        Controls.Add(dgw)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "frm_course_reg"
        StartPosition = FormStartPosition.CenterScreen
        Text = "COURSE REGISTRATION"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgw, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcourseName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcourseCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbdept As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbfac As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbprog As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmblev As ComboBox
    Friend WithEvents btnDelete As GelButtons.GelButton
    Friend WithEvents btnUpdate As GelButtons.GelButton
    Friend WithEvents btnSave As GelButtons.GelButton
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmbfilterdept As ComboBox
    Friend WithEvents cmblevelFilter As ComboBox
    Friend WithEvents cmbfacFilter As ComboBox
End Class
