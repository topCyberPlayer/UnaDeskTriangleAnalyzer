using System;

namespace TriangleAnalyzer
{
    public class TriangleAnalyzer
    {
        public enum TriangleType
        {
            Acute,       // Остроугольный
            Right,       // Прямоугольный
            Obtuse       // Тупоугольный
        }

        public static TriangleType AnalyzeTriangle(double sideA, double sideB, double sideC)
        {
            // Проверка на существование треугольника
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Невозможно построить треугольник с заданными сторонами.");
            }

            // Сортировка сторон по возрастанию
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            // Проверка типа треугольника
            if (IsRightTriangle(sides))
            {
                return TriangleType.Right;
            }
            else if (IsAcuteTriangle(sides))
            {
                return TriangleType.Acute;
            }
            else
            {
                return TriangleType.Obtuse;
            }
        }

        private static bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b;
        }

        /// <summary>
        /// Прямоугольный
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        private static bool IsRightTriangle(double[] sides)
        {
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        /// <summary>
        /// Остроугольный
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        private static bool IsAcuteTriangle(double[] sides)
        {
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) > Math.Pow(sides[2], 2);
        }
    }
}

