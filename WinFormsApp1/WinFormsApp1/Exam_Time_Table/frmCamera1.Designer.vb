﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamera1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCamera1))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.cmbCamera = New System.Windows.Forms.ComboBox()
        Me.lblCamera = New System.Windows.Forms.Label()
        Me.picFeed = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(386, 310)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 38)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Copy"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'picPreview
        '
        Me.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPreview.Location = New System.Drawing.Point(315, 60)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(224, 244)
        Me.picPreview.TabIndex = 10
        Me.picPreview.TabStop = False
        '
        'btnCapture
        '
        Me.btnCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Image = CType(resources.GetObject("btnCapture.Image"), System.Drawing.Image)
        Me.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapture.Location = New System.Drawing.Point(77, 310)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(96, 38)
        Me.btnCapture.TabIndex = 9
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'cmbCamera
        '
        Me.cmbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCamera.FormattingEnabled = True
        Me.cmbCamera.Location = New System.Drawing.Point(13, 33)
        Me.cmbCamera.Name = "cmbCamera"
        Me.cmbCamera.Size = New System.Drawing.Size(224, 21)
        Me.cmbCamera.TabIndex = 8
        '
        'lblCamera
        '
        Me.lblCamera.AutoSize = True
        Me.lblCamera.Location = New System.Drawing.Point(12, 17)
        Me.lblCamera.Name = "lblCamera"
        Me.lblCamera.Size = New System.Drawing.Size(82, 13)
        Me.lblCamera.TabIndex = 7
        Me.lblCamera.Text = "Select Camera :"
        '
        'picFeed
        '
        Me.picFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFeed.Location = New System.Drawing.Point(13, 60)
        Me.picFeed.Name = "picFeed"
        Me.picFeed.Size = New System.Drawing.Size(224, 244)
        Me.picFeed.TabIndex = 6
        Me.picFeed.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Picture Preview :"
        '
        'frmCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 355)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.picPreview)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.cmbCamera)
        Me.Controls.Add(Me.lblCamera)
        Me.Controls.Add(Me.picFeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCamera"
        Me.Text = "Webcam"
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents picPreview As System.Windows.Forms.PictureBox
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents btnCapture As System.Windows.Forms.Button
    Private WithEvents cmbCamera As System.Windows.Forms.ComboBox
    Private WithEvents lblCamera As System.Windows.Forms.Label
    Private WithEvents picFeed As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents Label1 As System.Windows.Forms.Label

End Class
