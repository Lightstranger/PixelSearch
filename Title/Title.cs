using System;
using System.Drawing;

namespace PixelSearch.Title {
    [System.Runtime.InteropServices.ComVisible(false)]
    public sealed class TitleScreen : MarshalByRefObject, IDisposable, System.Drawing.IDeviceContext {
        private void DrawBackground(PaintEventArgs e) {
            // Error: "(7,37): error CS0246: The type or namespace name 'PaintEventArgs 
            // could not be found (are you missing a using directive or an assembly reference?)"
            Image Background = new Image.FromFile("TitleBackground.png");
            PointF BackgroundCorner = new PointF(0.0F, 0.0F);
            e.Graphics.DrawImage(Background, BackgroundCorner);
        }
    }
}
