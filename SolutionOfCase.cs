using System;
using System.Linq;

namespace TestCase
{
    public class SolutionOfCase
    {
        public SolutionOfCase(int sample)
        {
            People = new Person[sample];
            for (int i = 0; i < sample; i++)
            {
                Console.WriteLine($"Person {i+1}");
                Console.Write("Enter what is age of death : ");
                if (!int.TryParse(Console.ReadLine(), out int aod))
                    Exception = true;

                Console.Write("Enter what is year of death : ");
                if (!int.TryParse(Console.ReadLine(), out int yod))
                    Exception = true;

                if (yod - aod <= DateTime.Now.Year)
                    Exception = true;

                if (Exception)
                    break;

                People[i] = new Person(aod, yod);
            }

            if (Exception)
                Console.WriteLine("Average people death: -1");
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Average people death : {People.Average(a => a.NumberOfPeopleKilled)}");
            }
        }

        private Person[] People { get; set; }
        private bool Exception { get; set; }
    }
}
