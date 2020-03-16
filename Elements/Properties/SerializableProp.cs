using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD_Regions.Elements.Properties
{
    [Serializable]
    public class SerializableProp
    {
        public string PropName;

        public SerializableProp() { }

        public SerializableProp(string propName)
        {
            this.PropName = propName;
        }

        public Prop Deserialize()
        {
            return null;
        }
    }
}
