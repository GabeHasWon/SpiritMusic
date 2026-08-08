using System;
using Terraria.ID;

namespace SpiritMusic.Common.Scenes;

internal class MarbleScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/MarbleBiome");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
    public override bool IsSceneEffectActive(Player player) => MusicConfig.Instance.Marble && Main.tile[player.Center.ToTileCoordinates16()].WallType == WallID.MarbleUnsafe;
}

[Obsolete("Replaced with background wall checks, but may be used in the future?")]
public class MarbleTileCounter : ModSystem
{
    public bool InMarble => _marbleCount > 200;

    private int _marbleCount = 0;

    public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
    {
        _marbleCount = tileCounts[TileID.Marble];

    }
}