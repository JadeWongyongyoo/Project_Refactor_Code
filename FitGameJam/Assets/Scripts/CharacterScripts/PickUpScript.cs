using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    private ItemList itemList;
    public bool itemCount = false;

    // Start is called before the first frame update
    void Start()
    {
        itemList = GameObject.FindGameObjectWithTag("ItemList").GetComponent<ItemList>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            PlayerItemListCheck(collision);
        }
    }

    void PlayerItemListCheck(Collider2D collision)
    {
        if (gameObject.CompareTag("Player1") && itemCount == false)
            Player1ItemCheck(collision);
        if (gameObject.CompareTag("Player2") && itemCount == false)
            Player2ItemCheck(collision);
    }

    void Player1ItemCheck(Collider2D collision)
    {
        ColliderPlayer1(collision);
        ObjectCollider(collision);
    }

    private void ColliderPlayer1(Collider2D collision)
    {
        itemList.player1_Item[0] = collision.gameObject;
        itemCount = true;
        itemList.changeImage_Item1();
    }

    private static void ObjectCollider(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
    }

    void Player2ItemCheck(Collider2D collision)
    {
        ColliderPlayer2(collision);
        ObjectCollider(collision);
    }

    private void ColliderPlayer2(Collider2D collision)
    {
        itemList.player2_Item[0] = collision.gameObject;
        itemCount = true;
        itemList.changeImage_Item2();
    }
}
