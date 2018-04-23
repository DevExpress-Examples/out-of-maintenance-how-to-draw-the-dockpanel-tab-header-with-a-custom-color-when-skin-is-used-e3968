using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraBars.ViewInfo;
using System.Drawing;
using DevExpress.XtraBars.Docking;
using DevExpress.Skins;
using DevExpress.XtraBars.Docking.Paint;
using DevExpress.Utils.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.XtraBars.Docking.Helpers;

namespace WindowsFormsApplication1
{
    public class MyPaintStyle : SkinBarManagerPaintStyle
    {
        public MyPaintStyle (BarManagerPaintStyleCollection collection) : base(collection) { }
        public override string Name { get { return "MyPaintStyle"; } }
        protected override void CreatePainters()
        {
            base.CreatePainters();
            this.fElementsPainter = new MySkinElementPainter(this);
        }        
    }

    public class MySkinElementPainter : DockElementsSkinPainter
    {
        public MySkinElementPainter(SkinBarManagerPaintStyle paintStyle) : base(paintStyle) { }

        protected override void DrawActiveTab(DrawTabArgs tabArgs)
        {

            tabArgs.Appearance.BackColor = Color.Chocolate;
            tabArgs.Appearance.BackColor2 = Color.Cornsilk;
            tabArgs.Appearance.GradientMode = LinearGradientMode.Vertical;
            tabArgs.DrawBackground();
            DirectionRectangle rect = new DirectionRectangle(PaintHelper.CalcTabContentBounds(tabArgs, DockingSkins.SkinTabHeader), !tabArgs.IsVertical);
            rect.CutFromHead(TabPanelPainter.TabHorzTextIndent);
            rect.CutFromTail(1);
            tabArgs.DrawString(tabArgs.TabLayout.TabText, rect.Bounds);
        }    
    }
}
