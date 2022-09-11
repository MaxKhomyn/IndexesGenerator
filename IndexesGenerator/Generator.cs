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

            if (config.Start == config.End)
            {
                return new[] { config.Start };
            }

            if (config.Start > config.End)
            {
                var temp = config.Start;
                config.Start = config.End;
                config.End = temp;

                config.Direction = config.Direction == AlgorithmDirection.Normal ?
                    AlgorithmDirection.Reverse :
                    AlgorithmDirection.Normal;
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
