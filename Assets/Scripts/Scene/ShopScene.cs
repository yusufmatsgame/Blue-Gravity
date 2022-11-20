using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider2D))]
public class ShopScene : MonoBehaviour
{
    [SerializeField] private GameObject shopMenu = null;
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        Player player = collision.GetComponent<Player>();

        if (player !=null)
        {
            shopMenu.SetActive(true);
        }
    }
}
