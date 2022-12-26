using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAreaLibrary;
using System;

namespace ShapesAreaLibraryTests
{
    [TestClass]
    public class CircleUnitTest
    {
        /// <summary>
        /// Проверка на ввод отрицательных значений.
        /// </summary>
        [TestMethod]
        public void TestExceptionMinusRadius()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        /// <summary>
        /// Проверка на ввод нуля.
        /// </summary>
        [TestMethod]
        public void TestExceptionZeroRadius()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        /// <summary>
        /// Тестирование на правильность вычисления площади.
        /// </summary>
        [TestMethod]
        public void TestCorrectResult()
        {
            var circle = new Circle(5);
            Assert.AreEqual(Math.Round(circle.Area, 5) , 78.53982);
        }
    }
}
