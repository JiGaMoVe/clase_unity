using UnityEngine;

public class SphereRaycast : MonoBehaviour
{
    [SerializeField] private Transform directionSphere;
    private IRaycast _raycast;
    
    private void Update()
    {
        Debug.DrawRay(transform.position, (directionSphere.position - transform.position) * 1000);

        if (Physics.Raycast(transform.position, directionSphere.position - transform.position, out RaycastHit hit, 1000, 1 << 8))
        {
            _raycast = hit.collider.GetComponent<IRaycast>();
            _raycast?.OnRaycastEnter();
        }
        else
        {
            if (_raycast != null)
            {
                _raycast.OnRaycastExit();
                _raycast = null;
            }
        }
    }
}
