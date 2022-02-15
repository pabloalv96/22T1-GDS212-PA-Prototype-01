 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{

    [SerializeField] GameObject vehicle;
    [SerializeField] Transform spawnPos;
    [SerializeField] float minSeparationTime;
    [SerializeField] float maxSeparationTime;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(SpawnVehicle()); 
    }

    private IEnumerator SpawnVehicle()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));
            Instantiate(vehicle, spawnPos.position, Quaternion.identity);
        }

        
    }


}
