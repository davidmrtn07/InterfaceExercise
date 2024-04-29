﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    interface ICompany
    {
        string Logo { get; set; }
        DateTime DateEstablished { get; set; }

        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }
        bool CanDrive { get; set; }

        void Drive();

    }
}
