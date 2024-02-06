using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Memory;
using DeathmatchPlugin.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathmatchPlugin.Effects
{
    public static class FillPlayerHealth
    {
        public static void Do(CCSPlayerController player)
        {
            if(!player.IsAlive() || player.IsBot)
                return;

            var health = player.PlayerPawn.Value.Health;
            if (health == 0) return;

            health = (health + 50) > 100 ?
                     100 :
                     health + 50;

            player.PlayerPawn.Value.Health = health;
            player.Health = health;
            Console.WriteLine($"Filling health of player {player.PlayerName}");
        }
    }
}