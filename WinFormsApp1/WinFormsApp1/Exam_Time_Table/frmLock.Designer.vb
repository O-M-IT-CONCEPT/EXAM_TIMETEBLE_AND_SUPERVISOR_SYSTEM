<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLock
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
    Friend WithEvents btnLogin As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnX = New GelButtons.GelButton()
        Me.btnTA9 = New GelButtons.GelButton()
        Me.btnTA0 = New GelButtons.GelButton()
        Me.btnTA8 = New GelButtons.GelButton()
        Me.btnTA4 = New GelButtons.GelButton()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnTA6 = New GelButtons.GelButton()
        Me.btnTA5 = New GelButtons.GelButton()
        Me.btnTA7 = New GelButtons.GelButton()
        Me.btnTA3 = New GelButtons.GelButton()
        Me.btnTA1 = New GelButtons.GelButton()
        Me.btnTA2 = New GelButtons.GelButton()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Location = New System.Drawing.Point(2, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 352)
        Me.Panel1.TabIndex = 1
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
        Me.TableLayoutPanel3.Controls.Add(Me.btnLogin, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA6, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA5, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA3, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTA2, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(15, 54)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(341, 289)
        Me.TableLayoutPanel3.TabIndex = 385
        '
        'btnX
        '
        Me.btnX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnX.BackColor = System.Drawing.Color.White
        Me.btnX.BackgroundImage = CType(resources.GetObject("btnX.BackgroundImage"), System.Drawing.Image)
        Me.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnX.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.ForeColor = System.Drawing.Color.White
        Me.btnX.GradientBottom = System.Drawing.Color.Purple
        Me.btnX.GradientTop = System.Drawing.Color.Purple
        Me.btnX.Location = New System.Drawing.Point(3, 219)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(107, 67)
        Me.btnX.TabIndex = 31
        Me.btnX.Text = "-->"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnTA9
        '
        Me.btnTA9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA9.BackColor = System.Drawing.Color.White
        Me.btnTA9.BackgroundImage = CType(resources.GetObject("btnTA9.BackgroundImage"), System.Drawing.Image)
        Me.btnTA9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA9.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA9.ForeColor = System.Drawing.Color.White
        Me.btnTA9.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA9.GradientTop = System.Drawing.Color.Purple
        Me.btnTA9.Location = New System.Drawing.Point(229, 147)
        Me.btnTA9.Name = "btnTA9"
        Me.btnTA9.Size = New System.Drawing.Size(109, 66)
        Me.btnTA9.TabIndex = 15
        Me.btnTA9.Text = "9"
        Me.btnTA9.UseVisualStyleBackColor = False
        '
        'btnTA0
        '
        Me.btnTA0.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA0.BackColor = System.Drawing.Color.White
        Me.btnTA0.BackgroundImage = CType(resources.GetObject("btnTA0.BackgroundImage"), System.Drawing.Image)
        Me.btnTA0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA0.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA0.ForeColor = System.Drawing.Color.White
        Me.btnTA0.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA0.GradientTop = System.Drawing.Color.Purple
        Me.btnTA0.Location = New System.Drawing.Point(116, 219)
        Me.btnTA0.Name = "btnTA0"
        Me.btnTA0.Size = New System.Drawing.Size(107, 67)
        Me.btnTA0.TabIndex = 17
        Me.btnTA0.Text = "0"
        Me.btnTA0.UseVisualStyleBackColor = False
        '
        'btnTA8
        '
        Me.btnTA8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA8.BackColor = System.Drawing.Color.White
        Me.btnTA8.BackgroundImage = CType(resources.GetObject("btnTA8.BackgroundImage"), System.Drawing.Image)
        Me.btnTA8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA8.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA8.ForeColor = System.Drawing.Color.White
        Me.btnTA8.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA8.GradientTop = System.Drawing.Color.Purple
        Me.btnTA8.Location = New System.Drawing.Point(116, 147)
        Me.btnTA8.Name = "btnTA8"
        Me.btnTA8.Size = New System.Drawing.Size(107, 66)
        Me.btnTA8.TabIndex = 14
        Me.btnTA8.Text = "8"
        Me.btnTA8.UseVisualStyleBackColor = False
        '
        'btnTA4
        '
        Me.btnTA4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA4.BackColor = System.Drawing.Color.White
        Me.btnTA4.BackgroundImage = CType(resources.GetObject("btnTA4.BackgroundImage"), System.Drawing.Image)
        Me.btnTA4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA4.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA4.ForeColor = System.Drawing.Color.White
        Me.btnTA4.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA4.GradientTop = System.Drawing.Color.Purple
        Me.btnTA4.Location = New System.Drawing.Point(3, 75)
        Me.btnTA4.Name = "btnTA4"
        Me.btnTA4.Size = New System.Drawing.Size(107, 66)
        Me.btnTA4.TabIndex = 30
        Me.btnTA4.Text = "4"
        Me.btnTA4.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(229, 219)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(109, 67)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnTA6
        '
        Me.btnTA6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA6.BackColor = System.Drawing.Color.White
        Me.btnTA6.BackgroundImage = CType(resources.GetObject("btnTA6.BackgroundImage"), System.Drawing.Image)
        Me.btnTA6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA6.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA6.ForeColor = System.Drawing.Color.White
        Me.btnTA6.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA6.GradientTop = System.Drawing.Color.Purple
        Me.btnTA6.Location = New System.Drawing.Point(229, 75)
        Me.btnTA6.Name = "btnTA6"
        Me.btnTA6.Size = New System.Drawing.Size(109, 66)
        Me.btnTA6.TabIndex = 12
        Me.btnTA6.Text = "6"
        Me.btnTA6.UseVisualStyleBackColor = False
        '
        'btnTA5
        '
        Me.btnTA5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA5.BackColor = System.Drawing.Color.White
        Me.btnTA5.BackgroundImage = CType(resources.GetObject("btnTA5.BackgroundImage"), System.Drawing.Image)
        Me.btnTA5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA5.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA5.ForeColor = System.Drawing.Color.White
        Me.btnTA5.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA5.GradientTop = System.Drawing.Color.Purple
        Me.btnTA5.Location = New System.Drawing.Point(116, 75)
        Me.btnTA5.Name = "btnTA5"
        Me.btnTA5.Size = New System.Drawing.Size(107, 66)
        Me.btnTA5.TabIndex = 11
        Me.btnTA5.Text = "5"
        Me.btnTA5.UseVisualStyleBackColor = False
        '
        'btnTA7
        '
        Me.btnTA7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA7.BackColor = System.Drawing.Color.White
        Me.btnTA7.BackgroundImage = CType(resources.GetObject("btnTA7.BackgroundImage"), System.Drawing.Image)
        Me.btnTA7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA7.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA7.ForeColor = System.Drawing.Color.White
        Me.btnTA7.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA7.GradientTop = System.Drawing.Color.Purple
        Me.btnTA7.Location = New System.Drawing.Point(3, 147)
        Me.btnTA7.Name = "btnTA7"
        Me.btnTA7.Size = New System.Drawing.Size(107, 66)
        Me.btnTA7.TabIndex = 13
        Me.btnTA7.Text = "7"
        Me.btnTA7.UseVisualStyleBackColor = False
        '
        'btnTA3
        '
        Me.btnTA3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA3.BackColor = System.Drawing.Color.White
        Me.btnTA3.BackgroundImage = CType(resources.GetObject("btnTA3.BackgroundImage"), System.Drawing.Image)
        Me.btnTA3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA3.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA3.ForeColor = System.Drawing.Color.White
        Me.btnTA3.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA3.GradientTop = System.Drawing.Color.Purple
        Me.btnTA3.Location = New System.Drawing.Point(229, 3)
        Me.btnTA3.Name = "btnTA3"
        Me.btnTA3.Size = New System.Drawing.Size(109, 66)
        Me.btnTA3.TabIndex = 9
        Me.btnTA3.Text = "3"
        Me.btnTA3.UseVisualStyleBackColor = False
        '
        'btnTA1
        '
        Me.btnTA1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA1.BackColor = System.Drawing.Color.White
        Me.btnTA1.BackgroundImage = CType(resources.GetObject("btnTA1.BackgroundImage"), System.Drawing.Image)
        Me.btnTA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA1.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA1.ForeColor = System.Drawing.Color.White
        Me.btnTA1.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA1.GradientTop = System.Drawing.Color.Purple
        Me.btnTA1.Location = New System.Drawing.Point(3, 3)
        Me.btnTA1.Name = "btnTA1"
        Me.btnTA1.Size = New System.Drawing.Size(107, 66)
        Me.btnTA1.TabIndex = 7
        Me.btnTA1.Text = "1"
        Me.btnTA1.UseVisualStyleBackColor = False
        '
        'btnTA2
        '
        Me.btnTA2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTA2.BackColor = System.Drawing.Color.White
        Me.btnTA2.BackgroundImage = CType(resources.GetObject("btnTA2.BackgroundImage"), System.Drawing.Image)
        Me.btnTA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTA2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTA2.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTA2.ForeColor = System.Drawing.Color.White
        Me.btnTA2.GradientBottom = System.Drawing.Color.Purple
        Me.btnTA2.GradientTop = System.Drawing.Color.Purple
        Me.btnTA2.Location = New System.Drawing.Point(116, 3)
        Me.btnTA2.Name = "btnTA2"
        Me.btnTA2.Size = New System.Drawing.Size(107, 66)
        Me.btnTA2.TabIndex = 8
        Me.btnTA2.Text = "2"
        Me.btnTA2.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.Black
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(15, 4)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(341, 46)
        Me.Password.TabIndex = 1
        Me.Password.Text = "ENTER PIN"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(66, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 52)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ENTER PIN TO UNLOCK"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(30, 136)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(47, 20)
        Me.txtUserID.TabIndex = 2
        Me.txtUserID.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 51)
        Me.Panel2.TabIndex = 3
        '
        'frmLock
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(371, 409)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLock"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
