using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackSword, spawnPoint;
    [SerializeField] OnButtonclick onButtonEnter;
    private void Start()
    {
        onButtonEnter.onButtonclick += spawnSword;
    }
    void spawnSword()
    {
        Instantiate(attackSword, spawnPoint.transform.position, attackSword.transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss"))
        {
            onButtonEnter.onButtonclick -= spawnSword;
        }
    }
}
