using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickup : MonoBehaviour {

    public GameObject player;
    public GameObject currentObject;
    public static bool PickedUpShield;
    int distanceToDespawn = 900;

    void Start()
    {      
        PickedUpShield = false;
        player = GameObject.FindWithTag("Player");
        Debug.Log("started");
    }

    private void Update()
    {
        if (player.transform.position.x - distanceToDespawn > this.transform.position.x)
        {
            this.gameObject.SetActive(false);
        }
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
