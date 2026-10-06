using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

namespace CoreWoodExtras;

public class RainBlocker : MonoBehaviour
{
	private static readonly List<Renderer> s_blockers = new List<Renderer>();

	private Renderer m_renderer;

	private void Awake()
	{
		m_renderer = GetComponent<Renderer>();
		if (m_renderer)
		{
			m_renderer.enabled = false;
		}
	}

	private void OnEnable()
	{
		if (m_renderer)
		{
			s_blockers.Add(m_renderer);
		}
	}

	private void OnDisable()
	{
		if (m_renderer)
		{
			m_renderer.enabled = false;
			s_blockers.Remove(m_renderer);
		}
	}

	private static void SetVisible(bool visible)
	{
		foreach (Renderer blocker in s_blockers)
		{
			blocker.enabled = visible;
		}
	}

	[HarmonyPatch(typeof(DepthCamera), nameof(DepthCamera.RenderDepth))]
	private static class DepthCameraRenderDepthPatch
	{
		private static void Prefix()
		{
			SetVisible(true);
		}

		private static void Finalizer()
		{
			SetVisible(false);
		}
	}
}
