using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilitySpawner : MonoBehaviour {

    public GameObject player;

    private int random1 = 0;
    private int random2 = 300;
    int num1, num2;

    public static InvincibilitySpawner SharedInstance;
    public List<GameObject> invincibilityObjects;
    public GameObject objectToPool;
    private int amountToPool = 1;

   void Awake()
    {
       SharedInstance = this;
    }

   void Start()
    {
        invincibilityObjects = new List<GameObject>();
         for (int i = 0; i < amountToPool; i++)
         {
             GameObject obj = (GameObject)Instantiate(objectToPool);
             obj.SetActive(false);
             invincibilityObjects.Add(obj);
            }

    }

    public void Update()
     {

        num1 = Random.Range(random1, random2);
        num2 = Random.Range(random1, random2);

       // Debug.Log(num1 + " and " + num2);

        if (num1 == num2)
        {
            Spawn();
        }

    }

    public GameObject GetPooledObject()
         {
            for (int i = 0; i < invincibilityObjects.Count; i++)
            {
                if (!invincibilityObjects[i].activeInHierarchy)
                {
                    return invincibilityObjects[i];
                }
            }
            return null;
        }


    public void Spawn()
        {
            GameObject pickup = SharedInstance.GetPooledObject();
            if (pickup != null)
            {
                pickup.transform.position = new Vector2(player.transform.position.x + 1500, Random.Range(-500, 500));

                pickup.SetActive(true);
            }

        }
    }

