using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHittingBoss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        var tryGetReceiver = GetComponent<OnTriggerReciever>();
        if (tryGetReceiver != null)
        {
            tryGetReceiver.NotifyOnTriggerEnter();
        }
    }
}
