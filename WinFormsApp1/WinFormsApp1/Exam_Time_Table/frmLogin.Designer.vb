<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmLogin
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
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents btnScanCard As GelButtons.GelButton
    Friend WithEvents btnCancel As Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        UserID = New TextBox()
        Panel1 = New Panel()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        LinkLabel1 = New LinkLabel()
        GelButton1 = New GelButtons.GelButton()
        Panel_Notify = New Panel()
        lblNotify = New Label()
        pic_notify = New PictureBox()
        btnReconnect = New Button()
        cmbLoginType = New ComboBox()
        btnForgetPassword = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnX = New GelButtons.GelButton()
        btnTA9 = New GelButtons.GelButton()
        btnTA0 = New GelButtons.GelButton()
        btnTA8 = New GelButtons.GelButton()
        btnTA4 = New GelButtons.GelButton()
        btnScanCard = New GelButtons.GelButton()
        btnTA6 = New GelButtons.GelButton()
        btnTA5 = New GelButtons.GelButton()
        btnTA7 = New GelButtons.GelButton()
        btnTA3 = New GelButtons.GelButton()
        btnTA1 = New GelButtons.GelButton()
        btnTA2 = New GelButtons.GelButton()
        Password = New TextBox()
        btnCancel = New Button()
        lblTime = New Label()
        lblLicenseMessage = New Label()
        lblDate = New Label()
        UserType = New TextBox()
        txtCurrentClockInID = New TextBox()
        Timer2 = New Timer(components)
        ToolTip1 = New ToolTip(components)
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel_Notify.SuspendLayout()
        CType(pic_notify, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' UserID
        ' 
        UserID.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserID.ForeColor = Color.DarkViolet
        UserID.Location = New Point(312, 75)
        UserID.Margin = New Padding(4, 3, 4, 3)
        UserID.Name = "UserID"
        UserID.Size = New Size(38, 35)
        UserID.TabIndex = 0
        UserID.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(GelButton1)
        Panel1.Controls.Add(Panel_Notify)
        Panel1.Controls.Add(btnReconnect)
        Panel1.Controls.Add(cmbLoginType)
        Panel1.Controls.Add(btnForgetPassword)
        Panel1.Controls.Add(TableLayoutPanel3)
        Panel1.Controls.Add(Password)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(lblTime)
        Panel1.Controls.Add(lblLicenseMessage)
        Panel1.Controls.Add(lblDate)
        Panel1.Controls.Add(UserType)
        Panel1.Controls.Add(txtCurrentClockInID)
        Panel1.Location = New Point(6, 51)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1064, 573)
        Panel1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 58.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Purple
        Label5.Location = New Point(623, 378)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(327, 104)
        Label5.TabIndex = 407
        Label5.Text = "SYSTEM"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.5F)
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(561, 70)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(502, 74)
        Label2.TabIndex = 405
        Label2.Text = "Contact your agent or email  moyofola12@gmail.com or" & vbCrLf & "               website : at   infoconf.great-site.net " & vbCrLf
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 95.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Purple
        Label3.Location = New Point(558, 105)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(453, 168)
        Label3.TabIndex = 404
        Label3.Text = "EXAM "
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 54.0F, FontStyle.Bold)
        Label4.ForeColor = Color.Purple
        Label4.Location = New Point(558, 273)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(489, 96)
        Label4.TabIndex = 406
        Label4.Text = "SUPERVISON "
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Times New Roman", 9.0F)
        LinkLabel1.LinkColor = Color.Purple
        LinkLabel1.Location = New Point(559, 485)
        LinkLabel1.Margin = New Padding(4, 0, 4, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(80, 15)
        LinkLabel1.TabIndex = 397
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "File Reindexing"
        ' 
        ' GelButton1
        ' 
        GelButton1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GelButton1.BackColor = Color.White
        GelButton1.FlatAppearance.BorderSize = 0
        GelButton1.FlatStyle = FlatStyle.Flat
        GelButton1.Font = New Font("Segoe UI", 25.25F, FontStyle.Bold)
        GelButton1.ForeColor = Color.White
        GelButton1.GradientBottom = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        GelButton1.GradientTop = Color.Purple
        GelButton1.Location = New Point(369, 479)
        GelButton1.Margin = New Padding(4, 3, 4, 3)
        GelButton1.Name = "GelButton1"
        GelButton1.Size = New Size(166, 74)
        GelButton1.TabIndex = 400
        GelButton1.Text = "Logout"
        GelButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel_Notify
        ' 
        Panel_Notify.BackColor = Color.Transparent
        Panel_Notify.BorderStyle = BorderStyle.FixedSingle
        Panel_Notify.Controls.Add(lblNotify)
        Panel_Notify.Controls.Add(pic_notify)
        Panel_Notify.Location = New Point(551, 3)
        Panel_Notify.Margin = New Padding(4, 3, 4, 3)
        Panel_Notify.Name = "Panel_Notify"
        Panel_Notify.Size = New Size(513, 49)
        Panel_Notify.TabIndex = 398
        Panel_Notify.Visible = False
        ' 
        ' lblNotify
        ' 
        lblNotify.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNotify.Location = New Point(48, 6)
        lblNotify.Margin = New Padding(4, 0, 4, 0)
        lblNotify.Name = "lblNotify"
        lblNotify.Size = New Size(462, 42)
        lblNotify.TabIndex = 1
        lblNotify.Text = "License Status :"
        lblNotify.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pic_notify
        ' 
        pic_notify.Image = My.Resources.Resources.notify
        pic_notify.Location = New Point(5, 6)
        pic_notify.Margin = New Padding(4, 3, 4, 3)
        pic_notify.Name = "pic_notify"
        pic_notify.Size = New Size(36, 36)
        pic_notify.SizeMode = PictureBoxSizeMode.StretchImage
        pic_notify.TabIndex = 0
        pic_notify.TabStop = False
        ' 
        ' btnReconnect
        ' 
        btnReconnect.BackColor = Color.Transparent
        btnReconnect.DialogResult = DialogResult.Cancel
        btnReconnect.FlatAppearance.BorderSize = 0
        btnReconnect.FlatStyle = FlatStyle.Flat
        btnReconnect.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReconnect.ForeColor = Color.White
        btnReconnect.Image = My.Resources.Resources.database_server
        btnReconnect.Location = New Point(182, 479)
        btnReconnect.Margin = New Padding(4, 3, 4, 3)
        btnReconnect.Name = "btnReconnect"
        btnReconnect.Size = New Size(77, 70)
        btnReconnect.TabIndex = 394
        btnReconnect.TextAlign = ContentAlignment.MiddleRight
        ToolTip1.SetToolTip(btnReconnect, "Check Database Connection Settings")
        btnReconnect.UseVisualStyleBackColor = False
        ' 
        ' cmbLoginType
        ' 
        cmbLoginType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLoginType.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbLoginType.FormattingEnabled = True
        cmbLoginType.Items.AddRange(New Object() {"PIN", "CARD"})
        cmbLoginType.Location = New Point(20, 5)
        cmbLoginType.Margin = New Padding(4, 3, 4, 3)
        cmbLoginType.Name = "cmbLoginType"
        cmbLoginType.Size = New Size(133, 45)
        cmbLoginType.TabIndex = 392
        ' 
        ' btnForgetPassword
        ' 
        btnForgetPassword.BackColor = Color.Transparent
        btnForgetPassword.DialogResult = DialogResult.Cancel
        btnForgetPassword.FlatAppearance.BorderSize = 0
        btnForgetPassword.FlatStyle = FlatStyle.Flat
        btnForgetPassword.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnForgetPassword.ForeColor = Color.White
        btnForgetPassword.Image = CType(resources.GetObject("btnForgetPassword.Image"), Image)
        btnForgetPassword.Location = New Point(266, 481)
        btnForgetPassword.Margin = New Padding(4, 3, 4, 3)
        btnForgetPassword.Name = "btnForgetPassword"
        btnForgetPassword.Size = New Size(77, 70)
        btnForgetPassword.TabIndex = 386
        btnForgetPassword.TextAlign = ContentAlignment.MiddleRight
        btnForgetPassword.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.Transparent
        TableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33334F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33334F))
        TableLayoutPanel3.Controls.Add(btnX, 0, 3)
        TableLayoutPanel3.Controls.Add(btnTA9, 2, 2)
        TableLayoutPanel3.Controls.Add(btnTA0, 1, 3)
        TableLayoutPanel3.Controls.Add(btnTA8, 1, 2)
        TableLayoutPanel3.Controls.Add(btnTA4, 0, 1)
        TableLayoutPanel3.Controls.Add(btnScanCard, 2, 3)
        TableLayoutPanel3.Controls.Add(btnTA6, 2, 1)
        TableLayoutPanel3.Controls.Add(btnTA5, 1, 1)
        TableLayoutPanel3.Controls.Add(btnTA7, 0, 2)
        TableLayoutPanel3.Controls.Add(btnTA3, 2, 0)
        TableLayoutPanel3.Controls.Add(btnTA1, 0, 0)
        TableLayoutPanel3.Controls.Add(btnTA2, 1, 0)
        TableLayoutPanel3.Location = New Point(13, 70)
        TableLayoutPanel3.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 4
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel3.Size = New Size(528, 381)
        TableLayoutPanel3.TabIndex = 385
        ' 
        ' btnX
        ' 
        btnX.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnX.BackColor = Color.White
        btnX.FlatAppearance.BorderSize = 0
        btnX.FlatStyle = FlatStyle.Flat
        btnX.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnX.ForeColor = Color.White
        btnX.GradientBottom = SystemColors.InfoText
        btnX.GradientTop = Color.Purple
        btnX.Location = New Point(7, 288)
        btnX.Margin = New Padding(4, 3, 4, 3)
        btnX.Name = "btnX"
        btnX.Size = New Size(163, 87)
        btnX.TabIndex = 9
        btnX.Text = "-->"
        btnX.UseVisualStyleBackColor = False
        ' 
        ' btnTA9
        ' 
        btnTA9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA9.BackColor = Color.White
        btnTA9.FlatAppearance.BorderSize = 0
        btnTA9.FlatStyle = FlatStyle.Flat
        btnTA9.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA9.ForeColor = Color.White
        btnTA9.GradientBottom = SystemColors.InfoText
        btnTA9.GradientTop = Color.Purple
        btnTA9.Location = New Point(356, 194)
        btnTA9.Margin = New Padding(4, 3, 4, 3)
        btnTA9.Name = "btnTA9"
        btnTA9.Size = New Size(165, 85)
        btnTA9.TabIndex = 8
        btnTA9.Text = "9"
        btnTA9.UseVisualStyleBackColor = False
        ' 
        ' btnTA0
        ' 
        btnTA0.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA0.BackColor = Color.White
        btnTA0.FlatAppearance.BorderSize = 0
        btnTA0.FlatStyle = FlatStyle.Flat
        btnTA0.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA0.ForeColor = Color.White
        btnTA0.GradientBottom = SystemColors.InfoText
        btnTA0.GradientTop = Color.Purple
        btnTA0.Location = New Point(181, 288)
        btnTA0.Margin = New Padding(4, 3, 4, 3)
        btnTA0.Name = "btnTA0"
        btnTA0.Size = New Size(164, 87)
        btnTA0.TabIndex = 10
        btnTA0.Text = "0"
        btnTA0.UseVisualStyleBackColor = False
        ' 
        ' btnTA8
        ' 
        btnTA8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA8.BackColor = Color.White
        btnTA8.FlatAppearance.BorderSize = 0
        btnTA8.FlatStyle = FlatStyle.Flat
        btnTA8.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA8.ForeColor = Color.White
        btnTA8.GradientBottom = SystemColors.InfoText
        btnTA8.GradientTop = Color.Purple
        btnTA8.Location = New Point(181, 194)
        btnTA8.Margin = New Padding(4, 3, 4, 3)
        btnTA8.Name = "btnTA8"
        btnTA8.Size = New Size(164, 85)
        btnTA8.TabIndex = 7
        btnTA8.Text = "8"
        btnTA8.UseVisualStyleBackColor = False
        ' 
        ' btnTA4
        ' 
        btnTA4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA4.BackColor = Color.White
        btnTA4.FlatAppearance.BorderSize = 0
        btnTA4.FlatStyle = FlatStyle.Flat
        btnTA4.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA4.ForeColor = Color.White
        btnTA4.GradientBottom = SystemColors.InfoText
        btnTA4.GradientTop = Color.Purple
        btnTA4.Location = New Point(7, 100)
        btnTA4.Margin = New Padding(4, 3, 4, 3)
        btnTA4.Name = "btnTA4"
        btnTA4.Size = New Size(163, 85)
        btnTA4.TabIndex = 3
        btnTA4.Text = "4"
        btnTA4.UseVisualStyleBackColor = False
        ' 
        ' btnScanCard
        ' 
        btnScanCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnScanCard.BackColor = Color.Transparent
        btnScanCard.BackgroundImageLayout = ImageLayout.Stretch
        btnScanCard.FlatAppearance.BorderSize = 0
        btnScanCard.FlatStyle = FlatStyle.Flat
        btnScanCard.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnScanCard.ForeColor = Color.White
        btnScanCard.GradientBottom = Color.Red
        btnScanCard.GradientTop = Color.Maroon
        btnScanCard.Location = New Point(356, 288)
        btnScanCard.Margin = New Padding(4, 3, 4, 3)
        btnScanCard.Name = "btnScanCard"
        btnScanCard.Size = New Size(165, 87)
        btnScanCard.TabIndex = 11
        btnScanCard.Text = "SCAN CARD"
        btnScanCard.UseVisualStyleBackColor = False
        ' 
        ' btnTA6
        ' 
        btnTA6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA6.BackColor = Color.White
        btnTA6.FlatAppearance.BorderSize = 0
        btnTA6.FlatStyle = FlatStyle.Flat
        btnTA6.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA6.ForeColor = Color.White
        btnTA6.GradientBottom = SystemColors.InfoText
        btnTA6.GradientTop = Color.Purple
        btnTA6.Location = New Point(356, 100)
        btnTA6.Margin = New Padding(4, 3, 4, 3)
        btnTA6.Name = "btnTA6"
        btnTA6.Size = New Size(165, 85)
        btnTA6.TabIndex = 5
        btnTA6.Text = "6"
        btnTA6.UseVisualStyleBackColor = False
        ' 
        ' btnTA5
        ' 
        btnTA5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA5.BackColor = Color.White
        btnTA5.FlatAppearance.BorderSize = 0
        btnTA5.FlatStyle = FlatStyle.Flat
        btnTA5.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA5.ForeColor = Color.White
        btnTA5.GradientBottom = SystemColors.InfoText
        btnTA5.GradientTop = Color.Purple
        btnTA5.Location = New Point(181, 100)
        btnTA5.Margin = New Padding(4, 3, 4, 3)
        btnTA5.Name = "btnTA5"
        btnTA5.Size = New Size(164, 85)
        btnTA5.TabIndex = 4
        btnTA5.Text = "5"
        btnTA5.UseVisualStyleBackColor = False
        ' 
        ' btnTA7
        ' 
        btnTA7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA7.BackColor = Color.White
        btnTA7.FlatAppearance.BorderSize = 0
        btnTA7.FlatStyle = FlatStyle.Flat
        btnTA7.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA7.ForeColor = Color.White
        btnTA7.GradientBottom = SystemColors.InfoText
        btnTA7.GradientTop = Color.Purple
        btnTA7.Location = New Point(7, 194)
        btnTA7.Margin = New Padding(4, 3, 4, 3)
        btnTA7.Name = "btnTA7"
        btnTA7.Size = New Size(163, 85)
        btnTA7.TabIndex = 6
        btnTA7.Text = "7"
        btnTA7.UseVisualStyleBackColor = False
        ' 
        ' btnTA3
        ' 
        btnTA3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA3.BackColor = Color.White
        btnTA3.FlatAppearance.BorderSize = 0
        btnTA3.FlatStyle = FlatStyle.Flat
        btnTA3.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA3.ForeColor = Color.White
        btnTA3.GradientBottom = SystemColors.InfoText
        btnTA3.GradientTop = Color.Purple
        btnTA3.Location = New Point(356, 6)
        btnTA3.Margin = New Padding(4, 3, 4, 3)
        btnTA3.Name = "btnTA3"
        btnTA3.Size = New Size(165, 85)
        btnTA3.TabIndex = 2
        btnTA3.Text = "3"
        btnTA3.UseVisualStyleBackColor = False
        ' 
        ' btnTA1
        ' 
        btnTA1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA1.BackColor = Color.White
        btnTA1.FlatAppearance.BorderSize = 0
        btnTA1.FlatStyle = FlatStyle.Flat
        btnTA1.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA1.ForeColor = Color.White
        btnTA1.GradientBottom = SystemColors.InfoText
        btnTA1.GradientTop = Color.Purple
        btnTA1.Location = New Point(7, 6)
        btnTA1.Margin = New Padding(4, 3, 4, 3)
        btnTA1.Name = "btnTA1"
        btnTA1.Size = New Size(163, 85)
        btnTA1.TabIndex = 0
        btnTA1.Text = "1"
        btnTA1.UseVisualStyleBackColor = False
        ' 
        ' btnTA2
        ' 
        btnTA2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnTA2.BackColor = Color.White
        btnTA2.FlatAppearance.BorderSize = 0
        btnTA2.FlatStyle = FlatStyle.Flat
        btnTA2.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTA2.ForeColor = Color.White
        btnTA2.GradientBottom = SystemColors.InfoText
        btnTA2.GradientTop = Color.Purple
        btnTA2.Location = New Point(181, 6)
        btnTA2.Margin = New Padding(4, 3, 4, 3)
        btnTA2.Name = "btnTA2"
        btnTA2.Size = New Size(164, 85)
        btnTA2.TabIndex = 1
        btnTA2.Text = "2"
        btnTA2.UseVisualStyleBackColor = False
        ' 
        ' Password
        ' 
        Password.BackColor = Color.White
        Password.Font = New Font("Segoe UI Semibold", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Password.ForeColor = Color.MidnightBlue
        Password.Location = New Point(161, 3)
        Password.Margin = New Padding(4, 3, 4, 3)
        Password.Name = "Password"
        Password.Size = New Size(379, 50)
        Password.TabIndex = 0
        Password.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.Location = New Point(98, 479)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(77, 70)
        btnCancel.TabIndex = 0
        btnCancel.TextAlign = ContentAlignment.MiddleRight
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblTime
        ' 
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.Purple
        lblTime.Location = New Point(13, 320)
        lblTime.Margin = New Padding(4, 0, 4, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(510, 99)
        lblTime.TabIndex = 389
        lblTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLicenseMessage
        ' 
        lblLicenseMessage.BackColor = Color.Transparent
        lblLicenseMessage.BorderStyle = BorderStyle.FixedSingle
        lblLicenseMessage.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblLicenseMessage.ForeColor = SystemColors.HotTrack
        lblLicenseMessage.Location = New Point(562, 503)
        lblLicenseMessage.Margin = New Padding(4, 0, 4, 0)
        lblLicenseMessage.Name = "lblLicenseMessage"
        lblLicenseMessage.Size = New Size(501, 40)
        lblLicenseMessage.TabIndex = 393
        lblLicenseMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDate
        ' 
        lblDate.BackColor = Color.Transparent
        lblDate.BorderStyle = BorderStyle.FixedSingle
        lblDate.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.Purple
        lblDate.Location = New Point(562, 502)
        lblDate.Margin = New Padding(4, 0, 4, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(499, 42)
        lblDate.TabIndex = 388
        lblDate.TextAlign = ContentAlignment.MiddleCenter
        lblDate.Visible = False
        ' 
        ' UserType
        ' 
        UserType.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserType.ForeColor = Color.DarkViolet
        UserType.Location = New Point(371, 173)
        UserType.Margin = New Padding(4, 3, 4, 3)
        UserType.Name = "UserType"
        UserType.Size = New Size(38, 35)
        UserType.TabIndex = 16
        UserType.Visible = False
        ' 
        ' txtCurrentClockInID
        ' 
        txtCurrentClockInID.Location = New Point(13, 187)
        txtCurrentClockInID.Margin = New Padding(4, 3, 4, 3)
        txtCurrentClockInID.Name = "txtCurrentClockInID"
        txtCurrentClockInID.Size = New Size(116, 23)
        txtCurrentClockInID.TabIndex = 25
        txtCurrentClockInID.Visible = False
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Database"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.BackColor = Color.Purple
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Turquoise
        Label1.Location = New Point(-2, -4)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1085, 50)
        Label1.TabIndex = 403
        Label1.Text = "EXAM TIME TABLE SUPERVISION SYSTEM"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1079, 635)
        Controls.Add(Panel1)
        Controls.Add(UserID)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel_Notify.ResumeLayout(False)
        CType(pic_notify, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents UserType As System.Windows.Forms.TextBox
    Friend WithEvents btnForgetPassword As System.Windows.Forms.Button
    Friend WithEvents txtCurrentClockInID As System.Windows.Forms.TextBox
    Friend WithEvents btnX As GelButtons.GelButton
    Friend WithEvents btnTA9 As GelButtons.GelButton
    Friend WithEvents btnTA0 As GelButtons.GelButton
    Friend WithEvents btnTA8 As GelButtons.GelButton
    Friend WithEvents btnTA4 As GelButtons.GelButton
    Friend WithEvents btnTA6 As GelButtons.GelButton
    Friend WithEvents btnTA5 As GelButtons.GelButton
    Friend WithEvents btnTA7 As GelButtons.GelButton
    Friend WithEvents btnTA3 As GelButtons.GelButton
    Friend WithEvents btnTA1 As GelButtons.GelButton
    Friend WithEvents btnTA2 As GelButtons.GelButton
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents cmbLoginType As System.Windows.Forms.ComboBox
    Friend WithEvents lblLicenseMessage As Label
    Friend WithEvents btnReconnect As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel_Notify As Panel
    Friend WithEvents pic_notify As PictureBox
    Friend WithEvents lblNotify As Label
    Friend WithEvents GelButton1 As GelButtons.GelButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
