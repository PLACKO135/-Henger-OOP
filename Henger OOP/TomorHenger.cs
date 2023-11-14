using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Henger_OOP
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            fajsuly = 7.87;
        }

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public double GetFajsuly { get => fajsuly; }
        public double Suly { get => Terfogat() * fajsuly; }

        public override string ToString()
        {
            return base.ToString() + $" fajsúly:{fajsuly};";
        }
    }
}