using System.Collections.Generic;
using System.Drawing;

namespace CGLab1
{
    internal class RGBViewProvider
    {
        private int BitmapWidth => redMarix.GetLength(0);
        private int BitmapHeight => redMarix.GetLength(1); // mb create smth more original

        private bool isBinary = false;
        private List<byte[,]> colorMarix = new List<byte[,]>();//матрица разложенных цветов
        private byte[,] redMarix;
        private byte[,] greenMarix;
        private byte[,] blueMarix;

        RGBViewProvider(Bitmap bmp)
        {
            // bmp for rgb
        }
        private bool CheckIfBlackWhite(Bitmap bmp)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (bmp.GetPixel(x, y) != Color.FromArgb(0, 0, 0) && bmp.GetPixel(x, y) != Color.FromArgb(255, 255, 255))
                    {
                        return false;
                    }

                }
            }
            return true;
        }


    }
}
