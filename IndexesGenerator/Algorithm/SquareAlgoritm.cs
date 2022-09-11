using System.Collections.Generic;

namespace IndexesGenerator.Algorithm
{
    internal class SquareAlgorithm : IndexesAlgorithm
    {
        protected SquareAlgorithm()
        {
            Algorithms.Add(AlgorithmThrough.ByRows, ByRows);
            Algorithms.Add(AlgorithmThrough.ByColumns, ByColumns);
        }

        public static SquareAlgorithm GetNewInstance() => new SquareAlgorithm();

        /// <summary>
        /// Iterate Indexes from start position to end position by rows. Can only increment position. Start position should be grater then end position
        /// </summary>
        /// <param name="config">Contains configuration for algorithm</param>
        /// <returns>Collection of indexes</returns>
        private IEnumerable<Position> ByRows(IndexesAlgorithmConfig config)
        {
            for (int x = config.Start.X; x <= config.End.X; x++)
            {
                for (int y = config.Start.Y; y <= config.End.Y; y++)
                {
                    yield return new Position(x, y);
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
                for (int x = config.Start.X; x <= config.End.X; x++)
                {
                    yield return new Position(x, y);
                }
            }
        }
    }
}
