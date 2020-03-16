using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UD_Regions.Entities
{
    [Serializable]
    public class SerializableVector3
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public SerializableVector3() { }

        public SerializableVector3(Vector3 p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }

        public override bool Equals(object obj)
        {
            if (obj is SerializableVector3 other && x == other.x && y == other.y && z == other.z)
                return true;

            if (obj is Vector3 other3 && x == other3.x && y == other3.y && z == other3.z)
                return true;

            return false;
        }

        public Vector3 GetVector3() => new Vector3(x, y, z);
    }
}