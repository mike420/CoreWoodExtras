using System.Collections.Generic;
using UnityEngine;

namespace CoreWoodExtras
{

    internal class Scarecrow : MonoBehaviour, Hoverable, Interactable
    {
        private const string ActiveKey = "mm_scarecrow_active";

        public string m_name = "Scarecrow";

        public float m_useDistance = 2f;

        public float m_hoverOffset = 0f;

        public bool m_checkGuardStone = true;

        public Transform m_attachPoint = null;

        public GameObject m_forcefield = null;

        public EffectList m_activateSFX = null;

        public EffectList m_deactivateSFX = null;

        // When false the scarecrow is inert: no forcefield and no interaction.
        // Mirrors MainConfig.EnableProtectionToggle, refreshed by ApplySettings.
        public bool m_toggleEnabled = true;

        private static readonly List<Scarecrow> Instances = new List<Scarecrow>();

        private ZNetView m_nview;

        private bool m_active = true;

        private Renderer[] m_renderers = new Renderer[0];

        private bool[] m_rendererDefaults = new bool[0];

        // The no-monsters area under the forcefield, and the object it lives on.
        private EffectArea m_area;

        private GameObject m_areaHost;

        // What the area was set up with in the prefab, so an identical one can be added again after it is destroyed.
        private EffectArea.Type m_areaType;

        private string m_areaStatusEffect = "";

        private bool m_areaPlayerOnly;

        // False for the placement ghost, which has no valid ZDO and must not protect anything.
        private bool m_live;

        private void Awake()
        {
            if (m_forcefield != null)
            {
                m_renderers = m_forcefield.GetComponentsInChildren<Renderer>(true);
                m_rendererDefaults = new bool[m_renderers.Length];
                for (int i = 0; i < m_renderers.Length; i++)
                {
                    m_rendererDefaults[i] = m_renderers[i].enabled;
                }

                m_area = m_forcefield.GetComponentInChildren<EffectArea>(true);
                if (m_area != null)
                {
                    m_areaHost = m_area.gameObject;
                    m_areaType = m_area.m_type;
                    m_areaStatusEffect = m_area.m_statusEffect;
                    m_areaPlayerOnly = m_area.m_playerOnly;
                }
            }

            m_nview = GetComponentInParent<ZNetView>();
            m_live = m_nview != null && m_nview.IsValid();
            if (m_live)
            {
                m_active = m_nview.GetZDO().GetBool(ActiveKey, true);
                InvokeRepeating(nameof(SyncState), 0.5f, 0.5f);
            }
            ApplySettings();
        }

        private void OnEnable()
        {
            Instances.Add(this);
        }

        private void OnDisable()
        {
            Instances.Remove(this);
        }

        // Re-applies the config to every live scarecrow.
        public static void ApplySettingsToAll()
        {
            foreach (Scarecrow scarecrow in Instances)
            {
                scarecrow.ApplySettings();
            }
        }

        private void ApplySettings()
        {
            m_toggleEnabled = MainConfig.EnableProtectionToggle.Value;
            bool show = MainConfig.ShowForcefield.Value;
            for (int i = 0; i < m_renderers.Length; i++)
            {
                if (m_renderers[i] != null)
                {
                    m_renderers[i].enabled = show && m_rendererDefaults[i];
                }
            }
            ApplyState(m_active);
        }

        private void SyncState()
        {
            if (m_nview == null || !m_nview.IsValid())
            {
                return;
            }
            bool active = m_nview.GetZDO().GetBool(ActiveKey, true);
            if (active != m_active)
            {
                ApplyState(active);
            }
        }

        private void ApplyState(bool active)
        {
            m_active = active;
            SetProtection(m_live && m_toggleEnabled && active);
        }

        private void SetProtection(bool protect)
        {
            if (m_forcefield == null)
            {
                return;
            }
            if (protect)
            {
                // A no-monsters area registers itself when it wakes up, which is when the forcefield first turns on.
                m_forcefield.SetActive(true);
                if (m_area == null && m_areaHost != null)
                {
                    // It was removed when protection was switched off, so a fresh one is needed. EffectArea reads its
                    // type and status effect in Awake, and AddComponent runs Awake straight away, so the component is
                    // added while its object is inactive and only switched on once it is set up.
                    m_areaHost.SetActive(false);
                    m_area = m_areaHost.AddComponent<EffectArea>();
                    m_area.m_type = m_areaType;
                    m_area.m_statusEffect = m_areaStatusEffect;
                    m_area.m_statusEffectHash = m_areaStatusEffect.GetStableHashCode();
                    m_area.m_playerOnly = m_areaPlayerOnly;
                    m_areaHost.SetActive(true);
                }
            }
            else
            {
                // EffectArea keeps no-monsters areas in a static list that is only cleared when the component is
                // destroyed, so switching the object off would leave the protection in place. Destroy it instead.
                if (m_area != null)
                {
                    Destroy(m_area);
                    m_area = null;
                }
                m_forcefield.SetActive(false);
            }
        }

        public string GetHoverText()
        {
            if (!m_toggleEnabled)
            {
                return "";
            }
            Player player = Player.m_localPlayer;
            if (player != null && !InUseDistance(player))
            {
                return Localization.instance.Localize("<color=#888888>$piece_toofar</color>");
            }
            if (m_checkGuardStone && !PrivateArea.CheckAccess(transform.position, 0f, flash: false))
            {
                return Localization.instance.Localize(m_name + "\n<color=#888888>$text_no_access_mm</color>");
            }
            string state = m_active ? "$text_forcefield_enable_mm" : "$text_forcefield_disable_mm";
            return Localization.instance.Localize(m_name + "\n[<color=yellow><b>$KEY_Use</b></color>] $piece_use\n" + state);
        }

        public string GetHoverName()
        {
            return m_name;
        }

        public bool Interact(Humanoid human, bool hold, bool alt)
        {
            if (hold || !m_toggleEnabled)
            {
                return false;
            }
            Player player = human as Player;
            if (player == null || !InUseDistance(player))
            {
                return false;
            }
            if (m_nview == null || !m_nview.IsValid())
            {
                return false;
            }
            if (m_checkGuardStone && !PrivateArea.CheckAccess(transform.position))
            {
                player.Message(MessageHud.MessageType.Center, "$text_no_access_mm");
                return true;
            }

            bool active = !m_nview.GetZDO().GetBool(ActiveKey, true);
            m_nview.ClaimOwnership();
            m_nview.GetZDO().Set(ActiveKey, active);
            ApplyState(active);

            EffectList sfx = active ? m_activateSFX : m_deactivateSFX;
            sfx?.Create(transform.position, transform.rotation);
            player.Message(MessageHud.MessageType.Center, active ? "$text_forcefield_enable_mm" : "$text_forcefield_disable_mm");
            return true;
        }

        public bool UseItem(Humanoid user, ItemDrop.ItemData item)
        {
            return false;
        }

        private bool InUseDistance(Humanoid human)
        {
            Transform reference = m_attachPoint != null ? m_attachPoint : transform;
            return Vector3.Distance(human.transform.position, reference.position) < m_useDistance;
        }

        public float GetHoverOffset()
        {
            return m_hoverOffset;
        }
    }
}
