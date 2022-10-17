using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawnSword : MonoBehaviour
{
    public float time = 3.0f;

    public float repeatRate = 4.0f;

    public GameObject attackSword, spawnPoint;

    void Start()
    {
        InvokeRepeating("Spawn", time, repeatRate);
    }

    void Spawn()
    {
        Instantiate(attackSword, spawnPoint.transform.position, attackSword.transform.rotation);
    }
}
