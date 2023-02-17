﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; } = "Default value";
        public string Make { get; set; } = "Default value";
        public string Model { get; set; } = "Default value";

        public abstract void DriveAbstract();
        
        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Default Virtual Drive Methods");
        }
        
    }
}
/*
             * Create an abstract class called Vehicle X
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */