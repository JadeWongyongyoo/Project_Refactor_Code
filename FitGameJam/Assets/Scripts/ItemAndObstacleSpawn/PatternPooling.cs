using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPooling : MonoBehaviour
{
    public List<GameObject> poolObjectList = new List<GameObject>();
    public PoolObject poolObject = new PoolObject();

    private List<GameObject> objectInTime = new List<GameObject>();
    private bool delaySpawn;

    void Start()
    {
        for (int numberelements = 0; numberelements < poolObjectList.Count; numberelements++)
        {
            poolObject.AddGameObjectTypeToPool(poolObjectList[numberelements]);
        }
        poolObject.CreateGameObjectFromPool();
    }

    void FixedUpdate()
    {
        bool isSpawned = poolObject.SpawnStatus();
        StartSpawnWhenTrue(isSpawned);
    }

    void StartSpawnWhenTrue(bool isSpawned)
    {
        if (isSpawned == false && delaySpawn == false)
        {
            StartCoroutine(ObjectSpawnFrequency());
            delaySpawn = true;
        }
        else if (isSpawned == true)
        {
            // StartCoroutine(Stop());
        }
    }
    
    IEnumerator ObjectSpawnFrequency()
    {
        for (int Numberfrequenciesobjects = 0; Numberfrequenciesobjects < 10; Numberfrequenciesobjects++)
        {
            RandomObjectSpawner();
            yield return new WaitForSeconds(3f);
        }
    }

    public void RandomObjectSpawner()
    {
        int randomNumber = Random.Range(0, poolObjectList.Count);
        SpawnRandomObject(randomNumber);
    }

    void SpawnRandomObject(int randomNumber)
    {
        if (poolObject.SpawnStatusSelection(randomNumber) == false)
        {
            objectInTime.Add(poolObject.EnableObjectInPool(randomNumber));
            StartCoroutine(Stop());
        }
        else
        {
            RandomObjectSpawner();
        }
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(30f);
        objectInTime[0].transform.position = gameObject.transform.position;
        poolObject.DisableObjectInPool(objectInTime[0]);
        objectInTime.RemoveAt(0);
        RandomObjectSpawner();
    }
}
