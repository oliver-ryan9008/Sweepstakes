using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSweepstakes
{
    interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}
