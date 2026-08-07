using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.TheDepths;

public static class TheDepthsIcons
{
	internal const string ModName = "TheDepths";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
	public const string DisplayNamePath = $"Mods.EnvironmentIconsCrossmod.DisplayNames.{ModName}";
}

[JITWhenModsEnabled(TheDepthsIcons.ModName)]
public class DepthsBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "DepthsBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(TheDepthsIcons.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{TheDepthsIcons.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!TheDepthsIcons.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(TheDepthsIcons.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(TheDepthsIcons.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}
