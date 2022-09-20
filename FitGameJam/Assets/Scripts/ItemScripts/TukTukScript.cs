using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TukTukScript : MonoBehaviour
{    
    void Start()
    {
        Invoke("destroyTukTuk", 5.0f);
    }

    void destroyTukTuk()
    {
        Destroy(gameObject);
    }    
}
