using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeCount : MonoBehaviour
{
    public Text CountTimeText;
    private TimeSpan timeSpent;


    // Start is called before the first frame update
    void Start()
    {
        timeSpent = new TimeSpan(0, 0, 10);

    }

    // Update is called once per frame
    void Update()
    {
        TimeUpdate();
        CountTimeText.text = "TimeLeft: " + timeSpent;
    }

    private void TimeUpdate()
    {
        if (timeSpent.TotalSeconds > 0)
        {
            timeSpent -= TimeSpan.FromSeconds(Time.deltaTime);

        }
    }
}
