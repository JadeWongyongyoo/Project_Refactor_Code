using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
