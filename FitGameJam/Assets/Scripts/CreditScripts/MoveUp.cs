using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveUp : MonoBehaviour
{

    void Update()
    {
        transform.DOMoveY(2200f, 20f);
    }
}
