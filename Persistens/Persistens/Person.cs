﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public bool IsMarried { get; set; }
        public int NoOfChildren { get; set; }

        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Height = height;
            this.IsMarried = isMarried;
            this.NoOfChildren = noOfChildren;
        }
        public string MakeTitle()
        {
            return $"{name};{birthDate};{height};{isMarried};{noOfChildren}";
        }

           
    }
}
