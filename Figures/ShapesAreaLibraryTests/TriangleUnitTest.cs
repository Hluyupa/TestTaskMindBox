using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAreaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaLibraryTests
{
    [TestClass]
    public class TriangleUnitTest
    {
        /// <summary>
        /// Тестирование на вывод ошибки при вводе отрицательных чисел.
        /// </summary>
        [TestMethod]
        public void TestExceptionMinusSide()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 3));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, 2, -3));
        }

        /// <summary>
        /// Проверка на ввод нуля.
        /// </summary>
        [TestMethod]
        public void TestExceptionZeroSide()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 2, 3));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 3));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 0));
        }

        /// <summary>
        /// Проверка на вывод ошибки при создании треугольника, который не может существовать.
        /// </summary>
        [TestMethod]
        public void TestNonExistentTriangle()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(6, 3, 3));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(4, 9, 2));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 10));
        }

        /// <summary>
        /// Тестирование на правильность подсчёта площади.
        /// </summary>
        [TestMethod]
        public void TestCorrectResult()
        {
            Shape triangle = new Triangle(5, 4, 3);
            Assert.AreEqual(Math.Round(triangle.Area, 5), 6);
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным.
        /// </summary>
        [TestMethod]
        public void TestRightAngleCheck()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.AreEqual(triangle.IsRightAngle, true);

            triangle = new Triangle(5, 3, 3);
            Assert.AreEqual(triangle.IsRightAngle, false);
        }
    }
}
