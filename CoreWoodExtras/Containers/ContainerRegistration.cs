using UnityEngine;

namespace CoreWoodExtras.Containers;

internal class ContainerRegistration : MonoBehaviour
{
    internal Container Container;

    private void OnDestroy()
    {
        UtilityMethods.DeRegisterContainer(Container);
    }
}
