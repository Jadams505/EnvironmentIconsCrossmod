using CalValEX.Biomes;
using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.CalamityVanities;

public static class CalamityVanitiesInfo
{
	internal const string ModName = "CalValEX";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);
}

[JITWhenModsEnabled(CalamityVanitiesInfo.ModName)]
public class AstralBlight_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralBlight>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityVanitiesInfo.Enabled;
}
