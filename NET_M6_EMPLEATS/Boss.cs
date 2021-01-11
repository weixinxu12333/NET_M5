using System;
using System.Collections.Generic;
using System.Text;

namespace NET_M6_EMPLEATS
{
    public class Boss : Base
    {
        public Boss(double souBase) : base(souBase, 1.5)
        {
            if (souBase < 8000) throw new ArgumentOutOfRangeException(nameof(souBase));
        }
    }
}
