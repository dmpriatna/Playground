using System;
namespace TestCase
{
    public class Person
    {
        public Person()
        {
        }

        public Person(int ageOfDeath, int yearOfDeath)
        {
            AgeOfDeath = ageOfDeath;
            YearOfDeath = yearOfDeath;
            NumberOfPeopleKilled = new CaseOfDeath(YearOfDeath - AgeOfDeath).Vilagers;
        }

        public int AgeOfDeath { get; set; }
        public int YearOfDeath { get; set; }
        public double NumberOfPeopleKilled { get; set; }
    }
}
