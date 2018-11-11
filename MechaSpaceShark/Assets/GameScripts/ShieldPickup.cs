using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickup : MonoBehaviour {

    public GameObject player;
    public GameObject currentObject;
    public static bool PickedUpShield;

    public void Start()
    {
        PickedUpShield = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickedUpShield = true;
            currentObject.SetActive(false);
        }
    }
}
