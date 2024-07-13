<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmManualGeneration
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgwManual = New DataGridView()
        btnSave = New Button()
        CType(dgwManual, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgwManual
        ' 
        dgwManual.AllowUserToAddRows = False
        dgwManual.AllowUserToDeleteRows = False
        dgwManual.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        dgwManual.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgwManual.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgwManual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwManual.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgwManual.BackgroundColor = Color.White
        dgwManual.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Purple
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgwManual.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgwManual.ColumnHeadersHeight = 37
        dgwManual.Cursor = Cursors.Hand
        dgwManual.EnableHeadersVisualStyles = False
        dgwManual.GridColor = Color.White
        dgwManual.Location = New Point(14, 14)
        dgwManual.Margin = New Padding(4, 3, 4, 3)
        dgwManual.MultiSelect = False
        dgwManual.Name = "dgwManual"
        dgwManual.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgwManual.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgwManual.RowHeadersWidth = 25
        dgwManual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        dgwManual.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgwManual.RowTemplate.Height = 44
        dgwManual.RowTemplate.Resizable = DataGridViewTriState.False
        dgwManual.ScrollBars = ScrollBars.Vertical
        dgwManual.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwManual.Size = New Size(1174, 647)
        dgwManual.TabIndex = 408
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(14, 669)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(117, 35)
        btnSave.TabIndex = 409
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' FrmManualGeneration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1202, 718)
        Controls.Add(btnSave)
        Controls.Add(dgwManual)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmManualGeneration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmManualGeneration"
        CType(dgwManual, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents dgwManual As DataGridView
    Friend WithEvents btnSave As Button
End Class
