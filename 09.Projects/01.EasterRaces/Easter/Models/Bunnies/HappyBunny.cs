﻿using Easter.Models.Bunnies.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Bunnies
{
    public class HappyBunny : Bunny
    {
        

        public HappyBunny(string name) 
            : base(name, 100)
        {
        }

       
    }
}
