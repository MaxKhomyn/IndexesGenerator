using System.Collections.Generic;

namespace IndexesGenerator.Algorithm
{
    internal sealed class SnakeAlgorithm : IndexesAlgorithm
    {
        private SnakeAlgorithm() : base()
        {
            Algorithms.Add(AlgorithmThrough.ByRows, ByRows);
            Algorithms.Add(AlgorithmThrough.ByColumns, ByColumns);
        }

        public static SnakeAlgorithm GetNewInstance() => new();

        private int StartFrom(int iterator, int x, int y) =>
            iterator > x ? 0 : y;

        private bool EndWhen(int x, int y, Position position, int size) =>
            y <= (x != position.X ? size - 1 : position.Y);

        /// <summary>
        /// Iterate Indexes from start position to end position by rows. Can only increment position. Start position should be grater then end position
        /// </summary>
        /// <param name="config">Contains configuration for algorithm</param>
        /// <returns>Collection of indexes</returns>
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

        /// <summary>
        /// Iterate Indexes from start position to end position by columns. Can only increment position. Start position should be grater then end position
        /// </summary>
        /// <param name="config">Contains configuration for algorithm</param>
        /// <returns>Collection of indexes</returns>
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
