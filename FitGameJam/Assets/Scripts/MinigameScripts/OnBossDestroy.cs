using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBossDestroy : MonoBehaviour
{
    public GameObject RetryButton, MainmenuButton, Boss;

    // Start is called before the first frame update
    void Start()
    {
        RetryButton.SetActive(false);
        MainmenuButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Boss == null)
        {
            RetryButton.SetActive(true);
            MainmenuButton.SetActive(true);
        }
    }
}
