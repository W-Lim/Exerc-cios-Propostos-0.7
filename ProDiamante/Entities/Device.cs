﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProDiamante.Entities
{
    abstract class Device
    {
        public string SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc);
    }
}
