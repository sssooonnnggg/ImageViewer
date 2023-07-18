﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Mathematics.Interop;

namespace ImageFramework.DirectX.Structs
{
    internal struct LayerLevelFilter
    {
        public int Layer;
        public int Level;
        public int Iteration;
        public int Layers;
        
        public int FilterX;
        public int FilterY;
        public int FilterZ;
        public int Levels;

        public RawBool TrueBool;
    }
}
