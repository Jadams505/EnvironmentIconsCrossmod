using EnvironmentIcons.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.Verdant;

public static class VerdantIcons
{
	internal const string ModName = "Verdant";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
	public const string DisplayNamePath = $"Mods.EnvironmentIconsCrossmod.DisplayNames.{ModName}";
}

[JITWhenModsEnabled(VerdantIcons.ModName)]
public class VerdantBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "VerdantBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(VerdantIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{VerdantIcons.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!VerdantIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(VerdantIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(VerdantIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(VerdantIcons.ModName)]
public class VerdantUndergroundBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "VerdantUndergroundBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(VerdantIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{VerdantIcons.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!VerdantIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(VerdantIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(VerdantIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}
