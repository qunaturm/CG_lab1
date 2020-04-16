using System;
using System.Drawing;

namespace lab_1_right
{
    class Median : Filters
    {
        const int size = 3;
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int[] medianR = new int[size * size];
            int[] medianG = new int[size * size];
            int[] medianB = new int[size * size];

            int radius = size / 2;
            int i = 0;
            for (int l = -radius; l <= radius; ++l)
                for (int k = -radius; k <= radius; ++k)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);

                    medianR[i] = sourceImage.GetPixel(idX, idY).R;
                    medianG[i] = sourceImage.GetPixel(idX, idY).G;
                    medianB[i++] = sourceImage.GetPixel(idX, idY).B;
                }
            Array.Sort(medianR);
            Array.Sort(medianG);
            Array.Sort(medianB);

            return Color.FromArgb(
                Clamp(medianR[size * size / 2], 0, 255),
                Clamp(medianG[size * size / 2], 0, 255),
                Clamp(medianB[size * size / 2], 0, 255));
        }
    }
}
