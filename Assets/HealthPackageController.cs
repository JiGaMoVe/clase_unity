using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class HealthPackageController : MonoBehaviour
{
    [SerializeField] private float timeBetween;
    [SerializeField] private GameObject healthPackage;

    private void Start()
    {
        InstantiateHealthPackage();
    }

    public void InstantiateHealthPackage()
    {
        StartCoroutine(Instantiate());
    }
    
    private IEnumerator Instantiate()
    {
        yield return new WaitForSeconds(timeBetween);
        var instance = Instantiate(healthPackage, transform);
        instance.transform.localPosition = new Vector3(Random.Range(-15f, 15f), 1, Random.Range(-15f, 15f));
    }
}
