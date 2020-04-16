using System.Drawing;

namespace lab_1_right
{
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }

        public MatrixFilter(float[,] kernel)
        {
            kernel = kernel;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radX = kernel.GetLength(0) / 2;
            int radY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;

            for (int l = -radY; l <= radY; l++)
                for (int k = -radX; k <= radX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radX, l + radY];
                    resultG += neighborColor.G * kernel[k + radX, l + radY];
                    resultB += neighborColor.B * kernel[k + radX, l + radY];
                }
            return Color.FromArgb(
               Clamp((int)resultR, 0, 255),
               Clamp((int)resultG, 0, 255),
               Clamp((int)resultB, 0, 255)
               );
        }
    }
}
