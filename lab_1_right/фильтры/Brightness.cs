using System.Drawing;

namespace lab_1_right
{
    class Brightness : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            int K = 47;

            Color resultColor = Color.FromArgb(Clamp(sourceColor.R + K, 0, 255), Clamp(sourceColor.G + K, 0, 255), Clamp(sourceColor.B + K, 0, 255));
            return resultColor;
        }
    }
}
