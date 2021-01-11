using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Base
    {
        private double SouBase { get; } = 2000;
        private double MultiplicadorSou { get; } = 1;
        public double SouBrutMensual => SouBase * MultiplicadorSou;
        public double SouBrutAnual => SouBrutMensual * 12;
        public double SouNetMensual { get; set; }
        public double SouNetAnual { get; set; }
        public double bonus {get; set;}

        public Base(double souBase, double multiplicadorSou)
        {
            SouBase = souBase;
            MultiplicadorSou = multiplicadorSou;
        }
    }
}
