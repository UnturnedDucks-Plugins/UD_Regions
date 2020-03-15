using Rocket.Core.Plugins;
using Logger = Rocket.Core.Logging.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_Regions.Elements;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UD_Regions.Elements.Properties;

namespace UD_Regions
{
    public class UD_Regions : RocketPlugin<UD_RegionsConfiguration>
    {
        public static UD_Regions Instance;
        public List<Region> Regions;
        public List<UnturnedPlayer> Players;

        protected override void Load()
        {
            Logger.Log("Loading UnturnedDucks Regions");

            // initialize
            Instance = this;
            Regions = new List<Region>();

            Configuration.Load();
            foreach (UnturnedPlayer player in Provider.clients.Select(p => UnturnedPlayer.FromCSteamID(p.playerID.steamID)))
            {
                PlayerConnected(player);
            }

            // loading preloaded regions
            Logger.Log("Loading Existing Regions");
            if (Regions.Count > 0) { Logger.Log("No Regions To Load"); }
            else
            {
                foreach (Region region in Regions)
                {
                    foreach (RegionProperty property in region.Properties)
                    {
                        property.Load();
                    }
                }
            }
        }

        protected override void Unload()
        {
            throw new NotImplementedException();
        }

        private void PlayerConnected(UnturnedPlayer player)
        {
            Players.Add(player);
        }

        public Region GetRegion(string regionName)
        {
            foreach (Region region in Regions)
            {
                if (region.Name.Equals(regionName))
                {
                    return region;
                }
            }

            return null;
        }
    }
}
