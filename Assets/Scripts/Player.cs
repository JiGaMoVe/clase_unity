using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float health;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HealthPackage"))
        {
            health += 20;
            Destroy(other.gameObject);
        }
    }
}
