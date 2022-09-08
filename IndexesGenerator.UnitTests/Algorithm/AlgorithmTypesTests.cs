using IndexesGenerator.Algorithm;

namespace IndexesGenerator.UnitTests.Algorithm
{
    public class AlgorithmTypesTests
    {
        [Theory]
        [InlineData(AlgorithmType.Snake, typeof(SnakeAlgorithm))]
        [InlineData(AlgorithmType.Square, typeof(SquareAlgorithm))]
        public void GetAlgorithm_ShouldReturnCorrect_IndexesAlgorithm(AlgorithmType algorithmType, Type algorithm)
        {
            var algorithmTypes = new AlgorithmTypes();

            var output = algorithmTypes.GetAlgorithm(algorithmType);

            Assert.NotNull(output);
            Assert.Equal(output.GetType(), algorithm);
        }

        [Fact]
        public void GetAlgorithm_ShouldTrow_ArgumentException()
        {
            var algorithmTypes = new AlgorithmTypes();

            Assert.Throws<ArgumentException>(() => algorithmTypes.GetAlgorithm(AlgorithmType.None));
        }
    }
}
