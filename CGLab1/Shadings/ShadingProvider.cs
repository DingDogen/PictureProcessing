using System;
using System.Drawing;
using System.Threading.Tasks;

namespace CGLab1
{
    //replace to bmp extensions???
    public class ShadingProvider
    {
        private bool[,] bmp;
        private int BitmapWidth => this.bmp.GetLength(1);
        private int BitmapHeight => this.bmp.GetLength(0);
        public ShadingProvider(Bitmap bmp)
        {
            this.bmp = new bool[bmp.Height, bmp.Width];

            for (int i = 0; i < this.bmp.GetLength(0); i++) // rows
            {
                for (int j = 0; j < this.bmp.GetLength(1); j++) // columns
                {
                    if (bmp.GetPixel(j, i).R == 0)
                    {
                        this.bmp[i, j] = false;
                    }
                    else
                    {
                        this.bmp[i, j] = true;
                    }
                }
            }
        }

        //refactor and delete hardcoding of numbers
        public double[,] EuclidShading()
        {
            double[,] res = new double[BitmapHeight, BitmapWidth];

            for (int i = 0; i < BitmapHeight; i++)
            {
                for (int j = 0; j < BitmapWidth; j++)
                {
                    if (this.bmp[i, j] == true) // если черное
                    {
                        res[i, j] = FindClosestToOpposite(j, i, false);

                    }
                    else if (this.bmp[i, j] == false)// если белое
                    {
                        res[i, j] = -FindClosestToOpposite(j, i, true);
                    }
                }
            }
            return res;
        }

        public double[,] ChessShading()
        {
            throw new NotImplementedException();
        }

        public double[,] CityShading()
        {
            throw new NotImplementedException();
        }

        public double[,] WaveShading()
        {
            throw new NotImplementedException();
        }

        private double FindClosestToOpposite(int x, int y, bool type)
        {
            double closest = BitmapWidth > BitmapWidth ? BitmapWidth : BitmapHeight;

            for (int i = 0; i < BitmapHeight; i++) //y
            {
                for (int j = 0; j < BitmapWidth; j++) //x
                {
                    if ((this.bmp[y, x]) != this.bmp[i, j]) //если текущая клетка противоположная искомой
                    {
                        double tempLength = GetLength(new Point(x, y), new Point(j, i));
                        if (tempLength < closest)
                        {
                            closest = tempLength;
                        }
                    }
                }
            }
            return closest;

            double GetLength(Point p1, Point p2)
            {
                return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            }
        }
    }
}
