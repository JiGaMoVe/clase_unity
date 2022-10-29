using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float velocity = 4;
    [SerializeField] private Rigidbody rigidBody;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * velocity;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * velocity;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * velocity;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * velocity;
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            rigidBody.AddForce(Vector3.up * 300);
        }
    }
}
