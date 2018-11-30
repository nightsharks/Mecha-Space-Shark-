﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickup : MonoBehaviour {

    public GameObject player;
    public GameObject currentObject;
    public static bool PickedUpShield;
    int distanceToDespawn = 1000;

    public AudioSource shieldPickupPlaySource;
    public AudioClip shieldClip;
    void Start()
    {      
        PickedUpShield = false;
        player = GameObject.FindWithTag("Player");
        shieldPickupPlaySource = player.GetComponent<AudioSource>();
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
            currentObject.SetActive(false);
            playInvincibilityNoise();

        }
    }


    void playInvincibilityNoise()
    {
        shieldPickupPlaySource.volume = .3f;
        shieldPickupPlaySource.PlayOneShot(shieldClip);
    }
}
