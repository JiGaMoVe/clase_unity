using UnityEngine;

public class CapsuleRaycast : MonoBehaviour, IRaycast
{
    public void OnRaycastEnter()
    {
        Destroy(gameObject);
    }

    public void OnRaycastExit()
    {
    }
}
