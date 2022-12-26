using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaLibrary
{
    public sealed class Triangle : Shape
    {
        /// <summary>
        /// Сторона треугольника A.
        /// </summary>
        public double SideA { get; private set; }

        /// <summary>
        /// Сторона треугольника B.
        /// </summary>
        public double SideB { get; private set; }

        /// <summary>
        /// Сторона треугольника C.
        /// </summary>
        public double SideC { get; private set; }

        
        private bool? isRightAngle;
        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// True - прямоугольный False - непрямоугольный.
        /// </summary>
        public bool? IsRightAngle 
        {
            get 
            {
                if (isRightAngle == null)
                    isRightAngle = RightAngleCheck();
                return isRightAngle;
            }
        }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="sideA">Сторона A</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        /// <exception cref="ArgumentOutOfRangeException">Длина стороны отрицательная, или равна нулю, или одна сторона болшьше суммы двух других.</exception>
        public Triangle(double sideA, double sideB, double sideC) 
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentOutOfRangeException("Длина стороны должна быть положительной и не равна нулю");
            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
                throw new ArgumentOutOfRangeException("Длина каждой стороны треугольника должна быть меньше суммы длин двух других сторон треугольника");
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        
        /// <summary>
        /// Метод, вычисляющий, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True - прямоугольный False - непрямоугольный.</returns>
        private bool RightAngleCheck()
        {
            List<double> sides = new List<double>() { SideA, SideB, SideC };
            double biggestSide = 0;

            sides.Remove(biggestSide = sides.Max());
            if (Math.Pow(biggestSide, 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))
                return true;
            else
                return false;
        }

        protected override double CalculateArea()
        {
            var halfP = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
        }
    }
}
