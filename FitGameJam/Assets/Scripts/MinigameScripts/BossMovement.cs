using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BossMovement : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveX(-20f, 30f);
    }
}
