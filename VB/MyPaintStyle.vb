Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Styles
Imports DevExpress.XtraBars.ViewInfo
Imports System.Drawing
Imports DevExpress.XtraBars.Docking
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Docking.Paint
Imports DevExpress.Utils.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraBars.Docking.Helpers

Namespace WindowsFormsApplication1
    Public Class MyPaintStyle
        Inherits SkinBarManagerPaintStyle

        Public Sub New(ByVal collection As BarManagerPaintStyleCollection)
            MyBase.New(collection)
        End Sub
        Public Overrides ReadOnly Property Name() As String
            Get
                Return "MyPaintStyle"
            End Get
        End Property
        Protected Overrides Sub CreatePainters()
            MyBase.CreatePainters()
            Me.fElementsPainter = New MySkinElementPainter(Me)
        End Sub
    End Class

    Public Class MySkinElementPainter
        Inherits DockElementsSkinPainter

        Public Sub New(ByVal paintStyle As SkinBarManagerPaintStyle)
            MyBase.New(paintStyle)
        End Sub

        Protected Overrides Sub DrawActiveTab(ByVal tabArgs As DrawTabArgs)

            tabArgs.Appearance.BackColor = Color.Chocolate
            tabArgs.Appearance.BackColor2 = Color.Cornsilk
            tabArgs.Appearance.GradientMode = LinearGradientMode.Vertical
            tabArgs.DrawBackground()
            Dim rect As New DirectionRectangle(PaintHelper.CalcTabContentBounds(tabArgs, DockingSkins.SkinTabHeader), Not tabArgs.IsVertical)
            rect.CutFromHead(TabPanelPainter.TabHorzTextIndent)
            rect.CutFromTail(1)
            tabArgs.DrawString(tabArgs.TabLayout.TabText, rect.Bounds)
        End Sub
    End Class
End Namespace
