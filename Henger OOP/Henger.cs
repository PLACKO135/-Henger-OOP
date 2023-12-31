﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Henger_OOP
{
    public class Henger
    {
        double magassag;
        double sugar;
        static int szuletesSzamlalo = 0;
        public Henger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public double GetMagassag { get => magassag; }
        public double GetSugar { get => sugar; }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }
   

        public virtual double Terfogat()
        {
            return Math.PI * Math.Pow(sugar, 2) * magassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Math.Round(Terfogat(), 2)}; sugár:{sugar}; magasság:{magassag};";
        }
    }
}