<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOption
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
        Dim CBlendItems1 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOption))
        Dim CBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Dim CBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
        Me.btnBackOffice = New CButtonLib.CButton()
        Me.btnFrontOffice = New CButtonLib.CButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUserType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClose = New CButtonLib.CButton()
        Me.btnClockOUT = New CButtonLib.CButton()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBackOffice
        '
        Me.btnBackOffice.BackColor = System.Drawing.Color.Transparent
        Me.btnBackOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.Purple, System.Drawing.Color.Purple, System.Drawing.Color.Purple}
        CBlendItems1.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.btnBackOffice.ColorFillBlend = CBlendItems1
        Me.btnBackOffice.Corners.All = 10
        Me.btnBackOffice.Corners.LowerLeft = 10
        Me.btnBackOffice.Corners.LowerRight = 10
        Me.btnBackOffice.Corners.UpperLeft = 10
        Me.btnBackOffice.Corners.UpperRight = 10
        Me.btnBackOffice.DesignerSelected = False
        Me.btnBackOffice.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackOffice.ImageIndex = 0
        Me.btnBackOffice.ImageSize = New System.Drawing.Size(256, 256)
        Me.btnBackOffice.Location = New System.Drawing.Point(12, 12)
        Me.btnBackOffice.Name = "btnBackOffice"
        Me.btnBackOffice.Size = New System.Drawing.Size(415, 342)
        Me.btnBackOffice.TabIndex = 1
        Me.btnBackOffice.Text = "Back Office"
        Me.btnBackOffice.TextShadowShow = False
        Me.btnBackOffice.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnFrontOffice
        '
        Me.btnFrontOffice.BackColor = System.Drawing.Color.Transparent
        Me.btnFrontOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.btnFrontOffice.ColorFillBlend = CBlendItems2
        Me.btnFrontOffice.Corners.All = 10
        Me.btnFrontOffice.Corners.LowerLeft = 10
        Me.btnFrontOffice.Corners.LowerRight = 10
        Me.btnFrontOffice.Corners.UpperLeft = 10
        Me.btnFrontOffice.Corners.UpperRight = 10
        Me.btnFrontOffice.DesignerSelected = False
        Me.btnFrontOffice.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrontOffice.ImageIndex = 0
        Me.btnFrontOffice.ImageSize = New System.Drawing.Size(256, 256)
        Me.btnFrontOffice.Location = New System.Drawing.Point(433, 12)
        Me.btnFrontOffice.Name = "btnFrontOffice"
        Me.btnFrontOffice.Size = New System.Drawing.Size(415, 342)
        Me.btnFrontOffice.TabIndex = 2
        Me.btnFrontOffice.Text = "POS"
        Me.btnFrontOffice.TextShadowShow = False
        Me.btnFrontOffice.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUserType, Me.ToolStripStatusLabel2, Me.lblUser, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 225)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(359, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.Visible = False
        '
        'lblUserType
        '
        Me.lblUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.Image = CType(resources.GetObject("lblUserType.Image"), System.Drawing.Image)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(78, 17)
        Me.lblUserType.Text = "User Type"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel2.Text = ":"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(70, 17)
        Me.lblUser.Text = "User Name"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(185, 17)
        Me.ToolStripStatusLabel3.Spring = True
        Me.ToolStripStatusLabel3.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnClockOUT)
        Me.Panel1.Controls.Add(Me.btnBackOffice)
        Me.Panel1.Controls.Add(Me.btnFrontOffice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 719)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.Purple, System.Drawing.Color.Purple, System.Drawing.Color.Purple}
        CBlendItems3.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.btnClose.ColorFillBlend = CBlendItems3
        Me.btnClose.Corners.All = 10
        Me.btnClose.Corners.LowerLeft = 10
        Me.btnClose.Corners.LowerRight = 10
        Me.btnClose.Corners.UpperLeft = 10
        Me.btnClose.Corners.UpperRight = 10
        Me.btnClose.DesignerSelected = False
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageIndex = 0
        Me.btnClose.ImageSize = New System.Drawing.Size(256, 256)
        Me.btnClose.Location = New System.Drawing.Point(436, 365)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(415, 342)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.TextShadowShow = False
        Me.btnClose.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'btnClockOUT
        '
        Me.btnClockOUT.BackColor = System.Drawing.Color.Transparent
        Me.btnClockOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.Purple, System.Drawing.Color.Purple, System.Drawing.Color.Purple}
        CBlendItems4.iPoint = New Single() {0!, 0.5!, 1.0!}
        Me.btnClockOUT.ColorFillBlend = CBlendItems4
        Me.btnClockOUT.Corners.All = 10
        Me.btnClockOUT.Corners.LowerLeft = 10
        Me.btnClockOUT.Corners.LowerRight = 10
        Me.btnClockOUT.Corners.UpperLeft = 10
        Me.btnClockOUT.Corners.UpperRight = 10
        Me.btnClockOUT.DesignerSelected = False
        Me.btnClockOUT.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClockOUT.ImageIndex = 0
        Me.btnClockOUT.ImageSize = New System.Drawing.Size(256, 256)
        Me.btnClockOUT.Location = New System.Drawing.Point(12, 360)
        Me.btnClockOUT.Name = "btnClockOUT"
        Me.btnClockOUT.Size = New System.Drawing.Size(415, 342)
        Me.btnClockOUT.TabIndex = 3
        Me.btnClockOUT.Text = "Clock OUT"
        Me.btnClockOUT.TextShadowShow = False
        Me.btnClockOUT.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'frmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(863, 719)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operations"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUserType As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBackOffice As CButtonLib.CButton
    Friend WithEvents btnFrontOffice As CButtonLib.CButton
    Friend WithEvents btnClockOUT As CButtonLib.CButton
    Friend WithEvents btnClose As CButtonLib.CButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
