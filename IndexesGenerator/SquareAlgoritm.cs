﻿using System.Collections.Generic;

namespace IndexesGenerator
{
    internal class SquareAlgorithm : IndexesAlgorithm
    {
        public SquareAlgorithm()
        {
            Algorithms.Add(Algorithm.ByRows, ByRows);
            Algorithms.Add(Algorithm.ByColumns, ByColumns);
        }

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