using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerReciever : MonoBehaviour
{
    public Action onTriggerEnter;

    public void NotifyOnTriggerEnter()
    {
        onTriggerEnter?.Invoke();
    }
}
