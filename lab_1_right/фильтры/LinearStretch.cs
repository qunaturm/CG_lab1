using System.Drawing;

namespace lab_1_right
{
    class LinearStretch : Filters
    {
        float minBrightness;
        float maxBrightness = -1;

        void calculateBrightness(Bitmap sourceImage)
        {
            float min = sourceImage.GetPixel(0, 0).GetBrightness(),
                max = sourceImage.GetPixel(0, 0).GetBrightness();
            for (int i = 0; i < sourceImage.Width; i++)
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color sourceColor = sourceImage.GetPixel(i, j);
                    if (sourceColor.GetBrightness() > max)
                        max = sourceColor.GetBrightness();
                    if (sourceColor.GetBrightness() < min)
                        min = sourceColor.GetBrightness();
                }
            minBrightness = min;
            maxBrightness = max;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (maxBrightness == -1)
                calculateBrightness(sourceImage);
            Color sourceColor = sourceImage.GetPixel(x, y);

            int brightnessChange =
                (int)((sourceColor.GetBrightness() - minBrightness) *
                (255 / (maxBrightness - minBrightness)));

            Color resultColor = Color.FromArgb(
                Clamp(sourceColor.R + brightnessChange, 0, 255),
                Clamp(sourceColor.G + brightnessChange, 0, 255),
                Clamp(sourceColor.B + brightnessChange, 0, 255));
            return resultColor;
        }
    }
}
