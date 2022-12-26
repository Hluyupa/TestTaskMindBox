using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaLibrary
{
    /// <summary>
    /// Базовый класс для всех фигур.
    /// От него должны наследоваться все классы фигур.
    /// </summary>
    public abstract class Shape
    {
        protected double area;
        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        public double Area
        { 
            get 
            {
                if (area == 0)
                    area = CalculateArea();
                return area;
            }
        }

        /// <summary>
        /// Метод для вычисления площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        protected abstract double CalculateArea();
    }
}
