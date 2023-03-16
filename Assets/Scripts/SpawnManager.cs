using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   // [SerializeField] private GameObject coinPrefab; //referans i�lemleri prefab soyas�ndakilerden yap�l�r. sahnedeki bi objeyi s�r�klersek null ref. hatas� al�r�z 
   // [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnRate = 5f;
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject[] objects;
    private float nextSpawnTime = 0f;
    // Spawn Manager'� sahnede �al��mas� i�in bir de game objecxt olarak ekleyip. o objeyle birle�tirdik.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime  += spawnRate;
            // runtimeda obje olu�turmam�z� sa�l�yor
            SpawnObject(objects[RandomObjectNumber()], spawnPositions[RandomSpawnNumber()]);

        }
             
    }

    private void SpawnObject(GameObject objectToSpawn, Transform newTransform)
    {
        Instantiate(objectToSpawn, newTransform.position, newTransform.rotation); //coinler spawnmanager neredeyse hangi konumdaysa orada olu�acak
    }
    private int RandomSpawnNumber()
    {
        return Random.Range(0, spawnPositions.Length);
    }
    private int RandomObjectNumber()
    {
        return Random.Range(0, objects.Length);
    }
}
