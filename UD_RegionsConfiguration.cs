
using Rocket.API;
using System.Collections.Generic;
using UD_Regions.Elements;

namespace UD_Regions
{
    public class UD_RegionsConfiguration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public List<Region> Regions;

        public void LoadDefaults()
        {
            Enabled = true;
            Regions = new List<Region>();
        }
    }
}
