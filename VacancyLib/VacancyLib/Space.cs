using System;

namespace VacancyLib
{
    public class Space
    {
        public static double FindSpace(params double[] doubles)
        {
            switch (doubles.Length)
            {
                case 1:
                    return CirqleSpace(doubles[0]);
                case 3:
                    return TriangleSpace(doubles[0], doubles[1], doubles[2]);
                default:
                    throw new ArgumentException("Неподходящее количество параметров");
            }
        }
        public static double CirqleSpace(double r)
        {
            if (r < 0)
            {
                throw new ArgumentOutOfRangeException("Значение параметра не может быть меньше нуля");
            }
            else
            {
                return Math.PI * r * r;
            }
        }
        public static double TriangleSpace(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
            {
                throw new ArgumentOutOfRangeException("Значение параметра не может быть меньше нуля");
            }
            else if ((a >= (b + c)) || (b >= (a + c)) || (c >= (b + a)))
            {
                throw new ArgumentOutOfRangeException("Длина любой стороны треугольника всегда меньше суммы длин двух его других сторон");
            }
            else
            {
                double[] temp = new double[] { a, b, c };
                Array.Sort(temp);
                a = temp[0];
                b = temp[1];
                c = temp[2];
                double res;
                if (IsRectangular(a, b, c))
                {
                    res = a * b / 2;
                }
                else
                {
                    double p = (a + b + c) / 2;
                    res = p * (p - a) * (p - b) * (p - c);
                    res = Math.Sqrt(res);
                }
                return res;
            }
        }
        public static bool IsRectangular(double a, double b, double c)
        {
            return (a * a + b * b) == (c * c);
        }
    }
}