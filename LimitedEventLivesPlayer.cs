using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LimitedEventLives;

public sealed class LimitedEventLivesPlayer : ModPlayer
{
    public override void UpdateDead()
    {
        if (Main.netMode == NetmodeID.MultiplayerClient) return;
        if (Main.invasionType == 0) return;
        
        if (Main.PlayerList.Any(player => !player.Player.dead)) return;
        
        Main.invasionDelay = 0;
        Main.invasionType = 0;
        Main.invasionSize = 0;
        Main.invasionWarn = 0;
        Main.invasionX = 0.0;
        Main.invasionSizeStart = 0;
    }
}