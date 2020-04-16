namespace lab_1_right
{
    class Sharp : MatrixFilter
    {
        public Sharp()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

            for (int i = 0; i < sizeX; ++i)
                for (int j = 0; j < sizeY; ++j)
                { 
                        kernel[i, j] = -1;
                }

            kernel[1, 1] = 9;
        }
        
    }
}
