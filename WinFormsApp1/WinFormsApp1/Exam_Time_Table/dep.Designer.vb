<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dep))
        GroupBox1 = New GroupBox()
        GelButton3 = New GelButtons.GelButton()
        GelButton2 = New GelButtons.GelButton()
        GelButton1 = New GelButtons.GelButton()
        ListBox1 = New ListBox()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GelButton3)
        GroupBox1.Controls.Add(GelButton2)
        GroupBox1.Controls.Add(GelButton1)
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(14, 14)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(304, 370)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' GelButton3
        ' 
        GelButton3.BackColor = Color.SteelBlue
        GelButton3.Cursor = Cursors.Hand
        GelButton3.FlatStyle = FlatStyle.Popup
        GelButton3.Font = New Font("Segoe UI Semibold", 19F, FontStyle.Bold)
        GelButton3.ForeColor = Color.White
        GelButton3.GradientBottom = Color.Purple
        GelButton3.GradientTop = Color.DarkMagenta
        GelButton3.Image = My.Resources.Resources.vat_calculator
        GelButton3.ImageAlign = ContentAlignment.MiddleLeft
        GelButton3.Location = New Point(259, 36)
        GelButton3.Margin = New Padding(4, 3, 4, 3)
        GelButton3.Name = "GelButton3"
        GelButton3.Size = New Size(40, 39)
        GelButton3.TabIndex = 434
        GelButton3.Text = "+"
        GelButton3.UseVisualStyleBackColor = False
        ' 
        ' GelButton2
        ' 
        GelButton2.BackColor = Color.SteelBlue
        GelButton2.Cursor = Cursors.Hand
        GelButton2.FlatStyle = FlatStyle.Popup
        GelButton2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GelButton2.ForeColor = Color.White
        GelButton2.GradientBottom = Color.Purple
        GelButton2.GradientTop = Color.DarkMagenta
        GelButton2.ImageAlign = ContentAlignment.MiddleLeft
        GelButton2.Location = New Point(98, 310)
        GelButton2.Margin = New Padding(4, 3, 4, 3)
        GelButton2.Name = "GelButton2"
        GelButton2.Size = New Size(90, 42)
        GelButton2.TabIndex = 433
        GelButton2.Text = "Exit"
        GelButton2.TextAlign = ContentAlignment.MiddleRight
        GelButton2.UseVisualStyleBackColor = False
        ' 
        ' GelButton1
        ' 
        GelButton1.BackColor = Color.SteelBlue
        GelButton1.Cursor = Cursors.Hand
        GelButton1.FlatStyle = FlatStyle.Popup
        GelButton1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GelButton1.ForeColor = Color.White
        GelButton1.GradientBottom = Color.Purple
        GelButton1.GradientTop = Color.DarkMagenta
        GelButton1.Image = CType(resources.GetObject("GelButton1.Image"), Image)
        GelButton1.ImageAlign = ContentAlignment.MiddleLeft
        GelButton1.Location = New Point(195, 310)
        GelButton1.Margin = New Padding(4, 3, 4, 3)
        GelButton1.Name = "GelButton1"
        GelButton1.Size = New Size(90, 42)
        GelButton1.TabIndex = 432
        GelButton1.Text = "Save"
        GelButton1.TextAlign = ContentAlignment.MiddleRight
        GelButton1.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = SystemColors.ButtonFace
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(76, 134)
        ListBox1.Margin = New Padding(4, 3, 4, 3)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(208, 139)
        ListBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(7, 141)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 19)
        Label2.TabIndex = 431
        Label2.Text = "All dept"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(7, 99)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 19)
        Label1.TabIndex = 427
        Label1.Text = "Dept"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(76, 98)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 26)
        TextBox1.TabIndex = 426
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.White
        ComboBox2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(76, 40)
        ComboBox2.Margin = New Padding(4, 3, 4, 3)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(176, 27)
        ComboBox2.TabIndex = 424
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(7, 40)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 19)
        Label5.TabIndex = 425
        Label5.Text = "Faculty"
        ' 
        ' dep
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(337, 408)
        Controls.Add(GroupBox1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "dep"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GelButton2 As GelButtons.GelButton
    Friend WithEvents GelButton1 As GelButtons.GelButton
    Friend WithEvents GelButton3 As GelButtons.GelButton
End Class
