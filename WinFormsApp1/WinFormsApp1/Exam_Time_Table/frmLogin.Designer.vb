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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GelButton1 = New GelButtons.GelButton()
        Me.Panel_Notify = New System.Windows.Forms.Panel()
        Me.lblNotify = New System.Windows.Forms.Label()
        Me.pic_notify = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReconnect = New System.Windows.Forms.Button()
        Me.cmbLoginType = New System.Windows.Forms.ComboBox()
        Me.btnForgetPassword = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblLicenseMessage = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.UserType = New System.Windows.Forms.TextBox()
        Me.txtCurrentClockInID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel_Notify.SuspendLayout()
        CType(Me.pic_notify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserID
        '
        Me.UserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserID.Location = New System.Drawing.Point(267, 65)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(33, 35)
        Me.UserID.TabIndex = 0
        Me.UserID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.GelButton1)
        Me.Panel1.Controls.Add(Me.Panel_Notify)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnReconnect)
        Me.Panel1.Controls.Add(Me.cmbLoginType)
        Me.Panel1.Controls.Add(Me.btnForgetPassword)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblLicenseMessage)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.UserType)
        Me.Panel1.Controls.Add(Me.txtCurrentClockInID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(1, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(912, 497)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 58.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(535, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(327, 104)
        Me.Label5.TabIndex = 402
        Me.Label5.Text = "SYSTEM"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Purple
        Me.LinkLabel1.Location = New System.Drawing.Point(479, 420)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(80, 15)
        Me.LinkLabel1.TabIndex = 397
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "File Reindexing"
        '
        'GelButton1
        '
        Me.GelButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GelButton1.BackColor = System.Drawing.Color.White
        Me.GelButton1.FlatAppearance.BorderSize = 0
        Me.GelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GelButton1.Font = New System.Drawing.Font("Segoe UI", 25.25!, System.Drawing.FontStyle.Bold)
        Me.GelButton1.ForeColor = System.Drawing.Color.White
        Me.GelButton1.GradientBottom = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GelButton1.GradientTop = System.Drawing.Color.Purple
        Me.GelButton1.Location = New System.Drawing.Point(316, 415)
        Me.GelButton1.Name = "GelButton1"
        Me.GelButton1.Size = New System.Drawing.Size(142, 64)
        Me.GelButton1.TabIndex = 400
        Me.GelButton1.Text = "Logout"
        Me.GelButton1.UseVisualStyleBackColor = False
        '
        'Panel_Notify
        '
        Me.Panel_Notify.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Notify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Notify.Controls.Add(Me.lblNotify)
        Me.Panel_Notify.Controls.Add(Me.pic_notify)
        Me.Panel_Notify.Location = New System.Drawing.Point(472, 3)
        Me.Panel_Notify.Name = "Panel_Notify"
        Me.Panel_Notify.Size = New System.Drawing.Size(440, 43)
        Me.Panel_Notify.TabIndex = 398
        Me.Panel_Notify.Visible = False
        '
        'lblNotify
        '
        Me.lblNotify.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotify.Location = New System.Drawing.Point(41, 5)
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(396, 36)
        Me.lblNotify.TabIndex = 1
        Me.lblNotify.Text = "License Status :"
        Me.lblNotify.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pic_notify
        '
        Me.pic_notify.Image = Global.WinFormsApp1.My.Resources.Resources.notify
        Me.pic_notify.Location = New System.Drawing.Point(4, 5)
        Me.pic_notify.Name = "pic_notify"
        Me.pic_notify.Size = New System.Drawing.Size(31, 31)
        Me.pic_notify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_notify.TabIndex = 0
        Me.pic_notify.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(482, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 64)
        Me.Label2.TabIndex = 399
        Me.Label2.Text = "Contact your agent or email  moyofola12@gmail.com or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               website : at" &
    "   infoconf.great-site.net " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'btnReconnect
        '
        Me.btnReconnect.BackColor = System.Drawing.Color.Transparent
        Me.btnReconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReconnect.FlatAppearance.BorderSize = 0
        Me.btnReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReconnect.ForeColor = System.Drawing.Color.White
        Me.btnReconnect.Image = Global.WinFormsApp1.My.Resources.Resources.database_server
        Me.btnReconnect.Location = New System.Drawing.Point(156, 415)
        Me.btnReconnect.Name = "btnReconnect"
        Me.btnReconnect.Size = New System.Drawing.Size(66, 61)
        Me.btnReconnect.TabIndex = 394
        Me.btnReconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnReconnect, "Check Database Connection Settings")
        Me.btnReconnect.UseVisualStyleBackColor = False
        '
        'cmbLoginType
        '
        Me.cmbLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoginType.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoginType.FormattingEnabled = True
        Me.cmbLoginType.Items.AddRange(New Object() {"PIN", "CARD"})
        Me.cmbLoginType.Location = New System.Drawing.Point(26, 10)
        Me.cmbLoginType.Name = "cmbLoginType"
        Me.cmbLoginType.Size = New System.Drawing.Size(91, 45)
        Me.cmbLoginType.TabIndex = 392
        '
        'btnForgetPassword
        '
        Me.btnForgetPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnForgetPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnForgetPassword.FlatAppearance.BorderSize = 0
        Me.btnForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgetPassword.ForeColor = System.Drawing.Color.White
        Me.btnForgetPassword.Image = CType(resources.GetObject("btnForgetPassword.Image"), System.Drawing.Image)
        Me.btnForgetPassword.Location = New System.Drawing.Point(228, 417)
        Me.btnForgetPassword.Name = "btnForgetPassword"
        Me.btnForgetPassword.Size = New System.Drawing.Size(66, 61)
        Me.btnForgetPassword.TabIndex = 386
        Me.btnForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnForgetPassword.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnX, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA9, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA0, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA8, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnScanCard, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA6, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA5, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA2, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(11, 61)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(453, 330)
        Me.TableLayoutPanel3.TabIndex = 385
        '
        'btnX
        '
        Me.btnX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnX.BackColor = System.Drawing.Color.White
        Me.btnX.FlatAppearance.BorderSize = 0
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.ForeColor = System.Drawing.Color.White
        Me.btnX.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnX.GradientTop = System.Drawing.Color.Purple
        Me.btnX.Location = New System.Drawing.Point(6, 249)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(140, 75)
        Me.btnX.TabIndex = 9
        Me.btnX.Text = "-->"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnTA9
        '
        Me.btnTA9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA9.BackColor = System.Drawing.Color.White
        Me.btnTA9.FlatAppearance.BorderSize = 0
        Me.btnTA9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA9.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA9.ForeColor = System.Drawing.Color.White
        Me.btnTA9.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA9.GradientTop = System.Drawing.Color.Purple
        Me.btnTA9.Location = New System.Drawing.Point(305, 168)
        Me.btnTA9.Name = "btnTA9"
        Me.btnTA9.Size = New System.Drawing.Size(142, 72)
        Me.btnTA9.TabIndex = 8
        Me.btnTA9.Text = "9"
        Me.btnTA9.UseVisualStyleBackColor = False
        '
        'btnTA0
        '
        Me.btnTA0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA0.BackColor = System.Drawing.Color.White
        Me.btnTA0.FlatAppearance.BorderSize = 0
        Me.btnTA0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA0.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA0.ForeColor = System.Drawing.Color.White
        Me.btnTA0.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA0.GradientTop = System.Drawing.Color.Purple
        Me.btnTA0.Location = New System.Drawing.Point(155, 249)
        Me.btnTA0.Name = "btnTA0"
        Me.btnTA0.Size = New System.Drawing.Size(141, 75)
        Me.btnTA0.TabIndex = 10
        Me.btnTA0.Text = "0"
        Me.btnTA0.UseVisualStyleBackColor = False
        '
        'btnTA8
        '
        Me.btnTA8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA8.BackColor = System.Drawing.Color.White
        Me.btnTA8.FlatAppearance.BorderSize = 0
        Me.btnTA8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA8.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA8.ForeColor = System.Drawing.Color.White
        Me.btnTA8.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA8.GradientTop = System.Drawing.Color.Purple
        Me.btnTA8.Location = New System.Drawing.Point(155, 168)
        Me.btnTA8.Name = "btnTA8"
        Me.btnTA8.Size = New System.Drawing.Size(141, 72)
        Me.btnTA8.TabIndex = 7
        Me.btnTA8.Text = "8"
        Me.btnTA8.UseVisualStyleBackColor = False
        '
        'btnTA4
        '
        Me.btnTA4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA4.BackColor = System.Drawing.Color.White
        Me.btnTA4.FlatAppearance.BorderSize = 0
        Me.btnTA4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA4.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA4.ForeColor = System.Drawing.Color.White
        Me.btnTA4.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA4.GradientTop = System.Drawing.Color.Purple
        Me.btnTA4.Location = New System.Drawing.Point(6, 87)
        Me.btnTA4.Name = "btnTA4"
        Me.btnTA4.Size = New System.Drawing.Size(140, 72)
        Me.btnTA4.TabIndex = 3
        Me.btnTA4.Text = "4"
        Me.btnTA4.UseVisualStyleBackColor = False
        '
        'btnScanCard
        '
        Me.btnScanCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScanCard.BackColor = System.Drawing.Color.Transparent
        Me.btnScanCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScanCard.FlatAppearance.BorderSize = 0
        Me.btnScanCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScanCard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanCard.ForeColor = System.Drawing.Color.White
        Me.btnScanCard.GradientBottom = System.Drawing.Color.Red
        Me.btnScanCard.GradientTop = System.Drawing.Color.Maroon
        Me.btnScanCard.Location = New System.Drawing.Point(305, 249)
        Me.btnScanCard.Name = "btnScanCard"
        Me.btnScanCard.Size = New System.Drawing.Size(142, 75)
        Me.btnScanCard.TabIndex = 11
        Me.btnScanCard.Text = "SCAN CARD"
        Me.btnScanCard.UseVisualStyleBackColor = False
        '
        'btnTA6
        '
        Me.btnTA6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA6.BackColor = System.Drawing.Color.White
        Me.btnTA6.FlatAppearance.BorderSize = 0
        Me.btnTA6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA6.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA6.ForeColor = System.Drawing.Color.White
        Me.btnTA6.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA6.GradientTop = System.Drawing.Color.Purple
        Me.btnTA6.Location = New System.Drawing.Point(305, 87)
        Me.btnTA6.Name = "btnTA6"
        Me.btnTA6.Size = New System.Drawing.Size(142, 72)
        Me.btnTA6.TabIndex = 5
        Me.btnTA6.Text = "6"
        Me.btnTA6.UseVisualStyleBackColor = False
        '
        'btnTA5
        '
        Me.btnTA5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA5.BackColor = System.Drawing.Color.White
        Me.btnTA5.FlatAppearance.BorderSize = 0
        Me.btnTA5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA5.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA5.ForeColor = System.Drawing.Color.White
        Me.btnTA5.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA5.GradientTop = System.Drawing.Color.Purple
        Me.btnTA5.Location = New System.Drawing.Point(155, 87)
        Me.btnTA5.Name = "btnTA5"
        Me.btnTA5.Size = New System.Drawing.Size(141, 72)
        Me.btnTA5.TabIndex = 4
        Me.btnTA5.Text = "5"
        Me.btnTA5.UseVisualStyleBackColor = False
        '
        'btnTA7
        '
        Me.btnTA7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA7.BackColor = System.Drawing.Color.White
        Me.btnTA7.FlatAppearance.BorderSize = 0
        Me.btnTA7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA7.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA7.ForeColor = System.Drawing.Color.White
        Me.btnTA7.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA7.GradientTop = System.Drawing.Color.Purple
        Me.btnTA7.Location = New System.Drawing.Point(6, 168)
        Me.btnTA7.Name = "btnTA7"
        Me.btnTA7.Size = New System.Drawing.Size(140, 72)
        Me.btnTA7.TabIndex = 6
        Me.btnTA7.Text = "7"
        Me.btnTA7.UseVisualStyleBackColor = False
        '
        'btnTA3
        '
        Me.btnTA3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA3.BackColor = System.Drawing.Color.White
        Me.btnTA3.FlatAppearance.BorderSize = 0
        Me.btnTA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA3.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA3.ForeColor = System.Drawing.Color.White
        Me.btnTA3.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA3.GradientTop = System.Drawing.Color.Purple
        Me.btnTA3.Location = New System.Drawing.Point(305, 6)
        Me.btnTA3.Name = "btnTA3"
        Me.btnTA3.Size = New System.Drawing.Size(142, 72)
        Me.btnTA3.TabIndex = 2
        Me.btnTA3.Text = "3"
        Me.btnTA3.UseVisualStyleBackColor = False
        '
        'btnTA1
        '
        Me.btnTA1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA1.BackColor = System.Drawing.Color.White
        Me.btnTA1.FlatAppearance.BorderSize = 0
        Me.btnTA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA1.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA1.ForeColor = System.Drawing.Color.White
        Me.btnTA1.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA1.GradientTop = System.Drawing.Color.Purple
        Me.btnTA1.Location = New System.Drawing.Point(6, 6)
        Me.btnTA1.Name = "btnTA1"
        Me.btnTA1.Size = New System.Drawing.Size(140, 72)
        Me.btnTA1.TabIndex = 0
        Me.btnTA1.Text = "1"
        Me.btnTA1.UseVisualStyleBackColor = False
        '
        'btnTA2
        '
        Me.btnTA2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA2.BackColor = System.Drawing.Color.White
        Me.btnTA2.FlatAppearance.BorderSize = 0
        Me.btnTA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA2.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA2.ForeColor = System.Drawing.Color.White
        Me.btnTA2.GradientBottom = System.Drawing.SystemColors.InfoText
        Me.btnTA2.GradientTop = System.Drawing.Color.Purple
        Me.btnTA2.Location = New System.Drawing.Point(155, 6)
        Me.btnTA2.Name = "btnTA2"
        Me.btnTA2.Size = New System.Drawing.Size(141, 72)
        Me.btnTA2.TabIndex = 1
        Me.btnTA2.Text = "2"
        Me.btnTA2.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.White
        Me.Password.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Password.Location = New System.Drawing.Point(134, 6)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(326, 50)
        Me.Password.TabIndex = 0
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(84, 415)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 61)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Purple
        Me.lblTime.Location = New System.Drawing.Point(11, 277)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(437, 86)
        Me.lblTime.TabIndex = 389
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLicenseMessage
        '
        Me.lblLicenseMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblLicenseMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLicenseMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLicenseMessage.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLicenseMessage.Location = New System.Drawing.Point(482, 436)
        Me.lblLicenseMessage.Name = "lblLicenseMessage"
        Me.lblLicenseMessage.Size = New System.Drawing.Size(430, 35)
        Me.lblLicenseMessage.TabIndex = 393
        Me.lblLicenseMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Purple
        Me.lblDate.Location = New System.Drawing.Point(482, 435)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(428, 37)
        Me.lblDate.TabIndex = 388
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDate.Visible = False
        '
        'UserType
        '
        Me.UserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserType.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserType.Location = New System.Drawing.Point(318, 150)
        Me.UserType.Name = "UserType"
        Me.UserType.Size = New System.Drawing.Size(33, 35)
        Me.UserType.TabIndex = 16
        Me.UserType.Visible = False
        '
        'txtCurrentClockInID
        '
        Me.txtCurrentClockInID.Location = New System.Drawing.Point(11, 162)
        Me.txtCurrentClockInID.Name = "txtCurrentClockInID"
        Me.txtCurrentClockInID.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentClockInID.TabIndex = 25
        Me.txtCurrentClockInID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 95.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(479, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(453, 168)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EXAM "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 54.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(452, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(489, 96)
        Me.Label4.TabIndex = 401
        Me.Label4.Text = "SUPERVISON "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(922, 46)
        Me.Panel2.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(919, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EXAM TIME TABLE SUPERVISION SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Database"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(925, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Notify.ResumeLayout(False)
        CType(Me.pic_notify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents UserType As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Label2 As Label
    Friend WithEvents GelButton1 As GelButtons.GelButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
