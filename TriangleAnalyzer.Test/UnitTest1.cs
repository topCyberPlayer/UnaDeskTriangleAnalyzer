namespace TriangleAnalyzer.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0, 0)]  // ����������� ���������� ���������
        [InlineData(1, 2, 3)]  // ����������� ���������� ���������
        [InlineData(0, 1, 2)]  // ����������� ���������� ���������
        [InlineData(3, 4, -5)] // ����������� ���������� ���������
        public void AnalyzeTriangle_InvalidTriangle_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => TriangleAnalyzer.AnalyzeTriangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 5, TriangleAnalyzer.TriangleType.Right)]      // �������������
        [InlineData(5, 12, 13, TriangleAnalyzer.TriangleType.Right)]    // �������������
        [InlineData(8, 15, 17, TriangleAnalyzer.TriangleType.Right)]    // �������������
        [InlineData(5, 6, 7, TriangleAnalyzer.TriangleType.Acute)]      // �������������
        [InlineData(1, 2, 2.5, TriangleAnalyzer.TriangleType.Obtuse)]   // ������������
        [InlineData(8, 15, 20, TriangleAnalyzer.TriangleType.Obtuse)]   // ������������
        [InlineData(9, 10, 16, TriangleAnalyzer.TriangleType.Obtuse)]   // ������������
        
        public void AnalyzeTriangle_ValidTriangles_ReturnsExpectedType(double sideA, double sideB, double sideC, TriangleAnalyzer.TriangleType expectedType)
        {
            var result = TriangleAnalyzer.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.Equal(expectedType, result);
        }
    }
}