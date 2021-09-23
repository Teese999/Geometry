using System;

namespace Geometric
{
    public class Geometry
    {
        /// <summary>
        /// Поиск площади
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <returns>Площадь</returns>
        public static double FindArea(double width, double height)
        {
            if (height <= 0 || width <= 0)
            {
                throw new ArgumentException("Значение должно быть больше нуля");

            }
            return width * height;
        }
        /// <summary>
        /// Поиск площади круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns>Радиус</returns>
        public static double FindCircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
        /// <summary>
        /// Площадь Треугольника
        /// </summary>
        /// <param name="sideOne">Сторона1</param>
        /// <param name="sideTwo">Сторона2</param>
        /// <param name="sideThree">Сторона3</param>
        /// <returns>Площадь Треугольника</returns>
        public static double FindTriangleArea(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                throw new ArgumentException("Сторона должна быть большу нуля");
            }
            double p = (sideOne + sideTwo + sideThree) / 2;
            if (p < sideOne || p < sideTwo || p < sideThree)
            {
                throw new ArgumentException("Р должна быть больше каждой из сторон");
            }
            return Math.Pow((p * (p - sideOne) * (p - sideTwo) * (p - sideThree)), 0.5);
        }
        /// <summary>
        /// Площадь Треугольника
        /// </summary>
        /// <param name="b">Основание</param>
        /// <param name="height">Высота</param>
        /// <returns>Площадь Треугольника</returns>
        public static double FindTriangleArea(double b, double height)
        {
            if (b <= 0 || height <= 0)
            {
                throw new ArgumentException("Основание и высота должны быть больше или равны 0");
            }

            return 0.5 * b * height;
        }
        /// <summary>
        /// Проверка на равносторонний треугольник
        /// </summary>
        /// <param name="sideOne"></param>
        /// <param name="sideTwo"></param>
        /// <param name="sideThree"></param>
        /// <returns>True - если равносторонний</returns>
        public static bool IsEquilateralTriangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше 0");
            }
            double maxSide = Math.Max(Math.Max(sideOne, sideTwo), sideThree);
            return (maxSide * maxSide) == (maxSide == sideOne ? sideTwo * sideTwo + sideThree * sideThree :
                                            maxSide == sideTwo ? sideOne * sideOne + sideThree * sideThree :
                                            sideOne * sideOne + sideTwo * sideTwo);
        }
    }
}
