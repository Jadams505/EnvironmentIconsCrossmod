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
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer1Biome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.Abyss1",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class Abyss2_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer2Biome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.Abyss2",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class Abyss3_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer3Biome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.Abyss3",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class Abyss4_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer4Biome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.Abyss4",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AcidRain_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AcidRainBiome>();

	// IsBiomeActive is not implemented in Calamity for acid rain
	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.AcidRain",
		() => IsBiomeActive() || AcidRainEvent.AcidRainEventIsOngoing);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class ArsenalLab_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<ArsenalLabBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.ArsenalLab",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralInfection_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralInfectionBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.AstralInfection",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralCaveDesert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralCaveDesert>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.AstralCaveDesert",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralDesert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralDesert>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.AstralDesert",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralIce_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralIce>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.AstralIce",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class AstralUnderground_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralUnderground>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.AstralUnderground",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}
 
[JITWhenModsEnabled(CalamityInfo.ModName)]
public class BasaltGully_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<BasaltGullyBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.BasaltGullyBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class BrimstoneCrag_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<BrimstoneCragsBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.BrimstoneCragsBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class ClamDen_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<ClamDenBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.ClamDenBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class GleamingBurrows_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<GleamingBurrowsBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.GleamingBurrowsBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class PolypForest_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<PolypForestBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.PolypForestBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class RadiantReefs_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<RadiantReefsBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.RadiantReefsBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class SulphurousSea_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<SulphurousSeaBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.SulphurousSeaBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class SunkenSea_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<SunkenSeaBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.SunkenSeaBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled(CalamityInfo.ModName)]
public class TimelessShores_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<TimelessShoresBiome>();

	public override Condition Applies() => new Condition($"{CalamityInfo.ConditionPath}.TimelessShoresBiome",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}