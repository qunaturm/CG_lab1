using System.ComponentModel;
using System.Drawing;

namespace lab_1_right
{
    class Closing : Filters
    {
        protected float[,] mask;

        public Closing(float[,] Mask)
        {
            mask = Mask;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return sourceImage.GetPixel(x, y);
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Filters filter1 = new Dilation(mask);
            Bitmap result = filter1.processImage(sourceImage, worker);
            Filters filter2 = new Erosion(mask);
            result = filter2.processImage(result, worker);
            return result;
        }
    }
}
