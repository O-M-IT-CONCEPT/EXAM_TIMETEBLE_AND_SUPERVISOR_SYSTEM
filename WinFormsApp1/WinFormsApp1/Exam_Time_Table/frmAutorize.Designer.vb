<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorize
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSet = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnX = New GelButtons.GelButton()
        Me.btnTA9 = New GelButtons.GelButton()
        Me.btnTA0 = New GelButtons.GelButton()
        Me.btnTA8 = New GelButtons.GelButton()
        Me.btnTA4 = New GelButtons.GelButton()
        Me.btnScanCard = New GelButtons.GelButton()
        Me.btnTA6 = New GelButtons.GelButton()
        Me.btnTA5 = New GelButtons.GelButton()
        Me.btnTA7 = New GelButtons.GelButton()
        Me.btnTA3 = New GelButtons.GelButton()
        Me.btnTA1 = New GelButtons.GelButton()
        Me.btnTA2 = New GelButtons.GelButton()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.cmbLoginType = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Feature Authorization"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblSet)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 46)
        Me.Panel2.TabIndex = 18
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Location = New System.Drawing.Point(395, 14)
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(0, 13)
        Me.lblSet.TabIndex = 2
        Me.lblSet.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(9, 115)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(453, 320)
        Me.TableLayoutPanel3.TabIndex = 386
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
        Me.btnX.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnX.Location = New System.Drawing.Point(3, 243)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(144, 74)
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
        Me.btnTA9.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA9.Location = New System.Drawing.Point(304, 163)
        Me.btnTA9.Name = "btnTA9"
        Me.btnTA9.Size = New System.Drawing.Size(146, 74)
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
        Me.btnTA0.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA0.Location = New System.Drawing.Point(153, 243)
        Me.btnTA0.Name = "btnTA0"
        Me.btnTA0.Size = New System.Drawing.Size(145, 74)
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
        Me.btnTA8.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA8.Location = New System.Drawing.Point(153, 163)
        Me.btnTA8.Name = "btnTA8"
        Me.btnTA8.Size = New System.Drawing.Size(145, 74)
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
        Me.btnTA4.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA4.Location = New System.Drawing.Point(3, 83)
        Me.btnTA4.Name = "btnTA4"
        Me.btnTA4.Size = New System.Drawing.Size(144, 74)
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
        Me.btnScanCard.Location = New System.Drawing.Point(304, 243)
        Me.btnScanCard.Name = "btnScanCard"
        Me.btnScanCard.Size = New System.Drawing.Size(146, 74)
        Me.btnScanCard.TabIndex = 11
        Me.btnScanCard.Text = "CLOSE"
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
        Me.btnTA6.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA6.Location = New System.Drawing.Point(304, 83)
        Me.btnTA6.Name = "btnTA6"
        Me.btnTA6.Size = New System.Drawing.Size(146, 74)
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
        Me.btnTA5.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA5.Location = New System.Drawing.Point(153, 83)
        Me.btnTA5.Name = "btnTA5"
        Me.btnTA5.Size = New System.Drawing.Size(145, 74)
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
        Me.btnTA7.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA7.Location = New System.Drawing.Point(3, 163)
        Me.btnTA7.Name = "btnTA7"
        Me.btnTA7.Size = New System.Drawing.Size(144, 74)
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
        Me.btnTA3.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA3.Location = New System.Drawing.Point(304, 3)
        Me.btnTA3.Name = "btnTA3"
        Me.btnTA3.Size = New System.Drawing.Size(146, 74)
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
        Me.btnTA1.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA1.Location = New System.Drawing.Point(3, 3)
        Me.btnTA1.Name = "btnTA1"
        Me.btnTA1.Size = New System.Drawing.Size(144, 74)
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
        Me.btnTA2.GradientTop = System.Drawing.SystemColors.HotTrack
        Me.btnTA2.Location = New System.Drawing.Point(153, 3)
        Me.btnTA2.Name = "btnTA2"
        Me.btnTA2.Size = New System.Drawing.Size(145, 74)
        Me.btnTA2.TabIndex = 1
        Me.btnTA2.Text = "2"
        Me.btnTA2.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.White
        Me.Password.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Password.Location = New System.Drawing.Point(75, 56)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(320, 50)
        Me.Password.TabIndex = 387
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbLoginType
        '
        Me.cmbLoginType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoginType.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoginType.FormattingEnabled = True
        Me.cmbLoginType.Items.AddRange(New Object() {"PIN", "CARD"})
        Me.cmbLoginType.Location = New System.Drawing.Point(3, 59)
        Me.cmbLoginType.Name = "cmbLoginType"
        Me.cmbLoginType.Size = New System.Drawing.Size(70, 45)
        Me.cmbLoginType.TabIndex = 393
        Me.cmbLoginType.Visible = False
        '
        'frmAutorize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.ClientSize = New System.Drawing.Size(478, 452)
        Me.Controls.Add(Me.cmbLoginType)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAutorize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorize Feature"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnX As GelButtons.GelButton
    Friend WithEvents btnTA9 As GelButtons.GelButton
    Friend WithEvents btnTA0 As GelButtons.GelButton
    Friend WithEvents btnTA8 As GelButtons.GelButton
    Friend WithEvents btnTA4 As GelButtons.GelButton
    Friend WithEvents btnScanCard As GelButtons.GelButton
    Friend WithEvents btnTA6 As GelButtons.GelButton
    Friend WithEvents btnTA5 As GelButtons.GelButton
    Friend WithEvents btnTA7 As GelButtons.GelButton
    Friend WithEvents btnTA3 As GelButtons.GelButton
    Friend WithEvents btnTA1 As GelButtons.GelButton
    Friend WithEvents btnTA2 As GelButtons.GelButton
    Friend WithEvents Password As TextBox
    Friend WithEvents cmbLoginType As ComboBox
    Friend WithEvents lblSet As Label
End Class
