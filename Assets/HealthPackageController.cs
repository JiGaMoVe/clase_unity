using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class HealthPackageController : MonoBehaviour
{
    [SerializeField] private float timeBetween;
    [SerializeField] private GameObject healthPackage;

    private IEnumerator _coroutine;

    private void Start()
    {
        _coroutine = Instantiate();
        StartCoroutine(_coroutine);
    }

    private IEnumerator Instantiate()
    {
        while (true)
        {
            yield return new WaitForSeconds(.4f);
            Instantiate(healthPackage, new Vector3(Random.Range(-15f, 15f), 4.2f, Random.Range(-15f, 15f)), Quaternion.identity);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            StopCoroutine(_coroutine);
        }
    }
}
