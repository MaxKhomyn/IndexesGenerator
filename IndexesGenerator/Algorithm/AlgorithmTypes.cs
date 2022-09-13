using System;
using System.Collections.Generic;

namespace IndexesGenerator.Algorithm
{
    internal class AlgorithmTypes
    {
        private readonly Dictionary<AlgorithmType, Func<IndexesAlgorithm>> _types;

        public AlgorithmTypes()
        {
            _types = new Dictionary<AlgorithmType, Func<IndexesAlgorithm>>
            {
                { AlgorithmType.Square, SquareAlgorithm.GetNewInstance },
                { AlgorithmType.Snake, SnakeAlgorithm.GetNewInstance }
            };
        }

        public IndexesAlgorithm GetAlgorithm(AlgorithmType type)
        {
            try
            {
                return _types[type]();
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException("Could not define Algorithm Type");
            }
        }
    }
}
