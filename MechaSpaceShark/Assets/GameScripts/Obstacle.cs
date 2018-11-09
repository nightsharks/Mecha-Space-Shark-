using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject currentObject;

    public static bool CollideWithAsteroid = false;

    public void Update()
    {
    
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CollideWithAsteroid = true;
        }
    }
}
