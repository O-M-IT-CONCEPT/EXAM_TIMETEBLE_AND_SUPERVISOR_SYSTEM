<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCamera))
        btnSave = New GelButtons.GelButton()
        picPreview = New PictureBox()
        saveFileDialog1 = New SaveFileDialog()
        btnCapture = New GelButtons.GelButton()
        cmbCamera = New ComboBox()
        lblCamera = New Label()
        picFeed = New PictureBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFeed, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.Enabled = False
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.GradientBottom = Color.Purple
        btnSave.GradientTop = Color.Purple
        '  btnSave.Image = My.Resources.Resources.hotel_2_2
        btnSave.Location = New Point(359, 301)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(148, 44)
        btnSave.TabIndex = 11
        btnSave.Text = "Copy"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' picPreview
        ' 
        picPreview.BackgroundImageLayout = ImageLayout.Stretch
        picPreview.BorderStyle = BorderStyle.FixedSingle
        picPreview.Location = New Point(359, 45)
        picPreview.Margin = New Padding(4, 3, 4, 3)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(322, 249)
        picPreview.TabIndex = 10
        picPreview.TabStop = False
        ' 
        ' btnCapture
        ' 
        btnCapture.FlatStyle = FlatStyle.Popup
        btnCapture.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCapture.ForeColor = Color.White
        btnCapture.GradientBottom = Color.Purple
        btnCapture.GradientTop = Color.Purple
        btnCapture.Location = New Point(14, 301)
        btnCapture.Margin = New Padding(4, 3, 4, 3)
        btnCapture.Name = "btnCapture"
        btnCapture.Size = New Size(150, 44)
        btnCapture.TabIndex = 9
        btnCapture.Text = "Capture"
        btnCapture.UseVisualStyleBackColor = True
        ' 
        ' cmbCamera
        ' 
        cmbCamera.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCamera.FormattingEnabled = True
        cmbCamera.Location = New Point(111, 14)
        cmbCamera.Margin = New Padding(4, 3, 4, 3)
        cmbCamera.Name = "cmbCamera"
        cmbCamera.Size = New Size(224, 23)
        cmbCamera.TabIndex = 8
        ' 
        ' lblCamera
        ' 
        lblCamera.AutoSize = True
        lblCamera.Location = New Point(14, 17)
        lblCamera.Margin = New Padding(4, 0, 4, 0)
        lblCamera.Name = "lblCamera"
        lblCamera.Size = New Size(88, 15)
        lblCamera.TabIndex = 7
        lblCamera.Text = "Select Camera :"
        ' 
        ' picFeed
        ' 
        picFeed.BackgroundImageLayout = ImageLayout.Stretch
        picFeed.BorderStyle = BorderStyle.FixedSingle
        picFeed.Location = New Point(14, 45)
        picFeed.Margin = New Padding(4, 3, 4, 3)
        picFeed.Name = "picFeed"
        picFeed.Size = New Size(322, 249)
        picFeed.TabIndex = 6
        picFeed.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(356, 17)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 12
        Label1.Text = "Picture Preview :"
        ' 
        ' frmCamera
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(695, 353)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(picPreview)
        Controls.Add(btnCapture)
        Controls.Add(cmbCamera)
        Controls.Add(lblCamera)
        Controls.Add(picFeed)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCamera"
        Text = "Webcam"
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        CType(picFeed, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Private WithEvents picPreview As System.Windows.Forms.PictureBox
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents cmbCamera As System.Windows.Forms.ComboBox
    Private WithEvents lblCamera As System.Windows.Forms.Label
    Private WithEvents picFeed As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnSave As GelButtons.GelButton
    Private WithEvents btnCapture As GelButtons.GelButton

End Class
