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
    public bool isObjectBehind = false;

    //need to check objects position to make sure it's behind player

    // 0 is left and it gets smaller as you go to the right

    public void Update()
    {
        isObjectBehindPlayer();
        
        if (isObjectBehind)
        {
            currentObject.SetActive(false);
        }
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

    public void isObjectBehindPlayer()
    {
        if(currentObject.transform.localPosition.x > player.localPosition.x)
        {
            isObjectBehind = true;
            Debug.Log("object behind");
        }
    }
}
