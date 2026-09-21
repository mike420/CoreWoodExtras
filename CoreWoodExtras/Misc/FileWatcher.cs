using System;
using System.Collections.Generic;
using System.IO;
using Jotunn;

namespace CoreWoodExtras;

internal class FileWatcher
{
	// Watchers must stay referenced, otherwise they can be garbage collected and silently stop raising events.
	private static readonly List<FileSystemWatcher> Watchers = new List<FileSystemWatcher>();

	public static void WatchFileChanges(string path, Action onChanged, bool includeSubdirectories = false)
	{
		FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
		string directoryName = Path.GetDirectoryName(path);
		string fileName = Path.GetFileName(path);
		fileSystemWatcher.Path = directoryName;
		fileSystemWatcher.Filter = fileName;
		fileSystemWatcher.IncludeSubdirectories = includeSubdirectories;
		fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
		fileSystemWatcher.Changed += delegate
		{
			RaiseChanged(onChanged);
		};
		fileSystemWatcher.Deleted += delegate
		{
			RaiseChanged(onChanged);
		};
		fileSystemWatcher.Created += delegate
		{
			RaiseChanged(onChanged);
		};
		fileSystemWatcher.Renamed += delegate
		{
			RaiseChanged(onChanged);
		};
		fileSystemWatcher.EnableRaisingEvents = true;
		Watchers.Add(fileSystemWatcher);
	}

	public static void WatchTranslationChanges(string path, Action onChanged)
	{
		if (!Directory.Exists(CoreWoodPlugin.TranslationFilePath))
		{
			return;
		}
		try
		{
			// Translations live in per-language subfolders (Translations/<Language>/*.json).
			WatchFileChanges(Path.Combine(path, "*.*"), onChanged, includeSubdirectories: true);
		}
		catch
		{
			Logger.LogError("There was an issue loading Translation files!");
		}
	}

	// Events arrive on a thread-pool thread and can fire while the editor still holds the file, so never let an exception escape.
	private static void RaiseChanged(Action onChanged)
	{
		try
		{
			onChanged?.Invoke();
		}
		catch (Exception ex)
		{
			Logger.LogWarning("[CoreWoodExtras] Failed to reload changed file: " + ex.Message);
		}
	}
}
