using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            sweepstakes.RegisterContestant();
            sweepstakes.PickWinner();

        }
    }
}
