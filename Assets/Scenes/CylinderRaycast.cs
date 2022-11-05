using UnityEngine;

public class CylinderRaycast : MonoBehaviour, IRaycast
{
    public void OnRaycastEnter()
    {
        transform.localScale = new Vector3(2, 2, 2);
    }

    public void OnRaycastExit()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}
