using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnvironmentHitPlayer : MonoBehaviour
{
    public float knockBackDistant = -5.0f;
    public GameObject objectSprite;
    SpriteRenderer sprite;
    public ObjectMove moveBack;
    public characterControl characterControl;
    public GameObject WLcontroller;
    public AudioSource hitSound;

    private int hp_Character = 10;
    public Slider slider;

    void Start()
    {
        characterControl = gameObject.GetComponent<characterControl>();
        sprite = objectSprite.GetComponent<SpriteRenderer>();
        moveBack = gameObject.GetComponent<ObjectMove>();
        moveBack.enabled = false;
    }

    void Update()
    {
        slider.value = hp_Character;
        if (hp_Character <= 0)
            WLcontroller.GetComponent<WinOrLose>().Lose(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + knockBackDistant, gameObject.transform.position.y);
            if (ShouldKnockBack())
            {
                Sounds();
                hp_Character -= 1;
                iFrame();
            }
        }
        if (collision.CompareTag("BangFai") || collision.CompareTag("Banana"))
        {
            if (ShouldKnockBack())
            {
                Sounds();
                hp_Character -= 2;
                Stun();
                iFrame();
            }
        }
        if (characterControl.normalform.sprite == characterControl.tuktukform && collision.CompareTag("Enemy"))
        {
            SettuktukObject(collision);
        }
        if (collision.CompareTag("Artifact"))
        {
            SettuktukObject(collision);
            WLcontroller.GetComponent<WinOrLose>().Win(gameObject);
        }
    }
    public bool ShouldKnockBack()
    {
        return knockBackDistant != 0;
    }
    public void Sounds()
    {
        hitSound.Play();
    }
    public void SettuktukObject(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
    }
    public void iFrame()
    {
        knockBackDistant = 0;
        InvokeRepeating("iFrameAnimation", 0, 0.5f);
        Invoke("timeOutiFrame", 3f);
    }
    public void iFrameAnimation()
    {
        hideSprite();
        Invoke("showSprite", 0.25f);
    }
    void hideSprite()
    {
        sprite.enabled = false;
    }
    void showSprite()
    {
        sprite.enabled = true;
    }
    void timeOutiFrame()
    {
        CancelInvoke("iFrameAnimation");
        knockBackDistant = -5f;
    }
    void Stun()
    {
        Controls();
        moveBack.enabled = true;
        Invoke("timeOutStun", 3f);
    }
    void timeOutStun()
    {
        Controls();
        moveBack.enabled = false;
    }
    void Controls()
    {
        characterControl.idle();
    }
}