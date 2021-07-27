using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Provider;
using SDG.Framework;
using Rocket.Core;
using SDG.Unturned;
using Rocket.Unturned.Events;
using SDG.NetTransport;
using SDG.SteamworksProvider;
using Rocket.Unturned.Permissions;
using Rocket.API.Collections;
using Rocket.Unturned.Enumerations;
using Rocket.API.Serialisation;

namespace Bootleg_DeitarPlug 
{
    public class Config : IRocketPluginConfiguration
    {
        public bool PronetoOther { get; set; }
        public bool OthertoProne { get; set; }
        public void LoadDefaults()
        {
            PronetoOther = true;
            OthertoProne = true;
        }
    }
}
