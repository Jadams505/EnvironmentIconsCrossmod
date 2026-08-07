using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.Arbour;

public static class ArbourIcons
{
	internal const string ModName = "Arbour";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
	public const string DisplayNamePath = $"Mods.EnvironmentIconsCrossmod.DisplayNames.{ModName}";
}

[JITWhenModsEnabled(ArbourIcons.ModName)]
public class ArborBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ArborBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(ArbourIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{ArbourIcons.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!ArbourIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(ArbourIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(ArbourIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

