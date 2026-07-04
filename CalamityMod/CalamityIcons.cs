using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.CalamityMod;

public static class CalamityInfo
{
	internal const string ModName = "CalamityMod";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class Abyss1_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AbyssLayer1Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(Abyss1_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class Abyss2_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AbyssLayer2Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(Abyss2_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class Abyss3_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AbyssLayer3Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(Abyss3_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class Abyss4_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AbyssLayer4Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(Abyss4_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AcidRain_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AcidRainBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	// IsBiomeActive is not implemented in Calamity for acid rain
	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		() => IsBiomeActive() || AcidRainEvent.AcidRainEventIsOngoing);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(AcidRain_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class ArsenalLab_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ArsenalLabBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(ArsenalLab_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralInfection_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AstralInfectionBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(AstralInfection_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralCaveDesert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AstralCaveDesert";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(AstralCaveDesert_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralDesert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AstralDesert";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(AstralDesert_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralIce_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AstralIce";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(AstralIce_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralUnderground_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AstralUnderground";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(AstralUnderground_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class BasaltGully_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "BasaltGullyBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(BasaltGully_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class BrimstoneCrag_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "BrimstoneCragsBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(BrimstoneCrag_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class ClamDen_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ClamDenBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(ClamDen_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class GleamingBurrows_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "GleamingBurrowsBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(GleamingBurrows_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class PolypForest_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "PolypForestBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(PolypForest_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class RadiantReefs_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "RadiantReefsBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(RadiantReefs_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class SulphurousSea_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SulphurousSeaBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(SulphurousSea_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class SunkenSea_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SunkenSeaBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(SunkenSea_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class TimelessShores_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "TimelessShoresBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(CalamityInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!CalamityInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(CalamityInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(CalamityInfo.ModName, BiomeName, nameof(TimelessShores_EnvironmentIcon));
			return false;
		}

		return true;
	}
}