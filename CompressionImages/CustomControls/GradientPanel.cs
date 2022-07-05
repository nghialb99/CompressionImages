using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressionImages.CustomControls
{
    public class GradientPanel : Panel
    {
        private Color topColor;
        private Color bottomColor;
        private float angle;

        [Category("Custom")]
        public Color TopColor { get => topColor; set { topColor = value; this.Invalidate(); } }

        [Category("Custom")]
        public Color BottomColor { get => bottomColor; set { bottomColor = value; this.Invalidate(); } }
        [Category("Custom")]
        public float Angle { get => angle; set { angle = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
