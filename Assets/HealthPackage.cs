using System;
using System.Collections;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class HealthPackage : MonoBehaviour
{
    private HealthPackageController _controller;
    private Vector3 _direction = Vector3.up;

    private void Start()
    {
        _controller = GetComponentInParent<HealthPackageController>();
        StartCoroutine(Rotation());
        StartCoroutine(ChangeRotation());
    }

    private IEnumerator ChangeRotation()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            _direction = Vector3.down;
            yield return new WaitForSeconds(10f);
            _direction = Vector3.up;
        }
    }
    
    private IEnumerator Rotation()
    {
        while (true)
        {
            transform.eulerAngles += _direction * Time.deltaTime * 30;
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            _controller.InstantiateHealthPackage();
        }
    }
}
