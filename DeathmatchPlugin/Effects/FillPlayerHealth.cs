using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Memory;
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
            Console.WriteLine("Filling player health");
            if(player == null || !player.IsValid || !player.PlayerPawn.IsValid || player.IsBot || player.JustBecameSpectator)
                return;

            var health = player.PlayerPawn.Value.Health;
            if (health == 0)
            {
                return;
            }
            else if ((health + 50) > 100)
            {
                player.PlayerPawn.Value.Health = 100;
                player.Health = 100;
            }
            else
            {
                player.PlayerPawn.Value.Health += 50;
                player.Health += 50;
            }
        }
    }
}