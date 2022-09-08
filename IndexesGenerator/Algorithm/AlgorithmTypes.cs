﻿using System;
using System.Collections.Generic;

namespace IndexesGenerator.Algorithm
{
    internal class AlgorithmTypes
    {
        protected readonly Dictionary<AlgorithmType, Func<IndexesAlgorithm>> Types;

        public AlgorithmTypes()
        {
            Types = new Dictionary<AlgorithmType, Func<IndexesAlgorithm>>();

            Types.Add(AlgorithmType.Square, SquareAlgorithm.GetNewInstance);
            Types.Add(AlgorithmType.Snake, SnakeAlgorithm.GetNewInstance);
        }

        public IndexesAlgorithm GetAlgorithm(AlgorithmType type)
        {
            try
            {
                return Types[type]();
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException("Could not define Algorithm Type");
            }
        }
    }
}
