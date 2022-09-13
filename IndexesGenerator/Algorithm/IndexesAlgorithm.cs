using System;
using System.Collections.Generic;

namespace IndexesGenerator.Algorithm
{
    public delegate IEnumerable<Position> IndexesAlgorithmFunc(IndexesAlgorithmConfig config);

    public abstract class IndexesAlgorithm
    {
        protected readonly Dictionary<AlgorithmThrough, IndexesAlgorithmFunc> Algorithms;

        protected IndexesAlgorithm()
        {
            Algorithms = new Dictionary<AlgorithmThrough, IndexesAlgorithmFunc>();
        }

        public IEnumerable<Position> Generate(IndexesAlgorithmConfig config)
        {
            if (config is null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            try
            {
                var algorithm = Algorithms[config.Through];

                return algorithm(config);
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException("Could not define Algorithm.");
            }
        }
    }
}
