using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using System.Collections.Generic;
using UD_Regions.Elements;

namespace UD_Regions
{
    public class UD_Regions : RocketPlugin<UD_RegionsConfiguration>
    {
        public static UD_Regions Instance;
        public List<Region> Regions;
        public List<UnturnedPlayer> Players;

        protected override void Load()
        {
            Logger.LogWarning("Loading UnturnedDucks Regions");
            Instance = this;

            Logger.LogWarning("Loading Existing Regions");
            Regions = Configuration?.Instance?.Regions ?? new List<Region>();
            foreach (Region region in Regions) { Logger.LogWarning("Loading " + region.Name); }

            Logger.LogWarning("Loading Players");
            Players = new List<UnturnedPlayer>();
        }

        protected override void Unload()
        {
            base.Unload();
        }

        public Region GetRegion(string regionName)
        {
            foreach (Region region in Regions)
            {
                if (region.Name.Equals(regionName))
                    return region;
            }
            return null;
        }

        public void PlayerConnected(UnturnedPlayer player)
        {
            Players.Add(player);
        }

        public void CreateRegion(Region toAdd)
        {
            Instance.Regions.Add(toAdd);
            toAdd.StartListening();
        }
    }
}
