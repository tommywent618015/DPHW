﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class Knight : Character
    {
        public Knight()
        {
            Weapon = new BowAndArrowBehaviour();
        }
    }
}
