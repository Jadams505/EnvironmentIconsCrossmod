using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.SOTS;

public static class SOTSInfo
{
	internal const string ModName = "SOTS";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(SOTSInfo.ModName)]
public class AbandondedVillageBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AbandonedVillageBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SOTSInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SOTSInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SOTSInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SOTSInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SOTSInfo.ModName, BiomeName, nameof(AbandondedVillageBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SOTSInfo.ModName)]
public class AnomalyBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AnomalyBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SOTSInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SOTSInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SOTSInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SOTSInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SOTSInfo.ModName, BiomeName, nameof(AnomalyBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SOTSInfo.ModName)]
public class PhaseBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "PhaseBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SOTSInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SOTSInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SOTSInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SOTSInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SOTSInfo.ModName, BiomeName, nameof(PhaseBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SOTSInfo.ModName)]
public class PlanetariumBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "PlanetariumBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SOTSInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SOTSInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SOTSInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SOTSInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SOTSInfo.ModName, BiomeName, nameof(PlanetariumBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SOTSInfo.ModName)]
public class PyramidBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "PyramidBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SOTSInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SOTSInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SOTSInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SOTSInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SOTSInfo.ModName, BiomeName, nameof(PyramidBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SOTSInfo.ModName)]
public class SanctuaryBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SanctuaryBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SOTSInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SOTSInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SOTSInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SOTSInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SOTSInfo.ModName, BiomeName, nameof(SanctuaryBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}