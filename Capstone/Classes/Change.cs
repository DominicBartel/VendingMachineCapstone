﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Change
    {
        public int Nickels { get; }

        public int Dimes { get; }

        public int Quarters { get; }



        public Change(decimal total)
        {
            total *= 100;
            int workingTotal = (int)total;

            Quarters = workingTotal / 25;

            workingTotal = workingTotal - (Quarters * 25);

            Dimes = workingTotal / 10;

            workingTotal = workingTotal - (Dimes * 10);

            Nickels = workingTotal / 5;

            workingTotal = workingTotal - (Nickels * 5);

            //Total = workingTotal * 0.01m;

        }
    }
}
