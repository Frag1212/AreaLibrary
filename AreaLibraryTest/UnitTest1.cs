using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLibrary;
using System;

namespace AreaLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Тестируем треугольник

            float result = Area.CalculateArea(2.3f, 2.3f, -1.1f);    //Отрицательная сторона
            float truevalue = -1.0f;
            Assert.AreEqual<float>(result, truevalue);

            result = Area.CalculateArea(2.4f, 3.3f, 10.0f);          //Одна сторона больше суммы других
            truevalue = -1.0f;
            Assert.AreEqual<float>(result, truevalue);

            result = Area.CalculateArea(1.2f, 0.0f, 1.2f);           //Нулевая сторона
            truevalue = 0.0f;
            Assert.AreEqual<float>(result, truevalue);

            result = Area.CalculateArea(1.0f, 1.0f, 1.0f);
            truevalue = 0.433f;
            float eps = 0.0006f;
            Assert.IsTrue(Math.Abs(result - truevalue) < eps);

            result = Area.CalculateArea(3.0f, 4.0f, 5.0f);           //Прямоугольный треугольник
            truevalue = 6.0f;
            Assert.AreEqual<float>(result, truevalue);

            result = Area.CalculateArea(1.7f, 3.2f, 2.3f);
            truevalue = 1.886f;
            eps = 0.0006f;
            Assert.IsTrue(Math.Abs(result - truevalue) < eps);

            //Тестируем круг

            result = Area.CalculateArea(-2.3f);                        //Отрицательный радиус
            truevalue = -1.0f;
            Assert.AreEqual<float>(result, truevalue);

            result = Area.CalculateArea(0.0f);                         //Нулевой радиус
            truevalue = 0.0f;
            Assert.AreEqual<float>(result, truevalue);

            result = Area.CalculateArea(1.0f);
            truevalue = 3.142f;
            eps = 0.0006f;
            Assert.IsTrue(Math.Abs(result - truevalue) < eps);

            result = Area.CalculateArea(2.3f);
            truevalue = 16.619f;
            eps = 0.0006f;
            Assert.IsTrue(Math.Abs(result - truevalue) < eps);
        }
    }
}
