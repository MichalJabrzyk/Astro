using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{
    public GameObject parentObj;
    public GameObject asteroidPrefab;
    public float spawnPosX = 100f;
    public float spawnPosY = 100f;
    public int asteroidIndex = 10;
    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn initialization 
        ASpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Asteroid spawn procedure
    void ASpawn()
    {

        for (i= 0; i < asteroidIndex; i++)
        {

            Vector2 spawnPos = new Vector2(Random.Range(-spawnPosX, spawnPosX), Random.Range(-spawnPosY, spawnPosY));   
            Instantiate(asteroidPrefab, spawnPos, asteroidPrefab.transform.rotation);
            asteroidPrefab.tag = "Asteroid";
            asteroidPrefab.name = "Asteroid" + i;

        }

    }

}
