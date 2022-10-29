using UnityEngine;
using Random = UnityEngine.Random;

public class Shoot : MonoBehaviour
{
    [SerializeField] private int maxAmmo;
    [SerializeField] private GameObject bulletPrefab;
    private BulletCount _count;
    private int _ammo;

    private void Start()
    {
        _count = FindObjectOfType<BulletCount>();
        _ammo = maxAmmo;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_ammo > 0)
            {
                var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                _ammo--;
                _count.AmmoChange(_ammo);
                bullet.GetComponent<Renderer>().material.color = Color.blue;
                Destroy(bullet, 2f);
            }
        }
    }
}
