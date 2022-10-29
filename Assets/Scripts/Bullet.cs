using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float velocity;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocity);
    }
}
