<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_lev))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        txtBatchName = New TextBox()
        Label1 = New Label()
        txtCode = New TextBox()
        Label8 = New Label()
        Panel3 = New Panel()
        btnDelete = New GelButtons.GelButton()
        btnUpdate = New GelButtons.GelButton()
        btnSave = New GelButtons.GelButton()
        dgw = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        GroupBox2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgw, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(txtBatchName)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtCode)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.SteelBlue
        GroupBox2.Location = New Point(14, 12)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(617, 110)
        GroupBox2.TabIndex = 395
        GroupBox2.TabStop = False
        GroupBox2.Text = "Add Level"
        ' 
        ' txtBatchName
        ' 
        txtBatchName.BackColor = Color.White
        txtBatchName.Font = New Font("Microsoft Sans Serif", 10F)
        txtBatchName.Location = New Point(132, 67)
        txtBatchName.Margin = New Padding(4, 3, 4, 3)
        txtBatchName.Name = "txtBatchName"
        txtBatchName.Size = New Size(467, 23)
        txtBatchName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(7, 69)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 17)
        Label1.TabIndex = 18
        Label1.Text = "Name :"
        ' 
        ' txtCode
        ' 
        txtCode.BackColor = Color.White
        txtCode.Font = New Font("Microsoft Sans Serif", 10F)
        txtCode.Location = New Point(132, 31)
        txtCode.Margin = New Padding(4, 3, 4, 3)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(467, 23)
        txtCode.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.SteelBlue
        Label8.Location = New Point(12, 31)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 17)
        Label8.TabIndex = 16
        Label8.Text = "Code :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnSave)
        Panel3.Location = New Point(14, 254)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(610, 65)
        Panel3.TabIndex = 396
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.SteelBlue
        btnDelete.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.GradientBottom = Color.Purple
        btnDelete.GradientTop = Color.DarkMagenta
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(231, 16)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(104, 38)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.TextAlign = ContentAlignment.MiddleRight
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SteelBlue
        btnUpdate.Enabled = False
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.GradientBottom = Color.Purple
        btnUpdate.GradientTop = Color.DarkMagenta
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(120, 15)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(104, 38)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.TextAlign = ContentAlignment.MiddleRight
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SteelBlue
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.GradientBottom = Color.Purple
        btnSave.GradientTop = Color.DarkMagenta
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(12, 15)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 38)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dgw
        ' 
        dgw.AllowUserToAddRows = False
        dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgw.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgw.BackgroundColor = Color.White
        dgw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Purple
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgw.ColumnHeadersHeight = 37
        dgw.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgw.Cursor = Cursors.Hand
        dgw.EnableHeadersVisualStyles = False
        dgw.GridColor = Color.White
        dgw.Location = New Point(14, 128)
        dgw.Margin = New Padding(4, 3, 4, 3)
        dgw.MultiSelect = False
        dgw.Name = "dgw"
        dgw.ReadOnly = True
        dgw.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgw.RowHeadersWidth = 25
        dgw.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        dgw.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgw.RowTemplate.Height = 44
        dgw.RowTemplate.Resizable = DataGridViewTriState.False
        dgw.ScrollBars = ScrollBars.Vertical
        dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgw.Size = New Size(610, 127)
        dgw.TabIndex = 407
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "SN/NO"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "id"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Visible = False
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Code"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Level"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' frm_lev
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(637, 336)
        Controls.Add(dgw)
        Controls.Add(Panel3)
        Controls.Add(GroupBox2)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "frm_lev"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(dgw, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBatchName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDelete As GelButtons.GelButton
    Friend WithEvents btnUpdate As GelButtons.GelButton
    Friend WithEvents btnSave As GelButtons.GelButton
    Friend WithEvents dgw As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
