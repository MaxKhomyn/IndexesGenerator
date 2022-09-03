using System;

namespace IndexesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();

            var config = new GeneratorConfig()
            {
                Start = new Position(1, 1),
                End = new Position(2, 3),
                Height = 4,
                Width = 5,
                Algorithm = Algorithm.ByRows,
                AlgorithmType = AlgorithmType.Snake,
                AlgorithmDirection = AlgorithmDirection.Reverse
            };

            foreach (var item in generator.Generate(config))
            {
                Console.WriteLine($"{item}\n");
            }

            Console.ReadKey();
        }
    }
}
