using IndexesGenerator.Algorithm;
using IndexesGenerator.UnitTests.TestsData;

namespace IndexesGenerator.UnitTests
{
    public class GeneratorTests
    {
        [Theory]
        [ClassData(typeof(GeneratorTestsData))]
        public void Generate_ShouldReturnCorrect_IEnumerable(GeneratorConfig input, List<Position> expected)
        {
            var generator = new Generator();

            var actual = generator
                .Generate(input)
                .ToList();

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.Equal(expected[i].X, actual[i].X);
                Assert.Equal(expected[i].Y, actual[i].Y);
            }
        }

        [Fact]
        public void Generate_Throw_ArgumentNullException()
        {
            var generator = new Generator();

            Assert.Throws<ArgumentNullException>(() => generator.Generate(null));
        }
    }
}
