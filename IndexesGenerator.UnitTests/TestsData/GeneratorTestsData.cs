using IndexesGenerator.Algorithm;
using System.Collections;

namespace IndexesGenerator.UnitTests.TestsData
{
    public class GeneratorTestsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByColumns,
                    Type = AlgorithmType.Square,
                    Direction = AlgorithmDirection.Reverse
                },
                new List<Position>() { new(2, 3), new(1, 3), new(2, 2), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByRows,
                    Type = AlgorithmType.Square,
                    Direction = AlgorithmDirection.Reverse
                },
                new List<Position>() { new(2, 3), new(2, 2), new(1, 3), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByColumns,
                    Type = AlgorithmType.Snake,
                    Direction = AlgorithmDirection.Reverse
                },
                new List<Position>() { new(2, 3), new(1, 3), new(0, 3), new(3, 2), new(2, 2), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByRows,
                    Type = AlgorithmType.Snake,
                    Direction = AlgorithmDirection.Reverse
                },
                new List<Position>() { new(2, 3), new(2, 2), new(2, 1), new(2, 0), new(1, 4), new(1, 3), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(2, 3),
                    End = new Position(1, 2),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByColumns,
                    Type = AlgorithmType.Square,
                    Direction = AlgorithmDirection.Normal
                },
                new List<Position>() { new(2, 3), new(1, 3), new(2, 2), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(2, 3),
                    End = new Position(1, 2),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByRows,
                    Type = AlgorithmType.Square,
                    Direction = AlgorithmDirection.Normal
                },
                new List<Position>() { new(2, 3), new(2, 2), new(1, 3), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(2, 3),
                    End = new Position(1, 2),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByColumns,
                    Type = AlgorithmType.Snake,
                    Direction = AlgorithmDirection.Normal
                },
                new List<Position>() { new(2, 3), new(1, 3), new(0, 3), new(3, 2), new(2, 2), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(2, 3),
                    End = new Position(1, 2),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByRows,
                    Type = AlgorithmType.Snake,
                    Direction = AlgorithmDirection.Normal
                },
                new List<Position>() { new(2, 3), new(2, 2), new(2, 1), new(2, 0), new(1, 4), new(1, 3), new(1, 2), },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(1, 2),
                    End = new Position(1, 2),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByRows,
                    Type = AlgorithmType.Snake,
                    Direction = AlgorithmDirection.Normal
                },
                new List<Position>() { new(1, 2) },
            };

            yield return new object[]
            {
                new GeneratorConfig()
                {
                    Start = new Position(2, 3),
                    End = new Position(2, 3),
                    Height = 4,
                    Width = 5,
                    Through = AlgorithmThrough.ByColumns,
                    Type = AlgorithmType.Square,
                    Direction = AlgorithmDirection.Reverse
                },
                new List<Position>() { new(2, 3) },
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
