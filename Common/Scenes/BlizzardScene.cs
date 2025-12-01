namespace SpiritMusic.Common.Scenes;

internal class BlizzardScene : ModSceneEffect
{
    public override int Music => MusicLoader.GetMusicSlot(Mod, SpiritMusic.SwapMusic ? "Sounds/Music/OtherworldBlizzard" : "Sounds/Music/Blizzard");
    public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;

    public override bool IsSceneEffectActive(Player player) => ModContent.GetInstance<MusicConfig>().Blizzard
        && player.ZoneSnow
        && player.ZoneOverworldHeight
        && !player.ZoneCorrupt
        && !player.ZoneMeteor
        && !player.ZoneCrimson
        && Main.raining;
}
