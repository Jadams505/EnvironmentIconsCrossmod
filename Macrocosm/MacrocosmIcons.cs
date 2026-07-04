using EnvironmentIcons.API;
using Macrocosm.Content.Biomes;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.Macrocosm;

public static class MacrocosmInfo
{
	internal const string ModName = "Macrocosm";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class BasaltBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "BasaltBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(BasaltBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}


[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class Moon_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MoonBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) 
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(Moon_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class DemonSunBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "DemonSunBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(DemonSunBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class EarthBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "EarthBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(EarthBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class IrradiationBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "IrradiationBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(IrradiationBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class MoonNightBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MoonNightBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(MoonNightBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}


[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class MoonUndergroundBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MoonUndergroundBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(MoonUndergroundBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class PollutionBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "PollutionBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(PollutionBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(MacrocosmInfo.ModName)]
public class UndergroundPollutionBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "UndergroundPollutionBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(MacrocosmInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{MacrocosmInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!MacrocosmInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(MacrocosmInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(MacrocosmInfo.ModName, BiomeName, nameof(UndergroundPollutionBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}