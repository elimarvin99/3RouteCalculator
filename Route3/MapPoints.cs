﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route3
{
    public class MapPoints : ITrackable
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public int calculated { get; set; }
    }
}