using System.Collections.Generic;

namespace IndexesGenerator.Algorithm
{
    internal class SnakeAlgorithm : IndexesAlgorithm
    {
        public SnakeAlgorithm() : base()
        {
            Algorithms.Add(AlgorithmThrough.ByRows, ByRows);
            Algorithms.Add(AlgorithmThrough.ByColumns, ByColumns);
        }

        private int StartFrom(int iterator, int x, int y) =>
            iterator > x ? 0 : y;

        private bool EndWhen(int x, int y, Position position, int size) =>
            y <= (x != position.X ? size - 1 : position.Y);

        private IEnumerable<Position> ByRows(IndexesAlgorithmConfig config)
        {
            for (int x = config.Start.X; x <= config.End.X; x++)
            {
                int y = StartFrom(x, config.Start.X, config.Start.Y);

                while (EndWhen(x, y, config.End, config.Width))
                {
                    yield return new Position(x, y);
                    y++;
                }
            }
        }

        private IEnumerable<Position> ByColumns(IndexesAlgorithmConfig config)
        {
            for (int y = config.Start.Y; y <= config.End.Y; y++)
            {
                int x = StartFrom(y, config.Start.Y, config.Start.X);

                while (EndWhen(y, x, new Position(config.End.Y, config.End.X), config.Height))
                {
                    yield return new Position(x, y);
                    x++;
                }
            }
        }
    }
}
