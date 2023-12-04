using static TriangleAnalyzer;

namespace TestTriangleAnalyzer
{
    public class UnitTest1
    {


        [Fact]
        public void Test1()
        {
            TriangleType triangleType = TriangleAnalyzer.AnalyzeTriangle(1,1,1);
        }
    }
}