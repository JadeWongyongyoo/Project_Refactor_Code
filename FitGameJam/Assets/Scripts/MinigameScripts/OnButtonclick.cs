using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonclick : MonoBehaviour
{
    public Action onButtonclick;
    
    public void NotifyonButtonclick()
    {
        onButtonclick?.Invoke();
    }
}
