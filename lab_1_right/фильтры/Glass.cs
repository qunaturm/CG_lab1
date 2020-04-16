using System;
using System.Drawing;

namespace lab_1_right
{
    class Glass : Filters
    {
        private Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int k, l;
            k = Clamp((int)(x + (rand.NextDouble() - 0.5) * 7), 0, sourceImage.Width - 1);
            l = Clamp((int)(y + (rand.NextDouble() - 0.5) * 7), 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(k, l);
            Color resultColor = Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);

            return resultColor;
        }
    }
}
