﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class DroneLimitExceededException : Exception
    {
        public DroneLimitExceededException(string message) : base(message)
        {
        }
    }
}
