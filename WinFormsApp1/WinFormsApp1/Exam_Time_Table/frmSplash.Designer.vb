<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        TextBox1 = New TextBox()
        txtActivationID = New TextBox()
        txtCPU_ID = New TextBox()
        Timer2 = New Timer(components)
        Panel1 = New Panel()
        Label3 = New Label()
        ProgressBar1 = New MetroFramework.Controls.MetroProgressSpinner()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        txtMB_SerialNo = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(74, 14)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(27, 22)
        TextBox1.TabIndex = 12
        TextBox1.Visible = False
        ' 
        ' txtActivationID
        ' 
        txtActivationID.CharacterCasing = CharacterCasing.Upper
        txtActivationID.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtActivationID.Location = New Point(0, 31)
        txtActivationID.Margin = New Padding(4, 3, 4, 3)
        txtActivationID.Name = "txtActivationID"
        txtActivationID.Size = New Size(27, 22)
        txtActivationID.TabIndex = 11
        txtActivationID.Visible = False
        ' 
        ' txtCPU_ID
        ' 
        txtCPU_ID.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCPU_ID.Location = New Point(35, 14)
        txtCPU_ID.Margin = New Padding(4, 3, 4, 3)
        txtCPU_ID.Name = "txtCPU_ID"
        txtCPU_ID.ReadOnly = True
        txtCPU_ID.Size = New Size(11, 22)
        txtCPU_ID.TabIndex = 10
        txtCPU_ID.Visible = False
        ' 
        ' Timer2
        ' 
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(35, 43)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(31, 30)
        Panel1.TabIndex = 14
        Panel1.Visible = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(8, 339)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 29)
        Label3.TabIndex = 5
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(55, 119)
        ProgressBar1.Margin = New Padding(4, 3, 4, 3)
        ProgressBar1.Maximum = 100
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(12, 25)
        ProgressBar1.TabIndex = 15
        ProgressBar1.UseSelectable = True
        ProgressBar1.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(525, 0)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(118, 120)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(115), CByte(13), CByte(125))
        Label2.Dock = DockStyle.Bottom
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 327)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(649, 23)
        Label2.TabIndex = 26
        Label2.Text = "TIME TABLE SUPERVISION  v14 Premium Edition"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(385, 251)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 76)
        Label1.TabIndex = 27
        Label1.Text = "DATA PROCESSING" & vbCrLf & "SYSTEM"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtMB_SerialNo
        ' 
        txtMB_SerialNo.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMB_SerialNo.Location = New Point(108, 61)
        txtMB_SerialNo.Margin = New Padding(4, 3, 4, 3)
        txtMB_SerialNo.Name = "txtMB_SerialNo"
        txtMB_SerialNo.ReadOnly = True
        txtMB_SerialNo.Size = New Size(11, 22)
        txtMB_SerialNo.TabIndex = 28
        txtMB_SerialNo.Visible = False
        ' 
        ' frmSplash
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(649, 350)
        Controls.Add(txtMB_SerialNo)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(ProgressBar1)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(TextBox1)
        Controls.Add(txtActivationID)
        Controls.Add(txtCPU_ID)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmSplash"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtActivationID As System.Windows.Forms.TextBox
    Friend WithEvents txtCPU_ID As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMB_SerialNo As System.Windows.Forms.TextBox
End Class
