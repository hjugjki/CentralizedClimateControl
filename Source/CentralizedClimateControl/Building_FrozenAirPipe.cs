﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace CentralizedClimateControl
{
    public class Building_FrozenAirPipe: Building_AirPipe
    {
        public override Graphic Graphic
        {
            get
            {
                if (def.defName == "cyanAirPipeHidden") return GraphicsLoader.GraphicFrozenPipeHidden;
                return GraphicsLoader.GraphicFrozenPipe;
            }
        }
    }
}
