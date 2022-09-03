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

        private IEnumerable<Position> ByRows(IndexesAlgorithmConfig config)
        {
            for (int x = config.Start.X; x <= config.End.X; x++)
            {
                for (int y = x > config.Start.X ? 0 : config.Start.Y; y <= (x != config.End.X ? config.Width - 1 : config.End.Y); y++)
                {
                    yield return new Position(x, y);
                }
            }
        }

        private IEnumerable<Position> ByColumns(IndexesAlgorithmConfig config)
        {
            for (int y = config.Start.Y; y <= config.End.Y; y++)
            {
                for (int x = y > config.Start.Y ? 0 : config.Start.X; x <= (y != config.End.Y ? config.Height - 1 : config.End.X); x++)
                {
                    yield return new Position(x, y);
                }
            }
        }
    }
}
