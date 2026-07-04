using CalValEX.Biomes;
using EnvironmentIcons.API;
using EnvironmentIconsCrossmod.Macrocosm;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.CalamityVanities;

public static class CalamityVanitiesInfo
{
	internal const string ModName = "CalValEX";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(CalamityVanitiesInfo.ModName)]
public class AstralBlight_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AstralBlight";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityVanitiesInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityVanitiesInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityVanitiesInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityVanitiesInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityVanitiesInfo.ModName, BiomeName, nameof(AstralBlight_EnvironmentIcon));
			return false;
		}

		return true;
	}
}
