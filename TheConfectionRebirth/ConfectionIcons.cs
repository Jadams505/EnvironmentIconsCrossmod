using EnvironmentIcons.API;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.RGB;
using Terraria.Localization;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.TheConfectionRebirth;

public static class TheConfectionRebirthIcons
{
	internal const string ModName = "TheConfectionRebirth";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
	public const string DisplayNamePath = $"Mods.EnvironmentIconsCrossmod.DisplayNames.{ModName}";
}

[JITWhenModsEnabled(TheConfectionRebirthIcons.ModName)]
public class ConfectionBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ConfectionBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{TheConfectionRebirthIcons.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!TheConfectionRebirthIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(TheConfectionRebirthIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(TheConfectionRebirthIcons.ModName)]
public class IceConfectionSurfaceBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "IceConfectionSurfaceBiome";

	// default name in confection is: currently unused due to no more surface snow npcs
	public override LocalizedText DisplayName => Language.GetText($"{TheConfectionRebirthIcons.DisplayNamePath}.{BiomeName}");
	protected override ModBiome Biome => ModContent.Find<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName);

	// IsBiomeActive is not implemented in confection
	public override Condition Applies() => new Condition($"{TheConfectionRebirthIcons.ConditionPath}.{BiomeName}",
		() => IsBiomeActive() 
		|| CommonConditions.SurfaceBiome.Snow.IsActive() && ModContent.GetInstance<ConfectionBiome_EnvironmentIcon>().IsBiomeActive());

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!TheConfectionRebirthIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(TheConfectionRebirthIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(TheConfectionRebirthIcons.ModName)]
public class IceConfectionUndergroundBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "IceConfectionUndergroundBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{TheConfectionRebirthIcons.ConditionPath}.{BiomeName}",
		() => IsBiomeActive()
		|| CommonConditions.UndergroundBiome.Ice.IsActive() && ModContent.GetInstance<ConfectionBiome_EnvironmentIcon>().IsBiomeActive());

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!TheConfectionRebirthIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(TheConfectionRebirthIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(TheConfectionRebirthIcons.ModName)]
public class SandConfectionSurfaceBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SandConfectionSurfaceBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{TheConfectionRebirthIcons.ConditionPath}.{BiomeName}",
		() => IsBiomeActive()
		|| CommonConditions.SurfaceBiome.Desert.IsActive() && ModContent.GetInstance<ConfectionBiome_EnvironmentIcon>().IsBiomeActive());

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!TheConfectionRebirthIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(TheConfectionRebirthIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(TheConfectionRebirthIcons.ModName)]
public class SandConfectionUndergroundBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SandConfectionUndergroundBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{TheConfectionRebirthIcons.ConditionPath}.{BiomeName}",
		() => IsBiomeActive()
		|| CommonConditions.UndergroundBiome.Desert.IsActive() && ModContent.GetInstance<ConfectionBiome_EnvironmentIcon>().IsBiomeActive());

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!TheConfectionRebirthIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(TheConfectionRebirthIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(TheConfectionRebirthIcons.ModName)]
public class ConfectionUndergroundBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ConfectionUndergroundBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{TheConfectionRebirthIcons.ConditionPath}.{BiomeName}",
		() => IsBiomeActive()
		|| Condition.NotInUnderworld.IsMet() && Condition.InBelowSurface.IsMet() && ModContent.GetInstance<ConfectionBiome_EnvironmentIcon>().IsBiomeActive());

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!TheConfectionRebirthIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(TheConfectionRebirthIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(TheConfectionRebirthIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}
