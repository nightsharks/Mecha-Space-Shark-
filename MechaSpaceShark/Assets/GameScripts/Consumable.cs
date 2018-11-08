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
    public bool isObjectBehindPlayer;

    //need to check objects position to make sure it's behind player

        // 0 is left and it gets smaller as you go to the right

    public void Update()
    {
        if (playerController.playerLocationX < currentObject.transform.localPosition.x)
        {
            Debug.Log("this works");
            currentObject.SetActive(false);
        }
    }
}
