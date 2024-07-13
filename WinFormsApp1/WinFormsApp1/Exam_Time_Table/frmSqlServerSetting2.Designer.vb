<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSqlServerSetting2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSqlServerSetting2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbInstallationType = New System.Windows.Forms.ComboBox()
        Me.cmbAuthentication = New System.Windows.Forms.ComboBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttoken = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtapikey = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txturl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnSearchServers = New System.Windows.Forms.Button()
        Me.btnBlankDB = New System.Windows.Forms.Button()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbServerName = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDemoDB = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(195, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SQL Server Setting"
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Location = New System.Drawing.Point(63, 14)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(23, 13)
        Me.lblSet.TabIndex = 21
        Me.lblSet.Text = "Set"
        Me.lblSet.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(170, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(239, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Enable Search by 2008 Sql server and below"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Installation Type :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblSet)
        Me.Panel2.Location = New System.Drawing.Point(-1, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 37)
        Me.Panel2.TabIndex = 1
        '
        'Timer5
        '
        '
        'cmbInstallationType
        '
        Me.cmbInstallationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstallationType.FormattingEnabled = True
        Me.cmbInstallationType.Items.AddRange(New Object() {"Server Installation", "Client Installation"})
        Me.cmbInstallationType.Location = New System.Drawing.Point(156, 55)
        Me.cmbInstallationType.Name = "cmbInstallationType"
        Me.cmbInstallationType.Size = New System.Drawing.Size(259, 21)
        Me.cmbInstallationType.TabIndex = 1
        '
        'cmbAuthentication
        '
        Me.cmbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAuthentication.FormattingEnabled = True
        Me.cmbAuthentication.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        Me.cmbAuthentication.Location = New System.Drawing.Point(156, 80)
        Me.cmbAuthentication.Name = "cmbAuthentication"
        Me.cmbAuthentication.Size = New System.Drawing.Size(259, 21)
        Me.cmbAuthentication.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(156, 133)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(259, 20)
        Me.txtPassword.TabIndex = 4
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(156, 107)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(259, 20)
        Me.txtUserName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SQL Server User Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 133)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SQL User Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SQL Server Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txttoken)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtapikey)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txturl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.btnSearchServers)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbInstallationType)
        Me.GroupBox1.Controls.Add(Me.btnBlankDB)
        Me.GroupBox1.Controls.Add(Me.btnTestConnection)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbAuthentication)
        Me.GroupBox1.Controls.Add(Me.cmbServerName)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnDemoDB)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SQL Server Configuration"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(137, 161)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "ERP NEXT DATA"
        '
        'txttoken
        '
        Me.txttoken.Location = New System.Drawing.Point(34, 235)
        Me.txttoken.Name = "txttoken"
        Me.txttoken.Size = New System.Drawing.Size(381, 20)
        Me.txttoken.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-4, 237)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Token"
        '
        'txtapikey
        '
        Me.txtapikey.Location = New System.Drawing.Point(34, 209)
        Me.txtapikey.Name = "txtapikey"
        Me.txtapikey.Size = New System.Drawing.Size(381, 20)
        Me.txtapikey.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 211)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 15)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Key"
        '
        'txturl
        '
        Me.txturl.Location = New System.Drawing.Point(34, 183)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(381, 20)
        Me.txturl.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 185)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Url"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.Purple
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.FlatAppearance.BorderSize = 0
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.White
        Me.btnConnect.Image = CType(resources.GetObject("btnConnect.Image"), System.Drawing.Image)
        Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConnect.Location = New System.Drawing.Point(241, 274)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(144, 40)
        Me.btnConnect.TabIndex = 23
        Me.btnConnect.Text = "Connect to DB"
        Me.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnSearchServers
        '
        Me.btnSearchServers.BackColor = System.Drawing.Color.Purple
        Me.btnSearchServers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchServers.FlatAppearance.BorderSize = 0
        Me.btnSearchServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchServers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchServers.ForeColor = System.Drawing.Color.White
        Me.btnSearchServers.Image = CType(resources.GetObject("btnSearchServers.Image"), System.Drawing.Image)
        Me.btnSearchServers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchServers.Location = New System.Drawing.Point(421, 12)
        Me.btnSearchServers.Name = "btnSearchServers"
        Me.btnSearchServers.Size = New System.Drawing.Size(104, 47)
        Me.btnSearchServers.TabIndex = 22
        Me.btnSearchServers.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servers"
        Me.btnSearchServers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchServers.UseVisualStyleBackColor = False
        '
        'btnBlankDB
        '
        Me.btnBlankDB.BackColor = System.Drawing.Color.Purple
        Me.btnBlankDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlankDB.FlatAppearance.BorderSize = 0
        Me.btnBlankDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlankDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlankDB.ForeColor = System.Drawing.Color.White
        Me.btnBlankDB.Image = CType(resources.GetObject("btnBlankDB.Image"), System.Drawing.Image)
        Me.btnBlankDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlankDB.Location = New System.Drawing.Point(421, 107)
        Me.btnBlankDB.Name = "btnBlankDB"
        Me.btnBlankDB.Size = New System.Drawing.Size(104, 40)
        Me.btnBlankDB.TabIndex = 7
        Me.btnBlankDB.Text = "Create Blank DB " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Proceed"
        Me.btnBlankDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBlankDB.UseVisualStyleBackColor = False
        Me.btnBlankDB.Visible = False
        '
        'btnTestConnection
        '
        Me.btnTestConnection.BackColor = System.Drawing.Color.Purple
        Me.btnTestConnection.FlatAppearance.BorderSize = 0
        Me.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnTestConnection.ForeColor = System.Drawing.Color.White
        Me.btnTestConnection.Image = Global.WinFormsApp1.My.Resources.Resources.Database_Active_icon
        Me.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTestConnection.Location = New System.Drawing.Point(124, 274)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(111, 40)
        Me.btnTestConnection.TabIndex = 6
        Me.btnTestConnection.Text = "Test DB Connection"
        Me.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTestConnection.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Authentication :"
        '
        'cmbServerName
        '
        Me.cmbServerName.FormattingEnabled = True
        Me.cmbServerName.Location = New System.Drawing.Point(156, 29)
        Me.cmbServerName.Name = "cmbServerName"
        Me.cmbServerName.Size = New System.Drawing.Size(259, 21)
        Me.cmbServerName.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Purple
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(421, 62)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 39)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDemoDB
        '
        Me.btnDemoDB.BackColor = System.Drawing.Color.Purple
        Me.btnDemoDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDemoDB.FlatAppearance.BorderSize = 0
        Me.btnDemoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDemoDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemoDB.ForeColor = System.Drawing.Color.White
        Me.btnDemoDB.Image = CType(resources.GetObject("btnDemoDB.Image"), System.Drawing.Image)
        Me.btnDemoDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDemoDB.Location = New System.Drawing.Point(388, 273)
        Me.btnDemoDB.Name = "btnDemoDB"
        Me.btnDemoDB.Size = New System.Drawing.Size(137, 40)
        Me.btnDemoDB.TabIndex = 8
        Me.btnDemoDB.Text = "Create DB  and Proceed"
        Me.btnDemoDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDemoDB.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 393)
        Me.Panel1.TabIndex = 3
        '
        'frmSqlServerSetting2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(585, 420)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSqlServerSetting2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSet As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnSearchServers As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer5 As Timer
    Friend WithEvents cmbInstallationType As ComboBox
    Friend WithEvents btnBlankDB As Button
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents cmbAuthentication As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDemoDB As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbServerName As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txttoken As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtapikey As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txturl As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
End Class
