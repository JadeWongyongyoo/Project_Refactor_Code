using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShowObstacle : MonoBehaviour
{
    public List<GameObject> obstacleList = new List<GameObject>();
    private int randomNumber;


    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, obstacleList.Count);
        obstacleList[randomNumber].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        obstacleListCount();


    }
    void AutoSpawn()
    {
        for (int i = 0; i < obstacleList.Count; i++)
        {
            if (obstacleList[i].activeInHierarchy == true)
            {
                break;
            }
            else
            {
                AutoSpawnObstacle(i);
            }

        }
    }
    void obstacleListCount()
    {
        for (int i = 0; i < obstacleList.Count; i++)
        {
            if (obstacleList[i].activeInHierarchy == true)
            {
                break;
            }
            else
            {
                obstacle(i);
            }

        }
    }
    void obstacle(int i)
    {
        if (i == obstacleList.Count - 1)
        {
            Invoke("AutoSpawn", 5f);
        }
    }
    void AutoSpawnObstacle(int i)
    {
        if (i == obstacleList.Count - 1)
        {
            randomNumber = Random.Range(0, obstacleList.Count);
            obstacleList[randomNumber].SetActive(true);
        }
    }
}
    
