using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] itemPrefabs;
   [SerializeField] private Transform[] spawnPoints;
    private int[] itemCounts = {40 ,30, 20,20  };
    private float spawnTimer;
    private float timer;
    public int totalItemCount = 0;
    public int spawnedItems = 0; 
    [SerializeField]private float minSpawnTimer ; 
    [SerializeField]private float maxSpawnTimer ; 

    void Start()
    {
        spawnTimer = Random.Range(minSpawnTimer, maxSpawnTimer);
        for (int i = 0; i < itemCounts.Length; i++)
        {
            totalItemCount += itemCounts[i];
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTimer)
        {
            if (spawnedItems <=  totalItemCount)
                SpawnItem();
            timer = 0f;
            spawnTimer = Random.Range(minSpawnTimer, maxSpawnTimer);
        }
        if (spawnedItems == totalItemCount)
        {
            enabled = false;
        }
    }

    void SpawnItem()
    {
        int itemType;
        do
        {
            itemType = Random.Range(0, itemPrefabs.Length);
           
        } while (itemCounts[itemType] <= 0);

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(itemPrefabs[itemType], spawnPoints[spawnPointIndex].position, Quaternion.identity);
        itemCounts[itemType]--;
        spawnedItems++;
    }
}
