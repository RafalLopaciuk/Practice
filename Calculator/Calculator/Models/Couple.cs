using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    class Couple
    {
        public double A { get; set; }
        public double B { get; set; }
        public Couple() { }
        public Couple(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double AddResult()
        {
            return this.A + this.B;
        }

        public double SubResult()
        {
            return this.A - this.B;
        }

        public double MulResult()
        {
            return this.A * this.B;
        }

        public double DivResult()
        {
            return this.A / this.B;
        }

        public double ModResult()
        {
            return this.A % this.B;
        }
    }
}
