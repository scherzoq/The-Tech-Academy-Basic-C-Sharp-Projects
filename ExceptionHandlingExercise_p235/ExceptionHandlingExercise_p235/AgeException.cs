﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise_p235
{
    public class AgeException : Exception
    {
        public AgeException()
            : base() { }
        public AgeException(string message)
            : base(message) { }
    }
}
