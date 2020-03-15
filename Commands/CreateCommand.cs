using System;
using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using UD_Regions.Elements;
using UnityEngine;

namespace UD_Regions.Commands
{
    public class CreateCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "rcreate";

        public string Help => "Create an Region";

        public string Syntax => "/rcreate <RegionName> <Type> <Radius>";

        public List<string> Aliases => new List<string> {"rcreate"};

        public List<string> Permissions => new List<string> { "region.command.create" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UD_Regions instance = UD_Regions.Instance;

            if (command.Length < 2)
            {
                UnturnedChat.Say(caller, "You are not using the command correctly: " + this.Syntax, Color.red);
                return;
            }

            string name = command[0].ToString();
            string type = command[1].ToString().ToLower();
            int radius = Int16.Parse(command[2]);

            if(UD_Regions.Instance.GetRegion(name) != null)
            {
                UnturnedChat.Say(caller, "A region with this name already exists");
            }

            switch (type)
            {
                case ("circle"):
                    instance.Regions.Add(new Region(name, radius));
                    break;
                default:
                    break;
            }
        }
    }
}
