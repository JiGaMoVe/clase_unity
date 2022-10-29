using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health = 100;

    private void OnTriggerEnter(Collider other)
    {
        var bullet = other.GetComponent<Bullet>();
        if (bullet != null)
        {
            health -= 10;
            Destroy(bullet.gameObject);
        }       
    }
}
