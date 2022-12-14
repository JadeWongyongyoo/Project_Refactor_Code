using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossLifePoint : MonoBehaviour
{
    public Text BossLifeText;
    int LifeCounter = 50;

    [SerializeField] OnTriggerReciever onTriggerReciever;

    void Start()
    {
        onTriggerReciever.onTriggerEnter += ReduceBossLife;
    }

    // Update is called once per frame
    void Update()
    {
        BossLifeText.text = "Boss Life: " + LifeCounter;
        if(LifeCounter == 0)
        {
            onTriggerReciever.onTriggerEnter -= ReduceBossLife;
            Destroy(gameObject);
        }
    }

    void ReduceBossLife()
    {
        LifeCounter -= 1;
    }

}
