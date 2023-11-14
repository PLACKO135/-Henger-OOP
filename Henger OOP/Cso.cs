using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Henger_OOP
{
        public class Cso : Henger
    {
        private double falVastagsag;

        public double FalVastagsag
        {
            get => falVastagsag;
        }

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            falVastagsag = 1;
        }

        public override double Terfogat()
        {
            double terfogatkint = Math.PI * Math.Pow(GetSugar, 2) * GetMagassag;
            double terfogatbent = Math.PI * Math.Pow((GetSugar - falVastagsag), 2) * GetMagassag;
            return terfogatkint - terfogatbent;
        }

        public override string ToString()
        {
            return base.ToString() + $" falVastagsag: {falVastagsag}";
        }
    }
}