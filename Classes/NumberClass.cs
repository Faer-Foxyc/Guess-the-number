﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number.Classes
{
    internal class NumberClass
    {
        int number { get; set; }
        public NumberClass(int _number) 
        {
            number = _number;
        }

        public int Number() 
        {
            Random random = new Random();
            number = random.Next(10);
            return number;   
        }
    }
}
