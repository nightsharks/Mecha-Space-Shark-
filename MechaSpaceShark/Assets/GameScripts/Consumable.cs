﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    public GameObject player;
    public GameObject currentObject;
    public float distanceFromPlayer;
    public float playerPositionX;
    public static bool CollideWithFood = false;
    public static bool isObjectBehind = false;
    private int distanceToDespawn = 900;


    public void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void Update()
    {
        //Debug.Log(playerPositionX);

        if (player.transform.position.x - distanceToDespawn > this.transform.position.x)
        {
            this.gameObject.SetActive(false);
        }

    }



    void LateUpdate()
    {
        CollideWithFood = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            currentObject.SetActive(false);
            CollideWithFood = true;
        }       
    }


}
