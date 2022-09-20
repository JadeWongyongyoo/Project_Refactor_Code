using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShowObstacle : MonoBehaviour
{
    public List<GameObject> obstacleList = new List<GameObject>();
    private int randomNumber;

    void Start()
    {
        randomNumber = Random.Range(0, obstacleList.Count);
        obstacleList[randomNumber].SetActive(true);
    }

    void Update()
    {
        obstacleListCount();

    }

    void AutoSpawn()
    {
        for (int numberobstacle = 0; numberobstacle < obstacleList.Count; numberobstacle++)
        {
            if (obstacleList[numberobstacle].activeInHierarchy == true)
            {
                break;
            }
            else
            {
                AutoSpawnObstacle(numberobstacle);
            }

        }
    }

    void obstacleListCount()
    {
        for (int Obstaclechecknumber = 0; Obstaclechecknumber < obstacleList.Count; Obstaclechecknumber++)
        {
            if (obstacleList[Obstaclechecknumber].activeInHierarchy == true)
            {
                break;
            }
            else
            {
                obstacle(Obstaclechecknumber);
            }

        }
    }
    void obstacle(int Obstaclechecknumber)
    {
        if (Obstaclechecknumber == obstacleList.Count - 1)
        {
            Invoke("AutoSpawn", 5f);
        }
    }
    void AutoSpawnObstacle(int numberobstacle)
    {
        if (numberobstacle == obstacleList.Count - 1)
        {
            randomNumber = Random.Range(0, obstacleList.Count);
            obstacleList[randomNumber].SetActive(true);
        }
    }
}
    
