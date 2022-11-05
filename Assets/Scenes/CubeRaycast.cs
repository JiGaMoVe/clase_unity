using UnityEngine;

public class CubeRaycast : MonoBehaviour, IRaycast
{
    public void OnRaycastEnter()
    { 
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void OnRaycastExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
