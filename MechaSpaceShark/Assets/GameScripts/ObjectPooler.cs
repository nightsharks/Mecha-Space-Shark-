using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjectsConsumable;
    public List<GameObject> pooledObjectsObstacle;
    public GameObject objectToPool;
    public int amountToPool;

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



}
