using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    private List <GameObject> gameObjectTypePoollist = new List <GameObject>();
    private List<GameObject> gameObjectsPoollist = new List<GameObject>();
    private const int MAX_OBJECT_AMOUNT = 12;
    
    public void AddGameObjectTypeToPool( GameObject PoolingObject)
    {
        gameObjectTypePoollist.Add(PoolingObject);
        gameObjectTypePoollist[gameObjectTypePoollist.Count-1].name = "Object Type : " + gameObjectTypePoollist.Count;
       Debug.Log("Added :"+ gameObjectTypePoollist.Count);
    }
    public void CreateGameObjectFromPool()
    {
        for (int OBJECT = 0; OBJECT < MAX_OBJECT_AMOUNT; OBJECT++)
        {
            CreateGameObject(OBJECT, OBJECT);
            Debug.Log("Added : " + gameObjectsPoollist[OBJECT].name + "Type : " + (OBJECT + 1));
        }
       
    }
    public void CreateRandomlyGameObjectFromPool()
    {
        for (int OBJECT = 0; OBJECT < MAX_OBJECT_AMOUNT; OBJECT++)
        {
            int RandomType = Random.Range(0, gameObjectTypePoollist.Count);
            CreateGameObject(RandomType, OBJECT);
            Debug.Log("Added : " + gameObjectsPoollist[OBJECT].name + " Type : " + (RandomType+1));
        }
    }
    public void CreateGameObject(int type,int number)
    {
        gameObjectsPoollist.Add(gameObjectTypePoollist[type]);
        gameObjectsPoollist[number].name = "Object : " + number.ToString();
        gameObjectsPoollist[number].SetActive(false);
        gameObjectsPoollist[number] = Instantiate(gameObjectsPoollist[number], gameObject.transform.position, gameObject.transform.rotation);
    }
    public GameObject EnableObjectInPool(int NumberObject)
    {
            gameObjectsPoollist[NumberObject].SetActive(true);
            return gameObjectsPoollist[NumberObject];
    }
    public void DisableObjectInPool(GameObject DisableGameObject)
    {
        for (int OBJECT = 0; OBJECT < MAX_OBJECT_AMOUNT; OBJECT++)
        {
            if (gameObjectsPoollist[OBJECT].name == DisableGameObject.name)
            {
                gameObjectsPoollist[OBJECT].SetActive(false);
                break;
            }
        }
    }
    public bool SpawnStatus()
    {
        for(int OBJECT = 0; OBJECT < MAX_OBJECT_AMOUNT; OBJECT++)
        {
            if (gameObjectsPoollist[OBJECT].activeInHierarchy == true)
            {
                
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    public bool SpawnStatusSelection(int numberObject)
    {

        if (gameObjectsPoollist[numberObject].activeInHierarchy == true)
        {
            return true;
        }
        return false;
        
    }
}
