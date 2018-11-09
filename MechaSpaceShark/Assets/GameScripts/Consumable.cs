using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    public GameObject player;
    public GameObject currentObject;

    public float distanceFromPlayer;
    public static bool CollideWithFood = false;
    public static bool isObjectBehind = false;

    //need to check objects position to make sure it's behind player

    // 0 is left and it gets smaller as you go to the right

    public void Update()
    {
        isObjectBehindPlayer();

        if (isObjectBehind)
        {
            currentObject.SetActive(false);
            Debug.Log("i think this works");
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
        if (currentObject.transform.position.x < player.transform.position.x)
        {
            isObjectBehind = true;
            Debug.Log("object behind");
        }
    }
}
