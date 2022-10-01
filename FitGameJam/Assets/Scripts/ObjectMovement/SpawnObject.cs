using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public float time = 3.0f;

    public float repeatRate = 4.0f;

    public GameObject Object;

    void Start()
    {
        InvokeRepeating("Spawn", time, repeatRate);
    }

    void Spawn()
    {
        Instantiate(Object, new Vector3(0, Random.Range(-4, 4), 0), Quaternion.identity);
    }

    void Update()
    {
        if (ShouldDestroy())     
            Destroy(this.gameObject);
            return; 
    }

    public bool ShouldDestroy()
    {
        return transform.position.x >= 200;
    }
}
