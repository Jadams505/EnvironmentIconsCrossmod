using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.ThoriumMod;

public static class ThoriumInfo
{
	internal const string ModName = "ThoriumMod";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(ThoriumInfo.ModName)]
public class DepthsBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "DepthsBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(ThoriumInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{ThoriumInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!ThoriumInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(ThoriumInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(ThoriumInfo.ModName, BiomeName, nameof(DepthsBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

/* These biomes exist in Thorium, but are basically equivalent to the vanilla variants, so don't think they are needed.
[JITWhenModsEnabled(ThoriumInfo.ModName)]
public class GraniteBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "GraniteBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(ThoriumInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{ThoriumInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!ThoriumInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(ThoriumInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(ThoriumInfo.ModName, BiomeName, nameof(GraniteBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(ThoriumInfo.ModName)]
public class MarbleBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MarbleBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(ThoriumInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{ThoriumInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!ThoriumInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(ThoriumInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(ThoriumInfo.ModName, BiomeName, nameof(MarbleBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}
*/