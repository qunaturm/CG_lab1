namespace lab_1_right
{
    class MotionBlur : MatrixFilter
    {
        public MotionBlur()
        {
            int size = 9;
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        kernel[i, j] = 1.0f / size;
                    else
                        kernel[i, j] = 0;
                }
        }
    }
}
