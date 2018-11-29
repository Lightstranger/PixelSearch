using System;
using System.Drawing;

namespace PixelSearch.Title {
    [System.Runtime.InteropServices.ComVisible(false)]
    public sealed class TitleScreen : MarshalByRefObject, IDisposable, System.Drawing.IDeviceContext {
        private void DrawBackground(PaintEventArgs e) {
            Image Background = new Image.FromFile("TitleBackground.png");
            PointF BackgroundCorner = new PointF(0.0F, 0.0F);
            e.Graphics.DrawImage(Background, BackgroundCorner);
        }
    }
}