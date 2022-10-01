using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class characterControl : MonoBehaviour
{
    public int jumpCount = 0;
    private bool isSlide = false;
    private Rigidbody2D rigidbody;
    public int jumpForce = 500;
    private Animator anim;
    public GameObject anim_Object;
    private ItemList itemList;
    private Collider2D collider;
    private float StateValue;
    private float usingItemValue;

    public GameObject itemBangFai, itemTukTuk,itemBanana;
    public GameObject spawnPoint_Front;
    public GameObject spawnPoint_Back;

    public AudioSource jumpSound, slideSound;

    public bool OnGround;
    private bool isRun;
    
    private EnvironmentHitPlayer environment;
    public BoxCollider2D collider2D;

    public SpriteRenderer normalform;
    public Sprite tuktukform;

    public GameObject blank;

    private PickUpScript pickupscript;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        environment = GetComponent<EnvironmentHitPlayer>();
        anim =anim_Object.GetComponent<Animator>();
        collider2D = GetComponent<BoxCollider2D>();
        normalform = anim_Object.GetComponent<SpriteRenderer>();
        itemList = GameObject.FindGameObjectWithTag("ItemList").GetComponent<ItemList>();
        pickupscript = gameObject.GetComponent<PickUpScript>();
        AnimationSetTrigger("isIdle");
    }

    void AnimationSetTrigger(string pararmeterName)
    {
        anim.SetTrigger(pararmeterName);
    }

    // Update is called once per frame
    void Update()
    {
        Player1_Control();
        Player2_Control();

        if (StateValue >-0.5 && StateValue <=0 && OnGround == true)
            Run();

        AnimationSetBool("isRun", isRun);
        AnimationSetBool("OnGround", OnGround);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        OnGround = true;
        Run();
    }

    void Run()
    {
        jumpCount = 0;
        isRun = true;
        collider2D.size = new Vector2(0.35f, 1.35f);
        collider2D.offset = new Vector2(-0.2f, 0f);
    }

    void Player1_Control()
    {
        if (ShouldJump1())
            jump();
        if (ShouldSlide1())
            slide();
        if (ShouldUseItem1())
            useItem1();
    }

    public bool ShouldJump1()
    {
        return StateValue <= 1 && StateValue > 0 && OnGround == true && gameObject.CompareTag("Player1");
    }

    public bool ShouldSlide1()
    {
        return StateValue < 0 && StateValue >= -1 && OnGround == true && gameObject.CompareTag("Player1");
    }

    public bool ShouldUseItem1()
    {
        return usingItemValue != 0 && gameObject.CompareTag("Player1");
    }

    void Player2_Control()
    {
        if (ShouldJump2())
            jump();
        if (ShouldSlide2())
            slide();
        if (ShouldUseItem2())
            useItem2();
    }

    public bool ShouldJump2()
    {
        return StateValue <= 1 && StateValue > 0 && OnGround == true && gameObject.CompareTag("Player2");
    }

    public bool ShouldSlide2()
    {
        return StateValue < 0 && StateValue >= -1 && OnGround == true && gameObject.CompareTag("Player2");
    }

    public bool ShouldUseItem2()
    {
        return usingItemValue != 0 && gameObject.CompareTag("Player2");
    }

    void AnimationSetBool(string parameterName,bool parameterBool)
    {
        anim.SetBool(parameterName, parameterBool);
    }

    void jump()
    {
        jumpSound.Play();
        isRun = false;
        AnimationSetTrigger("Jump");
        rigidbody.AddForce(new Vector2(0f, jumpForce));
        OnGround = false;
    }

    void slide()
    {
        slideSound.Play();
        isRun = false;
        isSlide = true;
        AnimationSetTrigger("isSlide");
        collider2D.size = new Vector2(1.35f,0.35f);
        collider2D.offset = new Vector2(-0.2f, -0.15f);
    }

    public void idle()
    {
        isRun = !isRun;
        AnimationSetTrigger("isIdle");
    }

    void useItem1()
    {
        if(itemList.player1_Item[0].name == "BangFai")
        {
            Player1_BangFai();
            return;
        }
        if (itemList.player1_Item[0].name == "Tuktuk")
        {
            Player1_Tuktuk();
            return;
        }
        if (itemList.player1_Item[0].name == "banana")
        {
            Player1_banana();
            return;
        }
        Debug.Log("Error");
    }

    void Player1_BangFai()
    {
        PLayer1_AlreadyHasItem();
        Instantiate(itemBangFai, spawnPoint_Front.transform.position, itemBangFai.transform.rotation);
    }

    void Player1_Tuktuk()
    {
        PLayer1_AlreadyHasItem();
        anim.enabled = false;
        environment.knockBackDistant = 0;
        TranformToTukTuk();
        Invoke("enableEnvironment", 5.0f);
    }

    void Player1_banana()
    {
        PLayer1_AlreadyHasItem();
        Instantiate(itemBanana, spawnPoint_Back.transform.position, itemBanana.transform.rotation);
    }

    void PLayer1_AlreadyHasItem()
    {
        itemList.player1_Item[0] = blank;
        pickupscript.itemCount = false;
    }

    void useItem2()
    {
        if (itemList.player2_Item[0].name == "BangFai")
        {
            Player2_BangFai();
            return;
        }
        if (itemList.player2_Item[0].name == "Tuktuk")
        {
            Player2_Tuktuk();
            return;
        }
        if (itemList.player2_Item[0].name == "banana")
        {
            Player2_banana();
            return;
        }    
    }

    void Player2_BangFai()
    {
        Player2_AlreadyHasItem();
        Instantiate(itemBangFai, spawnPoint_Front.transform.position, itemBangFai.transform.rotation);
    }

    void Player2_Tuktuk()
    {
        Player2_AlreadyHasItem();
        anim.enabled = false;
        environment.knockBackDistant = 0;
        TranformToTukTuk();
        Invoke("enableEnvironment", 5.0f);
    }

    void Player2_banana()
    {
        Player2_AlreadyHasItem();
        Instantiate(itemBanana, spawnPoint_Back.transform.position, itemBanana.transform.rotation);
    }

    void Player2_AlreadyHasItem()
    {
        itemList.player2_Item[0] = blank;
        pickupscript.itemCount = false;
    }

    void enableEnvironment()
    {
        environment.iFrame();
        anim.enabled = true;
    }
    void TranformToTukTuk()
    {
        normalform.sprite = tuktukform;
    }

    public void UpAndDownControl(InputAction.CallbackContext context)
    {
        StateValue = context.ReadValue<float>();
    }

    public void UsingItemControl(InputAction.CallbackContext context)
    {
        usingItemValue = context.ReadValue<float>();
    }
}
