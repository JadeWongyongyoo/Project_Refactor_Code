using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20.0f;
    void Update()
    {
        gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isShouldDestroyBullet(collision))
        Invoke("destroyBullet", 0.2f);
        
    }

    private bool isShouldDestroyBullet(Collider2D collision)
    {
        return collision.tag == "Player1" || collision.tag == "Player2" || collision.tag == "Wall";
    }

    private void destroyBullet()
    {
        Destroy(gameObject);
    }
}
