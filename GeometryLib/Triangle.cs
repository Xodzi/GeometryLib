using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Triangle: IShape
    {
        public double LineA { get; }
        public double LineB { get; }
        public double LineC { get; }

        public Triangle(double lineA, double lineB, double lineC)
        {
            LineA = lineA;
            LineB = lineB;
            LineC = lineC;
        }

        public double CalculateArea()
        {
            double s = (LineA + LineB + LineC) / 2;

            return Math.Sqrt(s * (s - LineA) * (s - LineB) * (s - LineC));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { LineA, LineB, LineC };

            Array.Sort(sides);//сортируем массив первые два элемента - это катеты, а третьий - гипотенуза

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2); //проверяем теорему Пифагора
        }
    }

}
