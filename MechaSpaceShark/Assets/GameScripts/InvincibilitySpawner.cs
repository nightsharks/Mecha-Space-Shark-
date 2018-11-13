using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilitySpawner : MonoBehaviour {

    public GameObject invincibilityItem;
    public GameObject player;

    private float spawnMin = 1f; 
    private float spawnMax = 50f;

    private int distanceToDespawn = 300;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if (player.transform.position.x - distanceToDespawn > this.transform.position.x)
        {
            this.gameObject.SetActive(false);
        }
    }

    void Spawn()
    {
        Instantiate(invincibilityItem, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }
}
