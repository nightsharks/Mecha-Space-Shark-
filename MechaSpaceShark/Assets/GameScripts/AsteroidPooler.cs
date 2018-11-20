using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidPooler : MonoBehaviour {

    public static AsteroidPooler SharedInstance;
    public List<GameObject> pooledObjectsAsteroid;
    public GameObject objectToPool;
    public GameObject objectToPool2;
    public GameObject objectToPool3;
    public int amountToPool;

    public GameObject player;

    float timer;
    float randomF = 3; //don't ask

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjectsAsteroid = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            int random = Random.Range(0, 3);
            if(random == 1)
            {
                GameObject obj = (GameObject)Instantiate(objectToPool);
                obj.SetActive(false);
                pooledObjectsAsteroid.Add(obj);
            }
            else if (random == 2)
            {
                GameObject obj2 = (GameObject)Instantiate(objectToPool2);
                obj2.SetActive(false);
                pooledObjectsAsteroid.Add(obj2);
            }
            else //if (random == 3)
            {
                GameObject obj3 = (GameObject)Instantiate(objectToPool3);
                obj3.SetActive(false);
                pooledObjectsAsteroid.Add(obj3);               
            }
            
                    
            
        }

    }

    public void Update()
    {
        //Debug.Log("object pooler script");
        timer = timer + Time.deltaTime;
        if (timer >= randomF)
        {
            timer = 0;
            randomF = Random.Range(1.0f, 1.5f);
            Spawn();
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjectsAsteroid.Count; i++)
        {
            if (!pooledObjectsAsteroid[i].activeInHierarchy)
            {
                return pooledObjectsAsteroid[i];
            }
            
        }
        return null;
    }

    public void Spawn()
    {
        GameObject rock = SharedInstance.GetPooledObject();

        if (rock != null)
        {
            rock.transform.position = new Vector2(player.transform.position.x + 1300, Random.Range(-500, 300));
            rock.SetActive(true);
        }

    }

}
