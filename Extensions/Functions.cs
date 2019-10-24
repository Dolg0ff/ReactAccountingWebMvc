using System;

namespace Extensions
{
    public class Functions
    {
        public static double limits(double inx, double xmin, double xmax, double nmin, double nmax)
        {
            double  scalek = (nmax - nmin) / (xmax - xmin);// - находим коэффициент размерности (во сколько раз один промежуток больше чем другой)
            double shiftk = (nmin - xmin);//смещение относительно старых пределов
            double output = (inx - xmin) * scalek + shiftk;//отнимаем смещение чтобы упростить вычисления
            return output + xmin;//возвращаем смещение на место
        }
    }
}
