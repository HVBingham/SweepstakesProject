﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface ISweepstakesManager
    { 
        void InsertSweepstakes(Sweepstakes sweepStakes);
        Sweepstakes GetSweepstakes();
       
    }
}
