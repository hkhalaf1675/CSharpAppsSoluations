﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ExceptionHandling
{
    internal interface ISeries
    {
        int Current { get; }

        void GetNext();

        void Reset();

    }
}
