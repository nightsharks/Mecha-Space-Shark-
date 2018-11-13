using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject player;
    public GameObject currentObject;

    public int distanceToDespawn = 900;
    public static bool CollideWithAsteroid = false;

    public void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void Update()
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
            if (ShieldPickup.PickedUpShield == false)
            {
                CollideWithAsteroid = true;
            }
            else
            {
                Debug.Log("collission false");
                CollideWithAsteroid = false;
            }
        }
    }

}
