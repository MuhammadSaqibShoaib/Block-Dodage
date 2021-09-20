using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawnner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject blockprefb;
    private float TimeToSpawn = 2f;
    public float TimeBetweenWaves = 1f;
    
    void Update()
    {
        if (Time.time >= TimeToSpawn)
        {
            BoxSpawn();
            TimeToSpawn =Time.time + TimeBetweenWaves;
        }
    }
        
    

    void BoxSpawn()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockprefb, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
