using System;
using System.Drawing;

namespace lab_1_right
{
    class Wave : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k, l;
            k = Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * y / 60)), 0, sourceImage.Width - 1);
            l = Clamp(y, 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(k, l);
            Color resultColor = Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);

            return resultColor;
        }
    }
}
