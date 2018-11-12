using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickup : MonoBehaviour {

    public GameObject player;
    public GameObject currentObject;
    public static bool PickedUpShield;

    void Start()
    {      
        PickedUpShield = false;
        
        Debug.Log("started");
    }

    private void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PickedUpShield = true;          
            Debug.Log("picked up");
            currentObject.SetActive(false);
            Debug.Log("coro started");
        }
    }
}
