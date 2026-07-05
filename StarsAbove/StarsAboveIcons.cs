using EnvironmentIcons.API;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.StarsAbove;

// Stars Above adds a lot more subworlds than biomes.
// TODO: Implement those as icons, maybe use their map icons as the icons, will require custom element I think
public static class StarsAboveInfo
{
	internal const string ModName = "StarsAbove";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
	public const string DisplayNamePath = $"Mods.EnvironmentIconsCrossmod.DisplayNames.{ModName}";
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class BleachedWorld_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "BleachedWorldBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(BleachedWorld_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class CorvusBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "CorvusBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(CorvusBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class DreamingCityBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "DreamingCityBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(DreamingCityBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class FriendlySpaceBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "FriendlySpaceBiome";
	public override LocalizedText DisplayName => Language.GetText($"{StarsAboveInfo.DisplayNamePath}.{BiomeName}");
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(FriendlySpaceBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class LyraBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "LyraBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(LyraBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class MoonBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MoonBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(MoonBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class NeonVeilBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "NeonVeilBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(NeonVeilBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class ObservatoryBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ObservatoryBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(ObservatoryBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class OtherworldBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "OtherworldBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(OtherworldBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(StarsAboveInfo.ModName)]
public class SeaOfStarsBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SeaOfStarsBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(StarsAboveInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{StarsAboveInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!StarsAboveInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(StarsAboveInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(StarsAboveInfo.ModName, BiomeName, nameof(SeaOfStarsBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}