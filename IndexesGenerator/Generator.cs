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
                throw new ArgumentNullException(nameof(config));
            }

            if (config.Start == config.End)
            {
                return new[] { config.Start };
            }

            var isReverse = config.Start > config.End;

            if (isReverse)
            {
                (config.Start, config.End) = (config.End, config.Start);
            }

            var algorithmTypes = new AlgorithmTypes();

            var enumerable = algorithmTypes
                .GetAlgorithm(config.Type)
                .Generate(config);

            if (isReverse)
            {
                return enumerable.Reverse();
            }

            return enumerable;
        }
    }
}
