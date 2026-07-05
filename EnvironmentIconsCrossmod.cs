using EnvironmentIconsCrossmod.Macrocosm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace EnvironmentIconsCrossmod
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class EnvironmentIconsCrossmod : Mod
	{
		private static EnvironmentIconsCrossmod _instance;
		public static EnvironmentIconsCrossmod Instance => _instance ??= ModContent.GetInstance<EnvironmentIconsCrossmod>();
		public int MissingContent { get; private set; } = 0;

		public static void LogMissingBiome(string modName, string modBiome, string disabledContent) =>
			LogMissingContent<ModBiome>(modName, modBiome, disabledContent);

		public static void LogMissingContent<T>(string modName, string content, string disabledContent)
		{
			Instance.MissingContent++;
			Instance.Logger.Error($"The {typeof(T).Name}: {content} added by {modName} could not be found. Loading for {disabledContent} has been disabled. Most likely {modName} had a recent update and may have removed or deleted {content}. Please report this message to '{Instance.DisplayNameClean}'.");
		}
	}
}
