Public Class MyRenderer
    Inherits ToolStripProfessionalRenderer
    Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
        If TypeOf e.Item IsNot ToolStripSeparator Then
            MyBase.OnRenderSeparator(e)
            Return
        End If

        Dim bounds As Rectangle = New Rectangle(Point.Empty, e.Item.Size)
        Dim width As Integer = bounds.Width
        Dim height As Integer = bounds.Height
        'Dim foreColor As Color = Color.Blue
        Dim backColor As Color = Color.Purple
        Dim lineColor As Color = Color.White

        ' Fill the background.
        e.Graphics.FillRectangle(New SolidBrush(backColor), 0, 0, width, height)
        e.Graphics.DrawLine(New Pen(lineColor), 0, 0, width, 0)

    End Sub
End Class

Public Class ColorTable
    Inherits ProfessionalColorTable
    Dim Color1 = Color.Purple
    Dim Color2 = Color.SteelBlue
    Dim Color3 = Color.WhiteSmoke

    Public Overrides ReadOnly Property MenuBorder() As Color
        Get
            Return Color1
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder() As Color
        Get
            Return Color1
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin() As Color
        Get
            Return Color2
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd() As Color
        Get
            Return Color2
        End Get
    End Property
    Public Overrides ReadOnly Property SeparatorDark() As Color
        Get
            Return Color3
        End Get
    End Property
    Public Overrides ReadOnly Property ToolStripDropDownBackground() As Color
        Get
            Return Color1
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientBegin() As System.Drawing.Color
        Get
            Return Color1
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientEnd() As System.Drawing.Color
        Get
            Return Color1
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientMiddle() As System.Drawing.Color
        Get
            Return Color1
        End Get
    End Property
End Class
