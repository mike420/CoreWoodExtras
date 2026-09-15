using UnityEngine;

public class KeyUtils
{
	public static bool IgnoreKeyPresses(bool extra = false)
	{
		if (!extra)
		{
			if (!(ZNetScene.instance == null) && !(Player.m_localPlayer == null) && !Minimap.IsOpen() && !Console.IsVisible() && !TextInput.IsVisible() && !ZNet.instance.InPasswordDialog())
			{
				return Chat.instance?.HasFocus() ?? false;
			}
			return true;
		}
		if (!(ZNetScene.instance == null) && !(Player.m_localPlayer == null) && !Minimap.IsOpen() && !Console.IsVisible() && !TextInput.IsVisible() && !ZNet.instance.InPasswordDialog())
		{
			Chat instance = Chat.instance;
			if (((object)instance == null || !instance.HasFocus()) && !StoreGui.IsVisible() && !InventoryGui.IsVisible() && !Menu.IsVisible())
			{
				return TextViewer.instance?.IsVisible() ?? false;
			}
		}
		return true;
	}

	public static bool CheckKeyDown(string value)
	{
		try
		{
			string[] array = value.Split(new char[1] { ',' });
			for (int i = 0; i < array.Length; i++)
			{
				if (Input.GetKeyDown(array[i].ToLower()))
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool CheckKeyUp(string value)
	{
		try
		{
			string[] array = value.Split(new char[1] { ',' });
			for (int i = 0; i < array.Length; i++)
			{
				if (Input.GetKeyUp(array[i].ToLower()))
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool CheckKeyHeld(string value, bool req = true)
	{
		try
		{
			string[] array = value.Split(new char[1] { ',' });
			for (int i = 0; i < array.Length; i++)
			{
				if (Input.GetKey(array[i].ToLower()))
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return !req;
	}
}
