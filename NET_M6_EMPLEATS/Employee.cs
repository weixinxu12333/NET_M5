﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Employee : Base
    {
        public Employee(double souBase) : base(souBase, 0.85) { }
        public Employee(double souBase, double multiplicadorSou) : base(souBase, multiplicadorSou) { }
    }
}
