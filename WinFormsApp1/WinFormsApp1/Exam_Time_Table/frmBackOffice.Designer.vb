<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBackOffice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackOffice))
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel4 = New ToolStripStatusLabel()
        lblUser = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        lblDateTime = New ToolStripStatusLabel()
        OpenFileDialog1 = New OpenFileDialog()
        Timer3 = New Timer(components)
        txtOpenID = New TextBox()
        lblSet = New Label()
        BackOfficeMenuStrip = New MenuStrip()
        SalesToolStripMenuItem = New ToolStripMenuItem()
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        AddLevelToolStripMenuItem = New ToolStripMenuItem()
        ManufacturingToolStripMenuItem = New ToolStripMenuItem()
        SupplierToolStripMenuItem = New ToolStripMenuItem()
        ExpensesToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        NotepadToolStripMenuItem = New ToolStripMenuItem()
        CalculatorToolStripMenuItem = New ToolStripMenuItem()
        WordpadToolStripMenuItem = New ToolStripMenuItem()
        MSWordToolStripMenuItem = New ToolStripMenuItem()
        MSPaintToolStripMenuItem = New ToolStripMenuItem()
        TaskManagerToolStripMenuItem = New ToolStripMenuItem()
        DashbaordToolStripMenuItem = New ToolStripMenuItem()
        ChequeWriterToolStripMenuItem = New ToolStripMenuItem()
        VATCalculatorToolStripMenuItem = New ToolStripMenuItem()
        SendSMSToolStripMenuItem = New ToolStripMenuItem()
        CreditCustomersToolStripMenuItem = New ToolStripMenuItem()
        GeneralCustomersToolStripMenuItem = New ToolStripMenuItem()
        MaintenanceToolStripMenuItem = New ToolStripMenuItem()
        LogsToolStripMenuItem = New ToolStripMenuItem()
        CompanyInfoToolStripMenuItem = New ToolStripMenuItem()
        SMSToolStripMenuItem = New ToolStripMenuItem()
        EmailToolStripMenuItem = New ToolStripMenuItem()
        maintemanceSep1 = New ToolStripSeparator()
        DBBackupToolStripMenuItem = New ToolStripMenuItem()
        DBRestoreToolStripMenuItem = New ToolStripMenuItem()
        ResetDatabaseToolStripMenuItem = New ToolStripMenuItem()
        maintenanceSep2 = New ToolStripSeparator()
        TerminalSettingToolStripMenuItem = New ToolStripMenuItem()
        maintenanceSep3 = New ToolStripSeparator()
        RegistrationToolStripMenuItem = New ToolStripMenuItem()
        AdvancedSettingsToolStripMenuItem = New ToolStripMenuItem()
        SecurityOprtionToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutUsToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem1 = New ToolStripMenuItem()
        StatusStrip1.SuspendLayout()
        BackOfficeMenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.AutoSize = False
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel4, lblUser, ToolStripStatusLabel3, lblDateTime})
        StatusStrip1.Location = New Point(0, 720)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 16, 0)
        StatusStrip1.Size = New Size(1370, 29)
        StatusStrip1.TabIndex = 63
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel4.ForeColor = Color.Black
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(94, 24)
        ToolStripStatusLabel4.Text = "Logged in As :"
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.Black
        lblUser.Image = CType(resources.GetObject("lblUser.Image"), Image)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(95, 24)
        lblUser.Text = "User Name"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(1075, 24)
        ToolStripStatusLabel3.Spring = True
        ToolStripStatusLabel3.Text = "DATA PROCESSING"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateTime.ForeColor = Color.Black
        lblDateTime.Image = CType(resources.GetObject("lblDateTime.Image"), Image)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(89, 24)
        lblDateTime.Text = "Date Time"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' txtOpenID
        ' 
        txtOpenID.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOpenID.Location = New Point(49, 323)
        txtOpenID.Margin = New Padding(4, 3, 4, 3)
        txtOpenID.Name = "txtOpenID"
        txtOpenID.Size = New Size(102, 20)
        txtOpenID.TabIndex = 398
        txtOpenID.TextAlign = HorizontalAlignment.Right
        txtOpenID.Visible = False
        ' 
        ' lblSet
        ' 
        lblSet.AutoSize = True
        lblSet.Location = New Point(46, 305)
        lblSet.Margin = New Padding(4, 0, 4, 0)
        lblSet.Name = "lblSet"
        lblSet.Size = New Size(41, 15)
        lblSet.TabIndex = 399
        lblSet.Text = "Label2"
        lblSet.Visible = False
        ' 
        ' BackOfficeMenuStrip
        ' 
        BackOfficeMenuStrip.BackColor = Color.Purple
        BackOfficeMenuStrip.Font = New Font("Segoe UI", 9F)
        BackOfficeMenuStrip.Items.AddRange(New ToolStripItem() {SalesToolStripMenuItem, InventoryToolStripMenuItem, AddLevelToolStripMenuItem, ManufacturingToolStripMenuItem, SupplierToolStripMenuItem, ExpensesToolStripMenuItem, ToolsToolStripMenuItem, MaintenanceToolStripMenuItem, HelpToolStripMenuItem, LogoutToolStripMenuItem})
        BackOfficeMenuStrip.Location = New Point(0, 0)
        BackOfficeMenuStrip.Name = "BackOfficeMenuStrip"
        BackOfficeMenuStrip.Padding = New Padding(7, 2, 0, 2)
        BackOfficeMenuStrip.RenderMode = ToolStripRenderMode.Professional
        BackOfficeMenuStrip.Size = New Size(1370, 27)
        BackOfficeMenuStrip.TabIndex = 400
        BackOfficeMenuStrip.Text = "MenuStrip"
        ' 
        ' SalesToolStripMenuItem
        ' 
        SalesToolStripMenuItem.BackColor = Color.Purple
        SalesToolStripMenuItem.Enabled = False
        SalesToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        SalesToolStripMenuItem.ForeColor = Color.White
        SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        SalesToolStripMenuItem.Size = New Size(182, 23)
        SalesToolStripMenuItem.Text = "TimeTable Data Processing"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.BackColor = Color.Purple
        InventoryToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        InventoryToolStripMenuItem.ForeColor = Color.White
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(93, 23)
        InventoryToolStripMenuItem.Text = "Add Faculty"
        ' 
        ' AddLevelToolStripMenuItem
        ' 
        AddLevelToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        AddLevelToolStripMenuItem.ForeColor = Color.White
        AddLevelToolStripMenuItem.Name = "AddLevelToolStripMenuItem"
        AddLevelToolStripMenuItem.Size = New Size(81, 23)
        AddLevelToolStripMenuItem.Text = "Add Level"
        ' 
        ' ManufacturingToolStripMenuItem
        ' 
        ManufacturingToolStripMenuItem.BackColor = Color.Purple
        ManufacturingToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        ManufacturingToolStripMenuItem.ForeColor = Color.White
        ManufacturingToolStripMenuItem.Name = "ManufacturingToolStripMenuItem"
        ManufacturingToolStripMenuItem.Size = New Size(124, 23)
        ManufacturingToolStripMenuItem.Text = "Add Department"
        ' 
        ' SupplierToolStripMenuItem
        ' 
        SupplierToolStripMenuItem.BackColor = Color.Purple
        SupplierToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        SupplierToolStripMenuItem.ForeColor = Color.White
        SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        SupplierToolStripMenuItem.Size = New Size(93, 23)
        SupplierToolStripMenuItem.Text = "Add Course"
        ' 
        ' ExpensesToolStripMenuItem
        ' 
        ExpensesToolStripMenuItem.BackColor = Color.Purple
        ExpensesToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        ExpensesToolStripMenuItem.ForeColor = Color.White
        ExpensesToolStripMenuItem.Name = "ExpensesToolStripMenuItem"
        ExpensesToolStripMenuItem.Size = New Size(69, 23)
        ExpensesToolStripMenuItem.Text = "Allocate"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.BackColor = Color.Purple
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NotepadToolStripMenuItem, CalculatorToolStripMenuItem, WordpadToolStripMenuItem, MSWordToolStripMenuItem, MSPaintToolStripMenuItem, TaskManagerToolStripMenuItem, DashbaordToolStripMenuItem, ChequeWriterToolStripMenuItem, VATCalculatorToolStripMenuItem, SendSMSToolStripMenuItem})
        ToolsToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        ToolsToolStripMenuItem.ForeColor = Color.White
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(52, 23)
        ToolsToolStripMenuItem.Text = "Tools"
        ' 
        ' NotepadToolStripMenuItem
        ' 
        NotepadToolStripMenuItem.BackColor = Color.Purple
        NotepadToolStripMenuItem.ForeColor = Color.White
        NotepadToolStripMenuItem.Image = My.Resources.Resources.notepad
        NotepadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        NotepadToolStripMenuItem.Size = New Size(172, 28)
        NotepadToolStripMenuItem.Text = "Notepad"
        ' 
        ' CalculatorToolStripMenuItem
        ' 
        CalculatorToolStripMenuItem.BackColor = Color.Purple
        CalculatorToolStripMenuItem.ForeColor = Color.White
        CalculatorToolStripMenuItem.Image = My.Resources.Resources.calculator
        CalculatorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        CalculatorToolStripMenuItem.Size = New Size(172, 28)
        CalculatorToolStripMenuItem.Text = "Calculator"
        ' 
        ' WordpadToolStripMenuItem
        ' 
        WordpadToolStripMenuItem.BackColor = Color.Purple
        WordpadToolStripMenuItem.ForeColor = Color.White
        WordpadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        WordpadToolStripMenuItem.Size = New Size(172, 28)
        WordpadToolStripMenuItem.Text = "Wordpad"
        ' 
        ' MSWordToolStripMenuItem
        ' 
        MSWordToolStripMenuItem.BackColor = Color.Purple
        MSWordToolStripMenuItem.ForeColor = Color.White
        MSWordToolStripMenuItem.Image = My.Resources.Resources.ms_word
        MSWordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        MSWordToolStripMenuItem.Name = "MSWordToolStripMenuItem"
        MSWordToolStripMenuItem.Size = New Size(172, 28)
        MSWordToolStripMenuItem.Text = "MS Word"
        ' 
        ' MSPaintToolStripMenuItem
        ' 
        MSPaintToolStripMenuItem.BackColor = Color.Purple
        MSPaintToolStripMenuItem.ForeColor = Color.White
        MSPaintToolStripMenuItem.Image = My.Resources.Resources.ms_paint
        MSPaintToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        MSPaintToolStripMenuItem.Name = "MSPaintToolStripMenuItem"
        MSPaintToolStripMenuItem.Size = New Size(172, 28)
        MSPaintToolStripMenuItem.Text = "MS Paint"
        ' 
        ' TaskManagerToolStripMenuItem
        ' 
        TaskManagerToolStripMenuItem.BackColor = Color.Purple
        TaskManagerToolStripMenuItem.ForeColor = Color.White
        TaskManagerToolStripMenuItem.Image = My.Resources.Resources.taskmanager
        TaskManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        TaskManagerToolStripMenuItem.Size = New Size(172, 28)
        TaskManagerToolStripMenuItem.Text = "Task Manager"
        ' 
        ' DashbaordToolStripMenuItem
        ' 
        DashbaordToolStripMenuItem.BackColor = Color.Purple
        DashbaordToolStripMenuItem.ForeColor = Color.White
        DashbaordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        DashbaordToolStripMenuItem.Name = "DashbaordToolStripMenuItem"
        DashbaordToolStripMenuItem.Size = New Size(172, 28)
        DashbaordToolStripMenuItem.Text = "Dashbaord"
        ' 
        ' ChequeWriterToolStripMenuItem
        ' 
        ChequeWriterToolStripMenuItem.BackColor = Color.Purple
        ChequeWriterToolStripMenuItem.ForeColor = Color.White
        ChequeWriterToolStripMenuItem.Image = My.Resources.Resources.cheque
        ChequeWriterToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ChequeWriterToolStripMenuItem.Name = "ChequeWriterToolStripMenuItem"
        ChequeWriterToolStripMenuItem.Size = New Size(172, 28)
        ChequeWriterToolStripMenuItem.Text = "Cheque Writer"
        ' 
        ' VATCalculatorToolStripMenuItem
        ' 
        VATCalculatorToolStripMenuItem.BackColor = Color.Purple
        VATCalculatorToolStripMenuItem.ForeColor = Color.White
        VATCalculatorToolStripMenuItem.Image = My.Resources.Resources.vat_calculator
        VATCalculatorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        VATCalculatorToolStripMenuItem.Name = "VATCalculatorToolStripMenuItem"
        VATCalculatorToolStripMenuItem.Size = New Size(172, 28)
        VATCalculatorToolStripMenuItem.Text = "VAT Calculator"
        ' 
        ' SendSMSToolStripMenuItem
        ' 
        SendSMSToolStripMenuItem.BackColor = Color.Purple
        SendSMSToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CreditCustomersToolStripMenuItem, GeneralCustomersToolStripMenuItem})
        SendSMSToolStripMenuItem.ForeColor = Color.White
        SendSMSToolStripMenuItem.Image = My.Resources.Resources.send_sms
        SendSMSToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        SendSMSToolStripMenuItem.Name = "SendSMSToolStripMenuItem"
        SendSMSToolStripMenuItem.Size = New Size(172, 28)
        SendSMSToolStripMenuItem.Text = "Send SMS"
        ' 
        ' CreditCustomersToolStripMenuItem
        ' 
        CreditCustomersToolStripMenuItem.BackColor = Color.Purple
        CreditCustomersToolStripMenuItem.ForeColor = Color.White
        CreditCustomersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        CreditCustomersToolStripMenuItem.Name = "CreditCustomersToolStripMenuItem"
        CreditCustomersToolStripMenuItem.Size = New Size(200, 28)
        CreditCustomersToolStripMenuItem.Text = "Credit Customers"
        ' 
        ' GeneralCustomersToolStripMenuItem
        ' 
        GeneralCustomersToolStripMenuItem.BackColor = Color.Purple
        GeneralCustomersToolStripMenuItem.ForeColor = Color.White
        GeneralCustomersToolStripMenuItem.Image = My.Resources.Resources.generalSMS
        GeneralCustomersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        GeneralCustomersToolStripMenuItem.Name = "GeneralCustomersToolStripMenuItem"
        GeneralCustomersToolStripMenuItem.Size = New Size(200, 28)
        GeneralCustomersToolStripMenuItem.Text = "General Customers"
        ' 
        ' MaintenanceToolStripMenuItem
        ' 
        MaintenanceToolStripMenuItem.BackColor = Color.Purple
        MaintenanceToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogsToolStripMenuItem, CompanyInfoToolStripMenuItem, SMSToolStripMenuItem, EmailToolStripMenuItem, maintemanceSep1, DBBackupToolStripMenuItem, DBRestoreToolStripMenuItem, ResetDatabaseToolStripMenuItem, maintenanceSep2, TerminalSettingToolStripMenuItem, maintenanceSep3, RegistrationToolStripMenuItem, AdvancedSettingsToolStripMenuItem, SecurityOprtionToolStripMenuItem})
        MaintenanceToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        MaintenanceToolStripMenuItem.ForeColor = Color.White
        MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        MaintenanceToolStripMenuItem.Size = New Size(100, 23)
        MaintenanceToolStripMenuItem.Text = "Maintenance"
        ' 
        ' LogsToolStripMenuItem
        ' 
        LogsToolStripMenuItem.BackColor = Color.Purple
        LogsToolStripMenuItem.ForeColor = Color.White
        LogsToolStripMenuItem.Image = My.Resources.Resources.logs
        LogsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        LogsToolStripMenuItem.Size = New Size(206, 38)
        LogsToolStripMenuItem.Text = "Logs"
        ' 
        ' CompanyInfoToolStripMenuItem
        ' 
        CompanyInfoToolStripMenuItem.BackColor = Color.Purple
        CompanyInfoToolStripMenuItem.ForeColor = Color.White
        CompanyInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        CompanyInfoToolStripMenuItem.Name = "CompanyInfoToolStripMenuItem"
        CompanyInfoToolStripMenuItem.Size = New Size(206, 38)
        CompanyInfoToolStripMenuItem.Text = "Company Info"
        ' 
        ' SMSToolStripMenuItem
        ' 
        SMSToolStripMenuItem.BackColor = Color.Purple
        SMSToolStripMenuItem.ForeColor = Color.White
        SMSToolStripMenuItem.Image = My.Resources.Resources.send_sms
        SMSToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        SMSToolStripMenuItem.Name = "SMSToolStripMenuItem"
        SMSToolStripMenuItem.Size = New Size(206, 38)
        SMSToolStripMenuItem.Text = "SMS Settings"
        ' 
        ' EmailToolStripMenuItem
        ' 
        EmailToolStripMenuItem.BackColor = Color.Purple
        EmailToolStripMenuItem.ForeColor = Color.White
        EmailToolStripMenuItem.Image = My.Resources.Resources.email
        EmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        EmailToolStripMenuItem.Size = New Size(206, 38)
        EmailToolStripMenuItem.Text = "Email Settings"
        ' 
        ' maintemanceSep1
        ' 
        maintemanceSep1.Name = "maintemanceSep1"
        maintemanceSep1.Size = New Size(203, 6)
        ' 
        ' DBBackupToolStripMenuItem
        ' 
        DBBackupToolStripMenuItem.BackColor = Color.Purple
        DBBackupToolStripMenuItem.ForeColor = Color.White
        DBBackupToolStripMenuItem.Image = My.Resources.Resources.database_backup
        DBBackupToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        DBBackupToolStripMenuItem.Name = "DBBackupToolStripMenuItem"
        DBBackupToolStripMenuItem.Size = New Size(206, 38)
        DBBackupToolStripMenuItem.Text = "DB Backup"
        ' 
        ' DBRestoreToolStripMenuItem
        ' 
        DBRestoreToolStripMenuItem.BackColor = Color.Purple
        DBRestoreToolStripMenuItem.ForeColor = Color.White
        DBRestoreToolStripMenuItem.Image = My.Resources.Resources.database_restore
        DBRestoreToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        DBRestoreToolStripMenuItem.Name = "DBRestoreToolStripMenuItem"
        DBRestoreToolStripMenuItem.Size = New Size(206, 38)
        DBRestoreToolStripMenuItem.Text = "DB Restore"
        ' 
        ' ResetDatabaseToolStripMenuItem
        ' 
        ResetDatabaseToolStripMenuItem.BackColor = Color.Purple
        ResetDatabaseToolStripMenuItem.ForeColor = Color.White
        ResetDatabaseToolStripMenuItem.Image = My.Resources.Resources.database_reset
        ResetDatabaseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ResetDatabaseToolStripMenuItem.Name = "ResetDatabaseToolStripMenuItem"
        ResetDatabaseToolStripMenuItem.Size = New Size(206, 38)
        ResetDatabaseToolStripMenuItem.Text = "Reset Database"
        ' 
        ' maintenanceSep2
        ' 
        maintenanceSep2.Name = "maintenanceSep2"
        maintenanceSep2.Size = New Size(203, 6)
        ' 
        ' TerminalSettingToolStripMenuItem
        ' 
        TerminalSettingToolStripMenuItem.BackColor = Color.Purple
        TerminalSettingToolStripMenuItem.ForeColor = Color.White
        TerminalSettingToolStripMenuItem.Image = My.Resources.Resources.terminal_settings
        TerminalSettingToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        TerminalSettingToolStripMenuItem.Name = "TerminalSettingToolStripMenuItem"
        TerminalSettingToolStripMenuItem.Size = New Size(206, 38)
        TerminalSettingToolStripMenuItem.Text = "Hardware Setting"
        ' 
        ' maintenanceSep3
        ' 
        maintenanceSep3.Name = "maintenanceSep3"
        maintenanceSep3.Size = New Size(203, 6)
        ' 
        ' RegistrationToolStripMenuItem
        ' 
        RegistrationToolStripMenuItem.BackColor = Color.Purple
        RegistrationToolStripMenuItem.ForeColor = Color.White
        RegistrationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        RegistrationToolStripMenuItem.Size = New Size(206, 38)
        RegistrationToolStripMenuItem.Text = "Users"
        ' 
        ' AdvancedSettingsToolStripMenuItem
        ' 
        AdvancedSettingsToolStripMenuItem.BackColor = Color.Purple
        AdvancedSettingsToolStripMenuItem.ForeColor = Color.White
        AdvancedSettingsToolStripMenuItem.Name = "AdvancedSettingsToolStripMenuItem"
        AdvancedSettingsToolStripMenuItem.Size = New Size(206, 38)
        AdvancedSettingsToolStripMenuItem.Text = "Advanced settings"
        ' 
        ' SecurityOprtionToolStripMenuItem
        ' 
        SecurityOprtionToolStripMenuItem.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        SecurityOprtionToolStripMenuItem.ForeColor = Color.White
        SecurityOprtionToolStripMenuItem.Name = "SecurityOprtionToolStripMenuItem"
        SecurityOprtionToolStripMenuItem.Size = New Size(206, 38)
        SecurityOprtionToolStripMenuItem.Text = "SecurityOption"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.BackColor = Color.Purple
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutUsToolStripMenuItem})
        HelpToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        HelpToolStripMenuItem.ForeColor = Color.White
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(49, 23)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutUsToolStripMenuItem
        ' 
        AboutUsToolStripMenuItem.BackColor = Color.Purple
        AboutUsToolStripMenuItem.ForeColor = Color.White
        AboutUsToolStripMenuItem.Image = My.Resources.Resources.about
        AboutUsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        AboutUsToolStripMenuItem.Size = New Size(170, 56)
        AboutUsToolStripMenuItem.Text = "About Us"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.BackColor = Color.Purple
        LogoutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LogoutToolStripMenuItem1})
        LogoutToolStripMenuItem.Font = New Font("Segoe UI", 10.5F)
        LogoutToolStripMenuItem.ForeColor = Color.White
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(65, 23)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' LogoutToolStripMenuItem1
        ' 
        LogoutToolStripMenuItem1.BackColor = Color.Purple
        LogoutToolStripMenuItem1.ForeColor = Color.White
        LogoutToolStripMenuItem1.Image = My.Resources.Resources.logout
        LogoutToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None
        LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        LogoutToolStripMenuItem1.Size = New Size(214, 56)
        LogoutToolStripMenuItem1.Text = "Logout"
        ' 
        ' frmBackOffice
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1370, 749)
        Controls.Add(lblSet)
        Controls.Add(txtOpenID)
        Controls.Add(StatusStrip1)
        Controls.Add(BackOfficeMenuStrip)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        MainMenuStrip = BackOfficeMenuStrip
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "frmBackOffice"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Back Office (Data Processing)"
        WindowState = FormWindowState.Maximized
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        BackOfficeMenuStrip.ResumeLayout(False)
        BackOfficeMenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents btnPOSRecord As CButtonLib.CButton
    Friend WithEvents btnPayment As CButtonLib.CButton
    Friend WithEvents btnStockAdjustment As CButtonLib.CButton
    Friend WithEvents btnPurchaseReturn As CButtonLib.CButton
    Friend WithEvents btnPurchase As CButtonLib.CButton
    Friend WithEvents btnPurchaseOrder As CButtonLib.CButton
    Friend WithEvents btnSetting As CButtonLib.CButton
    Friend WithEvents btnCompanyInfo As CButtonLib.CButton
    Friend WithEvents btnRegistration As CButtonLib.CButton
    Friend WithEvents btnSalesmanMaster As CButtonLib.CButton
    Friend WithEvents btnProductMaster As CButtonLib.CButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents txtOpenID As System.Windows.Forms.TextBox
    Friend WithEvents lblSet As System.Windows.Forms.Label
    'Friend WithEvents RibbonPanel8 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents rbtnPOSReport As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnAccountingReports As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnBLP As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnDashboard As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnSendBroadcastSMS As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel9 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents rbtnAboutUS As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel10 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents rbtnBank As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnBranch As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnBankAccount As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnP_W As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnFundTransfer As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnFundDeposit As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton10 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton11 As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnBankStatements As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel12 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents rbtnLS As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnMR As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnML As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel11 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents rbtnPOSRecord As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnShiftClosing As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnLogs As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel13 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents rbtnPurchaseOrder As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnPurchase As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnPurchaseReturn As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnSalesReturn As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnStockTransfer As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnStockAdjustment As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnRacking As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnProductsLocation As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel14 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents rbtnCreditCustomer As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnGeneralCustomer As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnReceipt As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnLedger As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonTab11 As System.Windows.Forms.RibbonTab
    'Friend WithEvents RibbonButton24 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton25 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton26 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton22 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton23 As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnVouchers As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnPayment As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnQuotation As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton2 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton3 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel15 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents RibbonButton4 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton5 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton9 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton12 As System.Windows.Forms.RibbonButton
    'Friend WithEvents rbtnPrintCard As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonSeparator2 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator3 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator4 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator5 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator6 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator7 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator8 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator1 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator9 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator10 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator11 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator12 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator13 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator14 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator16 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator18 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator19 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator15 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonSeparator17 As System.Windows.Forms.RibbonSeparator
    'Friend WithEvents RibbonTab12 As System.Windows.Forms.RibbonTab
    'Friend WithEvents RibbonPanel16 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents RibbonButton6 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton7 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton8 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton13 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton14 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton15 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonButton16 As System.Windows.Forms.RibbonButton
    'Friend WithEvents RibbonPanel17 As System.Windows.Forms.RibbonPanel
    'Friend WithEvents RibbonButton17 As System.Windows.Forms.RibbonButton
    Friend WithEvents btnCurrency As CButtonLib.CButton
    'Friend WithEvents rbtnCurrency As RibbonButton
    Friend WithEvents btnMultiBal As CButtonLib.CButton
    'Friend WithEvents RibbonSeparator20 As RibbonSeparator
    'Friend WithEvents rbtnMultiCurrency As RibbonButton
    'Friend WithEvents rbtnResetDb As RibbonButton
    Friend WithEvents btnBatches As CButtonLib.CButton
    'Friend WithEvents RibbonTab13 As RibbonTab
    'Friend WithEvents RibbonPanel18 As RibbonPanel
    'Friend WithEvents btnrBlock As RibbonButton
    'Friend WithEvents RibbonButton18 As RibbonButton
    'Friend WithEvents RibbonButton19 As RibbonButton
    'Friend WithEvents btnrRegrade As RibbonButton
    Friend WithEvents btnBlock As CButtonLib.CButton
    'Friend WithEvents RibbonTab14 As RibbonTab
    'Friend WithEvents RibbonPanel19 As RibbonPanel
    'Friend WithEvents RibbonButton20 As RibbonButton
    'Friend WithEvents RibbonPanel20 As RibbonPanel
    'Friend WithEvents RibbonButton21 As RibbonButton
    'Friend WithEvents RibbonPanel21 As RibbonPanel
    'Friend WithEvents RibbonButton27 As RibbonButton
    'Friend WithEvents RibbonPanel22 As RibbonPanel
    'Friend WithEvents RibbonButton28 As RibbonButton
    'Friend WithEvents RibbonPanel23 As RibbonPanel
    'Friend WithEvents RibbonButton29 As RibbonButton
    'Friend WithEvents RibbonPanel24 As RibbonPanel
    'Friend WithEvents RibbonButton31 As RibbonButton
    'Friend WithEvents RibbonPanel25 As RibbonPanel
    'Friend WithEvents RibbonButton32 As RibbonButton
    Friend WithEvents BackOfficeMenuStrip As MenuStrip
    Friend WithEvents ExpensesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordpadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSPaintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashbaordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChequeWriterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VATCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendSMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManufacturingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maintemanceSep1 As ToolStripSeparator
    Friend WithEvents DBBackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DBRestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maintenanceSep2 As ToolStripSeparator
    Friend WithEvents TerminalSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maintenanceSep3 As ToolStripSeparator
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecurityOprtionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddLevelToolStripMenuItem As ToolStripMenuItem
End Class
