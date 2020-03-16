using System;
using System.Collections.Generic;
using UD_Regions.Elements.Properties;
using UD_Regions.Entities;
using UnityEngine;

namespace UD_Regions.Elements
{
    [Serializable]
    public class Region
    {
        public string Name;
        public SerializableVector3 Center;
        public int Radius;
        public List<SerializableProp> Properties;

        public Region() { }

        public Region(string name, SerializableVector3 center, int radius)
        {
            this.Name = name;
            this.Center = center;
            this.Radius = radius;

            this.Properties = new List<SerializableProp>();
        }

        #region contains
        public bool Contains(SerializableVector3 position)
        {
            return Distance(this.Center, position) < Radius;
        }

        public bool Contains(Vector3 position)
        {
            return Contains(new SerializableVector3(position));
        }
        #endregion

        public static double Distance(SerializableVector3 pos1, SerializableVector3 pos2)
        {
            return Math.Sqrt(Math.Pow(pos1.x - pos2.x, 2) + Math.Pow(pos1.x - pos2.x, 2));
        }

        public void StartListening()
        {

        }
    }
}
