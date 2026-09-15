using System;
using System.IO;
using Jotunn;

namespace CoreWoodExtras;

internal class FileWatcher
{
	public static void WatchFileChanges(string path, Action onChanged)
	{
		FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
		string directoryName = Path.GetDirectoryName(path);
		string fileName = Path.GetFileName(path);
		fileSystemWatcher.Path = directoryName;
		fileSystemWatcher.Filter = fileName;
		fileSystemWatcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
		fileSystemWatcher.Changed += delegate
		{
			onChanged?.Invoke();
		};
		fileSystemWatcher.Deleted += delegate
		{
			onChanged?.Invoke();
		};
		fileSystemWatcher.Created += delegate
		{
			onChanged?.Invoke();
		};
		fileSystemWatcher.Renamed += delegate
		{
			onChanged?.Invoke();
		};
		fileSystemWatcher.EnableRaisingEvents = true;
	}

	public static void WatchTranslationChanges(string path, Action onChanged)
	{
		if (!Directory.Exists(CoreWoodPlugin.TranslationFilePath))
		{
			return;
		}
		try
		{
			WatchFileChanges(Path.Combine(path, "*.*"), onChanged);
		}
		catch
		{
			Logger.LogError("There was an issue loading Translation files!");
		}
	}
}
