using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexesGenerator
{
    internal class GeneratorConfig : IndexesAlgorithmConfig
    {
        public AlgorithmType AlgorithmType { get; set; }
        public AlgorithmDirection AlgorithmDirection { get; set; }
    }

    internal class Generator
    {
        protected readonly Dictionary<AlgorithmType, Func<IndexesAlgorithm>> AlgorithmTypes;

        public Generator()
        {
            AlgorithmTypes = new Dictionary<AlgorithmType, Func<IndexesAlgorithm>>();

            AlgorithmTypes.Add(AlgorithmType.Squere, GetSquareAlgorithm);
            AlgorithmTypes.Add(AlgorithmType.Snake, GetSnakeAlgorithm);
        }

        private IndexesAlgorithm GetSnakeAlgorithm() => new SnakeAlgorithm();

        private IndexesAlgorithm GetSquareAlgorithm() => new SquareAlgorithm();

        private IEnumerable<Position> GenerateIndexes(GeneratorConfig config)
        {
            try
            {
                var algorithmType = AlgorithmTypes[config.AlgorithmType];

                return algorithmType().Generate(config);
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException("Could not define Algorithm Type");
            }
        }

        public IEnumerable<Position> Generate(GeneratorConfig config)
        {
            if (config is null)
            {
                throw new ArgumentNullException("config - can not be null");
            }

            var enumerable = GenerateIndexes(config);

            var isReverse = config.AlgorithmDirection == AlgorithmDirection.Reverse;

            if (isReverse)
            {
                return enumerable.Reverse();
            }

            return enumerable;
        }
    }
}
