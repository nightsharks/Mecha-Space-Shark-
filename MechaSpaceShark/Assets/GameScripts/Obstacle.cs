using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if (ShieldPickup.PickedUpShield)
        {
            this.GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            this.GetComponent<Collider2D>().enabled = true;
        }

        if (player.transform.position.x - distanceToDespawn > this.transform.position.x)
        {
            this.gameObject.SetActive(false);
        }
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        if (ShieldPickup.PickedUpShield)
        {
            CollideWithAsteroid = false;      
        }
        else
        {
            CollideWithAsteroid = true;
        }
        
    }


}
