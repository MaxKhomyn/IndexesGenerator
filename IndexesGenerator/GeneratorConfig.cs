using IndexesGenerator.Algorithm;

namespace IndexesGenerator
{
    public class GeneratorConfig : IndexesAlgorithmConfig
    {
        public AlgorithmType Type { get; set; }
        public AlgorithmDirection Direction { get; set; }
    }
}
