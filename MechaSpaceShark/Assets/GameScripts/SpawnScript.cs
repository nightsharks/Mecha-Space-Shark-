using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnScript : MonoBehaviour
{
    public GameObject player;
    public GameObject[] obj;
    public List <GameObject> active = new List <GameObject>();
    public List<GameObject> inactive = new List<GameObject>();

    float timer;
    float randomF;


    void Start()
    {
        Spawn();
        randomF = Random.Range(0.0f, 10.0f);
    }

    public void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= randomF)
        {
            timer = 0;
            randomF = Random.Range(0.0f, 1.0f);
            Spawn();
        }

    }

    void Spawn()
    {
        GameObject food = ObjectPooler.SharedInstance.GetPooledObject();
        if (food!= null)
        {
            food.transform.position = new Vector3(player.transform.position.x + Random.Range(-100, 400), player.transform.position.y + Random.Range(-100, 400), player.transform.position.z + Random.Range(-100, 400));
            food.SetActive(true);
            active.Add(food);
        }

    }

}