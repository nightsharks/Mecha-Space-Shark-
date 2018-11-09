using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    public Transform player;
    public Transform thisObject;
    public float distanceFromPlayer;
    public GameObject currentObject;

    public static bool CollideWithFood = false;

    //need to check objects position to make sure it's behind player

    // 0 is left and it gets smaller as you go to the right

    public void Update()
    {
        //if (playerController.playerLocationX > currentObject.transform.localPosition.x)
        //{
        //    Debug.Log("this works");
            
        //    currentObject.SetActive(false);
        //}
    }

    void LateUpdate()
    {
        CollideWithFood = false;
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            currentObject.SetActive(false);
            CollideWithFood = true;
        }
    }
}
