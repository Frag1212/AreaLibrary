using System;

namespace AreaLibrary
{
    public static class Area
    {
        public static float CalculateArea(float a, float b, float c) //Площадь треугольника
        {
            if(a < b)                                   //Делаем a наибольшей стороной для дальнейших проверок
            {
                float t = a;
                a = b;
                b = t;
            }
            if (a < c)
            {
                float t = a;
                a = c;
                c = t;
            }

            if (a > b + c)                              //Ни одна сторона не должна быть больше чем сумма двух других. Если одна из сторон отрицательная это условие тоже срабатывает.
                return -1.0f;

            if(a * a == b * b + c * c)                  //Прямоугольный треугольник
            {
                return (b * c) / 2;
            }

            float S = 0.5f * (a + b + c);
            float A = S * (S - a) * (S - b) * (S - c);

            return (float)Math.Sqrt(A);
        }
        public static float CalculateArea(float r)      //Площадь круга
        {
            if (r < 0)
                return -1.0f;

            return (float)Math.PI * r * r;
        }

        //Для добавления новой фигуры достаточно сделать новую перегрузку функции CalculateArea
    }
}
