using Rocket.API;
using Logger = Rocket.Core.Logging.Logger;
using System;
using System.Collections.Generic;
using UD_Regions.Elements;
using UD_Regions.Entities;
using Rocket.Unturned.Player;

namespace UD_Regions.Commands
{
    class CreateCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => throw new NotImplementedException();

        public string Name => "RegionCreate";

        public string Help => throw new NotImplementedException();

        public string Syntax => "/regioncreate <Name> <Type> <Size>";

        public List<string> Aliases => new List<string> { "rcreate", "rc" };

        public List<string> Permissions => throw new NotImplementedException();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            string name = command[0];
            SerializableVector3 center = new SerializableVector3(((UnturnedPlayer)caller).Position);
            string type = command[1];
            ushort size = ushort.Parse(command[2]);

            Logger.Log("Creating Region " + name);
            UD_Regions.Instance.CreateRegion(new Region(name, center, size));
            Logger.Log("Created Region " + name);
        }
    }
}
