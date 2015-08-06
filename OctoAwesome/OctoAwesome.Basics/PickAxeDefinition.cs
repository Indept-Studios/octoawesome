﻿using OctoAwesome.Basics.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OctoAwesome.Basics
{
    public class PickaxeDefinition : IItemDefinition
    {
        public Bitmap Icon
        {
            get
            {
                return Resources.pick_iron;
            }
        }

        public string Name
        {
            get
            {
                return "Pickaxe";
            }
        }

        public PhysicalProperties GetProperties(IItem item)
        {
            return new PhysicalProperties()
            {
                Density = 1f,
                FractureToughness = 1f,
                Granularity = 1f,
                Hardness = 1f
            };
        }
    }
}
