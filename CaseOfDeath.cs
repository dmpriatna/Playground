using System;
namespace TestCase
{
    public class CaseOfDeath
    {
        public CaseOfDeath(int year)
        {
            year -= DateTime.Now.Year;
            NN = new double[year];
            N = 0;

            for (int i = 0; i < year; i++)
            {
                if (i < 2)
                    NN[i] = 1;
                else
                    NN[i] = NN[i-1] + NN[i-2];
                N += NN[i];
            }

            Vilagers = N;
        }

        private double N { get; set; }
        private double[] NN { get; set; }

        public double Vilagers { get; set; }
    }
}
