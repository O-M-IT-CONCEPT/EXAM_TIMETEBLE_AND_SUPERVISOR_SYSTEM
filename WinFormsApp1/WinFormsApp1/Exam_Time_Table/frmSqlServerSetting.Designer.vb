<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSqlServerSetting
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSqlServerSetting))
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        GroupBox1 = New GroupBox()
        CheckBox1 = New CheckBox()
        btnConnect = New Button()
        btnSearchServers = New Button()
        Label6 = New Label()
        cmbInstallationType = New ComboBox()
        btnBlankDB = New Button()
        btnTestConnection = New Button()
        Label7 = New Label()
        cmbAuthentication = New ComboBox()
        cmbServerName = New ComboBox()
        txtPassword = New TextBox()
        txtUserName = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        btnClose = New Button()
        btnDemoDB = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        lblSet = New Label()
        Timer5 = New Timer(components)
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(5, 5)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(641, 319)
        Panel1.TabIndex = 2
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(8, 53)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(113, 18)
        LinkLabel1.TabIndex = 25
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Link to Mobile"
        LinkLabel1.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Controls.Add(btnConnect)
        GroupBox1.Controls.Add(btnSearchServers)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(cmbInstallationType)
        GroupBox1.Controls.Add(btnBlankDB)
        GroupBox1.Controls.Add(btnTestConnection)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(cmbAuthentication)
        GroupBox1.Controls.Add(cmbServerName)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUserName)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(btnClose)
        GroupBox1.Controls.Add(btnDemoDB)
        GroupBox1.Location = New Point(7, 77)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(621, 237)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SQL Server Configuration"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(198, 9)
        CheckBox1.Margin = New Padding(4, 3, 4, 3)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(253, 19)
        CheckBox1.TabIndex = 24
        CheckBox1.Text = "Enable Search by 2008 Sql server and below"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnConnect
        ' 
        btnConnect.BackColor = Color.Purple
        btnConnect.Cursor = Cursors.Hand
        btnConnect.FlatAppearance.BorderSize = 0
        btnConnect.FlatStyle = FlatStyle.Flat
        btnConnect.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConnect.ForeColor = Color.White
        btnConnect.Image = CType(resources.GetObject("btnConnect.Image"), Image)
        btnConnect.ImageAlign = ContentAlignment.MiddleLeft
        btnConnect.Location = New Point(153, 183)
        btnConnect.Margin = New Padding(4, 3, 4, 3)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(168, 46)
        btnConnect.TabIndex = 23
        btnConnect.Text = "Connect to DB"
        btnConnect.TextAlign = ContentAlignment.MiddleRight
        btnConnect.UseVisualStyleBackColor = False
        ' 
        ' btnSearchServers
        ' 
        btnSearchServers.BackColor = Color.Purple
        btnSearchServers.Cursor = Cursors.Hand
        btnSearchServers.FlatAppearance.BorderSize = 0
        btnSearchServers.FlatStyle = FlatStyle.Flat
        btnSearchServers.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchServers.ForeColor = Color.White
        btnSearchServers.Image = CType(resources.GetObject("btnSearchServers.Image"), Image)
        btnSearchServers.ImageAlign = ContentAlignment.MiddleLeft
        btnSearchServers.Location = New Point(491, 27)
        btnSearchServers.Margin = New Padding(4, 3, 4, 3)
        btnSearchServers.Name = "btnSearchServers"
        btnSearchServers.Size = New Size(121, 54)
        btnSearchServers.TabIndex = 22
        btnSearchServers.Text = "Search" & vbCrLf & "Servers"
        btnSearchServers.TextAlign = ContentAlignment.MiddleRight
        btnSearchServers.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 63)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 15)
        Label6.TabIndex = 21
        Label6.Text = "Installation Type :"
        ' 
        ' cmbInstallationType
        ' 
        cmbInstallationType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbInstallationType.FormattingEnabled = True
        cmbInstallationType.Items.AddRange(New Object() {"Server Installation", "Client Installation"})
        cmbInstallationType.Location = New Point(182, 63)
        cmbInstallationType.Margin = New Padding(4, 3, 4, 3)
        cmbInstallationType.Name = "cmbInstallationType"
        cmbInstallationType.Size = New Size(302, 23)
        cmbInstallationType.TabIndex = 1
        ' 
        ' btnBlankDB
        ' 
        btnBlankDB.BackColor = Color.Purple
        btnBlankDB.Cursor = Cursors.Hand
        btnBlankDB.FlatAppearance.BorderSize = 0
        btnBlankDB.FlatStyle = FlatStyle.Flat
        btnBlankDB.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBlankDB.ForeColor = Color.White
        btnBlankDB.Image = CType(resources.GetObject("btnBlankDB.Image"), Image)
        btnBlankDB.ImageAlign = ContentAlignment.MiddleLeft
        btnBlankDB.Location = New Point(491, 126)
        btnBlankDB.Margin = New Padding(4, 3, 4, 3)
        btnBlankDB.Name = "btnBlankDB"
        btnBlankDB.Size = New Size(121, 46)
        btnBlankDB.TabIndex = 7
        btnBlankDB.Text = "Create Blank DB " & vbCrLf & "and Proceed"
        btnBlankDB.TextAlign = ContentAlignment.MiddleRight
        btnBlankDB.UseVisualStyleBackColor = False
        btnBlankDB.Visible = False
        ' 
        ' btnTestConnection
        ' 
        btnTestConnection.BackColor = Color.Purple
        btnTestConnection.FlatAppearance.BorderSize = 0
        btnTestConnection.FlatStyle = FlatStyle.Flat
        btnTestConnection.Font = New Font("Microsoft Sans Serif", 9F)
        btnTestConnection.ForeColor = Color.White
        btnTestConnection.Image = My.Resources.Resources.Database_Active_icon
        btnTestConnection.ImageAlign = ContentAlignment.MiddleLeft
        btnTestConnection.Location = New Point(16, 183)
        btnTestConnection.Margin = New Padding(4, 3, 4, 3)
        btnTestConnection.Name = "btnTestConnection"
        btnTestConnection.Size = New Size(130, 46)
        btnTestConnection.TabIndex = 6
        btnTestConnection.Text = "Test DB Connection"
        btnTestConnection.TextAlign = ContentAlignment.MiddleRight
        btnTestConnection.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 92)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 15)
        Label7.TabIndex = 17
        Label7.Text = "Authentication :"
        ' 
        ' cmbAuthentication
        ' 
        cmbAuthentication.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAuthentication.FormattingEnabled = True
        cmbAuthentication.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        cmbAuthentication.Location = New Point(182, 92)
        cmbAuthentication.Margin = New Padding(4, 3, 4, 3)
        cmbAuthentication.Name = "cmbAuthentication"
        cmbAuthentication.Size = New Size(302, 23)
        cmbAuthentication.TabIndex = 2
        ' 
        ' cmbServerName
        ' 
        cmbServerName.FormattingEnabled = True
        cmbServerName.Location = New Point(182, 33)
        cmbServerName.Margin = New Padding(4, 3, 4, 3)
        cmbServerName.Name = "cmbServerName"
        cmbServerName.Size = New Size(302, 23)
        cmbServerName.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(182, 153)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(302, 23)
        txtPassword.TabIndex = 4
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(182, 123)
        txtUserName.Margin = New Padding(4, 3, 4, 3)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(302, 23)
        txtUserName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 123)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 15)
        Label3.TabIndex = 8
        Label3.Text = "SQL Server User Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 153)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 15)
        Label2.TabIndex = 7
        Label2.Text = "SQL User Password :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 33)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 15)
        Label5.TabIndex = 10
        Label5.Text = "SQL Server Name :"
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Purple
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(491, 185)
        btnClose.Margin = New Padding(4, 3, 4, 3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(121, 45)
        btnClose.TabIndex = 9
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnDemoDB
        ' 
        btnDemoDB.BackColor = Color.Purple
        btnDemoDB.Cursor = Cursors.Hand
        btnDemoDB.FlatAppearance.BorderSize = 0
        btnDemoDB.FlatStyle = FlatStyle.Flat
        btnDemoDB.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDemoDB.ForeColor = Color.White
        btnDemoDB.Image = CType(resources.GetObject("btnDemoDB.Image"), Image)
        btnDemoDB.ImageAlign = ContentAlignment.MiddleLeft
        btnDemoDB.Location = New Point(324, 182)
        btnDemoDB.Margin = New Padding(4, 3, 4, 3)
        btnDemoDB.Name = "btnDemoDB"
        btnDemoDB.Size = New Size(160, 46)
        btnDemoDB.TabIndex = 8
        btnDemoDB.Text = "Create DB  and Proceed"
        btnDemoDB.TextAlign = ContentAlignment.MiddleRight
        btnDemoDB.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Purple
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lblSet)
        Panel2.Location = New Point(7, 6)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(621, 43)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(184, 7)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 24)
        Label1.TabIndex = 0
        Label1.Text = "SQL Server Setting"
        ' 
        ' lblSet
        ' 
        lblSet.AutoSize = True
        lblSet.Location = New Point(74, 16)
        lblSet.Margin = New Padding(4, 0, 4, 0)
        lblSet.Name = "lblSet"
        lblSet.Size = New Size(23, 15)
        lblSet.TabIndex = 21
        lblSet.Text = "Set"
        lblSet.Visible = False
        ' 
        ' Timer5
        ' 
        ' 
        ' frmSqlServerSetting
        ' 
        AcceptButton = btnDemoDB
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Purple
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(651, 327)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSqlServerSetting"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDemoDB As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmbServerName As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbAuthentication As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblSet As System.Windows.Forms.Label
    Friend WithEvents btnTestConnection As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnBlankDB As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbInstallationType As System.Windows.Forms.ComboBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents btnSearchServers As System.Windows.Forms.Button
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents btnConnect As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
