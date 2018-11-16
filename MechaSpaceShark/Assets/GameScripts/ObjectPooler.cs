using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjectsConsumable;
    public GameObject objectToPool;
    public int amountToPool;

    public GameObject player;

    float timer;
    float randomF;

//    public GameObject playerInstance;
//...
//SpawnedObject = GameObject.Instantiate(....);
//Consumable c = SpawnedObject.GetComponent<Consumable>();
//    c.player = playerInstance;

    void Awake()
    {
        SharedInstance = this; 
    }

    void Start()
    {
        pooledObjectsConsumable = new List<GameObject>();
        for(int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjectsConsumable.Add(obj);
        }

        randomF = 3;

    }

    public void Update()
    {
        //Debug.Log("object pooler script");
        timer = timer + Time.deltaTime;
        if (timer >= randomF)
        {
            timer = 0;
            randomF = Random.Range(0.0f, 2.0f);
            Spawn();
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjectsConsumable.Count; i++)
        {
            if (!pooledObjectsConsumable[i].activeInHierarchy)
            {
                return pooledObjectsConsumable[i];     
            }
        }
        return null;
    }

   public void Spawn()
    {
        GameObject food = SharedInstance.GetPooledObject();
        if (food != null)
        {
            food.transform.position = new Vector2(player.transform.position.x + 1500, Random.Range(-500, 500));

            food.SetActive(true);
        }

    }


}
