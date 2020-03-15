using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_Regions.Elements.Properties;
using UnityEngine;

namespace UD_Regions.Elements
{
    public class Region
    {
        public string Name;
        public Vector3 Center;
        public int Radius;
        public List<RegionProperty> Properties;

        public Region(string name, Vector3 center, int radius)
        {
            this.Name = name;
            this.Center = center;
            this.Radius = radius;
            this.Properties = new List<RegionProperty>();
        }

        public bool Contains(Vector3 position)
        {
            return Distance(this.Center, position) < Radius;
        }

        public double Distance(Vector3 pos1, Vector3 pos2)
        {
            return Math.Sqrt(Math.Pow(pos1.x - pos2.x, 2) + Math.Pow(pos1.x - pos2.x, 2));
        }

        public bool AddProperty(RegionProperty property)
        {
            if (!Properties.Contains(property))
            {
                Properties.Add(property);
                return true;
            }
            return false;
        }
    }
}
