using EnvironmentIcons.API;
using EnvironmentIconsCrossmod.AAModClassic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.AAMod;

public static class AAModInfo
{
	internal const string ModName = "AAMod";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class InfernoSurfaceBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "InfernoSurfaceBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class InfernoUndergroundBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "InfernoUndergroundBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class MourningSunBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MourningSunBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class DreadMoonBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "DreadMoonBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class MireSurfaceBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MireSurfaceBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class MireUndergroundBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MireUndergroundBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class MushblightBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MushblightBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(AAModInfo.ModName)]
public class MushblightSurfaceBiome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "MushblightSurfaceBiome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(AAModInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{AAModInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!AAModInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(AAModInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(AAModInfo.ModName, BiomeName, GetType().Name);
			return false;
		}

		return true;
	}
}
