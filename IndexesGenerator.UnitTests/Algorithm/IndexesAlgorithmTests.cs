using IndexesGenerator.Algorithm;
using IndexesGenerator.UnitTests.Algorithm.TestsData;

namespace IndexesGenerator.UnitTests.Algorithm
{
    public class IndexesAlgorithmTests
    {
        [Theory]
        [ClassData(typeof(IndexesAlgorithmTestsData))]
        public void Generate_ShouldReturnCorrect_IEnumerable(IndexesAlgorithmConfig input, IndexesAlgorithm algorithm, List<Position> expected)
        {
            Assert.NotNull(algorithm);

            var actual = algorithm.Generate(input).ToList();

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(expected[i].X, actual[i].X);
                Assert.Equal(expected[i].Y, actual[i].Y);
            }
        }
    }
}
