using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DK_BarrelShooter : MonoBehaviour
{
    //public float delayBetweenShots = 2f;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 2f;

    public GameObject objectToSpawn;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
        //SpawnObject();
    }

    private IEnumerator SpawnCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnObject();
        }
    }

    public void SpawnObject()
    {
        GameObject spawnedObject = Instantiate(objectToSpawn, transform.position, transform.rotation);
        //Invoke("SpawnObject", delayBetweenShots);
        spawnedObject.tag = "Barrel";
        
    }
}