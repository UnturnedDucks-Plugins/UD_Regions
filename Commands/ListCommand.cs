using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD_Regions.Commands
{
    class ListCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Help => throw new NotImplementedException();

        public string Syntax => throw new NotImplementedException();

        public List<string> Aliases => throw new NotImplementedException();

        public List<string> Permissions => throw new NotImplementedException();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            throw new NotImplementedException();
        }
    }
}
