using Rocket.API;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using UD_Regions.Elements;

namespace UD_Regions
{
    public class UD_RegionsConfiguration : IRocketPluginConfiguration
    {
        public List<Region> Regions;

        public void LoadDefaults()
        {
            Regions = new List<Region>();
        }
    }
}
