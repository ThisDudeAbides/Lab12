﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Staff : Person 
    {

       private string school;
        private double pay;

        public string School
        {
            get
            {
                return School;
            }
            set
            {
                School = value;
            }
        }
        public double Pay
        {
            get
            {
                return Pay;
            }
            set
            {
                Pay = value;
            }
        }

        public Staff()
        {

        }
        public Staff(string n, string a, string sch, double sal) : base(n, a)

        {
            School = sch;
            Pay = sal;
        }
        public override string ToString()
        {
            return  $" Student {Name}, Address {Address}, School{School},pay {Pay}";
        }
    }
}