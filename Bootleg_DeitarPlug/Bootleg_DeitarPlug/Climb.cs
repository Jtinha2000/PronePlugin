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
    public class Climb : RocketPlugin<Config>
    {
        public static Climb Instance { get; set; }
        protected override void Load()
        {
            Instance = this;
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected += Events_OnPlayerDisconnected;
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
            U.Events.OnPlayerDisconnected -= Events_OnPlayerDisconnected;
        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            player.Player.stance.onStanceUpdated += () => onStanceUpdated(player);
        }

        private void Events_OnPlayerDisconnected(UnturnedPlayer player)
        {
            player.Player.stance.onStanceUpdated -= () => onStanceUpdated(player);
        }

        private void onStanceUpdated(UnturnedPlayer player)
        {
            if (player.Stance == EPlayerStance.PRONE && Climb.Instance.Configuration.Instance.OthertoProne == true)
            {
                player.Player.equipment.dequip();
            }
            else if(player.Player.stance.initialStance == EPlayerStance.PRONE)
            {
                player.Player.equipment.dequip();
            }
        }
    }
}
