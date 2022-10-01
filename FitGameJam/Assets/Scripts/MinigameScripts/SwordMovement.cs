using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SwordMovement : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveX(30f, 2.5f);
    }
}
