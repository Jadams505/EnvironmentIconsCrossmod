using EnvironmentIcons.API;
using EnvironmentIconsCrossmod.StarsAbove;
using SpiritReforged.Content.Savanna.DustStorm;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace EnvironmentIconsCrossmod.SpiritReforged;

public static class SpiritReforged
{
	internal const string ModName = "SpiritReforged";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
	public const string DisplayNamePath = $"Mods.EnvironmentIconsCrossmod.DisplayNames.{ModName}";
}

[JITWhenModsEnabled(SpiritReforged.ModName)]
public class SaltBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SaltBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SpiritReforged.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SpiritReforged.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SpiritReforged.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SpiritReforged.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SpiritReforged.ModName, BiomeName, nameof(SaltBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SpiritReforged.ModName)]
public class SavannaBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SavannaBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SpiritReforged.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SpiritReforged.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SpiritReforged.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SpiritReforged.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SpiritReforged.ModName, BiomeName, nameof(SavannaBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SpiritReforged.ModName)]
public class ZigguratBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ZigguratBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(SpiritReforged.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{SpiritReforged.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SpiritReforged.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(SpiritReforged.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(SpiritReforged.ModName, BiomeName, nameof(ZigguratBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(SpiritReforged.ModName)]
public class Duststorm_EnvironmentIcon : ModEnvironmentIcon
{
	public const string ModPlayerName = "DustStormPlayer";
	public const string BiomeName = "Duststorm";

	public override LocalizedText DisplayName { get; } = Language.GetText($"{SpiritReforged.DisplayNamePath}.{BiomeName}");

	public override UIElement GetIconElement() => BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Events.Sandstorm.GetFilterImage();

	public override Condition Applies()
	{
		return new Condition($"{SpiritReforged.ConditionPath}.{BiomeName}", IsInBiome);
	}

	private static bool IsInBiome()
	{
		if (Main.LocalPlayer.TryGetModPlayer(out DustStormPlayer player))
			return player.ZoneDustStorm;
		return false;
	}

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!SpiritReforged.Enabled)
			return false;

		if (!ModContent.TryFind<ModPlayer>(SpiritReforged.ModName, ModPlayerName, out var local))
		{
			EnvironmentIconsCrossmod.LogMissingContent<ModPlayer>(SpiritReforged.ModName, ModPlayerName, nameof(Duststorm_EnvironmentIcon));
			return false;
		}

		return true;
	}
}
