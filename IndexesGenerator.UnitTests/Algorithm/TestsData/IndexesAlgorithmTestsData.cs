using IndexesGenerator.Algorithm;
using System.Collections;

namespace IndexesGenerator.UnitTests.Algorithm.TestsData
{
    public class IndexesAlgorithmTestsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new IndexesAlgorithmConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByColumns,
                },
                SquareAlgorithm.GetNewInstance(),
                new List<Position>() { new(1, 2), new(2, 2), new(1, 3), new(2, 3) },
            };

            yield return new object[]
            {
                new IndexesAlgorithmConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByRows,
                },
                SquareAlgorithm.GetNewInstance(),
                new List<Position>() { new(1, 2), new(1, 3), new(2, 2), new(2, 3) },
            };

            yield return new object[]
            {
                new IndexesAlgorithmConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByColumns,
                },
                SnakeAlgorithm.GetNewInstance(),
                new List<Position>() { new(1, 2), new(2, 2), new(3, 2), new(0, 3), new(1, 3), new(2, 3) },
            };

            yield return new object[]
            {
                new IndexesAlgorithmConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByRows,
                },
                SnakeAlgorithm.GetNewInstance(),
                new List<Position>() { new(1, 2), new(1, 3), new(1, 4), new(2, 0), new(2, 1), new(2, 2), new(2, 3) },
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
