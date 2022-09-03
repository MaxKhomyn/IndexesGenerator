using IndexesGenerator.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexesGenerator
{
    public class Generator
    {
        public IEnumerable<Position> Generate(GeneratorConfig config)
        {
            if (config is null)
            {
                throw new ArgumentNullException("config - can not be null");
            }

            var algorithmTypes = new AlgorithmTypes();

            var enumerable = algorithmTypes
                .GetAlgorithm(config.Type)
                .Generate(config);

            var isReverse = config.Direction == AlgorithmDirection.Reverse;

            if (isReverse)
            {
                return enumerable.Reverse();
            }

            return enumerable;
        }
    }
}
