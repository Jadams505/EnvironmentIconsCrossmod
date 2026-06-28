using CalamityMod.BiomeManagers;
using CalamityMod.BiomeManagers.BestiaryCategories;
using CalamityMod.Events;
using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.CalamityMod;

public static class CalamityInfo
{
	internal const string CalamityMod = "CalamityMod";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(CalamityMod, out Instance);
}

[JITWhenModsEnabled("CalamityMod")]
public class Abyss1_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer1Biome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class Abyss2_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer2Biome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class Abyss3_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer3Biome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class Abyss4_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AbyssLayer4Biome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class AcidRain_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AcidRainBiome>();

	// IsBiomeActive is not implemented in Calamity for acid rain
	public override Condition Applies() => new Condition("",
		() => IsBiomeActive() || AcidRainEvent.AcidRainEventIsOngoing);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class ArsenalLab_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<ArsenalLabBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class AstralInfection_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralInfectionBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class AstralCaveDesert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralCaveDesert>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class AstralDesert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralDesert>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class AstralIce_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralIce>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class AstralUnderground_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<AstralUnderground>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class BasaltGully_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<BasaltGullyBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class BrimstoneCrag_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<BrimstoneCragsBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class ClamDen_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<ClamDenBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class GleamingBurrows_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<GleamingBurrowsBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class PolypForest_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<PolypForestBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class RadiantReefs_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<RadiantReefsBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class SulphurousSea_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<SulphurousSeaBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class SunkenSea_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<SunkenSeaBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}

[JITWhenModsEnabled("CalamityMod")]
public class TimelessShores_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	protected override ModBiome Biome => ModContent.GetInstance<TimelessShoresBiome>();

	public override Condition Applies() => new Condition("",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod) => CalamityInfo.Enabled;
}