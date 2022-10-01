using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackSword, spawnPoint;

    public void spawnSword()
    {
        Instantiate(attackSword, spawnPoint.transform.position, attackSword.transform.rotation);
    }

}
