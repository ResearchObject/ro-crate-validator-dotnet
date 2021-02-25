using System;

namespace RoCrateValidatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool output = new RoCrateValidator.Validator().IsValidRoCrate(RO_Crate_validator.RoCrateMetadataExamples.RoCrateExample1);
            Console.WriteLine("Hello World!");
        }
    }
}
