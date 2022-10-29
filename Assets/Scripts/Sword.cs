using UnityEngine;

public class Sword : MonoBehaviour
{
    private Renderer _renderer;
    
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void ChangeColor(Color color)
    {
        _renderer.material.color = color;
        GetComponentInParent<Shoot>().GetComponent<Renderer>().material.color = Color.blue;
    }
}
