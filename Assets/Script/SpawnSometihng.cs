using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSometihng : MonoBehaviour
{
    public GameObject[] animals;
    //public int animalIndex;
    private int randomAnimalIndex;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        randomAnimalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-20, 20), 0, 10f);
        Instantiate(animals[randomAnimalIndex], spawnPosition, animals[randomAnimalIndex].transform.rotation);
    }
}
