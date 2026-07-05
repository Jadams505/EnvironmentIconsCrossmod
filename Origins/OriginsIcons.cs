using EnvironmentIcons.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod.Origins;

public static class OriginsInfo
{
	internal const string ModName = "Origins";
	public static Mod Instance = null;
	public static bool Enabled { get; } = ModLoader.TryGetMod(ModName, out Instance);

	public const string ConditionPath = $"Mods.EnvironmentIconsCrossmod.Conditions.{ModName}";
}

/* Not implemented yet
[JITWhenModsEnabled(OriginsInfo.ModName)]
public class AshenBiomeData_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "AshenBiomeData";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(AshenBiomeData_EnvironmentIcon));
			return false;
		}

		return true;
	}
}
*/

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Brine_Pool_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Brine_Pool";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Brine_Pool_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Defiled_Wastelands_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Defiled_Wastelands";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Defiled_Wastelands_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Underground_Defiled_Wastelands_Biome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Underground_Defiled_Wastelands_Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Underground_Defiled_Wastelands_Biome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Defiled_Wastelands_Desert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Defiled_Wastelands_Desert";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Defiled_Wastelands_Desert_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Defiled_Wastelands_Underground_Desert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Defiled_Wastelands_Underground_Desert";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Defiled_Wastelands_Underground_Desert_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Defiled_Wastelands_Ice_Biome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Defiled_Wastelands_Ice_Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Defiled_Wastelands_Ice_Biome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Defiled_Wastelands_Ocean_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Defiled_Wastelands_Ocean";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Defiled_Wastelands_Ocean_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Fiberglass_Undergrowth_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Fiberglass_Undergrowth";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Fiberglass_Undergrowth_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Limestone_Cave_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Limestone_Cave";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Limestone_Cave_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Riven_Hive_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Riven_Hive";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Riven_Hive_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Underground_Riven_Hive_Biome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Underground_Riven_Hive_Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Underground_Riven_Hive_Biome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Riven_Hive_Desert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Riven_Hive_Desert";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Riven_Hive_Desert_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Riven_Hive_Underground_Desert_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Riven_Hive_Underground_Desert";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Riven_Hive_Underground_Desert_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Riven_Hive_Ice_Biome_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Riven_Hive_Ice_Biome";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Riven_Hive_Ice_Biome_EnvironmentIcon));
			return false;
		}

		return true;
	}
}

[JITWhenModsEnabled(OriginsInfo.ModName)]
public class Riven_Hive_Ocean_EnvironmentIcon : ModBiomeEnvironmentIcon
{
	public const string BiomeName = "Riven_Hive_Ocean";
	protected override ModBiome Biome => ModContent.Find<ModBiome>(OriginsInfo.ModName, BiomeName);

	public override Condition Applies() => new Condition($"{OriginsInfo.ConditionPath}.{BiomeName}",
		IsBiomeActive);

	public override bool IsLoadingEnabled(Mod mod)
	{
		if (!OriginsInfo.Enabled)
			return false;

		if (!ModContent.TryFind<ModBiome>(OriginsInfo.ModName, BiomeName, out _))
		{
			EnvironmentIconsCrossmod.LogMissingBiome(OriginsInfo.ModName, BiomeName, nameof(Riven_Hive_Ocean_EnvironmentIcon));
			return false;
		}

		return true;
	}
}