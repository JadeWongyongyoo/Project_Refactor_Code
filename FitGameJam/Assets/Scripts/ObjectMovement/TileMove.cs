using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : MonoBehaviour
{
    public GameObject Origin;
    public GameObject ObjectTo;
    public float speed;    
    void Update()
    {
        gameObject.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (gameObject.transform.position.x<-50)        
            gameObject.transform.position = Origin.transform.position;
    }
}
