using Rocket.API;
using Rocket.Core.Plugins;
using System;
using Logger = Rocket.Core.Logging.Logger;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using UnityEngine;
using Rocket.Unturned.Chat;
using Rocket.API.Collections;
using static Rocket.Unturned.Events.UnturnedEvents;

namespace ExperienceReset
{
    public class ExperienceReset : RocketPlugin<ExperienceResetConfig>
    {
        public static ExperienceReset Instance { get; private set; }

        protected override void Load()
        {
            Instance = this;
            Logger.Log("ExperienceReset Loaded", ConsoleColor.Yellow);

            U.Events.OnPlayerConnected += onPlayerConnected;
        }

        public void onPlayerConnected(UnturnedPlayer player)
        {
            Logger.Log(player.Experience.ToString());


            if(player.Experience >= 1000)
            {
                player.Experience = 500;
                
            } else
            {
                return;
            }
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= onPlayerConnected;
        }
    }
}
