using EnvironmentIcons.API;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.AAModClassic;

public static class AAModClassicInfo
{
	internal const string ModName = "AAModClassic";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class AcropolisBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AcropolisBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, nameof(AcropolisBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class HoardBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "HoardBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, nameof(HoardBiome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class InfernoBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "InfernoBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class RisingSunPagodaBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "RisingSunPagodaBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class MireBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MireBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class RisingMoonLakeBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "RisingMoonLakeBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class RedMushroomBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "RedMushroomBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class StarsBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "StarsBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class TerrariumBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "TerrariumBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class VoidBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "VoidBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class LostKeepBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "LostKeepBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class ParthenanBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "ParthenanBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModClassicInfo.ModName)]
public class SunkenShipBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "SunkenShipBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModClassicInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModClassicInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModClassicInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModClassicInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModClassicInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}