using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   // [SerializeField] private GameObject coinPrefab; //referans iþlemleri prefab soyasýndakilerden yapýlýr. sahnedeki bi objeyi sürüklersek null ref. hatasý alýrýz 
   // [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnRate = 5f;
    [SerializeField] private Transform[] spawnPositions;
    [SerializeField] private GameObject[] objects;
    private float nextSpawnTime = 0f;
    // Spawn Manager'ý sahnede çalýþmasý için bir de game objecxt olarak ekleyip. o objeyle birleþtirdik.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime  += spawnRate;
            // runtimeda obje oluþturmamýzý saðlýyor
            SpawnObject(objects[RandomObjectNumber()], spawnPositions[RandomSpawnNumber()]);

        }
             
    }

    private void SpawnObject(GameObject objectToSpawn, Transform newTransform)
    {
        Instantiate(objectToSpawn, newTransform.position, newTransform.rotation); //coinler spawnmanager neredeyse hangi konumdaysa orada oluþacak
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
