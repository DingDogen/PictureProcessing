using System;
namespace CGLab1.MathExtensions
{
    public static class MathExtension
    {
        public static int Clamp(this double val, int min, int max)
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return Convert.ToInt32(val);
        }
    }
}
