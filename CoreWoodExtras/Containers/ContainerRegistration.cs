using UnityEngine;

namespace CoreWoodExtras.Containers;

// Added to every container that gets registered, so it is removed from UtilityMethods.RegisteredContainers whenever its
// object is destroyed. Containers that are not pieces (tombstones, cargo) and containers unloaded with their zone never
// go through the WearNTear destroy path, and would otherwise stay in the list.
internal class ContainerRegistration : MonoBehaviour
{
    internal Container Container;

    private void OnDestroy()
    {
        UtilityMethods.DeRegisterContainer(Container);
    }
}
