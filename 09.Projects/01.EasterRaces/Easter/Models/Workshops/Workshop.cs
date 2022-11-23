﻿using Easter.Models.Bunnies.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        private IEgg egg;
        private IBunny bunny;

        public Workshop()
        {
        }

        public void Color(IEgg egg, IBunny bunny)
        {
            while (egg.IsDone() || bunny.Energy > 0 || bunny.Dyes.Count > 0)
            {
                bunny.Work();
                egg.GetColored();

                while (bunny.Dyes.Count > 0)
                {
                    bunny.Work();
                }
            }
        }
    }
}
