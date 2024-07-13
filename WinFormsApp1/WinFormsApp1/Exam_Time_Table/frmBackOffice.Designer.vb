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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackOffice))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.txtOpenID = New System.Windows.Forms.TextBox()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.BackOfficeMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManufacturingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordpadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSPaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashbaordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChequeWriterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VATCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendSMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.maintemanceSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DBBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.maintenanceSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TerminalSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.maintenanceSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecurityOprtionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.BackOfficeMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.lblUser, Me.ToolStripStatusLabel3, Me.lblDateTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 25)
        Me.StatusStrip1.TabIndex = 63
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(94, 20)
        Me.ToolStripStatusLabel4.Text = "Logged in As :"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Image = CType(resources.GetObject("lblUser.Image"), System.Drawing.Image)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(95, 20)
        Me.lblUser.Text = "User Name"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(1077, 20)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Text = "DATA PROCESSING"
        '
        'lblDateTime
        '
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.Black
        Me.lblDateTime.Image = CType(resources.GetObject("lblDateTime.Image"), System.Drawing.Image)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(89, 20)
        Me.lblDateTime.Text = "Date Time"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtOpenID
        '
        Me.txtOpenID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpenID.Location = New System.Drawing.Point(42, 280)
        Me.txtOpenID.Name = "txtOpenID"
        Me.txtOpenID.Size = New System.Drawing.Size(88, 20)
        Me.txtOpenID.TabIndex = 398
        Me.txtOpenID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOpenID.Visible = False
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Location = New System.Drawing.Point(39, 264)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(39, 13)
        Me.lblSet.TabIndex = 399
        Me.lblSet.Text = "Label2"
        Me.lblSet.Visible = False
        '
        'BackOfficeMenuStrip
        '
        Me.BackOfficeMenuStrip.BackColor = System.Drawing.Color.Purple
        Me.BackOfficeMenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BackOfficeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.ManufacturingToolStripMenuItem, Me.ExpensesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.BackOfficeMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.BackOfficeMenuStrip.Name = "BackOfficeMenuStrip"
        Me.BackOfficeMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BackOfficeMenuStrip.Size = New System.Drawing.Size(1370, 27)
        Me.BackOfficeMenuStrip.TabIndex = 400
        Me.BackOfficeMenuStrip.Text = "MenuStrip"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.SalesToolStripMenuItem.Enabled = False
        Me.SalesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SalesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(182, 23)
        Me.SalesToolStripMenuItem.Text = "TimeTable Data Processing"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.SupplierToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SupplierToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(93, 23)
        Me.SupplierToolStripMenuItem.Text = "Add Course"
        '
        'ManufacturingToolStripMenuItem
        '
        Me.ManufacturingToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.ManufacturingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ManufacturingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ManufacturingToolStripMenuItem.Name = "ManufacturingToolStripMenuItem"
        Me.ManufacturingToolStripMenuItem.Size = New System.Drawing.Size(124, 23)
        Me.ManufacturingToolStripMenuItem.Text = "Add Department"
        '
        'ExpensesToolStripMenuItem
        '
        Me.ExpensesToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.ExpensesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ExpensesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExpensesToolStripMenuItem.Name = "ExpensesToolStripMenuItem"
        Me.ExpensesToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.ExpensesToolStripMenuItem.Text = "Allocate"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotepadToolStripMenuItem, Me.CalculatorToolStripMenuItem, Me.WordpadToolStripMenuItem, Me.MSWordToolStripMenuItem, Me.MSPaintToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.DashbaordToolStripMenuItem, Me.ChequeWriterToolStripMenuItem, Me.VATCalculatorToolStripMenuItem, Me.SendSMSToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.NotepadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NotepadToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.notepad
        Me.NotepadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.CalculatorToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CalculatorToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.calculator
        Me.CalculatorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'WordpadToolStripMenuItem
        '
        Me.WordpadToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.WordpadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        '  Me.WordpadToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.wordpad
        Me.WordpadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WordpadToolStripMenuItem.Name = "WordpadToolStripMenuItem"
        Me.WordpadToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.WordpadToolStripMenuItem.Text = "Wordpad"
        '
        'MSWordToolStripMenuItem
        '
        Me.MSWordToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.MSWordToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MSWordToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.ms_word
        Me.MSWordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MSWordToolStripMenuItem.Name = "MSWordToolStripMenuItem"
        Me.MSWordToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.MSWordToolStripMenuItem.Text = "MS Word"
        '
        'MSPaintToolStripMenuItem
        '
        Me.MSPaintToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.MSPaintToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MSPaintToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.ms_paint
        Me.MSPaintToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MSPaintToolStripMenuItem.Name = "MSPaintToolStripMenuItem"
        Me.MSPaintToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.MSPaintToolStripMenuItem.Text = "MS Paint"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.TaskManagerToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TaskManagerToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.taskmanager
        Me.TaskManagerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'DashbaordToolStripMenuItem
        '
        Me.DashbaordToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.DashbaordToolStripMenuItem.ForeColor = System.Drawing.Color.White
        '  Me.DashbaordToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.dashboard
        Me.DashbaordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DashbaordToolStripMenuItem.Name = "DashbaordToolStripMenuItem"
        Me.DashbaordToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.DashbaordToolStripMenuItem.Text = "Dashbaord"
        '
        'ChequeWriterToolStripMenuItem
        '
        Me.ChequeWriterToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.ChequeWriterToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ChequeWriterToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.cheque
        Me.ChequeWriterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ChequeWriterToolStripMenuItem.Name = "ChequeWriterToolStripMenuItem"
        Me.ChequeWriterToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.ChequeWriterToolStripMenuItem.Text = "Cheque Writer"
        '
        'VATCalculatorToolStripMenuItem
        '
        Me.VATCalculatorToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.VATCalculatorToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VATCalculatorToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.vat_calculator
        Me.VATCalculatorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VATCalculatorToolStripMenuItem.Name = "VATCalculatorToolStripMenuItem"
        Me.VATCalculatorToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.VATCalculatorToolStripMenuItem.Text = "VAT Calculator"
        '
        'SendSMSToolStripMenuItem
        '
        Me.SendSMSToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.SendSMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditCustomersToolStripMenuItem, Me.GeneralCustomersToolStripMenuItem})
        Me.SendSMSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SendSMSToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.send_sms
        Me.SendSMSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SendSMSToolStripMenuItem.Name = "SendSMSToolStripMenuItem"
        Me.SendSMSToolStripMenuItem.Size = New System.Drawing.Size(172, 28)
        Me.SendSMSToolStripMenuItem.Text = "Send SMS"
        '
        'CreditCustomersToolStripMenuItem
        '
        Me.CreditCustomersToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.CreditCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        ' Me.CreditCustomersToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources
        Me.CreditCustomersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CreditCustomersToolStripMenuItem.Name = "CreditCustomersToolStripMenuItem"
        Me.CreditCustomersToolStripMenuItem.Size = New System.Drawing.Size(200, 28)
        Me.CreditCustomersToolStripMenuItem.Text = "Credit Customers"
        '
        'GeneralCustomersToolStripMenuItem
        '
        Me.GeneralCustomersToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.GeneralCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GeneralCustomersToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.generalSMS
        Me.GeneralCustomersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GeneralCustomersToolStripMenuItem.Name = "GeneralCustomersToolStripMenuItem"
        Me.GeneralCustomersToolStripMenuItem.Size = New System.Drawing.Size(200, 28)
        Me.GeneralCustomersToolStripMenuItem.Text = "General Customers"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogsToolStripMenuItem, Me.CompanyInfoToolStripMenuItem, Me.SMSToolStripMenuItem, Me.EmailToolStripMenuItem, Me.maintemanceSep1, Me.DBBackupToolStripMenuItem, Me.DBRestoreToolStripMenuItem, Me.ResetDatabaseToolStripMenuItem, Me.maintenanceSep2, Me.TerminalSettingToolStripMenuItem, Me.maintenanceSep3, Me.RegistrationToolStripMenuItem, Me.UserRightToolStripMenuItem, Me.AdvancedSettingsToolStripMenuItem, Me.SecurityOprtionToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.MaintenanceToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(100, 23)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.LogsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogsToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.logs
        Me.LogsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'CompanyInfoToolStripMenuItem
        '
        Me.CompanyInfoToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.CompanyInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        '  Me.CompanyInfoToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.company
        Me.CompanyInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CompanyInfoToolStripMenuItem.Name = "CompanyInfoToolStripMenuItem"
        Me.CompanyInfoToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.CompanyInfoToolStripMenuItem.Text = "Company Info"
        '
        'SMSToolStripMenuItem
        '
        Me.SMSToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.SMSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SMSToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.send_sms
        Me.SMSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem"
        Me.SMSToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.SMSToolStripMenuItem.Text = "SMS Settings"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.EmailToolStripMenuItem.ForeColor = System.Drawing.Color.White
        'Me.EmailToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.email
        Me.EmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.EmailToolStripMenuItem.Text = "Email Settings"
        '
        'maintemanceSep1
        '
        Me.maintemanceSep1.Name = "maintemanceSep1"
        Me.maintemanceSep1.Size = New System.Drawing.Size(192, 6)
        '
        'DBBackupToolStripMenuItem
        '
        Me.DBBackupToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.DBBackupToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DBBackupToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.database_backup
        Me.DBBackupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DBBackupToolStripMenuItem.Name = "DBBackupToolStripMenuItem"
        Me.DBBackupToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.DBBackupToolStripMenuItem.Text = "DB Backup"
        '
        'DBRestoreToolStripMenuItem
        '
        Me.DBRestoreToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.DBRestoreToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DBRestoreToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.database_restore
        Me.DBRestoreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DBRestoreToolStripMenuItem.Name = "DBRestoreToolStripMenuItem"
        Me.DBRestoreToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.DBRestoreToolStripMenuItem.Text = "DB Restore"
        '
        'ResetDatabaseToolStripMenuItem
        '
        Me.ResetDatabaseToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.ResetDatabaseToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ResetDatabaseToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.database_reset
        Me.ResetDatabaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ResetDatabaseToolStripMenuItem.Name = "ResetDatabaseToolStripMenuItem"
        Me.ResetDatabaseToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.ResetDatabaseToolStripMenuItem.Text = "Reset Database"
        '
        'maintenanceSep2
        '
        Me.maintenanceSep2.Name = "maintenanceSep2"
        Me.maintenanceSep2.Size = New System.Drawing.Size(192, 6)
        '
        'TerminalSettingToolStripMenuItem
        '
        Me.TerminalSettingToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.TerminalSettingToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TerminalSettingToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.terminal_settings
        Me.TerminalSettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TerminalSettingToolStripMenuItem.Name = "TerminalSettingToolStripMenuItem"
        Me.TerminalSettingToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.TerminalSettingToolStripMenuItem.Text = "Hardware Setting"
        '
        'maintenanceSep3
        '
        Me.maintenanceSep3.Name = "maintenanceSep3"
        Me.maintenanceSep3.Size = New System.Drawing.Size(192, 6)
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.RegistrationToolStripMenuItem.ForeColor = System.Drawing.Color.White
        ' Me.RegistrationToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.registration
        Me.RegistrationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.RegistrationToolStripMenuItem.Text = "Users"
        '
        'UserRightToolStripMenuItem
        '
        Me.UserRightToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.UserRightToolStripMenuItem.ForeColor = System.Drawing.Color.White
        ' Me.UserRightToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.user_rights
        Me.UserRightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UserRightToolStripMenuItem.Name = "UserRightToolStripMenuItem"
        Me.UserRightToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.UserRightToolStripMenuItem.Text = "User Right"
        '
        'AdvancedSettingsToolStripMenuItem
        '
        Me.AdvancedSettingsToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.AdvancedSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdvancedSettingsToolStripMenuItem.Name = "AdvancedSettingsToolStripMenuItem"
        Me.AdvancedSettingsToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.AdvancedSettingsToolStripMenuItem.Text = "Advanced settings"
        '
        'SecurityOprtionToolStripMenuItem
        '
        Me.SecurityOprtionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SecurityOprtionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SecurityOprtionToolStripMenuItem.Name = "SecurityOprtionToolStripMenuItem"
        Me.SecurityOprtionToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.SecurityOprtionToolStripMenuItem.Text = "SecurityOption"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(49, 23)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.AboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutUsToolStripMenuItem.Image = Global.WinFormsApp1.My.Resources.Resources.about
        Me.AboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(141, 28)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.LogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem1})
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(65, 23)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.BackColor = System.Drawing.Color.Purple
        Me.LogoutToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem1.Image = Global.WinFormsApp1.My.Resources.Resources.logout
        Me.LogoutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(127, 28)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.InventoryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.InventoryToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(93, 23)
        Me.InventoryToolStripMenuItem.Text = "Add Faculty"
        '
        'frmBackOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.txtOpenID)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BackOfficeMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.BackOfficeMenuStrip
        Me.MaximizeBox = False
        Me.Name = "frmBackOffice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Back Office (Data Processing)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.BackOfficeMenuStrip.ResumeLayout(False)
        Me.BackOfficeMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents UserRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecurityOprtionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
End Class
