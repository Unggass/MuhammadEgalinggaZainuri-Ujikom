using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRange = 10;
    private float spawnPosZ = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 4f, 2f); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnAnimal();
        }
    }

    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
