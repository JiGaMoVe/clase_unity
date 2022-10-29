using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float velocity;
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.eulerAngles += Vector3.up * Time.deltaTime * velocity;
        }
        
        if (Input.GetKey(KeyCode.E))
        {
            transform.eulerAngles -= Vector3.up * Time.deltaTime * velocity;
        }
    }
}
