using System;
using System.Collections.Generic;

namespace IndexesGenerator
{
    internal delegate IEnumerable<Position> IndexesAlgorithmFunc(IndexesAlgorithmConfig config);

    internal class IndexesAlgorithm
    {
        protected readonly Dictionary<Algorithm, IndexesAlgorithmFunc> Algorithms;

        public IndexesAlgorithm()
        {
            Algorithms = new Dictionary<Algorithm, IndexesAlgorithmFunc>();
        }

        public IEnumerable<Position> Generate(IndexesAlgorithmConfig config)
        {
            if (config is null)
            {
                throw new ArgumentNullException("config - can not be null");
            }

            try
            {
                var algorithm = Algorithms[config.Algorithm];

                return algorithm(config);
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException("Could not define Algorithm");
            }
        }
    }
}
