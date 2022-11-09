using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayTimeCount : MonoBehaviour
{
    public GameObject winMenu;
    public Text CountTimeText;
    private TimeSpan timeUse;


    // Start is called before the first frame update
    void Start()
    {
        timeUse = new TimeSpan(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        TimeUpdate();
        CountTimeText.text = "Time: " + timeUse;
    }

    private void TimeUpdate()
    {
        if (winMenu.activeSelf == false)
        {
            timeUse += TimeSpan.FromSeconds(Time.deltaTime);

        }
    }
}
