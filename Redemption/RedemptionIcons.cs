using EnvironmentIcons.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.Redemption;

public static class RedemptionInfo
{
	internal const string ModName = "Redemption";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class BlazingBastionBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "BlazingBastionBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(BlazingBastionBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class FowlMorningBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "FowlMorningBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(FowlMorningBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class LabBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "LabBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(LabBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class SoullessBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SoullessBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(SoullessBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class WastelandCorruptionBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "WastelandCorruptionBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(WastelandCorruptionBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class WastelandCrimsonBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "WastelandCrimsonBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(WastelandCrimsonBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class WastelandDesertBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "WastelandDesertBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(WastelandDesertBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class WastelandPurityBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "WastelandPurityBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(WastelandPurityBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(RedemptionInfo.ModName)]
public class WastelandSnowBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "WastelandSnowBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(RedemptionInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{RedemptionInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!RedemptionInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(RedemptionInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(RedemptionInfo.ModName, BiomeName, nameof(WastelandSnowBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}