namespace TriangleAnalyzer.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0, 0)]  // Треугольник невозможно построить
        [InlineData(1, 2, 3)]  // Треугольник невозможно построить
        [InlineData(0, 1, 2)]  // Треугольник невозможно построить
        [InlineData(3, 4, -5)] // Треугольник невозможно построить
        public void AnalyzeTriangle_InvalidTriangle_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => TriangleAnalyzer.AnalyzeTriangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 5, TriangleAnalyzer.TriangleType.Right)]      // Прямоугольный
        [InlineData(5, 12, 13, TriangleAnalyzer.TriangleType.Right)]    // Прямоугольный
        [InlineData(8, 15, 17, TriangleAnalyzer.TriangleType.Right)]    // Прямоугольный
        [InlineData(5, 6, 7, TriangleAnalyzer.TriangleType.Acute)]      // Остроугольный
        [InlineData(1, 2, 2.5, TriangleAnalyzer.TriangleType.Obtuse)]   // Тупоугольный
        [InlineData(8, 15, 20, TriangleAnalyzer.TriangleType.Obtuse)]   // Тупоугольный
        [InlineData(9, 10, 16, TriangleAnalyzer.TriangleType.Obtuse)]   // Тупоугольный
        
        public void AnalyzeTriangle_ValidTriangles_ReturnsExpectedType(double sideA, double sideB, double sideC, TriangleAnalyzer.TriangleType expectedType)
        {
            var result = TriangleAnalyzer.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.Equal(expectedType, result);
        }
    }
}